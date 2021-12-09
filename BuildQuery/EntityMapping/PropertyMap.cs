using System.Reflection;

namespace BuildQuery.EntityMapping
{
    public class PropertyMap
    {
        public string ColumnName { get; private set; }

        public bool Key { get; private set; }

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

        public PropertyMap IsKey()
        {
            Key = true;
            return this;
        }
    }
}
