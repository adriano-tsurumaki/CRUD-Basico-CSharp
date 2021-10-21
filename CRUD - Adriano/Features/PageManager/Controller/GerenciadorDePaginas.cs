﻿using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.PageManager.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Controller.PageManager
{
    public class GerenciadorDePaginas<T> where T : class
    {
        private UcCentral _ucCentral;
        private UcBody _ucBody;
        private UcFooter _ucFooter;

        private UcPreviousButton _ucBotaoAnterior;
        private UcNextButton _ucBotaoProximo;
        private UcConfirmButton _ucBotaoConfirmar;
        private UcCancelButton _ucBotaoCancelar;

        private Panel _panelCentral;

        private Dictionary<int, Form> _paginas;
        private int _totalDePaginas = 1;
        private int _indiceAtualPagina = 1;

        private IControllerBase<T> _controller;
        private T _model;

        public GerenciadorDePaginas(Panel panelCentral, IControllerBase<T> controller, T model)
        {
            _panelCentral = panelCentral;
            _paginas = new Dictionary<int, Form>();
            _controller = controller;
            _model = model;
            InstanciarUsersControls();
            AtribuirEventos();
            ConstruirLayoutInicial();
        }

        public void InstanciarUsersControls()
        {
            _ucCentral = new UcCentral();
            _ucBody = new UcBody();
            _ucFooter = new UcFooter();
        }

        private void AtribuirEventos()
        {
            _ucBotaoAnterior = new UcPreviousButton();
            _ucBotaoAnterior.btnPrevious.Click += new EventHandler(BtnAnterior_Click);

            _ucBotaoProximo = new UcNextButton();
            _ucBotaoProximo.btnNext.Click += new EventHandler(BtnProximo_Click);

            _ucBotaoConfirmar = new UcConfirmButton();
            _ucBotaoConfirmar.btnConfirm.Click += new EventHandler(BtnConfirmar_Click);

            _ucBotaoCancelar = new UcCancelButton();
            _ucBotaoCancelar.btnCancel.Click += new EventHandler(BtnCancelar_Click);
        }

        private void BtnAnterior_Click(object sender, System.EventArgs e)
        {
            _indiceAtualPagina--;
            AtualizarRodape();
            AtualizarPagina();
        }

        private void BtnProximo_Click(object sender, System.EventArgs e)
        {
            _indiceAtualPagina++;
            AtualizarRodape();
            AtualizarPagina();
        }

        private void AtualizarRodape()
        {
            _ucFooter.pnlBottomLeft.Controls.Clear();
            _ucFooter.pnlBottomRight.Controls.Clear();

            if (_indiceAtualPagina > 1 && _indiceAtualPagina < _totalDePaginas)
            {
                AdicionarControl(_ucFooter.pnlBottomLeft, _ucBotaoAnterior);
                AdicionarControl(_ucFooter.pnlBottomRight, _ucBotaoProximo);
            }
            else if (_indiceAtualPagina == 1)
            {
                AdicionarControl(_ucFooter.pnlBottomLeft, _ucBotaoProximo);
                AdicionarControl(_ucFooter.pnlBottomRight, _ucBotaoCancelar);
            }
            else if (_indiceAtualPagina == _totalDePaginas)
            {
                AdicionarControl(_ucFooter.pnlBottomLeft, _ucBotaoAnterior);
                AdicionarControl(_ucFooter.pnlBottomRight, _ucBotaoConfirmar);
            }
        }

        private void AtualizarPagina()
        {
            _paginas.TryGetValue(_indiceAtualPagina, out var page);

            AtualizarControlPagina(page);
        }

        private void BtnConfirmar_Click(object sender, System.EventArgs e)
        {
            _controller.Salvar(_model);
        }

        private void BtnCancelar_Click(object sender, System.EventArgs e) =>
            _ucCentral.Dispose();

        public void ConstruirLayoutInicial()
        {
            _ucCentral.Dock = DockStyle.Fill;
            _ucBody.Dock = DockStyle.Fill;
            _ucFooter.Dock = DockStyle.Fill;

            AdicionarControl(_ucCentral.pnlBody, _ucBody);
            AdicionarControl(_ucCentral.pnlBottom, _ucFooter);

            AdicionarControl(_ucFooter.pnlBottomLeft, _ucBotaoProximo);
            AdicionarControl(_ucFooter.pnlBottomRight, _ucBotaoCancelar);
        }

        public void AdicionarControl(Panel panel, UserControl formFilha)
        {
            panel.Controls.Add(formFilha);
            panel.Tag = formFilha;

            formFilha.BringToFront();
            formFilha.Show();
        }

        public void AdicionarControl(Panel panel, Form formFilha)
        {
            formFilha.TopLevel = false;
            formFilha.FormBorderStyle = FormBorderStyle.None;
            formFilha.Dock = DockStyle.Fill;
            panel.Controls.Add(formFilha);
            panel.Tag = formFilha;

            formFilha.BringToFront();
            formFilha.Show();
        }

        public void AtualizarControlPagina(Form formFilha)
        {
            _ucBody.pnlBody.Controls.Clear();

            formFilha.TopLevel = false;
            formFilha.FormBorderStyle = FormBorderStyle.None;
            formFilha.Dock = DockStyle.Fill;
            
            _ucBody.pnlBody.Controls.Add(formFilha);
            _ucBody.pnlBody.Tag = formFilha;

            formFilha.BringToFront();
            formFilha.Show();
        }

        public void Show()
        {
            AtualizarControlPagina(_paginas.First().Value);
            AdicionarControl(_panelCentral, _ucCentral);
            _totalDePaginas--;
        }

        public void PageInit(Form formFilha) => AdicionarControl(_ucBody.pnlBody, formFilha);

        public void Add(FormBase<T> formFilha)
        {
            formFilha.AdicionarModel(_model);
            _paginas.Add(_totalDePaginas, formFilha);
            _totalDePaginas++;
        }
    }
}
