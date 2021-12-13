using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Where;
using System;
using System.Collections.Generic;

namespace BuildQuery.Builder.Factory
{
    public class WhereFactory
    {
        public IList<IWhereClauseBuilder> CreateBuilders(IList<Type> listTypes)
        {
            var listBuilders = new List<IWhereClauseBuilder>();

            foreach (var type in listTypes)
            {
                if (BuildQueryMapper.HasTableStored(type))
                    listBuilders.Add(new WhereMapperBuilder());
                else
                    listBuilders.Add(new WhereBuilder());
            }

            return listBuilders;
        }
    }
}
