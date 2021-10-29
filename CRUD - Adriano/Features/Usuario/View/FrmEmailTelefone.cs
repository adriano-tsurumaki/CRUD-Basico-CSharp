using CRUD___Adriano.Features.Email.Model;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Telefone.Enum;
using CRUD___Adriano.Features.Telefone.Model;
using CRUD___Adriano.Features.Usuario.Model;
using CRUD___Adriano.Features.Utils;
using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Usuario.View
{
    public partial class FrmEmailTelefone<T> : FormBase<T>, IFormBase where T : class
    //public partial class FrmEmailTelefone : Form
    {
        private BindingList<EmailModel> _emailsBinding;
        private BindingList<TelefoneModel> _telefonesBinding;

        public event ValidarHandle ValidarEvent;

        public FrmEmailTelefone()
        {
            InitializeComponent();

            btnAdicionarEmail.Enabled = false;
            btnAdicionarTelefone.Enabled = false;
            cbTelefone.AtribuirPeloEnum<TipoTelefoneEnum>();
            ValidarEvent += new ValidarHandle(ValidarComponentes);
        }

        public override void Validar() => ValidarEvent?.Invoke();

        public void ValidarComponentes()
        {
            if (_emailsBinding.Count == 0 || _telefonesBinding.Count == 0)
            {
                Validado = false;
                return;
            }

            Validado = true;
        }

        public override void AdicionarModel(ref T model)
        {
            _emailsBinding = new BindingList<EmailModel>((model as UsuarioModel).Emails);
            _emailsBinding.ConfiguracaoPadrao();

            _telefonesBinding = new BindingList<TelefoneModel>((model as UsuarioModel).Telefones);
            _telefonesBinding.ConfiguracaoPadrao();

            dgvEmails.DataSource = _emailsBinding;
            dgvTelefones.DataSource = _telefonesBinding;
            
            CustomizarGrids();
        }

        private void CustomizarGrids()
        {
            CustomizarGridEmail();
            CustomizarGridTelefone();
        }

        private void CustomizarGridEmail()
        {
            dgvEmails.Columns.Clear();
            
            DataGridViewCell celula = new DataGridViewTextBoxCell();

            DataGridViewTextBoxColumn nomeColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnColuna",
                HeaderText = "Nome",
                DataPropertyName = "Nome",
                ReadOnly = true,
            };

            DataGridViewButtonColumn botaoExcluirColuna = new DataGridViewButtonColumn()
            {
                CellTemplate = new DataGridViewButtonCell(),
                HeaderText = "Excluir",
                Name = "Excluir"
            };

            dgvEmails.Columns.Add(nomeColuna);
            dgvEmails.Columns.Add(botaoExcluirColuna);
            dgvEmails.AutoGenerateColumns = false;
        }

        private void CustomizarGridTelefone()
        {
            dgvTelefones.Columns.Clear();

            DataGridViewCell celula = new DataGridViewTextBoxCell();

            DataGridViewTextBoxColumn numeroColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnColuna",
                HeaderText = "Numero",
                DataPropertyName = "Numero",
                ReadOnly = true,
            };

            DataGridViewTextBoxColumn tipoColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnColuna",
                HeaderText = "Tipo",
                DataPropertyName = "Tipo",
                ReadOnly = true,
            };

            DataGridViewButtonColumn botaoExcluirColuna = new DataGridViewButtonColumn()
            {
                CellTemplate = new DataGridViewButtonCell(),
                HeaderText = "Excluir",
                Name = "Excluir"
            };

            dgvTelefones.Columns.Add(numeroColuna);
            dgvTelefones.Columns.Add(tipoColuna);
            dgvTelefones.Columns.Add(botaoExcluirColuna);
            dgvTelefones.AutoGenerateColumns = false;
        }

        private void BtnAdicionarEmail_Click(object sender, EventArgs e) =>
            AdicionarEmailNaGrid();

        private void TxtEmail__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || btnAdicionarEmail.Enabled != true) return;

            AdicionarEmailNaGrid();
        }

        private void AdicionarEmailNaGrid()
        {
            if (txtEmail.NuloOuVazio())
            {
                MessageBox.Show("Insira um email!");
                return;
            }

            _emailsBinding.Add(new EmailModel { Nome = txtEmail.Texto });
            txtEmail.Texto = string.Empty;
        }

        private void BtnAdicionarTelefone_Click(object sender, EventArgs e) =>
            AdicionarTelefoneNaGrid();

        private void TxtTelefone__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || btnAdicionarTelefone.Enabled != true) return;

            AdicionarTelefoneNaGrid();
        }

        private void AdicionarTelefoneNaGrid()
        {
            if (txtTelefone.NuloOuVazio())
            {
                MessageBox.Show("Insira um telefone!");
                return;
            }
            else if (!cbTelefone.EstaSelecionado())
            {
                MessageBox.Show("Selecione o tipo do telefone!");
                return;
            }

            _telefonesBinding.Add(new TelefoneModel { Numero = txtTelefone.Texto, Tipo = cbTelefone.PegarEnumPorDescricao<TipoTelefoneEnum>() });
            txtTelefone.Texto = string.Empty;
        }

        private void DgvEmails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = sender as DataGridView;

            if (e.RowIndex < 0) return;

            if (!(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)) return;

            var botao = senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
            var emailModelSelecionado = dgvEmails.CurrentRow.DataBoundItem as EmailModel;

            if (botao.Name.Equals("Excluir"))
                _emailsBinding.Remove(emailModelSelecionado);
        }

        private void DgvTelefones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = sender as DataGridView;

            if (e.RowIndex < 0) return;

            if (!(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)) return;

            var botao = senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
            var telefoneModelSelecionado = dgvTelefones.CurrentRow.DataBoundItem as TelefoneModel;

            if (botao.Name.Equals("Excluir"))
                _telefonesBinding.Remove(telefoneModelSelecionado);
        }

        private void TxtEmail__TextChanged(object sender, EventArgs e)
        {
            btnAdicionarEmail.Enabled = false;

            if (txtEmail.NuloOuVazio()) return;

            if (new Regex(@"^[a-zA-Z0-9.]+[@][a-z]+[.][a-zA-Z]{2,3}").Match(txtEmail.Texto).Success)
                btnAdicionarEmail.Enabled = true;
        }

        private void TxtTelefone__TextChanged(object sender, EventArgs e)
        {
            btnAdicionarTelefone.Enabled = false;

            if (txtTelefone.NuloOuVazio()) return;

            txtTelefone.Texto = txtTelefone.Texto.RetornarSomenteTextoEmNumeros();

            if(txtTelefone.Texto.Length > 0)
                btnAdicionarTelefone.Enabled = true;
        }
    }
}
