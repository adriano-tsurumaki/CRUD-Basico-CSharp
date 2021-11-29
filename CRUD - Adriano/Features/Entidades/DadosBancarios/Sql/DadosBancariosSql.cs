namespace CRUD___Adriano.Features.Entidades.DadosBancarios.Sql
{
    public static class DadosBancariosSql
    {
        public static readonly string Inserir =
            @"insert into DadosBancarios(id_colaborador, agencia, conta, tipo_conta, banco)
            values(@IdColaborador, @Agencia, @Conta, @TipoConta, @Banco)";

        public static readonly string SelecionarUm =
            @"select db.agencia, db.conta, db.tipo_conta as TipoConta, db.banco
			from DadosBancarios db
			inner join Colaborador c on c.id = db.id_colaborador
			inner join Usuario u on u.id = c.id_usuario
            where u.id = @id";

        public static readonly string Atualizar =
            @"update DadosBancarios set
            agencia = @Agencia,
            conta = @Conta,
            tipo_conta = @TipoConta,
            banco = @Banco
            where id_colaborador = @IdColaborador";

        public static readonly string ListarTodos =
            @"select u.id as IdUsuario, 
            u.id as split, db.agencia, db.conta, db.tipo_conta as TipoConta, db.banco
            from Colaborador c
            inner join Usuario u on u.id = c.id_usuario
            inner join DadosBancarios db on db.id_colaborador = c.id";
    }
}
