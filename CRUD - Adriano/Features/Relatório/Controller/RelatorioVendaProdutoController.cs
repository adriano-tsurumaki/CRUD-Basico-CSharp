using CRUD___Adriano.Features.Relatório.Dao;
using CRUD___Adriano.Features.Relatório.View;

namespace CRUD___Adriano.Features.Relatório.Controller
{
    public class RelatorioVendaProdutoController
    {
        private readonly RelatorioVendaProdutoDao _relatorioVendaProdutoDao;
        private readonly FrmRelatorioVendaProduto _frmRelatorioVendaProduto;

        public RelatorioVendaProdutoController(RelatorioVendaProdutoDao relatorioVendaProdutoDao)
        {
            _relatorioVendaProdutoDao = relatorioVendaProdutoDao;
            _frmRelatorioVendaProduto = new FrmRelatorioVendaProduto(this);
        }
    }
}
