using BuildQuery.Builder.Models;
using System;
using System.Collections.Generic;

namespace BuildQuery.Builder.Interfaces
{
    public interface ISelectClauseBuilder
    {
        public TableModel Model { get; }
        public string Build();
    }
}
