using CRUD___Adriano.Features.Vendas.Controller;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class FrmListagemVenda : Form
    {
        private readonly VendaListagemController _controller;

        public FrmListagemVenda(VendaListagemController controller)
        {
            InitializeComponent();
            _controller = controller;
        }


    }
}
