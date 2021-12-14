using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Models;
using System.Linq;
using System.Text;

namespace BuildQuery.Builder.Selects
{
    public class SelectMapperBuilder : ISelectClauseBuilder
    {
        private readonly TableModel _model;

        public TableModel Model => _model;

        public SelectMapperBuilder(TableModel model)
        {
            _model = model;
        }

        public string Build()
        {
            var entity = BuildQueryMapper.GetEntityMap(_model.Type);

            var sql = new StringBuilder();

            foreach(var select in _model.Selects)
            {
                var property = entity.PropertyMaps.First(x => x.PropertyInfo == select.PropertyInfo);
                sql.AppendLine($"{_model.Alias}.{property.ColumnName} as {property.PropertyInfo.Name},");
            }

            return sql.ToString();
        }
    }
}
