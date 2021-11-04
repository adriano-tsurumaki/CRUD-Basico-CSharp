using CRUD___Adriano.Features.Estados.Enum;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Usuario.Enum;
using CRUD___Adriano.Features.Usuario.Model;
using CRUD___Adriano.Features.Utils;
using CRUD___Adriano.Features.ValueObject.Cpf;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cadastro.Usuario.View
{
    public partial class FrmCadastroUsuario<T> : FormBase<T>, IFormBase where T : class
    //public partial class FrmCadastroUsuario : Form
    {
        private T _model;

        public event ValidarHandle ValidarEvent;

        public FrmCadastroUsuario()
        {
            InitializeComponent();

            txtNome.Focus();
            cbSexo.AtribuirPeloEnum<UsuarioSexoEnum>();
            cbEstado.AtribuirPeloEnum<EstadosBrasilEnum>();

            ValidarEvent += new ValidarHandle(ValidarComponentes);
        }

        public override void Validar() => ValidarEvent?.Invoke();

        public void ValidarComponentes()
        {
            if (txtNome.NuloOuVazio() || txtSobrenome.NuloOuVazio() ||
                txtCpf.NuloOuVazio() || txtLogradouro.NuloOuVazio() ||
                txtCidade.NuloOuVazio() || txtBairro.NuloOuVazio() ||
                txtNumero.NuloOuVazio() || !cbSexo.EstaSelecionado() ||
                !cbEstado.EstaSelecionado())
            {
                Validado = false;
                return;
            }

            if (!ValidarCpf())
            {
                Validado = false;
                return;
            }

            if (!txtCep.NuloOuVazio() && txtCep.Texto.Length != 9)
            {
                MessageBox.Show("Cep inválido, preencha todos os números ou deixe o campo vazio.", "Aviso");
                Validado = false;
                return;
            }

            (_model as UsuarioModel).Endereco.Uf = cbEstado.PegarEnumPorDescricao<EstadosBrasilEnum>();
            (_model as UsuarioModel).Sexo = cbSexo.PegarEnumPorDescricao<UsuarioSexoEnum>();
            (_model as UsuarioModel).DataNascimento = dataNascimento.Value;
            (_model as UsuarioModel).Cpf = txtCpf.Texto.RetornarSomenteTextoEmNumeros();
            (_model as UsuarioModel).Endereco.Cep = txtCep.Texto.RetornarSomenteTextoEmNumeros();

            Validado = true;
        }

        private bool ValidarCpf()
        {
            var resultado = (_model as UsuarioModel).Cpf.ValidarTudo();

            if (resultado.IsValid) return true;

            MessageBox.Show(resultado.Errors[0].ErrorMessage);
            return false;
        }

        public override void AdicionarModel(ref T model)
        {
            _model = model;
            txtNome.DataBindings.Add("Texto", model, "Nome");
            txtSobrenome.DataBindings.Add("Texto", model, "Sobrenome");
            txtLogradouro.DataBindings.Add("Texto", model, "Endereco.Logradouro");
            txtCidade.DataBindings.Add("Texto", model, "Endereco.Cidade");
            txtBairro.DataBindings.Add("Texto", model, "Endereco.Bairro");
            txtNumero.DataBindings.Add("Texto", model, "Endereco.Numero");
            txtCep.DataBindings.Add("Texto", model, "Endereco.Cep");
            txtComplemento.DataBindings.Add("Texto", model, "Endereco.Complemento");
            cbSexo.SelectedIndex = ((int)(_model as UsuarioModel).Sexo);
            cbEstado.SelectedIndex = ((int)(_model as UsuarioModel).Endereco.Uf);
        }

        private void DataNascimento_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DateTime.MinValue.Equals(dataNascimento.Value) || DateTime.MaxValue.Equals(dataNascimento.Value) ||
                dataNascimento.Value == null)
            {
                errorProvider.SetError(dataNascimento, "Data de nascimento inválido!");
                return;
            }

            errorProvider.SetError(dataNascimento, null);

            (_model as UsuarioModel).DataNascimento = dataNascimento.Value;
        }

        private bool evitarLoopCep;

        private void TxtCep__TextChanged(object sender, EventArgs e)
        {
            if (evitarLoopCep)
            {
                txtCep.SelectionStart = txtCep.Texto.Length;
                evitarLoopCep = false;
                return;
            }

            if (txtCep.Texto.Length == 10)
            {
                evitarLoopCep = true;
                txtCep.Texto = txtCep.Texto.Remove(txtCep.SelectionStart - 1, 1);
            }

            var textoFormatado = txtCep.Texto.RetornarSomenteTextoEmNumeros();

            if (textoFormatado.Length > 5)
                textoFormatado = textoFormatado.Insert(5, "-");

            if (textoFormatado != txtCep.Texto)
                evitarLoopCep = true;

            txtCep.SelectionLength = 0;
            txtCep.Texto = textoFormatado;
        }

        private bool evitarLoopCpf;

        private void TxtCpf__TextChanged(object sender, EventArgs e)
        {
            if (evitarLoopCpf)
            {
                txtCpf.SelectionStart = txtCpf.Texto.Length;
                evitarLoopCpf = false;
                return;
            }

            if (txtCpf.Texto.Length == 15)
            {
                evitarLoopCpf = true;
                txtCpf.Texto = txtCpf.Texto.Remove(txtCpf.SelectionStart - 1, 1);
            }

            var textoFormatado = txtCpf.Texto.RetornarSomenteTextoEmNumeros();

            if (textoFormatado.Length > 3)
                textoFormatado = textoFormatado.Insert(3, ".");
            
            if (textoFormatado.Length > 7)
                textoFormatado = textoFormatado.Insert(7, ".");
            
            if (textoFormatado.Length > 11)
                textoFormatado = textoFormatado.Insert(11, "-");

            if (textoFormatado != txtCpf.Texto)
                evitarLoopCpf = true;

            txtCpf.SelectionLength = 0;
            txtCpf.Texto = textoFormatado;
            (_model as UsuarioModel).Cpf = textoFormatado;
        }

        private void TxtNumero__TextChanged(object sender, EventArgs e) =>
            txtNumero.Texto = txtNumero.Texto.RetornarSomenteTextoEmNumeros();
    }
}
