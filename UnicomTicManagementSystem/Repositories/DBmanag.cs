using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace UnicomTicManagementSystem.Repositories
{
    internal class DBmanag
    {
        private static readonly string DbFolder = Path.Combine(Application.StartupPath, "Data");
        private static readonly string DbPath = Path.Combine(DbFolder, "users.db");

        public static string ConnectionString => $"Data Source={DbPath};Version=3;";

        public static void InitializeDatabase()
        {
            try
            {
                // Create folder if it doesn't exist
                if (!Directory.Exists(DbFolder))
                    Directory.CreateDirectory(DbFolder);

                // Create DB if it doesn't exist
                if (!File.Exists(DbPath))
                {
                    SQLiteConnection.CreateFile(DbPath);

                    using (var conn = new SQLiteConnection(ConnectionString))
                    {
                        conn.Open();

                        // Create tables
                        string createTables = @"
                            CREATE TABLE Users (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Username TEXT NOT NULL,
                                Name TEXT NOT NULL,
                                Password TEXT NOT NULL,
                                Role TEXT NOT NULL
                            );";

                        using (var cmd = new SQLiteCommand(createTables, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }     
