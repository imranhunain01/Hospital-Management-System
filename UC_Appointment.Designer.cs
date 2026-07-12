namespace Hospital_Management_System
{
    partial class UC_Appointment
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;   // Heading
        private System.Windows.Forms.Label label2;   // Name
        private System.Windows.Forms.Label label3;   // Age
        private System.Windows.Forms.Label label4;   // Disease
        private System.Windows.Forms.Label label5;   // Select Doctor
        private System.Windows.Forms.Label label6;   // Select Time

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(245, 74);
            label1.Name = "label1";
            label1.Size = new Size(216, 25);
            label1.TabIndex = 0;
            label1.Text = "Schedule Appointment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 124);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 164);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 3;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 204);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 5;
            label4.Text = "Disease:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 244);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 7;
            label5.Text = "Select Doctor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(145, 284);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 9;
            label6.Text = "Select Time:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(245, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(245, 204);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.Location = new Point(245, 244);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(245, 284);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(245, 334);
            button1.Name = "button1";
            button1.Size = new Size(200, 23);
            button1.TabIndex = 11;
            button1.Text = "Schedule Appointment";
            button1.Click += button1_Click;
            // 
            // UC_Appointment
            // 
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Name = "UC_Appointment";
            Size = new Size(617, 411);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
