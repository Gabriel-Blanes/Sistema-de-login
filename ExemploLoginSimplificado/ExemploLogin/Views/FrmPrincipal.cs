using ExemploLogin.Views.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploLogin.Views
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Resources.NomeSistema;
            lblStatusUsuario.Text = Sessao.Usuario.NomeUsuario;
        }

        private void FazerLogoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowLoginView();
        }
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Cadastros.FrmCadUsuarios();
            form.Show();
        }
    }
}
