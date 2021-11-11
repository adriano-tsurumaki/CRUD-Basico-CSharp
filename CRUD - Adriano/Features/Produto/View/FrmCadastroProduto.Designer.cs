
namespace CRUD___Adriano.Features.Produto.View
{
    partial class FrmCadastroProduto
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
            this.btnProcurarFornecedor = new System.Windows.Forms.Button();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.txtFornecedor = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblPrecoBruto = new System.Windows.Forms.Label();
            this.txtPrecoBruto = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblLucro = new System.Windows.Forms.Label();
            this.txtLucro = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.SuspendLayout();
            // 
            // btnProcurarFornecedor
            // 
            this.btnProcurarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurarFornecedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcurarFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnProcurarFornecedor.Location = new System.Drawing.Point(294, 60);
            this.btnProcurarFornecedor.Name = "btnProcurarFornecedor";
            this.btnProcurarFornecedor.Size = new System.Drawing.Size(105, 36);
            this.btnProcurarFornecedor.TabIndex = 1;
            this.btnProcurarFornecedor.Text = "Procurar";
            this.btnProcurarFornecedor.UseVisualStyleBackColor = true;
            this.btnProcurarFornecedor.Click += new System.EventHandler(this.BtnProcurarFornecedor_Click);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFornecedor.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblFornecedor.Location = new System.Drawing.Point(12, 24);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(102, 21);
            this.lblFornecedor.TabIndex = 2;
            this.lblFornecedor.Text = "Fornecedor*";
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoBarras.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblCodigoBarras.Location = new System.Drawing.Point(12, 111);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(143, 21);
            this.lblCodigoBarras.TabIndex = 5;
            this.lblCodigoBarras.Text = "Código de barras*";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtCodigoBarras.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCodigoBarras.BorderSize = 2;
            this.txtCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigoBarras.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigoBarras.Location = new System.Drawing.Point(12, 147);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoBarras.MaxLength = 32767;
            this.txtCodigoBarras.Multiline = false;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodigoBarras.PasswordChar = false;
            this.txtCodigoBarras.SelectionLength = 0;
            this.txtCodigoBarras.SelectionStart = 0;
            this.txtCodigoBarras.Size = new System.Drawing.Size(250, 36);
            this.txtCodigoBarras.TabIndex = 3;
            this.txtCodigoBarras.Texto = "";
            this.txtCodigoBarras.UnderlinedStyle = true;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtFornecedor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFornecedor.BorderSize = 2;
            this.txtFornecedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFornecedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFornecedor.Location = new System.Drawing.Point(12, 60);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtFornecedor.MaxLength = 32767;
            this.txtFornecedor.Multiline = false;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Padding = new System.Windows.Forms.Padding(7);
            this.txtFornecedor.PasswordChar = false;
            this.txtFornecedor.SelectionLength = 0;
            this.txtFornecedor.SelectionStart = 0;
            this.txtFornecedor.Size = new System.Drawing.Size(250, 36);
            this.txtFornecedor.TabIndex = 0;
            this.txtFornecedor.Texto = "";
            this.txtFornecedor.UnderlinedStyle = false;
            this.txtFornecedor._KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFornecedor__KeyDown);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(294, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNome.Location = new System.Drawing.Point(12, 198);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 21);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome*";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtNome.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNome.BorderSize = 2;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNome.Location = new System.Drawing.Point(12, 234);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(7);
            this.txtNome.PasswordChar = false;
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(250, 36);
            this.txtNome.TabIndex = 6;
            this.txtNome.Texto = "";
            this.txtNome.UnderlinedStyle = true;
            // 
            // lblPrecoBruto
            // 
            this.lblPrecoBruto.AutoSize = true;
            this.lblPrecoBruto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecoBruto.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblPrecoBruto.Location = new System.Drawing.Point(12, 285);
            this.lblPrecoBruto.Name = "lblPrecoBruto";
            this.lblPrecoBruto.Size = new System.Drawing.Size(104, 21);
            this.lblPrecoBruto.TabIndex = 9;
            this.lblPrecoBruto.Text = "Preço bruto*";
            // 
            // txtPrecoBruto
            // 
            this.txtPrecoBruto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtPrecoBruto.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPrecoBruto.BorderSize = 2;
            this.txtPrecoBruto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecoBruto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecoBruto.Location = new System.Drawing.Point(12, 321);
            this.txtPrecoBruto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoBruto.MaxLength = 32767;
            this.txtPrecoBruto.Multiline = false;
            this.txtPrecoBruto.Name = "txtPrecoBruto";
            this.txtPrecoBruto.Padding = new System.Windows.Forms.Padding(7);
            this.txtPrecoBruto.PasswordChar = false;
            this.txtPrecoBruto.SelectionLength = 0;
            this.txtPrecoBruto.SelectionStart = 0;
            this.txtPrecoBruto.Size = new System.Drawing.Size(250, 36);
            this.txtPrecoBruto.TabIndex = 8;
            this.txtPrecoBruto.Texto = "";
            this.txtPrecoBruto.UnderlinedStyle = true;
            // 
            // lblLucro
            // 
            this.lblLucro.AutoSize = true;
            this.lblLucro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLucro.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblLucro.Location = new System.Drawing.Point(294, 285);
            this.lblLucro.Name = "lblLucro";
            this.lblLucro.Size = new System.Drawing.Size(85, 21);
            this.lblLucro.TabIndex = 11;
            this.lblLucro.Text = "Lucro (%)*";
            // 
            // txtLucro
            // 
            this.txtLucro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtLucro.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLucro.BorderSize = 2;
            this.txtLucro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLucro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLucro.Location = new System.Drawing.Point(294, 321);
            this.txtLucro.Margin = new System.Windows.Forms.Padding(4);
            this.txtLucro.MaxLength = 32767;
            this.txtLucro.Multiline = false;
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Padding = new System.Windows.Forms.Padding(7);
            this.txtLucro.PasswordChar = false;
            this.txtLucro.SelectionLength = 0;
            this.txtLucro.SelectionStart = 0;
            this.txtLucro.Size = new System.Drawing.Size(250, 36);
            this.txtLucro.TabIndex = 10;
            this.txtLucro.Texto = "";
            this.txtLucro.UnderlinedStyle = true;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidade.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblQuantidade.Location = new System.Drawing.Point(294, 198);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(189, 21);
            this.lblQuantidade.TabIndex = 13;
            this.lblQuantidade.Text = "Quantidade no estoque*";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtQuantidade.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtQuantidade.BorderSize = 2;
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantidade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuantidade.Location = new System.Drawing.Point(294, 234);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.Multiline = false;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Padding = new System.Windows.Forms.Padding(7);
            this.txtQuantidade.PasswordChar = false;
            this.txtQuantidade.SelectionLength = 0;
            this.txtQuantidade.SelectionStart = 0;
            this.txtQuantidade.Size = new System.Drawing.Size(250, 36);
            this.txtQuantidade.TabIndex = 12;
            this.txtQuantidade.Texto = "";
            this.txtQuantidade.UnderlinedStyle = true;
            // 
            // FrmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(560, 377);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblLucro);
            this.Controls.Add(this.txtLucro);
            this.Controls.Add(this.lblPrecoBruto);
            this.Controls.Add(this.txtPrecoBruto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCodigoBarras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.btnProcurarFornecedor);
            this.Controls.Add(this.txtFornecedor);
            this.Name = "FrmCadastroProduto";
            this.Text = "FrmProdutoCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProcurarFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblCodigoBarras;
        private Componentes.TextBoxFlat txtCodigoBarras;
        private Componentes.TextBoxFlat txtFornecedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNome;
        private Componentes.TextBoxFlat txtNome;
        private System.Windows.Forms.Label lblPrecoBruto;
        private Componentes.TextBoxFlat txtPrecoBruto;
        private System.Windows.Forms.Label lblLucro;
        private Componentes.TextBoxFlat txtLucro;
        private System.Windows.Forms.Label lblQuantidade;
        private Componentes.TextBoxFlat txtQuantidade;
    }
}