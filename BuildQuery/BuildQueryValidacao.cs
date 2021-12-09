using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace BuildQuery
{
    public partial class BuildQuery<TPrincipalTable>
    {
        private PropertyInfo ValidarERetornarPropriedadeDaTabela(Type tipo, MemberExpression membro, object propriedade)
        {
            if (membro == null)
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a method, not a property.",
                    propriedade.ToString()));

            var informacaoDaPropriedade = membro.Member as PropertyInfo;
            if (informacaoDaPropriedade == null)
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a field, not a property.",
                    propriedade.ToString()));

            if (tipo != informacaoDaPropriedade.ReflectedType &&
                !tipo.IsSubclassOf(informacaoDaPropriedade.ReflectedType))
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a property that is not from type {1}.",
                    propriedade.ToString(),
                    tipo));

            return informacaoDaPropriedade;
        }

        private MemberExpression RetornarMemberExpression(object propriedade, LambdaExpression lambda)
        {
            MemberExpression membro;

            if (lambda.Body is UnaryExpression)
            {
                var unaryExpression = lambda.Body as UnaryExpression;
                membro = unaryExpression.Operand as MemberExpression;
            }
            else
                membro = lambda.Body as MemberExpression;

            return membro;
        }

        private void ValidarInnerJoins()
        {
            foreach (var propriedade in _propriedadesDasOutrasTabelas)
            {
                if (!_listInnerJoin.Any(x => x.FullName == propriedade.Key.ReflectedType.FullName))
                {
                    throw new ArgumentException(string.Format(
                    "Não foi especificado a tabela {0} para a coluna {1}",
                    propriedade.Key.ReflectedType.Name, propriedade.Key.Name));
                }
            }
        }

        private void ValidateInnerJoin<TOtherTable>(Expression<Func<TOtherTable, object>> expressaoOtherTable, object expressaoComparedTable)
        {
            var tipoOtherTable = typeof(TOtherTable);
            var tipoComparedTable = typeof(TPrincipalTable);

            var lambdaOtherTable = expressaoOtherTable as LambdaExpression;
            var lambdaComparedTable = expressaoComparedTable as LambdaExpression;

            var membroOtherTable = RetornarMemberExpression(expressaoOtherTable, lambdaOtherTable);
            var membroComparedTable = RetornarMemberExpression(expressaoComparedTable, lambdaComparedTable);

            var propOtherTable = ValidarERetornarPropriedadeDaTabela(tipoOtherTable, membroOtherTable, lambdaOtherTable);
            var propComparedTable = ValidarERetornarPropriedadeDaTabela(tipoComparedTable, membroComparedTable, lambdaComparedTable);

            var innerJoin = new InnerJoinModel
            {
                FullName = tipoOtherTable.FullName,
                Name = tipoOtherTable.Name
            };

            innerJoin.SetKeyPrimary(propOtherTable.Name);
            innerJoin.SetKeyCompared(propComparedTable.Name);

            GenerateAlias(innerJoin);

            if (!_listInnerJoin.Any(x => x.FullName == propComparedTable.ReflectedType.FullName) && !tipoComparedTable.IsSubclassOf(propComparedTable.ReflectedType))
            {
                throw new ArgumentException(string.Format(
                    "A tabela {0} não foi declarada",
                    propComparedTable.ReflectedType.FullName));
            }
            else
            {
                var innerJoinCompared = _listInnerJoin.Where(x => x.FullName == tipoComparedTable.FullName).First();

                innerJoin.SetAliasCompared(innerJoinCompared.Alias);
            }

            _listInnerJoin.Add(innerJoin);
        }

        private void GenerateAlias(InnerJoinModel innerJoin)
        {
            while (true)
            {
                var alias = innerJoin.GenerateAlias();
                if (!_listInnerJoin.Any(x => x.Alias == alias))
                {
                    innerJoin.SetAlias(alias);
                    break;
                }
            }
        }
    }
}
