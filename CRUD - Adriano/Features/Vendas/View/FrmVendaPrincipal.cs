using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.Produto.Model;
using CRUD___Adriano.Features.Usuario.Controller;
using System.Drawing;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class FrmVendaPrincipal : Form
    {
        public FrmVendaPrincipal()
        {
            InitializeComponent();
            AdicionarControl(pnlHeader, new UcVendaHeader());
            AdicionarControl(pnlLeftCentral, ConfigNinject.ObterInstancia<BuscarUsuarioController<ProdutoModel>>().RetornarFormulario());
        }

        public void AdicionarControl(Panel panel, UserControl formFilha)
        {
            panel.Controls.Add(formFilha);
            panel.Tag = formFilha;

            formFilha.Dock = DockStyle.Fill;
            formFilha.BringToFront();
            formFilha.Show();
        }

        public void AdicionarControl(Panel panel, Form formFilha)
        {
            panel.Controls.Clear();

            formFilha.TopLevel = false;
            formFilha.FormBorderStyle = FormBorderStyle.None;
            formFilha.Dock = DockStyle.Fill;

            panel.Controls.Add(formFilha);
            panel.Tag = formFilha;

            formFilha.BringToFront();
            formFilha.Show();
            formFilha.Focus();
        }

        private void FrmVendaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void FrmVendaPrincipal_Load(object sender, System.EventArgs e)
        {
            pnlLeftCentral.Size = new Size(Width / 2, pnlLeftCentral.Size.Height);
        }
    }
}
