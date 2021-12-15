using BuildQuery.EntityMapping;
using System;

namespace BuildQuery
{
    public class QueryMapperConfiguration
    {
        public void AddMap<TEntity>(EntityMap<TEntity> mapper) where TEntity : class
        {
            foreach (var propertyMap in mapper.PropertyMaps)
            {
                if (typeof(TEntity).IsSubclassOf(propertyMap.PropertyInfo.DeclaringType) && !propertyMap.AllowToUseBaseClass)
                    throw new Exception($"Propriedade {propertyMap.PropertyInfo.Name} pertencente a classe pai! Utilize propriedades pertencente a classe {typeof(TEntity)}");
            }

            BuildQueryMapper.TableMaps.Add(typeof(TEntity), mapper);
        }
    }

    public interface IConfigBuilder
    {
        public void Build();
    }
}
