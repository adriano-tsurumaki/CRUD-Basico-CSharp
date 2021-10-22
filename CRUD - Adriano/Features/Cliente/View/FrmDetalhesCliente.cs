using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Utils;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cliente.View
{
    public partial class FrmDetalhesCliente : Form
    {
        private readonly ClienteModel _clienteModel;

        public FrmDetalhesCliente(ClienteModel clienteModel)
        {
            InitializeComponent();
            _clienteModel = clienteModel;
            AtribuirModelParaCampo();
        }

        private void AtribuirModelParaCampo()
        {
            lblNome.Text = _clienteModel.Nome;
            lblSobrenome.Text = _clienteModel.Sobrenome;
            lblSexo.Text = _clienteModel.Sexo.RetornarDescricao();
            lblCpf.Text = _clienteModel.Cpf;
            lblCidade.Text = _clienteModel.Endereco.Cidade;
            lblEstado.Text = _clienteModel.Endereco.Uf.RetornarDescricao();
            lblLogradouro.Text = _clienteModel.Endereco.Logradouro;
            lblBairro.Text = _clienteModel.Endereco.Bairro;
            lblNumero.Text = _clienteModel.Endereco.Numero;
            lblValorLimite.Text = $"{_clienteModel.ValorLimite:c2}";
            lblObservacao.Text = _clienteModel.Observacao;
            lblDataNascimento.Text = $"{_clienteModel.DataNascimento:dd/mm/YY}";
        }

        private void BtnFechar_Click(object sender, EventArgs e) =>
            Close();
    }
}
