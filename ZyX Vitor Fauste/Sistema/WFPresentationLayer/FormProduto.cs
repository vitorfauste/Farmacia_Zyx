using BusinessLogicalLayer;
using DataAccessLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPresentationLayer
{
    public partial class FormProduto : Form
    {
        private ProdutoBLL bll = new ProdutoBLL();
        public FormProduto()
        {
            InitializeComponent();
            this.dgvProdutos.CellDoubleClick += DgvProdutos_CellDoubleClick;
        }

        private void DgvProdutos_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            btnCadastrar.Visible = false;
            btnAtualizar.Visible = true;
            lblID.Text = "ID";
            LaboratorioBLL labBLL = new LaboratorioBLL();
            //labBLL.GetById(this.dgvProdutos.Rows[e.RowIndex].Cells[3].Value);
            SingleResponse<Produto> singleProduto = bll.GetById(Convert.ToInt32(this.dgvProdutos.Rows[e.RowIndex].Cells[0].Value));

            if (!singleProduto.HasSuccess)
            {
                MessageBox.Show(singleProduto.Message);
                return;
            }

            DrawFormWithObject(singleProduto.Item);
        }

        private void DrawFormWithObject(Produto produto)
        {
            this.txtID.Text = produto.ID.ToString();
            this.txtNome.Text = produto.Nome.ToString();
            this.txtDescricao.Text = produto.Descricao.ToString();
            this.txtQuantEstoque.Text = produto.QuantiaEmEstoque.ToString();
            this.mktxtLucro.Text = produto.Lucro.ToString();
            this.cbxLaboratorio.Text = produto.Laboratorio.RazaoSocial;
            this.txtValorUnitario.Text = produto.ValorUnitario.ToString();
        }

        private Produto CreateObjectWithForm()
        {
            int temp;
            int.TryParse(txtID.Text, out temp);
            Laboratorio laboratorio = new Laboratorio();
            laboratorio.ID = Convert.ToInt32(cbxLaboratorio.SelectedValue);
            Produto produto = new Produto()
            {
                ID = temp,
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                QuantiaEmEstoque = Convert.ToDouble(txtQuantEstoque.Text),
                Lucro = Convert.ToDouble(mktxtLucro.Text),
                ValorUnitario = Convert.ToDouble(txtValorUnitario.Text),
                Laboratorio = laboratorio
            };
            return produto;
        }

        private void LimparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtQuantEstoque.Clear();
            txtValorUnitario.Clear();
            mktxtLucro.Clear();
            cbxLaboratorio.SelectedIndex = -1;
            btnAtualizar.Visible = false;
            btnCadastrar.Visible = true;
            lblID.Text = "ID (gerado automaticamente)";
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            SincronizarGrid();
            btnAtualizar.Visible = false;
            lblID.Text = "ID (gerado automaticamente)";
            cbxLaboratorio.Items.Clear();
            cbxLaboratorio.ValueMember = "ID";
            cbxLaboratorio.DisplayMember = "RazaoSocial";
            LaboratorioDAL laboratorioDAL = new LaboratorioDAL();
            cbxLaboratorio.DataSource = laboratorioDAL.GetAll().Dados;
            cbxLaboratorio.SelectedIndex = -1;
        }

        private void SincronizarGrid()
        {
            dgvProdutos.Rows.Clear();
            dgvProdutos.Refresh();
            dgvProdutos.DataSource = null;
            List<Produto> produtos = bll.GetAll().Dados;
            foreach (Produto produto in produtos)
            {
                dgvProdutos.Rows.Add(produto.ID, produto.Nome, produto.Descricao, produto.Laboratorio.RazaoSocial, 
                                     produto.ValorUnitario.ToString("C2"), produto.QuantiaEmEstoque, produto.Lucro + "%");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produto produto = CreateObjectWithForm();
            Response response = bll.Insert(produto);
            if (!response.HasSuccess)
            {
                MessageBox.Show(response.Message);
                return;
            }
            MessageBox.Show(response.Message);
            SincronizarGrid();
            LimparCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Produto produto = CreateObjectWithForm();
            Response response = bll.Update(produto);
            if (!response.HasSuccess)
            {
                MessageBox.Show(response.Message);
                return;
            }
            MessageBox.Show(response.Message);
            SincronizarGrid();
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.ID = Convert.ToInt32(txtID.Text);
            Response response = bll.Delete(produto);
            if (!response.HasSuccess)
            {
                MessageBox.Show(response.Message);
                return;
            }
            MessageBox.Show(response.Message);
            SincronizarGrid();
            LimparCampos();
        }
    }
}
