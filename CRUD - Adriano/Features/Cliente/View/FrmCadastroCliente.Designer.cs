
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
            this.txtNome = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtObservacao = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtNome.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNome.BorderSize = 2;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNome.Location = new System.Drawing.Point(12, 37);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(7);
            this.txtNome.PasswordChar = false;
            this.txtNome.Size = new System.Drawing.Size(237, 36);
            this.txtNome.TabIndex = 3;
            this.txtNome.Texto = "";
            this.txtNome.UnderlinedStyle = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(237, 21);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Valor limite para conta a prazo*";
            // 
            // txtObservacao
            // 
            this.txtObservacao.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.txtObservacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtObservacao.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtObservacao.BorderSize = 2;
            this.txtObservacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtObservacao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtObservacao.Location = new System.Drawing.Point(12, 112);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacao.Multiline = false;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Padding = new System.Windows.Forms.Padding(7);
            this.txtObservacao.PasswordChar = false;
            this.txtObservacao.Size = new System.Drawing.Size(237, 36);
            this.txtObservacao.TabIndex = 5;
            this.txtObservacao.Texto = "";
            this.txtObservacao.UnderlinedStyle = true;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblObservacao.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblObservacao.Location = new System.Drawing.Point(12, 84);
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
            this.ClientSize = new System.Drawing.Size(286, 195);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmCadastroCliente";
            this.Text = "FrmCadastroCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.TextBoxFlat txtNome;
        private System.Windows.Forms.Label lblNome;
        private Componentes.TextBoxFlat txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
    }
}