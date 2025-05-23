﻿namespace gymApp
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
            pictureBox1.Location = new Point(178, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._7a11b9f739c130eed437d1a237cc3b7d;
            pictureBox2.Location = new Point(-107, -65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(724, 1280);
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
            label3.Font = new Font("Premier League", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(58, 191);
            label3.Name = "label3";
            label3.Size = new Size(387, 39);
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
            Login_button.BackColor = Color.Transparent;
            Login_button.Font = new Font("Premier League", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_button.ForeColor = Color.Red;
            Login_button.Location = new Point(152, 551);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(196, 44);
            Login_button.TabIndex = 9;
            Login_button.Text = "LOGIN";
            Login_button.UseVisualStyleBackColor = false;
            // 
            // username
            // 
            username.BackColor = Color.White;
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Premier League", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = SystemColors.ActiveCaptionText;
            username.Location = new Point(125, 365);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(299, 24);
            username.TabIndex = 10;
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
            password.Location = new Point(126, 472);
            password.Multiline = true;
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(299, 24);
            password.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(500, 700);
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
    }
}
