using BuildQuery.Builder.Models;
using BuildQuery.Util;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace BuildQuery
{
    public partial class BuildQuery<TPrincipalTable>
    {
        private void SetInnerJoin<TOtherTable>(Expression<Func<TOtherTable, object>> expressaoOtherTable, object expressaoComparedTable)
        {
            var tipoTable = typeof(TOtherTable);
            var tipoComparedTable = typeof(TPrincipalTable);

            var propOtherTable = ReflectionHelper.GetMemberInfo(expressaoOtherTable) as PropertyInfo;
            var propComparedTable = ReflectionHelper.GetMemberInfo(expressaoComparedTable as LambdaExpression) as PropertyInfo;

            var innerJoin = new JoinModel();

            innerJoin.SetTypeCompared(tipoComparedTable);
            innerJoin.SetKeyPrimary(propOtherTable.Name);
            innerJoin.SetKeyCompared(propComparedTable.Name);
            innerJoin.SetAliasCompared(_tables.First(x => x.Type == tipoComparedTable).Alias);

            if (_tables.Any(x => x.Type == tipoTable))
                _tables.First(x => x.Type == tipoTable).Joins.Add(innerJoin);
            else
            {
                var table = new TableModel
                {
                    Alias = GenerateAlias(),
                    Name = tipoTable.Name,
                    Type = tipoTable,
                };

                _tables.Add(table);
            }
        }

        private void ValidateJoins()
        {
            //foreach (var select in _listSelects)
            //{
            //    if (!_listInnerJoins.Any(x => x.Type.FullName == select.PropertyInfo.ReflectedType.FullName))
            //    {
            //        throw new ArgumentException(string.Format(
            //        "Não foi especificado a tabela {0} para a coluna {1}",
            //        select.PropertyInfo.ReflectedType.Name, select.PropertyInfo.Name));
            //    }
            //}
        }
    }
}
