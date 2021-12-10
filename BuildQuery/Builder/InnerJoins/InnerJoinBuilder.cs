using BuildQuery.Builder.Interfaces;

namespace BuildQuery.Builder.InnerJoins
{
    public class InnerJoinBuilder : IJoinClauseBuilder
    {
        private readonly InnerJoinModel _model;

        public InnerJoinModel Model => _model;

        public InnerJoinBuilder(InnerJoinModel model)
        {
            _model = model;
        }

        public string Build()
        {
            throw new System.NotImplementedException();
        }
    }
}
