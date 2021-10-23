﻿using CRUD___Adriano.Features.Cadastro.Produto.Model;
using Dapper.FluentMap.Mapping;

namespace CRUD___Adriano.Features.Cliente.Model
{
    public class ClienteMap : EntityMap<ClienteModel>
    {
        public ClienteMap()
        {
            Map(x => x.IdUsuario).ToColumn("id", caseSensitive: false);
            Map(x => x.ValorLimite).ToColumn("valor_limite", caseSensitive: false);
        }
    }
}
