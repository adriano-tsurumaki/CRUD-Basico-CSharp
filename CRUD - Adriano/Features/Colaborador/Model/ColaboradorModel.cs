using CRUD___Adriano.Features.Colaborador.Model;
using CRUD___Adriano.Features.Usuario.Model;

namespace CRUD___Adriano.Features.Cliente.Model
{
    public class ColaboradorModel: UsuarioModel
    {
        public int Id { get; set; }
        public string Salario { get; set; }
        public string Comissao { get; set; }
        public DadosBancariosModel DadosBancarios { get; set; }

        public ColaboradorModel()
        {
            DadosBancarios = new DadosBancariosModel();
        }
    }
}
