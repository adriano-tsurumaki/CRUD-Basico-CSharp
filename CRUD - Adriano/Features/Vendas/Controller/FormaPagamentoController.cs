using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.View;
using System;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class FormaPagamentoController
    {
        private readonly UcFormaPagamento _ucFormaPagamento;

        public FormaPagamentoController()
        {
            _ucFormaPagamento = new UcFormaPagamento();
        }

        public void AdicionarModel(VendaModel vendaModel) =>
            _ucFormaPagamento.BindModel(vendaModel);

        public UcFormaPagamento RetornarUserControl() => _ucFormaPagamento;

        public void AtualizarValoresTotais(VendaModel vendaModel) =>
            _ucFormaPagamento.AtualizarValoresTotais(vendaModel);
    }
}
