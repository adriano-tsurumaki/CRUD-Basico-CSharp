using CRUD___Adriano.Features.Relatório.Enum;
using CRUD___Adriano.Features.Utils;
using CRUD___Adriano.Features.ValueObject.Precos;
using CRUD___Adriano.Features.Vendas.Sql;
using Dapper;
using System;

namespace CRUD___Adriano.Features.Relatório.Dao
{
    public class FiltroRelatorioVendaCliente
    {
        public int IdCliente { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public ComparadorEnum TipoComparador{ get; set; }
        public Preco PrecoSelecionado { get; set; }
        public int QuantidadeCliente { get; set; }
        public OrdernarClienteVendaEnum TipoOrdernar { get; set; }


        public string GerarSql()
        {
            throw new NotImplementedException();
        }

        public DynamicParameters RetornarParametroDinamico()
        {
            var parametros = new DynamicParameters();

            parametros.AddDynamicParams(new
            {
                IdCliente,
                DataInicio = DataInicio.ZerarHorario(),
                DataFinal = DataFinal.ZerarHorario(),
                PrecoSelecionado = PrecoSelecionado.Valor,
                QuantidadeCliente,
            });

            return parametros;
        }
    }
}
