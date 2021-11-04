﻿
namespace CRUD___Adriano.Features.Cliente.View
{
    partial class FrmAtalhos
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
            this.txtQuantidadeClientes = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblQuantidadeClientes = new System.Windows.Forms.Label();
            this.btnCadastrarClientes = new System.Windows.Forms.Button();
            this.btnCadastrarColaboradores = new System.Windows.Forms.Button();
            this.lblQuantidadeColaboradores = new System.Windows.Forms.Label();
            this.txtQuantidadeColaboradores = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.SuspendLayout();
            // 
            // txtQuantidadeClientes
            // 
            this.txtQuantidadeClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtQuantidadeClientes.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtQuantidadeClientes.BorderSize = 2;
            this.txtQuantidadeClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantidadeClientes.ForeColor = System.Drawing.Color.DimGray;
            this.txtQuantidadeClientes.Location = new System.Drawing.Point(13, 43);
            this.txtQuantidadeClientes.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidadeClientes.MaxLength = 10;
            this.txtQuantidadeClientes.Multiline = false;
            this.txtQuantidadeClientes.Name = "txtQuantidadeClientes";
            this.txtQuantidadeClientes.Padding = new System.Windows.Forms.Padding(7);
            this.txtQuantidadeClientes.PasswordChar = false;
            this.txtQuantidadeClientes.SelectionLength = 0;
            this.txtQuantidadeClientes.SelectionStart = 0;
            this.txtQuantidadeClientes.Size = new System.Drawing.Size(250, 36);
            this.txtQuantidadeClientes.TabIndex = 0;
            this.txtQuantidadeClientes.Texto = "";
            this.txtQuantidadeClientes.UnderlinedStyle = true;
            this.txtQuantidadeClientes._TextChanged += new System.EventHandler(this.TxtQuantidade__TextChanged);
            this.txtQuantidadeClientes._KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQuantidadeClientes__KeyDown);
            // 
            // lblQuantidadeClientes
            // 
            this.lblQuantidadeClientes.AutoSize = true;
            this.lblQuantidadeClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidadeClientes.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblQuantidadeClientes.Location = new System.Drawing.Point(12, 9);
            this.lblQuantidadeClientes.Name = "lblQuantidadeClientes";
            this.lblQuantidadeClientes.Size = new System.Drawing.Size(480, 21);
            this.lblQuantidadeClientes.TabIndex = 1;
            this.lblQuantidadeClientes.Text = "Digite a quantidade de clientes que deseja gerar aleatoriamente.";
            // 
            // btnCadastrarClientes
            // 
            this.btnCadastrarClientes.FlatAppearance.BorderSize = 2;
            this.btnCadastrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarClientes.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCadastrarClientes.Location = new System.Drawing.Point(270, 45);
            this.btnCadastrarClientes.Name = "btnCadastrarClientes";
            this.btnCadastrarClientes.Size = new System.Drawing.Size(91, 34);
            this.btnCadastrarClientes.TabIndex = 2;
            this.btnCadastrarClientes.Text = "Cadastrar";
            this.btnCadastrarClientes.UseVisualStyleBackColor = true;
            this.btnCadastrarClientes.Click += new System.EventHandler(this.BtnCadastrarClientes_Click);
            // 
            // btnCadastrarColaboradores
            // 
            this.btnCadastrarColaboradores.FlatAppearance.BorderSize = 2;
            this.btnCadastrarColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarColaboradores.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarColaboradores.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCadastrarColaboradores.Location = new System.Drawing.Point(270, 143);
            this.btnCadastrarColaboradores.Name = "btnCadastrarColaboradores";
            this.btnCadastrarColaboradores.Size = new System.Drawing.Size(91, 34);
            this.btnCadastrarColaboradores.TabIndex = 5;
            this.btnCadastrarColaboradores.Text = "Cadastrar";
            this.btnCadastrarColaboradores.UseVisualStyleBackColor = true;
            this.btnCadastrarColaboradores.Click += new System.EventHandler(this.BtnCadastrarColaboradores_Click);
            // 
            // lblQuantidadeColaboradores
            // 
            this.lblQuantidadeColaboradores.AutoSize = true;
            this.lblQuantidadeColaboradores.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidadeColaboradores.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblQuantidadeColaboradores.Location = new System.Drawing.Point(12, 107);
            this.lblQuantidadeColaboradores.Name = "lblQuantidadeColaboradores";
            this.lblQuantidadeColaboradores.Size = new System.Drawing.Size(530, 21);
            this.lblQuantidadeColaboradores.TabIndex = 4;
            this.lblQuantidadeColaboradores.Text = "Digite a quantidade de colaboradores que deseja gerar aleatoriamente.";
            // 
            // txtQuantidadeColaboradores
            // 
            this.txtQuantidadeColaboradores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtQuantidadeColaboradores.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtQuantidadeColaboradores.BorderSize = 2;
            this.txtQuantidadeColaboradores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantidadeColaboradores.ForeColor = System.Drawing.Color.DimGray;
            this.txtQuantidadeColaboradores.Location = new System.Drawing.Point(13, 141);
            this.txtQuantidadeColaboradores.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidadeColaboradores.MaxLength = 10;
            this.txtQuantidadeColaboradores.Multiline = false;
            this.txtQuantidadeColaboradores.Name = "txtQuantidadeColaboradores";
            this.txtQuantidadeColaboradores.Padding = new System.Windows.Forms.Padding(7);
            this.txtQuantidadeColaboradores.PasswordChar = false;
            this.txtQuantidadeColaboradores.SelectionLength = 0;
            this.txtQuantidadeColaboradores.SelectionStart = 0;
            this.txtQuantidadeColaboradores.Size = new System.Drawing.Size(250, 36);
            this.txtQuantidadeColaboradores.TabIndex = 3;
            this.txtQuantidadeColaboradores.Texto = "";
            this.txtQuantidadeColaboradores.UnderlinedStyle = true;
            this.txtQuantidadeColaboradores._TextChanged += new System.EventHandler(this.TxtQuantidadeColaboradores__TextChanged);
            this.txtQuantidadeColaboradores._KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQuantidadeColaboradores__KeyDown);
            // 
            // FrmCadastroListaDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarColaboradores);
            this.Controls.Add(this.lblQuantidadeColaboradores);
            this.Controls.Add(this.txtQuantidadeColaboradores);
            this.Controls.Add(this.btnCadastrarClientes);
            this.Controls.Add(this.lblQuantidadeClientes);
            this.Controls.Add(this.txtQuantidadeClientes);
            this.Name = "FrmCadastroListaDeClientes";
            this.Text = "FrmCadastroListaDeClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.TextBoxFlat txtQuantidadeClientes;
        private System.Windows.Forms.Label lblQuantidadeClientes;
        private System.Windows.Forms.Button btnCadastrarClientes;
        private System.Windows.Forms.Button btnCadastrarColaboradores;
        private System.Windows.Forms.Label lblQuantidadeColaboradores;
        private Componentes.TextBoxFlat txtQuantidadeColaboradores;
    }
}