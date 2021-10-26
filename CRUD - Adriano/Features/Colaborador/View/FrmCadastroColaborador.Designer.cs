
namespace CRUD___Adriano.Features.Colaborador.View
{
    partial class FrmCadastroColaborador
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
            this.txtSalario = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtComissao = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblComissao = new System.Windows.Forms.Label();
            this.cbTipoConta = new CRUD___Adriano.Features.Componentes.ComboBoxFlat();
            this.lblTipoConta = new System.Windows.Forms.Label();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.txtAgencia = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblConta = new System.Windows.Forms.Label();
            this.txtConta = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblBanco = new System.Windows.Forms.Label();
            this.txtBanco = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.txtSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtSalario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSalario.BorderSize = 2;
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSalario.Location = new System.Drawing.Point(12, 44);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalario.Multiline = false;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Padding = new System.Windows.Forms.Padding(7);
            this.txtSalario.PasswordChar = false;
            this.txtSalario.SelectionLength = 0;
            this.txtSalario.SelectionStart = 0;
            this.txtSalario.Size = new System.Drawing.Size(287, 36);
            this.txtSalario.TabIndex = 5;
            this.txtSalario.Texto = "";
            this.txtSalario.UnderlinedStyle = true;
            this.txtSalario._TextChanged += new System.EventHandler(this.TxtSalario__TextChanged);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalario.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblSalario.Location = new System.Drawing.Point(12, 9);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(66, 21);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salario*";
            // 
            // txtComissao
            // 
            this.txtComissao.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.txtComissao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtComissao.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtComissao.BorderSize = 2;
            this.txtComissao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComissao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtComissao.Location = new System.Drawing.Point(12, 129);
            this.txtComissao.Margin = new System.Windows.Forms.Padding(4);
            this.txtComissao.Multiline = false;
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Padding = new System.Windows.Forms.Padding(7);
            this.txtComissao.PasswordChar = false;
            this.txtComissao.SelectionLength = 0;
            this.txtComissao.SelectionStart = 0;
            this.txtComissao.Size = new System.Drawing.Size(287, 36);
            this.txtComissao.TabIndex = 7;
            this.txtComissao.Texto = "";
            this.txtComissao.UnderlinedStyle = true;
            this.txtComissao._TextChanged += new System.EventHandler(this.TxtComissao__TextChanged);
            // 
            // lblComissao
            // 
            this.lblComissao.AutoSize = true;
            this.lblComissao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComissao.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblComissao.Location = new System.Drawing.Point(12, 94);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(87, 21);
            this.lblComissao.TabIndex = 6;
            this.lblComissao.Text = "Comissão*";
            // 
            // cbTipoConta
            // 
            this.cbTipoConta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTipoConta.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbTipoConta.BorderSize = 2;
            this.cbTipoConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbTipoConta.ForeColor = System.Drawing.Color.DimGray;
            this.cbTipoConta.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbTipoConta.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cbTipoConta.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTipoConta.ListTextColor = System.Drawing.Color.DimGray;
            this.cbTipoConta.Location = new System.Drawing.Point(345, 132);
            this.cbTipoConta.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbTipoConta.Name = "cbTipoConta";
            this.cbTipoConta.Padding = new System.Windows.Forms.Padding(2);
            this.cbTipoConta.Size = new System.Drawing.Size(212, 30);
            this.cbTipoConta.TabIndex = 10;
            this.cbTipoConta.Texto = "";
            // 
            // lblTipoConta
            // 
            this.lblTipoConta.AutoSize = true;
            this.lblTipoConta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoConta.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTipoConta.Location = new System.Drawing.Point(345, 96);
            this.lblTipoConta.Name = "lblTipoConta";
            this.lblTipoConta.Size = new System.Drawing.Size(118, 21);
            this.lblTipoConta.TabIndex = 11;
            this.lblTipoConta.Text = "Tipo de conta*";
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAgencia.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblAgencia.Location = new System.Drawing.Point(12, 179);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(159, 21);
            this.lblAgencia.TabIndex = 16;
            this.lblAgencia.Text = "Número da agência*";
            // 
            // txtAgencia
            // 
            this.txtAgencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtAgencia.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAgencia.BorderSize = 2;
            this.txtAgencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAgencia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtAgencia.Location = new System.Drawing.Point(12, 214);
            this.txtAgencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgencia.Multiline = false;
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Padding = new System.Windows.Forms.Padding(7);
            this.txtAgencia.PasswordChar = false;
            this.txtAgencia.SelectionLength = 0;
            this.txtAgencia.SelectionStart = 0;
            this.txtAgencia.Size = new System.Drawing.Size(212, 36);
            this.txtAgencia.TabIndex = 15;
            this.txtAgencia.Texto = "";
            this.txtAgencia.UnderlinedStyle = true;
            this.txtAgencia._TextChanged += new System.EventHandler(this.TxtAgencia__TextChanged);
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConta.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblConta.Location = new System.Drawing.Point(345, 9);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(144, 21);
            this.lblConta.TabIndex = 18;
            this.lblConta.Text = "Número da conta*";
            // 
            // txtConta
            // 
            this.txtConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtConta.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtConta.BorderSize = 2;
            this.txtConta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtConta.Location = new System.Drawing.Point(345, 45);
            this.txtConta.Margin = new System.Windows.Forms.Padding(4);
            this.txtConta.Multiline = false;
            this.txtConta.Name = "txtConta";
            this.txtConta.Padding = new System.Windows.Forms.Padding(7);
            this.txtConta.PasswordChar = false;
            this.txtConta.SelectionLength = 0;
            this.txtConta.SelectionStart = 0;
            this.txtConta.Size = new System.Drawing.Size(212, 36);
            this.txtConta.TabIndex = 17;
            this.txtConta.Texto = "";
            this.txtConta.UnderlinedStyle = true;
            this.txtConta._TextChanged += new System.EventHandler(this.TxtConta__TextChanged);
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBanco.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblBanco.Location = new System.Drawing.Point(345, 177);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(135, 21);
            this.lblBanco.TabIndex = 20;
            this.lblBanco.Text = "Nome do banco*";
            // 
            // txtBanco
            // 
            this.txtBanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtBanco.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBanco.BorderSize = 2;
            this.txtBanco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBanco.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBanco.Location = new System.Drawing.Point(345, 213);
            this.txtBanco.Margin = new System.Windows.Forms.Padding(4);
            this.txtBanco.Multiline = false;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Padding = new System.Windows.Forms.Padding(7);
            this.txtBanco.PasswordChar = false;
            this.txtBanco.SelectionLength = 0;
            this.txtBanco.SelectionStart = 0;
            this.txtBanco.Size = new System.Drawing.Size(212, 36);
            this.txtBanco.TabIndex = 19;
            this.txtBanco.Texto = "";
            this.txtBanco.UnderlinedStyle = true;
            // 
            // FrmCadastroColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.lblAgencia);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.cbTipoConta);
            this.Controls.Add(this.lblTipoConta);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.lblComissao);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.KeyPreview = true;
            this.Name = "FrmCadastroColaborador";
            this.Text = "FrmCadastroColaborador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.TextBoxFlat txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private Componentes.TextBoxFlat txtComissao;
        private System.Windows.Forms.Label lblComissao;
        private Componentes.ComboBoxFlat cbTipoConta;
        private System.Windows.Forms.Label lblTipoConta;
        private System.Windows.Forms.Label lblAgencia;
        private Componentes.TextBoxFlat txtAgencia;
        private System.Windows.Forms.Label lblConta;
        private Componentes.TextBoxFlat txtConta;
        private System.Windows.Forms.Label lblBanco;
        private Componentes.TextBoxFlat txtBanco;
    }
}