namespace CRUD___Adriano.Features.Colaborador.Sql
{
    public static class ColaboradorSql
    {
        public static readonly string Inserir =
            @"insert into Colaborador(id_usuario, salario, comissao)
            output inserted.id
            values(@IdUsuario, @Salario, @Comissao)";

        public static string ListarTodos =
            @"select u.id as IdUsuario, u.nome, u.sobrenome, u.sexo, u.cpf, u.data_nascimento as DataNascimento, c.salario, c.comissao,
            c.id as split, en.id_usuario as IdUsuario, en.cep, en.logradouro, en.bairro, en.cidade, en.uf, en.complemento, en.numero
			from Colaborador c
			inner join Usuario u on u.id = c.id_usuario
			inner join Endereco en on en.id_usuario = u.id";

        public static string ListarTodosComCamposSomenteIdENome =
            @"select u.id as IdUsuario, u.nome
            from Colaborador c
            inner join Usuario u on u.id = c.id_usuario";

        public static string ListarPelaQuantidadeComCamposSomenteIdENome =
            @"select top {=Quantidade} u.id as IdUsuario, u.nome
            from Colaborador c
			inner join Usuario u on u.id = c.id_usuario";

        public static string ListarPeloNomeComCamposSomenteIdENome =
            @"select u.id as IdUsuario, u.nome
			from Colaborador c
			inner join Usuario u on u.id = c.id_usuario
            where u.nome Like @Nome + '%'";

        public static string SelecionarComCamposSomenteIdENome =
            @"select u.id as IdUsuario, u.nome
			from Colaborador c
			inner join Usuario u on u.id = c.id_usuario
			where u.id = @id";

        public static string Selecionar =
            @"select u.id as IdUsuario, u.nome, u.sobrenome, u.sexo, u.cpf, u.data_nascimento as DataNascimento, c.salario, c.comissao
			from Colaborador c
			inner join Usuario u on u.id = c.id_usuario
            where u.id = @id";

        public static string Atualizar =
            @"update Colaborador set
            salario = @Salario,
            comissao = @Comissao
            where id_usuario = @IdUsuario";
    }
}
