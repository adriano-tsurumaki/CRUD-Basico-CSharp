﻿using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Usuario.View;

namespace CRUD___Adriano.Features.Usuario.Controller
{
    public class BuscarUsuarioController<T> where T : class
    {
        private IControllerListarIdNome<T> _controller;
        private readonly FrmBuscarUsuario<T> _frmBuscarUsuario;
        public T usuarioSelecionado;

        public BuscarUsuarioController(IControllerListarIdNome<T> controller)
        {
            _controller = controller;
            _frmBuscarUsuario = new FrmBuscarUsuario<T>(this);
            _frmBuscarUsuario.BindGrid(_controller.ListarSomenteIdENome());
        }

        public void AtribuirUsuarioSelecionado(T usuario)
        {
            usuarioSelecionado = usuario;
            _frmBuscarUsuario.Close();
        }

        public T RetornarUsuarioSelecionado()
        {
            _frmBuscarUsuario.ShowDialog();

            return usuarioSelecionado;
        }
    }
}