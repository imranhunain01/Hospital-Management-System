using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class Dashboard : Form
    {
        private void LoadForm(UserControl uc)
        {
            panel2.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Add(uc);
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_AddPatient obj = new UC_AddPatient();
            LoadForm(obj);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_ViewDoctor obj = new UC_ViewDoctor();
            LoadForm(obj);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_Appointment obj = new UC_Appointment();
            LoadForm(obj);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Show();
        }
    }
}
