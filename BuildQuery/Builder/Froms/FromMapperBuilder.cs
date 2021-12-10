using BuildQuery.Builder.Interfaces;
using System;

namespace BuildQuery.Builder.Froms
{
    public class FromMapperBuilder : IFromClauseBuilder
    {
        public string Build(Type type, string alias) =>
            $"from {BuildQueryMapper.GetEntityMap(type).TableName} as {alias}";
    }
}
