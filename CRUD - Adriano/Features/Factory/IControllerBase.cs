using System.Collections.Generic;

namespace CRUD___Adriano.Features.Factory
{
    public interface IControllerBase<T> where T : class
    {
        void Salvar(T entidade);

        IList<T> Listar();

        IList<T> Listar(int quantidade);

        void Atualizar(int id);

        T Selecionar(int id);
    }
}
