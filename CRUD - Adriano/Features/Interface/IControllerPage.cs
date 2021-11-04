using CRUD___Adriano.Features.Factory;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Interface
{
    public interface IControllerPage<T>
    {
        bool ValidarForm();

        void AdicionarModel(ref T entidade);

        IViewPage<T> RetornarFormulario();
    }
}
