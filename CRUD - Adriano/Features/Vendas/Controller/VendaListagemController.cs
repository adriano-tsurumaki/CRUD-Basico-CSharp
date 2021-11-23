using CRUD___Adriano.Features.Vendas.Dao;
using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class VendaListagemController
    {
        private readonly VendaDao _vendaDao;
        private readonly FrmListagemVenda _frmListagemVenda;
        private BindingList<VendaModel> _vendaModelBindings;

        public VendaListagemController(VendaDao vendaDao)
        {
            _vendaDao = vendaDao;
            _frmListagemVenda = new FrmListagemVenda(this);
            _vendaModelBindings = new BindingList<VendaModel>();
            _frmListagemVenda.BindModel(_vendaModelBindings);
        }

        public FrmListagemVenda RetornarFormulario() => _frmListagemVenda;

        public void ListarTodos()
        {
            try
            {
                _vendaModelBindings.Clear();
                foreach (var venda in _vendaDao.ListarTodosParaListagem())
                    _vendaModelBindings.Add(venda);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar todas as vendas");
            }
        }
    }
}
