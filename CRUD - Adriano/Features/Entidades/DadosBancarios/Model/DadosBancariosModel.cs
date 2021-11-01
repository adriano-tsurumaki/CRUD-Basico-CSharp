using CRUD___Adriano.Features.Colaborador.Enum;

namespace CRUD___Adriano.Features.Entidades.DadosBancarios.Model
{
    public class DadosBancariosModel
    {
        public int IdColaborador { get; set; }
        public int Id { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public TipoContaEnum TipoConta { get; set; }
        public string Banco { get; set; }
    }
}
