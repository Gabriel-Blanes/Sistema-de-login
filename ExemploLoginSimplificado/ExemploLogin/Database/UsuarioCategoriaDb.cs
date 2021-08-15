using ExemploLogin.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace ExemploLogin.Database
{
    public class UsuarioCategoriaDb
    {
        private readonly Connection _connection = new Connection();


        public Categoria Get(int id)
        {
            using (var conn = _connection.CreateConnection())
            {
                var sql =
                "SELECT ID,\n" +
                "       DESCRICAO\n" +
                "  FROM USUARIOS_CATEG\n" +
                " WHERE ID = " + id;

                var command = new MySqlCommand(sql, conn);

                conn.Open();

                using (var dr = command.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return DoMapping(dr);
                    }

                    return null;
                }
            }
        }
        public List<Categoria> GetList()
        {
            using (var conn = _connection.CreateConnection())
            {
                var sql =
                "SELECT ID,\n" +
                "       DESCRICAO\n" +
                "  FROM USUARIOS_CATEG";

                var command = new MySqlCommand(sql, conn);

                conn.Open();

                using (var dr = command.ExecuteReader())
                {
                    var list = new List<Categoria>();

                    while (dr.Read())
                    {
                        list.Add(DoMapping(dr));
                    }

                    return list;
                }
            }
        }


        private Categoria DoMapping(IDataReader dr)
        {
            var obj = new Categoria();

            obj.Id = Convert.ToInt32(dr["ID"]);
            obj.Descricao = Convert.ToString(dr["DESCRICAO"]);

            return obj;
        }
    }
}
