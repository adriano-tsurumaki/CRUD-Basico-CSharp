
namespace CRUD___Adriano.Features.Vendas.View
{
    partial class FrmDetalhesVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.gridViewProdutos = new System.Windows.Forms.DataGridView();
            this.gridViewPagamentos = new System.Windows.Forms.DataGridView();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblTituloCliente = new System.Windows.Forms.Label();
            this.lblTituloFormaPagamento = new System.Windows.Forms.Label();
            this.lblTituloProdutos = new System.Windows.Forms.Label();
            this.lblTituloLucroTotal = new System.Windows.Forms.Label();
            this.lblLucroTotal = new System.Windows.Forms.Label();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.lblValorBrutoTotal = new System.Windows.Forms.Label();
            this.lblDescontoTotal = new System.Windows.Forms.Label();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.lblNomeVendedor = new System.Windows.Forms.Label();
            this.lblNumeroVenda = new System.Windows.Forms.Label();
            this.lblTituloValorPago = new System.Windows.Forms.Label();
            this.lblTituloValorBrutoTotal = new System.Windows.Forms.Label();
            this.lblTituloDescontoTotal = new System.Windows.Forms.Label();
            this.lblTituloDataEmissao = new System.Windows.Forms.Label();
            this.lblTituloNomeVendedor = new System.Windows.Forms.Label();
            this.lblTituloNumeroVenda = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnFechar);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(810, 32);
            this.pnlHeader.TabIndex = 3;
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFechar.Location = new System.Drawing.Point(781, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 32);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // pnlCentral
            // 
            this.pnlCentral.AutoScroll = true;
            this.pnlCentral.Controls.Add(this.gridViewProdutos);
            this.pnlCentral.Controls.Add(this.gridViewPagamentos);
            this.pnlCentral.Controls.Add(this.lblNomeCliente);
            this.pnlCentral.Controls.Add(this.lblTituloCliente);
            this.pnlCentral.Controls.Add(this.lblTituloFormaPagamento);
            this.pnlCentral.Controls.Add(this.lblTituloProdutos);
            this.pnlCentral.Controls.Add(this.lblTituloLucroTotal);
            this.pnlCentral.Controls.Add(this.lblLucroTotal);
            this.pnlCentral.Controls.Add(this.lblValorPago);
            this.pnlCentral.Controls.Add(this.lblValorBrutoTotal);
            this.pnlCentral.Controls.Add(this.lblDescontoTotal);
            this.pnlCentral.Controls.Add(this.lblDataEmissao);
            this.pnlCentral.Controls.Add(this.lblNomeVendedor);
            this.pnlCentral.Controls.Add(this.lblNumeroVenda);
            this.pnlCentral.Controls.Add(this.lblTituloValorPago);
            this.pnlCentral.Controls.Add(this.lblTituloValorBrutoTotal);
            this.pnlCentral.Controls.Add(this.lblTituloDescontoTotal);
            this.pnlCentral.Controls.Add(this.lblTituloDataEmissao);
            this.pnlCentral.Controls.Add(this.lblTituloNomeVendedor);
            this.pnlCentral.Controls.Add(this.lblTituloNumeroVenda);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(0, 32);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(810, 549);
            this.pnlCentral.TabIndex = 4;
            // 
            // gridViewProdutos
            // 
            this.gridViewProdutos.AllowUserToAddRows = false;
            this.gridViewProdutos.AllowUserToDeleteRows = false;
            this.gridViewProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewProdutos.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridViewProdutos.EnableHeadersVisualStyles = false;
            this.gridViewProdutos.GridColor = System.Drawing.Color.SteelBlue;
            this.gridViewProdutos.Location = new System.Drawing.Point(15, 233);
            this.gridViewProdutos.Name = "gridViewProdutos";
            this.gridViewProdutos.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.gridViewProdutos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridViewProdutos.RowTemplate.Height = 25;
            this.gridViewProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewProdutos.Size = new System.Drawing.Size(537, 246);
            this.gridViewProdutos.TabIndex = 35;
            // 
            // gridViewPagamentos
            // 
            this.gridViewPagamentos.AllowUserToAddRows = false;
            this.gridViewPagamentos.AllowUserToDeleteRows = false;
            this.gridViewPagamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewPagamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewPagamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridViewPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewPagamentos.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridViewPagamentos.EnableHeadersVisualStyles = false;
            this.gridViewPagamentos.GridColor = System.Drawing.Color.SteelBlue;
            this.gridViewPagamentos.Location = new System.Drawing.Point(15, 543);
            this.gridViewPagamentos.Name = "gridViewPagamentos";
            this.gridViewPagamentos.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.gridViewPagamentos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.gridViewPagamentos.RowTemplate.Height = 25;
            this.gridViewPagamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewPagamentos.Size = new System.Drawing.Size(537, 246);
            this.gridViewPagamentos.TabIndex = 34;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeCliente.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNomeCliente.Location = new System.Drawing.Point(116, 87);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(195, 21);
            this.lblNomeCliente.TabIndex = 33;
            this.lblNomeCliente.Text = "Adriano";
            // 
            // lblTituloCliente
            // 
            this.lblTituloCliente.AutoSize = true;
            this.lblTituloCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloCliente.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTituloCliente.Location = new System.Drawing.Point(12, 87);
            this.lblTituloCliente.Name = "lblTituloCliente";
            this.lblTituloCliente.Size = new System.Drawing.Size(65, 21);
            this.lblTituloCliente.TabIndex = 32;
            this.lblTituloCliente.Text = "Cliente:";
            // 
            // lblTituloFormaPagamento
            // 
            this.lblTituloFormaPagamento.AutoSize = true;
            this.lblTituloFormaPagamento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloFormaPagamento.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTituloFormaPagamento.Location = new System.Drawing.Point(15, 519);
            this.lblTituloFormaPagamento.Name = "lblTituloFormaPagamento";
            this.lblTituloFormaPagamento.Size = new System.Drawing.Size(100, 21);
            this.lblTituloFormaPagamento.TabIndex = 27;
            this.lblTituloFormaPagamento.Text = "Pagamentos";
            // 
            // lblTituloProdutos
            // 
            this.lblTituloProdutos.AutoSize = true;
            this.lblTituloProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloProdutos.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTituloProdutos.Location = new System.Drawing.Point(12, 209);
            this.lblTituloProdutos.Name = "lblTituloProdutos";
            this.lblTituloProdutos.Size = new System.Drawing.Size(148, 21);
            this.lblTituloProdutos.TabIndex = 24;
            this.lblTituloProdutos.Text = "Produtos vendidos";
            // 
            // lblTituloLucroTotal
            // 
            this.lblTituloLucroTotal.AutoSize = true;
            this.lblTituloLucroTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloLucroTotal.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTituloLucroTotal.Location = new System.Drawing.Point(12, 129);
            this.lblTituloLucroTotal.Name = "lblTituloLucroTotal";
            this.lblTituloLucroTotal.Size = new System.Drawing.Size(93, 21);
            this.lblTituloLucroTotal.TabIndex = 22;
            this.lblTituloLucroTotal.Text = "Lucro total:";
            // 
            // lblLucroTotal
            // 
            this.lblLucroTotal.AutoSize = true;
            this.lblLucroTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLucroTotal.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblLucroTotal.Location = new System.Drawing.Point(116, 129);
            this.lblLucroTotal.Name = "lblLucroTotal";
            this.lblLucroTotal.Size = new System.Drawing.Size(70, 21);
            this.lblLucroTotal.TabIndex = 21;
            this.lblLucroTotal.Text = "R$ 10,00";
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorPago.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblValorPago.Location = new System.Drawing.Point(464, 129);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(88, 21);
            this.lblValorPago.TabIndex = 17;
            this.lblValorPago.Text = "R$ 1000,00";
            // 
            // lblValorBrutoTotal
            // 
            this.lblValorBrutoTotal.AutoSize = true;
            this.lblValorBrutoTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorBrutoTotal.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblValorBrutoTotal.Location = new System.Drawing.Point(464, 87);
            this.lblValorBrutoTotal.Name = "lblValorBrutoTotal";
            this.lblValorBrutoTotal.Size = new System.Drawing.Size(88, 21);
            this.lblValorBrutoTotal.TabIndex = 14;
            this.lblValorBrutoTotal.Text = "R$ 1000,00";
            // 
            // lblDescontoTotal
            // 
            this.lblDescontoTotal.AutoSize = true;
            this.lblDescontoTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescontoTotal.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblDescontoTotal.Location = new System.Drawing.Point(464, 45);
            this.lblDescontoTotal.Name = "lblDescontoTotal";
            this.lblDescontoTotal.Size = new System.Drawing.Size(79, 21);
            this.lblDescontoTotal.TabIndex = 13;
            this.lblDescontoTotal.Text = "R$ 100,00";
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataEmissao.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblDataEmissao.Location = new System.Drawing.Point(464, 3);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(87, 21);
            this.lblDataEmissao.TabIndex = 12;
            this.lblDataEmissao.Text = "25/11/2021";
            // 
            // lblNomeVendedor
            // 
            this.lblNomeVendedor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeVendedor.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNomeVendedor.Location = new System.Drawing.Point(116, 45);
            this.lblNomeVendedor.Name = "lblNomeVendedor";
            this.lblNomeVendedor.Size = new System.Drawing.Size(195, 21);
            this.lblNomeVendedor.TabIndex = 11;
            this.lblNomeVendedor.Text = "Augusto";
            // 
            // lblNumeroVenda
            // 
            this.lblNumeroVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroVenda.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNumeroVenda.Location = new System.Drawing.Point(116, 3);
            this.lblNumeroVenda.Name = "lblNumeroVenda";
            this.lblNumeroVenda.Size = new System.Drawing.Size(195, 21);
            this.lblNumeroVenda.TabIndex = 10;
            this.lblNumeroVenda.Text = "1100";
            // 
            // lblTituloValorPago
            // 
            this.lblTituloValorPago.AutoSize = true;
            this.lblTituloValorPago.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloValorPago.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTituloValorPago.Location = new System.Drawing.Point(317, 129);
            this.lblTituloValorPago.Name = "lblTituloValorPago";
            this.lblTituloValorPago.Size = new System.Drawing.Size(93, 21);
            this.lblTituloValorPago.TabIndex = 7;
            this.lblTituloValorPago.Text = "Valor pago:";
            // 
            // lblTituloValorBrutoTotal
            // 
            this.lblTituloValorBrutoTotal.AutoSize = true;
            this.lblTituloValorBrutoTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloValorBrutoTotal.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTituloValorBrutoTotal.Location = new System.Drawing.Point(317, 87);
            this.lblTituloValorBrutoTotal.Name = "lblTituloValorBrutoTotal";
            this.lblTituloValorBrutoTotal.Size = new System.Drawing.Size(134, 21);
            this.lblTituloValorBrutoTotal.TabIndex = 4;
            this.lblTituloValorBrutoTotal.Text = "Valor bruto total:";
            // 
            // lblTituloDescontoTotal
            // 
            this.lblTituloDescontoTotal.AutoSize = true;
            this.lblTituloDescontoTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloDescontoTotal.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTituloDescontoTotal.Location = new System.Drawing.Point(317, 45);
            this.lblTituloDescontoTotal.Name = "lblTituloDescontoTotal";
            this.lblTituloDescontoTotal.Size = new System.Drawing.Size(122, 21);
            this.lblTituloDescontoTotal.TabIndex = 3;
            this.lblTituloDescontoTotal.Text = "Desconto total:";
            // 
            // lblTituloDataEmissao
            // 
            this.lblTituloDataEmissao.AutoSize = true;
            this.lblTituloDataEmissao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloDataEmissao.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTituloDataEmissao.Location = new System.Drawing.Point(317, 3);
            this.lblTituloDataEmissao.Name = "lblTituloDataEmissao";
            this.lblTituloDataEmissao.Size = new System.Drawing.Size(133, 21);
            this.lblTituloDataEmissao.TabIndex = 2;
            this.lblTituloDataEmissao.Text = "Data de emissão:";
            // 
            // lblTituloNomeVendedor
            // 
            this.lblTituloNomeVendedor.AutoSize = true;
            this.lblTituloNomeVendedor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloNomeVendedor.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTituloNomeVendedor.Location = new System.Drawing.Point(12, 45);
            this.lblTituloNomeVendedor.Name = "lblTituloNomeVendedor";
            this.lblTituloNomeVendedor.Size = new System.Drawing.Size(87, 21);
            this.lblTituloNomeVendedor.TabIndex = 1;
            this.lblTituloNomeVendedor.Text = "Vendedor:";
            // 
            // lblTituloNumeroVenda
            // 
            this.lblTituloNumeroVenda.AutoSize = true;
            this.lblTituloNumeroVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloNumeroVenda.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTituloNumeroVenda.Location = new System.Drawing.Point(12, 3);
            this.lblTituloNumeroVenda.Name = "lblTituloNumeroVenda";
            this.lblTituloNumeroVenda.Size = new System.Drawing.Size(82, 21);
            this.lblTituloNumeroVenda.TabIndex = 0;
            this.lblTituloNumeroVenda.Text = "Nº Venda:";
            // 
            // FrmDetalhesVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(810, 581);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlHeader);
            this.KeyPreview = true;
            this.Name = "FrmDetalhesVenda";
            this.Text = "FrmDetalhesVenda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDetalhesVenda_KeyDown);
            this.pnlHeader.ResumeLayout(false);
            this.pnlCentral.ResumeLayout(false);
            this.pnlCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPagamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblTituloCliente;
        private System.Windows.Forms.Label lblTituloFormaPagamento;
        private System.Windows.Forms.Label lblTituloProdutos;
        private System.Windows.Forms.Label lblTituloLucroTotal;
        private System.Windows.Forms.Label lblLucroTotal;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.Label lblValorBrutoTotal;
        private System.Windows.Forms.Label lblDescontoTotal;
        private System.Windows.Forms.Label lblDataEmissao;
        private System.Windows.Forms.Label lblNomeVendedor;
        private System.Windows.Forms.Label lblNumeroVenda;
        private System.Windows.Forms.Label lblTituloValorPago;
        private System.Windows.Forms.Label lblTituloValorBrutoTotal;
        private System.Windows.Forms.Label lblTituloDescontoTotal;
        private System.Windows.Forms.Label lblTituloDataEmissao;
        private System.Windows.Forms.Label lblTituloNomeVendedor;
        private System.Windows.Forms.Label lblTituloNumeroVenda;
        private System.Windows.Forms.DataGridView gridViewProdutos;
        private System.Windows.Forms.DataGridView gridViewPagamentos;
    }
}