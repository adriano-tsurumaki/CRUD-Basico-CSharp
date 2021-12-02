using CRUD___Adriano.Features.Entidades.DadosBancarios.Model;
using CRUD___Adriano.Features.Usuario.Model;
using CRUD___Adriano.Features.ValueObject.Precos;

namespace CRUD___Adriano.Features.Colaborador.Model
{
    public class ColaboradorModel: UsuarioModel
    {
        public int Id { get; set; }
        public Preco Salario { get; set; }
        public double Comissao { get; set; }
        public DadosBancariosModel DadosBancarios { get; set; }

        public ColaboradorModel()
        {
            DadosBancarios = new DadosBancariosModel();
        }
    }
}
