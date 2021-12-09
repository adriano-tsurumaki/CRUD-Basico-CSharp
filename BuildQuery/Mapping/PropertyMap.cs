using System.Reflection;

namespace BuildQuery.Mapping
{
    public interface IPropertyMap
    {
        string ColumnName { get; }

        PropertyInfo PropertyInfo { get; }
    }
}
