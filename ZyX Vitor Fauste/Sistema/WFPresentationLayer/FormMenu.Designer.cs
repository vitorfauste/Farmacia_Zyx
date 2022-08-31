namespace WFPresentationLayer
{
    partial class FormMenu
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
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnLaboratorio = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(12, 12);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(160, 71);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(196, 12);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(160, 71);
            this.btnProduto.TabIndex = 1;
            this.btnProduto.Text = "Produtos";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnLaboratorio
            // 
            this.btnLaboratorio.Location = new System.Drawing.Point(379, 12);
            this.btnLaboratorio.Name = "btnLaboratorio";
            this.btnLaboratorio.Size = new System.Drawing.Size(160, 71);
            this.btnLaboratorio.TabIndex = 2;
            this.btnLaboratorio.Text = "Laboratórios";
            this.btnLaboratorio.UseVisualStyleBackColor = true;
            this.btnLaboratorio.Click += new System.EventHandler(this.btnLaboratorio_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Location = new System.Drawing.Point(564, 12);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(160, 71);
            this.btnFornecedor.TabIndex = 3;
            this.btnFornecedor.Text = "Fornecedores";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(288, 128);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(160, 71);
            this.btnFuncionario.TabIndex = 4;
            this.btnFuncionario.Text = "Funcionários";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Visible = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.Location = new System.Drawing.Point(179, 230);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(160, 71);
            this.btnVenda.TabIndex = 5;
            this.btnVenda.Text = "Venda";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(400, 230);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(160, 71);
            this.btnCompra.TabIndex = 6;
            this.btnCompra.Text = "Compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 310);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.btnLaboratorio);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnCliente);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCliente;
        private Button btnProduto;
        private Button btnLaboratorio;
        private Button btnFornecedor;
        private Button btnFuncionario;
        private Button btnVenda;
        private Button btnCompra;
    }
}