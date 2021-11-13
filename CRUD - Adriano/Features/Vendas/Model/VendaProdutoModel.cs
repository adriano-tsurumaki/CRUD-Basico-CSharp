using CRUD___Adriano.Features.ValueObject.Precos;
using System;

namespace CRUD___Adriano.Features.Vendas.Model
{
    public class VendaProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataEmissao { get; set; }
        public Preco Desconto { get; set; }
        public int Quantidade { get; set; }
        public Preco PrecoVenda { get; set; }
    }
}
