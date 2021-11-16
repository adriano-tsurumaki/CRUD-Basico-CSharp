namespace CRUD___Adriano.Features.Vendas.Sql
{
    public static class VendaSql
    {
        public readonly static string SelecionarProdutoVendaPorId =
            @"select nome, preco_bruto as PrecoVenda from Produto where id = @id and ativo = 1";
    }
}
