namespace CRUD___Adriano.Features.Email.Sql
{
    public static class EmailSql
    {
        public static readonly string Inserir =
            @"insert into Email(id_usuario, nome) values (@IdUsuario, @Nome)";

        public static readonly string ListarTodosPorId =
            @"select u.id as IdUsuario,
			u.id as split, e.id, e.id_usuario as IdUsuario, e.nome
			from Usuario u
			inner join Email e on e.id_usuario = u.id";

        public static readonly string Remover =
            @"delete Email where id_usuario = @id";

        public static readonly string Atualizar =
            @"update Email set
            nome = @Nome
            where id = @Id and id_usuario = @IdUsuario";
    }
}
