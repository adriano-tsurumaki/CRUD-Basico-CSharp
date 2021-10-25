using CRUD___Adriano.Features.Cliente.Model;
using CRUD___Adriano.Features.Utils;
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
            lblNome.Text = _colaboradorModel.Nome;
            lblSobrenome.Text = _colaboradorModel.Sobrenome;
            lblSexo.Text = _colaboradorModel.Sexo.RetornarDescricao();
            lblCpf.Text = _colaboradorModel.Cpf;
            lblCidade.Text = _colaboradorModel.Endereco.Cidade;
            lblEstado.Text = _colaboradorModel.Endereco.Uf.RetornarDescricao();
            lblLogradouro.Text = _colaboradorModel.Endereco.Logradouro;
            lblBairro.Text = _colaboradorModel.Endereco.Bairro;
            lblNumero.Text = _colaboradorModel.Endereco.Numero;
            lblSalario.Text = $"{_colaboradorModel.Salario:c2}";
            lblComissao.Text = $"{_colaboradorModel.Comissao:c2}";
            lblDataNascimento.Text = $"{_colaboradorModel.DataNascimento:dd/mm/yyyy}";
            lblEmails.Text = RetornarEmailsFormatado();
            lblTelefones.Text = RetornarTelefonesFormatado();
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
