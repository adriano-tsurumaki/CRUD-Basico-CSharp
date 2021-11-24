using CRUD___Adriano.Features.Produto.Model;
using Dapper;

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

        public static DynamicParameters RetornarParametroDinamicoParaInserirUm(ProdutoModel produtoModel)
        {
            var parametros = new DynamicParameters();

            parametros.AddDynamicParams(new
            {
                IdFornecedor = produtoModel.Fornecedor.Id,
                produtoModel.CodigoBarras,
                produtoModel.Nome,
                PrecoBruto = produtoModel.PrecoBruto.Valor,
                produtoModel.Lucro,
                produtoModel.Quantidade
            });

            return parametros;
        }
    }
}
