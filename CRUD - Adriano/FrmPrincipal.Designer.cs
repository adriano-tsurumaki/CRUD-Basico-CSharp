
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClienteCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFuncionarioCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClientesListagem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuCadastro,
            this.listagemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMenuCadastro
            // 
            this.btnMenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClienteCadastro,
            this.btnFuncionarioCadastro});
            this.btnMenuCadastro.Name = "btnMenuCadastro";
            this.btnMenuCadastro.Size = new System.Drawing.Size(66, 20);
            this.btnMenuCadastro.Text = "Cadastro";
            // 
            // btnClienteCadastro
            // 
            this.btnClienteCadastro.Name = "btnClienteCadastro";
            this.btnClienteCadastro.Size = new System.Drawing.Size(180, 22);
            this.btnClienteCadastro.Text = "Cliente";
            this.btnClienteCadastro.Click += new System.EventHandler(this.BtnClienteCadastro_Click);
            // 
            // btnFuncionarioCadastro
            // 
            this.btnFuncionarioCadastro.Name = "btnFuncionarioCadastro";
            this.btnFuncionarioCadastro.Size = new System.Drawing.Size(180, 22);
            this.btnFuncionarioCadastro.Text = "Funcionário";
            // 
            // listagemToolStripMenuItem
            // 
            this.listagemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientesListagem});
            this.listagemToolStripMenuItem.Name = "listagemToolStripMenuItem";
            this.listagemToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.listagemToolStripMenuItem.Text = "Listagem";
            // 
            // btnClientesListagem
            // 
            this.btnClientesListagem.Name = "btnClientesListagem";
            this.btnClientesListagem.Size = new System.Drawing.Size(180, 22);
            this.btnClientesListagem.Text = "Clientes";
            this.btnClientesListagem.Click += new System.EventHandler(this.BtnClientesListagem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem btnClienteCadastro;
        private System.Windows.Forms.ToolStripMenuItem btnFuncionarioCadastro;
        private System.Windows.Forms.ToolStripMenuItem listagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnClientesListagem;
    }
}

