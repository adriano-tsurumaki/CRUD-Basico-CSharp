using CRUD___Adriano.Features.Vendas.Controller;
using CRUD___Adriano.Features.Vendas.Enum;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class UcDescontoVenda : UserControl
    {
        public delegate void DesabilitarHandler();
        public delegate void PegarDescontoHandler(TipoDescontoEnum tipoDesconto, double porcentagem);

        private DescontoVendaController _controller;

        public event DesabilitarHandler EventDesabilitar;
        public event PegarDescontoHandler EventPegarDesconto;

        public UcDescontoVenda(DescontoVendaController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void LblVoltar_Click(object sender, EventArgs e) =>
            EventDesabilitar?.Invoke();

        private void BtnCancel_Click(object sender, EventArgs e) =>
            EventDesabilitar?.Invoke();

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            var tipoDesconto = checkDescontoGeral.Checked ? TipoDescontoEnum.Geral : TipoDescontoEnum.Unidade;
            double.TryParse(txtDesconto.Texto, out double desconto);

            if (tipoDesconto == TipoDescontoEnum.Geral)
                _controller.DefinirQueFoiAplicadoODescontoGeral();

            EventPegarDesconto?.Invoke(tipoDesconto, desconto);
            EventDesabilitar?.Invoke();
        }

        private void BtnLimparTodosDescontos_Click(object sender, EventArgs e)
        {
            EventPegarDesconto?.Invoke(TipoDescontoEnum.Geral, 0);
            EventDesabilitar?.Invoke();
        }
    }
}
