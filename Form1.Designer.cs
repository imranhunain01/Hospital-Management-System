namespace Hospital_Management_System
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLogin = new Panel();
            button2 = new Button();
            label1 = new Label();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.WhiteSmoke;
            panelLogin.BorderStyle = BorderStyle.Fixed3D;
            panelLogin.Controls.Add(button2);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(label4);
            panelLogin.Controls.Add(button1);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(textBox2);
            panelLogin.Controls.Add(textBox1);
            panelLogin.Location = new Point(1, -2);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(452, 506);
            panelLogin.TabIndex = 0;
            panelLogin.Paint += panelLogin_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(175, 362);
            button2.Name = "button2";
            button2.Size = new Size(82, 28);
            button2.TabIndex = 8;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 342);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 7;
            label1.Text = "Don't have an account?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(69, 73);
            label4.Name = "label4";
            label4.Size = new Size(308, 36);
            label4.TabIndex = 6;
            label4.Text = "CCS Hospital System";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(109, 295);
            button1.Name = "button1";
            button1.Size = new Size(213, 30);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(108, 229);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 162);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 251);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 1;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_08_28_at_12_26_04_772ad98a;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(880, 496);
            Controls.Add(panelLogin);
            Name = "LoginPage";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}
