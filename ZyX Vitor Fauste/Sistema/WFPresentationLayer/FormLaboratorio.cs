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
    public partial class FormLaboratorio : Form
    {
        private LaboratorioBLL bll = new LaboratorioBLL();

        public FormLaboratorio()
        {
            InitializeComponent();
            this.dgvLaboratorios.CellDoubleClick += DgvLaboratorios_CellDoubleClick;
        }

        private void FormCadastroLaboratorio_Load(object sender, EventArgs e)
        {
            SincronizarGrid();
            btnAtualizar.Visible = false;
            btnCadastrar.Visible = true;
            lblID.Text = "ID (gerado automaticamente)";
        }

        private void DgvLaboratorios_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            btnCadastrar.Visible = false;
            btnNovo.Visible = true;
            lblID.Text = "ID";
            SingleResponse<Laboratorio> singleLaboratorio = bll.GetById(Convert.ToInt32(this.dgvLaboratorios.Rows[e.RowIndex].Cells[0].Value));

            if (!singleLaboratorio.HasSuccess)
            {
                MessageBox.Show(singleLaboratorio.Message);
                return;
            }
            DrawFormWithObject(singleLaboratorio.Item);

            btnCadastrar.Visible = false;
            btnAtualizar.Visible = true;
        }

        private void DrawFormWithObject(Laboratorio laboratorio)
        {
            this.txtID.Text = laboratorio.ID.ToString();
            this.txtRazaoSocial.Text = laboratorio.RazaoSocial;
            this.txtCNPJ.Text = laboratorio.CNPJ;
        }
        
        private Laboratorio CreateObjectWithForm()
        {
            int temp;
            int.TryParse(txtID.Text, out temp);
            Laboratorio laboratorio = new Laboratorio()
            {
                ID = temp,
                RazaoSocial = txtRazaoSocial.Text,
                CNPJ = txtCNPJ.Text
            };
            return laboratorio;
        }


        private void SincronizarGrid()
        {
            dgvLaboratorios.Rows.Clear();
            dgvLaboratorios.Refresh();
            dgvLaboratorios.DataSource = null;
            //dgvLaboratorios.DataSource = bll.GetAll().Dados;
            List<Laboratorio> laboratorios = bll.GetAll().Dados;
            foreach (Laboratorio laboratorio in laboratorios)
            {
                dgvLaboratorios.Rows.Add(laboratorio.ID, laboratorio.RazaoSocial, laboratorio.CNPJ);
            }
        }

        private void LimparCampos()
        {
            txtID.Clear();
            txtRazaoSocial.Clear();
            txtCNPJ.Clear();
            btnCadastrar.Visible = true;
            btnAtualizar.Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Laboratorio laboratorio = CreateObjectWithForm();
            Response response = bll.Insert(laboratorio);
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
            lblID.Text = "ID (gerado automaticamente)";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Laboratorio laboratorio = new Laboratorio();
            laboratorio.ID = Convert.ToInt32(txtID.Text);
            Response response = bll.Delete(laboratorio);
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
            Laboratorio laboratorio = CreateObjectWithForm();
            Response response = bll.Update(laboratorio);
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
