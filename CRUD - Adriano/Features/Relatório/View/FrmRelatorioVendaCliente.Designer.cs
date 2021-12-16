
namespace CRUD___Adriano.Features.Relatório.View
{
    partial class FrmRelatorioVendaCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorioVendaCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.pnlOrdernarPor = new System.Windows.Forms.Panel();
            this.checkCrescente = new System.Windows.Forms.CheckBox();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.cbOrdernador = new CRUD___Adriano.Features.Componentes.ComboBoxFlat();
            this.pnlValorSelecionado = new System.Windows.Forms.Panel();
            this.txtValor = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblValor = new System.Windows.Forms.Label();
            this.cbComparador = new CRUD___Adriano.Features.Componentes.ComboBoxFlat();
            this.pnlLimitarCliente = new System.Windows.Forms.Panel();
            this.txtQuantidade = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblLimite = new System.Windows.Forms.Label();
            this.pnlListagemCliente = new System.Windows.Forms.Panel();
            this.gridViewClienteFiltro = new System.Windows.Forms.DataGridView();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.Label();
            this.btnDeselecionarCliente = new System.Windows.Forms.Button();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.pnlFiltroData = new System.Windows.Forms.Panel();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.dtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.pnlFiltroCampos = new System.Windows.Forms.Panel();
            this.checkDataFiltro = new System.Windows.Forms.CheckBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.pnlTotalizadores = new System.Windows.Forms.Panel();
            this.txtTotalLiquido = new System.Windows.Forms.Label();
            this.txtDescontoTotal = new System.Windows.Forms.Label();
            this.txtTotalBruto = new System.Windows.Forms.Label();
            this.txtQuantidadeTotal = new System.Windows.Forms.Label();
            this.lblTotalLiquido = new System.Windows.Forms.Label();
            this.lblDescontoTotal = new System.Windows.Forms.Label();
            this.lblTotalBruto = new System.Windows.Forms.Label();
            this.lblQuantidadeTotal = new System.Windows.Forms.Label();
            this.btnAbrirFiltro = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.pnlRight.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.pnlOrdernarPor.SuspendLayout();
            this.pnlValorSelecionado.SuspendLayout();
            this.pnlLimitarCliente.SuspendLayout();
            this.pnlListagemCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClienteFiltro)).BeginInit();
            this.pnlCliente.SuspendLayout();
            this.pnlFiltroData.SuspendLayout();
            this.pnlFiltroCampos.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlTotalizadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.pnlRight.Controls.Add(this.pnlFiltro);
            this.pnlRight.Controls.Add(this.pnlBotoes);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1020, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(249, 761);
            this.pnlRight.TabIndex = 7;
            this.pnlRight.Visible = false;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.AutoScroll = true;
            this.pnlFiltro.Controls.Add(this.pnlOrdernarPor);
            this.pnlFiltro.Controls.Add(this.pnlValorSelecionado);
            this.pnlFiltro.Controls.Add(this.pnlLimitarCliente);
            this.pnlFiltro.Controls.Add(this.pnlListagemCliente);
            this.pnlFiltro.Controls.Add(this.pnlCliente);
            this.pnlFiltro.Controls.Add(this.pnlFiltroData);
            this.pnlFiltro.Controls.Add(this.pnlFiltroCampos);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(249, 686);
            this.pnlFiltro.TabIndex = 4;
            // 
            // pnlOrdernarPor
            // 
            this.pnlOrdernarPor.Controls.Add(this.checkCrescente);
            this.pnlOrdernarPor.Controls.Add(this.lblOrdenar);
            this.pnlOrdernarPor.Controls.Add(this.cbOrdernador);
            this.pnlOrdernarPor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrdernarPor.Location = new System.Drawing.Point(0, 686);
            this.pnlOrdernarPor.Name = "pnlOrdernarPor";
            this.pnlOrdernarPor.Size = new System.Drawing.Size(232, 120);
            this.pnlOrdernarPor.TabIndex = 21;
            // 
            // checkCrescente
            // 
            this.checkCrescente.AutoSize = true;
            this.checkCrescente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkCrescente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkCrescente.Location = new System.Drawing.Point(18, 87);
            this.checkCrescente.Name = "checkCrescente";
            this.checkCrescente.Size = new System.Drawing.Size(88, 23);
            this.checkCrescente.TabIndex = 19;
            this.checkCrescente.Text = "Crescente";
            this.checkCrescente.UseVisualStyleBackColor = true;
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrdenar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOrdenar.Location = new System.Drawing.Point(18, 14);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(85, 19);
            this.lblOrdenar.TabIndex = 17;
            this.lblOrdenar.Text = "Ordenar por";
            // 
            // cbOrdernador
            // 
            this.cbOrdernador.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbOrdernador.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.cbOrdernador.BorderSize = 1;
            this.cbOrdernador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbOrdernador.ForeColor = System.Drawing.Color.DimGray;
            this.cbOrdernador.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbOrdernador.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbOrdernador.ListTextColor = System.Drawing.Color.DimGray;
            this.cbOrdernador.Location = new System.Drawing.Point(18, 36);
            this.cbOrdernador.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbOrdernador.Name = "cbOrdernador";
            this.cbOrdernador.Padding = new System.Windows.Forms.Padding(1);
            this.cbOrdernador.Size = new System.Drawing.Size(200, 30);
            this.cbOrdernador.TabIndex = 18;
            this.cbOrdernador.Texto = "";
            // 
            // pnlValorSelecionado
            // 
            this.pnlValorSelecionado.Controls.Add(this.txtValor);
            this.pnlValorSelecionado.Controls.Add(this.lblValor);
            this.pnlValorSelecionado.Controls.Add(this.cbComparador);
            this.pnlValorSelecionado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlValorSelecionado.Location = new System.Drawing.Point(0, 533);
            this.pnlValorSelecionado.Name = "pnlValorSelecionado";
            this.pnlValorSelecionado.Size = new System.Drawing.Size(232, 153);
            this.pnlValorSelecionado.TabIndex = 20;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.Window;
            this.txtValor.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtValor.BorderSize = 2;
            this.txtValor.ForeColor = System.Drawing.Color.DimGray;
            this.txtValor.Location = new System.Drawing.Point(18, 95);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Multiline = false;
            this.txtValor.Name = "txtValor";
            this.txtValor.Padding = new System.Windows.Forms.Padding(7);
            this.txtValor.PasswordChar = false;
            this.txtValor.ReadOnly = false;
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.Size = new System.Drawing.Size(200, 30);
            this.txtValor.TabIndex = 14;
            this.txtValor.Texto = "";
            this.txtValor.UnderlinedStyle = false;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblValor.Location = new System.Drawing.Point(18, 16);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(40, 19);
            this.lblValor.TabIndex = 13;
            this.lblValor.Text = "Valor";
            // 
            // cbComparador
            // 
            this.cbComparador.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbComparador.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.cbComparador.BorderSize = 1;
            this.cbComparador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbComparador.ForeColor = System.Drawing.Color.DimGray;
            this.cbComparador.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbComparador.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbComparador.ListTextColor = System.Drawing.Color.DimGray;
            this.cbComparador.Location = new System.Drawing.Point(18, 49);
            this.cbComparador.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbComparador.Name = "cbComparador";
            this.cbComparador.Padding = new System.Windows.Forms.Padding(1);
            this.cbComparador.Size = new System.Drawing.Size(200, 30);
            this.cbComparador.TabIndex = 12;
            this.cbComparador.Texto = "";
            // 
            // pnlLimitarCliente
            // 
            this.pnlLimitarCliente.Controls.Add(this.txtQuantidade);
            this.pnlLimitarCliente.Controls.Add(this.lblLimite);
            this.pnlLimitarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLimitarCliente.Location = new System.Drawing.Point(0, 450);
            this.pnlLimitarCliente.Name = "pnlLimitarCliente";
            this.pnlLimitarCliente.Size = new System.Drawing.Size(232, 83);
            this.pnlLimitarCliente.TabIndex = 19;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantidade.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtQuantidade.BorderSize = 2;
            this.txtQuantidade.ForeColor = System.Drawing.Color.DimGray;
            this.txtQuantidade.Location = new System.Drawing.Point(18, 36);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.Multiline = false;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Padding = new System.Windows.Forms.Padding(7);
            this.txtQuantidade.PasswordChar = false;
            this.txtQuantidade.ReadOnly = false;
            this.txtQuantidade.SelectionLength = 0;
            this.txtQuantidade.SelectionStart = 0;
            this.txtQuantidade.Size = new System.Drawing.Size(200, 30);
            this.txtQuantidade.TabIndex = 15;
            this.txtQuantidade.Texto = "";
            this.txtQuantidade.UnderlinedStyle = false;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLimite.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLimite.Location = new System.Drawing.Point(18, 13);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(76, 19);
            this.lblLimite.TabIndex = 16;
            this.lblLimite.Text = "Limitar por";
            // 
            // pnlListagemCliente
            // 
            this.pnlListagemCliente.Controls.Add(this.gridViewClienteFiltro);
            this.pnlListagemCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListagemCliente.Location = new System.Drawing.Point(0, 352);
            this.pnlListagemCliente.Name = "pnlListagemCliente";
            this.pnlListagemCliente.Size = new System.Drawing.Size(232, 98);
            this.pnlListagemCliente.TabIndex = 19;
            this.pnlListagemCliente.Visible = false;
            // 
            // gridViewClienteFiltro
            // 
            this.gridViewClienteFiltro.AllowUserToAddRows = false;
            this.gridViewClienteFiltro.AllowUserToDeleteRows = false;
            this.gridViewClienteFiltro.AllowUserToResizeRows = false;
            this.gridViewClienteFiltro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewClienteFiltro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewClienteFiltro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewClienteFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewClienteFiltro.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewClienteFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewClienteFiltro.EnableHeadersVisualStyles = false;
            this.gridViewClienteFiltro.GridColor = System.Drawing.Color.SteelBlue;
            this.gridViewClienteFiltro.Location = new System.Drawing.Point(0, 0);
            this.gridViewClienteFiltro.Name = "gridViewClienteFiltro";
            this.gridViewClienteFiltro.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.gridViewClienteFiltro.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewClienteFiltro.RowTemplate.Height = 25;
            this.gridViewClienteFiltro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewClienteFiltro.Size = new System.Drawing.Size(232, 98);
            this.gridViewClienteFiltro.TabIndex = 13;
            this.gridViewClienteFiltro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewClienteFiltro_CellContentClick);
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.lblCliente);
            this.pnlCliente.Controls.Add(this.txtCliente);
            this.pnlCliente.Controls.Add(this.btnDeselecionarCliente);
            this.pnlCliente.Controls.Add(this.btnPesquisarCliente);
            this.pnlCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCliente.Location = new System.Drawing.Point(0, 254);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(232, 98);
            this.pnlCliente.TabIndex = 18;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCliente.Location = new System.Drawing.Point(18, 19);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 19);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCliente.Location = new System.Drawing.Point(18, 50);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(142, 25);
            this.txtCliente.TabIndex = 9;
            this.txtCliente.Text = "Não selecionado";
            this.txtCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeselecionarCliente
            // 
            this.btnDeselecionarCliente.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeselecionarCliente.FlatAppearance.BorderSize = 2;
            this.btnDeselecionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeselecionarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnDeselecionarCliente.Image")));
            this.btnDeselecionarCliente.Location = new System.Drawing.Point(166, 51);
            this.btnDeselecionarCliente.Name = "btnDeselecionarCliente";
            this.btnDeselecionarCliente.Size = new System.Drawing.Size(23, 25);
            this.btnDeselecionarCliente.TabIndex = 10;
            this.btnDeselecionarCliente.UseVisualStyleBackColor = true;
            this.btnDeselecionarCliente.Click += new System.EventHandler(this.BtnDeselecionarCliente_Click);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarCliente.FlatAppearance.BorderSize = 2;
            this.btnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarCliente.Image")));
            this.btnPesquisarCliente.Location = new System.Drawing.Point(195, 51);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(23, 25);
            this.btnPesquisarCliente.TabIndex = 11;
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.BtnPesquisarCliente_Click);
            // 
            // pnlFiltroData
            // 
            this.pnlFiltroData.Controls.Add(this.lblDataInicio);
            this.pnlFiltroData.Controls.Add(this.dtDataFinal);
            this.pnlFiltroData.Controls.Add(this.dtDataInicio);
            this.pnlFiltroData.Controls.Add(this.lblDataFinal);
            this.pnlFiltroData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltroData.Location = new System.Drawing.Point(0, 101);
            this.pnlFiltroData.Name = "pnlFiltroData";
            this.pnlFiltroData.Size = new System.Drawing.Size(232, 153);
            this.pnlFiltroData.TabIndex = 17;
            this.pnlFiltroData.Visible = false;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataInicio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDataInicio.Location = new System.Drawing.Point(18, 16);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(41, 19);
            this.lblDataInicio.TabIndex = 3;
            this.lblDataInicio.Text = "Inicio";
            // 
            // dtDataFinal
            // 
            this.dtDataFinal.CustomFormat = "dd/MM/yyyy";
            this.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataFinal.Location = new System.Drawing.Point(18, 115);
            this.dtDataFinal.Name = "dtDataFinal";
            this.dtDataFinal.Size = new System.Drawing.Size(134, 23);
            this.dtDataFinal.TabIndex = 2;
            // 
            // dtDataInicio
            // 
            this.dtDataInicio.CustomFormat = "dd/MM/yyyy";
            this.dtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataInicio.Location = new System.Drawing.Point(18, 47);
            this.dtDataInicio.Name = "dtDataInicio";
            this.dtDataInicio.Size = new System.Drawing.Size(134, 23);
            this.dtDataInicio.TabIndex = 1;
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataFinal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDataFinal.Location = new System.Drawing.Point(18, 84);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(37, 19);
            this.lblDataFinal.TabIndex = 4;
            this.lblDataFinal.Text = "Final";
            // 
            // pnlFiltroCampos
            // 
            this.pnlFiltroCampos.Controls.Add(this.checkDataFiltro);
            this.pnlFiltroCampos.Controls.Add(this.lblFiltro);
            this.pnlFiltroCampos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltroCampos.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltroCampos.Name = "pnlFiltroCampos";
            this.pnlFiltroCampos.Size = new System.Drawing.Size(232, 101);
            this.pnlFiltroCampos.TabIndex = 16;
            // 
            // checkDataFiltro
            // 
            this.checkDataFiltro.AutoSize = true;
            this.checkDataFiltro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkDataFiltro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkDataFiltro.Location = new System.Drawing.Point(18, 72);
            this.checkDataFiltro.Name = "checkDataFiltro";
            this.checkDataFiltro.Size = new System.Drawing.Size(119, 23);
            this.checkDataFiltro.TabIndex = 1;
            this.checkDataFiltro.Text = "Filtrar por data";
            this.checkDataFiltro.UseVisualStyleBackColor = true;
            this.checkDataFiltro.CheckedChanged += new System.EventHandler(this.CheckDataFiltro_CheckedChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFiltro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltro.Location = new System.Drawing.Point(3, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(57, 25);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "Filtro";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnFiltrar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 686);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(249, 75);
            this.pnlBotoes.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFiltrar.Location = new System.Drawing.Point(73, 19);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(105, 36);
            this.btnFiltrar.TabIndex = 0;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // pnlTotalizadores
            // 
            this.pnlTotalizadores.Controls.Add(this.txtTotalLiquido);
            this.pnlTotalizadores.Controls.Add(this.txtDescontoTotal);
            this.pnlTotalizadores.Controls.Add(this.txtTotalBruto);
            this.pnlTotalizadores.Controls.Add(this.txtQuantidadeTotal);
            this.pnlTotalizadores.Controls.Add(this.lblTotalLiquido);
            this.pnlTotalizadores.Controls.Add(this.lblDescontoTotal);
            this.pnlTotalizadores.Controls.Add(this.lblTotalBruto);
            this.pnlTotalizadores.Controls.Add(this.lblQuantidadeTotal);
            this.pnlTotalizadores.Controls.Add(this.btnAbrirFiltro);
            this.pnlTotalizadores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotalizadores.Location = new System.Drawing.Point(0, 686);
            this.pnlTotalizadores.Name = "pnlTotalizadores";
            this.pnlTotalizadores.Size = new System.Drawing.Size(1020, 75);
            this.pnlTotalizadores.TabIndex = 11;
            // 
            // txtTotalLiquido
            // 
            this.txtTotalLiquido.AutoSize = true;
            this.txtTotalLiquido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalLiquido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalLiquido.Location = new System.Drawing.Point(427, 38);
            this.txtTotalLiquido.Name = "txtTotalLiquido";
            this.txtTotalLiquido.Size = new System.Drawing.Size(72, 19);
            this.txtTotalLiquido.TabIndex = 24;
            this.txtTotalLiquido.Text = "R$ 100,00";
            // 
            // txtDescontoTotal
            // 
            this.txtDescontoTotal.AutoSize = true;
            this.txtDescontoTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescontoTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescontoTotal.Location = new System.Drawing.Point(427, 16);
            this.txtDescontoTotal.Name = "txtDescontoTotal";
            this.txtDescontoTotal.Size = new System.Drawing.Size(72, 19);
            this.txtDescontoTotal.TabIndex = 23;
            this.txtDescontoTotal.Text = "R$ 100,00";
            // 
            // txtTotalBruto
            // 
            this.txtTotalBruto.AutoSize = true;
            this.txtTotalBruto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalBruto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalBruto.Location = new System.Drawing.Point(138, 38);
            this.txtTotalBruto.Name = "txtTotalBruto";
            this.txtTotalBruto.Size = new System.Drawing.Size(72, 19);
            this.txtTotalBruto.TabIndex = 22;
            this.txtTotalBruto.Text = "R$ 100,00";
            // 
            // txtQuantidadeTotal
            // 
            this.txtQuantidadeTotal.AutoSize = true;
            this.txtQuantidadeTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantidadeTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuantidadeTotal.Location = new System.Drawing.Point(138, 16);
            this.txtQuantidadeTotal.Name = "txtQuantidadeTotal";
            this.txtQuantidadeTotal.Size = new System.Drawing.Size(33, 19);
            this.txtQuantidadeTotal.TabIndex = 21;
            this.txtQuantidadeTotal.Text = "100";
            // 
            // lblTotalLiquido
            // 
            this.lblTotalLiquido.AutoSize = true;
            this.lblTotalLiquido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalLiquido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalLiquido.Location = new System.Drawing.Point(319, 38);
            this.lblTotalLiquido.Name = "lblTotalLiquido";
            this.lblTotalLiquido.Size = new System.Drawing.Size(90, 19);
            this.lblTotalLiquido.TabIndex = 20;
            this.lblTotalLiquido.Text = "Total líquido: ";
            // 
            // lblDescontoTotal
            // 
            this.lblDescontoTotal.AutoSize = true;
            this.lblDescontoTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescontoTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDescontoTotal.Location = new System.Drawing.Point(319, 16);
            this.lblDescontoTotal.Name = "lblDescontoTotal";
            this.lblDescontoTotal.Size = new System.Drawing.Size(102, 19);
            this.lblDescontoTotal.TabIndex = 19;
            this.lblDescontoTotal.Text = "Desconto total:";
            // 
            // lblTotalBruto
            // 
            this.lblTotalBruto.AutoSize = true;
            this.lblTotalBruto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalBruto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalBruto.Location = new System.Drawing.Point(12, 38);
            this.lblTotalBruto.Name = "lblTotalBruto";
            this.lblTotalBruto.Size = new System.Drawing.Size(79, 19);
            this.lblTotalBruto.TabIndex = 18;
            this.lblTotalBruto.Text = "Total bruto:";
            // 
            // lblQuantidadeTotal
            // 
            this.lblQuantidadeTotal.AutoSize = true;
            this.lblQuantidadeTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidadeTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblQuantidadeTotal.Location = new System.Drawing.Point(12, 16);
            this.lblQuantidadeTotal.Name = "lblQuantidadeTotal";
            this.lblQuantidadeTotal.Size = new System.Drawing.Size(120, 19);
            this.lblQuantidadeTotal.TabIndex = 17;
            this.lblQuantidadeTotal.Text = "Quantidade total: ";
            // 
            // btnAbrirFiltro
            // 
            this.btnAbrirFiltro.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAbrirFiltro.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAbrirFiltro.FlatAppearance.BorderSize = 0;
            this.btnAbrirFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirFiltro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirFiltro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbrirFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirFiltro.Image")));
            this.btnAbrirFiltro.Location = new System.Drawing.Point(955, 0);
            this.btnAbrirFiltro.Name = "btnAbrirFiltro";
            this.btnAbrirFiltro.Size = new System.Drawing.Size(65, 75);
            this.btnAbrirFiltro.TabIndex = 16;
            this.btnAbrirFiltro.UseVisualStyleBackColor = false;
            this.btnAbrirFiltro.Click += new System.EventHandler(this.BtnAbrirFiltro_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AllowUserToResizeRows = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.EnableHeadersVisualStyles = false;
            this.gridView.GridColor = System.Drawing.Color.SteelBlue;
            this.gridView.Location = new System.Drawing.Point(0, 0);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.gridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridView.RowTemplate.Height = 25;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(1020, 686);
            this.gridView.TabIndex = 12;
            this.gridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridView_CellFormatting);
            // 
            // FrmRelatorioVendaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1269, 761);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.pnlTotalizadores);
            this.Controls.Add(this.pnlRight);
            this.Name = "FrmRelatorioVendaCliente";
            this.Text = "Relatório de cliente na venda";
            this.pnlRight.ResumeLayout(false);
            this.pnlFiltro.ResumeLayout(false);
            this.pnlOrdernarPor.ResumeLayout(false);
            this.pnlOrdernarPor.PerformLayout();
            this.pnlValorSelecionado.ResumeLayout(false);
            this.pnlValorSelecionado.PerformLayout();
            this.pnlLimitarCliente.ResumeLayout(false);
            this.pnlLimitarCliente.PerformLayout();
            this.pnlListagemCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClienteFiltro)).EndInit();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.pnlFiltroData.ResumeLayout(false);
            this.pnlFiltroData.PerformLayout();
            this.pnlFiltroCampos.ResumeLayout(false);
            this.pnlFiltroCampos.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlTotalizadores.ResumeLayout(false);
            this.pnlTotalizadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label txtCliente;
        private System.Windows.Forms.Button btnDeselecionarCliente;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Panel pnlFiltroData;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.DateTimePicker dtDataFinal;
        private System.Windows.Forms.DateTimePicker dtDataInicio;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Panel pnlFiltroCampos;
        private System.Windows.Forms.CheckBox checkDataFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Panel pnlTotalizadores;
        private System.Windows.Forms.Button btnAbrirFiltro;
        private System.Windows.Forms.DataGridView gridView;
        private Componentes.ComboBoxFlat cbOrdernador;
        private System.Windows.Forms.Label lblOrdenar;
        private Componentes.TextBoxFlat txtValor;
        private System.Windows.Forms.Label lblValor;
        private Componentes.ComboBoxFlat cbComparador;
        private System.Windows.Forms.CheckBox checkCrescente;
        private System.Windows.Forms.Panel pnlOrdernarPor;
        private System.Windows.Forms.Panel pnlValorSelecionado;
        private System.Windows.Forms.Panel pnlLimitarCliente;
        private Componentes.TextBoxFlat txtQuantidade;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Panel pnlListagemCliente;
        private System.Windows.Forms.DataGridView gridViewClienteFiltro;
        private System.Windows.Forms.Label lblTotalLiquido;
        private System.Windows.Forms.Label lblDescontoTotal;
        private System.Windows.Forms.Label lblTotalBruto;
        private System.Windows.Forms.Label lblQuantidadeTotal;
        private System.Windows.Forms.Label txtTotalLiquido;
        private System.Windows.Forms.Label txtDescontoTotal;
        private System.Windows.Forms.Label txtTotalBruto;
        private System.Windows.Forms.Label txtQuantidadeTotal;
    }
}