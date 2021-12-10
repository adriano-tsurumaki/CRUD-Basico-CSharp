using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Models;

namespace BuildQuery.Builder.Selects
{
    public class SelectBuilder : ISelectClauseBuilder
    {
        private readonly SelectModel _model;

        public SelectModel Model => _model;

        public SelectBuilder(SelectModel model)
        {
            _model = model;
        }

        public string Build()
        {
            return "";
        }
    }
}
