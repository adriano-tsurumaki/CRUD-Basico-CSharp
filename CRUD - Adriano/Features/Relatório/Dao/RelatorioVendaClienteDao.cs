using CRUD___Adriano.Features.Relatório.Model;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CRUD___Adriano.Features.Relatório.Dao
{
    public class RelatorioVendaClienteDao
    {
        private readonly IDbConnection _conexao;

        public RelatorioVendaClienteDao(IDbConnection conexao)
        {
            _conexao = conexao;
        }

        internal IList<RelatorioVendaClienteModel> ListarVendaClientesPeloFiltro(FiltroRelatorioVendaCliente filtro)
        {
            try
            {
                _conexao.Open();
                return _conexao.Query<RelatorioVendaClienteModel>(filtro.GerarSql(), filtro.RetornarParametroDinamico()).ToList();
            }
            finally
            {
                _conexao.Close();
            }
        }
    }
}
