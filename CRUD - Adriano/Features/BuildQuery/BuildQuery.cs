using CRUD___Adriano.Features.Cadastro.Produto.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace CRUD___Adriano.Features.BuildQuery
{
    public class BuildQuery<T> where T : class, new()
    {
        private IList<PropertyInfo> propriedadesDaTabela;

        public BuildQuery()
        {
            propriedadesDaTabela = new List<PropertyInfo>();
        }

        public BuildQuery<T> Select<TProperty>(Expression<Func<T, TProperty>> propriedade)
        {
            Type tipo = typeof(T);

            var membro = propriedade.Body as MemberExpression;

            if (membro == null)
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a method, not a property.",
                    propriedade.ToString()));

            var informacaoDaPropriedade = membro.Member as PropertyInfo; 
            if (informacaoDaPropriedade == null)
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a field, not a property.",
                    propriedade.ToString()));

            if (tipo != informacaoDaPropriedade.ReflectedType &&
                !tipo.IsSubclassOf(informacaoDaPropriedade.ReflectedType))
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a property that is not from type {1}.",
                    propriedade.ToString(),
                    tipo));

            propriedadesDaTabela.Add(informacaoDaPropriedade);

            return this;
        }

        public BuildQuery<T> SelectOut<TOtherTable>(Expression<Func<TOtherTable, IComparable>> propriedade)
        {
            Type tipo = typeof(TOtherTable);

            var membro = propriedade.Body as MemberExpression;

            if (membro == null)
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a method, not a property.",
                    propriedade.ToString()));

            var informacaoDaPropriedade = membro.Member as PropertyInfo;
            if (informacaoDaPropriedade == null)
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a field, not a property.",
                    propriedade.ToString()));

            if (tipo != informacaoDaPropriedade.ReflectedType &&
                !tipo.IsSubclassOf(informacaoDaPropriedade.ReflectedType))
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a property that is not from type {1}.",
                    propriedade.ToString(),
                    tipo));

            propriedadesDaTabela.Add(informacaoDaPropriedade);

            return this;
        }
    }
}
