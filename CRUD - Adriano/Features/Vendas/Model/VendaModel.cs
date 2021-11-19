using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Colaborador.Model;
using CRUD___Adriano.Features.ValueObject.Precos;
using System.Collections.Generic;
using System.Linq;

namespace CRUD___Adriano.Features.Vendas.Model
{
    public class VendaModel
    {
        public ColaboradorModel Colaborador { get; private set; }
        public ClienteModel Cliente { get; private set; }
        public IList<VendaProdutoModel> ListaDeProdutos { get; }
        public IList<FormaPagamentoModel> ListaPagamentos { get; }
        public Preco ValorTotal { get => ListaDeProdutos.Sum(x => x.PrecoLiquido.Valor); }
        public Preco ValorPago { get => ListaPagamentos.Sum(x => x.ValorAPagar.Valor); }

        public void DefinirColaborador(ColaboradorModel colaborador) => Colaborador = colaborador;

        public void DefinirCliente(ClienteModel cliente) => Cliente = cliente;

        public VendaModel()
        {
            ListaDeProdutos = new List<VendaProdutoModel>();
            ListaPagamentos = new List<FormaPagamentoModel>();
        }
    }
}
