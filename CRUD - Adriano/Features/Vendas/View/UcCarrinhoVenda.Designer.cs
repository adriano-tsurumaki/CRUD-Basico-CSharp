
namespace CRUD___Adriano.Features.Vendas.View
{
    partial class UcCarrinhoVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlSubTotal = new System.Windows.Forms.Panel();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.pnlTituloCarrinho = new System.Windows.Forms.Panel();
            this.lblTituloCarrinho = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlSubTotal.SuspendLayout();
            this.pnlTituloCarrinho.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AllowUserToResizeColumns = false;
            this.gridView.AllowUserToResizeRows = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.EnableHeadersVisualStyles = false;
            this.gridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.gridView.Location = new System.Drawing.Point(0, 43);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowTemplate.Height = 25;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(572, 375);
            this.gridView.TabIndex = 6;
            this.gridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridView_CellFormatting);
            this.gridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellValueChanged);
            this.gridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GridView_DataError);
            this.gridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GridView_MouseDown);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottom.Controls.Add(this.pnlSubTotal);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 418);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(572, 49);
            this.pnlBottom.TabIndex = 7;
            // 
            // pnlSubTotal
            // 
            this.pnlSubTotal.Controls.Add(this.lblSubTotal);
            this.pnlSubTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSubTotal.Location = new System.Drawing.Point(324, 0);
            this.pnlSubTotal.Name = "pnlSubTotal";
            this.pnlSubTotal.Size = new System.Drawing.Size(246, 47);
            this.pnlSubTotal.TabIndex = 1;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotal.ForeColor = System.Drawing.Color.White;
            this.lblSubTotal.Location = new System.Drawing.Point(0, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(246, 47);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "SubTotal (12 itens): R$ 9999,00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTituloCarrinho
            // 
            this.pnlTituloCarrinho.Controls.Add(this.lblTituloCarrinho);
            this.pnlTituloCarrinho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloCarrinho.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloCarrinho.Name = "pnlTituloCarrinho";
            this.pnlTituloCarrinho.Size = new System.Drawing.Size(572, 43);
            this.pnlTituloCarrinho.TabIndex = 2;
            // 
            // lblTituloCarrinho
            // 
            this.lblTituloCarrinho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTituloCarrinho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloCarrinho.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloCarrinho.ForeColor = System.Drawing.Color.White;
            this.lblTituloCarrinho.Location = new System.Drawing.Point(0, 0);
            this.lblTituloCarrinho.Name = "lblTituloCarrinho";
            this.lblTituloCarrinho.Size = new System.Drawing.Size(572, 43);
            this.lblTituloCarrinho.TabIndex = 1;
            this.lblTituloCarrinho.Text = "Carrinho";
            this.lblTituloCarrinho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcCarrinhoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.pnlTituloCarrinho);
            this.Controls.Add(this.pnlBottom);
            this.Name = "UcCarrinhoVenda";
            this.Size = new System.Drawing.Size(572, 467);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlSubTotal.ResumeLayout(false);
            this.pnlTituloCarrinho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlSubTotal;
        internal System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Panel pnlTituloCarrinho;
        internal System.Windows.Forms.Label lblTituloCarrinho;
    }
}
