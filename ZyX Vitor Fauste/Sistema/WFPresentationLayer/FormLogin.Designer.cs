namespace WFPresentationLayer
{
    partial class FormLogin
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblValidacao = new System.Windows.Forms.Label();
            this.chkVisualizarSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(27, 41);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 23);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(27, 102);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(263, 23);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(121, 157);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblValidacao
            // 
            this.lblValidacao.AutoSize = true;
            this.lblValidacao.ForeColor = System.Drawing.Color.Red;
            this.lblValidacao.Location = new System.Drawing.Point(27, 130);
            this.lblValidacao.Name = "lblValidacao";
            this.lblValidacao.Size = new System.Drawing.Size(0, 15);
            this.lblValidacao.TabIndex = 5;
            // 
            // chkVisualizarSenha
            // 
            this.chkVisualizarSenha.AutoSize = true;
            this.chkVisualizarSenha.Location = new System.Drawing.Point(215, 83);
            this.chkVisualizarSenha.Name = "chkVisualizarSenha";
            this.chkVisualizarSenha.Size = new System.Drawing.Size(75, 19);
            this.chkVisualizarSenha.TabIndex = 1713;
            this.chkVisualizarSenha.TabStop = false;
            this.chkVisualizarSenha.Text = "Visualizar";
            this.chkVisualizarSenha.UseVisualStyleBackColor = true;
            this.chkVisualizarSenha.CheckedChanged += new System.EventHandler(this.chkVisualizarSenha_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 189);
            this.Controls.Add(this.chkVisualizarSenha);
            this.Controls.Add(this.lblValidacao);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Label lblValidacao;
        private CheckBox chkVisualizarSenha;
    }
}