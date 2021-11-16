using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.Sql;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CRUD___Adriano.Features.Vendas.Dao
{
    public class VendaProdutoDao
    {
        private readonly IDbConnection _conexao;

        public VendaProdutoDao(IDbConnection conexao)
        {
            _conexao = conexao;
        }

        public VendaProdutoModel SelecionarProdutoPeloId(int id) =>
            _conexao.QuerySingleOrDefault<VendaProdutoModel>(VendaSql.SelecionarProdutoVendaPorId, new { id });

        public IList<VendaProdutoModel> SelecionarProdutoPeloNome(string nome) =>
            _conexao.Query<VendaProdutoModel>(VendaSql.SelecionarProdutoVendaPeloNome, new { nome }).ToList();

        public IList<VendaProdutoModel> ListarTodosParaVenda() =>
            _conexao.Query<VendaProdutoModel>(VendaSql.ListarTodosParaVenda).ToList();
    }
}
