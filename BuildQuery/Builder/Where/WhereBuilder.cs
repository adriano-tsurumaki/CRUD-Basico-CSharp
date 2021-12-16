using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Models;

namespace BuildQuery.Builder.Where
{
    public class WhereBuilder : IWhereClauseBuilder
    {
        private readonly TableModel _tableModel;

        public TableModel TableModel => _tableModel;

        public WhereBuilder(TableModel tableModel)
        {
            _tableModel = tableModel;
        }

        public string Build()
        {
            return "";
        }
    }
}
