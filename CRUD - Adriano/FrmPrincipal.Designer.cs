
namespace CRUD___Adriano
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTelaCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTelaCadastro
            // 
            this.btnTelaCadastro.Location = new System.Drawing.Point(135, 193);
            this.btnTelaCadastro.Name = "btnTelaCadastro";
            this.btnTelaCadastro.Size = new System.Drawing.Size(140, 23);
            this.btnTelaCadastro.TabIndex = 0;
            this.btnTelaCadastro.Text = "Abrir tela de cadastro";
            this.btnTelaCadastro.UseVisualStyleBackColor = true;
            this.btnTelaCadastro.Click += new System.EventHandler(this.BtnTelaCadastro_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTelaCadastro);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTelaCadastro;
    }
}

