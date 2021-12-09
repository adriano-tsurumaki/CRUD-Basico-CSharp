using BuildQuery.Mapping;

namespace BuildQuery
{
    public class QueryMapperConfiguration
    {
        public void AddMap<TEntity>(EntityMap<TEntity> mapper) where TEntity : class =>
            BuildQueryMapper.TableMaps.Add(typeof(TEntity), mapper);
    }
}
