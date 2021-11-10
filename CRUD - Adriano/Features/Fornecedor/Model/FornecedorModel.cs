using CRUD___Adriano.Features.Usuario.Model;
using CRUD___Adriano.Features.ValueObject.Cnpj;

namespace CRUD___Adriano.Features.Fornecedor.Model
{
    public class FornecedorModel : UsuarioModel
    {
        public string Observacao { get; set; }
        public MeuCnpj Cnpj { get; set; }
    }
}
