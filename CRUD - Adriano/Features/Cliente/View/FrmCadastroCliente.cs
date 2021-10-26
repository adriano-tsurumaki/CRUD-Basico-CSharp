using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Utils;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cliente.View
{
    public partial class FrmCadastroCliente : FormBase<ClienteModel>, IFormBase
    //public partial class FrmCadastroCliente : Form
    {
        private ClienteModel _clienteModel;
        
        public event ValidarHandle ValidarEvent;

        public FrmCadastroCliente()
        {
            InitializeComponent();
            ValidarEvent += new ValidarHandle(ValidarComponentes);
        }

        public override void Validar() => ValidarEvent?.Invoke();

        public void ValidarComponentes()
        {
            if (txtValorLimite.NuloOuVazio())
            {
                Validado = false;
                return;
            }
            else if (!txtValorLimite.Numerico())
            {
                MessageBox.Show("Valor limite deve ser numérico!");
                Validado = false;
                return;
            }

            int.TryParse(txtValorLimite.Texto.RetornarSomenteNumeros(), out int resultado);
            
            _clienteModel.ValorLimite = resultado;

            Validado = true;
        }

        public override void AdicionarModel(ref ClienteModel clienteModel)
        {
            txtValorLimite.DataBindings.Add("Texto", clienteModel, "ValorLimite");
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

            var textoFormatado = "R$ " + txtValorLimite.Texto.RetornarSomenteNumeros();

            if (textoFormatado.Length > 5)
                textoFormatado = textoFormatado.Insert(textoFormatado.Length - 2, ",");

            if (textoFormatado != txtValorLimite.Texto)
                evitarLoopValorLimite = true;

            txtValorLimite.SelectionLength = 0;
            txtValorLimite.Texto = textoFormatado;
        }
    }
}
