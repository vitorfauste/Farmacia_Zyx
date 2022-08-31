namespace WFPresentationLayer
{
    partial class FormLaboratorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLaboratorios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(12, 85);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(279, 23);
            this.txtRazaoSocial.TabIndex = 0;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(12, 148);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(132, 23);
            this.txtCNPJ.TabIndex = 1;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(12, 67);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(71, 15);
            this.lblRazaoSocial.TabIndex = 3;
            this.lblRazaoSocial.Text = "Razão social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "CNPJ";
            // 
            // dgvLaboratorios
            // 
            this.dgvLaboratorios.AllowUserToAddRows = false;
            this.dgvLaboratorios.AllowUserToDeleteRows = false;
            this.dgvLaboratorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaboratorios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.RazaoSocial,
            this.CNPJ});
            this.dgvLaboratorios.Location = new System.Drawing.Point(314, 12);
            this.dgvLaboratorios.Name = "dgvLaboratorios";
            this.dgvLaboratorios.ReadOnly = true;
            this.dgvLaboratorios.RowHeadersVisible = false;
            this.dgvLaboratorios.RowTemplate.Height = 25;
            this.dgvLaboratorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaboratorios.Size = new System.Drawing.Size(383, 159);
            this.dgvLaboratorios.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.HeaderText = "Código";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // RazaoSocial
            // 
            this.RazaoSocial.HeaderText = "Razão social";
            this.RazaoSocial.Name = "RazaoSocial";
            this.RazaoSocial.ReadOnly = true;
            // 
            // CNPJ
            // 
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(415, 197);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(70, 197);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(149, 23);
            this.btnAtualizar.TabIndex = 23;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(70, 197);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(149, 23);
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 27;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 30);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(28, 23);
            this.txtID.TabIndex = 26;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(314, 197);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 28;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // FormLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 235);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvLaboratorios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtRazaoSocial);
            this.Name = "FormLaboratorio";
            this.Text = "FormCadastroLaboratorio";
            this.Load += new System.EventHandler(this.FormCadastroLaboratorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtRazaoSocial;
        private TextBox txtCNPJ;
        private Label lblRazaoSocial;
        private Label label2;
        private DataGridView dgvLaboratorios;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnCadastrar;
        private Label lblID;
        private TextBox txtID;
        private Button btnNovo;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn RazaoSocial;
        private DataGridViewTextBoxColumn CNPJ;
    }
}