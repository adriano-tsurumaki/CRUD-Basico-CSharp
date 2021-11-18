using CRUD___Adriano.Features.ValueObject.Porcentagens;
using CRUD___Adriano.Features.Vendas.Enum;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class UcDescontoVenda : UserControl
    {
        public delegate void DesabilitarHandler();
        public delegate void PegarDescontoHandler(TipoDescontoEnum tipoDesconto, Porcentagem porcentagem);

        public event DesabilitarHandler EventDesabilitar;
        public event PegarDescontoHandler EventPegarDesconto;

        public UcDescontoVenda()
        {
            InitializeComponent();
        }

        private void LblVoltar_Click(object sender, EventArgs e) =>
            EventDesabilitar?.Invoke();

        private void BtnCancel_Click(object sender, EventArgs e) =>
            EventDesabilitar?.Invoke();

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            var tipoDesconto = checkDescontoGeral.Checked ? TipoDescontoEnum.Geral : TipoDescontoEnum.Unidade;
            double.TryParse(txtDesconto.Texto, out double desconto);

            EventPegarDesconto?.Invoke(tipoDesconto, desconto);
        }
    }
}
