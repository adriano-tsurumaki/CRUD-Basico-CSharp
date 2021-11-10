﻿using CRUD___Adriano.Features.Fornecedor.Model;
using Dapper;
using System.Text;

namespace CRUD___Adriano.Features.Fornecedor.Sql
{
    public static class FornecedorSql
    {
        public static string InserirFornecedor(FornecedorModel fornecedorModel)
        {
            var insertSql = new StringBuilder("insert into Fornecedor(id_usuario, cnpj");
            var valuesSql = new StringBuilder("values (@IdUsuario, @Cnpj");

            if (!string.IsNullOrEmpty(fornecedorModel.Observacao))
            {
                insertSql.Append(", observacao");
                valuesSql.Append(", @Observacao");
            }

            insertSql.Append(")");
            valuesSql.Append(")");
            return string.Join(' ', insertSql, valuesSql);
        }

        public static object RetornarParametroDinamicoParaInserirUm(FornecedorModel fornecedorModel)
        {
            var parametros = new DynamicParameters();

            parametros.AddDynamicParams(new
            {
                fornecedorModel.Observacao,
                Cnpj = fornecedorModel.Cnpj.ToString(),
            });

            return parametros;
        }
    }
}
