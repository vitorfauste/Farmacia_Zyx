using BusinessLogicalLayer;
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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            this.Hide();
            formCliente.ShowDialog();
            this.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto();
            this.Hide();
            formProduto.ShowDialog();
            this.Show();
        }

        private void btnLaboratorio_Click(object sender, EventArgs e)
        {
            FormLaboratorio formLaboratorio = new FormLaboratorio();
            this.Hide();
            formLaboratorio.ShowDialog();
            this.Show();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            FormFornecedor formFornecedor = new FormFornecedor();
            this.Hide();
            formFornecedor.ShowDialog();
            this.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FormFuncionario formFuncionario = new FormFuncionario();
            this.Hide();
            formFuncionario.ShowDialog();
            this.Show();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            FormVenda formVenda = new FormVenda();
            this.Hide();
            formVenda.ShowDialog();
            this.Show();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            FormCompra formCompra = new FormCompra();
            this.Hide();
            formCompra.ShowDialog();
            this.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (SystemParameters.FuncionarioLogado.IsAdmin)
            {
                btnFuncionario.Visible = true;
            }
        }
    }
}
