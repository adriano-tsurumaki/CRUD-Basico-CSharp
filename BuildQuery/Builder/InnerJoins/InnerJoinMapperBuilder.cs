using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Models;
using System.Linq;
using System.Text;

namespace BuildQuery.Builder.InnerJoins
{
    public class InnerJoinMapperBuilder : IJoinClauseBuilder
    {
        private readonly TableModel _tableModel;

        public TableModel TableModel => _tableModel;

        public InnerJoinMapperBuilder(TableModel tableModel)
        {
            _tableModel = tableModel;
        }

        public string Build()
        {
            var entity = BuildQueryMapper.GetEntityMap(_tableModel.Type);

            var sql = new StringBuilder();

            foreach (var innerJoin in _tableModel.Joins)
            {
                var primaryKey = entity.PropertyMaps.Where(x => x.PropertyInfo.Name == innerJoin.KeyPrimary).First().ColumnName;

                var foreignKey = entity.PropertyMaps.Where(x => x.PropertyInfo.Name == innerJoin.KeyCompared).First().ColumnName;

                sql.AppendLine($"inner join {entity.TableName} as {_tableModel.Alias} on {_tableModel.Alias}.{primaryKey} = {innerJoin.AliasCompared}.{foreignKey}");
            }

            return sql.ToString();
        }
    }
}
