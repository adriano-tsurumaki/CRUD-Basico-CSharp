using CRUD___Adriano.Features.Configuration;
using System;
using System.Data;

namespace CRUD___Adriano.Features.Factory
{
    public class ControllerConexao
    {
        public void EscopoConexao(Action<IDbConnection> acao)
        {
            using(var conexao = SqlConexao.RetornarConexao())
            {
                conexao.Open();
                acao(conexao);
            }
        }

        public void EscopoTransacao(Action<IDbConnection, IDbTransaction> acao)
        {
            using (var conexao = SqlConexao.RetornarConexao())
            {
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                {
                    acao(conexao, transacao);
                    transacao.Commit();
                }
            }
        }
    }
}
