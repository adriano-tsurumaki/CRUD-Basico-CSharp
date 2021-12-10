using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Models;
using BuildQuery.Builder.Selects;
using System.Collections.Generic;

namespace BuildQuery.Builder.Factory
{
    public class SelectFactory
    {
        public IList<ISelectClauseBuilder> CreateBuilders(IList<SelectModel> listModels)
        {
            var listBuilders = new List<ISelectClauseBuilder>();

            foreach (var model in listModels)
            {
                if (BuildQueryMapper.HasTableStored(model.Type))
                    listBuilders.Add(new SelectMapperBuilder(model));
                else
                    listBuilders.Add(new SelectBuilder(model));
            }

            return listBuilders;
        }
    }
}
