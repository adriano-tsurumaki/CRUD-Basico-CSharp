namespace CRUD___Adriano.Features.Entidades.DadosBancarios.Sql
{
    public static class DadosBancariosSql
    {
        public static readonly string Inserir =
            @"insert into DadosBancarios(id_colaborador, agencia, conta, tipo_conta, banco)
            values(@IdColaborador, @Agencia, @Conta, @TipoConta, @Banco)";
    }
}
