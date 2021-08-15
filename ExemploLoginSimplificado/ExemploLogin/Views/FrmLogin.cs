using ExemploLogin.Models.Exceptions;
using ExemploLogin.Services;
using ExemploLogin.Views.Utils;
using System;
using System.Windows.Forms;

namespace ExemploLogin.Views
{
    public partial class FrmLogin : Form
    {
        private readonly UsuarioService _usuarioService = new UsuarioService();


        public FrmLogin()
        {
            InitializeComponent();
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Resources.NomeSistema;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                Sessao.Usuario = _usuarioService.FazerLogin(txtNomeUsuario.Text, txtSenha.Text);
                this.ShowPrincipalView();
            }
            catch (LoginException ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar realizar o login! \n" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
