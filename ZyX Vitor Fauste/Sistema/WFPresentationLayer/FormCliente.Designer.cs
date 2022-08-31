namespace WFPresentationLayer
{
    partial class FormCliente
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PontosFidelidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtTelefone2 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPontosFidelidade = new System.Windows.Forms.TextBox();
            this.chkIsAtivo = new System.Windows.Forms.CheckBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnMostrarInativos = new System.Windows.Forms.Button();
            this.btnMostrarAtivos = new System.Windows.Forms.Button();
            this.chkIsFidelidade = new System.Windows.Forms.CheckBox();
            this.btnClientesFidelidade = new System.Windows.Forms.Button();
            this.btnClientesNaoFidelidade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.CPF,
            this.RG,
            this.Telefone,
            this.Telefone2,
            this.Email,
            this.PontosFidelidade});
            this.dgvClientes.Location = new System.Drawing.Point(276, 12);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(808, 377);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.TabStop = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "Código";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // RG
            // 
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Telefone2
            // 
            this.Telefone2.HeaderText = "Telefone sec.";
            this.Telefone2.Name = "Telefone2";
            this.Telefone2.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // PontosFidelidade
            // 
            this.PontosFidelidade.HeaderText = "Pontuação";
            this.PontosFidelidade.Name = "PontosFidelidade";
            this.PontosFidelidade.ReadOnly = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 30);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 1;
            this.txtID.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(225, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(12, 146);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 23);
            this.txtCPF.TabIndex = 2;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(12, 206);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 23);
            this.txtTelefone.TabIndex = 4;
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Location = new System.Drawing.Point(137, 206);
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(100, 23);
            this.txtTelefone2.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 264);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 23);
            this.txtEmail.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "ID";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 69);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(12, 128);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(28, 15);
            this.lblCPF.TabIndex = 9;
            this.lblCPF.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefone secundário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pontuação";
            // 
            // txtPontosFidelidade
            // 
            this.txtPontosFidelidade.Location = new System.Drawing.Point(15, 366);
            this.txtPontosFidelidade.Name = "txtPontosFidelidade";
            this.txtPontosFidelidade.ReadOnly = true;
            this.txtPontosFidelidade.Size = new System.Drawing.Size(64, 23);
            this.txtPontosFidelidade.TabIndex = 13;
            this.txtPontosFidelidade.TabStop = false;
            this.txtPontosFidelidade.Text = "0";
            // 
            // chkIsAtivo
            // 
            this.chkIsAtivo.AutoSize = true;
            this.chkIsAtivo.Location = new System.Drawing.Point(137, 345);
            this.chkIsAtivo.Name = "chkIsAtivo";
            this.chkIsAtivo.Size = new System.Drawing.Size(54, 19);
            this.chkIsAtivo.TabIndex = 7;
            this.chkIsAtivo.Text = "Ativo";
            this.chkIsAtivo.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(74, 415);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "Cadastrar";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(74, 415);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 123123;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(137, 128);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(22, 15);
            this.lblRG.TabIndex = 19;
            this.lblRG.Text = "RG";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(137, 146);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 23);
            this.txtRG.TabIndex = 3;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(385, 415);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Location = new System.Drawing.Point(276, 415);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(87, 23);
            this.btnNovoCliente.TabIndex = 10;
            this.btnNovoCliente.Text = "Novo";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // btnMostrarInativos
            // 
            this.btnMostrarInativos.Location = new System.Drawing.Point(608, 415);
            this.btnMostrarInativos.Name = "btnMostrarInativos";
            this.btnMostrarInativos.Size = new System.Drawing.Size(108, 23);
            this.btnMostrarInativos.TabIndex = 13;
            this.btnMostrarInativos.Text = "Clientes inativos";
            this.btnMostrarInativos.UseVisualStyleBackColor = true;
            this.btnMostrarInativos.Click += new System.EventHandler(this.btnMostrarInativos_Click);
            // 
            // btnMostrarAtivos
            // 
            this.btnMostrarAtivos.Location = new System.Drawing.Point(482, 415);
            this.btnMostrarAtivos.Name = "btnMostrarAtivos";
            this.btnMostrarAtivos.Size = new System.Drawing.Size(108, 23);
            this.btnMostrarAtivos.TabIndex = 12;
            this.btnMostrarAtivos.Text = "Clientes ativos";
            this.btnMostrarAtivos.UseVisualStyleBackColor = true;
            this.btnMostrarAtivos.Click += new System.EventHandler(this.btnMostrarAtivos_Click);
            // 
            // chkIsFidelidade
            // 
            this.chkIsFidelidade.AutoSize = true;
            this.chkIsFidelidade.Checked = true;
            this.chkIsFidelidade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsFidelidade.Location = new System.Drawing.Point(137, 370);
            this.chkIsFidelidade.Name = "chkIsFidelidade";
            this.chkIsFidelidade.Size = new System.Drawing.Size(118, 19);
            this.chkIsFidelidade.TabIndex = 8;
            this.chkIsFidelidade.Text = "Cliente fidelidade";
            this.chkIsFidelidade.UseVisualStyleBackColor = true;
            // 
            // btnClientesFidelidade
            // 
            this.btnClientesFidelidade.Location = new System.Drawing.Point(732, 415);
            this.btnClientesFidelidade.Name = "btnClientesFidelidade";
            this.btnClientesFidelidade.Size = new System.Drawing.Size(117, 23);
            this.btnClientesFidelidade.TabIndex = 14;
            this.btnClientesFidelidade.Text = "Clientes fidelidade";
            this.btnClientesFidelidade.UseVisualStyleBackColor = true;
            this.btnClientesFidelidade.Click += new System.EventHandler(this.btnClientesFidelidade_Click);
            // 
            // btnClientesNaoFidelidade
            // 
            this.btnClientesNaoFidelidade.Location = new System.Drawing.Point(868, 415);
            this.btnClientesNaoFidelidade.Name = "btnClientesNaoFidelidade";
            this.btnClientesNaoFidelidade.Size = new System.Drawing.Size(147, 23);
            this.btnClientesNaoFidelidade.TabIndex = 15;
            this.btnClientesNaoFidelidade.Text = "Clientes não-fidelidade";
            this.btnClientesNaoFidelidade.UseVisualStyleBackColor = true;
            this.btnClientesNaoFidelidade.Click += new System.EventHandler(this.btnClientesNaoFidelidade_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 461);
            this.Controls.Add(this.btnClientesNaoFidelidade);
            this.Controls.Add(this.btnClientesFidelidade);
            this.Controls.Add(this.chkIsFidelidade);
            this.Controls.Add(this.btnMostrarAtivos);
            this.Controls.Add(this.btnMostrarInativos);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.chkIsAtivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPontosFidelidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone2);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvClientes);
            this.Name = "FormCliente";
            this.Text = "FormCadastroCliente";
            this.Load += new System.EventHandler(this.FormCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvClientes;
        private TextBox txtID;
        private TextBox txtNome;
        private TextBox txtCPF;
        private TextBox txtTelefone;
        private TextBox txtTelefone2;
        private TextBox txtEmail;
        private Label lblID;
        private Label lblNome;
        private Label lblCPF;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private TextBox txtPontosFidelidade;
        private CheckBox chkIsAtivo;
        private Button btnInserir;
        private Button btnAtualizar;
        private Label lblRG;
        private TextBox txtRG;
        private Button btnExcluir;
        private Button btnNovoCliente;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn RG;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Telefone2;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn PontosFidelidade;
        private Button btnMostrarInativos;
        private Button btnMostrarAtivos;
        private CheckBox chkIsFidelidade;
        private Button btnClientesFidelidade;
        private Button btnClientesNaoFidelidade;
    }
}