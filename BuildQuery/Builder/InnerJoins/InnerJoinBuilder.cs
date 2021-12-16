using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Models;
using System.Text;

namespace BuildQuery.Builder.InnerJoins
{
    public class InnerJoinBuilder : IJoinClauseBuilder
    {
        private readonly TableModel _tableModel;

        public TableModel TableModel => _tableModel;

        public InnerJoinBuilder(TableModel tableModel)
        {
            _tableModel = tableModel;
        }

        public string Build()
        {
            var sql = new StringBuilder();

            foreach (var innerJoin in _tableModel.Joins)
            {
                sql.AppendLine($"inner join {_tableModel.Name} as {_tableModel.Alias} on {_tableModel.Alias}.{innerJoin.KeyPrimary} = {innerJoin.AliasCompared}.{innerJoin.KeyCompared}");
            }

            return sql.ToString();
        }
    }
}
