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
    public partial class FormVenda : Form
    {
        ClienteBLL clienteBLL = new ClienteBLL();
        FormaPagamentoBLL formaPagamentoBLL = new FormaPagamentoBLL();
        VendaBLL vendaBLL = new VendaBLL();
        Venda venda = new Venda();
        ProdutoBLL produtoBLL = new ProdutoBLL();
        FormCliente formCliente = new FormCliente();
        double valorTotal = 0;
        public FormVenda()
        {
            InitializeComponent();
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            if (SystemParameters.FuncionarioLogado != null)
            {
                lblUsuarioLogado.Text += " " + SystemParameters.FuncionarioLogado.Nome;
            }

            txtValorTotal.Text = 0.ToString("C2");

            PopularCbxClientes();
            cbxCliente.SelectedIndex = -1;

            cbxFormaPagamento.Items.Clear();
            cbxFormaPagamento.ValueMember = "ID";
            cbxFormaPagamento.DisplayMember = "Nome";
            cbxFormaPagamento.DataSource = formaPagamentoBLL.GetAll().Dados;
            cbxFormaPagamento.SelectedIndex = -1;

            cbxProduto.Items.Clear();
            cbxProduto.ValueMember = "ID";
            cbxProduto.DisplayMember = "Nome";
            cbxProduto.DataSource = produtoBLL.GetAll().Dados;
            cbxProduto.SelectedIndex = -1;

            LimparCampos();
        }
        private void AtualizarValorTotalSomando()
        {
            foreach (ItemTransacao itemVenda in venda.Itens)
            {
                valorTotal += itemVenda.ValorUnitario * itemVenda.QuantidadeProduto;
            }
            txtValorTotal.Text = valorTotal.ToString("C2");
        }
        private void AtualizarValorTotalSubtraindo()
        {
            //tem que pegar a coluna codigo da row selecionada e fazer um getbyid pra fazer o cálculo do valor total especificamente
            //com aquele produto, senão ele faz com o último produto adicionado na grid
            foreach (ItemTransacao itemVenda in venda.Itens)
            {
                valorTotal -= itemVenda.ValorUnitario * itemVenda.QuantidadeProduto;
            }
            txtValorTotal.Text = valorTotal.ToString("C2");
        }
        private void dgvProdutos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }
        private void PopularCbxClientes()
        {
            BindingList<Cliente> bindingClientes = new BindingList<Cliente>();
            foreach (Cliente cliente in clienteBLL.GetAll().Dados)
            {
                bindingClientes.Add(cliente);
            }
            BindingSource bSource = new BindingSource();
            bSource.DataSource = bindingClientes;
            cbxCliente.ValueMember = "ID";
            cbxCliente.DisplayMember = "Nome";
            cbxCliente.DataSource = bSource;
        }
        private void LimparCampos()
        {
            cbxProduto.SelectedIndex = -1;
            cbxFormaPagamento.SelectedIndex = -1;
            cbxCliente.SelectedIndex = -1;
            txtQuantidade.Text = "";
            txtPontuacao.Text = "";
            txtValorTotal.Text = 0.ToString("C2");
            chkIsFidelidade.Checked = false;
            dgvProdutos.Rows.Clear();
        }

        //private void btnAdicionarProduto_Click(object sender, EventArgs e)
        //{
        //    Produto produto = produtoBLL.GetById(Convert.ToInt32(cbxProduto.SelectedValue)).Item;
        //    bool hasFound = false;
        //    if (produto != null)
        //    {
        //        produto.QuantiaEmEstoque = Convert.ToDouble(txtQuantidade.Text);
        //        for (int i = 0; i < produtos.Count; i++)
        //        {
        //            if (produto.ID == produtos[i].ID)
        //            {
        //                hasFound = true;
        //                produtos[i].QuantiaEmEstoque += produto.QuantiaEmEstoque;
        //                if (produtos[i].ValorUnitario != produto.ValorUnitario)
        //                {
        //                    produtos[i].ValorUnitario = produtoBLL.CalculateNewValueWithProdutos(produtos[i], produto);
        //                }
        //                break;
        //            }
        //        }
        //        if (!hasFound)
        //        {
        //            produtos.Add(produto);

        //            dgvProdutos.Rows.Add();
        //        }
        //        double valor = 0;
        //        for (int i = 0; i < produtos.Count; i++)
        //        {
        //            valor += Math.Round((produtos[i].QuantiaEmEstoque * produtos[i].ValorUnitario), 2);
        //            dgvProdutos.Rows[i].Cells["ProdutosEntradaID"].Value = produtos[i].ID;
        //            dgvProdutos.Rows[i].Cells["ProdutosEntradaNome"].Value = produtos[i].Nome;
        //            dgvProdutos.Rows[i].Cells["ProdutosEntradaUn"].Value = TipoUnidadeBLL.GetById(produtos[i].TipoUnidadeId).Item.Nome;
        //            dgvProdutos.Rows[i].Cells["ProdutosEntradaQtde"].Value = produtos[i].QtdEstoque;
        //            dgvProdutos.Rows[i].Cells["ProdutosEntradaValor"].Value = Math.Round(produtos[i].Valor, 2);
        //            dgvProdutos.Rows[i].Cells["ProdutosEntradaTotal"].Value = Math.Round(produtos[i].QtdEstoque * produtos[i].Valor, 2);
        //        }
        //        txtNumItens.Text = produtos.Count.ToString();
        //        txtTotalPago.Text = (valor).ToString();
        //    }
        //}

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ItemTransacao itemVenda = new ItemTransacao();
            
            if (cbxProduto.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }

            double quantidadeDoProdutoVendida = itemVenda.QuantidadeProduto;
            if ((!double.TryParse(txtQuantidade.Text, out quantidadeDoProdutoVendida)) || txtQuantidade.Text == "")
            {
                MessageBox.Show("Quantidade deve ser preenchida com um número.");
                return;
            }

            Produto produto = new Produto();
            produto = produtoBLL.GetById(Convert.ToInt32(cbxProduto.SelectedValue)).Item;
            bool hasFound = false;
            for (int i = 0; i < venda.Itens.Count; i++)
            {
                if (venda.Itens[i].IDProduto == produto.ID)
                {
                    hasFound = true;
                    venda.Itens[i].QuantidadeProduto -= Convert.ToDouble(txtQuantidade.Text);
                    produto.QuantiaEmEstoque = venda.Itens[i].QuantidadeProduto;
                    break;
                }
            }

            
            //Regra de tela caso o usuário tente inserir uma quantidade para venda maior que o estoque do produto selecionado
            if (Convert.ToDouble(txtQuantidade.Text) > produto.QuantiaEmEstoque)
            {
                MessageBox.Show("Estoque insuficiente.");
                return;
            }
            double valorProdutoComLucro = produto.ValorUnitario * (1 + (produto.Lucro / 100));
            dgvProdutos.Rows.Add(produto.ID, produto.Nome, produto.Descricao, produto.Laboratorio.RazaoSocial,
                                 produto.QuantiaEmEstoque, (produto.ValorUnitario * (1 + (produto.Lucro / 100))).ToString("C2"), txtQuantidade.Text);

            itemVenda.QuantidadeProduto = Convert.ToDouble(txtQuantidade.Text);
            itemVenda.IDProduto = produto.ID;
            itemVenda.ValorUnitario = valorProdutoComLucro;

            venda.Itens.Add(itemVenda);
            txtQuantidade.Text = "";
            AtualizarValorTotalSomando();
            
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            formCliente.ShowDialog();
            PopularCbxClientes();
            cbxCliente.SelectedIndex = cbxCliente.Items.Count - 1;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (cbxCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um cliente.");
                return;
            }

            if (cbxFormaPagamento.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma forma de pagamento.");
                return;
            }

            if ((valorTotal <= 0) || (dgvProdutos.Rows.Count == 0))
            {
                MessageBox.Show("Uma venda não pode ser realizada sem produtos.");
                return;
            }

            venda.DataTransacao = dtpDataVenda.Value;
            venda.FormaPagamento = Convert.ToInt32(cbxFormaPagamento.SelectedValue);
            venda.IDCliente = Convert.ToInt32(cbxCliente.SelectedValue);
            venda.ValorTotal = valorTotal;
            if (SystemParameters.FuncionarioLogado == null)
            {
                venda.IDFuncionario = 1;
            }
            else
            {
                venda.IDFuncionario = SystemParameters.FuncionarioLogado.ID;
            }
            
            MessageBox.Show(vendaBLL.Insert(venda).Message);
            LimparCampos();
        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCliente.SelectedIndex >= 0)
            {
                Cliente cliente = new Cliente();
                cliente = clienteBLL.GetById(Convert.ToInt32(cbxCliente.SelectedValue)).Item;
                txtPontuacao.Text = cliente.PontosFidelidade.ToString();
                chkIsFidelidade.Checked = cliente.IsFidelidade;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows == null || dgvProdutos.Rows.Count <= 0)
            {
                MessageBox.Show("Para excluir um produto do carrinho, é necessário que ele " +
                                "esteja no carrinho. Caso já esteja, é necessário selecioná-lo na lista de produtos.");
                return;
            }
            DataGridViewRow rowCodigo = this.dgvProdutos.SelectedRows[0];
            venda.Itens.RemoveAt(rowCodigo.Index);
            dgvProdutos.Rows.RemoveAt(rowCodigo.Index);
            AtualizarValorTotalSubtraindo();
        }
    }
}
