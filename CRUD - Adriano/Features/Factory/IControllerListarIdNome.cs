using System.Collections.Generic;

namespace CRUD___Adriano.Features.Factory
{
    public interface IControllerListarIdNome<T> where T : class
    {
        public IList<T> ListarSomenteIdENome();

        public IList<T> ListarPelaQuantidadeSomenteIdENome(int quantidade);

        public IList<T> ListarPeloNomeSomenteIdENome(string nome);

        public T SelecionarPeloIdSomenteIdENome(int id);
    }
}
