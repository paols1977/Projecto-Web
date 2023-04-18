using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Inquerito2
{
    public class DBConnect
    {


        private SQLiteConnection connection;

        public DBConnect() {



            Initialize();
        
        
        }


        private void Initialize()
        {

            string connectionString;

            string path = AppDomain.CurrentDomain.BaseDirectory + "bin\\";
            connectionString = "Data Source=" + path + "Inquerito.db; Version=3;";

            connection = new SQLiteConnection(connectionString);

        }
        private bool OpenConnection()
        {

            try
            {

                connection.Open();
                return true;


            }

            catch(SQLiteException ex)
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

            catch (SQLiteException ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Insert(string nome,string distrito,string comida, string clube)
        {

            bool flag = true;
            try
            {
                string query = "inset into dados(nome,distrito,comida,clube)values('" + nome + "','" + distrito + "','" + comida + "','" + clube + "');";
                if (OpenConnection())
                {
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    cmd.ExecuteNonQuery();


                }
            }

            catch (SQLiteException ex)
            {

                Debug.WriteLine(ex.Message);
                flag = false;
            }

            finally
            {
                CloseConnection();

            }
            return flag;
        }



    }
}