using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Models;
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

        public string Build()
        {
            var entity = BuildQueryMapper.GetEntityMap(_model.Type);

            var columnName = entity.PropertyMaps.Where(x => x.PropertyInfo == _model.PropertyInfo).First().ColumnName;

            return new StringBuilder().AppendLine($"{columnName} as {_model.Alias}, ").ToString();
        }
    }
}
