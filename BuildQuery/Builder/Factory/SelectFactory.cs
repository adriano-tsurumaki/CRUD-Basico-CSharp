using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Models;
using BuildQuery.Builder.Selects;
using System.Collections.Generic;

namespace BuildQuery.Builder.Factory
{
    public class SelectFactory
    {
        public IList<ISelectClauseBuilder> CreateBuilders(IList<TableModel> tables)
        {
            var listBuilders = new List<ISelectClauseBuilder>();

            foreach (var model in tables)
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
