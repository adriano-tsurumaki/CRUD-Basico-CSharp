using CRUD___Adriano.Features.Configuration.Login.Model;
using Dapper;
using System;
using System.Data;
using System.Linq;

namespace CRUD___Adriano.Features.Configuration.Login.Dao
{
    public class LoginDao
    {
        private IDbConnection _conexao;

        public LoginDao(IDbConnection conexao)
        {
            _conexao = conexao;
        }

        public bool VerificarSeExisteUsuarioJaConectado()
        {
            try
            {
                _conexao.Open();

                var usuarioSistemaModel = _conexao.QueryFirstOrDefault<UsuarioSistemaModel>("select manter_logado as ManterLogado from Login_Sistema");
                    
                if (usuarioSistemaModel == null) return false;

                return usuarioSistemaModel.ManterLogado;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public bool ValidarLogin(UsuarioSistemaModel usuarioSistemaModel)
        {
            usuarioSistemaModel.IdUsuarioSistema = SelecionarIdDoUsuarioSistema(usuarioSistemaModel);
            
            if (usuarioSistemaModel.IdUsuarioSistema == 0) return false;

            if (!VerificarSeUsuarioSistemaEstaRegistradoNoLoginSistema(usuarioSistemaModel.IdUsuarioSistema))
                RegistrarUsuarioSistemaNoLoginSistema(usuarioSistemaModel);
            else
                AtualizarUsuarioSistemaNoLoginSistema(usuarioSistemaModel);

            return true;
        }

        private int SelecionarIdDoUsuarioSistema(UsuarioSistemaModel usuarioSistemaModel)
        {
            try
            {
                _conexao.Open();

                return _conexao.QuerySingleOrDefault<int>("select id from Usuario_Sistema where nome = @Nome and senha = @Senha", usuarioSistemaModel);
            }
            finally
            {
                _conexao.Close();
            }
        }

        private bool VerificarSeUsuarioSistemaEstaRegistradoNoLoginSistema(int id)
        {
            try
            {
                _conexao.Open();

                return _conexao.Query<bool>("select Count(*) from Login_Sistema where id_usuario_sistema = @id", new { id }).FirstOrDefault();
            }
            finally
            {
                _conexao.Close();
            }
        }

        private void RegistrarUsuarioSistemaNoLoginSistema(UsuarioSistemaModel usuarioSistemaModel)
        {
            try
            {
                _conexao.Open();
                _conexao.Execute("insert into Login_Sistema (id_usuario_sistema, manter_logado) values (@IdUsuarioSistema, @ManterLogado)", usuarioSistemaModel);
            }
            finally
            {
                _conexao.Close();
            }
        }

        private void AtualizarUsuarioSistemaNoLoginSistema(UsuarioSistemaModel usuarioSistemaModel)
        {
            try
            {
                _conexao.Open();

                _conexao.Execute(@"update Login_Sistema 
                                set id_usuario_sistema = @IdUsuarioSistema, 
                                manter_logado = @ManterLogado",
                                usuarioSistemaModel);
            }
            finally
            {
                _conexao.Close();
            }
        }

        public void Deslogar()
        {
            try
            {
                _conexao.Open();
                _conexao.Execute("delete Login_Sistema");
            }
            finally
            {
                _conexao.Close();
            }
        }

        public string RetornarUsuarioLogadoSomenteNome()
        {
            try
            {
                _conexao.Open();
                return _conexao.QuerySingleOrDefault<string>(@"select us.nome from Login_Sistema ls 
                                        inner join Usuario_Sistema us 
                                        on us.id = ls.id_usuario_sistema");
            }
            finally
            {
                _conexao.Close();
            }
        }
    }
}
