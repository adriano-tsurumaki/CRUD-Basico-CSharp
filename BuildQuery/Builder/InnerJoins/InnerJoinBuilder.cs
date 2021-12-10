using BuildQuery.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildQuery.Builder.InnerJoins
{
    public class InnerJoinBuilder : IJoinClauseBuilder
    {
        private readonly InnerJoinModel _model;

        public InnerJoinModel Model => _model;

        public InnerJoinBuilder(InnerJoinModel model)
        {
            _model = model;
        }

        public string Build(Dictionary<Type, string> dictionaryAlias)
        {
            var nameTable = string.IsNullOrEmpty(_model.NameTable) ? _model.NameTable : _model.Name;

            dictionaryAlias.TryGetValue(_model.Type, out var alias);
            dictionaryAlias.TryGetValue(_model.TypeCompared, out var aliasCompared);

            return new StringBuilder().AppendLine($"inner join {nameTable} as {alias} on {alias}.{_model.KeyPrimary} = {aliasCompared}.{_model.KeyCompared}").ToString();
        }
    }
}
