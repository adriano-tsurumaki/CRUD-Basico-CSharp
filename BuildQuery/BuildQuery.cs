using BuildQuery.Builder.Factory;
using BuildQuery.Builder.Models;
using BuildQuery.Util;
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

        private Dictionary<Type, string> _dictionaryAlias;

        private IList<SelectModel> _listSelects;

        private IList<InnerJoinModel> _listInnerJoins;

        public BuildQuery()
        {
            _propriedadesDaTabelaPrincipal = new Dictionary<PropertyInfo, string>();
            _propriedadesDasOutrasTabelas = new Dictionary<PropertyInfo, string>();
            _dictionaryAlias = new Dictionary<Type, string>();

            Type tipo = typeof(TPrincipalTable);

            _dictionaryAlias.Add(tipo, GenerateAlias());

            var innerJoin = new InnerJoinModel
            {
                Type = tipo,
                FullName = tipo.FullName,
                Name = tipo.Name,
                Principal = true
            };

            _listInnerJoins = new List<InnerJoinModel> { innerJoin };

            var select = new SelectModel
            {
                Type = tipo,
                Principal = true,
            };

            _listSelects = new List<SelectModel> { select };
        }

        public BuildQuery<TPrincipalTable> Select(params Expression<Func<TPrincipalTable, object>>[] argsPropriedades)
        {
            foreach(var propriedade in argsPropriedades)
            {
                Type tipo = typeof(TPrincipalTable);

                var informacaoDaPropriedade = ReflectionHelper.GetMemberInfo(propriedade) as PropertyInfo;

                if (informacaoDaPropriedade.MemberType != MemberTypes.Property)
                    throw new ArgumentException($"A expressão {informacaoDaPropriedade} não é uma propriedade, é {informacaoDaPropriedade.MemberType}!");

                var select = new SelectModel
                {
                    Type = tipo,
                    PropertyInfo = informacaoDaPropriedade
                };

                if (tipo.IsSubclassOf(informacaoDaPropriedade.ReflectedType))
                    _propriedadesDasOutrasTabelas.Add(informacaoDaPropriedade, informacaoDaPropriedade.Name);
                else
                {
                    select.Principal = true;
                    _propriedadesDaTabelaPrincipal.Add(informacaoDaPropriedade, informacaoDaPropriedade.Name);
                }

                _listSelects.Add(select);
            }

            return this;
        }

        public BuildQuery<TPrincipalTable> SelectOut<TOtherTable>(params Expression<Func<TOtherTable, object>>[] argsPropriedade)
        {
            foreach (var propriedade in argsPropriedade)
            {
                Type tipo = typeof(TOtherTable);

                var informacaoDaPropriedade = ReflectionHelper.GetMemberInfo(propriedade) as PropertyInfo;

                if (informacaoDaPropriedade.MemberType != MemberTypes.Property)
                    throw new ArgumentException($"A expressão {informacaoDaPropriedade} não é uma propriedade, é {informacaoDaPropriedade.MemberType}!");

                var select = new SelectModel
                {
                    Type = tipo,
                    PropertyInfo = informacaoDaPropriedade
                };

                if (tipo.IsSubclassOf(informacaoDaPropriedade.ReflectedType))
                    _propriedadesDasOutrasTabelas.Add(informacaoDaPropriedade, informacaoDaPropriedade.Name);
                else
                {
                    select.Principal = true;
                    _propriedadesDaTabelaPrincipal.Add(informacaoDaPropriedade, informacaoDaPropriedade.Name);
                }

                _listSelects.Add(select);
            }

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

            return build.ToString();
        }

        private StringBuilder BuildSelect()
        {
            var select = new StringBuilder().AppendLine("select");

            foreach(var item in new SelectFactory().CreateBuilders(_listSelects))
                select.AppendLine(item.Build(_dictionaryAlias));

            return select;
        }

        private StringBuilder BuildFrom()
        {
            var from = new StringBuilder("from ");

            //var alias = _listInnerJoins.First(x => x.Principal).Alias;

            //if (BuildQueryMapper.GetTables().TryGetValue(typeof(TPrincipalTable), out var nome))
            //    from.AppendLine($"{nome.TableName} as {alias}");
            //else
            //    throw new ArgumentException("");

            return from;
        }

        private StringBuilder BuildInnerJoin()
        {
            var innerJoin = new StringBuilder();

            foreach(var item in new InnerJoinFactory().CreateBuilders(_listInnerJoins))
                innerJoin.AppendLine(item.Build(_dictionaryAlias));

            return innerJoin;
        }

        private string TrimAllExcessWhiteSpace(string valor) =>
            new Regex(@"\s\s+").Replace(valor, " ");

        public string GenerateAlias()
        {
            const string chars = "abcdeghijklmnorpqrstuvwxyz";
            while (true)
            {
                var random = new Random();

                var alias = new string(Enumerable.Repeat(chars, 2).Select(s => s[random.Next(s.Length)]).ToArray());

                if (!_dictionaryAlias.Any(x => x.Value == alias))
                    return alias;
                else
                    return GenerateAlias();
            }
        }
    }

    public class InnerJoinModel
    {
        public string NameTable { get; set; }
        public Type Type { get; set; }
        public Type TypeCompared { get; set; }
        public bool Principal { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string KeyPrimary { get; private set; }
        public string KeyCompared { get; private set; }

        public InnerJoinModel()
        {
            Principal = false;
        }

        public void SetKeyPrimary(string keyPrimary) =>
            KeyPrimary = keyPrimary;

        public void SetKeyCompared(string keyCompared) =>
            KeyCompared = keyCompared;
    }
}
