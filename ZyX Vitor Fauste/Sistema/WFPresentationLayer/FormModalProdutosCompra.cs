using BusinessLogicalLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFPresentationLayer.ViewModel;

namespace WFPresentationLayer
{
    public partial class FormModalProdutosCompra : Form
    {
        ProdutoBLL produtoBLL = new ProdutoBLL();
        LaboratorioBLL laboratorioBLL = new LaboratorioBLL();
        public ProdutoTransacao produtoCompra;
        public FormModalProdutosCompra()
        {
            InitializeComponent();
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnNovoProduto.Visible = false;
            btnVoltar.Visible = true;
            btnSelecionar.Visible = false;
            btnCadastrar.Visible = true;
            cbxProdutos.Enabled = false;
            cbxLaboratorio.Enabled = true;
            txtNome.ReadOnly = false;
            txtLucro.ReadOnly = false;
            txtDescricao.ReadOnly = false;
            txtEstoque.Text = "0";
        }

        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtEstoque.Clear();
            txtLucro.Clear();
            txtNome.Clear();
            txtValor.Clear();
            txtQuantidade.Clear();
            cbxLaboratorio.SelectedIndex = -1;
            cbxProdutos.SelectedIndex = -1;
        }

        private void PopularCbxProdutos()
        {
            BindingList<Produto> bindingProdutos = new BindingList<Produto>();
            foreach (Produto produto in produtoBLL.GetAll().Dados)
            {
                bindingProdutos.Add(produto);
            }
            BindingSource bSource = new BindingSource();
            bSource.DataSource = bindingProdutos;
            cbxProdutos.ValueMember = "ID";
            cbxProdutos.DisplayMember = "Nome";
            cbxProdutos.DataSource = bSource;
        }

        private void FormModalProdutos_Load(object sender, EventArgs e)
        {
            botaoClick = false;
            txtQuantidade.Select();
            btnVoltar.Visible = false;
            btnCadastrar.Visible = false;
            PopularCbxProdutos();

            cbxLaboratorio.ValueMember = "ID";
            cbxLaboratorio.DisplayMember = "RazaoSocial";
            cbxLaboratorio.DataSource = laboratorioBLL.GetAll().Dados;

            LimparCampos();
        }

        private void Voltar()
        {
            PopularCbxProdutos();
            LimparCampos();
            btnVoltar.Visible = false;
            btnSelecionar.Visible = true;
            btnCadastrar.Visible = false;
            btnNovoProduto.Visible = true;
            cbxProdutos.Enabled = true;
            cbxLaboratorio.Enabled = false;
            txtNome.ReadOnly = true;
            txtLucro.ReadOnly = true;
            txtEstoque.ReadOnly = true;
            txtDescricao.ReadOnly = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            Laboratorio lab = new Laboratorio();
            lab.ID = Convert.ToInt32(cbxLaboratorio.SelectedValue);
            produto.Nome = txtNome.Text;
            produto.Descricao = txtDescricao.Text;
            produto.Lucro = Convert.ToDouble(txtLucro.Text);
            produto.Laboratorio = lab;
            MessageBox.Show(produtoBLL.Insert(produto).Message);
            Voltar();
        }
        public bool botaoClick { get; set; }
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (cbxProdutos.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtValor.Text) || string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                MessageBox.Show("Quantidade e valor unitário devem ser preenchidos.");
                return;
            }
            
            Laboratorio lab = new Laboratorio();
            lab.ID = Convert.ToInt32(cbxLaboratorio.SelectedValue);
            lab.RazaoSocial = cbxLaboratorio.Text;
            produtoCompra = new ProdutoTransacao
            {
                Codigo = Convert.ToInt32(cbxProdutos.SelectedValue),
                Nome = txtNome.Text,
                Quantidade = Convert.ToDouble(txtQuantidade.Text),
                Descricao = txtDescricao.Text,
                Laboratorio = lab,
                Lucro = Convert.ToDouble(txtLucro.Text),
                ValorUnitario = Convert.ToDouble(txtValor.Text)
            };
            this.botaoClick = true;
            this.Close();

        }

        private void cbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProdutos.SelectedIndex >= 0)
            {
                Produto produto = new Produto();
                produto = produtoBLL.GetById(Convert.ToInt32(cbxProdutos.SelectedValue)).Item;
                txtDescricao.Text = produto.Descricao;
                txtEstoque.Text = produto.QuantiaEmEstoque.ToString();
                txtLucro.Text = produto.Lucro.ToString();
                txtNome.Text = produto.Nome;
                cbxLaboratorio.SelectedValue = produto.Laboratorio.ID;
            }
        }
    }
}
