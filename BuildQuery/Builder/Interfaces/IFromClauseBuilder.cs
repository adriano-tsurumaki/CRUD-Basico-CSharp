using BuildQuery.Builder.Models;

namespace BuildQuery.Builder.Interfaces
{
    public interface IFromClauseBuilder
    {
        public TableModel TableModel { get; }
        public string Build();
    }
}
