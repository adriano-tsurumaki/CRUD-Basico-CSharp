using CRUD___Adriano.Features.Usuario.Enum;
using System;
using System.Collections.Generic;

namespace CRUD___Adriano.Features.Cliente.Model
{
    public abstract class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public UsuarioSexoEnum Sexo { get; set; }
        public IList<EmailModel> Emails { get; set; }
        public DateTime DataNascimento { get; set; }
        public EnderecoModel Endereco { get; set; }

        public UsuarioModel()
        {
            Endereco = new EnderecoModel();
            Emails = new List<EmailModel>();
        }
    }
}
