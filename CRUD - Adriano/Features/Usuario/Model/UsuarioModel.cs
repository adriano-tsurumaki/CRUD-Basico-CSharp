﻿using CRUD___Adriano.Features.Entidades.Email.Model;
using CRUD___Adriano.Features.Entidades.Endereco.Model;
using CRUD___Adriano.Features.Entidades.Telefone.Model;
using CRUD___Adriano.Features.Usuario.Enum;
using CRUD___Adriano.Features.ValueObject.Cpf;
using System;
using System.Collections.Generic;

namespace CRUD___Adriano.Features.Usuario.Model
{
    public abstract class UsuarioModel
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public MeuCpf Cpf { get; set; }
        public UsuarioSexoEnum Sexo { get; set; }
        public IList<EmailModel> Emails { get; set; }
        public IList<TelefoneModel> Telefones { get; set; }
        public DateTime DataNascimento { get; set; }
        public EnderecoModel Endereco { get; set; }

        public UsuarioModel()
        {
            Emails = new List<EmailModel>();
            Telefones = new List<TelefoneModel>();
            Endereco = new EnderecoModel();
        }
    }
}
