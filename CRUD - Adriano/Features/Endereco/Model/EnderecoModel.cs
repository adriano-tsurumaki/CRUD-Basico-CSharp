using CRUD___Adriano.Features.Estados.Enum;

namespace CRUD___Adriano.Features.Endereco.Model
{
    public class EnderecoModel
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public EstadosBrasilEnum Uf { get; set; }
        public string Numero { get; set; }
    }
}