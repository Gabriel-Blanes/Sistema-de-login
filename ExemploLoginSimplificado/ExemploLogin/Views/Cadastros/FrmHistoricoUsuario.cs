using ExemploLogin.Models;
using ExemploLogin.Services;
using ExemploLogin.Views.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExemploLogin.Views.Cadastros
{
    public partial class FrmHistoricoUsuario : Form
    {
        private readonly UsuarioService _usuarioService = new UsuarioService();
        private readonly CategoriaService _categoriaService = new CategoriaService();
        private readonly SituacaoService _situacaoService = new SituacaoService();

        public List<UsuarioHistorico> Historico { get; private set; }


        public FrmHistoricoUsuario(List<UsuarioHistorico> historico)
        {
            InitializeComponent();

            Historico = historico;
        }


        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                CarregarGrid();
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

        private void FrmHistorico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CarregarGrid()
        {
            var list = new List<UsuarioHistoricoViewModel>();

            var usuarios = _usuarioService.GetUsuarios();
            var categorias = _categoriaService.GetCategorias();
            var situacoes = _situacaoService.GetSituacoes();

            foreach (var hist in Historico)
            {
                var obj = new UsuarioHistoricoViewModel();

                obj.IdHistorico = hist.IdHistorico;
                obj.DataHora = hist.DataHoraHistorico;
                obj.Usuario = usuarios.FirstOrDefault(u => u.Id == hist.IdUsuarioHistorico)?.NomeUsuario;
                obj.Acao = hist.TipoHistorico;

                obj.NomeUsuario = hist.NomeUsuario;
                obj.Categoria = categorias.FirstOrDefault(c => c.Id == hist.IdCategoria)?.Descricao;
                obj.Situacao = situacoes.FirstOrDefault(s => s.Id == hist.IdSituacao)?.Descricao;

                list.Add(obj);
            }

            dataGridView.DataSource = list;
        }
    }
}
