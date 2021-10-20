using CRUD___Adriano.Features.Email.Model;
using CRUD___Adriano.Features.Endereco.Model;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Usuario.Enum;
using System;
using System.Collections.Generic;

namespace CRUD___Adriano.Features.Usuario.Model
{
    public abstract class UsuarioModel : ModelBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public UsuarioSexoEnum Sexo { get; set; }
        public IList<EmailModel> Emails { get; set; }
        public DateTime DataNascimento { get; set; }
        public EnderecoModel Endereco { get; set; }

        public UsuarioModel()
        {
            Endereco = new EnderecoModel();
            Emails = new List<EmailModel>();
        }

        public string RetornarCpfFormatado() => 
            Convert.ToUInt64(Cpf).ToString(@"000\.000\.000\-00");

    }
}
