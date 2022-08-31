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
    public partial class FormCliente : Form
    {
        private ClienteBLL bll = new ClienteBLL();
        
        public FormCliente()
        {
            InitializeComponent();
            this.dgvClientes.CellDoubleClick += DgvClientes_CellDoubleClick;
        }

        private void DrawFormWithObject(Cliente cliente)
        {
            this.txtID.Text = cliente.ID.ToString();
            this.txtNome.Text = cliente.Nome;
            this.txtTelefone.Text = cliente.Telefone;
            this.txtTelefone2.Text = cliente.Telefone2;
            this.txtCPF.Text = cliente.CPF;
            this.txtRG.Text = cliente.RG;
            this.txtEmail.Text = cliente.Email;
            this.chkIsAtivo.Checked = cliente.IsAtivo;
            this.chkIsFidelidade.Checked = cliente.IsFidelidade;
        }

        private void DgvClientes_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            btnInserir.Visible = false;
            btnNovoCliente.Visible = true;
            chkIsAtivo.Visible = true;
            lblID.Text = "ID";
            SingleResponse<Cliente> singleCliente = bll.GetById(Convert.ToInt32(this.dgvClientes.Rows[e.RowIndex].Cells[0].Value));
            if (!singleCliente.HasSuccess)
            {
                MessageBox.Show(singleCliente.Message);
                return;
            }
            DrawFormWithObject(singleCliente.Item);
            btnInserir.Visible = false;
            btnAtualizar.Visible = true;
        }
        private Cliente CreateObjectWithForm()
        {
            int temp;
            int.TryParse(txtID.Text, out temp);
            Cliente cliente = new Cliente()
            {
                ID = temp,
                Nome = txtNome.Text,
                CPF = txtCPF.Text,
                RG = txtRG.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Telefone2 = txtTelefone2.Text,
                PontosFidelidade = Convert.ToInt32(txtPontosFidelidade.Text),
                IsAtivo = chkIsAtivo.Checked,
                IsFidelidade = chkIsFidelidade.Checked
            };
            return cliente;
        }

        private void SincronizarGridFidelidade()
        {
            dgvClientes.Rows.Clear();
            dgvClientes.Refresh();
            dgvClientes.DataSource = null;
            List<Cliente> clientes = bll.GetAll().Dados;
            foreach (Cliente cliente in clientes)
            {
                if (cliente.IsFidelidade)
                {
                    dgvClientes.Rows.Add(cliente.ID, cliente.Nome, cliente.CPF, cliente.RG, cliente.Telefone,
                                         cliente.Telefone2, cliente.Email, cliente.PontosFidelidade);
                }
            }
        }

        private void SincronizarGridNaoFidelidade()
        {
            dgvClientes.Rows.Clear();
            dgvClientes.Refresh();
            dgvClientes.DataSource = null;
            List<Cliente> clientes = bll.GetAll().Dados;
            foreach (Cliente cliente in clientes)
            {
                if (!cliente.IsFidelidade)
                {
                    dgvClientes.Rows.Add(cliente.ID, cliente.Nome, cliente.CPF, cliente.RG, cliente.Telefone,
                                         cliente.Telefone2, cliente.Email, cliente.PontosFidelidade);
                }
            }
        }


        private void SincronizarGridAtivos()
        {
            dgvClientes.Rows.Clear();
            dgvClientes.Refresh();
            dgvClientes.DataSource = null;
            List<Cliente> clientes = bll.GetAll().Dados;
            foreach (Cliente cliente in clientes)
            {
                if (cliente.IsAtivo)
                {
                    dgvClientes.Rows.Add(cliente.ID, cliente.Nome, cliente.CPF, cliente.RG, cliente.Telefone,
                                         cliente.Telefone2, cliente.Email, cliente.PontosFidelidade);
                }
            }
        }

        private void SincronizarGridInativos()
        {
            dgvClientes.Rows.Clear();
            dgvClientes.Refresh();
            dgvClientes.DataSource = null;
            List<Cliente> clientes = bll.GetAll().Dados;
            foreach (Cliente cliente in clientes)
            {
                if (!cliente.IsAtivo)
                {
                    dgvClientes.Rows.Add(cliente.ID, cliente.Nome, cliente.CPF, cliente.RG, cliente.Telefone,
                                         cliente.Telefone2, cliente.Email, cliente.PontosFidelidade);
                }
            }
        }

        private void LimparCampos()
        {
            txtCPF.Clear();
            txtTelefone.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone2.Clear();
            txtRG.Clear();
            txtID.Clear();
            txtPontosFidelidade.Text = "0";
        }

        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            SincronizarGridAtivos();
            chkIsAtivo.Visible = false;
            lblID.Text = "ID (gerado automaticamente)";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = CreateObjectWithForm();
            Response response = bll.Insert(cliente);
            MessageBox.Show(response.Message);
            if (response.HasSuccess)
            {
                LimparCampos();
            }
            SincronizarGridAtivos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Cliente cliente = CreateObjectWithForm();
            Response response = bll.Update(cliente);
            MessageBox.Show(response.Message);
            if (response.HasSuccess)
            {
                LimparCampos();
                chkIsAtivo.Visible = false;
                btnInserir.Visible = true;
                btnAtualizar.Visible = false;
                lblID.Text = "ID (gerado automaticamente)";
            }
            SincronizarGridAtivos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ID = Convert.ToInt32(txtID.Text);
            Response response = bll.Delete(cliente);
            MessageBox.Show(response.Message);
            if (response.HasSuccess)
            {
                LimparCampos();
                chkIsAtivo.Visible = false;
                btnAtualizar.Visible = false;
                btnInserir.Visible = true;
            }
            SincronizarGridAtivos();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnInserir.Visible = true;
            chkIsAtivo.Visible = false;
            lblID.Text = "ID (gerado automaticamente)";
            btnAtualizar.Visible = false;
            chkIsFidelidade.Checked = true;
        }

        private void btnMostrarInativos_Click(object sender, EventArgs e)
        {
            SincronizarGridInativos();
        }

        private void btnMostrarAtivos_Click(object sender, EventArgs e)
        {
            SincronizarGridAtivos();
        }

        private void btnClientesFidelidade_Click(object sender, EventArgs e)
        {
            SincronizarGridFidelidade();
        }

        private void btnClientesNaoFidelidade_Click(object sender, EventArgs e)
        {
            SincronizarGridNaoFidelidade();
        }
    }
}
