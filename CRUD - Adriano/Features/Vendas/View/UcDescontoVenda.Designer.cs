
namespace CRUD___Adriano.Features.Vendas.View
{
    partial class UcDescontoVenda
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
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.checkDescontoGeral = new System.Windows.Forms.CheckBox();
            this.txtDesconto = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.Controls.Add(this.lblVoltar);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(376, 37);
            this.pnlTopo.TabIndex = 0;
            // 
            // lblVoltar
            // 
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVoltar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVoltar.Location = new System.Drawing.Point(0, 0);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(56, 37);
            this.lblVoltar.TabIndex = 0;
            this.lblVoltar.Text = "Voltar";
            this.lblVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVoltar.Click += new System.EventHandler(this.LblVoltar_Click);
            // 
            // checkDescontoGeral
            // 
            this.checkDescontoGeral.AutoSize = true;
            this.checkDescontoGeral.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkDescontoGeral.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkDescontoGeral.Location = new System.Drawing.Point(32, 66);
            this.checkDescontoGeral.Name = "checkDescontoGeral";
            this.checkDescontoGeral.Size = new System.Drawing.Size(147, 25);
            this.checkDescontoGeral.TabIndex = 1;
            this.checkDescontoGeral.Text = "Desconto geral?";
            this.checkDescontoGeral.UseVisualStyleBackColor = true;
            // 
            // txtDesconto
            // 
            this.txtDesconto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtDesconto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDesconto.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtDesconto.BorderSize = 2;
            this.txtDesconto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDesconto.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesconto.Location = new System.Drawing.Point(32, 135);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesconto.MaxLength = 32767;
            this.txtDesconto.Multiline = false;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Padding = new System.Windows.Forms.Padding(7);
            this.txtDesconto.PasswordChar = false;
            this.txtDesconto.SelectionLength = 0;
            this.txtDesconto.SelectionStart = 0;
            this.txtDesconto.Size = new System.Drawing.Size(138, 36);
            this.txtDesconto.TabIndex = 3;
            this.txtDesconto.Texto = "";
            this.txtDesconto.UnderlinedStyle = false;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDesconto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDesconto.Location = new System.Drawing.Point(32, 105);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(107, 21);
            this.lblDesconto.TabIndex = 4;
            this.lblDesconto.Text = "Desconto (%)";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(210, 66);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(144, 39);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(32, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Desabilitar todos os descontos";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(210, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 39);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // UcDescontoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.checkDescontoGeral);
            this.Controls.Add(this.pnlTopo);
            this.Name = "UcDescontoVenda";
            this.Size = new System.Drawing.Size(376, 255);
            this.pnlTopo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.CheckBox checkDescontoGeral;
        private Componentes.TextBoxFlat txtDesconto;
        private System.Windows.Forms.Label lblDesconto;
        public System.Windows.Forms.Button btnConfirm;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnCancel;
    }
}
