using System;
using System.Collections.Generic;

namespace CRUD___Adriano.Features.Cliente.Model
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public IList<EmailModel> Emails { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
