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

        public static readonly string sqlSelecionarCliente =
           @"select u.id as IdUsuario, u.nome, u.sobrenome, u.sexo, u.cpf, u.data_nascimento as DataNascimento, c.valor_limite as ValorLimite, c.observacao
			from Cliente c
			inner join Usuario u on u.id = c.id_usuario
            where u.id = @id";
    }
}
