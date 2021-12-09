using BuildQuery.Mapping;
using System;
using System.Collections.Generic;

namespace BuildQuery
{
    public static class BuildQueryMapper
    {
        public static Dictionary<Type, IEntityMap> TableMaps = new Dictionary<Type, IEntityMap>();

        private static readonly QueryMapperConfiguration _configuration = new QueryMapperConfiguration();

        public static void Initialize(Action<QueryMapperConfiguration> configure)
        {
            configure(_configuration);
        }

        public static Dictionary<Type, IEntityMap> GetDictionary() => TableMaps;
    }
}
