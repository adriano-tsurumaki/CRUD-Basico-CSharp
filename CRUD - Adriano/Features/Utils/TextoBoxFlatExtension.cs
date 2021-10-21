using CRUD___Adriano.Features.Componentes;

namespace CRUD___Adriano.Features.Utils
{
    public static class TextoBoxFlatExtension
    {
        public static bool NuloOuVazio(this TextBoxFlat textoBox) =>
            string.IsNullOrEmpty(textoBox.Texto);
    }
}
