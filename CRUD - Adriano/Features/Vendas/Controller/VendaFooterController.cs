using CRUD___Adriano.Features.PageManager.View;
using CRUD___Adriano.Features.Vendas.View;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class VendaFooterController
    {
        public delegate void AvancarHandler();
        public delegate void VoltarHandler();
        public event AvancarHandler EventAvancar;
        public event VoltarHandler EventVoltar;

        private readonly UcVendaFooter _ucVendaFoooter;

        private UcPreviousButton _ucBotaoAnterior;
        private UcNextButton _ucBotaoProximo;
        private UcConfirmButton _ucBotaoConfirmar;
        private UcCancelButton _ucBotaoCancelar;

        public VendaFooterController()
        {
            _ucVendaFoooter = new UcVendaFooter(this);
            AtribuirEventos();
            AdicionarControl(_ucVendaFoooter.pnlBottomRight, _ucBotaoProximo);
            AdicionarControl(_ucVendaFoooter.pnlBottomLeft, _ucBotaoCancelar);
        }

        private void AtribuirEventos()
        {
            _ucBotaoAnterior = new UcPreviousButton();
            _ucBotaoAnterior.btnPrevious.Click += BtnAnterior_Click;

            _ucBotaoProximo = new UcNextButton();
            _ucBotaoProximo.btnNext.Click += BtnProximo_Click;

            _ucBotaoConfirmar = new UcConfirmButton();
            _ucBotaoConfirmar.btnConfirm.Click += BtnConfirmar_Click;

            _ucBotaoCancelar = new UcCancelButton();
            _ucBotaoCancelar.btnCancel.Click += BtnCancelar_Click;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            EventAvancar?.Invoke();
            AtualizarRodape(2);
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            EventVoltar?.Invoke();
            AtualizarRodape(1);
        }

        public void AtualizarRodape(int indice)
        {
            _ucVendaFoooter.pnlBottomLeft.Controls.Clear();
            _ucVendaFoooter.pnlBottomRight.Controls.Clear();

            if (indice == 1)
            {
                AdicionarControl(_ucVendaFoooter.pnlBottomRight, _ucBotaoProximo);
                AdicionarControl(_ucVendaFoooter.pnlBottomLeft, _ucBotaoCancelar);
            }
            else
            {
                AdicionarControl(_ucVendaFoooter.pnlBottomLeft, _ucBotaoAnterior);
                AdicionarControl(_ucVendaFoooter.pnlBottomRight, _ucBotaoConfirmar);
            }

        }

        public UcVendaFooter RetornarUserControl() => _ucVendaFoooter;

        public void AdicionarControl(Panel panel, UserControl formFilha)
        {
            panel.Controls.Add(formFilha);
            panel.Tag = formFilha;

            formFilha.Dock = DockStyle.Fill;
            formFilha.BringToFront();
            formFilha.Show();
        }
    }
}
