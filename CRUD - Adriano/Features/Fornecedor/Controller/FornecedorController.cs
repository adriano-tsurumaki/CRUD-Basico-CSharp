using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Fornecedor.Dao;
using CRUD___Adriano.Features.Fornecedor.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Fornecedor.Controller
{
    public class FornecedorController : IControllerBase<FornecedorModel>
    {
        private readonly FornecedorDao _fornecedorDao;

        public FornecedorController(FornecedorDao fornecedorDao)
        {
            _fornecedorDao = fornecedorDao;
        }

        public bool Atualizar(FornecedorModel fornecedorModel)
        {
            throw new NotImplementedException();
        }

        public IList<FornecedorModel> Listar()
        {
            throw new NotImplementedException();
        }

        public IList<FornecedorModel> ListarPelaQuantidadeSomenteIdENome(int quantidade)
        {
            throw new NotImplementedException();
        }

        public bool Remover(int id)
        {
            throw new NotImplementedException();
        }

        public bool Salvar(FornecedorModel fornecedorModel)
        {
            try
            {
                return _fornecedorDao.CadastrarFornecedor(fornecedorModel);
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao cadastrar o fornecedor");
            }
            return false;
        }

        public FornecedorModel Selecionar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
