using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Repositories
{
    public class DatabaseManager
    {
        private static SQLiteConnection conn;

        public static SQLiteConnection GetConnection()
        {
            if (conn == null)
            {
                conn = new SQLiteConnection("Data Source=unicomtic.db;Version=3;");
            }

            if (conn.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Database connection failed: " + ex.Message);
                    throw;
                }
            }

            return conn;
        }
    }
}



