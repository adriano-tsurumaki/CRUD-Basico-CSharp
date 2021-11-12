using CRUD___Adriano.Features.Fornecedor.Model;
using Dapper;
using System.Text;

namespace CRUD___Adriano.Features.Fornecedor.Sql
{
    public static class FornecedorSql
    {
        public static string ListarTodosComCamposSomenteIdENome =
            @"select u.id as IdUsuario, f.id, u.nome
            from Fornecedor f
            inner join Usuario u on u.id = f.id_usuario";

        public static string ListarPeloNomeComCamposSomenteIdENome =
            @"select u.id as IdUsuario, f.id, u.nome
			from Fornecedor f
			inner join Usuario u on u.id = f.id_usuario
            where u.nome Like @Nome + '%'";

        public static readonly string ListarPelaQuantidadeComCamposSomenteIdENome =
            @"select top {=Quantidade} u.id as IdUsuario, f.id, u.nome
            from Fornecedor f
			inner join Usuario u on u.id = f.id_usuario";

        public static readonly string SelecionarComCamposSomenteIdENome =
            @"select u.id as IdUsuario, f.id, u.nome
			from Fornecedor f
			inner join Usuario u on u.id = f.id_usuario
			where u.id = @id";

        public static string InserirFornecedor(FornecedorModel fornecedorModel)
        {
            var insertSql = new StringBuilder("insert into Fornecedor(id_usuario, cnpj");
            var valuesSql = new StringBuilder("values (@IdUsuario, @Cnpj");

            if (!string.IsNullOrEmpty(fornecedorModel.Observacao))
            {
                insertSql.Append(", observacao");
                valuesSql.Append(", @Observacao");
            }

            insertSql.Append(")");
            valuesSql.Append(")");
            return string.Join(' ', insertSql, valuesSql);
        }

        public static object RetornarParametroDinamicoParaInserirUm(FornecedorModel fornecedorModel)
        {
            var parametros = new DynamicParameters();

            parametros.AddDynamicParams(new
            {
                fornecedorModel.IdUsuario,
                fornecedorModel.Observacao,
                Cnpj = fornecedorModel.Cnpj.ToString(),
            });

            return parametros;
        }
    }
}
