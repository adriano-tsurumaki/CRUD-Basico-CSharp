using System.Reflection;

namespace BuildQuery.Builder.Models
{
    public class SelectModel
    {
        public PropertyInfo PropertyInfo { get; set; }
        public string ColumnName { get; set; }
    }
}
