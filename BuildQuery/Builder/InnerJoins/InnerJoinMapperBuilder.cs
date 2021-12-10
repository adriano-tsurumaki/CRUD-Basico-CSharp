using BuildQuery.Builder.Interfaces;
using System;
using System.Collections.Generic;
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

        public string Build(Dictionary<Type, string> dictionaryAlias)
        {
            var entity = BuildQueryMapper.GetEntityMap(_model.Type);

            var primaryKey = entity.PropertyMaps.Where(x => x.PropertyInfo.Name == _model.KeyPrimary).First().ColumnName;

            var foreignKey = entity.PropertyMaps.Where(x => x.PropertyInfo.Name == _model.KeyCompared).First().ColumnName;

            dictionaryAlias.TryGetValue(_model.Type, out var alias);
            dictionaryAlias.TryGetValue(_model.TypeCompared, out var aliasCompared);

            return new StringBuilder().AppendLine($"inner join {entity.TableName} as {alias} on {alias}.{primaryKey} = {aliasCompared}.{foreignKey}").ToString();
        }
    }
}
