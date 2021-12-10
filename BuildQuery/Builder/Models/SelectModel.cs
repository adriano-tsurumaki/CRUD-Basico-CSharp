using System;
using System.Reflection;

namespace BuildQuery.Builder.Models
{
    public class SelectModel
    {
        public bool Principal { get; set; }
        public string Alias { get; set; }
        public Type Type { get; set; }
        public PropertyInfo PropertyInfo { get; set; }

        public SelectModel()
        {
            Principal = false;
        }
    }
}
