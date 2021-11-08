using System;
using System.Data;

namespace CRUD___Adriano.Features.Factory
{
    public class ControllerConexao
    {
        private IDbConnection _conexao;

        public ControllerConexao(IDbConnection conexao)
        {
            _conexao = conexao;
        }

        public void EscopoConexao(Action<IDbConnection> acao)
        {
            try
            {
                _conexao.Open();
                acao(_conexao);
            }
            catch(Exception excecao)
            {
                throw excecao;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public T EscopoConexaoComRetorno<T>(Func<IDbConnection, T> acao)
        {
            try
            {
                _conexao.Open();
                return acao(_conexao);
            }
            finally
            {
                _conexao.Close();
            }
        }

        public void EscopoTransacao(Action<IDbConnection, IDbTransaction> acao)
        {
            try
            {
                _conexao.Open();
                
                using var transacao = _conexao.BeginTransaction();
                
                acao(_conexao, transacao);
                transacao.Commit();
            }
            finally
            {
                _conexao.Close();
            }
        }

        public T EscopoTransacaoComRetorno<T>(Func<IDbConnection, IDbTransaction, T> acao)
        {
            try
            {
                _conexao.Open();
                
                using var transacao = _conexao.BeginTransaction();

                var resultado = acao(_conexao, transacao);
                transacao.Commit();
                return resultado;
            }
            finally
            {
                _conexao.Close();
            }
        }
    }
}
