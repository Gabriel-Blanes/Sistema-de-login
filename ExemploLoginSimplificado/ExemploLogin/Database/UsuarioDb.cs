using ExemploLogin.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace ExemploLogin.Database
{
    public class UsuarioDb
    {
        private readonly Connection _connection = new Connection();
        private readonly UsuarioHistoricoDb _historicoDb = new UsuarioHistoricoDb();

        // Tamanho máximo dos campos na tabela.
        public int NomeUsuarioMaxLenght => 50;
        public int SenhaMaxLenght => 15;

        
        // Funções Get:
        public Usuario Get(int id)
        {
            using (var conn = _connection.CreateConnection())
            {
                var sql =
                "SELECT ID,\n" +
                "       NOMEUSUARIO,\n" +
                "       SENHA,\n" +
                "       ID_CATEGORIA,\n" +
                "       ID_SITUACAO\n" +
                "  FROM USUARIOS\n" +
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
        public Usuario GetByNomeUsuario(string nomeUsuario)
        {
            using (var conn = _connection.CreateConnection())
            {
                var sql =
                "SELECT ID,\n" +
                "       NOMEUSUARIO,\n" +
                "       SENHA,\n" +
                "       ID_CATEGORIA,\n" +
                "       ID_SITUACAO\n" +
                "  FROM USUARIOS\n" +
                " WHERE NOMEUSUARIO = @P_NOMEUSUARIO";

                var command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("P_NOMEUSUARIO", nomeUsuario);

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
        public List<Usuario> GetList()
        {
            using (var conn = _connection.CreateConnection())
            {
                var sql =
                "SELECT ID,\n" +
                "       NOMEUSUARIO,\n" +
                "       SENHA,\n" +
                "       ID_CATEGORIA,\n" +
                "       ID_SITUACAO\n" +
                "  FROM USUARIOS\n" +
                " ORDER BY NOMEUSUARIO";

                var command = new MySqlCommand(sql, conn);

                conn.Open();

                using (var dr = command.ExecuteReader())
                {
                    var list = new List<Usuario>();

                    while (dr.Read())
                    {
                        list.Add(DoMapping(dr));
                    }

                    return list;
                }
            }
        }
        public List<Usuario> GetList(int? id, string nomeUsuario, int? idCategoria, int? idSituacao)
        {
            using (var conn = _connection.CreateConnection())
            {
                var command = new MySqlCommand("", conn);

                var sql =
                "SELECT ID,\n" +
                "       NOMEUSUARIO,\n" +
                "       SENHA,\n" +
                "       ID_CATEGORIA,\n" +
                "       ID_SITUACAO\n" +
                "  FROM USUARIOS\n" +
                " WHERE ID != 0\n";

                if (id.HasValue)
                {
                    sql += "   AND ID = @P_ID\n";
                    command.Parameters.AddWithValue("P_ID", id.Value);
                }
                if (!string.IsNullOrEmpty(nomeUsuario))
                {
                    sql += "   AND NOMEUSUARIO LIKE @P_NOMEUSUARIO\n";
                    command.Parameters.AddWithValue("P_NOMEUSUARIO", $"%{nomeUsuario}%");
                }
                if (idCategoria.HasValue)
                {
                    sql += "   AND ID_CATEGORIA = @P_ID_CATEGORIA\n";
                    command.Parameters.AddWithValue("P_ID_CATEGORIA", idCategoria.Value);
                }
                if (idSituacao.HasValue)
                {
                    sql += "   AND ID_SITUACAO = @P_ID_SITUACAO\n";
                    command.Parameters.AddWithValue("P_ID_SITUACAO", idSituacao.Value);
                }

                sql += " ORDER BY NOMEUSUARIO";

                command.CommandText = sql;

                conn.Open();

                using (var dr = command.ExecuteReader())
                {
                    var list = new List<Usuario>();

                    while (dr.Read())
                    {
                        list.Add(DoMapping(dr));
                    }

                    return list;
                }
            }
        }
        public List<UsuarioHistorico> GetHistorico(int id)
        {
            // Delega a solicitação para a classe responsável.
            return _historicoDb.GetList(id);
        }

        // Funções Set:
        public void Insert(Usuario usuario)
        {
            using (var conn = _connection.CreateConnection())
            {
                var sql =
                "INSERT INTO USUARIOS\n" +
                "( NOMEUSUARIO, SENHA, ID_CATEGORIA, ID_SITUACAO )\n" +
                "VALUES\n" +
                "( @P_NOMEUSUARIO, @P_SENHA, @P_ID_CATEGORIA, @P_ID_SITUACAO )";

                var command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("P_NOMEUSUARIO", usuario.NomeUsuario);
                command.Parameters.AddWithValue("P_SENHA", usuario.Senha);
                command.Parameters.AddWithValue("P_ID_CATEGORIA", usuario.IdCategoria);
                command.Parameters.AddWithValue("P_ID_SITUACAO", usuario.IdSituacao);

                conn.Open();
                command.Transaction = conn.BeginTransaction();

                try
                {
                    command.ExecuteNonQuery();

                    // obtém o Id.
                    usuario.Id = Convert.ToInt32(command.LastInsertedId);

                    // Grava Histórico
                    _historicoDb.Insert(usuario, command, new Historico { Tipo = "INCLUSAO" });

                    command.Transaction.Commit();
                }
                catch (Exception)
                {
                    command.Transaction.Rollback();
                    usuario.Id = 0;     // Limpa o Id.
                    throw;
                }
            }
        }
        public void Update(Usuario usuario)
        {
            using (var conn = _connection.CreateConnection())
            {
                var sql =
                "UPDATE USUARIOS\n" +
                "   SET NOMEUSUARIO = @P_NOMEUSUARIO,\n" +
                "       SENHA = @P_SENHA,\n" +
                "       ID_CATEGORIA = @P_ID_CATEGORIA,\n" +
                "       ID_SITUACAO = @P_ID_SITUACAO\n" +
                " WHERE ID = @P_ID";

                var command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("P_NOMEUSUARIO", usuario.NomeUsuario);
                command.Parameters.AddWithValue("P_SENHA", usuario.Senha);
                command.Parameters.AddWithValue("P_ID_CATEGORIA", usuario.IdCategoria);
                command.Parameters.AddWithValue("P_ID_SITUACAO", usuario.IdSituacao);
                command.Parameters.AddWithValue("P_ID", usuario.Id);

                conn.Open();
                command.Transaction = conn.BeginTransaction();

                try
                {
                    var result = command.ExecuteNonQuery();

                    // Verifica resultado do Update.
                    if (result == 0)
                        throw new Exception("O comando não atualizou nenhum usuário!");

                    // Grava Histórico.
                    _historicoDb.Insert(usuario, command, new Historico { Tipo = "ALTERACAO" });

                    command.Transaction.Commit();
                }
                catch (Exception)
                {
                    command.Transaction.Rollback();
                    throw;
                }
            }
        }


        /// <summary>
        /// Realiza o mapeamento padrão da tabela para um objeto.
        /// </summary>
        /// <param name="dr">DataReader contendo o resultado da consulta.</param>
        private Usuario DoMapping(IDataReader dr)
        {
            var obj = new Usuario();

            obj.Id = Convert.ToInt32(dr["ID"]);
            obj.NomeUsuario = Convert.ToString(dr["NOMEUSUARIO"]);
            obj.Senha = Convert.ToString(dr["SENHA"]);
            obj.IdCategoria = Convert.ToInt32(dr["ID_CATEGORIA"]);
            obj.IdSituacao = Convert.ToInt32(dr["ID_SITUACAO"]);

            return obj;
        }
    }
}
