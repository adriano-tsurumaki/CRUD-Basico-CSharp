using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CRUD___Adriano.Features.Factory
{
    public interface IControllerBase<T> where T : class
    {
        void Salvar(T entidade);

        IList<T> Listar(int quantidade);

        void Atualizar(int id);

        T Selecionar(int id);
    }
}
