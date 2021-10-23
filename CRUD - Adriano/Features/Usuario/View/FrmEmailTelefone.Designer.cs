
namespace CRUD___Adriano.Features.Usuario.View
{
    partial class FrmEmailTelefone<T>
    //partial class FrmEmailTelefone
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
            this.cbTelefone = new CRUD___Adriano.Features.Componentes.ComboBoxFlat();
            this.btnAdicionarTelefone = new System.Windows.Forms.Button();
            this.btnAdicionarEmail = new System.Windows.Forms.Button();
            this.txtTelefone = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.dgvTelefones = new System.Windows.Forms.DataGridView();
            this.txtEmail = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dgvEmails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmails)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTelefone
            // 
            this.cbTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.cbTelefone.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbTelefone.BorderSize = 1;
            this.cbTelefone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbTelefone.ForeColor = System.Drawing.Color.DimGray;
            this.cbTelefone.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbTelefone.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTelefone.ListTextColor = System.Drawing.Color.DimGray;
            this.cbTelefone.Location = new System.Drawing.Point(342, 86);
            this.cbTelefone.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbTelefone.Name = "cbTelefone";
            this.cbTelefone.Padding = new System.Windows.Forms.Padding(1);
            this.cbTelefone.Size = new System.Drawing.Size(287, 30);
            this.cbTelefone.TabIndex = 27;
            this.cbTelefone.Texto = "";
            // 
            // btnAdicionarTelefone
            // 
            this.btnAdicionarTelefone.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAdicionarTelefone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarTelefone.FlatAppearance.BorderSize = 0;
            this.btnAdicionarTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarTelefone.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionarTelefone.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarTelefone.Location = new System.Drawing.Point(536, 41);
            this.btnAdicionarTelefone.Name = "btnAdicionarTelefone";
            this.btnAdicionarTelefone.Size = new System.Drawing.Size(93, 29);
            this.btnAdicionarTelefone.TabIndex = 26;
            this.btnAdicionarTelefone.Text = "Adicionar";
            this.btnAdicionarTelefone.UseVisualStyleBackColor = false;
            this.btnAdicionarTelefone.Click += new System.EventHandler(this.BtnAdicionarTelefone_Click);
            // 
            // btnAdicionarEmail
            // 
            this.btnAdicionarEmail.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAdicionarEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarEmail.FlatAppearance.BorderSize = 0;
            this.btnAdicionarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionarEmail.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarEmail.Location = new System.Drawing.Point(206, 44);
            this.btnAdicionarEmail.Name = "btnAdicionarEmail";
            this.btnAdicionarEmail.Size = new System.Drawing.Size(93, 29);
            this.btnAdicionarEmail.TabIndex = 25;
            this.btnAdicionarEmail.Text = "Adicionar";
            this.btnAdicionarEmail.UseVisualStyleBackColor = false;
            this.btnAdicionarEmail.Click += new System.EventHandler(this.BtnAdicionarEmail_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.txtTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtTelefone.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTelefone.BorderSize = 2;
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefone.Location = new System.Drawing.Point(342, 34);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Multiline = false;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Padding = new System.Windows.Forms.Padding(7);
            this.txtTelefone.PasswordChar = false;
            this.txtTelefone.Size = new System.Drawing.Size(187, 36);
            this.txtTelefone.TabIndex = 19;
            this.txtTelefone.Texto = "";
            this.txtTelefone.UnderlinedStyle = true;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTelefone.Location = new System.Drawing.Point(342, 9);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(80, 21);
            this.lblTelefone.TabIndex = 24;
            this.lblTelefone.Text = "Telefones";
            // 
            // dgvTelefones
            // 
            this.dgvTelefones.AllowUserToAddRows = false;
            this.dgvTelefones.AllowUserToDeleteRows = false;
            this.dgvTelefones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTelefones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.dgvTelefones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefones.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvTelefones.Location = new System.Drawing.Point(342, 130);
            this.dgvTelefones.Name = "dgvTelefones";
            this.dgvTelefones.RowTemplate.Height = 25;
            this.dgvTelefones.Size = new System.Drawing.Size(287, 164);
            this.dgvTelefones.TabIndex = 23;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Location = new System.Drawing.Point(12, 34);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(187, 36);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.Texto = "";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblEmail.Location = new System.Drawing.Point(12, 9);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 21);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Emails";
            // 
            // dgvEmails
            // 
            this.dgvEmails.AccessibleDescription = "";
            this.dgvEmails.AllowUserToAddRows = false;
            this.dgvEmails.AllowUserToDeleteRows = false;
            this.dgvEmails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.dgvEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmails.Location = new System.Drawing.Point(12, 86);
            this.dgvEmails.Name = "dgvEmails";
            this.dgvEmails.RowTemplate.Height = 25;
            this.dgvEmails.RowTemplate.ReadOnly = true;
            this.dgvEmails.Size = new System.Drawing.Size(287, 164);
            this.dgvEmails.TabIndex = 21;
            // 
            // FrmEmailTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(642, 316);
            this.Controls.Add(this.cbTelefone);
            this.Controls.Add(this.btnAdicionarTelefone);
            this.Controls.Add(this.btnAdicionarEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.dgvTelefones);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.dgvEmails);
            this.KeyPreview = true;
            this.Name = "FrmEmailTelefone";
            this.Text = "FrmEmailTelefone";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.ComboBoxFlat cbTelefone;
        public System.Windows.Forms.Button btnAdicionarTelefone;
        public System.Windows.Forms.Button btnAdicionarEmail;
        private Componentes.TextBoxFlat txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.DataGridView dgvTelefones;
        private Componentes.TextBoxFlat txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridView dgvEmails;
    }
}