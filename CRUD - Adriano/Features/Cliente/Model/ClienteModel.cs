using CRUD___Adriano.Features.Usuario.Model;

namespace CRUD___Adriano.Features.Cadastro.Produto.Model
{
    public class ClienteModel: UsuarioModel
    {
        public int Id { get; set; }
        public string ValorLimite { get; set; }
        public string Observacao { get; set; }
    }
}
