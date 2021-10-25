using CRUD___Adriano.Features.Cliente.Model;
using CRUD___Adriano.Features.Colaborador.Enum;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Utils;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Colaborador.View
{
    public partial class FrmCadastroColaborador : FormBase<ColaboradorModel>, IFormBase
    //public partial class FrmCadastroColaborador : Form
    {
        public ColaboradorModel _colaboradorModel{ get; set; }

        public event ValidarHandle ValidarEvent;

        public FrmCadastroColaborador()
        {
            InitializeComponent();
            ValidarEvent += new ValidarHandle(ValidarComponentes);
        }

        public override void Validar() => ValidarEvent?.Invoke();

        public void ValidarComponentes()
        {
            if (txtSalario.NuloOuVazio() || txtComissao.NuloOuVazio() ||
                txtAgencia.NuloOuVazio() || txtConta.NuloOuVazio() ||
                txtBanco.NuloOuVazio() || !cbTipoConta.EstaSelecionado())
            {
                Validado = false;
                return;
            }

            _colaboradorModel.DadosBancarios.TipoConta = cbTipoConta.PegarEnumPorDescricao<TipoContaEnum>();

            Validado = true;
        }

        public override void AdicionarModel(ref ColaboradorModel colaboradorModel)
        {
            _colaboradorModel = colaboradorModel;
            txtSalario.DataBindings.Add("Texto", colaboradorModel, "Salario");
            txtComissao.DataBindings.Add("Texto", colaboradorModel, "Comissao");
            txtAgencia.DataBindings.Add("Texto", colaboradorModel.DadosBancarios, "Agencia");
            txtConta.DataBindings.Add("Texto", colaboradorModel.DadosBancarios, "Conta");
            txtBanco.DataBindings.Add("Texto", colaboradorModel.DadosBancarios, "Banco");
            cbTipoConta.AtribuirPeloEnum<TipoContaEnum>();
            cbTipoConta.SelectedIndex = (int)colaboradorModel.DadosBancarios.TipoConta;
        }
    }
}
