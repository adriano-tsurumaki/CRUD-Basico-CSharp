using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace BuildQuery.Util
{
    public static class ReflectionHelper
    {
        public static MemberInfo GetMemberInfo(LambdaExpression lambda)
        {
            Expression expr = lambda;
            while (true)
            {
                switch (expr.NodeType)
                {
                    case ExpressionType.Lambda:
                        expr = ((LambdaExpression)expr).Body;
                        break;

                    case ExpressionType.Convert:
                        expr = ((UnaryExpression)expr).Operand;
                        break;

                    case ExpressionType.MemberAccess:
                        var memberExpression = (MemberExpression)expr;
                        var member = memberExpression.Member;
                        Type paramType;

                        while (memberExpression != null)
                        {
                            paramType = memberExpression.Type;

                            var baseMember = paramType.GetMembers().FirstOrDefault(m => m.Name == member.Name);
                            if (baseMember != null)
                            {
                                if (baseMember is PropertyInfo baseProperty && member is PropertyInfo property)
                                {
                                    if (baseProperty.DeclaringType == property.DeclaringType &&
                                        baseProperty.PropertyType != Nullable.GetUnderlyingType(property.PropertyType))
                                    {
                                        return baseMember;
                                    }
                                }
                                else
                                {
                                    return baseMember;
                                }
                            }

                            memberExpression = memberExpression.Expression as MemberExpression;
                        }
                        
                        paramType = lambda.Parameters[0].Type;
                        return paramType.GetMember(member.Name)[0];

                    default:
                        return null;
                }
            }
        }

        public static Expression GetExpression(LambdaExpression lambda)
        {
            Expression expr = lambda;
            while (true)
            {
                switch (expr.NodeType)
                {
                    case ExpressionType.Lambda:
                        expr = ((LambdaExpression)expr).Body;
                        break;

                    case ExpressionType.Convert:
                        return ((UnaryExpression)expr).Operand;

                    default:
                        return null;
                }
            }
        }
    }
}
