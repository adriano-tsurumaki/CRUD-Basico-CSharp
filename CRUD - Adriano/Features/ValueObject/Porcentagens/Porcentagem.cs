namespace CRUD___Adriano.Features.ValueObject.Porcentagens
{
    public struct Porcentagem
    {
        private readonly float _valor;

        public Porcentagem(int valor)
        {
            _valor = valor / 100;
        }

        public static implicit operator Porcentagem(int valor) => new Porcentagem(valor);
    }
}
