using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BuildQuery.Builder.Models
{
    public class WhereModel
    {
        public Type Type { get; set; }
        public IList<BinaryExpression> BinaryExpressions { get; }
        public IList<Expression> Expressions { get; set; }
        public string OperatorInFinalLine { get; private set; }

        public WhereModel()
        {
            BinaryExpressions = new List<BinaryExpression>();
            Expressions = new List<Expression>();
            OperatorInFinalLine = " and ";
        }

        private string SetOpetarorInFinalLine(string operatorInFinalLine) =>
            OperatorInFinalLine = operatorInFinalLine;
    }
}
