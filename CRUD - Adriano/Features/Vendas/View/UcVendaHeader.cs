using System;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class UcVendaHeader : UserControl
    {
        public UcVendaHeader()
        {
            InitializeComponent();
            lblHorario.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void TimerHorario_Tick(object sender, EventArgs e)
        {
            lblHorario.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
