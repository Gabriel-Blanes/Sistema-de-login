using ExemploLogin.Models;
using ExemploLogin.Services;
using ExemploLogin.Views.ViewModels;
using System;
using System.Windows.Forms;

namespace ExemploLogin.Views.Cadastros
{
    public partial class FrmBuscarUsuario : Form
    {
        private readonly UsuarioService _usuarioService = new UsuarioService();
        private readonly CategoriaService _categoriaService = new CategoriaService();
        private readonly SituacaoService _situacaoService = new SituacaoService();


        public Usuario UsuarioSelecionado { get; private set; }


        public FrmBuscarUsuario()
        {
            InitializeComponent();
        }


        private void FrmBuscarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                dataGridView.DataSource = null;
                CarregarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no carregamento da tela! \n" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void FrmBuscarUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var categoria = cboCategoria.SelectedItem as Categoria;
                var situacao = cboSituacao.SelectedItem as Situacao;

                var result = _usuarioService.BuscarUsuarios(txtId.Text, txtNomeUsuario.Text, categoria?.Id.ToString(), situacao?.Id.ToString());
                dataGridView.DataSource = result;

                Application.DoEvents();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.DataSource != null && dataGridView.SelectedRows.Count > 0)
                {
                    if (dataGridView.CurrentRow.DataBoundItem is UsuarioConsultaViewModel usuarioViewModel)
                    {
                        UsuarioSelecionado = _usuarioService.GetUsuario(usuarioViewModel.Id);
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar obter os dados selecionados. \n" + ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnBuscar_Click(sender, e);
            }
        }


        private void CarregarCombos()
        {
            var categorias = _categoriaService.GetCategorias();
            categorias.Insert(0, new Categoria { Descricao = "" });
            cboCategoria.Items.AddRange(categorias.ToArray());

            var situacoes = _situacaoService.GetSituacoes();
            situacoes.Insert(0, new Situacao { Descricao = "" });
            cboSituacao.Items.AddRange(situacoes.ToArray());
        }
    }
}
