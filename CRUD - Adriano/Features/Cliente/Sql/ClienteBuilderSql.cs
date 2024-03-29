﻿using BuildQuery;
using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Usuario.Model;

namespace CRUD___Adriano.Features.Cliente.Sql
{
    public class ClienteBuilderSql
    {
        public static string ListarTodosComCamposSomenteIdENome() =>
            new BuildQuery<ClienteModel>()
            .Select<UsuarioModel>(u => u.IdUsuario, u => u.Nome)
            .InnerJoin<UsuarioModel>(u => u.IdUsuario, c => c.IdUsuario)
            .Build();

        public static string Selecionar() =>
            new BuildQuery<ClienteModel>()
            .Select(c => c.ValorLimite, c => c.Observacao)
            .Select<UsuarioModel>(u => u.IdUsuario, u => u.Nome, u => u.Sobrenome, u => u.Sexo, u => u.Cpf, u => u.DataNascimento)
            .InnerJoin<UsuarioModel>(u => u.IdUsuario, c => c.IdUsuario)
            .Where<UsuarioModel>(u => u.IdUsuario)
            .Build();
    }
}
