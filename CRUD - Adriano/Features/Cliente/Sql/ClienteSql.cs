﻿using CRUD___Adriano.Features.Cadastro.Produto.Model;
using Dapper;
using System.Text;

namespace CRUD___Adriano.Features.Cliente.Sql
{
    public static class ClienteSql
    {
        public static readonly string ListarTodos =
            @"select u.id as IdUsuario, u.nome, u.sobrenome, u.sexo, u.cpf, u.data_nascimento as DataNascimento, c.valor_limite as ValorLimite, c.observacao,
            c.id as split, en.id_usuario as IdUsuario, en.cep, en.logradouro, en.bairro, en.cidade, en.uf, en.complemento, en.numero
			from Cliente c
			inner join Usuario u on u.id = c.id_usuario
			inner join Endereco en on en.id_usuario = u.id";

        public static readonly string ListarTodosComCamposSomenteIdENome =
            @"select u.id as IdUsuario, u.nome
			from Cliente c
			inner join Usuario u on u.id = c.id_usuario";
        
        public static readonly string ListarPeloNomeComCamposSomenteIdENome =
            @"select u.id as IdUsuario, u.nome
			from Cliente c
			inner join Usuario u on u.id = c.id_usuario
            where u.nome Like @Nome + '%'";

        public static readonly string ListarPelaQuantidadeComCamposSomenteIdENome =
            @"select top {=Quantidade} u.id as IdUsuario, u.nome
            from Cliente c
			inner join Usuario u on u.id = c.id_usuario";

        public static DynamicParameters RetornarParametroDinamicoDaModel(ClienteModel clienteModel)
        {
            var parametros = new DynamicParameters();

            parametros.AddDynamicParams(new
            {
                clienteModel.IdUsuario,
                clienteModel.Id,
                ValorLimite = clienteModel.ValorLimite.Valor,
                clienteModel.Observacao
            });

            return parametros;
        }

        public static readonly string SelecionarComCamposSomenteIdENome =
            @"select u.id as IdUsuario, u.nome
			from Cliente c
			inner join Usuario u on u.id = c.id_usuario
			where u.id = @id";

        public static readonly string Selecionar =
           @"select u.id as IdUsuario, u.nome, u.sobrenome, u.sexo, u.cpf, u.data_nascimento as DataNascimento, c.valor_limite as ValorLimite, c.observacao
			from Cliente c
			inner join Usuario u on u.id = c.id_usuario
            where u.id = @id";

        public static readonly string SelecionarQuantidadeDeTodos =
            @"select count(*) from Cliente";

        public static readonly string SelecionarEmail =
            @"select e.id, e.nome from Email e
            inner join Usuario u on u.id = e.id_usuario
            where u.id = @id";

        public static readonly string ValorLimiteRestante = 
            @"select u.nome, c.valor_limite - sum(fp.valor_pago) as ValorLimite from Venda v
            inner join Usuario u on u.id = v.id_cliente
            inner join Cliente c on c.id_usuario = u.id
            inner join FormaPagamento fp on fp.id_venda = v.id
            where fp.tipo_pagamento <> 1 and fp.tipo_pagamento <> 2 and u.id = @IdUsuario
            group by u.nome, c.valor_limite";

        public static readonly string ValorLimite =
            @"select valor_limite as ValorLimite from Cliente where id_usuario = @IdUsuario";

        public static string Inserir(ClienteModel clienteModel)
        {
            var insertSql = new StringBuilder("insert into Cliente(id_usuario, valor_limite");
            var valuesSql = new StringBuilder("values (@IdUsuario, @ValorLimite");

            if (!string.IsNullOrEmpty(clienteModel.Observacao))
            {
                insertSql.Append(", observacao");
                valuesSql.Append(", @Observacao");
            }

            insertSql.Append(")");
            valuesSql.Append(")");
            return string.Join(' ', insertSql, valuesSql);
        }

        public static string Atualizar(ClienteModel clienteModel)
        {
            var updateSql = new StringBuilder(@"update Cliente set 
            valor_limite = @ValorLimite");

            if (!string.IsNullOrEmpty(clienteModel.Observacao))
                updateSql.Append(", observacao = @Observacao ");

            updateSql.Append(" where id_usuario = @IdUsuario");

            return updateSql.ToString();
        }
    }
}
