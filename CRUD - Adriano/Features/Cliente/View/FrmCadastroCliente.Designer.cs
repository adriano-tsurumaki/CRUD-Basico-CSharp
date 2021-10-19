
namespace CRUD___Adriano.Features.Cadastro.Produto.View
{
    partial class FrmCadastroCliente
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
            this.components = new System.ComponentModel.Container();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNome = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtSobrenome = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCep = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtLogradouro = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtBairro = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.txtComplemento = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.txtNumero = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.dataNascimento = new CRUD___Adriano.Features.Componentes.DatePickerFlat();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbSexo = new CRUD___Adriano.Features.Componentes.ComboBoxFlat();
            this.pnlBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNome.Location = new System.Drawing.Point(13, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 21);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome*";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(10, 7);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 38);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(142, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 38);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.panel1);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 518);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(622, 57);
            this.pnlBottom.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(366, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 57);
            this.panel1.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtNome.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNome.BorderSize = 2;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNome.Location = new System.Drawing.Point(13, 37);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(7);
            this.txtNome.PasswordChar = false;
            this.txtNome.Size = new System.Drawing.Size(212, 36);
            this.txtNome.TabIndex = 1;
            this.txtNome.Texto = "";
            this.txtNome.UnderlinedStyle = true;
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNome_Validating);
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSobrenome.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblSobrenome.Location = new System.Drawing.Point(325, 9);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(103, 21);
            this.lblSobrenome.TabIndex = 7;
            this.lblSobrenome.Text = "Sobrenome*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(13, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sexo*";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataNascimento.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblDataNascimento.Location = new System.Drawing.Point(325, 80);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(161, 21);
            this.lblDataNascimento.TabIndex = 10;
            this.lblDataNascimento.Text = "Data de nascimento*";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtSobrenome.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSobrenome.BorderSize = 2;
            this.txtSobrenome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSobrenome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSobrenome.Location = new System.Drawing.Point(325, 37);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(4);
            this.txtSobrenome.Multiline = false;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Padding = new System.Windows.Forms.Padding(7);
            this.txtSobrenome.PasswordChar = false;
            this.txtSobrenome.Size = new System.Drawing.Size(212, 36);
            this.txtSobrenome.TabIndex = 2;
            this.txtSobrenome.Texto = "";
            this.txtSobrenome.UnderlinedStyle = true;
            this.txtSobrenome.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSobrenome_Validating);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCep.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblCep.Location = new System.Drawing.Point(13, 151);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(41, 21);
            this.lblCep.TabIndex = 14;
            this.lblCep.Text = "CEP:";
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtCep.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCep.BorderSize = 2;
            this.txtCep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCep.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCep.Location = new System.Drawing.Point(13, 179);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4);
            this.txtCep.Multiline = false;
            this.txtCep.Name = "txtCep";
            this.txtCep.Padding = new System.Windows.Forms.Padding(7);
            this.txtCep.PasswordChar = false;
            this.txtCep.Size = new System.Drawing.Size(212, 36);
            this.txtCep.TabIndex = 5;
            this.txtCep.Texto = "";
            this.txtCep.UnderlinedStyle = true;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogradouro.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblLogradouro.Location = new System.Drawing.Point(13, 222);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(104, 21);
            this.lblLogradouro.TabIndex = 16;
            this.lblLogradouro.Text = "Logradouro*";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtLogradouro.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLogradouro.BorderSize = 2;
            this.txtLogradouro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogradouro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLogradouro.Location = new System.Drawing.Point(13, 250);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogradouro.Multiline = false;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Padding = new System.Windows.Forms.Padding(7);
            this.txtLogradouro.PasswordChar = false;
            this.txtLogradouro.Size = new System.Drawing.Size(212, 36);
            this.txtLogradouro.TabIndex = 7;
            this.txtLogradouro.Texto = "";
            this.txtLogradouro.UnderlinedStyle = true;
            this.txtLogradouro.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLogradouro_Validating);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBairro.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblBairro.Location = new System.Drawing.Point(13, 293);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(61, 21);
            this.lblBairro.TabIndex = 17;
            this.lblBairro.Text = "Bairro*";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComplemento.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblComplemento.Location = new System.Drawing.Point(13, 364);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(115, 21);
            this.lblComplemento.TabIndex = 18;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCidade.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblCidade.Location = new System.Drawing.Point(325, 151);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(68, 21);
            this.lblCidade.TabIndex = 19;
            this.lblCidade.Text = "Cidade*";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstado.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblEstado.Location = new System.Drawing.Point(325, 222);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(66, 21);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "Estado*";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNumero.Location = new System.Drawing.Point(325, 293);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(77, 21);
            this.lblNumero.TabIndex = 21;
            this.lblNumero.Text = "Numero*";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtBairro.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBairro.BorderSize = 2;
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBairro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBairro.Location = new System.Drawing.Point(13, 321);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Multiline = false;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Padding = new System.Windows.Forms.Padding(7);
            this.txtBairro.PasswordChar = false;
            this.txtBairro.Size = new System.Drawing.Size(212, 36);
            this.txtBairro.TabIndex = 9;
            this.txtBairro.Texto = "";
            this.txtBairro.UnderlinedStyle = true;
            this.txtBairro.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBairro_Validating);
            // 
            // txtComplemento
            // 
            this.txtComplemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtComplemento.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtComplemento.BorderSize = 2;
            this.txtComplemento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComplemento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtComplemento.Location = new System.Drawing.Point(13, 392);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplemento.Multiline = false;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Padding = new System.Windows.Forms.Padding(7);
            this.txtComplemento.PasswordChar = false;
            this.txtComplemento.Size = new System.Drawing.Size(212, 36);
            this.txtComplemento.TabIndex = 11;
            this.txtComplemento.Texto = "";
            this.txtComplemento.UnderlinedStyle = true;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtNumero.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNumero.BorderSize = 2;
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumero.Location = new System.Drawing.Point(325, 321);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Multiline = false;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumero.PasswordChar = false;
            this.txtNumero.Size = new System.Drawing.Size(212, 36);
            this.txtNumero.TabIndex = 10;
            this.txtNumero.Texto = "";
            this.txtNumero.UnderlinedStyle = true;
            this.txtNumero.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNumero_Validating);
            // 
            // dataNascimento
            // 
            this.dataNascimento.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dataNascimento.BorderSize = 0;
            this.dataNascimento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimento.Location = new System.Drawing.Point(325, 108);
            this.dataNascimento.MinimumSize = new System.Drawing.Size(4, 35);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(212, 35);
            this.dataNascimento.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dataNascimento.TabIndex = 22;
            this.dataNascimento.TextColor = System.Drawing.Color.White;
            this.dataNascimento.Validating += new System.ComponentModel.CancelEventHandler(this.DataNascimento_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cbSexo
            // 
            this.cbSexo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSexo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbSexo.BorderSize = 2;
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbSexo.ForeColor = System.Drawing.Color.DimGray;
            this.cbSexo.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cbSexo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbSexo.ListTextColor = System.Drawing.Color.DimGray;
            this.cbSexo.Location = new System.Drawing.Point(12, 113);
            this.cbSexo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Padding = new System.Windows.Forms.Padding(2);
            this.cbSexo.Size = new System.Drawing.Size(212, 30);
            this.cbSexo.TabIndex = 23;
            this.cbSexo.Texto = "";
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(622, 575);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro do produto";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroProduto_KeyDown);
            this.pnlBottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel panel1;
        private Componentes.TextBoxFlat txtNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataNascimento;
        private Componentes.TextBoxFlat txtSobrenome;
        private System.Windows.Forms.Label lblCep;
        private Componentes.TextBoxFlat txtCep;
        private System.Windows.Forms.Label lblLogradouro;
        private Componentes.TextBoxFlat txtLogradouro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNumero;
        private Componentes.TextBoxFlat txtBairro;
        private Componentes.TextBoxFlat txtComplemento;
        private Componentes.TextBoxFlat txtNumero;
        private Componentes.DatePickerFlat dataNascimento;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Componentes.ComboBoxFlat cbSexo;
    }
}