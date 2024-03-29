﻿using CRUD___Adriano.Features.Cliente.Dao;
using CRUD___Adriano.Features.Email.Controller;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.Usuario.Model;
using CRUD___Adriano.Features.Vendas.Dao;
using CRUD___Adriano.Features.Vendas.Enum;
using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class VendaPrincipalController
    {
        private readonly VendaDao _vendaDao;
        
        private readonly FrmVendaPrincipal _frmVendaPrincipal;
        private VendaHeaderController _controllerVendaHeader;
        private PesquisarProdutoController _controllerPesquisarProduto;
        private CarrinhoVendaController _controllerCarrinhoVenda;
        private DescontoVendaController _controllerDescontoVenda;
        private VendaFooterController _controllerVendaFooter;
        private FormaPagamentoController _controllerFormaPagamento;
        private ListaPagamentoController _controllerListaPagamento;
        private ControllerEnum _tipoCrud;

        private VendaModel _vendaModel;

        public VendaPrincipalController(VendaDao vendaDao)
        {
            _vendaDao = vendaDao;

            _frmVendaPrincipal = new FrmVendaPrincipal(this);
        }

        public void Start()
        {
            _vendaModel = new VendaModel();
            InicializarConfiguracoes();
            _tipoCrud = ControllerEnum.Salvar;
            _frmVendaPrincipal.ShowDialog();
        }

        public void Start(VendaModel vendaModel)
        {
            _vendaModel = vendaModel;
            InicializarConfiguracoes();
            _controllerVendaHeader.DefinirLabelCliente(vendaModel.Cliente.Nome);
            _controllerVendaHeader.DefinirLabelColaborador(vendaModel.Colaborador.Nome);
            _tipoCrud = ControllerEnum.Atualizar;
            _frmVendaPrincipal.ShowDialog();
        }

        public void InicializarConfiguracoes()
        {
            InstanciarControllers();

            AdicionarControl(_frmVendaPrincipal.pnlHeader, _controllerVendaHeader.RetornarUserControl());
            AdicionarControl(_frmVendaPrincipal.pnlLeftCentral, _controllerPesquisarProduto.RetornarUserControl());
            AdicionarControl(_frmVendaPrincipal.pnlRightCentral, _controllerCarrinhoVenda.RetornarUserControl());
            AdicionarControl(_frmVendaPrincipal.pnlFooter, _controllerVendaFooter.RetornarUserControl());

            DefinirEventosDosUserControls();
        }

        private void InstanciarControllers()
        {
            _controllerPesquisarProduto = ConfigNinject.ObterInstancia<PesquisarProdutoController>();
            
            _controllerCarrinhoVenda = ConfigNinject.ObterInstancia<CarrinhoVendaController>();
            _controllerCarrinhoVenda.AdicionarModel(_vendaModel.ListaDeProdutos);

            _controllerVendaHeader = ConfigNinject.ObterInstancia<VendaHeaderController>();
            _controllerDescontoVenda = ConfigNinject.ObterInstancia<DescontoVendaController>();
            _controllerVendaFooter = ConfigNinject.ObterInstancia<VendaFooterController>();
            
            _controllerFormaPagamento = ConfigNinject.ObterInstancia<FormaPagamentoController>();
            _controllerFormaPagamento.AdicionarModel(_vendaModel);

            _controllerListaPagamento = ConfigNinject.ObterInstancia<ListaPagamentoController>();
            _controllerListaPagamento.AdicionarModel(_vendaModel.ListaPagamentos);
        }

        private void DefinirEventosDosUserControls()
        {
            _controllerVendaHeader.RetornarUserControl().EventDefinirIdCliente += EventDefinirCliente;
            _controllerVendaHeader.RetornarUserControl().EventDefinirIdColaborador += EventDefinirColaborador;

            _controllerPesquisarProduto.RetornarUserControl().EventEnviarProduto += EventEnviarProduto;
            _controllerCarrinhoVenda.RetornarUserControl().EventHabilitarUcDesconto += EventHabilitarUcDesconto;
            _controllerDescontoVenda.RetornarUserControl().EventDesabilitar += EventDesabilitarUcDesconto;

            _controllerDescontoVenda.RetornarUserControl().EventPegarDesconto += EventPegarDesconto;
            _controllerVendaFooter.EventCancelar += EventCancelar;
            _controllerVendaFooter.EventVoltar += EventVoltar;
            _controllerVendaFooter.EventAvancar += EventAvancar;
            _controllerVendaFooter.EventConfirmar += EventConfirmar;

            _controllerFormaPagamento.RetornarUserControl().EventAdicionarPagamento += EventAdicionarPagamento;

            _controllerListaPagamento.RetornarUserControl().EventAtualizarFormaPagamento += EventAtualizarFormaPagamento;
        }

        private void EventDefinirCliente(UsuarioModel clienteModelSelecionado)
        {
            _vendaModel.DefinirIdCliente(clienteModelSelecionado.IdUsuario);
            _vendaModel.DefinirNomeCliente(clienteModelSelecionado.Nome);

            if (VerificarSeClienteFazAniversario())
                MessageBox.Show($"{clienteModelSelecionado.Nome} faz aniversário hoje!", "Parabéns!!!!!");
        }


        private bool VerificarSeClienteFazAniversario()
        {
            var dataNascimento = SelecionarDataDeNascimento();

            return dataNascimento.Month == DateTime.Now.Month && dataNascimento.Day == DateTime.Now.Day;
        }

        private DateTime SelecionarDataDeNascimento()
        {
            try
            {
                return ConfigNinject.ObterInstancia<ClienteDao>().SelecionarDataDeNascimento(_vendaModel.Cliente.IdUsuario);
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Houve um erro ao verificar a data de nascimento do cliente!");
            }

            return DateTime.MinValue;
        }

        private void EventDefinirColaborador(UsuarioModel colaboradorModelSelecionado) =>
            _vendaModel.DefinirIdColaborador(colaboradorModelSelecionado.IdUsuario);

        private void EventEnviarProduto(VendaProdutoModel vendaProdutoSelecionado)
        {
            if (_controllerDescontoVenda.FoiAplicadoDescontoGeral() && MessageBox.Show("Já foi aplicado um desconto geral no pedido, deseja cancelar este desconto?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AplicarDescontoGeral(0, _controllerCarrinhoVenda.RetornarListasDeProdutosParaDesconto());
                _controllerDescontoVenda.DefinirQueNaoFoiAplicadoODescontoGeral();
            }

            _controllerCarrinhoVenda.AdicionarProdutoNoCarrinho(vendaProdutoSelecionado);
        }

        private void EventHabilitarUcDesconto() =>
            AdicionarControl(_frmVendaPrincipal.pnlLeftCentral, _controllerDescontoVenda.RetornarUserControl());

        private void EventDesabilitarUcDesconto() =>
            AdicionarControl(_frmVendaPrincipal.pnlLeftCentral, _controllerPesquisarProduto.RetornarUserControl());

        private void EventPegarDesconto(TipoDescontoEnum tipoDesconto, double porcentagem)
        {
            if (tipoDesconto == TipoDescontoEnum.Geral)
            {
                AplicarDescontoGeral(porcentagem, _controllerCarrinhoVenda.RetornarListasDeProdutosParaDesconto());
                _controllerCarrinhoVenda.AtualizarCarrinho();
                return;
            }

            if (_controllerDescontoVenda.FoiAplicadoDescontoGeral() && MessageBox.Show("Já foi aplicado um desconto geral no pedido, deseja cancelar este desconto?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AplicarDescontoGeral(0, _controllerCarrinhoVenda.RetornarListasDeProdutosParaDesconto());
                AplicarDescontoUnitario(porcentagem, _controllerCarrinhoVenda.RetornarVendaProdutoSelecionadoParaDesconto());
                _controllerDescontoVenda.DefinirQueNaoFoiAplicadoODescontoGeral();
                _controllerCarrinhoVenda.AtualizarCarrinho();
                return;
            }
            
            AplicarDescontoUnitario(porcentagem, _controllerCarrinhoVenda.RetornarVendaProdutoSelecionadoParaDesconto());
            _controllerCarrinhoVenda.AtualizarCarrinho();
        }

        public static void AplicarDescontoGeral(double porcentagem, IList<VendaProdutoModel> listaDeProdutos)
        {
            foreach (var item in listaDeProdutos)
                item.Desconto = item.PrecoVenda * porcentagem;
        }

        public static void AplicarDescontoUnitario(double porcentagem, VendaProdutoModel produtoSelecionado) =>
            produtoSelecionado.Desconto = produtoSelecionado.PrecoVenda * porcentagem;

        private void EventAdicionarPagamento(IList<FormaPagamentoModel> listaFormaPagamentos)
        {
            var valorPago = listaFormaPagamentos.Sum(x => x.ValorAPagar.Valor) + _vendaModel.ValorPago;

            if (valorPago > _vendaModel.ValorLiquidoTotal)
            {
                MessageBox.Show("Valor inserido é maior que o valor restante a ser pago!");
                return;
            }

            int ordemPagamento;

            if (_vendaModel.ListaPagamentos.Count == 0)
                ordemPagamento = 1;
            else
                ordemPagamento = _vendaModel.ListaPagamentos.Last().OrdemPagamento + 1;

            foreach (var item in listaFormaPagamentos)
                item.OrdemPagamento = ordemPagamento;

            _controllerListaPagamento.AdicionarPagamentosNaLista(listaFormaPagamentos);
            _controllerFormaPagamento.AtualizarValoresTotais(_vendaModel);
        }

        private void EventAtualizarFormaPagamento() =>
            _controllerFormaPagamento.AtualizarValoresTotais(_vendaModel);

        private void EventCancelar() =>
            CancelarVenda();

        private void EventVoltar()
        {
            _controllerVendaFooter.AtualizarRodape(1);

            AdicionarControl(_frmVendaPrincipal.pnlLeftCentral, _controllerPesquisarProduto.RetornarUserControl());
            AdicionarControl(_frmVendaPrincipal.pnlRightCentral, _controllerCarrinhoVenda.RetornarUserControl());
        }

        private void EventAvancar()
        {
            if (!PossuiItensNoCarrinho())
            {
                MessageBox.Show("Não é possível prosseguir quando não possui itens no carrinho!");
                return;
            }

            _controllerVendaFooter.AtualizarRodape(2);
            AdicionarControl(_frmVendaPrincipal.pnlLeftCentral, _controllerFormaPagamento.RetornarUserControl());
            AdicionarControl(_frmVendaPrincipal.pnlRightCentral, _controllerListaPagamento.RetornarUserControl());
            _controllerFormaPagamento.AtualizarValoresTotais(_vendaModel);
        }

        private bool PossuiItensNoCarrinho() =>
            _controllerCarrinhoVenda.PossuiItensNoCarrinho();

        private void EventConfirmar()
        {
            if (!ValidarModel() || !VerificarSeClientePodePagarOValorAPrazo()) return;
            
            switch (_tipoCrud)
            {
                case ControllerEnum.Salvar:
                    EfetuarVenda();
                    break;
                case ControllerEnum.Atualizar:
                    AtualizarVenda();
                    break;
            }
        }

        private bool ValidarModel()
        {
            if (_vendaModel.Cliente.IdUsuario == 0)
            {
                MessageBox.Show("Selecione um cliente!", "Aviso");
                return false;
            }
            if (_vendaModel.Colaborador.IdUsuario == 0)
            {
                MessageBox.Show("Selecione um funcionário!", "Aviso");
                return false;
            }
            if (_vendaModel.ListaPagamentos.Count == 0 || _vendaModel.ValorPago < _vendaModel.ValorLiquidoTotal)
            {
                MessageBox.Show("Efetue o pagamento total!", "Aviso");
                return false;
            }
            if (_vendaModel.ValorPago > _vendaModel.ValorLiquidoTotal)
            {
                MessageBox.Show("Valor pago é maior que o valor total da venda!", "Aviso");
                return false;
            }

            return true;
        }

        private bool VerificarSeClientePodePagarOValorAPrazo()
        {
            if (!_vendaModel.ListaPagamentos.Any(x => x.TipoPagamento == TipoPagamentoEnum.Credito || x.TipoPagamento == TipoPagamentoEnum.Cheque)) return true;

            try
            {
                double valorLimite = ConfigNinject.ObterInstancia<ClienteDao>().RetornarValorLimiteRestante(_vendaModel.Cliente.IdUsuario);

                var valorTotalAPrazo = _vendaModel.ListaPagamentos
                    .Where(x => x.TipoPagamento == TipoPagamentoEnum.Credito || x.TipoPagamento == TipoPagamentoEnum.Cheque)
                    .Sum(x => x.ValorAPagar.Valor);

                if (valorTotalAPrazo > valorLimite)
                {
                    MessageBox.Show("O Valor a prazo a ser pago é maior que o valor limite do cliente", "Aviso");
                    MessageBox.Show($"Valor limite restante: {valorLimite:c}", "Aviso");
                    return false;
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao tentar buscar o limite de crédito do cliente!");
                return false;
            }

            return true;
        }

        private void EfetuarVenda()
        {
            if (MessageBox.Show("Deseja efetuar a venda?", "Confirmação", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                _vendaDao.EfetuarVenda(_vendaModel);

                if (MessageBox.Show("Deseja enviar o comprovante por e-mail?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    EmailSenderController.EnviarConfirmacaoDaCompra(
                        _vendaModel.Cliente.Nome, 
                        _vendaModel.ValorPago,
                        ConfigNinject.ObterInstancia<ClienteDao>().SelecionarEmail(_vendaModel.Cliente.IdUsuario));

                MessageBox.Show("Venda efetuada com sucesso!");
                _frmVendaPrincipal.Close();
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao efetuar a venda!");
            }
        }

        private void AtualizarVenda()
        {
            if (MessageBox.Show("Deseja atualizar a venda?", "Confirmação", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                _vendaDao.AtualizarVenda(_vendaModel);
                MessageBox.Show("Venda atualizada com sucesso!");
                _frmVendaPrincipal.Close();
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao atualizar a venda!");
            }
        }

        public void AdicionarControl(Panel panel, UserControl formFilha)
        {
            panel.Controls.Add(formFilha);
            panel.Tag = formFilha;

            formFilha.Dock = DockStyle.Fill;
            formFilha.BringToFront();
            formFilha.Show();
        }

        public void GerenciarKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    CancelarVenda();
                    break;
            }
        }

        private void CancelarVenda()
        {
            if (MessageBox.Show("Deseja cancelar a venda?", "Confirmação", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            _frmVendaPrincipal.Close();
        }
    }
}
