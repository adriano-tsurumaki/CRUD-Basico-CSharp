using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Models;

namespace BuildQuery.Builder.Froms
{
    public class FromMapperBuilder : IFromClauseBuilder
    {
        private readonly TableModel _tableModel;

        public TableModel TableModel => _tableModel;

        public FromMapperBuilder(TableModel model)
        {
            _tableModel = model;
        }

        public string Build() =>
            $"from {BuildQueryMapper.GetEntityMap(_tableModel.Type).TableName} as {_tableModel.Alias}";
    }
}
