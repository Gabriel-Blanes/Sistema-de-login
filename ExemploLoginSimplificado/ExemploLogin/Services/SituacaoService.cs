using ExemploLogin.Database;
using ExemploLogin.Models;
using System.Collections.Generic;

namespace ExemploLogin.Services
{
    public class SituacaoService
    {
        private readonly UsuarioSituacaoDb _db = new UsuarioSituacaoDb();


        public Situacao GetSituacao(int id)
        {
            return _db.Get(id);
        }
        public List<Situacao> GetSituacoes()
        {
            return _db.GetList();
        }
    }
}
