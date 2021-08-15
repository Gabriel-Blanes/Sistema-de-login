using ExemploLogin.Models;
using ExemploLogin.Services;
using ExemploLogin.Views.Utils;
using ExemploLogin.Workbench;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploLogin.Views.Cadastros
{
    public partial class FrmCadUsuarios : Form
    {
        private readonly UsuarioService _usuarioService = new UsuarioService();
        private readonly CategoriaService _categoriaService = new CategoriaService();
        private readonly SituacaoService _situacaoService = new SituacaoService();

        private bool modoEdicao = false;

        public Usuario Usuario { get; private set; }
        public List<UsuarioHistorico> Historico { get; private set; }

        public List<Categoria> Categorias { get; private set; }
        public List<Situacao> Situacoes { get; private set; }


        public FrmCadUsuarios()
        {
            InitializeComponent();
        }


        private void FrmCadUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                CarregarCombos();
                HabilitarCampos(false);
                HabilitarBotoesCadastroPadrao(false);
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FrmBuscarUsuario();
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    Usuario = form.UsuarioSelecionado;
                    SetUsuarioNaTela();

                    HabilitarCampos(false);
                    HabilitarBotoesCadastro(sender);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                modoEdicao = false;
                Usuario = new Usuario();

                this.LimparCampos();
                HabilitarCampos();
                HabilitarBotoesCadastro(sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                modoEdicao = true;

                HabilitarCampos();
                HabilitarBotoesCadastro(sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string verbo = modoEdicao ? "atualizar" : "incluir";
            string acao = modoEdicao ? "Atualização" : "Inclusão";
            string conclusao = modoEdicao ? "atualizado" : "incluído";

            try
            {
                Cursor = Cursors.WaitCursor;

                string mensagem = $"Deseja realmente {verbo} este usuário?";
                if (MessageBox.Show(mensagem, acao, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    // Obtém as alterações realizadas na tela e atualiza o objeto.
                    AtualizaObjetoUsuario();

                    _usuarioService.Salvar(Usuario);

                    SetUsuarioNaTela();
                    HabilitarCampos(false);
                    HabilitarBotoesCadastro(sender);

                    MessageBox.Show($"Usuário {conclusao} com sucesso!", $"{acao}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao tentar {verbo} este usuário. \n" + ex.Message, $"Erro! {acao}!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (modoEdicao)
                    SetUsuarioNaTela();
                else
                    this.LimparCampos();

                HabilitarCampos(false);
                HabilitarBotoesCadastro(sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHistorico_Click(object sender, EventArgs e)
        {
            var form = new FrmHistoricoUsuario(Historico);
            form.ShowDialog();
        }


        private void CarregarCombos()
        {
            Categorias = _categoriaService.GetCategorias();
            cboCategoria.Items.AddRange(Categorias.ToArray());

            Situacoes = _situacaoService.GetSituacoes();
            cboSituacao.Items.AddRange(Situacoes.ToArray());
        }

        private void HabilitarCampos(bool value = true)
        {
            var readOnly = !value;

            txtNomeUsuario.ReadOnly = readOnly;
            txtSenha.ReadOnly = readOnly;

            cboCategoria.Enabled = value;
            cboSituacao.Enabled = value;
        }
        private void HabilitarBotoesCadastro(object sender)
        {
            if (sender is Button button)
            {
                if (button.Name == btnNovo.Name)
                {
                    btnBuscar.Enabled = false;
                    btnNovo.Enabled = false;
                    btnEditar.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnCancelar.Enabled = true;

                    modoEdicao = false;
                }
                else if (button.Name == btnEditar.Name)
                {
                    btnBuscar.Enabled = false;
                    btnNovo.Enabled = false;
                    btnEditar.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnCancelar.Enabled = true;

                    modoEdicao = true;
                }
                else if (button.Name == btnCancelar.Name)
                {
                    HabilitarBotoesCadastroPadrao(modoEdicao);
                }
                else
                {
                    HabilitarBotoesCadastroPadrao();
                }
            }
        }
        private void HabilitarBotoesCadastroPadrao(bool btnEditar = true)
        {
            btnBuscar.Enabled = true;
            btnNovo.Enabled = true;
            this.btnEditar.Enabled = btnEditar;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void AtualizaObjetoUsuario()
        {
            Usuario.NomeUsuario = txtNomeUsuario.Text;
            Usuario.Senha = txtSenha.Text;

            var categoria = cboCategoria.SelectedItem as Categoria;
            if (categoria != null)
                Usuario.IdCategoria = categoria.Id;
            else
                Usuario.IdCategoria = 0;

            var situacao = cboSituacao.SelectedItem as Situacao;
            if (situacao != null)
                Usuario.IdSituacao = situacao.Id;
            else
                Usuario.IdSituacao = 0;
        }
        private void SetUsuarioNaTela()
        {
            if (Usuario != null)
            {
                txtId.Text = Usuario.Id.ToString();
                txtNomeUsuario.Text = Usuario.NomeUsuario;
                txtSenha.Text = Usuario.Senha;

                cboCategoria.SelectedItem = Categorias.FirstOrDefault(c => c.Id == Usuario.IdCategoria);
                cboSituacao.SelectedItem = Situacoes.FirstOrDefault(c => c.Id == Usuario.IdSituacao);

                SetHistoricoNaTela();
            }
            else
            {
                this.LimparCampos();
            }
        }
        private void SetHistoricoNaTela()
        {
            Historico = _usuarioService.GetHistorico(Usuario);

            var ultimoHistorico = Historico?.OrderByDescending(h => h.DataHoraHistorico).FirstOrDefault();
            if (ultimoHistorico != null)
            {
                txtDataHoraHist.Text = ultimoHistorico.DataHoraHistorico.ToString("dd/MM/yyyy HH:mm");

                var usuarioHist = _usuarioService.GetUsuario(ultimoHistorico.IdUsuarioHistorico);
                txtUsuarioHist.Text = usuarioHist.NomeUsuario;

                txtTipoHist.Text = ultimoHistorico.TipoHistorico;
            }
            else
            {
                grbHistorico.LimparCampos();
            }
        }
    }
}
