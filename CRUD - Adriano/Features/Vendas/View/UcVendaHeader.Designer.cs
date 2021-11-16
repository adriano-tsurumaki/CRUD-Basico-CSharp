
namespace CRUD___Adriano.Features.Vendas.View
{
    partial class UcVendaHeader
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
            this.components = new System.ComponentModel.Container();
            this.pnlVendedor = new System.Windows.Forms.Panel();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblTituloVendedor = new System.Windows.Forms.Label();
            this.pnlHorario = new System.Windows.Forms.Panel();
            this.lblHorario = new System.Windows.Forms.Label();
            this.timerHorario = new System.Windows.Forms.Timer(this.components);
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTituloCliente = new System.Windows.Forms.Label();
            this.pnlVendedor.SuspendLayout();
            this.pnlHorario.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVendedor
            // 
            this.pnlVendedor.Controls.Add(this.lblVendedor);
            this.pnlVendedor.Controls.Add(this.lblTituloVendedor);
            this.pnlVendedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlVendedor.Location = new System.Drawing.Point(973, 0);
            this.pnlVendedor.Name = "pnlVendedor";
            this.pnlVendedor.Size = new System.Drawing.Size(210, 96);
            this.pnlVendedor.TabIndex = 0;
            // 
            // lblVendedor
            // 
            this.lblVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVendedor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVendedor.ForeColor = System.Drawing.Color.White;
            this.lblVendedor.Location = new System.Drawing.Point(0, 26);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(210, 70);
            this.lblVendedor.TabIndex = 2;
            this.lblVendedor.Text = "Administrador";
            this.lblVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloVendedor
            // 
            this.lblTituloVendedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloVendedor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloVendedor.ForeColor = System.Drawing.Color.White;
            this.lblTituloVendedor.Location = new System.Drawing.Point(0, 0);
            this.lblTituloVendedor.Name = "lblTituloVendedor";
            this.lblTituloVendedor.Size = new System.Drawing.Size(210, 26);
            this.lblTituloVendedor.TabIndex = 1;
            this.lblTituloVendedor.Text = "Vendedor";
            this.lblTituloVendedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pnlHorario
            // 
            this.pnlHorario.Controls.Add(this.lblHorario);
            this.pnlHorario.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlHorario.Location = new System.Drawing.Point(686, 0);
            this.pnlHorario.Name = "pnlHorario";
            this.pnlHorario.Size = new System.Drawing.Size(287, 96);
            this.pnlHorario.TabIndex = 1;
            // 
            // lblHorario
            // 
            this.lblHorario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHorario.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(0, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(287, 96);
            this.lblHorario.TabIndex = 3;
            this.lblHorario.Text = "12:00:00";
            this.lblHorario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerHorario
            // 
            this.timerHorario.Enabled = true;
            this.timerHorario.Interval = 1000;
            this.timerHorario.Tick += new System.EventHandler(this.TimerHorario_Tick);
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.lblCliente);
            this.pnlCliente.Controls.Add(this.lblTituloCliente);
            this.pnlCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCliente.Location = new System.Drawing.Point(0, 0);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(210, 96);
            this.pnlCliente.TabIndex = 2;
            // 
            // lblCliente
            // 
            this.lblCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(0, 26);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(210, 70);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente não selecionado";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCliente.Click += new System.EventHandler(this.LblCliente_Click);
            // 
            // lblTituloCliente
            // 
            this.lblTituloCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloCliente.ForeColor = System.Drawing.Color.White;
            this.lblTituloCliente.Location = new System.Drawing.Point(0, 0);
            this.lblTituloCliente.Name = "lblTituloCliente";
            this.lblTituloCliente.Size = new System.Drawing.Size(210, 26);
            this.lblTituloCliente.TabIndex = 1;
            this.lblTituloCliente.Text = "Cliente";
            this.lblTituloCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // UcVendaHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.pnlHorario);
            this.Controls.Add(this.pnlVendedor);
            this.Name = "UcVendaHeader";
            this.Size = new System.Drawing.Size(1183, 96);
            this.pnlVendedor.ResumeLayout(false);
            this.pnlHorario.ResumeLayout(false);
            this.pnlCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblTituloVendedor;
        private System.Windows.Forms.Panel pnlHorario;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Timer timerHorario;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTituloCliente;
    }
}
