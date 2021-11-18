using CRUD___Adriano.Features.Vendas.Model;

namespace CRUD___Adriano.Features.Utils
{
    public static class VendaProdutoExtension
    {
        public static bool Vazio(this VendaProdutoModel produto)
        {
            if (produto is null || (string.IsNullOrEmpty(produto.Nome) && produto.Desconto.Valor == 0 && 
                produto.Id == 0 && produto.Quantidade == 0 && 
                produto.PrecoVenda.Valor == 0)) return true;

            return false;
        }
    }
}
