using CRUD___Adriano.Features.Componentes;
using CRUD___Adriano.Features.Estados.Enum;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Usuario.Enum;
using CRUD___Adriano.Features.Usuario.Model;
using CRUD___Adriano.Features.Utils;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cadastro.Usuario.View
{
    public partial class FrmCadastroUsuario<T> : FormBase<T> where T : class
    {
        private T _model;

        public FrmCadastroUsuario()
        {
            InitializeComponent();

            txtNome.Focus();
            cbSexo.AtribuirPeloEnum<UsuarioSexoEnum>();
            cbEstado.AtribuirPeloEnum<EstadosBrasilEnum>();
        }

        public override void AdicionarModel(T model)
        {
            _model = model;
        }

        private void BtnCadastrar_Click(object sender, System.EventArgs e)
        {
            //if (ValidateChildren(ValidationConstraints.Enabled))
                //_produtoCadastroController.CadastrarCliente(_usuarioModel);
        }

        private void BtnCancelar_Click(object sender, System.EventArgs e) =>
            Close();

        private void FrmCadastroProduto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.F5:
                    //_produtoCadastroController.CadastrarCliente(_usuarioModel);
                    break;
            }
        }

        private void TxtNome_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidacaoPadrao(txtNome, e))
                (_model as UsuarioModel).Nome = txtNome.Texto;
        }

        private void TxtSobrenome_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidacaoPadrao(txtSobrenome, e))
                (_model as UsuarioModel).Sobrenome = txtSobrenome.Texto;
        }

        private void TxtLogradouro_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidacaoPadrao(txtLogradouro, e))
                (_model as UsuarioModel).Endereco.Logradouro = txtLogradouro.Texto;
        }

        private void TxtBairro_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidacaoPadrao(txtBairro, e))
                (_model as UsuarioModel).Endereco.Bairro = txtBairro.Texto;
        }

        private void TxtNumero_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidacaoPadrao(txtNumero, e))
                (_model as UsuarioModel).Endereco.Numero = txtNumero.Texto;
        }


        private void TxtCidade_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidacaoPadrao(txtCidade, e))
                (_model as UsuarioModel).Endereco.Cidade = txtCidade.Texto;
        }

        private void TxtCpf_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidacaoPadrao(txtCpf, e))
                (_model as UsuarioModel).Cpf = txtCpf.Texto;
        }

        private bool ValidacaoPadrao(TextBoxFlat textBox, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Texto))
            {
                errorProvider.SetError(textBox, "Número obrigatório!");
                return false;
            }

            errorProvider.SetError(textBox, null);
            return true;
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

        private void CbSexo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                (_model as UsuarioModel).Sexo = cbSexo.PegarEnumPorDescricao<UsuarioSexoEnum>();
                errorProvider.SetError(cbSexo, null);
            }
            catch (Exception)
            {
                errorProvider.SetError(cbSexo, "Opção inválida!");
            }
        }

        private void CbEstado_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                (_model as UsuarioModel).Endereco.Uf = cbEstado.PegarEnumPorDescricao<UsuarioSexoEnum>().ToString();
                errorProvider.SetError(cbEstado, null);
            }
            catch (Exception)
            {
                errorProvider.SetError(cbEstado, "Opção inválida!");
            }
        }
    }
}
