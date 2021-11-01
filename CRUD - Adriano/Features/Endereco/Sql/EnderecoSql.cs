using CRUD___Adriano.Features.Endereco.Model;
using System.Text;

namespace CRUD___Adriano.Features.Endereco.Sql
{
    public static class EnderecoSql
    {

        public static readonly string SelecionarUm =
            @"select en.id_usuario as IdUsuario, en.cep, en.logradouro, en.bairro, en.cidade, en.uf, en.complemento, en.numero
			from Endereco en
			inner join Usuario u on u.id = en.id_usuario
			inner join Cliente c on c.id_usuario = en.id_usuario
            where en.id_usuario = @id";

        public static string Inserir(EnderecoModel enderecoModel)
        {
            var insertSql = new StringBuilder("insert into Endereco(id_usuario, logradouro, cidade, uf, complemento, bairro, numero");
            var valuesSql = new StringBuilder("values (@IdUsuario, @Logradouro, @Cidade, @Uf, @Complemento, @Bairro, @Numero");

            if (!string.IsNullOrEmpty(enderecoModel.Cep))
            {
                insertSql.Append(", cep");
                valuesSql.Append(", @Cep");
            }

            insertSql.Append(")");
            valuesSql.Append(")");
            return string.Join(' ', insertSql, valuesSql);
        }

        public static readonly string Remover =
            @"delete Endereco where id_usuario = @id";

        public static string Atualizar(EnderecoModel enderecoModel)
        {
            var updateSql = new StringBuilder(@"update Endereco set
                logradouro = @Logradouro,
                bairro = @Bairro,
                complemento = @Complemento,
                cidade = @Cidade,
                uf = @Uf,
                numero = @Numero");

            if (!string.IsNullOrEmpty(enderecoModel.Cep))
                updateSql.Append(", cep = @Cep");

            updateSql.Append(" where id_usuario = @IdUsuario");

            return updateSql.ToString();
        }
    }
}
