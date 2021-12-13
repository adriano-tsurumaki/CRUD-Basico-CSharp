using BuildQuery.Builder.Models;
using System;
using System.Collections.Generic;

namespace BuildQuery.Builder.Interfaces
{
    public interface IJoinClauseBuilder
    {
        public InnerJoinModel Model { get; }
        public string Build(Dictionary<Type, string> dictionaryAlias);
    }
}
