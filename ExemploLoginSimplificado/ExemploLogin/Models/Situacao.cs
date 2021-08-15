namespace ExemploLogin.Models
{
    public class Situacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
