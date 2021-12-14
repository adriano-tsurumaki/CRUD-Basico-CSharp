using System;
using System.Linq.Expressions;

namespace BuildQuery.Builder.Models
{
    public class WhereModel
    {
        public Type Type { get; set; }
        public Expression Expression { get; set; }
    }
}
