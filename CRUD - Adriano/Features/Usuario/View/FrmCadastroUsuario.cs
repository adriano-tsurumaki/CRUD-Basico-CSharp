using CRUD___Adriano.Features.Componentes;
using CRUD___Adriano.Features.Estados.Enum;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Usuario.Enum;
using CRUD___Adriano.Features.Usuario.Model;
using CRUD___Adriano.Features.Utils;
using System;

namespace CRUD___Adriano.Features.Cadastro.Usuario.View
{
    public partial class FrmCadastroUsuario<T> : FormBase<T>, IFormBase where T : class
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
        }

        public override void AdicionarModel(ref T model)
        {
            _model = model;
        }

        private bool TextoNuloOuVazio(TextBoxFlat textBox) => string.IsNullOrEmpty(textBox.Texto);

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
    }
}
