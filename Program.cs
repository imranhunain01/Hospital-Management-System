using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
//using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    internal static class Program
    {
        public static string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Hospital_DB;Trusted_Connection=True;";

        public static string CurrentFirstName;
        public static string CurrentLastName;
        public static string CurrentEmail;
        public static string CurrentAge;
        public static string CurrentDisease;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPage());
        }
        public static bool ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }

                        con.Open();
                        cmd.ExecuteNonQuery();
                        return true; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false; 
            }
        }
    }
}
