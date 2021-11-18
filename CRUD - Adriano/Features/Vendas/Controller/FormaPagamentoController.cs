using CRUD___Adriano.Features.Vendas.View;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class FormaPagamentoController
    {
        private readonly UcFormaPagamento _ucFormaPagamento;

        public FormaPagamentoController()
        {
            _ucFormaPagamento = new UcFormaPagamento();
        }

        public UcFormaPagamento RetornarUserControl() => _ucFormaPagamento;
    }
}
