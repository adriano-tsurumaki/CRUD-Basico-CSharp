using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Colaborador.Model;
using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.Usuario.Controller;
using CRUD___Adriano.Features.Usuario.Model;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class UcVendaHeader : UserControl
    {
        public delegate void DefinirIdUsuarioHandler(UsuarioModel usuarioModelSelecionado);

        public event DefinirIdUsuarioHandler EventDefinirIdCliente;
        public event DefinirIdUsuarioHandler EventDefinirIdColaborador;

        public UcVendaHeader()
        {
            InitializeComponent();
            lblHorario.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void TimerHorario_Tick(object sender, EventArgs e) =>
            lblHorario.Text = DateTime.Now.ToString("HH:mm:ss");

        private void LblCliente_Click(object sender, EventArgs e)
        {
            var clienteModel = ConfigNinject.ObterInstancia<BuscarUsuarioController<ClienteModel>>()
                .DefinirTituloDoForm("Listagem de Clientes").RetornarUsuarioSelecionado();

            if (string.IsNullOrEmpty(clienteModel.Nome)) return;

            lblCliente.Text = clienteModel.Nome;
            EventDefinirIdCliente?.Invoke(clienteModel);
        }

        private void LblVendedor_Click(object sender, EventArgs e)
        {
            var colaboradorModel = ConfigNinject.ObterInstancia<BuscarUsuarioController<ColaboradorModel>>()
                .DefinirTituloDoForm("Listagem de Colaboradores").RetornarUsuarioSelecionado();

            if (string.IsNullOrEmpty(colaboradorModel.Nome)) return;

            lblVendedor.Text = colaboradorModel.Nome;
            EventDefinirIdColaborador?.Invoke(colaboradorModel);
        }

        public void DefinirLabelCliente(string nome) =>
            lblCliente.Text = nome;

        public void DefinirLabelColaborador(string nome) =>
            lblVendedor.Text = nome;
    }
}
