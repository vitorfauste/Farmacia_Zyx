namespace WFPresentationLayer
{
    partial class FormFuncionario
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkIsAdmin = new System.Windows.Forms.CheckBox();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblCPFFuncionario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Administrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.chkVisualizarSenha = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(262, 23);
            this.txtNome.TabIndex = 0;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(166, 106);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(102, 23);
            this.txtRG.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(6, 253);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(262, 23);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(262, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.AutoSize = true;
            this.chkIsAdmin.Location = new System.Drawing.Point(166, 328);
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.Size = new System.Drawing.Size(102, 19);
            this.chkIsAdmin.TabIndex = 6;
            this.chkIsAdmin.Text = "Administrador";
            this.chkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(6, 26);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(94, 15);
            this.lblNomeFuncionario.TabIndex = 9;
            this.lblNomeFuncionario.Text = "Nome completo";
            // 
            // lblCPFFuncionario
            // 
            this.lblCPFFuncionario.AutoSize = true;
            this.lblCPFFuncionario.Location = new System.Drawing.Point(6, 88);
            this.lblCPFFuncionario.Name = "lblCPFFuncionario";
            this.lblCPFFuncionario.Size = new System.Drawing.Size(28, 15);
            this.lblCPFFuncionario.TabIndex = 10;
            this.lblCPFFuncionario.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "RG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Senha";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(18, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(18, 27);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(39, 23);
            this.txtID.TabIndex = 16;
            this.txtID.TabStop = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(423, 301);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 42);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Complemento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Bairro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Rua";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "CEP";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(257, 182);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(84, 23);
            this.txtComplemento.TabIndex = 13;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(6, 182);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(245, 23);
            this.txtBairro.TabIndex = 12;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(131, 44);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(209, 23);
            this.txtCidade.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(290, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "Número";
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(82, 44);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(44, 23);
            this.cbxEstado.TabIndex = 8;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(290, 106);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(50, 23);
            this.txtNumero.TabIndex = 11;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(6, 106);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(278, 23);
            this.txtRua.TabIndex = 10;
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.CPF,
            this.RG,
            this.Email,
            this.Telefone,
            this.Administrador});
            this.dgvFuncionarios.Location = new System.Drawing.Point(663, 12);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.RowHeadersVisible = false;
            this.dgvFuncionarios.RowTemplate.Height = 25;
            this.dgvFuncionarios.Size = new System.Drawing.Size(695, 438);
            this.dgvFuncionarios.TabIndex = 36;
            this.dgvFuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellDoubleClick);
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
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Administrador
            // 
            this.Administrador.HeaderText = "Administrador";
            this.Administrador.Name = "Administrador";
            this.Administrador.ReadOnly = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(423, 357);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(105, 40);
            this.btnNovo.TabIndex = 15;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(423, 410);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 40);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(423, 301);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(105, 42);
            this.btnAtualizar.TabIndex = 123213;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.chkVisualizarSenha);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtRG);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.chkIsAdmin);
            this.groupBox1.Controls.Add(this.lblNomeFuncionario);
            this.groupBox1.Controls.Add(this.lblCPFFuncionario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 363);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados pessoais";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(6, 106);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(102, 23);
            this.txtCPF.TabIndex = 1713;
            // 
            // chkVisualizarSenha
            // 
            this.chkVisualizarSenha.AutoSize = true;
            this.chkVisualizarSenha.Location = new System.Drawing.Point(193, 234);
            this.chkVisualizarSenha.Name = "chkVisualizarSenha";
            this.chkVisualizarSenha.Size = new System.Drawing.Size(75, 19);
            this.chkVisualizarSenha.TabIndex = 1712;
            this.chkVisualizarSenha.TabStop = false;
            this.chkVisualizarSenha.Text = "Visualizar";
            this.chkVisualizarSenha.UseVisualStyleBackColor = true;
            this.chkVisualizarSenha.CheckedChanged += new System.EventHandler(this.chkVisualizarSenha_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCEP);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.txtComplemento);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtRua);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbxEstado);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(292, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 221);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(6, 44);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(71, 23);
            this.txtCEP.TabIndex = 33;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(6, 326);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(102, 23);
            this.txtTelefone.TabIndex = 1714;
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Name = "FormFuncionario";
            this.Text = "FormCadastroFuncionario";
            this.Load += new System.EventHandler(this.FormCadastroFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNome;
        private TextBox txtRG;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private CheckBox chkIsAdmin;
        private Label lblNomeFuncionario;
        private Label lblCPFFuncionario;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label lblID;
        private TextBox txtID;
        private Button btnCadastrar;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private Label label12;
        private ComboBox cbxEstado;
        private TextBox txtNumero;
        private TextBox txtRua;
        private DataGridView dgvFuncionarios;
        private Button btnNovo;
        private Button btnExcluir;
        private Button btnAtualizar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox chkVisualizarSenha;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn RG;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Administrador;
        private TextBox txtCPF;
        private TextBox txtCEP;
        private TextBox txtTelefone;
    }
}