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

        public void DefinirLabelCliente(string nome) => _ucVendaHeader.DefinirLabelCliente(nome);

        public void DefinirLabelColaborador(string nome) => _ucVendaHeader.DefinirLabelColaborador(nome);
    }
}
