using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.PageManager.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Controller.PageManager
{
    public class PageManager
    {
        private UcCentral _ucCentral;
        private UcBody _ucBody;
        private UcFooter _ucFooter;

        private UcPreviousButton _ucPreviousButton;
        private UcNextButton _ucNextButton;
        private UcConfirmButton _ucConfirmButton;
        private UcCancelButton _ucCancelButton;

        private Panel _panelCentral;

        private Dictionary<int, Form> _pages;
        private int _totalPages = 1;
        private int _currentPage = 1;

        private IControllerFactory _controller;
        private ModelBase _model;

        public PageManager(Panel panelCentral, IControllerFactory controller, ModelBase model)
        {
            _panelCentral = panelCentral;
            _pages = new Dictionary<int, Form>();
            _controller = controller;
            InstanciarUsersControls();
            ConstruirLayoutInicial();
        }

        public void InstanciarUsersControls()
        {
            _ucCentral = new UcCentral();
            _ucBody = new UcBody();
            _ucFooter = new UcFooter();

            _ucPreviousButton = new UcPreviousButton();
            _ucPreviousButton.btnPrevious.Click += new EventHandler(BtnPrevious_Click);

            _ucNextButton = new UcNextButton();
            _ucNextButton.btnNext.Click += new EventHandler(BtnNext_Click);

            _ucConfirmButton = new UcConfirmButton();
            _ucConfirmButton.btnConfirm.Click += new EventHandler(BtnConfirm_Click);

            _ucCancelButton = new UcCancelButton();
            _ucCancelButton.btnCancel.Click += new EventHandler(BtnCancel_Click);
        }

        private void BtnPrevious_Click(object sender, System.EventArgs e)
        {
            _currentPage--;
            UpdateFooter();
            UpdatePage();
        }

        private void BtnNext_Click(object sender, System.EventArgs e)
        {
            _currentPage++;
            UpdateFooter();
            UpdatePage();
        }

        private void UpdateFooter()
        {
            _ucFooter.pnlBottomLeft.Controls.Clear();
            _ucFooter.pnlBottomRight.Controls.Clear();

            if (_currentPage > 1 && _currentPage < _totalPages)
            {
                AdicionarControl(_ucFooter.pnlBottomLeft, _ucPreviousButton);
                AdicionarControl(_ucFooter.pnlBottomRight, _ucNextButton);
            }
            else if (_currentPage == 1)
            {
                AdicionarControl(_ucFooter.pnlBottomLeft, _ucNextButton);
                AdicionarControl(_ucFooter.pnlBottomRight, _ucCancelButton);
            }
            else if (_currentPage == _totalPages)
            {
                AdicionarControl(_ucFooter.pnlBottomLeft, _ucPreviousButton);
                AdicionarControl(_ucFooter.pnlBottomRight, _ucConfirmButton);
            }
        }

        private void UpdatePage()
        {
            _pages.TryGetValue(_currentPage, out var page);

            UpdatePageControl(page);
        }

        private void BtnConfirm_Click(object sender, System.EventArgs e)
        {
            _controller.Salvar(_model);
        }

        private void BtnCancel_Click(object sender, System.EventArgs e) =>
            _ucCentral.Dispose();

        public void ConstruirLayoutInicial()
        {
            _ucCentral.Dock = DockStyle.Fill;
            _ucBody.Dock = DockStyle.Fill;
            _ucFooter.Dock = DockStyle.Fill;

            AdicionarControl(_ucCentral.pnlBody, _ucBody);
            AdicionarControl(_ucCentral.pnlBottom, _ucFooter);

            AdicionarControl(_ucFooter.pnlBottomLeft, _ucNextButton);
            AdicionarControl(_ucFooter.pnlBottomRight, _ucCancelButton);
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

        public void UpdatePageControl(Form formFilha)
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
            UpdatePageControl(_pages.First().Value);
            AdicionarControl(_panelCentral, _ucCentral);
            _totalPages--;
        }

        public void PageInit(Form formFilha) => AdicionarControl(_ucBody.pnlBody, formFilha);

        public void Add(Form formFilha)
        {
            _pages.Add(_totalPages, formFilha);
            _totalPages++;
        }
    }
}
