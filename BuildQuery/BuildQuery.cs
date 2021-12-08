using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace BuildQuery
{
    public partial class BuildQuery<T> where T : class, new()
    {
        private IList<PropertyInfo> propriedadesDaTabelaPrincipal;
        private IList<PropertyInfo> propriedadesDasOutrasTabelas;

        private IList<string> innerJoinNomes;

        public BuildQuery()
        {
            propriedadesDaTabelaPrincipal = new List<PropertyInfo>();
            propriedadesDasOutrasTabelas = new List<PropertyInfo>();
            innerJoinNomes = new List<string>();
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

            propriedadesDaTabelaPrincipal.Add(informacaoDaPropriedade);

            return this;
        }

        public BuildQuery<T> SelectOut<TOtherTable>(Expression<Func<TOtherTable, object>> propriedade)
        {
            Type tipo = typeof(TOtherTable);

            var lambda = propriedade as LambdaExpression;

            MemberExpression membro;

            if (lambda.Body is UnaryExpression)
            {
                var unaryExpression = lambda.Body as UnaryExpression;
                membro = unaryExpression.Operand as MemberExpression;
            }
            else
                membro = propriedade.Body as MemberExpression;


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

            propriedadesDasOutrasTabelas.Add(informacaoDaPropriedade);

            return this;
        }

        public BuildQuery<T> InnerJoin<TOtherTable>()
        {
            var tipo = typeof(TOtherTable);

            innerJoinNomes.Add(tipo.FullName);

            return this;
        }

        public string Build()
        {
            foreach (var propriedade in propriedadesDasOutrasTabelas)
            {
                if (!innerJoinNomes.Any(x => x == propriedade.ReflectedType.FullName))
                {
                    throw new ArgumentException(string.Format(
                    "Não foi especificado a tabela para a coluna {0}",
                    propriedade.Name));
                }
            }

            return "";
        }
    }
}
