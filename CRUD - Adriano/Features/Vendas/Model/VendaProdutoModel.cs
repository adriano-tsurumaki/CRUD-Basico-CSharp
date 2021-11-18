using CRUD___Adriano.Features.ValueObject.Porcentagens;
using CRUD___Adriano.Features.ValueObject.Precos;
using System;

namespace CRUD___Adriano.Features.Vendas.Model
{
    public class VendaProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataEmissao { get; }
        public Preco Desconto { get; set; }
        public int Quantidade { get; set; }
        public Preco PrecoBruto { get; set; }
        public Porcentagem Lucro { get; set; }
        public Preco PrecoVenda { get => PrecoBruto * (Lucro.Valor + 1); }

        public VendaProdutoModel()
        {
            DataEmissao = DateTime.Now;
            Quantidade = 1;
        }

        public Preco PrecoLiquido { get => (PrecoVenda - Desconto) * Quantidade; }
    }
}
