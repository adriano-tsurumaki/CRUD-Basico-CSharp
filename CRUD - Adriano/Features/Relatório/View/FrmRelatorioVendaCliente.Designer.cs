
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorioVendaCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnlTotalizadores = new System.Windows.Forms.Panel();
            this.btnAbrirFiltro = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.pnlRight.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlFiltroData.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnlRight.Location = new System.Drawing.Point(1035, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(234, 761);
            this.pnlRight.TabIndex = 7;
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
            this.pnlFiltro.Size = new System.Drawing.Size(234, 697);
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
            this.pnlBotoes.Location = new System.Drawing.Point(0, 697);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(234, 64);
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
            // 
            // pnlTotalizadores
            // 
            this.pnlTotalizadores.Controls.Add(this.btnAbrirFiltro);
            this.pnlTotalizadores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotalizadores.Location = new System.Drawing.Point(0, 697);
            this.pnlTotalizadores.Name = "pnlTotalizadores";
            this.pnlTotalizadores.Size = new System.Drawing.Size(1035, 64);
            this.pnlTotalizadores.TabIndex = 11;
            // 
            // btnAbrirFiltro
            // 
            this.btnAbrirFiltro.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAbrirFiltro.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAbrirFiltro.FlatAppearance.BorderSize = 0;
            this.btnAbrirFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirFiltro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirFiltro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbrirFiltro.Location = new System.Drawing.Point(970, 0);
            this.btnAbrirFiltro.Name = "btnAbrirFiltro";
            this.btnAbrirFiltro.Size = new System.Drawing.Size(65, 64);
            this.btnAbrirFiltro.TabIndex = 16;
            this.btnAbrirFiltro.UseVisualStyleBackColor = false;
            this.btnAbrirFiltro.Click += new System.EventHandler(this.BtnAbrirFiltro_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
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
            this.gridView.Size = new System.Drawing.Size(1035, 697);
            this.gridView.TabIndex = 12;
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
            this.Text = "FrmRelatorioVendaCliente";
            this.pnlRight.ResumeLayout(false);
            this.pnlFiltro.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlFiltroData.ResumeLayout(false);
            this.pnlFiltroData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlTotalizadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label txtCliente;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.Button btnDeselecionarCliente;
        private System.Windows.Forms.Button btnDeselecionarProduto;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Label txtProduto;
        private System.Windows.Forms.Panel pnlFiltroData;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.DateTimePicker dtDataFinal;
        private System.Windows.Forms.DateTimePicker dtDataInicio;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkDataFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Panel pnlTotalizadores;
        private System.Windows.Forms.Button btnAbrirFiltro;
        private System.Windows.Forms.DataGridView gridView;
    }
}