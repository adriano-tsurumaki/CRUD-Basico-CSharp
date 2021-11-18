using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.View;
using System;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class DescontoVendaController
    {
        private readonly UcDescontoVenda _ucDescontoVenda;
        private VendaProdutoModel _vendaProdutoSelecionado;

        public DescontoVendaController()
        {
            _ucDescontoVenda = new UcDescontoVenda();
        }

        public UcDescontoVenda RetornarUserControl() => _ucDescontoVenda;
    }
}
