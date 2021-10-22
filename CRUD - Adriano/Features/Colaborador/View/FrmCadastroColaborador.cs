using CRUD___Adriano.Features.Cliente.Model;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Utils;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Colaborador.View
{
    public partial class FrmCadastroColaborador : FormBase<ColaboradorModel>, IFormBase
    //public partial class FrmCadastroColaborador : Form
    {
        public event ValidarHandle ValidarEvent;

        public FrmCadastroColaborador()
        {
            InitializeComponent();
            ValidarEvent += new ValidarHandle(ValidarComponentes);
        }

        public override void Validar() => ValidarEvent?.Invoke();

        public void ValidarComponentes()
        {
            if (txtSalario.NuloOuVazio() || txtComissao.NuloOuVazio())
            {
                Validado = false;
                return;
            }

            Validado = true;
        }

        public override void AdicionarModel(ref ColaboradorModel colaboradorModel)
        {
            txtSalario.DataBindings.Add("Texto", colaboradorModel, "Salario");
            txtComissao.DataBindings.Add("Texto", colaboradorModel, "Comissao");
        }
    }
}
