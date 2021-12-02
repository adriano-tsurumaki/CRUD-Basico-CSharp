using CRUD___Adriano.Features.Colaborador.Model;
using Dapper;

namespace CRUD___Adriano.Features.Colaborador.Sql
{
    public static class ColaboradorSql
    {
        public static readonly string Inserir =
            @"insert into Colaborador(id_usuario, salario, comissao)
            output inserted.id
            values(@IdUsuario, @Salario, @Comissao)";

        public static readonly string ListarTodos =
            @"select u.id as IdUsuario, u.nome, u.sobrenome, u.sexo, u.cpf, u.data_nascimento as DataNascimento, c.salario, c.comissao,
            c.id as split, en.id_usuario as IdUsuario, en.cep, en.logradouro, en.bairro, en.cidade, en.uf, en.complemento, en.numero
			from Colaborador c
			inner join Usuario u on u.id = c.id_usuario
			inner join Endereco en on en.id_usuario = u.id";

        public static readonly string ListarTodosComCamposSomenteIdENome =
            @"select u.id as IdUsuario, u.nome
            from Colaborador c
            inner join Usuario u on u.id = c.id_usuario";

        public static readonly string ListarPelaQuantidadeComCamposSomenteIdENome =
            @"select top {=Quantidade} u.id as IdUsuario, u.nome
            from Colaborador c
			inner join Usuario u on u.id = c.id_usuario";

        public static readonly string ListarPeloNomeComCamposSomenteIdENome =
            @"select u.id as IdUsuario, u.nome
			from Colaborador c
			inner join Usuario u on u.id = c.id_usuario
            where u.nome Like @Nome + '%'";

        public static readonly string SelecionarComCamposSomenteIdENome =
            @"select u.id as IdUsuario, u.nome
			from Colaborador c
			inner join Usuario u on u.id = c.id_usuario
			where u.id = @id";

        public static readonly string Selecionar =
            @"select u.id as IdUsuario, u.nome, u.sobrenome, u.sexo, u.cpf, u.data_nascimento as DataNascimento, c.salario, c.comissao
			from Colaborador c
			inner join Usuario u on u.id = c.id_usuario
            where u.id = @id";

        public static readonly string SelecionarQuantidadeDeTodos =
            @"select count(*) from Colaborador";

        public static readonly string Atualizar =
            @"update Colaborador set
            salario = @Salario,
            comissao = @Comissao
            where id_usuario = @IdUsuario";

        public static DynamicParameters RetornarParametroDinamicoDaModel(ColaboradorModel colaboradorModel)
        {
            var parametros = new DynamicParameters();

            parametros.AddDynamicParams(new
            {
                colaboradorModel.IdUsuario,
                colaboradorModel.Id,
                Salario = colaboradorModel.Salario.Valor,
                colaboradorModel.Comissao
            });

            return parametros;
        }
    }
}
