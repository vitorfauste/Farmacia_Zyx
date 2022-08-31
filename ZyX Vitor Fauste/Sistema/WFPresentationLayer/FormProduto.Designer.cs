namespace WFPresentationLayer
{
    partial class FormProduto
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbxLaboratorio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantEstoque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mktxtLucro = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(311, 435);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(409, 435);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(94, 341);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(92, 34);
            this.btnAtualizar.TabIndex = 321312;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Descricao,
            this.Laboratorio,
            this.ValorUnitario,
            this.QuantidadeEstoque,
            this.Lucro});
            this.dgvProdutos.Location = new System.Drawing.Point(311, 12);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowTemplate.Height = 25;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(662, 397);
            this.dgvProdutos.TabIndex = 70;
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
            // ValorUnitario
            // 
            this.ValorUnitario.HeaderText = "Valor unit.";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.ReadOnly = true;
            // 
            // QuantidadeEstoque
            // 
            this.QuantidadeEstoque.HeaderText = "Estoque";
            this.QuantidadeEstoque.Name = "QuantidadeEstoque";
            this.QuantidadeEstoque.ReadOnly = true;
            // 
            // Lucro
            // 
            this.Lucro.HeaderText = "Lucro";
            this.Lucro.Name = "Lucro";
            this.Lucro.ReadOnly = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(94, 341);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(92, 34);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 54;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 34);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(39, 23);
            this.txtID.TabIndex = 53;
            this.txtID.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 48;
            this.label2.Text = "Descrição";
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(12, 78);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(40, 15);
            this.lblNomeFuncionario.TabIndex = 46;
            this.lblNomeFuncionario.Text = "Nome";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 157);
            this.txtDescricao.MaxLength = 250;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(262, 23);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 96);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(262, 23);
            this.txtNome.TabIndex = 1;
            // 
            // cbxLaboratorio
            // 
            this.cbxLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLaboratorio.FormattingEnabled = true;
            this.cbxLaboratorio.Location = new System.Drawing.Point(12, 219);
            this.cbxLaboratorio.Name = "cbxLaboratorio";
            this.cbxLaboratorio.Size = new System.Drawing.Size(121, 23);
            this.cbxLaboratorio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 75;
            this.label3.Text = "Laboratório";
            // 
            // txtQuantEstoque
            // 
            this.txtQuantEstoque.Location = new System.Drawing.Point(12, 281);
            this.txtQuantEstoque.Name = "txtQuantEstoque";
            this.txtQuantEstoque.Size = new System.Drawing.Size(100, 23);
            this.txtQuantEstoque.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 78;
            this.label1.Text = "Quant. estoque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 79;
            this.label4.Text = "Lucro (%)";
            // 
            // mktxtLucro
            // 
            this.mktxtLucro.Location = new System.Drawing.Point(174, 281);
            this.mktxtLucro.Name = "mktxtLucro";
            this.mktxtLucro.Size = new System.Drawing.Size(100, 23);
            this.mktxtLucro.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 82;
            this.label5.Text = "Valor unitário (R$)";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(174, 219);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(100, 23);
            this.txtValorUnitario.TabIndex = 4;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 469);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.mktxtLucro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantEstoque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxLaboratorio);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Name = "FormProduto";
            this.Text = "FormProduto";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNovo;
        private Button btnExcluir;
        private Button btnAtualizar;
        private DataGridView dgvProdutos;
        private Button btnCadastrar;
        private Label lblID;
        private TextBox txtID;
        private Label label2;
        private Label lblNomeFuncionario;
        private TextBox txtDescricao;
        private TextBox txtNome;
        private ComboBox cbxLaboratorio;
        private Label label3;
        private TextBox txtQuantEstoque;
        private Label label1;
        private Label label4;
        private MaskedTextBox mktxtLucro;
        private Label label5;
        private TextBox txtValorUnitario;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Laboratorio;
        private DataGridViewTextBoxColumn ValorUnitario;
        private DataGridViewTextBoxColumn QuantidadeEstoque;
        private DataGridViewTextBoxColumn Lucro;
    }
}