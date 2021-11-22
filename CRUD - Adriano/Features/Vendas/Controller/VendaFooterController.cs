using CRUD___Adriano.Features.PageManager.View;
using CRUD___Adriano.Features.Vendas.View;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class VendaFooterController
    {
        public delegate void ButtonHandler();
        public event ButtonHandler EventCancelar;
        public event ButtonHandler EventVoltar;
        public event ButtonHandler EventAvancar;
        public event ButtonHandler EventConfirmar;

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

        private void BtnCancelar_Click(object sender, EventArgs e) =>
            EventCancelar?.Invoke();

        private void BtnAnterior_Click(object sender, EventArgs e) =>
            EventVoltar?.Invoke();

        private void BtnProximo_Click(object sender, EventArgs e) =>
            EventAvancar?.Invoke();

        private void BtnConfirmar_Click(object sender, EventArgs e) =>
            EventConfirmar?.Invoke();

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
