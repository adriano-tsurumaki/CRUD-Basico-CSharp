using BuildQuery.Builder.Froms;
using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Models;

namespace BuildQuery.Builder.Factory
{
    public class FromFactory
    {
        public IFromClauseBuilder CreateBuild(TableModel table)
        {
            if (BuildQueryMapper.HasTableStored(table.Type))
                return new FromMapperBuilder(table);

            return new FromBuilder(table);
        }
    }
}
