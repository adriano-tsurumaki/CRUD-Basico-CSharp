using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Colaborador.Model;
using CRUD___Adriano.Features.ValueObject.Precos;
using System.Collections.Generic;
using System.Linq;

namespace CRUD___Adriano.Features.Vendas.Model
{
    public class VendaModel
    {
        public ColaboradorModel Colaborador { get; set; }
        public ClienteModel Cliente { get; set; }
        public IList<VendaProdutoModel> ListaDeProdutos { get; set; }
        public IList<FormaPagamentoModel> ListaPagamentos { get; set; }
        public Preco ValorTotal { get => ListaDeProdutos.Sum(x => x.PrecoLiquido.Valor); }

        public VendaModel()
        {
            ListaDeProdutos = new List<VendaProdutoModel>();
        }
    }
}
