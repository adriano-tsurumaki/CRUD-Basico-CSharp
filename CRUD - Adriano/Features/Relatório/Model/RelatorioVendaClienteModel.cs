using CRUD___Adriano.Features.ValueObject.Precos;

namespace CRUD___Adriano.Features.Relatório.Model
{
    public class RelatorioVendaClienteModel
    {
        public string NomeCliente { get; set; }
        public int QuantidadeVendas { get; set; }
        public Preco TotalBruto { get; set; }
        public Preco DescontoTotal { get; set; }
        public Preco TotalLiquido { get; set; }
    }
}
