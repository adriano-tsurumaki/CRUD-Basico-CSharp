using BuildQuery.Builder.Interfaces;
using System.Linq;
using System.Text;

namespace BuildQuery.Builder.InnerJoins
{
    public class InnerJoinMapperBuilder : IJoinClauseBuilder
    {
        private readonly InnerJoinModel _model;

        public InnerJoinModel Model => _model;

        public InnerJoinMapperBuilder(InnerJoinModel model)
        {
            _model = model;
        }

        public string Build()
        {
            var entity = BuildQueryMapper.GetEntityMap(_model.Type);

            var primaryKey = entity.PropertyMaps.Where(x => x.PropertyInfo.Name == _model.KeyPrimary).First().ColumnName;

            var foreignKey = entity.PropertyMaps.Where(x => x.PropertyInfo.Name == _model.KeyCompared).First().ColumnName;

            return new StringBuilder().AppendLine($"inner join {entity.TableName} as {_model.Alias} on {_model.Alias}.{primaryKey} = {_model.AliasCompared}.{foreignKey}").ToString();
        }
    }
}
