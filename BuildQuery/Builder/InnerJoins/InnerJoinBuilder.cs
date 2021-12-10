using BuildQuery.Builder.Interfaces;
using System.Text;

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
            var nameTable = string.IsNullOrEmpty(_model.NameTable) ? _model.NameTable : _model.Name;

            return new StringBuilder().AppendLine($"inner join {nameTable} as {_model.Alias} on {_model.Alias}.{_model.KeyPrimary} = {_model.AliasCompared}.{_model.KeyCompared}").ToString(); ;
        }
    }
}
