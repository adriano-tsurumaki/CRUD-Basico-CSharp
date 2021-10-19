using CRUD___Adriano.Features.Cadastro.Produto.Controller;
using CRUD___Adriano.Features.Usuario.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using CRUD___Adriano.Features.Utils;
using CRUD___Adriano.Features.Componentes;

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

        private void TxtNome_Validating(object sender, System.ComponentModel.CancelEventArgs e) =>
            ValidacaoPadrao(txtNome, e);

        private void TxtSobrenome_Validating(object sender, System.ComponentModel.CancelEventArgs e) => 
            ValidacaoPadrao(txtSobrenome, e);

        private void TxtLogradouro_Validating(object sender, System.ComponentModel.CancelEventArgs e) => 
            ValidacaoPadrao(txtLogradouro, e);

        private void TxtBairro_Validating(object sender, System.ComponentModel.CancelEventArgs e) =>
            ValidacaoPadrao(txtBairro, e);

        private void TxtNumero_Validating(object sender, System.ComponentModel.CancelEventArgs e) =>
            ValidacaoPadrao(txtNumero, e);

        private void TxtCidade_Validating(object sender, System.ComponentModel.CancelEventArgs e) =>
            ValidacaoPadrao(txtCidade, e);

        private void TxtEstado_Validating(object sender, System.ComponentModel.CancelEventArgs e) =>
            ValidacaoPadrao(txtEstado, e);

        private void ValidacaoPadrao(TextBoxFlat textBox, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Texto))
            {
                errorProvider.SetError(textBox, "Número obrigatório!");
                return;
            }
            errorProvider.SetError(textBox, null);
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

        private void CbSexo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                cbSexo.PegarEnumPorDescricao<UsuarioEnum>();
                e.Cancel = false;
                errorProvider.SetError(dataNascimento, null);
            }
            catch(Exception ex)
            {
                e.Cancel = true;
                errorProvider.SetError(dataNascimento, "Opção inválida!");
            }
        }
    }
}
