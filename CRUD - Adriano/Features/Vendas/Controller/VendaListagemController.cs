using CRUD___Adriano.Features.Vendas.View;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class VendaListagemController
    {
        private readonly FrmListagemVenda _frmListagemVenda;

        public VendaListagemController()
        {
            _frmListagemVenda = new FrmListagemVenda(this);
        }

        public FrmListagemVenda RetornarFormulario() => _frmListagemVenda;
    }
}
