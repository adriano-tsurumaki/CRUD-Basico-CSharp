
namespace CRUD___Adriano.Features.PageManager.View
{
    partial class UcFooter
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBottomRight = new System.Windows.Forms.Panel();
            this.pnlBottomsRight = new System.Windows.Forms.Panel();
            this.pnlBottomLeft = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlBottomsRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlBottomsRight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 57);
            this.panel1.TabIndex = 0;
            // 
            // pnlBottomRight
            // 
            this.pnlBottomRight.Location = new System.Drawing.Point(191, 10);
            this.pnlBottomRight.Name = "pnlBottomRight";
            this.pnlBottomRight.Size = new System.Drawing.Size(144, 38);
            this.pnlBottomRight.TabIndex = 0;
            // 
            // pnlBottomsRight
            // 
            this.pnlBottomsRight.Controls.Add(this.pnlBottomLeft);
            this.pnlBottomsRight.Controls.Add(this.pnlBottomRight);
            this.pnlBottomsRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBottomsRight.Location = new System.Drawing.Point(84, 0);
            this.pnlBottomsRight.Name = "pnlBottomsRight";
            this.pnlBottomsRight.Size = new System.Drawing.Size(346, 57);
            this.pnlBottomsRight.TabIndex = 1;
            // 
            // pnlBottomLeft
            // 
            this.pnlBottomLeft.Location = new System.Drawing.Point(25, 10);
            this.pnlBottomLeft.Name = "pnlBottomLeft";
            this.pnlBottomLeft.Size = new System.Drawing.Size(144, 38);
            this.pnlBottomLeft.TabIndex = 1;
            // 
            // FrmFooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "FrmFooter";
            this.Size = new System.Drawing.Size(430, 57);
            this.panel1.ResumeLayout(false);
            this.pnlBottomsRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBottomsRight;
        public System.Windows.Forms.Panel pnlBottomRight;
        public System.Windows.Forms.Panel pnlBottomLeft;
    }
}
