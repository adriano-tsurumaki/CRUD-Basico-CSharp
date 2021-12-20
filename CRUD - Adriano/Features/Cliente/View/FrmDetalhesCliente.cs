using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Utils;
using System;
using System.Text;
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
            var idade = DateTime.Now.Year - _clienteModel.DataNascimento.Year;

            lblNome.Text = _clienteModel.Nome;
            lblSobrenome.Text = _clienteModel.Sobrenome;
            lblIdade.Text = $"{idade} {(idade > 0 ? "anos" : "ano")}";
            lblSexo.Text = _clienteModel.Sexo.RetornarDescricao();
            lblCpf.Text = _clienteModel.Cpf.Formatado;
            lblCidade.Text = _clienteModel.Endereco.Cidade;
            lblEstado.Text = _clienteModel.Endereco.Uf.RetornarDescricao();
            lblLogradouro.Text = _clienteModel.Endereco.Logradouro;
            lblBairro.Text = _clienteModel.Endereco.Bairro;
            lblNumero.Text = _clienteModel.Endereco.Numero;
            lblValorLimite.Text = _clienteModel.ValorLimite.Formatado;
            lblObservacao.Text = _clienteModel.Observacao;
            lblDataNascimento.Text = $"{_clienteModel.DataNascimento:dd/MM/yyyy}";
            lblEmails.Text = RetornarEmailsFormatado();
            lblTelefones.Text = RetornarTelefonesFormatado();
        }

        private void BtnFechar_Click(object sender, System.EventArgs e) =>
            Close();

        private string RetornarEmailsFormatado()
        {
            var textoFormatado = new StringBuilder();

            foreach (var email in _clienteModel.Emails)
                textoFormatado.AppendLine(email.Nome);

            return textoFormatado.ToString();
        }

        private string RetornarTelefonesFormatado()
        {
            var textoFormatado = new StringBuilder();

            foreach (var telefone in _clienteModel.Telefones)
                textoFormatado.AppendLine(telefone.Numero);

            return textoFormatado.ToString();
        }
    }
}
