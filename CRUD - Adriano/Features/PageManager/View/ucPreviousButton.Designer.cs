
namespace CRUD___Adriano.Features.PageManager.View
{
    partial class UcPreviousButton
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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(0, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(144, 39);
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "Anterior";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // ucPreviousButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrevious);
            this.Name = "ucPreviousButton";
            this.Size = new System.Drawing.Size(144, 39);
            this.Load += new System.EventHandler(this.ucPreviousButton_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnPrevious;
    }
}
