using System.Windows.Forms;

namespace CRUD___Adriano.Features.Factory
{
    public delegate void ValidarHandle();

    public class FormBase<T> : Form where T : class
    {
        public bool Validado { get; }

        public virtual void AdicionarModel(ref T model) { }

        public virtual void Validar() { }
    }
}
