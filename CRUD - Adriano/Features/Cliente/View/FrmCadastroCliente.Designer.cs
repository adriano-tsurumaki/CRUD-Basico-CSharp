
namespace CRUD___Adriano.Features.Cliente.View
{
    partial class FrmCadastroCliente
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
            this.txtValorLimite = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblValorLimite = new System.Windows.Forms.Label();
            this.txtObservacao = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValorLimite
            // 
            this.txtValorLimite.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.txtValorLimite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtValorLimite.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtValorLimite.BorderSize = 2;
            this.txtValorLimite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorLimite.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtValorLimite.Location = new System.Drawing.Point(12, 34);
            this.txtValorLimite.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorLimite.MaxLength = 13;
            this.txtValorLimite.Multiline = false;
            this.txtValorLimite.Name = "txtValorLimite";
            this.txtValorLimite.Padding = new System.Windows.Forms.Padding(7);
            this.txtValorLimite.PasswordChar = false;
            this.txtValorLimite.SelectionLength = 0;
            this.txtValorLimite.SelectionStart = 0;
            this.txtValorLimite.Size = new System.Drawing.Size(287, 36);
            this.txtValorLimite.TabIndex = 1;
            this.txtValorLimite.Texto = "";
            this.txtValorLimite.UnderlinedStyle = true;
            this.txtValorLimite._TextChanged += new System.EventHandler(this.TxtValorLimite__TextChanged);
            // 
            // lblValorLimite
            // 
            this.lblValorLimite.AutoSize = true;
            this.lblValorLimite.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorLimite.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblValorLimite.Location = new System.Drawing.Point(12, 9);
            this.lblValorLimite.Name = "lblValorLimite";
            this.lblValorLimite.Size = new System.Drawing.Size(216, 21);
            this.lblValorLimite.TabIndex = 2;
            this.lblValorLimite.Text = "Valor limite compra a prazo*";
            // 
            // txtObservacao
            // 
            this.txtObservacao.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.txtObservacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtObservacao.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtObservacao.BorderSize = 2;
            this.txtObservacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtObservacao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtObservacao.Location = new System.Drawing.Point(12, 110);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacao.MaxLength = 500;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Padding = new System.Windows.Forms.Padding(7);
            this.txtObservacao.PasswordChar = false;
            this.txtObservacao.SelectionLength = 0;
            this.txtObservacao.SelectionStart = 0;
            this.txtObservacao.Size = new System.Drawing.Size(617, 134);
            this.txtObservacao.TabIndex = 2;
            this.txtObservacao.Texto = "";
            this.txtObservacao.UnderlinedStyle = false;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblObservacao.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblObservacao.Location = new System.Drawing.Point(12, 85);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(97, 21);
            this.lblObservacao.TabIndex = 4;
            this.lblObservacao.Text = "Observação";
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtValorLimite);
            this.Controls.Add(this.lblValorLimite);
            this.KeyPreview = true;
            this.Name = "FrmCadastroCliente";
            this.Text = "FrmCadastroCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.TextBoxFlat txtValorLimite;
        private System.Windows.Forms.Label lblValorLimite;
        private Componentes.TextBoxFlat txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
    }
}