using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Factory;

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

        }

        public override void AdicionarModel(ref ClienteModel clienteModel)
        {
            _clienteModel = clienteModel;
        }
    }
}
