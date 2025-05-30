namespace gymApp
{
    partial class mainPage
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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            usersSubMenu = new Panel();
            usersButton = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            plansSubMenu = new Panel();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            progressSubMenu = new Panel();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            usersSubMenu.SuspendLayout();
            plansSubMenu.SuspendLayout();
            progressSubMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(progressSubMenu);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(plansSubMenu);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(usersSubMenu);
            panel1.Controls.Add(usersButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 100);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.King_bodybuilding_and_gym_logo_vector_image_Png;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // usersSubMenu
            // 
            usersSubMenu.Controls.Add(button4);
            usersSubMenu.Controls.Add(button3);
            usersSubMenu.Controls.Add(button2);
            usersSubMenu.Dock = DockStyle.Top;
            usersSubMenu.Location = new Point(0, 123);
            usersSubMenu.Name = "usersSubMenu";
            usersSubMenu.Size = new Size(186, 68);
            usersSubMenu.TabIndex = 2;
            // 
            // usersButton
            // 
            usersButton.Dock = DockStyle.Top;
            usersButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usersButton.Location = new Point(0, 100);
            usersButton.Name = "usersButton";
            usersButton.Size = new Size(186, 23);
            usersButton.TabIndex = 1;
            usersButton.Text = "Users";
            usersButton.TextAlign = ContentAlignment.MiddleLeft;
            usersButton.UseVisualStyleBackColor = true;
            usersButton.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(186, 23);
            button2.TabIndex = 0;
            button2.Text = "Add User";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Location = new Point(0, 23);
            button3.Name = "button3";
            button3.Size = new Size(186, 23);
            button3.TabIndex = 1;
            button3.Text = "Manage Users";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Location = new Point(0, 46);
            button4.Name = "button4";
            button4.Size = new Size(186, 22);
            button4.TabIndex = 2;
            button4.Text = "Print";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 191);
            button1.Name = "button1";
            button1.Size = new Size(186, 23);
            button1.TabIndex = 3;
            button1.Text = "Plans";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // plansSubMenu
            // 
            plansSubMenu.Controls.Add(button5);
            plansSubMenu.Controls.Add(button6);
            plansSubMenu.Controls.Add(button7);
            plansSubMenu.Dock = DockStyle.Top;
            plansSubMenu.Location = new Point(0, 214);
            plansSubMenu.Name = "plansSubMenu";
            plansSubMenu.Size = new Size(186, 68);
            plansSubMenu.TabIndex = 4;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.Location = new Point(0, 46);
            button5.Name = "button5";
            button5.Size = new Size(186, 22);
            button5.TabIndex = 2;
            button5.Text = "Print";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.Location = new Point(0, 23);
            button6.Name = "button6";
            button6.Size = new Size(186, 23);
            button6.TabIndex = 1;
            button6.Text = "Manage Plans";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.Location = new Point(0, 0);
            button7.Name = "button7";
            button7.Size = new Size(186, 23);
            button7.TabIndex = 0;
            button7.Text = "Add Plan";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Top;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(0, 282);
            button8.Name = "button8";
            button8.Size = new Size(186, 23);
            button8.TabIndex = 5;
            button8.Text = "Plans";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = true;
            // 
            // progressSubMenu
            // 
            progressSubMenu.Controls.Add(button9);
            progressSubMenu.Controls.Add(button10);
            progressSubMenu.Controls.Add(button11);
            progressSubMenu.Dock = DockStyle.Top;
            progressSubMenu.Location = new Point(0, 305);
            progressSubMenu.Name = "progressSubMenu";
            progressSubMenu.Size = new Size(186, 68);
            progressSubMenu.TabIndex = 6;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Top;
            button9.Location = new Point(0, 46);
            button9.Name = "button9";
            button9.Size = new Size(186, 22);
            button9.TabIndex = 2;
            button9.Text = "Print";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Top;
            button10.Location = new Point(0, 23);
            button10.Name = "button10";
            button10.Size = new Size(186, 23);
            button10.TabIndex = 1;
            button10.Text = "Manage Users";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Top;
            button11.Location = new Point(0, 0);
            button11.Name = "button11";
            button11.Size = new Size(186, 23);
            button11.TabIndex = 0;
            button11.Text = "Add User";
            button11.UseVisualStyleBackColor = true;
            // 
            // mainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mainPage";
            Text = "mainPage";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            usersSubMenu.ResumeLayout(false);
            plansSubMenu.ResumeLayout(false);
            progressSubMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel usersSubMenu;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button usersButton;
        private Panel plansSubMenu;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button1;
        private Panel progressSubMenu;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button8;
    }
}