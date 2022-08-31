using BusinessLogicalLayer;
using DataAccessLayer;
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

namespace WFPresentationLayer
{
    public partial class FormCompra : Form
    {
        FornecedorBLL fornecedorBLL = new FornecedorBLL();
        FormaPagamentoBLL formaPagamentoBLL = new FormaPagamentoBLL();
        CompraBLL compraBLL = new CompraBLL();
        Compra compra = new Compra();
        FormModalProdutosCompra formModal = new FormModalProdutosCompra();
        double valorTotal = 0;

        public FormCompra()
        {
            InitializeComponent();
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            if (SystemParameters.FuncionarioLogado != null)
            {
                lblUsuarioLogado.Text += " " + SystemParameters.FuncionarioLogado.Nome;
            }

            cbxFornecedor.Items.Clear();
            PopularCbxFornecedores();
            cbxFornecedor.SelectedIndex = -1;

            cbxFormaPagamento.Items.Clear();
            cbxFormaPagamento.ValueMember = "ID";
            cbxFormaPagamento.DisplayMember = "Nome";
            cbxFormaPagamento.DataSource = formaPagamentoBLL.GetAll().Dados;

            LimparCampos();
        }

        private void PopularCbxFornecedores()
        {
            BindingList<Fornecedor> bindingFornecedores = new BindingList<Fornecedor>();
            foreach (Fornecedor fornecedor in fornecedorBLL.GetAll().Dados)
            {
                bindingFornecedores.Add(fornecedor);
            }
            BindingSource bSource = new BindingSource();
            bSource.DataSource = bindingFornecedores;
            cbxFornecedor.ValueMember = "ID";
            cbxFornecedor.DisplayMember = "RazaoSocial";
            cbxFornecedor.DataSource = bSource;
        }

        

        private void LimparCampos()
        {
            cbxFornecedor.SelectedIndex = -1;
            cbxFormaPagamento.SelectedIndex = -1;
            txtCNPJFornecedor.Clear();
            txtNomeContatoFornecedor.Clear();
            txtRazaoSocialFornecedor.Clear();
            dgvProdutos.Rows.Clear();
            txtValorTotal.Text = 0.ToString("C2");
        }

        private void cbxFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFornecedor.SelectedIndex >= 0)
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor = fornecedorBLL.GetById(Convert.ToInt32(cbxFornecedor.SelectedValue)).Item;
                txtCNPJFornecedor.Text = fornecedor.CNPJ;
                txtNomeContatoFornecedor.Text = fornecedor.NomeContato;
                txtRazaoSocialFornecedor.Text = fornecedor.RazaoSocial;
            }
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            FormFornecedor formFornecedor = new FormFornecedor();
            formFornecedor.ShowDialog();
            PopularCbxFornecedores();
            cbxFornecedor.SelectedIndex = cbxFornecedor.Items.Count - 1;
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            formModal.ShowDialog();
            if (formModal.botaoClick)
            {
                dgvProdutos.Rows.Add(formModal.produtoCompra.Codigo.ToString(), formModal.produtoCompra.Nome, 
                                     formModal.produtoCompra.Descricao, formModal.produtoCompra.Laboratorio.RazaoSocial,
                                     formModal.produtoCompra.Lucro.ToString() + "%", formModal.produtoCompra.ValorUnitario.ToString("C2"), 
                                     formModal.produtoCompra.Quantidade.ToString());
                ItemTransacao itemCompra = new ItemTransacao();

                itemCompra.IDProduto = formModal.produtoCompra.Codigo;
                itemCompra.QuantidadeProduto = formModal.produtoCompra.Quantidade;
                itemCompra.ValorUnitario = formModal.produtoCompra.ValorUnitario;

                compra.Itens.Add(itemCompra);
                AtualizarValorTotalSomando();
            }
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows == null || dgvProdutos.Rows.Count <= 0)
            {
                MessageBox.Show("Para excluir um produto do carrinho, é necessário que ele " +
                                "esteja na lista abaixo. Caso já esteja, é necessário selecioná-lo nessa lista.");
                return;
            }
            DataGridViewRow rowCodigo = this.dgvProdutos.SelectedRows[0];
            compra.Itens.RemoveAt(rowCodigo.Index);
            dgvProdutos.Rows.RemoveAt(rowCodigo.Index);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (SystemParameters.FuncionarioLogado == null)
            {
                MessageBox.Show("Você deve estar logado para realizar uma compra.");
                return;
            }

            if ((cbxFormaPagamento.SelectedIndex >= 0) && 
                (cbxFornecedor.SelectedIndex >= 0) && 
                (dtpCompra.Value != null) &&
                (dgvProdutos.Rows.Count != 0))
            {
                compra.IDFornecedor = Convert.ToInt32(cbxFornecedor.SelectedValue);
                compra.FormaPagamento = Convert.ToInt32(cbxFormaPagamento.SelectedValue);
                compra.IDFuncionario = SystemParameters.FuncionarioLogado.ID;
                compra.DataTransacao = dtpCompra.Value;
                compra.ValorTotal = valorTotal;
                MessageBox.Show(compraBLL.Insert(compra).Message);
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Todos os dados da compra devem ser informados.");
            }

            //objeto compra preenchido com tudo que for necessário, incluindo os itens comprados
        }

        private void AtualizarValorTotalSomando()
        {
            valorTotal += formModal.produtoCompra.ValorUnitario * formModal.produtoCompra.Quantidade;
            txtValorTotal.Text = valorTotal.ToString("C2");
        }
        private void AtualizarValorTotalSubtraindo()
        {
            valorTotal -= formModal.produtoCompra.ValorUnitario * formModal.produtoCompra.Quantidade;
            txtValorTotal.Text = valorTotal.ToString("C2");
        }

        private void dgvProdutos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            AtualizarValorTotalSubtraindo();
        }
    }
}
