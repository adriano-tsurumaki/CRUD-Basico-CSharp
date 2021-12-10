using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildQuery.Builder.Selects
{
    public class SelectMapperBuilder : ISelectClauseBuilder
    {
        private readonly SelectModel _model;

        public SelectModel Model => _model;

        public SelectMapperBuilder(SelectModel model)
        {
            _model = model;
        }

        public string Build(Dictionary<Type, string> dictionaryAlias)
        {
            var entity = BuildQueryMapper.GetEntityMap(_model.Type);

            var propertyMap = entity.PropertyMaps.Where(x => x.PropertyInfo == _model.PropertyInfo).First();

            dictionaryAlias.TryGetValue(_model.Type, out var alias);

            return new StringBuilder().AppendLine($"{alias}.{propertyMap.ColumnName} as {propertyMap.PropertyInfo.Name},").ToString();
        }
    }
}
