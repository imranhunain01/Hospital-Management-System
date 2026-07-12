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
    public partial class UC_AddPatient : UserControl
    {
        public UC_AddPatient()
        {
            InitializeComponent();
        }

        private void UC_AddPatient_Load(object sender, EventArgs e)
        {

            textBox1.Text = Program.CurrentFirstName; 
            textBox2.Text = Program.CurrentLastName;  
            textBox3.Text = Program.CurrentEmail;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            comboBox1.Items.Add("Other");

            comboBox1.SelectedIndex = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
             $"FN={textBox1.Text}, LN={textBox2.Text}, Email={textBox3.Text}, " +
             $"Gender={(comboBox1.SelectedItem == null ? "NULL" : comboBox1.SelectedItem.ToString())}, " +
             $"Phone={textBox4.Text}, Age={textBox6.Text}, Disease={textBox5.Text}"
             );

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||   
                string.IsNullOrWhiteSpace(textBox2.Text) ||  
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                comboBox1.SelectedIndex == -1 ||            
                string.IsNullOrWhiteSpace(textBox4.Text) ||   
                string.IsNullOrWhiteSpace(textBox6.Text) ||   
                string.IsNullOrWhiteSpace(textBox5.Text))     
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = "INSERT INTO Patient (FirstName, LastName, Email, Gender, PhoneNumber, Age, Disease) " +
                               "VALUES (@FirstName, @LastName, @Email, @Gender, @PhoneNumber, @Age, @Disease)";

                var parameters = new Dictionary<string, object>()
        {
                 {"@FirstName", textBox1.Text },
                 {"@LastName", textBox2.Text },
                 {"@Email", textBox3.Text },
                 {"@Gender", comboBox1.SelectedItem.ToString() },
                 {"@PhoneNumber", textBox4.Text },
                 {"@Age", int.Parse(textBox6.Text) },
                 {"@Disease", textBox5.Text }
        };

                Program.ExecuteQuery(query, parameters);

                Program.CurrentFirstName = textBox1.Text;
                Program.CurrentLastName = textBox2.Text;
                Program.CurrentEmail = textBox3.Text;
                Program.CurrentAge = textBox5.Text;
                Program.CurrentDisease = textBox6.Text;

                MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = 0;
                textBox4.Clear();
                textBox6.Clear();
                textBox5.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding patient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
       
