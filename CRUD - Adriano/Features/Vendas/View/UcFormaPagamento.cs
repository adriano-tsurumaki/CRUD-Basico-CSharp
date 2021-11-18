using CRUD___Adriano.Features.Utils;
using CRUD___Adriano.Features.Vendas.Enum;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class UcFormaPagamento : UserControl
    {
        public UcFormaPagamento()
        {
            InitializeComponent();
            cbFormaPagamento.AtribuirPeloEnum<TipoPagamentoEnum>();
        }
    }
}
