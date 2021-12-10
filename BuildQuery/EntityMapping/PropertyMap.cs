using System.Reflection;

namespace BuildQuery.EntityMapping
{
    public class PropertyMap
    {
        public string ColumnName { get; private set; }

        public bool AllowToUseBaseClass { get; private set; }

        public PropertyInfo PropertyInfo { get; }

        public PropertyMap(PropertyInfo propertyInfo)
        {
            PropertyInfo = propertyInfo;
        }

        public PropertyMap ToColumn(string columnName)
        {
            ColumnName = columnName;
            return this;
        }

        public PropertyMap IsBaseClass()
        {
            AllowToUseBaseClass = true;
            return this;
        }
    }
}
