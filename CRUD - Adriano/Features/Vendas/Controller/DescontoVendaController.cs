using CRUD___Adriano.Features.Vendas.View;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class DescontoVendaController
    {
        private readonly UcDescontoVenda _ucDescontoVenda;

        public DescontoVendaController()
        {
            _ucDescontoVenda = new UcDescontoVenda();
        }

        public UcDescontoVenda RetornarUserControl() => _ucDescontoVenda;
    }
}
