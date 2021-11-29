using CRUD___Adriano.Features.Produto.Model;
using CRUD___Adriano.Features.Vendas.Sql;
using Dapper;
using System;
using System.Data;

namespace CRUD___Adriano.Features.Produto.Sql
{
    public static class ProdutoSql
    {
        public static readonly string Inserir =
            @"insert into Produto (id_fornecedor, codigo_barra, nome, preco_bruto, lucro, quantidade) 
            values (@IdFornecedor, @CodigoBarras, @Nome, @PrecoBruto, @Lucro, @Quantidade)";
        
        public static readonly string AtualizarEstoque =
            @"update Produto set
                quantidade = @Quantidade
                where id = @id";
        
        public static readonly string SelecionarQuantidade =
            @"select quantidade from Produto where id = @id";

        public static readonly string Atualizar =
            @"update Produto set
            id_fornecedor = @IdFornecedor,
            codigo_barra = @CodigoBarras,
            nome = @Nome,
            preco_bruto = @PrecoBruto,
            quantidade = @Quantidade,
            lucro = @Lucro
            where id = @id";

        public static readonly string ListarTodos =
            @"select id, nome, codigo_barra as CodigoBarra, preco_bruto as PrecoBruto, lucro
            from Produto";

        public static readonly string ListarTodosComCamposSomenteIdENome =
            @"select id, nome, ativo, quantidade from Produto";

        public static readonly string ListarPelaQuantidadeComCamposSomenteIdENome =
            @"select top {=Quantidade} id, nome, ativo, quantidade from Produto";

        public static string ListarPeloNomeComCamposSomenteIdENome =
            @"select id, nome, ativo, quantidade
			from Produto
            where nome Like @Nome + '%'";

        public static readonly string SelecionarComCamposSomenteIdENome =
            @"select id, nome, ativo, quantidade
			from Produto
            where id = @id";

        public static readonly string Selecionar =
            @"select id, nome, codigo_barra as CodigoBarras, quantidade, preco_bruto as PrecoBruto, lucro
            from Produto where id = @id";

        public static DynamicParameters RetornarParametroDinamicoParaInserirUm(ProdutoModel produtoModel)
        {
            var parametros = new DynamicParameters();

            parametros.AddDynamicParams(new
            {
                produtoModel.Id,
                IdFornecedor = produtoModel.Fornecedor.Id,
                produtoModel.CodigoBarras,
                produtoModel.Nome,
                PrecoBruto = produtoModel.PrecoBruto.Valor,
                produtoModel.Ativo,
                produtoModel.Lucro,
                produtoModel.Quantidade
            });

            return parametros;
        }

        public static DynamicParameters RetornarParametroDinamicoParaListagemComFiltro(FiltroVendaSql filtroVendaSql)
        {
            var parametros = new DynamicParameters();

            parametros.AddDynamicParams(new
            {
                filtroVendaSql.DataFinal,
                filtroVendaSql.DataInicio,
                filtroVendaSql.TipoComparador,
                ValorVenda = filtroVendaSql.ValorVenda.Valor
            });

            return parametros;
        }
    }
}
