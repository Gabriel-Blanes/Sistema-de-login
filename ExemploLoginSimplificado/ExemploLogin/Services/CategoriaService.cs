using ExemploLogin.Database;
using ExemploLogin.Models;
using System.Collections.Generic;

namespace ExemploLogin.Services
{
    public class CategoriaService
    {
        private readonly UsuarioCategoriaDb _db = new UsuarioCategoriaDb();


        public Categoria GetCategoria(int id)
        {
            return _db.Get(id);
        }
        public List<Categoria> GetCategorias()
        {
            return _db.GetList();
        }
    }
}
