namespace WFPresentationLayer
{
    partial class FormCompra
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
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpCompra = new System.Windows.Forms.DateTimePicker();
            this.cbxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrarFornecedor = new System.Windows.Forms.Button();
            this.txtNomeContatoFornecedor = new System.Windows.Forms.TextBox();
            this.txtCNPJFornecedor = new System.Windows.Forms.TextBox();
            this.txtRazaoSocialFornecedor = new System.Windows.Forms.TextBox();
            this.cbxFornecedor = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.gbxLista.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(24, 33);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(153, 43);
            this.btnAdicionarProduto.TabIndex = 3;
            this.btnAdicionarProduto.Text = "Adicionar produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Descricao,
            this.Laboratorio,
            this.Lucro,
            this.ValorUnit,
            this.Quantidade});
            this.dgvProdutos.Location = new System.Drawing.Point(6, 22);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowTemplate.Height = 25;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(1060, 233);
            this.dgvProdutos.TabIndex = 2;
            this.dgvProdutos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvProdutos_RowsRemoved);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Laboratorio
            // 
            this.Laboratorio.HeaderText = "Laboratório";
            this.Laboratorio.Name = "Laboratorio";
            this.Laboratorio.ReadOnly = true;
            // 
            // Lucro
            // 
            this.Lucro.HeaderText = "Lucro";
            this.Lucro.Name = "Lucro";
            this.Lucro.ReadOnly = true;
            // 
            // ValorUnit
            // 
            this.ValorUnit.HeaderText = "Valor unit.";
            this.ValorUnit.Name = "ValorUnit";
            this.ValorUnit.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvProdutos);
            this.gbxLista.Location = new System.Drawing.Point(12, 267);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(1072, 261);
            this.gbxLista.TabIndex = 4;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de produtos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluirProduto);
            this.groupBox1.Controls.Add(this.btnAdicionarProduto);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 169);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleção de produto";
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Location = new System.Drawing.Point(24, 95);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(153, 43);
            this.btnExcluirProduto.TabIndex = 4;
            this.btnExcluirProduto.Text = "Remover produto";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nova compra";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpCompra);
            this.groupBox2.Controls.Add(this.cbxFormaPagamento);
            this.groupBox2.Location = new System.Drawing.Point(249, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 169);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Forma de pagamento";
            // 
            // dtpCompra
            // 
            this.dtpCompra.Checked = false;
            this.dtpCompra.Location = new System.Drawing.Point(17, 111);
            this.dtpCompra.Name = "dtpCompra";
            this.dtpCompra.Size = new System.Drawing.Size(236, 23);
            this.dtpCompra.TabIndex = 1;
            // 
            // cbxFormaPagamento
            // 
            this.cbxFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFormaPagamento.FormattingEnabled = true;
            this.cbxFormaPagamento.Location = new System.Drawing.Point(17, 53);
            this.cbxFormaPagamento.Name = "cbxFormaPagamento";
            this.cbxFormaPagamento.Size = new System.Drawing.Size(236, 23);
            this.cbxFormaPagamento.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnCadastrarFornecedor);
            this.groupBox3.Controls.Add(this.txtNomeContatoFornecedor);
            this.groupBox3.Controls.Add(this.txtCNPJFornecedor);
            this.groupBox3.Controls.Add(this.txtRazaoSocialFornecedor);
            this.groupBox3.Controls.Add(this.cbxFornecedor);
            this.groupBox3.Location = new System.Drawing.Point(547, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 169);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do fornecedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Selecione um fornecedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome para contato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Razão social";
            // 
            // btnCadastrarFornecedor
            // 
            this.btnCadastrarFornecedor.Location = new System.Drawing.Point(16, 95);
            this.btnCadastrarFornecedor.Name = "btnCadastrarFornecedor";
            this.btnCadastrarFornecedor.Size = new System.Drawing.Size(194, 49);
            this.btnCadastrarFornecedor.TabIndex = 4;
            this.btnCadastrarFornecedor.Text = "Cadastrar novo fornecedor";
            this.btnCadastrarFornecedor.UseVisualStyleBackColor = true;
            this.btnCadastrarFornecedor.Click += new System.EventHandler(this.btnCadastrarFornecedor_Click);
            // 
            // txtNomeContatoFornecedor
            // 
            this.txtNomeContatoFornecedor.Location = new System.Drawing.Point(244, 129);
            this.txtNomeContatoFornecedor.Name = "txtNomeContatoFornecedor";
            this.txtNomeContatoFornecedor.ReadOnly = true;
            this.txtNomeContatoFornecedor.Size = new System.Drawing.Size(272, 23);
            this.txtNomeContatoFornecedor.TabIndex = 3;
            // 
            // txtCNPJFornecedor
            // 
            this.txtCNPJFornecedor.Location = new System.Drawing.Point(244, 81);
            this.txtCNPJFornecedor.Name = "txtCNPJFornecedor";
            this.txtCNPJFornecedor.ReadOnly = true;
            this.txtCNPJFornecedor.Size = new System.Drawing.Size(272, 23);
            this.txtCNPJFornecedor.TabIndex = 2;
            // 
            // txtRazaoSocialFornecedor
            // 
            this.txtRazaoSocialFornecedor.Location = new System.Drawing.Point(244, 33);
            this.txtRazaoSocialFornecedor.Name = "txtRazaoSocialFornecedor";
            this.txtRazaoSocialFornecedor.ReadOnly = true;
            this.txtRazaoSocialFornecedor.Size = new System.Drawing.Size(272, 23);
            this.txtRazaoSocialFornecedor.TabIndex = 1;
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFornecedor.FormattingEnabled = true;
            this.cbxFornecedor.Location = new System.Drawing.Point(16, 53);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(194, 23);
            this.cbxFornecedor.TabIndex = 0;
            this.cbxFornecedor.SelectedIndexChanged += new System.EventHandler(this.cbxFornecedor_SelectedIndexChanged);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(919, 45);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(153, 43);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar compra";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(18, 17);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(50, 15);
            this.lblUsuarioLogado.TabIndex = 9;
            this.lblUsuarioLogado.Text = "Usuário:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(919, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Valor total:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(984, 12);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(88, 23);
            this.txtValorTotal.TabIndex = 12;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 531);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxLista);
            this.Name = "FormCompra";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.gbxLista.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdicionarProduto;
        private DataGridView dgvProdutos;
        private GroupBox gbxLista;
        private GroupBox groupBox1;
        private Button btnExcluirProduto;
        private Label label1;
        private GroupBox groupBox2;
        private DateTimePicker dtpCompra;
        private ComboBox cbxFormaPagamento;
        private GroupBox groupBox3;
        private Button btnCadastrarFornecedor;
        private TextBox txtNomeContatoFornecedor;
        private TextBox txtCNPJFornecedor;
        private TextBox txtRazaoSocialFornecedor;
        private ComboBox cbxFornecedor;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnFinalizar;
        private Label lblUsuarioLogado;
        private Label label9;
        private TextBox txtValorTotal;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Laboratorio;
        private DataGridViewTextBoxColumn Lucro;
        private DataGridViewTextBoxColumn ValorUnit;
        private DataGridViewTextBoxColumn Quantidade;
    }
}