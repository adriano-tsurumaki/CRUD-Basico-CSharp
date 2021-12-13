using System;

namespace BuildQuery.Builder.Models
{
    public class InnerJoinModel
    {
        public string NameTable { get; private set; }
        public Type Type { get; private set; }
        public Type TypeCompared { get; private set; }
        public bool Principal { get; private set; }
        public string KeyPrimary { get; private set; }
        public string KeyCompared { get; private set; }

        public InnerJoinModel()
        {
            Principal = false;
        }

        public void SetNameTable(string nameTable) =>
            NameTable = nameTable;

        public void SetType(Type type) =>
            Type = type;

        public void SetTypeCompared(Type type) =>
            TypeCompared = type;

        public void SetPrincipal(bool principal) =>
            Principal = principal;

        public void SetKeyPrimary(string keyPrimary) =>
            KeyPrimary = keyPrimary;

        public void SetKeyCompared(string keyCompared) =>
            KeyCompared = keyCompared;
    }
}
