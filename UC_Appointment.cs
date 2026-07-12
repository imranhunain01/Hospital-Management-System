using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class UC_Appointment : UserControl
    {
        public UC_Appointment()
        {
            InitializeComponent();

            textBox1.Text = Program.CurrentFirstName + " " + Program.CurrentLastName;
            textBox2.Text = Program.CurrentAge;
            textBox3.Text = Program.CurrentDisease;

            LoadDoctors();
        }

        private void LoadDoctors()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Program.connectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT DoctorID, DoctorName, Availability FROM Doctors", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBox1.DisplayMember = "DoctorName";
                    comboBox1.ValueMember = "DoctorID";
                    comboBox1.DataSource = dt;

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message);
            }
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int doctorId = Convert.ToInt32(comboBox1.SelectedValue);
                using (SqlConnection con = new SqlConnection(Program.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Availability FROM Doctors WHERE DoctorID=@DoctorID", con);
                    cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                    var availability = cmd.ExecuteScalar()?.ToString();

                    comboBox1.Items.Clear();
                    if (!string.IsNullOrEmpty(availability))
                    {
                        string[] slots = availability.Split(',');
                        foreach (var slot in slots)
                        {
                            comboBox1.Items.Add(slot.Trim());
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading time slots: " + ex.Message);
            }
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                comboBox1.SelectedIndex == -1 ||
                comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO Appointments (PatientName, Age, Disease, DoctorID, AppointmentTime) " +
                           "VALUES (@Name, @Age, @Disease, @DoctorID, @AppointmentTime)";

            var parameters = new Dictionary<string, object>()
            {
                {"@Name", textBox1.Text },
                {"@Age", textBox2.Text },
                {"@Disease", textBox3.Text },
                {"@DoctorID", comboBox1.SelectedValue },
                {"@AppointmentTime", comboBox1.SelectedItem.ToString() }
            };

            try
            {
                Program.ExecuteQuery(query, parameters);
                MessageBox.Show("Appointment Scheduled!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
                comboBox1.SelectedIndex = -1;
                comboBox1.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving appointment: " + ex.Message);
            }
        }
    }
}
