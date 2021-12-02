using CRUD___Adriano.Features.Colaborador.Model;
using CRUD___Adriano.Features.Utils;
using System;
using System.Text;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Colaborador.View
{
    public partial class FrmDetalhesColaborador : Form
    {
        private readonly ColaboradorModel _colaboradorModel;

        public FrmDetalhesColaborador(ColaboradorModel colaboradorModel)
        {
            InitializeComponent();
            _colaboradorModel = colaboradorModel;
            AtribuirModelParaCampo();
        }

        private void AtribuirModelParaCampo()
        {
            var idade = DateTime.Now.Year - _colaboradorModel.DataNascimento.Year;

            lblNome.Text = _colaboradorModel.Nome;
            lblSobrenome.Text = _colaboradorModel.Sobrenome;
            lblIdade.Text = $"{idade} {(idade > 0 ? "anos" : "ano")}";
            lblSexo.Text = _colaboradorModel.Sexo.RetornarDescricao();
            lblCpf.Text = _colaboradorModel.Cpf.Formatado;
            lblCidade.Text = _colaboradorModel.Endereco.Cidade;
            lblEstado.Text = _colaboradorModel.Endereco.Uf.RetornarDescricao();
            lblLogradouro.Text = _colaboradorModel.Endereco.Logradouro;
            lblBairro.Text = _colaboradorModel.Endereco.Bairro;
            lblNumero.Text = _colaboradorModel.Endereco.Numero;
            lblSalario.Text = $"R$ {_colaboradorModel.Salario.Formatado}";
            lblComissao.Text = $"{_colaboradorModel.Comissao * 100}%";
            lblDataNascimento.Text = $"{_colaboradorModel.DataNascimento:dd/mm/yyyy}";
            lblEmails.Text = RetornarEmailsFormatado();
            lblTelefones.Text = RetornarTelefonesFormatado();
            lblAgencia.Text = _colaboradorModel.DadosBancarios.Agencia.ToString();
            lblConta.Text = _colaboradorModel.DadosBancarios.Conta.ToString();
            lblTipoConta.Text = _colaboradorModel.DadosBancarios.TipoConta.RetornarDescricao();
            lblBanco.Text = _colaboradorModel.DadosBancarios.Banco;
        }

        private string RetornarEmailsFormatado()
        {
            var textoFormatado = new StringBuilder();

            foreach (var email in _colaboradorModel.Emails)
                textoFormatado.AppendLine(email.Nome);

            return textoFormatado.ToString();
        }

        private string RetornarTelefonesFormatado()
        {
            var textoFormatado = new StringBuilder();

            foreach (var telefone in _colaboradorModel.Telefones)
                textoFormatado.AppendLine(telefone.Numero);

            return textoFormatado.ToString();
        }

        private void BtnFechar_Click(object sender, System.EventArgs e) =>
            Close();
    }
}
