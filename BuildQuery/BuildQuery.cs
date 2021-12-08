using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace BuildQuery
{
    public partial class BuildQuery<TPrincipalTable> where TPrincipalTable : class
    {
        private IList<PropertyInfo> _propriedadesDaTabelaPrincipal;
        private IList<PropertyInfo> _propriedadesDasOutrasTabelas;

        private IList<InnerJoinBuilder> _listInnerJoin;

        public BuildQuery()
        {
            _propriedadesDaTabelaPrincipal = new List<PropertyInfo>();
            _propriedadesDasOutrasTabelas = new List<PropertyInfo>();

            Type tipo = typeof(TPrincipalTable);

            var innerJoin = new InnerJoinBuilder
            {
                FullName = tipo.FullName,
                Name = tipo.Name,
                Principal = true
            };

            innerJoin.SetAlias(innerJoin.GenerateAlias());

            _listInnerJoin = new List<InnerJoinBuilder>();
            _listInnerJoin.Add(innerJoin);
        }

        public BuildQuery<TPrincipalTable> Select<TProperty>(Expression<Func<TPrincipalTable, TProperty>> propriedade)
        {
            Type tipo = typeof(TPrincipalTable);

            var membro = propriedade.Body as MemberExpression;

            var informacaoDaPropriedade = ValidarERetornarPropriedadeDaTabela(tipo, membro, propriedade);

            if (tipo.IsSubclassOf(informacaoDaPropriedade.ReflectedType))
                _propriedadesDasOutrasTabelas.Add(informacaoDaPropriedade);
            else
                _propriedadesDaTabelaPrincipal.Add(informacaoDaPropriedade);

            return this;
        }

        public BuildQuery<TPrincipalTable> SelectOut<TOtherTable>(Expression<Func<TOtherTable, object>> propriedade)
        {
            Type tipo = typeof(TOtherTable);

            var lambda = propriedade as LambdaExpression;

            var membro = RetornarMemberExpression(propriedade, lambda);

            _propriedadesDasOutrasTabelas.Add(ValidarERetornarPropriedadeDaTabela(tipo, membro, lambda));

            return this;
        }

        public BuildQuery<TPrincipalTable> InnerJoin<TOtherTable>(
            Expression<Func<TOtherTable, object>> expressaoOtherTable,
            Expression<Func<TPrincipalTable, object>> expressaoPrincipalTable)
        {
            ValidateInnerJoin(expressaoOtherTable, expressaoPrincipalTable);

            return this;
        }

        public BuildQuery<TPrincipalTable> InnerJoin<TOtherTable, TComparedTable>(
            Expression<Func<TOtherTable, object>> expressaoOtherTable,
            Expression<Func<TComparedTable, object>> expressaoComparedTable)
        {
            ValidateInnerJoin(expressaoOtherTable, expressaoComparedTable);

            return this;
        }

        public string Build()
        {
            ValidarInnerJoins();

            return "";
        }
    }

    public class InnerJoinBuilder
    {
        public bool Principal { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string KeyPrimary { get; private set; }
        public string KeyCompared { get; private set; }
        public string Alias { get; private set; }
        public string AliasCompared { get; private set; }
        public string On 
        {
            get
            {
                if (string.IsNullOrEmpty(Alias))
                    throw new ArgumentException(string.Format("Não foi gerado o apelido para o {0}", FullName));
                else
                    return string.Format("{0}.{1} = {2}.{3}", Alias, KeyPrimary, AliasCompared, KeyCompared);
            }
        }

        public InnerJoinBuilder()
        {
            Principal = false;
        }

        public void SetKeyPrimary(string keyPrimary) =>
            KeyPrimary = keyPrimary;

        public void SetKeyCompared(string keyCompared) =>
            KeyCompared = keyCompared;

        public void SetAlias(string alias) =>
            Alias = alias;

        public void SetAliasCompared(string aliasCompared) =>
            AliasCompared = aliasCompared;

        public string GenerateAlias()
        {
            var random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdeghijklmnorpqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, 3)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
