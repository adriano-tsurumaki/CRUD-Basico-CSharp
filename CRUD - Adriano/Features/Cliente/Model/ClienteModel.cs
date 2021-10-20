using CRUD___Adriano.Features.Usuario.Model;

namespace CRUD___Adriano.Features.Cadastro.Produto.Model
{
    public class ClienteModel: UsuarioModel
    {
        public int ValorLimite { get; set; }
        public string Observacao { get; set; }
    }
}
