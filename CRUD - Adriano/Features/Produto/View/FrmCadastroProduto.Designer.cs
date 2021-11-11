
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
            this.txtFornecedor = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.btnProcurarFornecedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtFornecedor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFornecedor.BorderSize = 2;
            this.txtFornecedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFornecedor.ForeColor = System.Drawing.Color.DimGray;
            this.txtFornecedor.Location = new System.Drawing.Point(13, 42);
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
            // 
            // btnProcurarFornecedor
            // 
            this.btnProcurarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurarFornecedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcurarFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnProcurarFornecedor.Location = new System.Drawing.Point(286, 42);
            this.btnProcurarFornecedor.Name = "btnProcurarFornecedor";
            this.btnProcurarFornecedor.Size = new System.Drawing.Size(105, 36);
            this.btnProcurarFornecedor.TabIndex = 1;
            this.btnProcurarFornecedor.Text = "Procurar";
            this.btnProcurarFornecedor.UseVisualStyleBackColor = true;
            this.btnProcurarFornecedor.Click += new System.EventHandler(this.BtnProcurarFornecedor_Click);
            // 
            // FrmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcurarFornecedor);
            this.Controls.Add(this.txtFornecedor);
            this.Name = "FrmCadastroProduto";
            this.Text = "FrmProdutoCadastro";
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.TextBoxFlat txtFornecedor;
        private System.Windows.Forms.Button btnProcurarFornecedor;
    }
}