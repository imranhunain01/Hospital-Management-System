using System;
using System.Data;
//using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class UC_ViewDoctor : UserControl 
    {
        public UC_ViewDoctor()
        {
            InitializeComponent();
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            try
            {
               string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Hospital_DB;Trusted_Connection=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT DoctorName, Specialization, Availability FROM Doctors";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message);
            }
        }
    }
}
