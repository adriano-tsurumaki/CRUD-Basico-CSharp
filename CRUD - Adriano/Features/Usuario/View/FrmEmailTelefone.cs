using CRUD___Adriano.Features.Email.Model;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Telefone.Enum;
using CRUD___Adriano.Features.Telefone.Model;
using CRUD___Adriano.Features.Usuario.Model;
using CRUD___Adriano.Features.Utils;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Usuario.View
{
    public partial class FrmEmailTelefone<T> : FormBase<T>, IFormBase where T : class
    //public partial class FrmEmailTelefone : Form
    {
        private BindingList<EmailModel> _emailsBinding;
        private BindingList<TelefoneModel> _telefonesBinding;

        public event ValidarHandle ValidarEvent;

        public FrmEmailTelefone()
        {
            InitializeComponent();

            cbTelefone.AtribuirPeloEnum<TipoTelefoneEnum>();
            ValidarEvent += new ValidarHandle(ValidarComponentes);
        }

        public override void Validar() => ValidarEvent?.Invoke();

        public void ValidarComponentes()
        {
            if (_emailsBinding.Count == 0 || _telefonesBinding.Count == 0)
            {
                Validado = false;
                return;
            }

            Validado = true;
        }

        public override void AdicionarModel(ref T model)
        {
            _emailsBinding = new BindingList<EmailModel>((model as UsuarioModel).Emails);
            _emailsBinding.ConfiguracaoPadrao();

            _telefonesBinding = new BindingList<TelefoneModel>((model as UsuarioModel).Telefones);
            _telefonesBinding.ConfiguracaoPadrao();

            dgvEmails.DataSource = _emailsBinding;
            dgvTelefones.DataSource = _telefonesBinding;
        }

        private void BtnAdicionarEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.NuloOuVazio())
            {
                MessageBox.Show("Insira um email!");
                return;
            }
            _emailsBinding.Add(new EmailModel { Nome = txtEmail.Texto });
        }

        private void BtnAdicionarTelefone_Click(object sender, EventArgs e)
        {
            if (txtTelefone.NuloOuVazio())
            {
                MessageBox.Show("Insira um telefone!");
                return;
            }
            else if (!cbTelefone.EstaSelecionado())
            {
                MessageBox.Show("Selecione o tipo do telefone!");
                return;
            }
            _telefonesBinding.Add(new TelefoneModel { Numero = txtTelefone.Texto, Tipo = cbTelefone.PegarEnumPorDescricao<TipoTelefoneEnum>() });
        }
    }
}
