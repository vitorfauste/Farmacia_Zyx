namespace WFPresentationLayer
{
    partial class FormVenda
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkIsFidelidade = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.txtPontuacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Descricao,
            this.Laboratorio,
            this.QuantidadeEstoque,
            this.ValorUnitario,
            this.QuantidadeVendida});
            this.dgvProdutos.Location = new System.Drawing.Point(6, 22);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowTemplate.Height = 25;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(1058, 229);
            this.dgvProdutos.TabIndex = 0;
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
            // QuantidadeEstoque
            // 
            this.QuantidadeEstoque.HeaderText = "Estoque rest.";
            this.QuantidadeEstoque.Name = "QuantidadeEstoque";
            this.QuantidadeEstoque.ReadOnly = true;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.HeaderText = "Valor unit.";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.ReadOnly = true;
            // 
            // QuantidadeVendida
            // 
            this.QuantidadeVendida.HeaderText = "Quantidade";
            this.QuantidadeVendida.Name = "QuantidadeVendida";
            this.QuantidadeVendida.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProdutos);
            this.groupBox1.Location = new System.Drawing.Point(9, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 257);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de produtos";
            // 
            // cbxProduto
            // 
            this.cbxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(6, 42);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(428, 23);
            this.cbxProduto.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemover);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAdicionar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbxProduto);
            this.groupBox2.Location = new System.Drawing.Point(9, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 142);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicionar produtos";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(337, 87);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(97, 41);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "un.";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(218, 87);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(97, 41);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(6, 105);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 23);
            this.txtQuantidade.TabIndex = 5;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecionar produto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkIsFidelidade);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnCadastrarCliente);
            this.groupBox3.Controls.Add(this.txtPontuacao);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbxCliente);
            this.groupBox3.Location = new System.Drawing.Point(807, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 142);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // chkIsFidelidade
            // 
            this.chkIsFidelidade.AutoSize = true;
            this.chkIsFidelidade.Enabled = false;
            this.chkIsFidelidade.Location = new System.Drawing.Point(144, 77);
            this.chkIsFidelidade.Name = "chkIsFidelidade";
            this.chkIsFidelidade.Size = new System.Drawing.Size(118, 19);
            this.chkIsFidelidade.TabIndex = 11;
            this.chkIsFidelidade.Text = "Cliente fidelidade";
            this.chkIsFidelidade.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Pontuação:";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(65, 107);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(139, 27);
            this.btnCadastrarCliente.TabIndex = 7;
            this.btnCadastrarCliente.Text = "Cadastrar novo cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // txtPontuacao
            // 
            this.txtPontuacao.Location = new System.Drawing.Point(74, 73);
            this.txtPontuacao.Name = "txtPontuacao";
            this.txtPontuacao.ReadOnly = true;
            this.txtPontuacao.Size = new System.Drawing.Size(38, 23);
            this.txtPontuacao.TabIndex = 9;
            this.txtPontuacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Selecionar cliente";
            // 
            // cbxCliente
            // 
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(6, 42);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(256, 23);
            this.cbxCliente.TabIndex = 3;
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(898, 42);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(175, 41);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Finalizar venda";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(21, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 46);
            this.label7.TabIndex = 10;
            this.label7.Text = "Venda";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpDataVenda);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cbxFormaPagamento);
            this.groupBox4.Location = new System.Drawing.Point(497, 95);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 142);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados da venda";
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Location = new System.Drawing.Point(6, 105);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(256, 23);
            this.dtpDataVenda.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Forma de pagamento";
            // 
            // cbxFormaPagamento
            // 
            this.cbxFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFormaPagamento.FormattingEnabled = true;
            this.cbxFormaPagamento.Location = new System.Drawing.Point(6, 42);
            this.cbxFormaPagamento.Name = "cbxFormaPagamento";
            this.cbxFormaPagamento.Size = new System.Drawing.Size(256, 23);
            this.cbxFormaPagamento.TabIndex = 3;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(985, 6);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(88, 23);
            this.txtValorTotal.TabIndex = 15;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(920, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Valor total:";
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(21, 9);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(50, 15);
            this.lblUsuarioLogado.TabIndex = 13;
            this.lblUsuarioLogado.Text = "Usuário:";
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 520);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVenda";
            this.Text = "FormVenda";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProdutos;
        private GroupBox groupBox1;
        private ComboBox cbxProduto;
        private GroupBox groupBox2;
        private Label label3;
        private Button btnAdicionar;
        private Label label2;
        private TextBox txtQuantidade;
        private Label label1;
        private GroupBox groupBox3;
        private Button btnCadastrarCliente;
        private Label label6;
        private ComboBox cbxCliente;
        private Button btnFinalizar;
        private Label label7;
        private CheckBox chkIsFidelidade;
        private Label label8;
        private TextBox txtPontuacao;
        private GroupBox groupBox4;
        private DateTimePicker dtpDataVenda;
        private Label label5;
        private Label label4;
        private ComboBox cbxFormaPagamento;
        private TextBox txtValorTotal;
        private Label label9;
        private Label lblUsuarioLogado;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Laboratorio;
        private DataGridViewTextBoxColumn QuantidadeEstoque;
        private DataGridViewTextBoxColumn ValorUnitario;
        private DataGridViewTextBoxColumn QuantidadeVendida;
        private Button btnRemover;
    }
}