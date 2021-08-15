using ExemploLogin.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace ExemploLogin.Database
{
    public class UsuarioHistoricoDb
    {
        private readonly Connection _connection = new Connection();


        public List<UsuarioHistorico> GetList(int idUsuario)
        {
            using (var conn = _connection.CreateConnection())
            {
                var sql =
                "SELECT ID_HIST,\n" +
                "       ID_USUARIO,\n" +
                "       NOMEUSUARIO,\n" +
                "       SENHA,\n" +
                "       ID_CATEGORIA,\n" +
                "       ID_SITUACAO,\n" +
                "       DATAHORA_HIST,\n" +
                "       ID_USUARIO_HIST,\n" +
                "       TIPO_HIST,\n" +
                "       JUSTIF_HIST\n" +
                "  FROM USUARIOS_HIST\n" +
                " WHERE ID_USUARIO = " + idUsuario;

                var command = new MySqlCommand(sql, conn);

                conn.Open();

                using (var dr = command.ExecuteReader())
                {
                    var list = new List<UsuarioHistorico>();

                    while (dr.Read())
                    {
                        list.Add(DoMapping(dr));
                    }

                    return list;
                }
            }
        }

        public void Insert(Usuario usuario, MySqlCommand comandoExecutado, Historico historico)
        {
            var sql =
            "INSERT INTO USUARIOS_HIST\n" +
            "(\n" +
            "    ID_USUARIO,\n" +
            "    NOMEUSUARIO,\n" +
            "    SENHA,\n" +
            "    ID_CATEGORIA,\n" +
            "    ID_SITUACAO,\n" +
            "    ID_USUARIO_HIST,\n" +
            "    TIPO_HIST,\n" +
            "    JUSTIF_HIST\n" +
            ")\n" +
            "VALUES\n" +
            "(\n" +
            "    @P_ID_USUARIO,\n" +
            "    @P_NOMEUSUARIO,\n" +
            "    @P_SENHA,\n" +
            "    @P_ID_CATEGORIA,\n" +
            "    @P_ID_SITUACAO,\n" +
            "    @P_ID_USUARIO_HIST,\n" +
            "    @P_TIPO_HIST,\n" +
            "    @P_JUSTIF_HIST\n" +
            ")";

            var command = new MySqlCommand(sql, comandoExecutado.Connection);
            command.Transaction = comandoExecutado.Transaction;

            command.Parameters.AddWithValue("P_ID_USUARIO", usuario.Id);
            command.Parameters.AddWithValue("P_NOMEUSUARIO", usuario.NomeUsuario);
            command.Parameters.AddWithValue("P_SENHA", usuario.Senha);
            command.Parameters.AddWithValue("P_ID_CATEGORIA", usuario.IdCategoria);
            command.Parameters.AddWithValue("P_ID_SITUACAO", usuario.IdSituacao);
            command.Parameters.AddWithValue("P_ID_USUARIO_HIST", Sessao.Usuario.Id);
            command.Parameters.AddWithValue("P_TIPO_HIST", historico.Tipo);
            command.Parameters.AddWithValue("P_JUSTIF_HIST", historico.Justificativa);

            command.ExecuteNonQuery();
        }


        private UsuarioHistorico DoMapping(IDataReader dr)
        {
            var obj = new UsuarioHistorico();

            obj.IdHistorico = Convert.ToInt32(dr["ID_HIST"]);
            obj.Id = Convert.ToInt32(dr["ID_USUARIO"]);
            obj.NomeUsuario = Convert.ToString(dr["NOMEUSUARIO"]);
            obj.Senha = Convert.ToString(dr["SENHA"]);
            obj.IdCategoria = Convert.ToInt32(dr["ID_CATEGORIA"]);
            obj.IdSituacao = Convert.ToInt32(dr["ID_SITUACAO"]);

            obj.DataHoraHistorico = Convert.ToDateTime(dr["DATAHORA_HIST"]);
            obj.IdUsuarioHistorico = Convert.ToInt32(dr["ID_USUARIO_HIST"]);
            obj.TipoHistorico = Convert.ToString(dr["TIPO_HIST"]);
            obj.JustificativaHistorico = Convert.ToString(dr["JUSTIF_HIST"]);

            return obj;
        }
    }
}
