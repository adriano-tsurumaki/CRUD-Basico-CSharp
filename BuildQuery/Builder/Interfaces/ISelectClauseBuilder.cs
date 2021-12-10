using BuildQuery.Builder.Models;
using System;
using System.Collections.Generic;

namespace BuildQuery.Builder.Interfaces
{
    public interface ISelectClauseBuilder
    {
        public SelectModel Model { get; }
        public string Build(Dictionary<Type, string> dictionaryAlias);
    }
}
