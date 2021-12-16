using BuildQuery.Builder.InnerJoins;
using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Models;
using System.Collections.Generic;

namespace BuildQuery.Builder.Factory
{
    public class InnerJoinFactory
    {
        public IList<IJoinClauseBuilder> CreateBuilders(IList<TableModel> tables)
        {
            var listBuilders = new List<IJoinClauseBuilder>();

            foreach (var model in tables)
            {
                if (BuildQueryMapper.HasTableStored(model.Type))
                    listBuilders.Add(new InnerJoinMapperBuilder(model));
                else
                    listBuilders.Add(new InnerJoinBuilder(model));
            }

            return listBuilders;
        }
    }
}
