using BuildQuery.Builder.Models;

namespace BuildQuery.Builder.Interfaces
{
    public interface IJoinClauseBuilder
    {
        public TableModel TableModel { get; }
        public string Build();
    }
}
