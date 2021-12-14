using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Models;

namespace BuildQuery.Builder.Froms
{
    public class FromBuilder : IFromClauseBuilder
    {
        private readonly TableModel _tableModel;

        public TableModel TableModel => _tableModel;

        public FromBuilder(TableModel model)
        {
            _tableModel = model;
        }

        public string Build() =>
            $"from {_tableModel.Name} as {_tableModel.Alias}";
    }
}
