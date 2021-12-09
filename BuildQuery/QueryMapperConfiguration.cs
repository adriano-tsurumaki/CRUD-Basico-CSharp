using BuildQuery.EntityMapping;

namespace BuildQuery
{
    public class QueryMapperConfiguration
    {

        public void AddMap<TEntity>(EntityMap<TEntity> mapper) where TEntity : class =>
            BuildQueryMapper.TableMaps.Add(typeof(TEntity), mapper);
    }

    public interface IConfigBuilder
    {
        public void Build();
    }
}
