
namespace Exe1_Cadastros
{
    partial class frmNotasEntrada
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.txtNumNota = new System.Windows.Forms.TextBox();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.btnLocalizarFornecedor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLocalizarProduto = new System.Windows.Forms.Button();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.txtPrecoCustoProduto = new System.Windows.Forms.TextBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.btnInserirProduto = new System.Windows.Forms.Button();
            this.btnCancelarProduto = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalNota = new System.Windows.Forms.TextBox();
            this.btnInserirNotaEntrada = new System.Windows.Forms.Button();
            this.btnCancelarNotaEntrada = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fornecedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número Nota:";
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.Location = new System.Drawing.Point(111, 62);
            this.txtIdFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(132, 23);
            this.txtIdFornecedor.TabIndex = 4;
            this.txtIdFornecedor.TextChanged += new System.EventHandler(this.txtIdFornecedor_TextChanged);
            // 
            // txtNumNota
            // 
            this.txtNumNota.Location = new System.Drawing.Point(111, 103);
            this.txtNumNota.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumNota.Name = "txtNumNota";
            this.txtNumNota.Size = new System.Drawing.Size(132, 23);
            this.txtNumNota.TabIndex = 5;
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(279, 62);
            this.txtNomeFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.ReadOnly = true;
            this.txtNomeFornecedor.Size = new System.Drawing.Size(396, 23);
            this.txtNomeFornecedor.TabIndex = 8;
            // 
            // btnLocalizarFornecedor
            // 
            this.btnLocalizarFornecedor.Location = new System.Drawing.Point(701, 54);
            this.btnLocalizarFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnLocalizarFornecedor.Name = "btnLocalizarFornecedor";
            this.btnLocalizarFornecedor.Size = new System.Drawing.Size(141, 39);
            this.btnLocalizarFornecedor.TabIndex = 10;
            this.btnLocalizarFornecedor.Text = "Localizar";
            this.btnLocalizarFornecedor.UseVisualStyleBackColor = true;
            this.btnLocalizarFornecedor.Click += new System.EventHandler(this.btnLocalizarFornecedor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Emissão:";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(499, 106);
            this.lblEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(62, 17);
            this.lblEntrada.TabIndex = 13;
            this.lblEntrada.Text = "Entrada:";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(569, 101);
            this.dtpEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(140, 23);
            this.dtpEntrada.TabIndex = 14;
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissao.Location = new System.Drawing.Point(349, 101);
            this.dtpEmissao.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(140, 23);
            this.dtpEmissao.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quantidade:";
            // 
            // btnLocalizarProduto
            // 
            this.btnLocalizarProduto.Location = new System.Drawing.Point(701, 206);
            this.btnLocalizarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnLocalizarProduto.Name = "btnLocalizarProduto";
            this.btnLocalizarProduto.Size = new System.Drawing.Size(141, 39);
            this.btnLocalizarProduto.TabIndex = 21;
            this.btnLocalizarProduto.Text = "Localizar";
            this.btnLocalizarProduto.UseVisualStyleBackColor = true;
            this.btnLocalizarProduto.Click += new System.EventHandler(this.btnLocalizarProduto_Click);
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(279, 214);
            this.txtDescricaoProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.ReadOnly = true;
            this.txtDescricaoProduto.Size = new System.Drawing.Size(396, 23);
            this.txtDescricaoProduto.TabIndex = 20;
            // 
            // txtPrecoCustoProduto
            // 
            this.txtPrecoCustoProduto.Location = new System.Drawing.Point(111, 254);
            this.txtPrecoCustoProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoCustoProduto.Name = "txtPrecoCustoProduto";
            this.txtPrecoCustoProduto.Size = new System.Drawing.Size(132, 23);
            this.txtPrecoCustoProduto.TabIndex = 19;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(111, 214);
            this.txtIdProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(132, 23);
            this.txtIdProduto.TabIndex = 18;
            this.txtIdProduto.TextChanged += new System.EventHandler(this.txtIdProduto_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Preço Custo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 217);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Produto:";
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(370, 254);
            this.txtQuantidadeProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(132, 23);
            this.txtQuantidadeProduto.TabIndex = 23;
            // 
            // btnInserirProduto
            // 
            this.btnInserirProduto.Location = new System.Drawing.Point(20, 294);
            this.btnInserirProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserirProduto.Name = "btnInserirProduto";
            this.btnInserirProduto.Size = new System.Drawing.Size(203, 52);
            this.btnInserirProduto.TabIndex = 24;
            this.btnInserirProduto.Text = "Inserir Produto";
            this.btnInserirProduto.UseVisualStyleBackColor = true;
            this.btnInserirProduto.Click += new System.EventHandler(this.btnInserirProduto_Click);
            // 
            // btnCancelarProduto
            // 
            this.btnCancelarProduto.Location = new System.Drawing.Point(249, 294);
            this.btnCancelarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarProduto.Name = "btnCancelarProduto";
            this.btnCancelarProduto.Size = new System.Drawing.Size(203, 52);
            this.btnCancelarProduto.TabIndex = 25;
            this.btnCancelarProduto.Text = "Cancelar Produto";
            this.btnCancelarProduto.UseVisualStyleBackColor = true;
            this.btnCancelarProduto.Click += new System.EventHandler(this.btnCancelarProduto_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Id,
            this.Descrição,
            this.Quantidade,
            this.PrecoCusto,
            this.Total});
            this.dgvProdutos.Location = new System.Drawing.Point(20, 354);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(822, 244);
            this.dgvProdutos.TabIndex = 26;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // PrecoCusto
            // 
            this.PrecoCusto.HeaderText = "Preço Custo";
            this.PrecoCusto.Name = "PrecoCusto";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 628);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Total Nota:";
            // 
            // txtTotalNota
            // 
            this.txtTotalNota.Location = new System.Drawing.Point(100, 624);
            this.txtTotalNota.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalNota.Name = "txtTotalNota";
            this.txtTotalNota.Size = new System.Drawing.Size(132, 23);
            this.txtTotalNota.TabIndex = 28;
            // 
            // btnInserirNotaEntrada
            // 
            this.btnInserirNotaEntrada.Location = new System.Drawing.Point(259, 614);
            this.btnInserirNotaEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserirNotaEntrada.Name = "btnInserirNotaEntrada";
            this.btnInserirNotaEntrada.Size = new System.Drawing.Size(193, 43);
            this.btnInserirNotaEntrada.TabIndex = 29;
            this.btnInserirNotaEntrada.Text = "Inserir Nota Entrada";
            this.btnInserirNotaEntrada.UseVisualStyleBackColor = true;
            this.btnInserirNotaEntrada.Click += new System.EventHandler(this.btnInserirNotaEntrada_Click);
            // 
            // btnCancelarNotaEntrada
            // 
            this.btnCancelarNotaEntrada.Location = new System.Drawing.Point(484, 614);
            this.btnCancelarNotaEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarNotaEntrada.Name = "btnCancelarNotaEntrada";
            this.btnCancelarNotaEntrada.Size = new System.Drawing.Size(193, 43);
            this.btnCancelarNotaEntrada.TabIndex = 30;
            this.btnCancelarNotaEntrada.Text = "Cancelar Nota Entrada";
            this.btnCancelarNotaEntrada.UseVisualStyleBackColor = true;
            this.btnCancelarNotaEntrada.Click += new System.EventHandler(this.btnCancelarNotaEntrada_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 31);
            this.label6.TabIndex = 31;
            this.label6.Text = "NOTA DE ENTRADA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(253, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(372, 31);
            this.label9.TabIndex = 32;
            this.label9.Text = "PRODUTOS COMPRADOS";
            // 
            // frmNotasEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 668);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelarNotaEntrada);
            this.Controls.Add(this.btnInserirNotaEntrada);
            this.Controls.Add(this.txtTotalNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnCancelarProduto);
            this.Controls.Add(this.btnInserirProduto);
            this.Controls.Add(this.txtQuantidadeProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLocalizarProduto);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.txtPrecoCustoProduto);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpEmissao);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLocalizarFornecedor);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.txtNumNota);
            this.Controls.Add(this.txtIdFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNotasEntrada";
            this.Text = "Notas Entrada";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumNota;
        private System.Windows.Forms.Button btnLocalizarFornecedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.DateTimePicker dtpEmissao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLocalizarProduto;
        private System.Windows.Forms.TextBox txtPrecoCustoProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantidadeProduto;
        private System.Windows.Forms.Button btnInserirProduto;
        private System.Windows.Forms.Button btnCancelarProduto;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalNota;
        private System.Windows.Forms.Button btnInserirNotaEntrada;
        private System.Windows.Forms.Button btnCancelarNotaEntrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtIdFornecedor;
        public System.Windows.Forms.TextBox txtNomeFornecedor;
        public System.Windows.Forms.TextBox txtDescricaoProduto;
        public System.Windows.Forms.TextBox txtIdProduto;
    }
}