using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BuildQuery.Builder.Models
{
    public class WhereModel
    {
        public Type Type { get; set; }
        public IList<ExpressionModel> ExpressionModels { get; }

        public WhereModel()
        {
            ExpressionModels = new List<ExpressionModel>();
        }
    }

    public class ExpressionModel
    {
        public Expression Expression { get; private set; }
        public OperatorWhereEnum OperatorInFinalLine { get; private set; }

        public void SetExpression(Expression expression)
        {
            Expression = expression;
        }

        public void SetOperatorInFinalLine(OperatorWhereEnum operatorInFinalLine)
        {
            OperatorInFinalLine = operatorInFinalLine;
        }
    }

    public enum OperatorWhereEnum
    {
        NONE = 0,
        AND = 1,
        OR = 2,
        NOT = 3
    }
}
