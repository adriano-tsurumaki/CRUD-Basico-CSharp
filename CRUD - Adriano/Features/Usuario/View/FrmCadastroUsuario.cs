using CRUD___Adriano.Features.Cadastro.Produto.Controller;
using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Componentes;
using CRUD___Adriano.Features.Estados.Enum;
using CRUD___Adriano.Features.Usuario.Enum;
using CRUD___Adriano.Features.Utils;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cadastro.Usuario.View
{
    public partial class FrmCadastroUsuario : Form
    {
        private ClienteCadastroController _produtoCadastroController;
        private ClienteModel _clienteModel;

        public FrmCadastroUsuario(ClienteCadastroController produtoCadastroController)
        {
            InitializeComponent();
            _produtoCadastroController = produtoCadastroController;

            _clienteModel = new ClienteModel();

            txtNome.Focus();
            cbSexo.AtribuirPeloEnum<UsuarioSexoEnum>();
            cbEstado.AtribuirPeloEnum<EstadosBrasilEnum>();
        }

        private void BtnCadastrar_Click(object sender, System.EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
                _produtoCadastroController.CadastrarCliente(_clienteModel);
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
                    _produtoCadastroController.CadastrarCliente(_clienteModel);
                    break;
            }
        }

        private void TxtNome_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidacaoPadrao(txtNome, e))
                _clienteModel.Nome = txtNome.Texto;
        }

        private void TxtSobrenome_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidacaoPadrao(txtSobrenome, e))
                _clienteModel.Sobrenome = txtSobrenome.Texto;
        }

        private void TxtLogradouro_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidacaoPadrao(txtLogradouro, e))
                _clienteModel.Endereco.Logradouro = txtLogradouro.Texto;
        }

        private void TxtBairro_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidacaoPadrao(txtBairro, e))
                _clienteModel.Endereco.Bairro = txtBairro.Texto;
        }

        private void TxtNumero_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidacaoPadrao(txtNumero, e))
                _clienteModel.Endereco.Numero = txtNumero.Texto;
        }


        private void TxtCidade_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidacaoPadrao(txtCidade, e))
                _clienteModel.Endereco.Cidade = txtCidade.Texto;
        }

        private void TxtCpf_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidacaoPadrao(txtCpf, e))
                _clienteModel.Cpf = txtCpf.Texto;
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

            _clienteModel.DataNascimento = dataNascimento.Value;
        }

        private void CbSexo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                _clienteModel.Sexo = cbSexo.PegarEnumPorDescricao<UsuarioSexoEnum>();
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
                _clienteModel.Endereco.Uf = cbEstado.PegarEnumPorDescricao<UsuarioSexoEnum>().ToString();
                errorProvider.SetError(cbEstado, null);
            }
            catch (Exception)
            {
                errorProvider.SetError(cbEstado, "Opção inválida!");
            }
        }
    }
}
