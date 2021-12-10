using BuildQuery.Builder.Interfaces;
using System.Text;

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
            var entity = BuildQueryMapper.GetEntityMap(_model.Type);

            return new StringBuilder().AppendLine($"inner join {entity.TableName} as {_model.Alias} on {_model.Alias}.{_model.KeyPrimary} = {_model.AliasCompared}.{_model.KeyCompared}").ToString();
        }
    }
}
