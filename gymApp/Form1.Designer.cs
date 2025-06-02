namespace gymApp
{
    partial class Form1
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

        private PictureBox GetPictureBox1()
        {
            return pictureBox1;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            Login_button = new Button();
            textBox_username = new TextBox();
            pictureBox5 = new PictureBox();
            textBox_password = new TextBox();
            button1 = new Button();
            button_minimize = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.King_bodybuilding_and_gym_logo_vector_image_Png;
            pictureBox1.Location = new Point(159, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._7a11b9f739c130eed437d1a237cc3b7d;
            pictureBox2.Location = new Point(-95, -64);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(533, 591);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 6);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 6);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(62, 128);
            label3.Name = "label3";
            label3.Size = new Size(290, 39);
            label3.TabIndex = 4;
            label3.Text = "Welcome to Gym";
            label3.Click += label3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.torso;
            pictureBox3.Location = new Point(62, 265);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.ForeColor = Color.CornflowerBlue;
            panel1.Location = new Point(62, 302);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 1);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.CornflowerBlue;
            panel2.Location = new Point(62, 382);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 1);
            panel2.TabIndex = 7;
            // 
            // Login_button
            // 
            Login_button.BackColor = Color.White;
            Login_button.FlatStyle = FlatStyle.Popup;
            Login_button.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_button.ForeColor = Color.Red;
            Login_button.Location = new Point(133, 413);
            Login_button.Margin = new Padding(3, 2, 3, 2);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(172, 33);
            Login_button.TabIndex = 9;
            Login_button.Text = "LOGIN";
            Login_button.UseVisualStyleBackColor = false;
            Login_button.Click += Login_button_Click;
            // 
            // textBox_username
            // 
            textBox_username.AccessibleName = "";
            textBox_username.BackColor = Color.White;
            textBox_username.BorderStyle = BorderStyle.None;
            textBox_username.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_username.ForeColor = SystemColors.ActiveCaptionText;
            textBox_username.Location = new Point(107, 274);
            textBox_username.Margin = new Padding(3, 2, 3, 2);
            textBox_username.Name = "textBox_username";
            textBox_username.PlaceholderText = "Username";
            textBox_username.Size = new Size(264, 16);
            textBox_username.TabIndex = 10;
            textBox_username.Tag = "";
            textBox_username.TextChanged += username_TextChanged;
            textBox_username.KeyDown += textBox_username_KeyDown;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._lock;
            pictureBox5.Location = new Point(62, 344);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 33);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.White;
            textBox_password.BorderStyle = BorderStyle.None;
            textBox_password.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_password.ForeColor = SystemColors.ActiveCaptionText;
            textBox_password.Location = new Point(107, 354);
            textBox_password.Margin = new Padding(3, 2, 3, 2);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.PlaceholderText = "Password";
            textBox_password.Size = new Size(265, 16);
            textBox_password.TabIndex = 13;
            textBox_password.Tag = " ";
            textBox_password.KeyDown += textBox_password_KeyDown;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(416, -1);
            button1.Name = "button1";
            button1.Size = new Size(22, 22);
            button1.TabIndex = 14;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button_minimize
            // 
            button_minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_minimize.BackColor = Color.RosyBrown;
            button_minimize.FlatStyle = FlatStyle.Flat;
            button_minimize.Location = new Point(395, -1);
            button_minimize.Name = "button_minimize";
            button_minimize.Size = new Size(22, 22);
            button_minimize.TabIndex = 15;
            button_minimize.Text = "-";
            button_minimize.UseVisualStyleBackColor = false;
            button_minimize.Click += button_minimize_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(438, 525);
            Controls.Add(button_minimize);
            Controls.Add(button1);
            Controls.Add(textBox_password);
            Controls.Add(pictureBox5);
            Controls.Add(textBox_username);
            Controls.Add(Login_button);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private Button Login_button;
        private TextBox textBox_username;
        private PictureBox pictureBox5;
        private TextBox textBox_password;
        private Button button1;
        private Button button_minimize;
    }
}
