using System;
using System.Collections.Generic;

namespace BuildQuery.Builder.Models
{
    public class TableModel
    {
        public bool Principal { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public IList<SelectModel> Selects { get; set; }
        public Type Type { get; set; }
        public IList<JoinModel> Joins { get; set; }
        public IList<WhereModel> Wheres { get; set; }

        public TableModel()
        {
            Principal = true;
            Selects = new List<SelectModel>();
            Joins = new List<JoinModel>();
            Wheres = new List<WhereModel>();
        }
    }
}
