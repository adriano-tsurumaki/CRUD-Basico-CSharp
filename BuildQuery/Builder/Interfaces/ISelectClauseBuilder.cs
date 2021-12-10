using BuildQuery.Builder.Models;

namespace BuildQuery.Builder.Interfaces
{
    public interface ISelectClauseBuilder
    {
        public SelectModel Model { get; }
        public string Build();
    }
}
