using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Usuario.Model;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CRUD___Adriano.Features.Cliente.Controller
{
    public class ClienteController : IControllerFactory
    {
        public void Atualizar(int id)
        {
            
        }

        public IList<T> Listar<T>(int quantidade)
        {
            throw new System.NotImplementedException();
        }

        public void Salvar<T>(T entidade)
        {

        }

        public T Selecionar<T>(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
