using CRUD___Adriano.Features.Colaborador.Enum;
using CRUD___Adriano.Features.Colaborador.Model;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Interface;
using CRUD___Adriano.Features.Utils;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Colaborador.View
{
    public partial class FrmCadastroColaborador : Form, IViewPage<ColaboradorModel>
    {
        public ColaboradorModel _colaboradorModel{ get; set; }

        private readonly IControllerPage<ColaboradorModel> _controllerPage;

        public FrmCadastroColaborador(IControllerPage<ColaboradorModel> controllerPage)
        {
            InitializeComponent();
            _controllerPage = controllerPage;
        }

        // TODO: Mostrar mensagens de erro
        public bool ValidarComponentes()
        {
            if (txtAgencia.NuloOuVazio() || txtConta.NuloOuVazio() ||
                txtBanco.NuloOuVazio() || !cbTipoConta.EstaSelecionado())
            {
                MessageBox.Show("Preencha os campos obrigatórios");
                return false;
            }

            if (!ValidarSalario() || !ValidarComissao()) return false;

            _colaboradorModel.DadosBancarios.TipoConta = cbTipoConta.PegarEnumPorDescricao<TipoContaEnum>();
            _colaboradorModel.Comissao = txtComissao.Texto.DoubleOuZero() / 100;

            return true;
        }

        private bool ValidarSalario()
        {
            if (txtSalario.NuloOuVazio()) return false;

            var resultado = _colaboradorModel.Salario.ValidarTudo();

            if (resultado.IsValid) return true;

            MessageBox.Show(resultado.Errors[0].ErrorMessage);
            return false;
        }

        private bool ValidarComissao()
        {
            if (txtComissao.NuloOuVazio()) return false;

            if (_colaboradorModel.Comissao >= 1)
            {
                MessageBox.Show("A comissão não deve ser igual ou ultrapassar os 100%");
                return false;
            }

            return true;
        }

        public void BindModel(ref ColaboradorModel colaboradorModel)
        {
            _colaboradorModel = colaboradorModel;
            txtSalario.DataBindings.Add("Texto", colaboradorModel, "Salario.Formatado");
            txtComissao.Texto = (colaboradorModel.Comissao * 100).ToString();
            txtAgencia.DataBindings.Add("Texto", colaboradorModel.DadosBancarios, "Agencia");
            txtConta.DataBindings.Add("Texto", colaboradorModel.DadosBancarios, "Conta");
            txtBanco.DataBindings.Add("Texto", colaboradorModel.DadosBancarios, "Banco");
            cbTipoConta.AtribuirPeloEnum<TipoContaEnum>();
            cbTipoConta.SelectedIndex = (int)colaboradorModel.DadosBancarios.TipoConta;
        }

        private bool evitarLoopSalario;

        private void TxtSalario__TextChanged(object sender, System.EventArgs e)
        {
            if (evitarLoopSalario)
            {
                txtSalario.SelectionStart = txtSalario.Texto.Length;
                evitarLoopSalario = false;
                return;
            }

            var textoFormatado = "R$ " + txtSalario.Texto.RetornarSomenteTextoEmNumeros();

            if (textoFormatado.Length > 5)
                textoFormatado = textoFormatado.Insert(textoFormatado.Length - 2, ",");

            if (textoFormatado != txtSalario.Texto)
                evitarLoopSalario = true;

            txtSalario.SelectionLength = 0;
            txtSalario.Texto = textoFormatado;
            _colaboradorModel.Salario = txtSalario.Texto;
        }

        private bool evitarLoopConta;

        private void TxtConta__TextChanged(object sender, System.EventArgs e)
        {
            if (evitarLoopConta)
            {
                txtConta.SelectionStart = txtConta.Texto.Length;
                evitarLoopConta = false;
                return;
            }

            if (txtConta.Texto.Length == 13)
            {
                evitarLoopConta = true;
                txtConta.Texto = txtConta.Texto.Remove(txtConta.SelectionStart - 1, 1);
            }

            var textoFormatado = txtConta.Texto.RetornarSomenteTextoEmNumeros();

            if (textoFormatado != txtConta.Texto)
                evitarLoopConta = true;

            txtConta.SelectionLength = 0;
            txtConta.Texto = textoFormatado;
        }

        private void TxtComissao__TextChanged(object sender, System.EventArgs e)
        {
            _colaboradorModel.Comissao = txtComissao.Texto.DoubleOuZero() / 100;
        }

        private bool evitarLoopAgencia;

        private void TxtAgencia__TextChanged(object sender, System.EventArgs e)
        {
            if (evitarLoopAgencia)
            {
                txtAgencia.SelectionStart = txtAgencia.Texto.Length;
                evitarLoopAgencia = false;
                return;
            }

            if (txtAgencia.Texto.Length == 5)
            {
                evitarLoopAgencia = true;
                txtAgencia.Texto = txtAgencia.Texto.Remove(txtAgencia.SelectionStart - 1, 1);
            }

            var textoFormatado = txtAgencia.Texto.RetornarSomenteTextoEmNumeros();

            if (textoFormatado != txtAgencia.Texto)
                evitarLoopAgencia = true;

            txtAgencia.SelectionLength = 0;
            txtAgencia.Texto = textoFormatado;
        }
    }
}
