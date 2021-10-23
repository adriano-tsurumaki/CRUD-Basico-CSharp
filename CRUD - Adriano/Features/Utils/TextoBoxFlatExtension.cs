﻿using CRUD___Adriano.Features.Componentes;

namespace CRUD___Adriano.Features.Utils
{
    public static class TextoBoxFlatExtension
    {
        public static bool NuloOuVazio(this TextBoxFlat textoBox) =>
            string.IsNullOrEmpty(textoBox.Texto);

        public static bool Numerico(this TextBoxFlat textoBox) =>
            int.TryParse(textoBox.Texto, out _);
    }
}
