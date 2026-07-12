namespace Hospital_Management_System
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            label1 = new Label();
            button2 = new Button();
            AddPatient = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_08_28_at_12_26_04_08f4a921;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(AddPatient);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 484);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(33, 304);
            button4.Name = "button4";
            button4.Size = new Size(149, 35);
            button4.TabIndex = 3;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(33, 247);
            button3.Name = "button3";
            button3.Size = new Size(149, 35);
            button3.TabIndex = 2;
            button3.Text = "Appointment Schedule";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(45, 46);
            label1.Name = "label1";
            label1.Size = new Size(122, 24);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(33, 188);
            button2.Name = "button2";
            button2.Size = new Size(149, 35);
            button2.TabIndex = 1;
            button2.Text = "View Doctor";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AddPatient
            // 
            AddPatient.BackColor = SystemColors.ActiveCaption;
            AddPatient.Location = new Point(33, 132);
            AddPatient.Name = "AddPatient";
            AddPatient.Size = new Size(149, 35);
            AddPatient.TabIndex = 0;
            AddPatient.Text = "Add Patient";
            AddPatient.UseVisualStyleBackColor = false;
            AddPatient.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.hospital_management_system_in_kenya;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(223, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(664, 484);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 481);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button AddPatient;
    }
}