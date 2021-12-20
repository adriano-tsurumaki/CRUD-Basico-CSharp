using BuildQuery.Builder.Interfaces;
using BuildQuery.Builder.Models;
using BuildQuery.EntityMapping;
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

            var propertyMaps = BuildQueryMapper.GetEntityMap(_tableModel.Type).PropertyMaps;

            BuildExpression(_tableModel.Wheres.SelectMany(x => x.ExpressionModels), sql, propertyMaps);

            return sql.ToString();
        }

        private void BuildExpression(IEnumerable<ExpressionModel> expressionModels, StringBuilder sql, IList<PropertyMap> propertyMaps)
        {
            if (expressionModels.Count() == 0) return;

            foreach (var model in expressionModels)
            {
                if (model.Expression is BinaryExpression binaryExpression)
                {
                    var operandLeft = GetOperandStringInExpression(binaryExpression.Left, propertyMaps);
                    var operandRight = GetOperandStringInExpression(binaryExpression.Right, propertyMaps);

                    switch (model.Expression.NodeType)
                    {
                        case ExpressionType.Equal:
                            sql.AppendLine($"{operandLeft} = {operandRight}{GetStringInOperatorWhereEnum(model.OperatorInFinalLine)}");
                            break;
                    }
                }
                else if (model.Expression is MemberExpression memberExpression)
                {
                    var propertyInfo = memberExpression.Member as PropertyInfo;

                    var propertyMapFromMapper = propertyMaps.FirstOrDefault(x => x.PropertyInfo == propertyInfo);
                    if (propertyMapFromMapper != null)
                        sql.AppendLine($"{_tableModel.Alias}.{propertyMapFromMapper.ColumnName} = @{propertyMapFromMapper.PropertyInfo.Name}{GetStringInOperatorWhereEnum(model.OperatorInFinalLine)}");
                    else
                        sql.AppendLine($"{_tableModel.Alias}.{propertyInfo.Name} = @{propertyInfo.Name}{GetStringInOperatorWhereEnum(model.OperatorInFinalLine)}");
                }
                else if (model.Expression is UnaryExpression unaryExpression)
                {
                    var propertyInfo = (unaryExpression.Operand as MemberExpression).Member as PropertyInfo;

                    var propertyMapFromMapper = propertyMaps.FirstOrDefault(x => x.PropertyInfo == propertyInfo);
                    if (propertyMapFromMapper != null)
                        sql.AppendLine($"{_tableModel.Alias}.{propertyMapFromMapper.ColumnName} = @{propertyMapFromMapper.PropertyInfo.Name}{GetStringInOperatorWhereEnum(model.OperatorInFinalLine)}");
                    else
                        sql.AppendLine($"{_tableModel.Alias}.{propertyInfo.Name} = @{propertyInfo.Name}{GetStringInOperatorWhereEnum(model.OperatorInFinalLine)}");
                }
            }
        }

        private string GetOperandStringInExpression(Expression expression, IList<PropertyMap> propertyMapsFromMapper)
        {
            var propertyInfo = GetPropertyInfoFromExpression(expression);
            
            var operandString = string.Empty;

            if (propertyInfo != null)
            {
                var propertyMapFromMapper = propertyMapsFromMapper.FirstOrDefault(x => x.PropertyInfo == propertyInfo);
                if (propertyMapFromMapper == null)
                    operandString = $"{_tableModel.Alias}.{propertyInfo.Name}";
                else
                    operandString = $"{_tableModel.Alias}.{propertyMapFromMapper.ColumnName}";
            }
            else
            {
                if (expression is ConstantExpression constantExpression)
                {
                    operandString = $"'{constantExpression.Value}'";
                }
                else if (expression is UnaryExpression unaryExpression)
                {
                    var propertyMapFromMapper = propertyMapsFromMapper.FirstOrDefault(x => x.PropertyInfo == (unaryExpression.Operand as MemberExpression).Member as PropertyInfo);
                    if (propertyMapFromMapper == null)
                        operandString = $"{_tableModel.Alias}.{(unaryExpression.Operand as MemberExpression).Member.Name}";
                    else
                        operandString = $"{_tableModel.Alias}.{propertyMapFromMapper.ColumnName}";
                }
            }

            return operandString;
        }

        private string GetStringInOperatorWhereEnum(OperatorWhereEnum operatorInFinalLine)
        {
            switch (operatorInFinalLine)
            {
                case OperatorWhereEnum.OR:
                    return " or ";
                case OperatorWhereEnum.NOT:
                    return " not ";
                case OperatorWhereEnum.AND:
                case OperatorWhereEnum.NONE:
                default:
                    return " and ";
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
    }
}
