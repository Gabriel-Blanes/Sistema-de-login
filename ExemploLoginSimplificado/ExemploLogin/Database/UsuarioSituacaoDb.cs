using ExemploLogin.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace ExemploLogin.Database
{
    public class UsuarioSituacaoDb
    {
        private readonly Connection _connection = new Connection();


        public Situacao Get(int id)
        {
            using (var conn = _connection.CreateConnection())
            {
                var sql =
                "SELECT ID,\n" +
                "       DESCRICAO\n" +
                "  FROM USUARIOS_SIT\n" +
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
        public List<Situacao> GetList()
        {
            using (var conn = _connection.CreateConnection())
            {
                var sql =
                "SELECT ID,\n" +
                "       DESCRICAO\n" +
                "  FROM USUARIOS_SIT";

                var command = new MySqlCommand(sql, conn);

                conn.Open();

                using (var dr = command.ExecuteReader())
                {
                    var list = new List<Situacao>();

                    while (dr.Read())
                    {
                        list.Add(DoMapping(dr));
                    }

                    return list;
                }
            }
        }


        private Situacao DoMapping(IDataReader dr)
        {
            var obj = new Situacao();

            obj.Id = Convert.ToInt32(dr["ID"]);
            obj.Descricao = Convert.ToString(dr["DESCRICAO"]);

            return obj;
        }
    }
}
