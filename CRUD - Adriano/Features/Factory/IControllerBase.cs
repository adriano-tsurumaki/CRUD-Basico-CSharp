using System.Collections.Generic;

namespace CRUD___Adriano.Features.Factory
{
    public interface IControllerBase<T> where T : class
    {
        bool Salvar(T entidade);

        IList<T> Listar();

        IList<T> Listar(int quantidade);

        bool Atualizar(int id);

        T Selecionar(int id);

        bool Remover(int id);
    }
}
