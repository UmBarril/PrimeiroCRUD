using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD
{
     static class Db
    {
        public static MySqlConnection connection = new MySqlConnection();
        public static string username;
        public static string password;
        public static bool Connect()
        {
            try
            {
                connection = new MySqlConnection($"Server=localhost;Database=test;Port=3306;Uid={ username };Pwd={ password };");
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    Thread.Sleep(3000);
                    if (connection.State == System.Data.ConnectionState.Open) return true;
                    else if (connection.State == System.Data.ConnectionState.Closed) return false;
                    else MessageBox.Show("ué"); return false;

                } 
                else 
                {
                    MessageBox.Show("Já há uma conexão existente!");
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static void Disconnect()
        {            
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            } else
            {
                MessageBox.Show("Não há nenhuma conexão que possa ser fechada!");
            }                
        }
    }
}
