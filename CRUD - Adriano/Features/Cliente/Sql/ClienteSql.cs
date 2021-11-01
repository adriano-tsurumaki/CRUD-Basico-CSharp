namespace CRUD___Adriano.Features.Cliente.Sql
{
    public static class ClienteSql
    {
        public static readonly string sqlListarTodosOsClientes =
            @"select u.id as IdUsuario, u.nome, u.sobrenome, u.sexo, u.cpf, u.data_nascimento as DataNascimento, c.valor_limite as ValorLimite, c.observacao,
            c.id as split, en.id_usuario as IdUsuario, en.cep, en.logradouro, en.bairro, en.cidade, en.uf, en.complemento, en.numero
			from Cliente c
			inner join Usuario u on u.id = c.id_usuario
			inner join Endereco en on en.id_usuario = u.id";

        public static readonly string sqlListarTodosOsClientesComCamposSomenteIdENome =
            @"select u.id as IdUsuario, u.nome
			from Cliente c
			inner join Usuario u on u.id = c.id_usuario";
        
        public static readonly string sqlListarClientesPeloNomeComCamposSomenteIdENome =
            @"select u.id as IdUsuario, u.nome
			from Cliente c
			inner join Usuario u on u.id = c.id_usuario
            where u.nome Like @Nome + '%'";

        public static readonly string sqlListarAlgunsClientesComCamposSomenteIdENome =
            @"select top {=Quantidade} u.id as IdUsuario, u.nome
            from Cliente c
			inner join Usuario u on u.id = c.id_usuario";

        public static readonly string sqlSelecionarClienteComCamposSomenteIdENome =
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
