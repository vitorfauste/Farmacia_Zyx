namespace WFPresentationLayer
{
    partial class FormModalProdutosCompra
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
            this.cbxProdutos = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbxLaboratorio = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtLucro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxProdutos
            // 
            this.cbxProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProdutos.FormattingEnabled = true;
            this.cbxProdutos.Location = new System.Drawing.Point(12, 34);
            this.cbxProdutos.Name = "cbxProdutos";
            this.cbxProdutos.Size = new System.Drawing.Size(237, 23);
            this.cbxProdutos.TabIndex = 5;
            this.cbxProdutos.SelectedIndexChanged += new System.EventHandler(this.cbxProdutos_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(237, 23);
            this.txtNome.TabIndex = 1;
            // 
            // cbxLaboratorio
            // 
            this.cbxLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLaboratorio.Enabled = false;
            this.cbxLaboratorio.FormattingEnabled = true;
            this.cbxLaboratorio.Location = new System.Drawing.Point(12, 250);
            this.cbxLaboratorio.Name = "cbxLaboratorio";
            this.cbxLaboratorio.Size = new System.Drawing.Size(237, 23);
            this.cbxLaboratorio.TabIndex = 3;
            this.cbxLaboratorio.TabStop = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 141);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(237, 75);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(12, 307);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.ReadOnly = true;
            this.txtEstoque.Size = new System.Drawing.Size(105, 23);
            this.txtEstoque.TabIndex = 3;
            // 
            // txtLucro
            // 
            this.txtLucro.Location = new System.Drawing.Point(144, 307);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.ReadOnly = true;
            this.txtLucro.Size = new System.Drawing.Size(105, 23);
            this.txtLucro.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selecione um produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "% de lucro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Estoque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Laboratório";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descrição";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nome";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 415);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(105, 23);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Location = new System.Drawing.Point(12, 415);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(105, 23);
            this.btnNovoProduto.TabIndex = 7;
            this.btnNovoProduto.Text = "Novo produto";
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(144, 415);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(105, 23);
            this.btnSelecionar.TabIndex = 9;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(144, 415);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Quant. (compra)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Valor unit. (compra)";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(12, 374);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(105, 23);
            this.txtQuantidade.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(144, 374);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(105, 23);
            this.txtValor.TabIndex = 6;
            // 
            // FormModalProdutosCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 450);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLucro);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.cbxLaboratorio);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cbxProdutos);
            this.Name = "FormModalProdutosCompra";
            this.Text = "ModalProdutos";
            this.Load += new System.EventHandler(this.FormModalProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxProdutos;
        private TextBox txtNome;
        private ComboBox cbxLaboratorio;
        private TextBox txtDescricao;
        private TextBox txtEstoque;
        private TextBox txtLucro;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnVoltar;
        private Button btnNovoProduto;
        private Button btnSelecionar;
        private Button btnCadastrar;
        private Label label7;
        private Label label8;
        private TextBox txtQuantidade;
        private TextBox txtValor;
    }
}