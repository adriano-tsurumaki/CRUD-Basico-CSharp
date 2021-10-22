﻿using CRUD___Adriano.Features.Estados.Enum;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Usuario.Enum;
using CRUD___Adriano.Features.Usuario.Model;
using CRUD___Adriano.Features.Utils;
using System;
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

            (_model as UsuarioModel).Endereco.Uf = cbEstado.PegarEnumPorDescricao<EstadosBrasilEnum>();
            (_model as UsuarioModel).Sexo = cbSexo.PegarEnumPorDescricao<UsuarioSexoEnum>();
            (_model as UsuarioModel).DataNascimento = dataNascimento.Value;

            Validado = true;
        }

        public override void AdicionarModel(ref T model)
        {
            _model = model;
            txtNome.DataBindings.Add("Texto", model, "Nome");
            txtSobrenome.DataBindings.Add("Texto", model, "Sobrenome");
            txtCpf.DataBindings.Add("Texto", model, "Cpf");
            txtLogradouro.DataBindings.Add("Texto", model, "Endereco.Logradouro");
            txtCidade.DataBindings.Add("Texto", model, "Endereco.Cidade");
            txtBairro.DataBindings.Add("Texto", model, "Endereco.Bairro");
            txtNumero.DataBindings.Add("Texto", model, "Endereco.Numero");
            txtCep.DataBindings.Add("Texto", model, "Endereco.Cep");
            txtComplemento.DataBindings.Add("Texto", model, "Endereco.Complemento");
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
    }
}