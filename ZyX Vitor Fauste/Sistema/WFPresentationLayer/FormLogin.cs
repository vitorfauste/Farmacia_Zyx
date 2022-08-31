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
    public partial class FormLogin : Form
    {
        LoginBLL bll = new LoginBLL();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void Login()
        {
            SingleResponse<Funcionario> login = bll.UserExistsAndPasswordIsCorrect(txtEmail.Text, txtSenha.Text);
            lblValidacao.Text = login.Message;
            if (login.HasSuccess)
            {
                SystemParameters.FuncionarioLogado = login.Item;

                FormMenu formMenu = new FormMenu();
                this.Hide();
                formMenu.ShowDialog();
                this.Close();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
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
    }
}
