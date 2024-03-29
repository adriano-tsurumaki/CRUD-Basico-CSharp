﻿
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Relatório.View
{
    partial class FrmRelatorioVendaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorioVendaProduto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.Label();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.btnDeselecionarCliente = new System.Windows.Forms.Button();
            this.btnDeselecionarProduto = new System.Windows.Forms.Button();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.Label();
            this.pnlFiltroData = new System.Windows.Forms.Panel();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.dtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkDataFiltro = new System.Windows.Forms.CheckBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.pnlTotalizadores = new System.Windows.Forms.Panel();
            this.txtTotalLucro = new System.Windows.Forms.Label();
            this.lblTotalLucro = new System.Windows.Forms.Label();
            this.txtTotalLiquido = new System.Windows.Forms.Label();
            this.txtDescontoTotal = new System.Windows.Forms.Label();
            this.txtTotalBruto = new System.Windows.Forms.Label();
            this.txtQuantidadeTotal = new System.Windows.Forms.Label();
            this.lblTotalLiquido = new System.Windows.Forms.Label();
            this.lblDescontoTotal = new System.Windows.Forms.Label();
            this.lblTotalBruto = new System.Windows.Forms.Label();
            this.lblQuantidadeTotal = new System.Windows.Forms.Label();
            this.btnAbrirFiltro = new System.Windows.Forms.Button();
            this.pnlRight.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlFiltroData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.pnlTotalizadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.pnlRight.Controls.Add(this.pnlFiltro);
            this.pnlRight.Controls.Add(this.pnlBotoes);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1087, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(234, 701);
            this.pnlRight.TabIndex = 6;
            this.pnlRight.Visible = false;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.panel3);
            this.pnlFiltro.Controls.Add(this.pnlFiltroData);
            this.pnlFiltro.Controls.Add(this.panel1);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(234, 626);
            this.pnlFiltro.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblProduto);
            this.panel3.Controls.Add(this.lblCliente);
            this.panel3.Controls.Add(this.txtCliente);
            this.panel3.Controls.Add(this.btnPesquisarProduto);
            this.panel3.Controls.Add(this.btnDeselecionarCliente);
            this.panel3.Controls.Add(this.btnDeselecionarProduto);
            this.panel3.Controls.Add(this.btnPesquisarCliente);
            this.panel3.Controls.Add(this.txtProduto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 168);
            this.panel3.TabIndex = 18;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProduto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProduto.Location = new System.Drawing.Point(18, 23);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(59, 19);
            this.lblProduto.TabIndex = 12;
            this.lblProduto.Text = "Produto";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCliente.Location = new System.Drawing.Point(18, 91);
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
            this.txtCliente.Location = new System.Drawing.Point(18, 122);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(134, 25);
            this.txtCliente.TabIndex = 9;
            this.txtCliente.Text = "Não selecionado";
            this.txtCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarProduto.FlatAppearance.BorderSize = 2;
            this.btnPesquisarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarProduto.Image")));
            this.btnPesquisarProduto.Location = new System.Drawing.Point(187, 54);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(23, 25);
            this.btnPesquisarProduto.TabIndex = 15;
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.BtnPesquisarProduto_Click);
            // 
            // btnDeselecionarCliente
            // 
            this.btnDeselecionarCliente.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeselecionarCliente.FlatAppearance.BorderSize = 2;
            this.btnDeselecionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeselecionarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnDeselecionarCliente.Image")));
            this.btnDeselecionarCliente.Location = new System.Drawing.Point(158, 122);
            this.btnDeselecionarCliente.Name = "btnDeselecionarCliente";
            this.btnDeselecionarCliente.Size = new System.Drawing.Size(23, 25);
            this.btnDeselecionarCliente.TabIndex = 10;
            this.btnDeselecionarCliente.UseVisualStyleBackColor = true;
            this.btnDeselecionarCliente.Click += new System.EventHandler(this.BtnDeselecionarCliente_Click);
            // 
            // btnDeselecionarProduto
            // 
            this.btnDeselecionarProduto.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeselecionarProduto.FlatAppearance.BorderSize = 2;
            this.btnDeselecionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeselecionarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnDeselecionarProduto.Image")));
            this.btnDeselecionarProduto.Location = new System.Drawing.Point(158, 54);
            this.btnDeselecionarProduto.Name = "btnDeselecionarProduto";
            this.btnDeselecionarProduto.Size = new System.Drawing.Size(23, 25);
            this.btnDeselecionarProduto.TabIndex = 14;
            this.btnDeselecionarProduto.UseVisualStyleBackColor = true;
            this.btnDeselecionarProduto.Click += new System.EventHandler(this.BtnDeselecionarProduto_Click);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarCliente.FlatAppearance.BorderSize = 2;
            this.btnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarCliente.Image")));
            this.btnPesquisarCliente.Location = new System.Drawing.Point(187, 122);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(23, 25);
            this.btnPesquisarCliente.TabIndex = 11;
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.BtnPesquisarCliente_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtProduto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProduto.ForeColor = System.Drawing.Color.Black;
            this.txtProduto.Location = new System.Drawing.Point(18, 54);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(134, 25);
            this.txtProduto.TabIndex = 13;
            this.txtProduto.Text = "Não selecionado";
            this.txtProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pnlFiltroData.Size = new System.Drawing.Size(234, 153);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.checkDataFiltro);
            this.panel1.Controls.Add(this.lblFiltro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 101);
            this.panel1.TabIndex = 16;
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
            this.pnlBotoes.Location = new System.Drawing.Point(0, 626);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(234, 75);
            this.pnlBotoes.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFiltrar.Location = new System.Drawing.Point(58, 16);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(105, 36);
            this.btnFiltrar.TabIndex = 0;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.gridView.GridColor = System.Drawing.Color.SteelBlue;
            this.gridView.Location = new System.Drawing.Point(0, 0);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.gridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridView.RowTemplate.Height = 25;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(1087, 626);
            this.gridView.TabIndex = 8;
            this.gridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridView_CellFormatting);
            // 
            // pnlTotalizadores
            // 
            this.pnlTotalizadores.Controls.Add(this.btnAbrirFiltro);
            this.pnlTotalizadores.Controls.Add(this.txtTotalLucro);
            this.pnlTotalizadores.Controls.Add(this.lblTotalLucro);
            this.pnlTotalizadores.Controls.Add(this.txtTotalLiquido);
            this.pnlTotalizadores.Controls.Add(this.txtDescontoTotal);
            this.pnlTotalizadores.Controls.Add(this.txtTotalBruto);
            this.pnlTotalizadores.Controls.Add(this.txtQuantidadeTotal);
            this.pnlTotalizadores.Controls.Add(this.lblTotalLiquido);
            this.pnlTotalizadores.Controls.Add(this.lblDescontoTotal);
            this.pnlTotalizadores.Controls.Add(this.lblTotalBruto);
            this.pnlTotalizadores.Controls.Add(this.lblQuantidadeTotal);
            this.pnlTotalizadores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotalizadores.Location = new System.Drawing.Point(0, 626);
            this.pnlTotalizadores.Name = "pnlTotalizadores";
            this.pnlTotalizadores.Size = new System.Drawing.Size(1087, 75);
            this.pnlTotalizadores.TabIndex = 10;
            // 
            // txtTotalLucro
            // 
            this.txtTotalLucro.AutoSize = true;
            this.txtTotalLucro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalLucro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalLucro.Location = new System.Drawing.Point(612, 16);
            this.txtTotalLucro.Name = "txtTotalLucro";
            this.txtTotalLucro.Size = new System.Drawing.Size(72, 19);
            this.txtTotalLucro.TabIndex = 34;
            this.txtTotalLucro.Text = "R$ 100,00";
            // 
            // lblTotalLucro
            // 
            this.lblTotalLucro.AutoSize = true;
            this.lblTotalLucro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalLucro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalLucro.Location = new System.Drawing.Point(516, 16);
            this.lblTotalLucro.Name = "lblTotalLucro";
            this.lblTotalLucro.Size = new System.Drawing.Size(79, 19);
            this.lblTotalLucro.TabIndex = 33;
            this.lblTotalLucro.Text = "Total lucro: ";
            // 
            // txtTotalLiquido
            // 
            this.txtTotalLiquido.AutoSize = true;
            this.txtTotalLiquido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalLiquido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalLiquido.Location = new System.Drawing.Point(372, 38);
            this.txtTotalLiquido.Name = "txtTotalLiquido";
            this.txtTotalLiquido.Size = new System.Drawing.Size(72, 19);
            this.txtTotalLiquido.TabIndex = 32;
            this.txtTotalLiquido.Text = "R$ 100,00";
            // 
            // txtDescontoTotal
            // 
            this.txtDescontoTotal.AutoSize = true;
            this.txtDescontoTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescontoTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescontoTotal.Location = new System.Drawing.Point(372, 16);
            this.txtDescontoTotal.Name = "txtDescontoTotal";
            this.txtDescontoTotal.Size = new System.Drawing.Size(72, 19);
            this.txtDescontoTotal.TabIndex = 31;
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
            this.txtTotalBruto.TabIndex = 30;
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
            this.txtQuantidadeTotal.TabIndex = 29;
            this.txtQuantidadeTotal.Text = "100";
            // 
            // lblTotalLiquido
            // 
            this.lblTotalLiquido.AutoSize = true;
            this.lblTotalLiquido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalLiquido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalLiquido.Location = new System.Drawing.Point(264, 38);
            this.lblTotalLiquido.Name = "lblTotalLiquido";
            this.lblTotalLiquido.Size = new System.Drawing.Size(90, 19);
            this.lblTotalLiquido.TabIndex = 28;
            this.lblTotalLiquido.Text = "Total líquido: ";
            // 
            // lblDescontoTotal
            // 
            this.lblDescontoTotal.AutoSize = true;
            this.lblDescontoTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescontoTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDescontoTotal.Location = new System.Drawing.Point(264, 16);
            this.lblDescontoTotal.Name = "lblDescontoTotal";
            this.lblDescontoTotal.Size = new System.Drawing.Size(102, 19);
            this.lblDescontoTotal.TabIndex = 27;
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
            this.lblTotalBruto.TabIndex = 26;
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
            this.lblQuantidadeTotal.TabIndex = 25;
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
            this.btnAbrirFiltro.Location = new System.Drawing.Point(1022, 0);
            this.btnAbrirFiltro.Name = "btnAbrirFiltro";
            this.btnAbrirFiltro.Size = new System.Drawing.Size(65, 75);
            this.btnAbrirFiltro.TabIndex = 16;
            this.btnAbrirFiltro.UseVisualStyleBackColor = false;
            this.btnAbrirFiltro.Click += new System.EventHandler(this.BtnAbrirFiltro_Click);
            // 
            // FrmRelatorioVendaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1321, 701);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.pnlTotalizadores);
            this.Controls.Add(this.pnlRight);
            this.Name = "FrmRelatorioVendaProduto";
            this.Text = "Relatório de produto na venda";
            this.pnlRight.ResumeLayout(false);
            this.pnlFiltro.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlFiltroData.ResumeLayout(false);
            this.pnlFiltroData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.pnlTotalizadores.ResumeLayout(false);
            this.pnlTotalizadores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.DateTimePicker dtDataInicio;
        private System.Windows.Forms.DateTimePicker dtDataFinal;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Panel pnlTotalizadores;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.Button btnDeselecionarProduto;
        private System.Windows.Forms.Label txtProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Button btnDeselecionarCliente;
        private System.Windows.Forms.Label txtCliente;
        private System.Windows.Forms.Button btnAbrirFiltro;
        private Panel panel3;
        private Panel pnlFiltroData;
        private Panel panel1;
        private CheckBox checkDataFiltro;
        private Label txtTotalLiquido;
        private Label txtDescontoTotal;
        private Label txtTotalBruto;
        private Label txtQuantidadeTotal;
        private Label lblTotalLiquido;
        private Label lblDescontoTotal;
        private Label lblTotalBruto;
        private Label lblQuantidadeTotal;
        private Label txtTotalLucro;
        private Label lblTotalLucro;
    }
}