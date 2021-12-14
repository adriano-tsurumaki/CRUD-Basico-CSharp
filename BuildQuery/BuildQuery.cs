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

    //TODO: Mudar a chave do _dictionaryAlias para um GUID!
    public partial class BuildQuery<TPrincipalTable> where TPrincipalTable : class
    {
        private Dictionary<Type, string> _dictionaryAlias;

        private IList<SelectModel> _listSelects;

        private IList<InnerJoinModel> _listInnerJoins;

        private IList<Expression> _listWheres;

        private IList<TableModel> _tables;

        public BuildQuery()
        {
            _dictionaryAlias = new Dictionary<Type, string>();

            Type tipo = typeof(TPrincipalTable);

            _dictionaryAlias.Add(tipo, GenerateAlias());

            var innerJoin = new InnerJoinModel();

            innerJoin.SetType(tipo);
            innerJoin.SetPrincipal(true);

            _listInnerJoins = new List<InnerJoinModel> { innerJoin };
            _listSelects = new List<SelectModel>();
            _listWheres = new List<Expression>();

            _tables = new List<TableModel>
            {
                new TableModel
                {
                    Principal = true,
                    Alias = GenerateAlias(),
                    Name = tipo.Name,
                    Type = tipo,
                }
            };
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
                    PropertyInfo = informacaoDaPropriedade,
                    ColumnName = informacaoDaPropriedade.Name
                };

                //------------------------------------------------------------------------------
                _tables.First(x => x.Principal == true).Selects.Add(select);
                //------------------------------------------------------------------------------

                if (!tipo.IsSubclassOf(informacaoDaPropriedade.ReflectedType))
                    select.Principal = true;

                _listSelects.Add(select);
            }

            return this;
        }

        public BuildQuery<TPrincipalTable> Select<TOtherTable>(params Expression<Func<TOtherTable, object>>[] argsPropriedade)
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

                //------------------------------------------------------------------------------
                if (_tables.Any(x => x.Type == typeof(TOtherTable)))
                    _tables.First(x => x.Type == typeof(TOtherTable)).Selects.Add(select);
                else
                {
                    var table = new TableModel
                    {
                        Alias = GenerateAlias(),
                        Name = tipo.Name,
                        Type = tipo,
                    };

                    table.Selects.Add(select);

                    _tables.Add(table);
                }
                //------------------------------------------------------------------------------

                if (!tipo.IsSubclassOf(informacaoDaPropriedade.ReflectedType))
                    select.Principal = true;

                _listSelects.Add(select);
            }

            return this;
        }


        public BuildQuery<TPrincipalTable> Select(string names, params Expression<Func<TPrincipalTable, object>>[] argsPropriedades)
        {
            var listNames = names.Split(",");

            if (listNames.Count() != argsPropriedades.Count())
                throw new ArgumentException($"A quantidade de nomes estabelecidos não é igual a quantidade de propriedades passadas no parâmetros");

            var zip = listNames.Zip(argsPropriedades, (n, a) => new { name = n, propriedade = a });

            foreach (var arquivo in zip)
            {
                Type tipo = typeof(TPrincipalTable);

                var informacaoDaPropriedade = ReflectionHelper.GetMemberInfo(arquivo.propriedade) as PropertyInfo;

                if (informacaoDaPropriedade.MemberType != MemberTypes.Property)
                    throw new ArgumentException($"A expressão {informacaoDaPropriedade} não é uma propriedade, é {informacaoDaPropriedade.MemberType}!");

                var select = new SelectModel
                {
                    Type = tipo,
                    PropertyInfo = informacaoDaPropriedade,
                    ColumnName = arquivo.name.Trim()
                };

                //------------------------------------------------------------------------------
                if (_tables.Any(x => x.Type == typeof(TPrincipalTable)))
                    _tables.First(x => x.Type == typeof(TPrincipalTable)).Selects.Add(select);
                else
                {
                    var table = new TableModel
                    {
                        Alias = GenerateAlias(),
                        Name = tipo.Name,
                        Type = tipo,
                    };

                    table.Selects.Add(select);

                    _tables.Add(table);
                }
                //------------------------------------------------------------------------------

                if (!tipo.IsSubclassOf(informacaoDaPropriedade.ReflectedType))
                    select.Principal = true;

                _listSelects.Add(select);
            }

            return this;
        }

        public BuildQuery<TPrincipalTable> InnerJoin<TOtherTable>(
            Expression<Func<TOtherTable, object>> expressaoOtherTable,
            Expression<Func<TPrincipalTable, object>> expressaoPrincipalTable)
        {
            SetInnerJoin(expressaoOtherTable, expressaoPrincipalTable);

            return this;
        }

        public BuildQuery<TPrincipalTable> InnerJoin<TOtherTable, TComparedTable>(
            Expression<Func<TOtherTable, object>> expressaoOtherTable,
            Expression<Func<TComparedTable, object>> expressaoComparedTable)
        {
            SetInnerJoin(expressaoOtherTable, expressaoComparedTable);

            return this;
        } 

        public BuildQuery<TPrincipalTable> Where(
            Expression<Func<TPrincipalTable, object>> expressaoPrincipalTable)
        {
            _listWheres.Add(ReflectionHelper.GetExpression(expressaoPrincipalTable));

            return this;
        }

        public BuildQuery<TPrincipalTable> Where<TOtherTable>(
            Expression<Func<TOtherTable, object>> expressaoOtherTable)
        {
            _listWheres.Add(ReflectionHelper.GetExpression(expressaoOtherTable));

            return this;
        }

        public BuildQuery<TPrincipalTable> Where<TOtherTable>(
            Expression<Func<TPrincipalTable, TOtherTable, object>> expressaoTwoTable)
        {
            _listWheres.Add(ReflectionHelper.GetExpression(expressaoTwoTable));

            var i = expressaoTwoTable.Body as BinaryExpression;

            return this;
        }

        public string Build()
        {
            ValidarInnerJoins();

            var select = BuildSelect();
            var from = BuildFrom();
            var innerJoin = BuildInnerJoin();
            var where = BuildWhere();

            var build = new StringBuilder();

            build.AppendLine(select.ToString());
            build.Append(from.ToString());
            build.Append(innerJoin.ToString());
            build.Append(where.ToString());

            return build.ToString();
        }

        private StringBuilder BuildSelect()
        {
            var select = new StringBuilder().AppendLine("select");

            foreach(var item in new SelectFactory().CreateBuilders(_tables))
                select.Append(item.Build());

            select.Remove(select.Length - 3, 3);

            return select;
        }

        private StringBuilder BuildFrom()
        {
            var from = new StringBuilder();

            var tipo = typeof(TPrincipalTable);

            _dictionaryAlias.TryGetValue(tipo, out var alias);

            return from.AppendLine(new FromFactory().CreateBuild(tipo).Build(tipo, alias));
        }

        private StringBuilder BuildInnerJoin()
        {
            var innerJoin = new StringBuilder();

            foreach(var item in new InnerJoinFactory().CreateBuilders(_listInnerJoins))
                innerJoin.AppendLine(item.Build(_dictionaryAlias));

            return innerJoin;
        }

        private StringBuilder BuildWhere()
        {
            var where = new StringBuilder().AppendLine("where");

            foreach (var item in new WhereFactory().CreateBuilders(_dictionaryAlias.Keys.ToList()))
                where.AppendLine(item.Build());

            return where;
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
}
