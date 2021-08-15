namespace ExemploLogin.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public int IdCategoria { get; set; }
        public int IdSituacao { get; set; }
    }
}
