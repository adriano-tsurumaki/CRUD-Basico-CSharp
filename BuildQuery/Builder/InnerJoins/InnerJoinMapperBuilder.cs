using BuildQuery.Builder.Interfaces;

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

        public string Build()
        {
            throw new System.NotImplementedException();
        }
    }
}
