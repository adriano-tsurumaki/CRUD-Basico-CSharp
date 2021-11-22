using CRUD___Adriano.Features.ValueObject.Precos;
using System.Collections.Generic;
using System.Linq;

namespace CRUD___Adriano.Features.Vendas.Model
{
    public class VendaModel
    {
        public int IdColaborador { get; private set; }
        public int IdCliente { get; private set; }
        public IList<VendaProdutoModel> ListaDeProdutos { get; }
        public IList<FormaPagamentoModel> ListaPagamentos { get; }
        public Preco DescontoTotal { get => ListaDeProdutos.Sum(x => x.Desconto.Valor); }
        public Preco ValorBrutoTotal { get => ListaDeProdutos.Sum(x => x.PrecoBruto.Valor); }
        public Preco ValorLiquidoTotal { get => ListaDeProdutos.Sum(x => x.PrecoLiquido.Valor); }
        public Preco ValorPago { get => ListaPagamentos.Sum(x => x.ValorAPagar.Valor); }

        public void DefinirColaborador(int  idColaborador) => IdColaborador = idColaborador;

        public void DefinirCliente(int idCliente) => IdCliente = idCliente;

        public VendaModel()
        {
            ListaDeProdutos = new List<VendaProdutoModel>();
            ListaPagamentos = new List<FormaPagamentoModel>();
        }
    }
}
