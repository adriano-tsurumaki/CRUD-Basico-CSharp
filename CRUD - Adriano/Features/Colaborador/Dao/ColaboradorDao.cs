using CRUD___Adriano.Features.Cliente.Model;
using CRUD___Adriano.Features.Endereco.Model;
using Dapper;
using System.Data;
using System.Text;

namespace CRUD___Adriano.Features.Colaborador.Dao
{
    public class ColaboradorDao
    {
        private static readonly string sqlInserirUsuario =
            @"insert into Usuario(nome, sobrenome, sexo, data_nascimento, cpf) 
            output inserted.id
            values(@Nome, @Sobrenome, @Sexo, @DataNascimento, @Cpf)";

        private static readonly string sqlInserirColaborador =
            @"insert into Colaborador(id_usuario, salario, comissao)
            values(@IdUsuario, @Salario, @Comissao)";

        private static readonly string sqlInserirEmail =
            @"insert into Email(id_usuario, nome) values (@IdUsuario, @Nome)";

        private static readonly string sqlInserirTelefone =
            @"insert into Telefone(id_usuario, numero, tipo) values (@IdUsuario, @Numero, @Tipo)";

        public static bool CadastrarColaborador(IDbConnection conexao, IDbTransaction transacao, ColaboradorModel colaboradorModel)
        {
            colaboradorModel.IdUsuario = (int)conexao.ExecuteScalar(sqlInserirUsuario, colaboradorModel, transacao);

            conexao.Execute(sqlInserirColaborador, colaboradorModel, transacao);

            colaboradorModel.Endereco.IdUsuario = colaboradorModel.IdUsuario;

            foreach (var email in colaboradorModel.Emails)
                email.IdUsuario = colaboradorModel.IdUsuario;

            foreach (var telefone in colaboradorModel.Telefones)
                telefone.IdUsuario = colaboradorModel.IdUsuario;

            conexao.Execute(SqlInserirEndereco(colaboradorModel.Endereco), colaboradorModel.Endereco, transacao);
            conexao.Execute(sqlInserirEmail, colaboradorModel.Emails, transacao);
            conexao.Execute(sqlInserirTelefone, colaboradorModel.Telefones, transacao);

            return true;
        }

        private static string SqlInserirEndereco(EnderecoModel enderecoModel)
        {
            var insertSql = new StringBuilder("insert into Endereco(id_usuario, logradouro, cidade, uf, complemento, bairro, numero");
            var valuesSql = new StringBuilder("values (@IdUsuario, @Logradouro, @Cidade, @Uf, @Complemento, @Bairro, @Numero");

            if (!string.IsNullOrEmpty(enderecoModel.Cep))
            {
                insertSql.Append(", cep");
                valuesSql.Append(", @Cep");
            }

            insertSql.Append(")");
            valuesSql.Append(")");
            return string.Join(' ', insertSql, valuesSql);
        }
    }
}
