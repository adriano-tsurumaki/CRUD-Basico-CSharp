﻿using CRUD___Adriano.Features.Telefone.Enum;

namespace CRUD___Adriano.Features.Telefone.Model
{
    public class TelefoneModel
    {
        public string Numero { get; set; }
        public TipoTelefoneEnum Tipo { get; set; }
    }
}
