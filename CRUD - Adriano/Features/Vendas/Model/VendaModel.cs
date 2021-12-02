using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Colaborador.Model;
using CRUD___Adriano.Features.ValueObject.Precos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUD___Adriano.Features.Vendas.Model
{
    public class VendaModel
    {
        public int Id { get; set; }
        public ColaboradorModel Colaborador { get; private set; }
        public ClienteModel Cliente { get; private set; }
        public DateTime DataEmissao { get; set; }
        public IList<VendaProdutoModel> ListaDeProdutos { get; }
        public IList<FormaPagamentoModel> ListaPagamentos { get; }

        public Preco DescontoTotal { get => ListaDeProdutos.Sum(x => x.Desconto.Valor); }
        public Preco ValorBrutoTotal { get => ListaDeProdutos.Sum(x => x.PrecoBruto.Valor); }
        public Preco ValorLiquidoTotal { get => ListaDeProdutos.Sum(x => x.PrecoLiquido.Valor); }
        public Preco ValorPago { get => ListaPagamentos.Sum(x => x.ValorAPagar.Valor); }

        public void DefinirColaborador(ColaboradorModel colaboradorModel) => Colaborador = colaboradorModel;
        public void DefinirIdColaborador(int idColaborador) => Colaborador.IdUsuario = idColaborador;

        public void DefinirCliente(ClienteModel clienteModel) => Cliente = clienteModel;
        public void DefinirIdCliente(int idCliente) => Cliente.IdUsuario = idCliente;
        public void DefinirNomeCliente(string nome) => Cliente.Nome = nome;


        public VendaModel()
        {
            ListaDeProdutos = new List<VendaProdutoModel>();
            ListaPagamentos = new List<FormaPagamentoModel>();
            Cliente = new ClienteModel();
            Colaborador = new ColaboradorModel();
        }
    }
}
