namespace CRUD___Adriano.Features.Configuration.Login.Model
{
    public class UsuarioSistemaModel
    {
        public int IdUsuarioSistema { get; set; }
        public string TipoUsuario { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public bool ManterLogado { get; set; }
    }
}
