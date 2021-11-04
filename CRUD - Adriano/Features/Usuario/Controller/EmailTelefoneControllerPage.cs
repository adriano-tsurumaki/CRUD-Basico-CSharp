using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD___Adriano.Features.Usuario.Controller
{
    public class EmailTelefoneControllerPage<T> : IControllerPage<T>
    {
        private T _usuarioModel;

        private IViewPage<T> _frmEmailTelefone;

        public EmailTelefoneControllerPage(IViewPage<T> frmEmailTelefone)
        {
            _frmEmailTelefone = frmEmailTelefone;
        }

        public void AdicionarModel(ref T usuarioModel)
        {
            _usuarioModel = usuarioModel;
            _frmEmailTelefone.BindModel(ref _usuarioModel);
        }

        public IViewPage<T> RetornarFormulario() => _frmEmailTelefone;

        public bool ValidarForm() =>
            _frmEmailTelefone.ValidarComponentes();
    }
}
