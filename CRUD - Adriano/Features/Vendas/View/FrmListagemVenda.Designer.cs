﻿
namespace CRUD___Adriano.Features.Vendas.View
{
    partial class FrmListagemVenda
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
            this.gridView = new System.Windows.Forms.DataGridView();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.txtPesquisar = new CRUD___Adriano.Features.Componentes.TextBoxFlat();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.pnlPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
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
            this.gridView.Location = new System.Drawing.Point(0, 36);
            this.gridView.Name = "gridView";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.gridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridView.RowTemplate.Height = 25;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(817, 471);
            this.gridView.TabIndex = 3;
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.pnlPesquisa.Controls.Add(this.txtPesquisar);
            this.pnlPesquisa.Controls.Add(this.btnPesquisar);
            this.pnlPesquisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPesquisa.Location = new System.Drawing.Point(0, 0);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(817, 36);
            this.pnlPesquisa.TabIndex = 4;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPesquisar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPesquisar.BorderSize = 2;
            this.txtPesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisar.ForeColor = System.Drawing.Color.DimGray;
            this.txtPesquisar.Location = new System.Drawing.Point(0, 0);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisar.MaxLength = 32767;
            this.txtPesquisar.Multiline = false;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Padding = new System.Windows.Forms.Padding(7);
            this.txtPesquisar.PasswordChar = false;
            this.txtPesquisar.ReadOnly = false;
            this.txtPesquisar.SelectionLength = 0;
            this.txtPesquisar.SelectionStart = 0;
            this.txtPesquisar.Size = new System.Drawing.Size(725, 36);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.Texto = "";
            this.txtPesquisar.UnderlinedStyle = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPesquisar.FlatAppearance.BorderSize = 2;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(725, 0);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(92, 36);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.Color.Silver;
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFiltro.Location = new System.Drawing.Point(817, 0);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(176, 507);
            this.pnlFiltro.TabIndex = 5;
            // 
            // FrmListagemVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 507);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.pnlFiltro);
            this.Name = "FrmListagemVenda";
            this.Text = "FrmListagemVenda";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.pnlPesquisa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Panel pnlPesquisa;
        private Componentes.TextBoxFlat txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel pnlFiltro;
    }
}