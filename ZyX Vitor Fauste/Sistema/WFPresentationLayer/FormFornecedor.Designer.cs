namespace WFPresentationLayer
{
    partial class FormFornecedor
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
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.AllowUserToAddRows = false;
            this.dgvFornecedores.AllowUserToDeleteRows = false;
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.RazaoSocial,
            this.NomeContato,
            this.Telefone,
            this.CNPJ,
            this.Email});
            this.dgvFornecedores.Location = new System.Drawing.Point(320, 12);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.ReadOnly = true;
            this.dgvFornecedores.RowHeadersVisible = false;
            this.dgvFornecedores.RowTemplate.Height = 25;
            this.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedores.Size = new System.Drawing.Size(658, 371);
            this.dgvFornecedores.TabIndex = 0;
            this.dgvFornecedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFornecedores_CellDoubleClick);
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
            // NomeContato
            // 
            this.NomeContato.HeaderText = "Contato";
            this.NomeContato.Name = "NomeContato";
            this.NomeContato.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // CNPJ
            // 
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(12, 140);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(110, 15);
            this.lblRG.TabIndex = 37;
            this.lblRG.Text = "Nome para contato";
            // 
            // txtNomeContato
            // 
            this.txtNomeContato.Location = new System.Drawing.Point(12, 158);
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Size = new System.Drawing.Size(291, 23);
            this.txtNomeContato.TabIndex = 23;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(96, 329);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(123, 54);
            this.btnCadastrar.TabIndex = 35;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Telefone";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(178, 197);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 15);
            this.lblCPF.TabIndex = 28;
            this.lblCPF.Text = "CNPJ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 78);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(71, 15);
            this.lblNome.TabIndex = 27;
            this.lblNome.Text = "Razão social";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 26;
            this.lblID.Text = "ID";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 278);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(291, 23);
            this.txtEmail.TabIndex = 25;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(12, 215);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(125, 23);
            this.txtTelefone.TabIndex = 24;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(12, 96);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(291, 23);
            this.txtRazaoSocial.TabIndex = 21;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 30);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 20;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(320, 389);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 38;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(427, 389);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 39;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(96, 329);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(123, 54);
            this.btnAtualizar.TabIndex = 40;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(178, 215);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(125, 23);
            this.txtCNPJ.TabIndex = 41;
            // 
            // FormFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 420);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.txtNomeContato);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvFornecedores);
            this.Name = "FormFornecedor";
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.FormFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvFornecedores;
        private Label lblRG;
        private TextBox txtNomeContato;
        private Button btnCadastrar;
        private Label label4;
        private Label label2;
        private Label lblCPF;
        private Label lblNome;
        private Label lblID;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtRazaoSocial;
        private TextBox txtID;
        private Button btnNovo;
        private Button btnExcluir;
        private Button btnAtualizar;
        private TextBox txtCNPJ;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn RazaoSocial;
        private DataGridViewTextBoxColumn NomeContato;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn CNPJ;
        private DataGridViewTextBoxColumn Email;
    }
}