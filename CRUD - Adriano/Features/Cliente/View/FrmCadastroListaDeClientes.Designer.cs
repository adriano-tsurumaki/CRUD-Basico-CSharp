
namespace CRUD___Adriano.Features.Cliente.View
{
    partial class FrmCadastroListaDeClientes
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
            this.txtQuantidade = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblTituloQuantidade = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtQuantidade.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtQuantidade.BorderSize = 2;
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantidade.ForeColor = System.Drawing.Color.DimGray;
            this.txtQuantidade.Location = new System.Drawing.Point(13, 43);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.MaxLength = 10;
            this.txtQuantidade.Multiline = false;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Padding = new System.Windows.Forms.Padding(7);
            this.txtQuantidade.PasswordChar = false;
            this.txtQuantidade.SelectionLength = 0;
            this.txtQuantidade.SelectionStart = 0;
            this.txtQuantidade.Size = new System.Drawing.Size(250, 36);
            this.txtQuantidade.TabIndex = 0;
            this.txtQuantidade.Texto = "";
            this.txtQuantidade.UnderlinedStyle = true;
            this.txtQuantidade._TextChanged += new System.EventHandler(this.TxtQuantidade__TextChanged);
            this.txtQuantidade._KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQuantidade__KeyDown);
            // 
            // lblTituloQuantidade
            // 
            this.lblTituloQuantidade.AutoSize = true;
            this.lblTituloQuantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloQuantidade.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTituloQuantidade.Location = new System.Drawing.Point(12, 9);
            this.lblTituloQuantidade.Name = "lblTituloQuantidade";
            this.lblTituloQuantidade.Size = new System.Drawing.Size(480, 21);
            this.lblTituloQuantidade.TabIndex = 1;
            this.lblTituloQuantidade.Text = "Digite a quantidade de clientes que deseja gerar aleatoriamente.";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCadastrar.Location = new System.Drawing.Point(270, 45);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(91, 34);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // FrmCadastroListaDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblTituloQuantidade);
            this.Controls.Add(this.txtQuantidade);
            this.Name = "FrmCadastroListaDeClientes";
            this.Text = "FrmCadastroListaDeClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.TextBoxFlat txtQuantidade;
        private System.Windows.Forms.Label lblTituloQuantidade;
        private System.Windows.Forms.Button btnCadastrar;
    }
}