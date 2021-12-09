using BuildQuery.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace BuildQuery.Mapping
{
    public interface IEntityMap
    {
        IList<PropertyMap> PropertyMaps { get; }
    }

    public abstract class EntityMap<TEntity> : IEntityMap where TEntity : class
    {
        private readonly IList<PropertyMap> _propertyMaps;

        public IList<PropertyMap> PropertyMaps => _propertyMaps;

        public EntityMap()
        {
            _propertyMaps = new List<PropertyMap>();
        }

        public string TableName { get; private set; }

        protected void ToTable(string tableName) =>
            TableName = tableName;

        protected PropertyMap Map(Expression<Func<TEntity, object>> expression)
        {
            var propertyInfo = ReflectionHelper.GetMemberInfo(expression) as PropertyInfo;

            if (typeof(TEntity).IsSubclassOf(propertyInfo.DeclaringType))
                throw new Exception($"Propriedade {propertyInfo.Name} pertencente a classe pai! Utilize propriedades pertencente a classe {typeof(TEntity)}");

            if (PropertyMaps.Any(x => x.PropertyInfo == propertyInfo))
                throw new Exception($"Detectado duplicação de mapeamento. A propriedade '{propertyInfo.Name}' já foi mapeado!");

            var propertyMapper = GeneratePropertyMap(propertyInfo);

            PropertyMaps.Add(propertyMapper);

            return propertyMapper;
        }

        private PropertyMap GeneratePropertyMap(PropertyInfo propertyInfo) => new PropertyMap(propertyInfo);
    }

    public class PropertyMap 
    {
        public string ColumnName { get; private set; }

        public PropertyInfo PropertyInfo { get; }

        public PropertyMap(PropertyInfo propertyInfo)
        {
            PropertyInfo = propertyInfo;
        }

        public void ToColumn(string columnName) => ColumnName = columnName;
    }
}
