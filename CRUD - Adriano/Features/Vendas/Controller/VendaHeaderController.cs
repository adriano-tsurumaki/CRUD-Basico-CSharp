using CRUD___Adriano.Features.Vendas.View;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class VendaHeaderController
    {
        private readonly UcVendaHeader _ucVendaHeader;

        public VendaHeaderController()
        {
            _ucVendaHeader = new UcVendaHeader();
        }

        public UcVendaHeader RetornarUserControl() => _ucVendaHeader;
    }
}
