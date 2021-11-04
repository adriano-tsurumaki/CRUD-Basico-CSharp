using CRUD___Adriano.Features.Usuario.Model;
using Dapper;

namespace CRUD___Adriano.Features.Usuario.Sql
{
    public static class UsuarioSql
    {
        public static readonly string Inserir =
            @"insert into Usuario(nome, sobrenome, sexo, data_nascimento, cpf) 
            output inserted.id
            values(@Nome, @Sobrenome, @Sexo, @DataNascimento, @Cpf)";

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

        public static DynamicParameters RetornarParametroDinamicoParaInserirUm(UsuarioModel usuarioModel)
        {
            var parametros = new DynamicParameters();

            parametros.AddDynamicParams(new {
                usuarioModel.Nome,
                usuarioModel.Sobrenome,
                Cpf = usuarioModel.Cpf.ToString(),
                usuarioModel.Sexo,
                usuarioModel.DataNascimento
            });

            return parametros;
        }
    }
}
