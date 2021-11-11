
namespace CRUD___Adriano.Features.Fornecedor.View
{
    partial class FrmCadastroFornecedor
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
            this.txtObservacao = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtCnpj = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.SuspendLayout();
            // 
            // txtObservacao
            // 
            this.txtObservacao.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.txtObservacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtObservacao.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtObservacao.BorderSize = 2;
            this.txtObservacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtObservacao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtObservacao.Location = new System.Drawing.Point(12, 117);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacao.MaxLength = 500;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Padding = new System.Windows.Forms.Padding(7);
            this.txtObservacao.PasswordChar = false;
            this.txtObservacao.SelectionLength = 0;
            this.txtObservacao.SelectionStart = 0;
            this.txtObservacao.Size = new System.Drawing.Size(617, 134);
            this.txtObservacao.TabIndex = 5;
            this.txtObservacao.Texto = "";
            this.txtObservacao.UnderlinedStyle = false;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblObservacao.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblObservacao.Location = new System.Drawing.Point(12, 92);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(97, 21);
            this.lblObservacao.TabIndex = 6;
            this.lblObservacao.Text = "Observação";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCnpj.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblCnpj.Location = new System.Drawing.Point(12, 9);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(43, 21);
            this.lblCnpj.TabIndex = 29;
            this.lblCnpj.Text = "Cpf*";
            // 
            // txtCnpj
            // 
            this.txtCnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtCnpj.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCnpj.BorderSize = 2;
            this.txtCnpj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCnpj.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCnpj.Location = new System.Drawing.Point(12, 36);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(4);
            this.txtCnpj.MaxLength = 14;
            this.txtCnpj.Multiline = false;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Padding = new System.Windows.Forms.Padding(7);
            this.txtCnpj.PasswordChar = false;
            this.txtCnpj.SelectionLength = 0;
            this.txtCnpj.SelectionStart = 0;
            this.txtCnpj.Size = new System.Drawing.Size(212, 36);
            this.txtCnpj.TabIndex = 28;
            this.txtCnpj.Texto = "";
            this.txtCnpj.UnderlinedStyle = true;
            this.txtCnpj._TextChanged += new System.EventHandler(this.TxtCnpj__TextChanged);
            // 
            // FrmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(679, 423);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Name = "FrmCadastroFornecedor";
            this.Text = "FrmCadastroFornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.TextBoxFlat txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblCnpj;
        private Componentes.TextBoxFlat txtCnpj;
    }
}