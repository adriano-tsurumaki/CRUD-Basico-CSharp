﻿
namespace CRUD___Adriano
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAtalho = new System.Windows.Forms.Button();
            this.pnlListagemSubmenu = new System.Windows.Forms.Panel();
            this.btnListagemFuncionario = new System.Windows.Forms.Button();
            this.btnListagemCliente = new System.Windows.Forms.Button();
            this.btnListagem = new System.Windows.Forms.Button();
            this.pnlCadastroSubmenu = new System.Windows.Forms.Panel();
            this.btnCadastroFornecedor = new System.Windows.Forms.Button();
            this.btnCadastroFuncionario = new System.Windows.Forms.Button();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.pnlUsuarioLogado = new System.Windows.Forms.Panel();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.pnlTitlebar = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlChild = new System.Windows.Forms.Panel();
            this.btnCadastroProduto = new System.Windows.Forms.Button();
            this.pnlSideMenu.SuspendLayout();
            this.pnlListagemSubmenu.SuspendLayout();
            this.pnlCadastroSubmenu.SuspendLayout();
            this.pnlUsuarioLogado.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.pnlTitlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlSideMenu.Controls.Add(this.btnLogout);
            this.pnlSideMenu.Controls.Add(this.btnAtalho);
            this.pnlSideMenu.Controls.Add(this.pnlListagemSubmenu);
            this.pnlSideMenu.Controls.Add(this.btnListagem);
            this.pnlSideMenu.Controls.Add(this.pnlCadastroSubmenu);
            this.pnlSideMenu.Controls.Add(this.btnCadastro);
            this.pnlSideMenu.Controls.Add(this.pnlUsuarioLogado);
            this.pnlSideMenu.Controls.Add(this.panelLogo);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(220, 561);
            this.pnlSideMenu.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 654);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(203, 46);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Sair";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnAtalho
            // 
            this.btnAtalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAtalho.FlatAppearance.BorderSize = 0;
            this.btnAtalho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtalho.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtalho.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAtalho.Image = ((System.Drawing.Image)(resources.GetObject("btnAtalho.Image")));
            this.btnAtalho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtalho.Location = new System.Drawing.Point(0, 594);
            this.btnAtalho.Name = "btnAtalho";
            this.btnAtalho.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnAtalho.Size = new System.Drawing.Size(203, 60);
            this.btnAtalho.TabIndex = 7;
            this.btnAtalho.Text = "Atalhos";
            this.btnAtalho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtalho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtalho.UseVisualStyleBackColor = true;
            this.btnAtalho.Click += new System.EventHandler(this.BtnAtalho_Click);
            // 
            // pnlListagemSubmenu
            // 
            this.pnlListagemSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlListagemSubmenu.Controls.Add(this.btnListagemFuncionario);
            this.pnlListagemSubmenu.Controls.Add(this.btnListagemCliente);
            this.pnlListagemSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListagemSubmenu.Location = new System.Drawing.Point(0, 470);
            this.pnlListagemSubmenu.Name = "pnlListagemSubmenu";
            this.pnlListagemSubmenu.Size = new System.Drawing.Size(203, 124);
            this.pnlListagemSubmenu.TabIndex = 6;
            // 
            // btnListagemFuncionario
            // 
            this.btnListagemFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListagemFuncionario.FlatAppearance.BorderSize = 0;
            this.btnListagemFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListagemFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListagemFuncionario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListagemFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnListagemFuncionario.Image")));
            this.btnListagemFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListagemFuncionario.Location = new System.Drawing.Point(0, 60);
            this.btnListagemFuncionario.Name = "btnListagemFuncionario";
            this.btnListagemFuncionario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnListagemFuncionario.Size = new System.Drawing.Size(203, 60);
            this.btnListagemFuncionario.TabIndex = 1;
            this.btnListagemFuncionario.Text = "Funcionário";
            this.btnListagemFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListagemFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListagemFuncionario.UseVisualStyleBackColor = true;
            this.btnListagemFuncionario.Click += new System.EventHandler(this.BtnListagemFuncionario_Click);
            // 
            // btnListagemCliente
            // 
            this.btnListagemCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListagemCliente.FlatAppearance.BorderSize = 0;
            this.btnListagemCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListagemCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListagemCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListagemCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnListagemCliente.Image")));
            this.btnListagemCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListagemCliente.Location = new System.Drawing.Point(0, 0);
            this.btnListagemCliente.Name = "btnListagemCliente";
            this.btnListagemCliente.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnListagemCliente.Size = new System.Drawing.Size(203, 60);
            this.btnListagemCliente.TabIndex = 0;
            this.btnListagemCliente.Text = "Cliente";
            this.btnListagemCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListagemCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListagemCliente.UseVisualStyleBackColor = true;
            this.btnListagemCliente.Click += new System.EventHandler(this.BtnClientesListagem_Click);
            // 
            // btnListagem
            // 
            this.btnListagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListagem.FlatAppearance.BorderSize = 0;
            this.btnListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListagem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListagem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListagem.Image = ((System.Drawing.Image)(resources.GetObject("btnListagem.Image")));
            this.btnListagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListagem.Location = new System.Drawing.Point(0, 410);
            this.btnListagem.Name = "btnListagem";
            this.btnListagem.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnListagem.Size = new System.Drawing.Size(203, 60);
            this.btnListagem.TabIndex = 5;
            this.btnListagem.Text = "Listagem";
            this.btnListagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListagem.UseVisualStyleBackColor = true;
            this.btnListagem.Click += new System.EventHandler(this.BtnMenuListagem_Click);
            // 
            // pnlCadastroSubmenu
            // 
            this.pnlCadastroSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlCadastroSubmenu.Controls.Add(this.btnCadastroProduto);
            this.pnlCadastroSubmenu.Controls.Add(this.btnCadastroFornecedor);
            this.pnlCadastroSubmenu.Controls.Add(this.btnCadastroFuncionario);
            this.pnlCadastroSubmenu.Controls.Add(this.btnCadastroCliente);
            this.pnlCadastroSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCadastroSubmenu.Location = new System.Drawing.Point(0, 172);
            this.pnlCadastroSubmenu.Name = "pnlCadastroSubmenu";
            this.pnlCadastroSubmenu.Size = new System.Drawing.Size(203, 238);
            this.pnlCadastroSubmenu.TabIndex = 4;
            // 
            // btnCadastroFornecedor
            // 
            this.btnCadastroFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroFornecedor.FlatAppearance.BorderSize = 0;
            this.btnCadastroFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroFornecedor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroFornecedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCadastroFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroFornecedor.Image")));
            this.btnCadastroFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroFornecedor.Location = new System.Drawing.Point(0, 120);
            this.btnCadastroFornecedor.Name = "btnCadastroFornecedor";
            this.btnCadastroFornecedor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastroFornecedor.Size = new System.Drawing.Size(203, 60);
            this.btnCadastroFornecedor.TabIndex = 2;
            this.btnCadastroFornecedor.Text = "Fornecedor";
            this.btnCadastroFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastroFornecedor.UseVisualStyleBackColor = true;
            this.btnCadastroFornecedor.Click += new System.EventHandler(this.BtnCadastroFornecedor_Click);
            // 
            // btnCadastroFuncionario
            // 
            this.btnCadastroFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadastroFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroFuncionario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCadastroFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroFuncionario.Image")));
            this.btnCadastroFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroFuncionario.Location = new System.Drawing.Point(0, 60);
            this.btnCadastroFuncionario.Name = "btnCadastroFuncionario";
            this.btnCadastroFuncionario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastroFuncionario.Size = new System.Drawing.Size(203, 60);
            this.btnCadastroFuncionario.TabIndex = 1;
            this.btnCadastroFuncionario.Text = "Funcionário";
            this.btnCadastroFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastroFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastroFuncionario.Click += new System.EventHandler(this.BtnCadastroFuncionario_Click);
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroCliente.FlatAppearance.BorderSize = 0;
            this.btnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCadastroCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroCliente.Image")));
            this.btnCadastroCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroCliente.Location = new System.Drawing.Point(0, 0);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCadastroCliente.Size = new System.Drawing.Size(203, 60);
            this.btnCadastroCliente.TabIndex = 0;
            this.btnCadastroCliente.Text = "Cliente";
            this.btnCadastroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastroCliente.UseVisualStyleBackColor = true;
            this.btnCadastroCliente.Click += new System.EventHandler(this.BtnClienteCadastro_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastro.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastro.Image")));
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(0, 112);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnCadastro.Size = new System.Drawing.Size(203, 60);
            this.btnCadastro.TabIndex = 3;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.BtnMenuCadastro_Click);
            // 
            // pnlUsuarioLogado
            // 
            this.pnlUsuarioLogado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlUsuarioLogado.Controls.Add(this.lblUsuarioLogado);
            this.pnlUsuarioLogado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuarioLogado.Location = new System.Drawing.Point(0, 75);
            this.pnlUsuarioLogado.Name = "pnlUsuarioLogado";
            this.pnlUsuarioLogado.Size = new System.Drawing.Size(203, 37);
            this.pnlUsuarioLogado.TabIndex = 4;
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblUsuarioLogado.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUsuarioLogado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuarioLogado.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(0, 0);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(203, 37);
            this.lblUsuarioLogado.TabIndex = 1;
            this.lblUsuarioLogado.Text = "Admin";
            this.lblUsuarioLogado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lblNomeEmpresa);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(203, 75);
            this.panelLogo.TabIndex = 3;
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNomeEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblNomeEmpresa.Location = new System.Drawing.Point(0, 0);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(203, 75);
            this.lblNomeEmpresa.TabIndex = 1;
            this.lblNomeEmpresa.Text = "Augusto\'s Fashion";
            this.lblNomeEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNomeEmpresa.Click += new System.EventHandler(this.LblNomeEmpresa_Click);
            // 
            // pnlTitlebar
            // 
            this.pnlTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlTitlebar.Controls.Add(this.lblTitulo);
            this.pnlTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitlebar.Location = new System.Drawing.Point(220, 0);
            this.pnlTitlebar.Name = "pnlTitlebar";
            this.pnlTitlebar.Size = new System.Drawing.Size(714, 75);
            this.pnlTitlebar.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(714, 75);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Dashboard";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlChild
            // 
            this.pnlChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.pnlChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChild.Location = new System.Drawing.Point(220, 75);
            this.pnlChild.Name = "pnlChild";
            this.pnlChild.Size = new System.Drawing.Size(714, 486);
            this.pnlChild.TabIndex = 4;
            this.pnlChild.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.PnlChild_ControlRemoved);
            // 
            // btnCadastroProduto
            // 
            this.btnCadastroProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroProduto.FlatAppearance.BorderSize = 0;
            this.btnCadastroProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroProduto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCadastroProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroProduto.Image")));
            this.btnCadastroProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroProduto.Location = new System.Drawing.Point(0, 180);
            this.btnCadastroProduto.Name = "btnCadastroProduto";
            this.btnCadastroProduto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastroProduto.Size = new System.Drawing.Size(203, 60);
            this.btnCadastroProduto.TabIndex = 3;
            this.btnCadastroProduto.Text = "Produto";
            this.btnCadastroProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastroProduto.UseVisualStyleBackColor = true;
            this.btnCadastroProduto.Click += new System.EventHandler(this.BtnCadastroProduto_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.pnlChild);
            this.Controls.Add(this.pnlTitlebar);
            this.Controls.Add(this.pnlSideMenu);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(950, 600);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlListagemSubmenu.ResumeLayout(false);
            this.pnlCadastroSubmenu.ResumeLayout(false);
            this.pnlUsuarioLogado.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.pnlTitlebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel pnlCadastroSubmenu;
        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Button btnCadastroFuncionario;
        private System.Windows.Forms.Panel pnlListagemSubmenu;
        private System.Windows.Forms.Button btnListagemFuncionario;
        private System.Windows.Forms.Button btnListagemCliente;
        private System.Windows.Forms.Button btnListagem;
        private System.Windows.Forms.Panel pnlTitlebar;
        private System.Windows.Forms.Panel pnlChild;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.Button btnAtalho;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlUsuarioLogado;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Button btnCadastroFornecedor;
        private System.Windows.Forms.Button btnCadastroProduto;
    }
}

