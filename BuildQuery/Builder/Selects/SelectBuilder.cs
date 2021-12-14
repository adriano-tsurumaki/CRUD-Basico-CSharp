using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Models;
using System.Text;

namespace BuildQuery.Builder.Selects
{
    public class SelectBuilder : ISelectClauseBuilder
    {
        private readonly TableModel _model;

        public TableModel Model => _model;

        public SelectBuilder(TableModel model)
        {
            _model = model;
        }

        public string Build()
        {
            var sql = new StringBuilder();

            foreach (var select in _model.Selects)
                sql.AppendLine($"{_model.Alias}.{select.ColumnName} as {select.PropertyInfo.Name},");

            return sql.ToString();
        }
    }
}
