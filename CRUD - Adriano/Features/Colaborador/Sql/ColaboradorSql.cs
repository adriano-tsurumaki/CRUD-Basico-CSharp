namespace CRUD___Adriano.Features.Colaborador.Sql
{
    public static class ColaboradorSql
    {
        public static readonly string Inserir =
            @"insert into Colaborador(id_usuario, salario, comissao)
            output inserted.id
            values(@IdUsuario, @Salario, @Comissao)";

        public static string ListarTodosOsColaboradoresComCamposSomenteIdENome =
            @"select u.id as IdUsuario, u.nome
            from Colaborador c
            inner join Usuario u on u.id = c.id_usuario";
    }
}
