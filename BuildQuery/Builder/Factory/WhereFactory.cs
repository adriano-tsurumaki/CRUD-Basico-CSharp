using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Models;
using BuildQuery.Builder.Where;
using System.Collections.Generic;

namespace BuildQuery.Builder.Factory
{
    public class WhereFactory
    {
        public IList<IWhereClauseBuilder> CreateBuilders(IList<TableModel> tables)
        {
            var listBuilders = new List<IWhereClauseBuilder>();

            foreach (var model in tables)
            {
                if (BuildQueryMapper.HasTableStored(model.Type))
                    listBuilders.Add(new WhereMapperBuilder(model));
                else
                    listBuilders.Add(new WhereBuilder(model));
            }

            return listBuilders;
        }
    }
}
