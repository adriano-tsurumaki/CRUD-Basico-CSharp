using System;
using System.Collections.Generic;

namespace BuildQuery
{
    public static class BuildQueryMapper
    {
        public static Dictionary<string, string> map = new Dictionary<string, string>();

        public static void AddTable<T>(string nome)
        {
            map.Add(typeof(T).FullName, nome);
        }

        public static Dictionary<string, string> GetDictionary() => map;
    }
}
