using CRUD___Adriano.Features.Cadastro.Produto.Controller;
using CRUD___Adriano.Features.Usuario.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using CRUD___Adriano.Features.Utils;

namespace CRUD___Adriano.Features.Cadastro.Produto.View
{
    public partial class FrmCadastroCliente : Form
    {
        private ClienteCadastroController _produtoCadastroController;

        public FrmCadastroCliente(ClienteCadastroController produtoCadastroController)
        {
            InitializeComponent();
            _produtoCadastroController = produtoCadastroController;
            txtNome.Focus();
            cbSexo.AtribuirPeloEnum<UsuarioEnum>();
        }

        private void BtnCadastrar_Click(object sender, System.EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
                MessageBox.Show("Validado com sucesso", "Sucesso", MessageBoxButtons.OK);
                //_produtoCadastroController.EfetuarCadastroDoProduto();
        }

        private void BtnCancelar_Click(object sender, System.EventArgs e) =>
            Close();

        private void FrmCadastroProduto_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.F5:
                    _produtoCadastroController.EfetuarCadastroDoProduto();
                    break;
            }
        }

        private void TxtNome_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNome.Texto))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNome, "Nome obrigatório!");
                return;
            }
            e.Cancel = false;
            errorProvider.SetError(txtNome, null);
        }

        private void TxtSobrenome_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSobrenome.Texto))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSobrenome, "Sobrenome obrigatório!");
                return;
            }
            e.Cancel = false;
            errorProvider.SetError(txtSobrenome, null);
        }

        private void TxtLogradouro_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogradouro.Texto))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLogradouro, "Logradouro obrigatório!");
                return;
            }
            e.Cancel = false;
            errorProvider.SetError(txtLogradouro, null);
        }

        private void TxtBairro_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBairro.Texto))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBairro, "Bairro obrigatório!");
                return;
            }
            e.Cancel = false;
            errorProvider.SetError(txtBairro, null);
        }

        private void TxtNumero_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Texto))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNumero, "Número obrigatório!");
                return;
            }
            e.Cancel = false;
            errorProvider.SetError(txtNumero, null);
        }

        private void DataNascimento_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DateTime.MinValue.Equals(dataNascimento.Value) || DateTime.MaxValue.Equals(dataNascimento.Value) ||
                dataNascimento.Value == null)
            {
                e.Cancel = true;
                errorProvider.SetError(dataNascimento, "Data de nascimento inválido!");
                return;
            }

            e.Cancel = false;
            errorProvider.SetError(dataNascimento, null);
        }
    }
}
