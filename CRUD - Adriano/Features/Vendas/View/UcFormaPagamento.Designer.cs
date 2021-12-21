
namespace CRUD___Adriano.Features.Vendas.View
{
    partial class UcFormaPagamento
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbFormaPagamento = new CRUD___Adriano.Features.Componentes.ComboBoxFlat();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorASerPago = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblValorASerPago = new System.Windows.Forms.Label();
            this.txtQuantidadeParcelas = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblQuantidadeParcelas = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblValorRestante = new System.Windows.Forms.Label();
            this.pnlTituloFormaPagamento = new System.Windows.Forms.Panel();
            this.lblTituloFormaPagamento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTituloFormaPagamento.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(21, 98);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(235, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Escolha a forma de pagamento";
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.cbFormaPagamento.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.cbFormaPagamento.BorderSize = 2;
            this.cbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbFormaPagamento.ForeColor = System.Drawing.Color.DimGray;
            this.cbFormaPagamento.IconColor = System.Drawing.Color.LightSkyBlue;
            this.cbFormaPagamento.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbFormaPagamento.ListTextColor = System.Drawing.Color.DimGray;
            this.cbFormaPagamento.Location = new System.Drawing.Point(21, 136);
            this.cbFormaPagamento.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Padding = new System.Windows.Forms.Padding(2);
            this.cbFormaPagamento.Size = new System.Drawing.Size(243, 30);
            this.cbFormaPagamento.TabIndex = 1;
            this.cbFormaPagamento.Texto = "";
            this.cbFormaPagamento.OnSelectedIndexChanged += new System.EventHandler(this.CbFormaPagamento_OnSelectedIndexChanged);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblValorTotal.Location = new System.Drawing.Point(21, 22);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(161, 21);
            this.lblValorTotal.TabIndex = 2;
            this.lblValorTotal.Text = "Valor total: R$999.00";
            // 
            // txtValorASerPago
            // 
            this.txtValorASerPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtValorASerPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtValorASerPago.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtValorASerPago.BorderSize = 2;
            this.txtValorASerPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorASerPago.ForeColor = System.Drawing.Color.DimGray;
            this.txtValorASerPago.Location = new System.Drawing.Point(21, 221);
            this.txtValorASerPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorASerPago.MaxLength = 32767;
            this.txtValorASerPago.Multiline = false;
            this.txtValorASerPago.Name = "txtValorASerPago";
            this.txtValorASerPago.Padding = new System.Windows.Forms.Padding(7);
            this.txtValorASerPago.PasswordChar = false;
            this.txtValorASerPago.ReadOnly = false;
            this.txtValorASerPago.SelectionLength = 0;
            this.txtValorASerPago.SelectionStart = 0;
            this.txtValorASerPago.Size = new System.Drawing.Size(243, 36);
            this.txtValorASerPago.TabIndex = 4;
            this.txtValorASerPago.Texto = "";
            this.txtValorASerPago.UnderlinedStyle = false;
            // 
            // lblValorASerPago
            // 
            this.lblValorASerPago.AutoSize = true;
            this.lblValorASerPago.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorASerPago.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblValorASerPago.Location = new System.Drawing.Point(21, 183);
            this.lblValorASerPago.Name = "lblValorASerPago";
            this.lblValorASerPago.Size = new System.Drawing.Size(105, 21);
            this.lblValorASerPago.TabIndex = 5;
            this.lblValorASerPago.Text = "Valor a pagar";
            // 
            // txtQuantidadeParcelas
            // 
            this.txtQuantidadeParcelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtQuantidadeParcelas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtQuantidadeParcelas.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtQuantidadeParcelas.BorderSize = 2;
            this.txtQuantidadeParcelas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantidadeParcelas.ForeColor = System.Drawing.Color.DimGray;
            this.txtQuantidadeParcelas.Location = new System.Drawing.Point(22, 312);
            this.txtQuantidadeParcelas.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidadeParcelas.MaxLength = 32767;
            this.txtQuantidadeParcelas.Multiline = false;
            this.txtQuantidadeParcelas.Name = "txtQuantidadeParcelas";
            this.txtQuantidadeParcelas.Padding = new System.Windows.Forms.Padding(7);
            this.txtQuantidadeParcelas.PasswordChar = false;
            this.txtQuantidadeParcelas.ReadOnly = false;
            this.txtQuantidadeParcelas.SelectionLength = 0;
            this.txtQuantidadeParcelas.SelectionStart = 0;
            this.txtQuantidadeParcelas.Size = new System.Drawing.Size(243, 36);
            this.txtQuantidadeParcelas.TabIndex = 6;
            this.txtQuantidadeParcelas.Texto = "";
            this.txtQuantidadeParcelas.UnderlinedStyle = false;
            // 
            // lblQuantidadeParcelas
            // 
            this.lblQuantidadeParcelas.AutoSize = true;
            this.lblQuantidadeParcelas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidadeParcelas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblQuantidadeParcelas.Location = new System.Drawing.Point(22, 274);
            this.lblQuantidadeParcelas.Name = "lblQuantidadeParcelas";
            this.lblQuantidadeParcelas.Size = new System.Drawing.Size(182, 21);
            this.lblQuantidadeParcelas.TabIndex = 7;
            this.lblQuantidadeParcelas.Text = "Quantidade de parcelas";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(21, 365);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(144, 39);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // lblValorRestante
            // 
            this.lblValorRestante.AutoSize = true;
            this.lblValorRestante.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorRestante.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblValorRestante.Location = new System.Drawing.Point(22, 60);
            this.lblValorRestante.Name = "lblValorRestante";
            this.lblValorRestante.Size = new System.Drawing.Size(187, 21);
            this.lblValorRestante.TabIndex = 17;
            this.lblValorRestante.Text = "Valor restante: R$999.00";
            // 
            // pnlTituloFormaPagamento
            // 
            this.pnlTituloFormaPagamento.Controls.Add(this.lblTituloFormaPagamento);
            this.pnlTituloFormaPagamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloFormaPagamento.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloFormaPagamento.Name = "pnlTituloFormaPagamento";
            this.pnlTituloFormaPagamento.Size = new System.Drawing.Size(373, 43);
            this.pnlTituloFormaPagamento.TabIndex = 19;
            // 
            // lblTituloFormaPagamento
            // 
            this.lblTituloFormaPagamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTituloFormaPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloFormaPagamento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloFormaPagamento.ForeColor = System.Drawing.Color.White;
            this.lblTituloFormaPagamento.Location = new System.Drawing.Point(0, 0);
            this.lblTituloFormaPagamento.Name = "lblTituloFormaPagamento";
            this.lblTituloFormaPagamento.Size = new System.Drawing.Size(373, 43);
            this.lblTituloFormaPagamento.TabIndex = 1;
            this.lblTituloFormaPagamento.Text = "Forma de pagamento";
            this.lblTituloFormaPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblValorTotal);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.lblValorRestante);
            this.panel1.Controls.Add(this.cbFormaPagamento);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.txtValorASerPago);
            this.panel1.Controls.Add(this.lblQuantidadeParcelas);
            this.panel1.Controls.Add(this.lblValorASerPago);
            this.panel1.Controls.Add(this.txtQuantidadeParcelas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 443);
            this.panel1.TabIndex = 20;
            // 
            // UcFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTituloFormaPagamento);
            this.Name = "UcFormaPagamento";
            this.Size = new System.Drawing.Size(373, 486);
            this.pnlTituloFormaPagamento.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private Componentes.ComboBoxFlat cbFormaPagamento;
        private System.Windows.Forms.Label lblValorTotal;
        private Componentes.TextBoxFlat txtValorASerPago;
        private System.Windows.Forms.Label lblValorASerPago;
        private Componentes.TextBoxFlat txtQuantidadeParcelas;
        private System.Windows.Forms.Label lblQuantidadeParcelas;
        public System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblValorRestante;
        private System.Windows.Forms.Panel pnlTituloFormaPagamento;
        internal System.Windows.Forms.Label lblTituloFormaPagamento;
        private System.Windows.Forms.Panel panel1;
    }
}
