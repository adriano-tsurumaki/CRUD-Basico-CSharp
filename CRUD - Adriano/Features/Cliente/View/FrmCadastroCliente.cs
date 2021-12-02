using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Interface;
using CRUD___Adriano.Features.Utils;
using CRUD___Adriano.Features.ValueObject.Precos;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cliente.View
{
    public partial class FrmCadastroCliente : Form, IViewPage<ClienteModel>
    {
        private ClienteModel _clienteModel;

        private readonly IControllerPage<ClienteModel> _controllerPage;

        public FrmCadastroCliente(IControllerPage<ClienteModel> controllerPage)
        {
            InitializeComponent();
            _controllerPage = controllerPage;
        }

        public bool ValidarComponentes()
        {
            if (!ValidarValorLimite()) return false;

            return true;
        }

        private bool ValidarValorLimite()
        {
            if (txtValorLimite.NuloOuVazio()) return false;

            var resultado = _clienteModel.ValorLimite.ValidarTudo();

            if (resultado.IsValid) return true;

            MessageBox.Show(resultado.Errors[0].ErrorMessage);
            return false;
        }

        public void BindModel(ref ClienteModel clienteModel)
        {
            txtValorLimite.DataBindings.Add("Texto", clienteModel, "ValorLimite.Formatado");
            txtObservacao.DataBindings.Add("Texto", clienteModel, "Observacao");
            _clienteModel = clienteModel;
        }

        private bool evitarLoopValorLimite;

        private void TxtValorLimite__TextChanged(object sender, System.EventArgs e)
        {
            if (evitarLoopValorLimite)
            {
                txtValorLimite.SelectionStart = txtValorLimite.Texto.Length;
                evitarLoopValorLimite = false;
                return;
            }

            var textoFormatado = "R$ " + txtValorLimite.Texto.RetornarSomenteTextoEmNumeros();

            if (textoFormatado.Length > 5)
                textoFormatado = textoFormatado.Insert(textoFormatado.Length - 2, ",");

            if (textoFormatado != txtValorLimite.Texto)
                evitarLoopValorLimite = true;

            txtValorLimite.SelectionLength = 0;
            txtValorLimite.Texto = textoFormatado;
            _clienteModel.ValorLimite = txtValorLimite.Texto;
        }

        private void TxtObservacao__TextChanged(object sender, System.EventArgs e) =>
            lblCaracteresObservacao.Text = $"{500 - txtObservacao.Texto.Length} caracteres restando";
    }
}
