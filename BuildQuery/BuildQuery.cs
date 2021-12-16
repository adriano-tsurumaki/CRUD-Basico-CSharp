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
        private IList<TableModel> _tables;

        public string Splitter { get; private set; }

        public BuildQuery()
        {
            Type tipo = typeof(TPrincipalTable);

            Splitter = "split";

            _tables = new List<TableModel>();

            _tables.Add(new TableModel
            {
                Principal = true,
                Alias = GenerateAlias(),
                Name = tipo.Name,
                Type = tipo,
            });
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
                    PropertyInfo = informacaoDaPropriedade,
                    ColumnName = informacaoDaPropriedade.Name
                };

                _tables.First(x => x.Principal == true).Selects.Add(select);
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
                    PropertyInfo = informacaoDaPropriedade,
                    ColumnName = informacaoDaPropriedade.Name
                };

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
                    PropertyInfo = informacaoDaPropriedade,
                    ColumnName = arquivo.name.Trim()
                };

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
            }

            return this;
        }

        public BuildQuery<TPrincipalTable> Select<TOtherTable>(string names, params Expression<Func<TOtherTable, object>>[] argsPropriedades)
        {
            var listNames = names.Split(",");

            if (listNames.Count() != argsPropriedades.Count())
                throw new ArgumentException($"A quantidade de nomes estabelecidos não é igual a quantidade de propriedades passadas no parâmetros");

            var zip = listNames.Zip(argsPropriedades, (n, a) => new { name = n, propriedade = a });

            foreach (var arquivo in zip)
            {
                Type tipo = typeof(TOtherTable);

                var informacaoDaPropriedade = ReflectionHelper.GetMemberInfo(arquivo.propriedade) as PropertyInfo;

                if (informacaoDaPropriedade.MemberType != MemberTypes.Property)
                    throw new ArgumentException($"A expressão {informacaoDaPropriedade} não é uma propriedade, é {informacaoDaPropriedade.MemberType}!");

                var select = new SelectModel
                {
                    PropertyInfo = informacaoDaPropriedade,
                    ColumnName = arquivo.name.Trim()
                };

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
            }

            return this;
        }

        public BuildQuery<TPrincipalTable> Split()
        {
            var tipo = typeof(TPrincipalTable);

            var tableModel = new TableModel()
            {
                Alias = _tables.First(x => x.Principal == true).Alias,
                Type = tipo
            };

            var splitter = new SelectModel()
            {
                ColumnAlias = Splitter,
                ColumnName = _tables.First().Selects.First().ColumnName,
            };

            tableModel.Selects.Add(splitter);
            _tables.Add(tableModel);

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
            Expression<Func<TPrincipalTable, bool>> expressaoPrincipalTable)
        {
            var whereModel = new WhereModel();

            SplitInSmallBinaryExpression(ReflectionHelper.GetExpression(expressaoPrincipalTable), whereModel.ExpressionModels, OperatorWhereEnum.NONE);

            _tables.First(x => x.Principal == true).Wheres.Add(whereModel);

            return this;
        }

        public BuildQuery<TPrincipalTable> Where(
            params Expression<Func<TPrincipalTable, object>>[] argsExpressions)
        {
            var whereModel = new WhereModel();

            foreach (var expression in argsExpressions)
            {
                var model = new ExpressionModel();
                model.SetExpression(ReflectionHelper.GetExpression(expression));
                whereModel.ExpressionModels.Add(model);
            }

            _tables.First(x => x.Principal == true).Wheres.Add(whereModel);

            return this;
        }

        public BuildQuery<TPrincipalTable> Where<TOtherTable>(
            Expression<Func<TOtherTable, bool>> expressaoOtherTable)
        {
            var whereModel = new WhereModel();

            SplitInSmallBinaryExpression(ReflectionHelper.GetExpression(expressaoOtherTable), whereModel.ExpressionModels, OperatorWhereEnum.NONE);
            
            _tables.First(x => x.Type == typeof(TOtherTable)).Wheres.Add(whereModel);

            return this;
        }

        public BuildQuery<TPrincipalTable> Where<TOtherTable>(
            params Expression<Func<TOtherTable, object>>[] argsExpressions)
        {
            var whereModel = new WhereModel();

            foreach (var expression in argsExpressions)
            {
                var model = new ExpressionModel();
                model.SetExpression(ReflectionHelper.GetExpression(expression));
                whereModel.ExpressionModels.Add(model);
            }

            _tables.First(x => x.Type == typeof(TOtherTable)).Wheres.Add(whereModel);

            return this;
        }

        public BuildQuery<TPrincipalTable> Where<TOtherTable>(
            Expression<Func<TPrincipalTable, TOtherTable, object>> expressaoTwoTable)
        {
            //_listWheres.Add(ReflectionHelper.GetExpression(expressaoTwoTable));

            return this;
        }

        private void SplitInSmallBinaryExpression(Expression expression, IList<ExpressionModel> list, OperatorWhereEnum operatorWhere)
        {
            if (expression is BinaryExpression binaryExpression)
            {
                if (binaryExpression.Left is BinaryExpression)
                {
                    SplitInSmallBinaryExpression(binaryExpression.Left, list, GetOperatorWhereEnum(binaryExpression.NodeType));
                }
                else
                {
                    var binaryExpressionModel = new ExpressionModel();

                    binaryExpressionModel.SetExpression(binaryExpression);
                    binaryExpressionModel.SetOperatorInFinalLine(operatorWhere);

                    list.Add(binaryExpressionModel);
                    return;
                }

                if (binaryExpression.Right is BinaryExpression)
                {
                    SplitInSmallBinaryExpression(binaryExpression.Right, list, operatorWhere);
                }
                else
                {
                    var binaryExpressionModel = new ExpressionModel();

                    binaryExpressionModel.SetExpression(binaryExpression);
                    binaryExpressionModel.SetOperatorInFinalLine(operatorWhere);

                    list.Add(binaryExpressionModel);
                    return;
                }
            }
        }

        private OperatorWhereEnum GetOperatorWhereEnum(ExpressionType nodeType)
        {
            switch(nodeType)
            {
                case ExpressionType.OrElse:
                    return OperatorWhereEnum.OR;
                case ExpressionType.AndAlso:
                    return OperatorWhereEnum.AND;
                default:
                    return OperatorWhereEnum.NONE;
            }
        }

        public string Build()
        {
            ValidateJoins();

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

            var tablePrincipal = _tables.First(x => x.Principal == true);

            return from.AppendLine(new FromFactory().CreateBuild(tablePrincipal).Build());
        }

        private StringBuilder BuildInnerJoin()
        {
            var innerJoin = new StringBuilder();

            foreach (var item in new InnerJoinFactory().CreateBuilders(_tables))
                innerJoin.AppendLine(item.Build());

            return innerJoin;
        }

        private StringBuilder BuildWhere()
        {
            var where = new StringBuilder().AppendLine("where");

            foreach (var item in new WhereFactory().CreateBuilders(_tables))
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

                if (!_tables.Any(x => x.Alias == alias))
                    return alias;
                else
                    return GenerateAlias();
            }
        }
    }
}
