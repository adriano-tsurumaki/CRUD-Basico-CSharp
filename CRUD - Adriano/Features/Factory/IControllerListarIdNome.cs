using System.Collections.Generic;

namespace CRUD___Adriano.Features.Factory
{
    public interface IControllerListarIdNome<T> where T : class
    {
        public IList<T> ListarSomenteIdENome();

        IList<T> ListarPelaQuantidadeSomenteIdENome(int quantidade);

        IList<T> ListarPeloNomeSomenteIdENome(string nome);
    }
}
