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
            username = new TextBox();
            pictureBox5 = new PictureBox();
            password = new TextBox();
            button1 = new Button();
            button2 = new Button();
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
            pictureBox1.Location = new Point(182, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._7a11b9f739c130eed437d1a237cc3b7d;
            pictureBox2.Location = new Point(-109, -85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(609, 788);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 8);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 8);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(71, 171);
            label3.Name = "label3";
            label3.Size = new Size(355, 48);
            label3.TabIndex = 4;
            label3.Text = "Welcome to Gym";
            label3.Click += label3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.torso;
            pictureBox3.Location = new Point(71, 353);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.ForeColor = Color.CornflowerBlue;
            panel1.Location = new Point(71, 403);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 1);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.CornflowerBlue;
            panel2.Location = new Point(71, 509);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 1);
            panel2.TabIndex = 7;
            // 
            // Login_button
            // 
            Login_button.BackColor = Color.White;
            Login_button.FlatStyle = FlatStyle.Popup;
            Login_button.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_button.ForeColor = Color.Red;
            Login_button.Location = new Point(152, 551);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(197, 44);
            Login_button.TabIndex = 9;
            Login_button.Text = "LOGIN";
            Login_button.UseVisualStyleBackColor = false;
            
            // 
            // username
            // 
            username.AccessibleName = "";
            username.BackColor = Color.White;
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = SystemColors.ActiveCaptionText;
            username.Location = new Point(122, 365);
            username.Multiline = true;
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(302, 24);
            username.TabIndex = 10;
            username.Tag = "";
            username.TextChanged += username_TextChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._lock;
            pictureBox5.Location = new Point(71, 459);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // password
            // 
            password.BackColor = Color.White;
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.ForeColor = SystemColors.ActiveCaptionText;
            password.Location = new Point(122, 472);
            password.Multiline = true;
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Password";
            password.Size = new Size(303, 24);
            password.TabIndex = 13;
            password.Tag = " ";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(475, -1);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(25, 29);
            button1.TabIndex = 14;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(331, 631);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(111, 53);
            button2.TabIndex = 15;
            button2.Text = "goToMainPage(Test)";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(501, 700);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(pictureBox5);
            Controls.Add(username);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox username;
        private PictureBox pictureBox5;
        private TextBox password;
        private Button button1;
        private Button button2;
    }
}
