using System.Collections.Generic;

namespace CRUD___Adriano.Features.Factory
{
    public interface IViewPage<T>
    {
        bool ValidarComponentes();

        void BindModel(ref T entidade);
    }
}
