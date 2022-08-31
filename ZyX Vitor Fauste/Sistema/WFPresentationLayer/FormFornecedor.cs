using BusinessLogicalLayer;
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
    public partial class FormFornecedor : Form
    {
        private FornecedorBLL bll = new FornecedorBLL();

        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void DgvFornecedores_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            btnCadastrar.Visible = false;
            lblID.Text = "ID";
            SingleResponse<Fornecedor> singleFornecedor = bll.GetById(Convert.ToInt32
                                                          (this.dgvFornecedores.Rows[e.RowIndex].Cells[0].Value));

            if (!singleFornecedor.HasSuccess)
            {
                MessageBox.Show(singleFornecedor.Message);
                return;
            }

            DrawFormWithObject(singleFornecedor.Item);
            btnCadastrar.Visible = false;
            btnAtualizar.Visible = true;
        }

        private void DrawFormWithObject(Fornecedor fornecedor)
        {
            this.txtID.Text = fornecedor.ID.ToString();
            this.txtRazaoSocial.Text = fornecedor.RazaoSocial;
            this.txtTelefone.Text = fornecedor.Telefone;
            this.txtNomeContato.Text = fornecedor.NomeContato;
            this.txtEmail.Text = fornecedor.Email;
            this.txtCNPJ.Text = fornecedor.CNPJ;
        }
        
        private Fornecedor CreateObjectWithForm()
        {
            int temp;
            int.TryParse(txtID.Text, out temp);
            Fornecedor fornecedor = new Fornecedor()
            {
                ID = temp,
                CNPJ = txtCNPJ.Text,
                RazaoSocial = txtRazaoSocial.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text,
                NomeContato = txtNomeContato.Text
            };
            return fornecedor;
        }


        private void SincronizarGrid()
        {
            dgvFornecedores.Rows.Clear();
            dgvFornecedores.Refresh();
            dgvFornecedores.DataSource = null;
            List<Fornecedor> fornecedores = bll.GetAll().Dados;
            foreach (Fornecedor fornecedor in fornecedores)
            {
                dgvFornecedores.Rows.Add(fornecedor.ID, fornecedor.RazaoSocial, fornecedor.NomeContato, fornecedor.Telefone,
                                         fornecedor.CNPJ, fornecedor.Email);
            }
        }

        private void LimparCampos()
        {
            txtCNPJ.Clear();
            txtEmail.Clear();
            txtID.Clear();
            txtNomeContato.Clear();
            txtRazaoSocial.Clear();
            txtTelefone.Clear();
        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {
            SincronizarGrid();
            lblID.Text = "ID (gerado automaticamente)";
            btnAtualizar.Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnCadastrar.Visible = true;
            btnAtualizar.Visible = false;
            lblID.Text = "ID (gerado automaticamente)";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = CreateObjectWithForm();
            Response response = bll.Insert(fornecedor);
            if (!response.HasSuccess)
            {
                MessageBox.Show(response.Message);
                return;
            }
            MessageBox.Show(response.Message);
            SincronizarGrid();
            LimparCampos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = CreateObjectWithForm();
            Response response = bll.Update(fornecedor);
            MessageBox.Show(response.Message);
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
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.ID = Convert.ToInt32(txtID.Text);
            Response response = bll.Delete(fornecedor);
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
