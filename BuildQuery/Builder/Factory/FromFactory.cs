using BuildQuery.Builder.Froms;
using BuildQuery.Builder.Interfaces;
using System;

namespace BuildQuery.Builder.Factory
{
    public class FromFactory
    {
        public IFromClauseBuilder CreateBuild(Type type)
        {
            if (BuildQueryMapper.HasTableStored(type))
                return new FromMapperBuilder();

            return new FromBuilder();
        }
    }
}
