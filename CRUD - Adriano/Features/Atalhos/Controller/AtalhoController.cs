using CRUD___Adriano.Features.Cliente.Controller;
using CRUD___Adriano.Features.Cliente.View;
using CRUD___Adriano.Features.Colaborador.Controller;
using CRUD___Adriano.Features.Configuration;
using CRUD___Adriano.Features.Fornecedor.Controller;
using CRUD___Adriano.Features.Produto.Controller;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Atalhos.Controller
{
    public class AtalhoController
    {
        private readonly ClienteController _clienteController;
        private readonly ColaboradorController _colaboradorController;
        private readonly FornecedorController _fornecedorController;
        private readonly ProdutoController _produtoController;

        public AtalhoController(ClienteController clienteController, ColaboradorController colaboradorController, FornecedorController fornecedorController, ProdutoController produtoController)
        {
            _clienteController = clienteController;
            _colaboradorController = colaboradorController;
            _fornecedorController = fornecedorController;
            _produtoController = produtoController;
        }

        public Form RetornarFormulario() => new FrmAtalhos(this);

        public void CadastrarListaDeClientes(int quantidade)
        {
            if(_clienteController.SalvarLista(RandomEntity.RetornarListaDeClientes(quantidade)))
                MessageBox.Show("Cadastrado com sucesso");
        }

        public void CadastrarListaDeColaboradores(int quantidade)
        {
            if(_colaboradorController.SalvarLista(RandomEntity.RetornarListaDeColaboradores(quantidade)))
                MessageBox.Show("Cadastrado com sucesso");
        }

        public void CadastrarListaDeFornecedores(int quantidade)
        {
            if (_fornecedorController.SalvarLista(RandomEntity.RetornarListaDeFornecedores(quantidade)))
                MessageBox.Show("Cadastrado com sucesso");
        }

        public void CadastrarListaDeProdutos(int quantidade)
        {
            try
            {
                if (_produtoController.SalvarLista(RandomEntity.RetornarListaDeProdutos(quantidade)))
                    MessageBox.Show("Cadastro com sucesso");
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao gerar a lista de produtos aleatoriamente!");
            }
        }
    }
}
