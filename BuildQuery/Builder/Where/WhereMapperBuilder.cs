using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Models;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace BuildQuery.Builder.Where
{
    public class WhereMapperBuilder : IWhereClauseBuilder
    {
        private readonly TableModel _tableModel;

        public TableModel TableModel => _tableModel;

        public WhereMapperBuilder(TableModel tableModel)
        {
            _tableModel = tableModel;
        }

        public string Build()
        {
            var sql = new StringBuilder();

            BuildBinaryExpression(_tableModel.Wheres.SelectMany(x => x.BinaryExpressions), sql);

            BuildExpression(_tableModel.Wheres.SelectMany(x => x.Expressions), sql);

            return sql.ToString();
        }

        private void BuildBinaryExpression(IEnumerable<BinaryExpression> binaryExpressions, StringBuilder sql)
        {
            if (binaryExpressions.Count() == 0) return;

            var entity = BuildQueryMapper.GetEntityMap(_tableModel.Type);

            var propertyMaps = entity.PropertyMaps;

            foreach (var binaryExpression in binaryExpressions)
            {
                var propertyInfoLeft = GetPropertyInfoFromExpression(binaryExpression.Left);
                var propertyInfoRight = GetPropertyInfoFromExpression(binaryExpression.Right);

                if (propertyInfoLeft != null)
                {
                    var propertyMapLeft =  propertyMaps.First(x => x.PropertyInfo == propertyInfoLeft);
                }

                if (propertyInfoRight != null)
                {
                    var propertyMapRight =  propertyMaps.First(x => x.PropertyInfo == propertyInfoRight);
                }


                switch (binaryExpression.NodeType)
                {
                    case ExpressionType.Equal:
                        sql.AppendLine($"{_tableModel.Alias}.{propertyMapLeft.ColumnName} = {propertyInfoRight} &&");
                        break;
                }
            }
        }

        private PropertyInfo GetPropertyInfoFromExpression(Expression expression)
        {
            if (expression is MemberExpression memberExpression)
            {
                return memberExpression.Member as PropertyInfo;
            }

            return null;
        }

        private void BuildExpression(IEnumerable<Expression> expressions, StringBuilder sql)
        {
            if (expressions.Count() == 0) return;
            
            foreach (var expression in expressions)
            {

            }
        }
    }
}
