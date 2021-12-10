using BuildQuery.Builder.Interfaces;
using System;

namespace BuildQuery.Builder.Froms
{
    public class FromBuilder : IFromClauseBuilder
    {
        public string Build(Type type, string alias) =>
            $"from {type.Name} as {alias}";
    }
}
