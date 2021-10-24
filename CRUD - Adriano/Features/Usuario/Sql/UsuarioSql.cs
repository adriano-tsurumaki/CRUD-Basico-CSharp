namespace CRUD___Adriano.Features.Usuario.Sql
{
    public static class UsuarioSql
    {
        public static readonly string Remover =
            @"delete Usuario where id = @id";

        public static readonly string Atualizar =
            @"update Usuario set
            nome = @Nome,
            sobrenome = @Sobrenome,
            cpf = @Cpf,
            sexo = @Sexo,
            data_nascimento = @DataNascimento
            where id = @IdUsuario";
    }
}
