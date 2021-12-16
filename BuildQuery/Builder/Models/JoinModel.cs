using System;

namespace BuildQuery.Builder.Models
{
    public class JoinModel
    {
        public Type TypeCompared { get; private set; }
        public string KeyPrimary { get; private set; }
        public string KeyCompared { get; private set; }
        public string AliasCompared { get; private set; }

        public void SetTypeCompared(Type type) =>
            TypeCompared = type;

        public void SetKeyPrimary(string keyPrimary) =>
            KeyPrimary = keyPrimary;

        public void SetKeyCompared(string keyCompared) =>
            KeyCompared = keyCompared;

        public void SetAliasCompared(string aliasCompared) =>
            AliasCompared = aliasCompared;
    }
}
