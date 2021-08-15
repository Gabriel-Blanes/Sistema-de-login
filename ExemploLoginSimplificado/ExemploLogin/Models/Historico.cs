using System;

namespace ExemploLogin.Models
{
    public class Historico
    {
        public DateTime DataHora { get; set; }
        public int IdUsuario { get; set; }
        public string Tipo { get; set; }
        public string Justificativa { get; set; }
    }
}
