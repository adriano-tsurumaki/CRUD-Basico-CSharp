using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Factory
{
    public class FormBase<T> : Form where T : class
    {
        public virtual void AdicionarModel(T model) { }
    }
}
