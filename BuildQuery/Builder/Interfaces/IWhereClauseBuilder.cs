using BuildQuery.Builder.Models;

namespace BuildQuery.Builder.Interfaces
{
    public interface IWhereClauseBuilder
    {
        public TableModel TableModel { get; }
        public string Build();
    }
}
