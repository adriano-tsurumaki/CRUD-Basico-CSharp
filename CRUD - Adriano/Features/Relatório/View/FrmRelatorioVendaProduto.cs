using CRUD___Adriano.Features.Relatório.Controller;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Relatório.View
{
    public partial class FrmRelatorioVendaProduto : Form
    {
        private readonly RelatorioVendaProdutoController _controller;

        public FrmRelatorioVendaProduto(RelatorioVendaProdutoController controller)
        {
            InitializeComponent();
            _controller = controller;
        }
    }
}
