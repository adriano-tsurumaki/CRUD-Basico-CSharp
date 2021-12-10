using BuildQuery.Builder.InnerJoins;
using BuildQuery.Builder.Interfaces;
using System.Collections.Generic;

namespace BuildQuery.Builder.Factory
{
    public class InnerJoinFactory
    {
        public IList<IJoinClauseBuilder> CreateBuilders(IList<InnerJoinModel> listModels)
        {
            var listBuilders = new List<IJoinClauseBuilder>();

            foreach (var model in listModels)
            {
                if (model.Principal) continue;

                if (BuildQueryMapper.HasTableStored(model.Type))
                    listBuilders.Add(new InnerJoinMapperBuilder(model));
                else
                    listBuilders.Add(new InnerJoinBuilder(model));
            }

            return listBuilders;
        }
    }
}
