using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.View;
using System.Collections.Generic;
using System.ComponentModel;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class ListaPagamentoController
    {
        private readonly UcListaPagamento _ucListaPagamento;
        private BindingList<FormaPagamentoModel> _formaPagamentosBinding;

        public ListaPagamentoController()
        {
            _ucListaPagamento = new UcListaPagamento();
        }

        public UcListaPagamento RetornarUserControl() => _ucListaPagamento;

        public void AdicionarModel(IList<FormaPagamentoModel> listaFormaPagamento)
        {
            _formaPagamentosBinding = new BindingList<FormaPagamentoModel>(listaFormaPagamento);
            _ucListaPagamento.BindModel(_formaPagamentosBinding); 
        }

        public void AdicionarPagamentosNaLista(IList<FormaPagamentoModel> listaFormaPagamentos)
        {
            foreach (var pagamento in listaFormaPagamentos)
            {
                pagamento.PosicaoPagamento = _formaPagamentosBinding.Count + 1;
                _formaPagamentosBinding.Add(pagamento);
            }
        }
    }
}
