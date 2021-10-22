using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Email.Model;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Telefone.Enum;
using CRUD___Adriano.Features.Telefone.Model;
using CRUD___Adriano.Features.Utils;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cliente.View
{
    public partial class FrmCadastroCliente : FormBase<ClienteModel>, IFormBase
    //public partial class FrmCadastroCliente : Form
    {
        public ClienteModel _clienteModel { get; set; }
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

            Validado = true;
        }

        public override void AdicionarModel(ref ClienteModel clienteModel)
        {
            _clienteModel = clienteModel;
            txtValorLimite.DataBindings.Add("Texto", clienteModel, "ValorLimite");
            txtObservacao.DataBindings.Add("Texto", clienteModel, "Observacao");
        }
    }
}
