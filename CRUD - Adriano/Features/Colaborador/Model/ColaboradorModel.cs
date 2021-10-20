using CRUD___Adriano.Features.Usuario.Model;

namespace CRUD___Adriano.Features.Cliente.Model
{
    public class ColaboradorModel: UsuarioModel
    {
        public float Salario { get; set; }
        public float Comissao { get; set; }
    }
}
