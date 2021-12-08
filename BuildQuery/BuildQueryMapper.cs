using System;
using System.Collections.Generic;

namespace BuildQuery
{
    public static class BuildQueryMapper
    {
        public static Dictionary<string, string> map = new Dictionary<string, string>();

        private static readonly QueryMapperConfiguration _configuration = new QueryMapperConfiguration();

        public static void AddTable<T>(string nome)
        {
            map.Add(typeof(T).FullName, nome);
        }

        public static void Initialize(Action<QueryMapperConfiguration> configure)
        {
            configure(_configuration);
        }

        public static Dictionary<string, string> GetDictionary() => map;
    }

    public class QueryMapperConfiguration
    {
        public void AddMap<T>() where T : class
        {

        }
    }
}
