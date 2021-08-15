using System;

namespace ExemploLogin.Models
{
    public class UsuarioHistorico : Usuario
    {
        public int IdHistorico { get; set; }
        public DateTime DataHoraHistorico { get; set; }
        public int IdUsuarioHistorico { get; set; }
        public string TipoHistorico { get; set; }
        public string JustificativaHistorico { get; set; }
    }
}
