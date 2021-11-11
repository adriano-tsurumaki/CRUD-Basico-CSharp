using System.Collections.Generic;

namespace CRUD___Adriano.Features.Factory
{
    public interface IControllerBase<T> where T : class
    {
        bool Salvar(T entidade);

        IList<T> Listar();

        bool Atualizar(T entidade);

        T Selecionar(int id);

        bool Remover(int id);
    }

    public enum ControllerEnum
    {
        Salvar = 1,
        Listar = 2,
        Atualizar = 3,
        Remover = 4
    }
}
