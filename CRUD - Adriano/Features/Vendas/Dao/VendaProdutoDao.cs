using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.Sql;
using Dapper;
using System;
using System.Data;

namespace CRUD___Adriano.Features.Vendas.Dao
{
    public class VendaProdutoDao
    {
        private readonly IDbConnection _conexao;

        public VendaProdutoDao(IDbConnection conexao)
        {
            _conexao = conexao;
        }

        public VendaProdutoModel SelecionarProdutoPeloId(int id)
        {
            return _conexao.QuerySingleOrDefault<VendaProdutoModel>(VendaSql.SelecionarProdutoVendaPorId, new { id });
        }
    }
}
