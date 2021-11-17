using CRUD___Adriano.Features.Vendas.Controller;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class UcDescontoVenda : UserControl
    {
        public event HabilitarUserControlHandler EventDesabilitarUcDesconto;

        public UcDescontoVenda()
        {
            InitializeComponent();
        }

        private void LblVoltar_Click(object sender, EventArgs e) =>
            EventDesabilitarUcDesconto?.Invoke();
    }
}
