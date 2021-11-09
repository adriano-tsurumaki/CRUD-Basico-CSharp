
namespace CRUD___Adriano.Features.Configuration.Login.View
{
    partial class FrmLogin
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
            this.textBoxFlat1 = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.textBoxFlat2 = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblTituloLogo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFlat1
            // 
            this.textBoxFlat1.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxFlat1.BorderColor = System.Drawing.Color.Black;
            this.textBoxFlat1.BorderSize = 2;
            this.textBoxFlat1.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxFlat1.Location = new System.Drawing.Point(279, 189);
            this.textBoxFlat1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFlat1.MaxLength = 32767;
            this.textBoxFlat1.Multiline = false;
            this.textBoxFlat1.Name = "textBoxFlat1";
            this.textBoxFlat1.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxFlat1.PasswordChar = false;
            this.textBoxFlat1.SelectionLength = 0;
            this.textBoxFlat1.SelectionStart = 0;
            this.textBoxFlat1.Size = new System.Drawing.Size(250, 30);
            this.textBoxFlat1.TabIndex = 0;
            this.textBoxFlat1.Texto = "";
            this.textBoxFlat1.UnderlinedStyle = true;
            // 
            // textBoxFlat2
            // 
            this.textBoxFlat2.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxFlat2.BorderColor = System.Drawing.Color.Black;
            this.textBoxFlat2.BorderSize = 2;
            this.textBoxFlat2.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxFlat2.Location = new System.Drawing.Point(279, 279);
            this.textBoxFlat2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFlat2.MaxLength = 32767;
            this.textBoxFlat2.Multiline = false;
            this.textBoxFlat2.Name = "textBoxFlat2";
            this.textBoxFlat2.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxFlat2.PasswordChar = true;
            this.textBoxFlat2.SelectionLength = 0;
            this.textBoxFlat2.SelectionStart = 0;
            this.textBoxFlat2.Size = new System.Drawing.Size(250, 30);
            this.textBoxFlat2.TabIndex = 1;
            this.textBoxFlat2.Texto = "";
            this.textBoxFlat2.UnderlinedStyle = true;
            // 
            // lblTituloLogo
            // 
            this.lblTituloLogo.AutoSize = true;
            this.lblTituloLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloLogo.Location = new System.Drawing.Point(312, 66);
            this.lblTituloLogo.Name = "lblTituloLogo";
            this.lblTituloLogo.Size = new System.Drawing.Size(194, 32);
            this.lblTituloLogo.TabIndex = 2;
            this.lblTituloLogo.Text = "Augusto Fashion";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(279, 164);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 21);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.Location = new System.Drawing.Point(279, 254);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(54, 21);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // btnEntrar
            // 
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntrar.Location = new System.Drawing.Point(362, 374);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(93, 33);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTituloLogo);
            this.Controls.Add(this.textBoxFlat2);
            this.Controls.Add(this.textBoxFlat1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.TextBoxFlat textBoxFlat1;
        private Componentes.TextBoxFlat textBoxFlat2;
        private System.Windows.Forms.Label lblTituloLogo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnEntrar;
    }
}