using BuildQuery.Util;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace BuildQuery
{
    public partial class BuildQuery<TPrincipalTable>
    {
        private void ValidarInnerJoins()
        {
            foreach (var select in _listSelects)
            {
                if (!_listInnerJoins.Any(x => x.Type.FullName == select.PropertyInfo.ReflectedType.FullName))
                {
                    throw new ArgumentException(string.Format(
                    "Não foi especificado a tabela {0} para a coluna {1}",
                    select.PropertyInfo.ReflectedType.Name, select.PropertyInfo.Name));
                }
            }
        }

        private void SetInnerJoin<TOtherTable>(Expression<Func<TOtherTable, object>> expressaoOtherTable, object expressaoComparedTable)
        {
            var tipoTable = typeof(TOtherTable);
            var tipoComparedTable = typeof(TPrincipalTable);

            var propOtherTable = ReflectionHelper.GetMemberInfo(expressaoOtherTable) as PropertyInfo;
            var propComparedTable = ReflectionHelper.GetMemberInfo(expressaoComparedTable as LambdaExpression) as PropertyInfo;

            var innerJoin = new InnerJoinModel();

            innerJoin.SetType(tipoTable);
            innerJoin.SetTypeCompared(tipoComparedTable);
            innerJoin.SetKeyPrimary(propOtherTable.Name);
            innerJoin.SetKeyCompared(propComparedTable.Name);

            if (!_listInnerJoins.Any(x => x.Type.FullName == propComparedTable.ReflectedType.FullName) && !tipoComparedTable.IsSubclassOf(propComparedTable.ReflectedType))
                throw new ArgumentException(string.Format(
                    "A tabela {0} não foi declarada",
                    propComparedTable.ReflectedType.FullName));

            _listInnerJoins.Add(innerJoin);

            _dictionaryAlias.Add(tipoTable, GenerateAlias());
        }
    }
}
