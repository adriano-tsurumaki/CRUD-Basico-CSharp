
namespace CRUD___Adriano.Features.Colaborador.View
{
    partial class FrmCadastroColaborador
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
            this.txtSalario = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtComissao = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblComissao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.txtSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtSalario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSalario.BorderSize = 2;
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSalario.Location = new System.Drawing.Point(12, 34);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalario.Multiline = false;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Padding = new System.Windows.Forms.Padding(7);
            this.txtSalario.PasswordChar = false;
            this.txtSalario.Size = new System.Drawing.Size(287, 36);
            this.txtSalario.TabIndex = 5;
            this.txtSalario.Texto = "";
            this.txtSalario.UnderlinedStyle = true;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalario.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblSalario.Location = new System.Drawing.Point(12, 9);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(66, 21);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salario*";
            // 
            // txtComissao
            // 
            this.txtComissao.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.txtComissao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtComissao.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtComissao.BorderSize = 2;
            this.txtComissao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComissao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtComissao.Location = new System.Drawing.Point(12, 126);
            this.txtComissao.Margin = new System.Windows.Forms.Padding(4);
            this.txtComissao.Multiline = false;
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Padding = new System.Windows.Forms.Padding(7);
            this.txtComissao.PasswordChar = false;
            this.txtComissao.Size = new System.Drawing.Size(287, 36);
            this.txtComissao.TabIndex = 7;
            this.txtComissao.Texto = "";
            this.txtComissao.UnderlinedStyle = true;
            // 
            // lblComissao
            // 
            this.lblComissao.AutoSize = true;
            this.lblComissao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComissao.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblComissao.Location = new System.Drawing.Point(12, 101);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(87, 21);
            this.lblComissao.TabIndex = 6;
            this.lblComissao.Text = "Comissão*";
            // 
            // FrmCadastroColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.lblComissao);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.KeyPreview = true;
            this.Name = "FrmCadastroColaborador";
            this.Text = "FrmCadastroColaborador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.TextBoxFlat txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private Componentes.TextBoxFlat txtComissao;
        private System.Windows.Forms.Label lblComissao;
    }
}