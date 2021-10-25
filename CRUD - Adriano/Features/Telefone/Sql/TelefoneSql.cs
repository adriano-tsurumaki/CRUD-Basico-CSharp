namespace CRUD___Adriano.Features.Telefone.Sql
{
    public static class TelefoneSql
    {
        public static readonly string Inserir =
            @"insert into Telefone(id_usuario, numero, tipo) values (@IdUsuario, @Numero, @Tipo)";

        public static readonly string ListarTodosPorId =
            @"select u.id as IdUsuario, 
			u.id as split, t.id, t.id_usuario as IdUsuario, t.numero, t.tipo
			from Usuario u
            inner join Telefone t on t.id_usuario = u.id";

        public static readonly string Remover =
            @"delete Telefone where id_usuario = @id";

        public static readonly string Atualizar =
            @"update Telefone set
            numero = @Numero,
            tipo = @Tipo
            where id = @Id and id_usuario = @IdUsuario";
    }
}
