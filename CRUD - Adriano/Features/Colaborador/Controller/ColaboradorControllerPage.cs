using CRUD___Adriano.Features.Colaborador.Model;
using CRUD___Adriano.Features.Colaborador.View;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Interface;
using System;

namespace CRUD___Adriano.Features.Colaborador.Controller
{
    public class ColaboradorControllerPage : IControllerPage<ColaboradorModel>
    {
        private ColaboradorModel _colaboradorModel;

        private readonly IViewPage<ColaboradorModel> _frmColaboradorPage;

        public ColaboradorControllerPage() =>
            _frmColaboradorPage = new FrmCadastroColaborador(this);

        public void AdicionarModel(ref ColaboradorModel colaboradorModel)
        {
            _colaboradorModel = colaboradorModel;
            _frmColaboradorPage.BindModel(ref _colaboradorModel);
        }

        public IViewPage<ColaboradorModel> RetornarFormulario() =>
            _frmColaboradorPage;

        public bool ValidarForm() =>
            _frmColaboradorPage.ValidarComponentes();
    }
}
