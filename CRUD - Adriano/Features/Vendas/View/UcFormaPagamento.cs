using CRUD___Adriano.Features.Utils;
using CRUD___Adriano.Features.Vendas.Controller;
using CRUD___Adriano.Features.Vendas.Enum;
using CRUD___Adriano.Features.Vendas.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class UcFormaPagamento : UserControl
    {
        public delegate void AdicionarPagamentoHandler(IList<FormaPagamentoModel> listaPagamentos);

        public event AdicionarPagamentoHandler EventAdicionarPagamento;

        public UcFormaPagamento()
        {
            InitializeComponent();
            cbFormaPagamento.AtribuirPeloEnum<TipoPagamentoEnum>();
        }

        public void BindModel(VendaModel vendaModel)
        {
            AtualizarValoresTotais(vendaModel);
        }

        public void AtualizarValoresTotais(VendaModel vendaModel)
        {
            lblValorTotal.Text = $"Valor total: {vendaModel.ValorLiquidoTotal.Formatado}";
            lblValorRestante.Text = $"Valor restante: {(vendaModel.ValorLiquidoTotal - vendaModel.ValorPago).Formatado}";
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (!txtQuantidadeParcelas.Numerico())
            {
                MessageBox.Show("Deve ser numérico");
                return;
            }
            if (cbFormaPagamento.PegarEnumPorDescricao<TipoPagamentoEnum>() != TipoPagamentoEnum.Dinheiro && txtQuantidadeParcelas.Texto.IntOuZero() <= 0)
            {
                MessageBox.Show("A quantia de parcela deve ser maior que 0");
                return;
            }
            if (!cbFormaPagamento.EstaSelecionado())
            {
                MessageBox.Show("Selecione uma forma de pagamento!");
                return;
            }
            if (txtValorASerPago.Texto.DoubleOuZero() <= 0)
            {
                MessageBox.Show("Valor a ser pago deve ser maior que zero!");
                return;
            }
            // TODO: Fazer validações

            var listaFormaPagamento = FormaPagamentoController.GerarListaFormaPagamento(
                txtQuantidadeParcelas.Texto.IntOuZero(),
                cbFormaPagamento.PegarEnumPorDescricao<TipoPagamentoEnum>(),
                txtValorASerPago.Texto.DoubleOuZero());

            EventAdicionarPagamento?.Invoke(listaFormaPagamento);
        }

        private void CbFormaPagamento_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbFormaPagamento.EstaSelecionado()) return;

            var tipoPagamento = cbFormaPagamento.PegarEnumPorDescricao<TipoPagamentoEnum>();

            if (tipoPagamento == TipoPagamentoEnum.Dinheiro)
            {
                txtQuantidadeParcelas.ReadOnly = true;
                txtQuantidadeParcelas.Texto = "0";
            }
            else if (tipoPagamento == TipoPagamentoEnum.Debito)
            {
                txtQuantidadeParcelas.ReadOnly = true;
                txtQuantidadeParcelas.Texto = "1";
            }
            else
            {
                txtQuantidadeParcelas.ReadOnly = false;
                txtQuantidadeParcelas.Texto = "1";
            }

        }
    }
}
