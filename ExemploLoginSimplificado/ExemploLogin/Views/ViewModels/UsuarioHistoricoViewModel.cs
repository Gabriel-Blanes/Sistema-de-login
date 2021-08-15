using System;

namespace ExemploLogin.Views.ViewModels
{
    public class UsuarioHistoricoViewModel
    {
        public int IdHistorico { get; set; }
        public DateTime DataHora { get; set; }
        public string Usuario { get; set; }
        public string Acao { get; set; }

        public string NomeUsuario { get; set; }
        public string Categoria { get; set; }
        public string Situacao { get; set; }
    }
}
