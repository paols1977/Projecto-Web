using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Services.Description;

namespace Inquerito2.App_Code
{
    public class DBConnect
    {
        private const string V = "INSERT INTO Restaurantes (nome, distrito, comida, clube) VALUES (@nome, @distrito, @comida, @clube)";
        private string connectionString = "Data Source=grandeporto.ddns.net;Initial Catalog=Prog22094;User ID=User22094;Password=AspNET2023!;";

        public bool ValidateUser(string username, string password)
        {
            // conectar ao banco de dados
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // consultar o banco de dados para verificar se o usuário e a senha são válidos
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                int count = (int)cmd.ExecuteScalar();

                // fechar a conexão com o banco de dados
                conn.Close();

                // retornar verdadeiro se o usuário e a senha são válidos, caso contrário, falso
                return count > 0;
            }
        }

        private MySqlConnection connection;
        private string server;
        private string database;
        private string Uid;
        private string password;
        private string port;
        private string connectionString;

        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "grandeporto.ddns.net"; //localhost OU // 127.0.0.1
            database = "Prog22094";
            Uid = "User22094"; // root
            password = "AspNET2023!"; // ""
            port = "3306";

            connectionString = "Server=" + server + ";Port=" + port + ";Database=" + database + ";Uid=" + Uid + ";Pwd=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool ValidateUser(string username, string password)
        {
            // conectar ao banco de dados
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // consultar o banco de dados para verificar se o usuário e a senha são válidos
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                int count = (int)cmd.ExecuteScalar();

                // fechar a conexão com o banco de dados
                conn.Close();

                // retornar verdadeiro se o usuário e a senha são válidos, caso contrário, falso
                return count > 0;
            }
        }

        public bool Insert(string nome, string distrito, string comida, string clube)
        {
            bool flag = true;
            try
            {
                string query = V;
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    SqlCommand comando = new SqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@distrito", distrito);
                    comando.Parameters.AddWithValue("@comida", comida);
                    comando.Parameters.AddWithValue("@clube", clube);
                    int linhasAfetadas = comando.ExecuteNonQuery();
                    if (linhasAfetadas == 0)
                    {
                        flag = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir o restaurante: " + ex.Message);
                flag = false;
            }
            return flag;
        }
    }
}


