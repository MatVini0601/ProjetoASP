using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace POO3D3309.DAL
{

    // Credits: Matheus Vinicius: 33 e Gabriel Henrique: 09
    public class DatabaseConnection
    {
        private MySqlConnection conexao;

        private string conInfo = "persist security info = false;" +
                                 "server = localhost;" +
                                 "database = bd_Gravadora;" +
                                 "user = root;" + "pwd = ;";

        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(conInfo);
                conexao.Open();
            }
            catch (MySqlException err)
            {
                throw new Exception("Erro na conexão" + err.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        public void ExecuteCommand(string sql)
        {
            try
            {
                Conectar();
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException err)
            {
                throw new Exception("Error");
            }
        }

        public DataTable ExecuteQuery(string sql)
        {
            try
            {
                Conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter data = new MySqlDataAdapter(sql, conexao);
                data.Fill(dt);
                return dt;
            }
            catch (MySqlException err)
            {
                throw new Exception($"Erro na Query {err}");
            }
        }
    }
}