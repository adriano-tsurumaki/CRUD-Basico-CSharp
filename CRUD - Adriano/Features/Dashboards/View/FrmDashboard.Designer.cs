
namespace CRUD___Adriano.Features.Dashboards.View
{
    partial class FrmDashboard
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
            this.lblTituloQuantidadeClientes = new System.Windows.Forms.Label();
            this.lblTituloQuantidadeFuncionarios = new System.Windows.Forms.Label();
            this.lblQuantidadeClientes = new System.Windows.Forms.Label();
            this.lblQuantidadeFuncionarios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloQuantidadeClientes
            // 
            this.lblTituloQuantidadeClientes.AutoSize = true;
            this.lblTituloQuantidadeClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloQuantidadeClientes.ForeColor = System.Drawing.Color.White;
            this.lblTituloQuantidadeClientes.Location = new System.Drawing.Point(12, 23);
            this.lblTituloQuantidadeClientes.Name = "lblTituloQuantidadeClientes";
            this.lblTituloQuantidadeClientes.Size = new System.Drawing.Size(269, 21);
            this.lblTituloQuantidadeClientes.TabIndex = 0;
            this.lblTituloQuantidadeClientes.Text = "Quantidade de clientes registrados:";
            // 
            // lblTituloQuantidadeFuncionarios
            // 
            this.lblTituloQuantidadeFuncionarios.AutoSize = true;
            this.lblTituloQuantidadeFuncionarios.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloQuantidadeFuncionarios.ForeColor = System.Drawing.Color.White;
            this.lblTituloQuantidadeFuncionarios.Location = new System.Drawing.Point(12, 82);
            this.lblTituloQuantidadeFuncionarios.Name = "lblTituloQuantidadeFuncionarios";
            this.lblTituloQuantidadeFuncionarios.Size = new System.Drawing.Size(303, 21);
            this.lblTituloQuantidadeFuncionarios.TabIndex = 1;
            this.lblTituloQuantidadeFuncionarios.Text = "Quantidade de funcionários registrados:";
            // 
            // lblQuantidadeClientes
            // 
            this.lblQuantidadeClientes.AutoSize = true;
            this.lblQuantidadeClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidadeClientes.ForeColor = System.Drawing.Color.White;
            this.lblQuantidadeClientes.Location = new System.Drawing.Point(348, 23);
            this.lblQuantidadeClientes.Name = "lblQuantidadeClientes";
            this.lblQuantidadeClientes.Size = new System.Drawing.Size(19, 21);
            this.lblQuantidadeClientes.TabIndex = 2;
            this.lblQuantidadeClientes.Text = "0";
            // 
            // lblQuantidadeFuncionarios
            // 
            this.lblQuantidadeFuncionarios.AutoSize = true;
            this.lblQuantidadeFuncionarios.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidadeFuncionarios.ForeColor = System.Drawing.Color.White;
            this.lblQuantidadeFuncionarios.Location = new System.Drawing.Point(348, 82);
            this.lblQuantidadeFuncionarios.Name = "lblQuantidadeFuncionarios";
            this.lblQuantidadeFuncionarios.Size = new System.Drawing.Size(19, 21);
            this.lblQuantidadeFuncionarios.TabIndex = 3;
            this.lblQuantidadeFuncionarios.Text = "0";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(708, 555);
            this.Controls.Add(this.lblQuantidadeFuncionarios);
            this.Controls.Add(this.lblQuantidadeClientes);
            this.Controls.Add(this.lblTituloQuantidadeFuncionarios);
            this.Controls.Add(this.lblTituloQuantidadeClientes);
            this.Name = "FrmDashboard";
            this.Text = "FrmDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloQuantidadeClientes;
        private System.Windows.Forms.Label lblTituloQuantidadeFuncionarios;
        private System.Windows.Forms.Label lblQuantidadeClientes;
        private System.Windows.Forms.Label lblQuantidadeFuncionarios;
    }
}