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
    }
}
