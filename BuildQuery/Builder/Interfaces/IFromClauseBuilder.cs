using System;

namespace BuildQuery.Builder.Interfaces
{
    public interface IFromClauseBuilder
    {
        public string Build(Type type, string alias);
    }
}
