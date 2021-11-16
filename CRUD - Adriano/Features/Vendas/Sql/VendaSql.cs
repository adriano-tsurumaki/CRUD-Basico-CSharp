namespace CRUD___Adriano.Features.Vendas.Sql
{
    public static class VendaSql
    {
        public readonly static string SelecionarProdutoVendaPorId =
            @"select id, nome, preco_bruto as PrecoVenda from Produto where id = @id and ativo = 1";

        public readonly static string SelecionarProdutoVendaPeloNome =
            @"select id, nome, preco_bruto as PrecoVenda from Produto where nome Like @nome + '%' and ativo = 1";
    }
}
