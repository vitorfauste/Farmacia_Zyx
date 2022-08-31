using BusinessLogicalLayer;
using DataAcessLayer;
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
    public partial class FormFuncionario : Form
    {
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        public FormFuncionario()
        {
            InitializeComponent();
        }
        private void FormCadastroFuncionario_Load(object sender, EventArgs e)
        {
            EnderecoBLL enderecoBLL = new EnderecoBLL();
            SincronizarGrid();
            cbxEstado.Items.Clear();
            cbxEstado.DataSource = enderecoBLL.GetAllEstados().Dados;
            cbxEstado.DisplayMember = "UF";
            cbxEstado.ValueMember = "ID";
            cbxEstado.SelectedIndex = -1;
            btnAtualizar.Visible = false;
            lblID.Text = "ID (gerado automaticamente)";
            
        }

        private void DrawFormWithObject(Funcionario funcionario)
        {
            //Preenchimento dos dados pessoais
            this.txtID.Text = funcionario.ID.ToString();
            this.txtNome.Text = funcionario.Nome;
            this.txtTelefone.Text = funcionario.Telefone;
            this.txtCPF.Text = funcionario.CPF;
            this.txtRG.Text = funcionario.RG;
            this.txtEmail.Text = funcionario.Email;
            this.txtSenha.Text = funcionario.Senha;
            this.chkIsAdmin.Checked = funcionario.IsAdmin;
            this.txtCEP.Text = funcionario.Endereco.CEP;

            //Preenchimento do endereço
            this.cbxEstado.SelectedIndex = funcionario.Endereco.Estado.ID - 1;
            this.txtRua.Text = funcionario.Endereco.Rua;
            this.txtCidade.Text = funcionario.Endereco.Cidade;
            this.txtComplemento.Text = funcionario.Endereco.Complemento;
            this.txtNumero.Text = funcionario.Endereco.Numero;
            this.txtBairro.Text = funcionario.Endereco.Bairro;
        }

        private Endereco CreateObjectEnderecoWithForm()
        {
            Estado estado = new Estado();
            estado.ID = Convert.ToInt32(cbxEstado.SelectedValue);
            Endereco endereco = new Endereco()
            {
                CEP = txtCEP.Text.Replace("-", ""),
                Rua = txtRua.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Complemento = txtComplemento.Text,
                Estado = estado,
                Numero = txtNumero.Text
            };
            return endereco;
        }
        private Funcionario CreateObjectWithForm(Endereco endereco)
        {
            int temp;
            int.TryParse(txtID.Text, out temp);
            Funcionario funcionario = new Funcionario()
            {
                ID = temp,
                Nome = txtNome.Text,
                CPF = txtCPF.Text.Replace("-", "").Replace(".", ""),
                RG = txtRG.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                IsAdmin = chkIsAdmin.Checked,
                Endereco = endereco
            };
            return funcionario;
        }

        private void SincronizarGrid()
        {
            dgvFuncionarios.Rows.Clear();
            dgvFuncionarios.Refresh();
            dgvFuncionarios.DataSource = null;
            List<Funcionario> funcionarios = funcionarioBLL.GetAll().Dados;
            foreach (Funcionario funcionario in funcionarios)
            {
                dgvFuncionarios.Rows.Add(funcionario.ID, funcionario.Nome, funcionario.CPF, funcionario.RG, funcionario.Email,
                                         funcionario.Telefone, funcionario.IsAdmin);
            }

        }

        private void LimparCampos()
        {
            txtID.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtEmail.Clear();
            txtID.Clear();
            txtNome.Clear();
            txtNumero.Clear();
            txtRG.Clear();
            txtRua.Clear();
            txtSenha.Clear();
            txtCEP.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();
            cbxEstado.SelectedIndex = -1;
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = CreateObjectWithForm(CreateObjectEnderecoWithForm());
            Response response = funcionarioBLL.Insert(funcionario);
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
            btnCadastrar.Visible = true;
            btnAtualizar.Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = CreateObjectWithForm(CreateObjectEnderecoWithForm());
            Response response = funcionarioBLL.Delete(funcionario);
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
            Funcionario funcionario = CreateObjectWithForm(CreateObjectEnderecoWithForm());
            funcionario.Endereco.ID = funcionarioBLL.GetEnderecoID(funcionario.ID).Item;
            Response response = funcionarioBLL.Update(funcionario);
            if (!response.HasSuccess)
            {
                MessageBox.Show(response.Message);
                return;
            }
            MessageBox.Show(response.Message);
            SincronizarGrid();
            LimparCampos();
        }

        private void chkVisualizarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVisualizarSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void dgvFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCadastrar.Visible = false;
            btnAtualizar.Visible = true;
            lblID.Text = "ID";

            SingleResponse<Funcionario> singleFuncionario = funcionarioBLL.GetById(Convert.ToInt32
                                                                           (this.dgvFuncionarios.Rows[e.RowIndex].Cells[0].Value));

            if (!singleFuncionario.HasSuccess)
            {
                MessageBox.Show(singleFuncionario.Message);
                return;
            }

            DrawFormWithObject(singleFuncionario.Item);
        }
    }
}
