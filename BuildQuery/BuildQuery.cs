using BuildQuery.Builder.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace BuildQuery
{
    public partial class BuildQuery<TPrincipalTable> where TPrincipalTable : class
    {
        private Dictionary<PropertyInfo, string> _propriedadesDaTabelaPrincipal;
        private Dictionary<PropertyInfo, string> _propriedadesDasOutrasTabelas;

        private IList<InnerJoinModel> _listInnerJoin;

        public BuildQuery()
        {
            _propriedadesDaTabelaPrincipal = new Dictionary<PropertyInfo, string>();
            _propriedadesDasOutrasTabelas = new Dictionary<PropertyInfo, string>();

            Type tipo = typeof(TPrincipalTable);

            var innerJoin = new InnerJoinModel
            {
                Type = typeof(TPrincipalTable),
                FullName = tipo.FullName,
                Name = tipo.Name,
                Principal = true
            };

            innerJoin.SetAlias(innerJoin.GenerateAlias());

            _listInnerJoin = new List<InnerJoinModel> { innerJoin };
        }

        public BuildQuery<TPrincipalTable> Select<TProperty>(Expression<Func<TPrincipalTable, TProperty>> propriedade)
        {
            Type tipo = typeof(TPrincipalTable);

            var membro = propriedade.Body as MemberExpression;

            var informacaoDaPropriedade = ValidarERetornarPropriedadeDaTabela(tipo, membro, propriedade);

            if (tipo.IsSubclassOf(informacaoDaPropriedade.ReflectedType))
                _propriedadesDasOutrasTabelas.Add(informacaoDaPropriedade, informacaoDaPropriedade.Name);
            else
                _propriedadesDaTabelaPrincipal.Add(informacaoDaPropriedade, informacaoDaPropriedade.Name);

            return this;
        }

        public BuildQuery<TPrincipalTable> Select<TProperty>(Expression<Func<TPrincipalTable, TProperty>> propriedade, string nomeDaColuna)
        {
            Type tipo = typeof(TPrincipalTable);

            var membro = propriedade.Body as MemberExpression;

            var informacaoDaPropriedade = ValidarERetornarPropriedadeDaTabela(tipo, membro, propriedade);

            if (tipo.IsSubclassOf(informacaoDaPropriedade.ReflectedType))
                _propriedadesDasOutrasTabelas.Add(informacaoDaPropriedade, nomeDaColuna);
            else
                _propriedadesDaTabelaPrincipal.Add(informacaoDaPropriedade, nomeDaColuna);

            return this;

        }

        public BuildQuery<TPrincipalTable> SelectOut<TOtherTable>(Expression<Func<TOtherTable, object>> propriedade)
        {
            Type tipo = typeof(TOtherTable);

            var lambda = propriedade as LambdaExpression;

            var membro = RetornarMemberExpression(propriedade, lambda);

            var informacaoDaPropriedade = ValidarERetornarPropriedadeDaTabela(tipo, membro, lambda);

            _propriedadesDasOutrasTabelas.Add(informacaoDaPropriedade, informacaoDaPropriedade.Name);

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

            var select = BuildSelect();
            var from = BuildFrom();
            var innerJoin = BuildInnerJoin();

            var build = new StringBuilder();

            build.AppendLine(select.ToString());
            build.AppendLine(from.ToString());
            build.AppendLine(innerJoin.ToString());

            return TrimAllExcessWhiteSpace(build.ToString());
        }

        private StringBuilder BuildSelect()
        {
            var select = new StringBuilder("select ");

            var alias = _listInnerJoin.Where(x => x.Principal).First().Alias;

            foreach (var item in _propriedadesDaTabelaPrincipal)
            {
                select.AppendLine($"{alias}.{item.Value},");
            }

            foreach (var item in _propriedadesDasOutrasTabelas)
            {
                var aliasOther = _listInnerJoin.Where(x => x.FullName == item.Key.ReflectedType.FullName).First().Alias;
                select.AppendLine($"{aliasOther}.{item.Value},");
            }

            select.Remove(select.Length - 3, 3);

            return select;
        }

        private StringBuilder BuildFrom()
        {
            var from = new StringBuilder("from ");

            var alias = _listInnerJoin.First(x => x.Principal).Alias;

            //if (BuildQueryMapper.GetTables().TryGetValue(typeof(TPrincipalTable), out var nome))
            //    from.AppendLine($"{nome.TableName} as {alias}");
            //else
            //    throw new ArgumentException("");

            return from;
        }

        private StringBuilder BuildInnerJoin()
        {
            var innerJoin = new StringBuilder();

            foreach(var item in new InnerJoinFactory().CreateBuilders(_listInnerJoin))
                innerJoin.AppendLine(item.Build());

            return innerJoin;
        }

        private string TrimAllExcessWhiteSpace(string valor) =>
            new Regex(@"\s\s+").Replace(valor, " ");
    }

    public class InnerJoinModel
    {
        public Type Type { get; set; }
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

        public InnerJoinModel()
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

            const string chars = "abcdeghijklmnorpqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, 2)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
