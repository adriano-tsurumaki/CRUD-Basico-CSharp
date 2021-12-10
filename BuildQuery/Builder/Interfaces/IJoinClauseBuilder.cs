using System.Text;

namespace BuildQuery.Builder.Interfaces
{
    public interface IJoinClauseBuilder
    {
        public InnerJoinModel Model { get; }
        public string Build();
    }
}
