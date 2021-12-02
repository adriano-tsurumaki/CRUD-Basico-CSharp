using CRUD___Adriano.Features.Usuario.Model;
using CRUD___Adriano.Features.ValueObject.Precos;

namespace CRUD___Adriano.Features.Cadastro.Produto.Model
{
    public class ClienteModel: UsuarioModel
    {
        public int Id { get; set; }
        public Preco ValorLimite { get; set; }
        public string Observacao { get; set; }
    }
}
