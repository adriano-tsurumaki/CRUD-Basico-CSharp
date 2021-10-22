using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.PageManager.View;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.GerenciadorDeFilaPaginas.Controller
{
    public class GerenciadorDeListagem<T> where T : class
    {
        private readonly Panel docker;
        public T _model;

        private readonly Stack<FormBase<T>> _filaDePaginas;

        public GerenciadorDeListagem()
        {

        }

    }
}
