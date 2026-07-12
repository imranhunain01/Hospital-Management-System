using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO Users1 (FirstName, LastName, Email, Password) VALUES (@FirstName, @LastName, @Email, @Password)";

            var parameters = new Dictionary<string, object>()
            {
                {"@FirstName", textBox1.Text },
                {"@LastName", textBox2.Text },
                {"@Email", textBox3.Text },
                {"@Password", textBox4.Text }
            };

          
           
                bool success = Program.ExecuteQuery(query, parameters);

                if (success)
                {
                    Program.CurrentFirstName = textBox1.Text;
                    Program.CurrentLastName = textBox2.Text;
                    Program.CurrentEmail = textBox3.Text;

                    MessageBox.Show("Patient Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to register patient!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Show();
        }
    }
}