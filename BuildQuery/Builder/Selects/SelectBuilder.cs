using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Models;
using System;
using System.Collections.Generic;

namespace BuildQuery.Builder.Selects
{
    public class SelectBuilder : ISelectClauseBuilder
    {
        private readonly SelectModel _model;

        public SelectModel Model => _model;

        public SelectBuilder(SelectModel model)
        {
            _model = model;
        }

        public string Build(Dictionary<Type, string> dictionaryAlias)
        {
            dictionaryAlias.TryGetValue(_model.Type, out var alias);

            return $"{alias}.{_model.ColumnName} as {_model.PropertyInfo.Name}, ";
        }
    }
}
