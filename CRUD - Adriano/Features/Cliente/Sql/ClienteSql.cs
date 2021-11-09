using CRUD___Adriano.Features.Cadastro.Produto.Model;
using System.Text;

namespace CRUD___Adriano.Features.Cliente.Sql
{
    public static class ClienteSql
    {
        public static readonly string ListarTodos =
            @"select u.id as IdUsuario, u.nome, u.sobrenome, u.sexo, u.cpf, u.data_nascimento as DataNascimento, c.valor_limite as ValorLimite, c.observacao,
            c.id as split, en.id_usuario as IdUsuario, en.cep, en.logradouro, en.bairro, en.cidade, en.uf, en.complemento, en.numero
			from Cliente c
			inner join Usuario u on u.id = c.id_usuario
			inner join Endereco en on en.id_usuario = u.id";

        public static readonly string ListarTodosComCamposSomenteIdENome =
            @"select u.id as IdUsuario, u.nome
			from Cliente c
			inner join Usuario u on u.id = c.id_usuario";
        
        public static readonly string ListarPeloNomeComCamposSomenteIdENome =
            @"select u.id as IdUsuario, u.nome
			from Cliente c
			inner join Usuario u on u.id = c.id_usuario
            where u.nome Like @Nome + '%'";

        public static readonly string ListarPelaQuantidadeComCamposSomenteIdENome =
            @"select top {=Quantidade} u.id as IdUsuario, u.nome
            from Cliente c
			inner join Usuario u on u.id = c.id_usuario";

        public static readonly string SelecionarComCamposSomenteIdENome =
            @"select u.id as IdUsuario, u.nome
			from Cliente c
			inner join Usuario u on u.id = c.id_usuario
			where u.id = @id";

        public static readonly string Selecionar =
           @"select u.id as IdUsuario, u.nome, u.sobrenome, u.sexo, u.cpf, u.data_nascimento as DataNascimento, c.valor_limite as ValorLimite, c.observacao
			from Cliente c
			inner join Usuario u on u.id = c.id_usuario
            where u.id = @id";

        public static readonly string SelecionarQuantidadeDeTodos =
            @"select count(*) from Cliente";

        public static string InserirCliente(ClienteModel clienteModel)
        {
            var insertSql = new StringBuilder("insert into Cliente(id_usuario, valor_limite");
            var valuesSql = new StringBuilder("values (@IdUsuario, @ValorLimite");

            if (!string.IsNullOrEmpty(clienteModel.Observacao))
            {
                insertSql.Append(", observacao");
                valuesSql.Append(", @Observacao");
            }

            insertSql.Append(")");
            valuesSql.Append(")");
            return string.Join(' ', insertSql, valuesSql);
        }

        public static string AtualizarCliente(ClienteModel clienteModel)
        {
            var updateSql = new StringBuilder(@"update Cliente set 
            valor_limite = @ValorLimite");

            if (!string.IsNullOrEmpty(clienteModel.Observacao))
                updateSql.Append(", observacao = @Observacao ");

            updateSql.Append(" where id_usuario = @IdUsuario");

            return updateSql.ToString();
        }
    }
}
