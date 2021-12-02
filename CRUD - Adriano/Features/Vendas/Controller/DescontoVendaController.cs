using CRUD___Adriano.Features.Vendas.View;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class DescontoVendaController
    {
        private readonly UcDescontoVenda _ucDescontoVenda;

        private bool _foiAplicadoDescontoGeral;

        public DescontoVendaController()
        {
            _ucDescontoVenda = new UcDescontoVenda(this);
            _foiAplicadoDescontoGeral = false;
        }

        public UcDescontoVenda RetornarUserControl() => _ucDescontoVenda;

        public void DefinirQueFoiAplicadoODescontoGeral() => _foiAplicadoDescontoGeral = true;

        public void DefinirQueNaoFoiAplicadoODescontoGeral() => _foiAplicadoDescontoGeral = false;

        public bool FoiAplicadoDescontoGeral() => _foiAplicadoDescontoGeral;
    }
}
