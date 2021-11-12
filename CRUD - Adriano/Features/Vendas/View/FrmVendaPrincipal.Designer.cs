
namespace CRUD___Adriano.Features.Vendas.View
{
    partial class FrmVendaPrincipal
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlLeftCentral = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlRightCentral = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1183, 96);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlLeftCentral
            // 
            this.pnlLeftCentral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftCentral.Location = new System.Drawing.Point(0, 96);
            this.pnlLeftCentral.Name = "pnlLeftCentral";
            this.pnlLeftCentral.Size = new System.Drawing.Size(601, 547);
            this.pnlLeftCentral.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 643);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1183, 100);
            this.pnlFooter.TabIndex = 2;
            // 
            // pnlRightCentral
            // 
            this.pnlRightCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightCentral.Location = new System.Drawing.Point(601, 96);
            this.pnlRightCentral.Name = "pnlRightCentral";
            this.pnlRightCentral.Size = new System.Drawing.Size(582, 547);
            this.pnlRightCentral.TabIndex = 2;
            // 
            // FrmVendaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1183, 743);
            this.Controls.Add(this.pnlRightCentral);
            this.Controls.Add(this.pnlLeftCentral);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmVendaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVendaPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmVendaPrincipal_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlLeftCentral;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlRightCentral;
    }
}