using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD___Adriano.Features.Factory
{
    public interface IControllerFactory
    {
        void Salvar<T>(T entidade);

        IList<T> Listar<T>(int quantidade);

        void Atualizar(int id);

        T Selecionar<T>(int id);
    }
}
