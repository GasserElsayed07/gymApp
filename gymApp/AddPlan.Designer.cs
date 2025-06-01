namespace gymApp
{
    partial class AddPlan
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
            button1 = new Button();
            progressSubMenu = new Panel();
            button9 = new Button();
            button11 = new Button();
            ProgressButton = new Button();
            plansSubMenu = new Panel();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            PlansButton = new Button();
            usersSubMenu = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            usersButton = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            comboBox1 = new ComboBox();
            AddPlanExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            ClientdataGridView = new DataGridView();
            button12 = new Button();
            label4 = new Label();
            comboBox3 = new ComboBox();
            panel1.SuspendLayout();
            progressSubMenu.SuspendLayout();
            plansSubMenu.SuspendLayout();
            usersSubMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClientdataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(progressSubMenu);
            panel1.Controls.Add(ProgressButton);
            panel1.Controls.Add(plansSubMenu);
            panel1.Controls.Add(PlansButton);
            panel1.Controls.Add(usersSubMenu);
            panel1.Controls.Add(usersButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 450);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(14, 426);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(144, 22);
            button1.TabIndex = 3;
            button1.Text = "Back to Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressSubMenu
            // 
            progressSubMenu.Controls.Add(button9);
            progressSubMenu.Controls.Add(button11);
            progressSubMenu.Dock = DockStyle.Top;
            progressSubMenu.Location = new Point(0, 305);
            progressSubMenu.Name = "progressSubMenu";
            progressSubMenu.Size = new Size(177, 68);
            progressSubMenu.TabIndex = 6;
            // 
            // button9
            // 
            button9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button9.BackColor = Color.White;
            button9.Dock = DockStyle.Top;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(0, 23);
            button9.Name = "button9";
            button9.Size = new Size(177, 22);
            button9.TabIndex = 2;
            button9.Text = "Print";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button11
            // 
            button11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button11.BackColor = Color.White;
            button11.Dock = DockStyle.Top;
            button11.FlatStyle = FlatStyle.Popup;
            button11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(0, 0);
            button11.Name = "button11";
            button11.Size = new Size(177, 23);
            button11.TabIndex = 0;
            button11.Text = "Add new progress";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // ProgressButton
            // 
            ProgressButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ProgressButton.BackColor = Color.DarkRed;
            ProgressButton.Dock = DockStyle.Top;
            ProgressButton.FlatStyle = FlatStyle.Popup;
            ProgressButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProgressButton.ForeColor = SystemColors.ControlLightLight;
            ProgressButton.Location = new Point(0, 282);
            ProgressButton.Name = "ProgressButton";
            ProgressButton.Size = new Size(177, 23);
            ProgressButton.TabIndex = 5;
            ProgressButton.Text = "Progress Tracking";
            ProgressButton.TextAlign = ContentAlignment.MiddleLeft;
            ProgressButton.UseVisualStyleBackColor = false;
            ProgressButton.Click += ProgressButton_Click;
            // 
            // plansSubMenu
            // 
            plansSubMenu.Controls.Add(button5);
            plansSubMenu.Controls.Add(button6);
            plansSubMenu.Controls.Add(button7);
            plansSubMenu.Dock = DockStyle.Top;
            plansSubMenu.Location = new Point(0, 214);
            plansSubMenu.Name = "plansSubMenu";
            plansSubMenu.Size = new Size(177, 68);
            plansSubMenu.TabIndex = 4;
            // 
            // button5
            // 
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.BackColor = Color.White;
            button5.Dock = DockStyle.Top;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(0, 46);
            button5.Name = "button5";
            button5.Size = new Size(177, 22);
            button5.TabIndex = 2;
            button5.Text = "Print";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button6.BackColor = Color.WhiteSmoke;
            button6.Dock = DockStyle.Top;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(0, 23);
            button6.Name = "button6";
            button6.Size = new Size(177, 23);
            button6.TabIndex = 1;
            button6.Text = "Manage Plans";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button7.BackColor = Color.White;
            button7.Dock = DockStyle.Top;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(0, 0);
            button7.Name = "button7";
            button7.Size = new Size(177, 23);
            button7.TabIndex = 0;
            button7.Text = "Add Plan";
            button7.UseVisualStyleBackColor = false;
            // 
            // PlansButton
            // 
            PlansButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PlansButton.BackColor = Color.DarkRed;
            PlansButton.Dock = DockStyle.Top;
            PlansButton.FlatStyle = FlatStyle.Popup;
            PlansButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlansButton.ForeColor = SystemColors.ButtonHighlight;
            PlansButton.Location = new Point(0, 191);
            PlansButton.Name = "PlansButton";
            PlansButton.Size = new Size(177, 23);
            PlansButton.TabIndex = 3;
            PlansButton.Text = "Plans";
            PlansButton.TextAlign = ContentAlignment.MiddleLeft;
            PlansButton.UseVisualStyleBackColor = false;
            PlansButton.Click += PlansButton_Click;
            // 
            // usersSubMenu
            // 
            usersSubMenu.Controls.Add(button4);
            usersSubMenu.Controls.Add(button3);
            usersSubMenu.Controls.Add(button2);
            usersSubMenu.Dock = DockStyle.Top;
            usersSubMenu.Location = new Point(0, 123);
            usersSubMenu.Name = "usersSubMenu";
            usersSubMenu.Size = new Size(177, 68);
            usersSubMenu.TabIndex = 2;
            // 
            // button4
            // 
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = Color.White;
            button4.Dock = DockStyle.Top;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(0, 46);
            button4.Name = "button4";
            button4.Size = new Size(177, 22);
            button4.TabIndex = 2;
            button4.Text = "Print Client Info";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.BackColor = Color.White;
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 23);
            button3.Name = "button3";
            button3.Size = new Size(177, 23);
            button3.TabIndex = 1;
            button3.Text = "Manage Clients Data ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.White;
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(177, 23);
            button2.TabIndex = 0;
            button2.Text = "Add New Client  ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // usersButton
            // 
            usersButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            usersButton.BackColor = Color.DarkRed;
            usersButton.Dock = DockStyle.Top;
            usersButton.FlatAppearance.BorderColor = Color.Black;
            usersButton.FlatAppearance.BorderSize = 0;
            usersButton.FlatStyle = FlatStyle.Popup;
            usersButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usersButton.ForeColor = SystemColors.Control;
            usersButton.Location = new Point(0, 100);
            usersButton.Name = "usersButton";
            usersButton.Size = new Size(177, 23);
            usersButton.TabIndex = 1;
            usersButton.Text = "Clients ";
            usersButton.TextAlign = ContentAlignment.MiddleLeft;
            usersButton.UseVisualStyleBackColor = false;
            usersButton.Click += usersButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 100);
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
            pictureBox1.Size = new Size(177, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.gymImage1;
            pictureBox2.ErrorImage = null;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(718, 228);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(912, 597);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(210, 47);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(155, 23);
            comboBox1.TabIndex = 18;
            // 
            // AddPlanExit
            // 
            AddPlanExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddPlanExit.BackColor = Color.FromArgb(192, 0, 0);
            AddPlanExit.FlatStyle = FlatStyle.Popup;
            AddPlanExit.Location = new Point(958, 0);
            AddPlanExit.Name = "AddPlanExit";
            AddPlanExit.Size = new Size(22, 22);
            AddPlanExit.TabIndex = 19;
            AddPlanExit.Text = "X";
            AddPlanExit.UseVisualStyleBackColor = false;
            AddPlanExit.Click += AddPlanExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(204, 22);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 46;
            label1.Text = "Enter ID  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 116);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 47;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(396, 22);
            label3.Name = "label3";
            label3.Size = new Size(165, 25);
            label3.TabIndex = 48;
            label3.Text = "Enter Plan Type  :";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Sliver Plan ", "Gold Plan ", "Premium Plan" });
            comboBox2.Location = new Point(401, 47);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(205, 23);
            comboBox2.TabIndex = 49;
            // 
            // ClientdataGridView
            // 
            ClientdataGridView.AllowUserToAddRows = false;
            ClientdataGridView.AllowUserToDeleteRows = false;
            ClientdataGridView.BackgroundColor = Color.FromArgb(192, 0, 0);
            ClientdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClientdataGridView.Location = new Point(210, 84);
            ClientdataGridView.Margin = new Padding(3, 2, 3, 2);
            ClientdataGridView.Name = "ClientdataGridView";
            ClientdataGridView.RowHeadersWidth = 51;
            ClientdataGridView.RowTemplate.Height = 40;
            ClientdataGridView.Size = new Size(561, 314);
            ClientdataGridView.TabIndex = 50;
            // 
            // button12
            // 
            button12.BackColor = Color.Red;
            button12.FlatStyle = FlatStyle.Popup;
            button12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.ForeColor = SystemColors.ButtonHighlight;
            button12.Location = new Point(210, 407);
            button12.Margin = new Padding(3, 2, 3, 2);
            button12.Name = "button12";
            button12.Size = new Size(136, 34);
            button12.TabIndex = 52;
            button12.Text = "Assign Plan";
            button12.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(638, 22);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 53;
            label4.Text = "Enter Duration  :";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1-month", "3-months", "6-months", "1-year" });
            comboBox3.Location = new Point(643, 47);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(205, 23);
            comboBox3.TabIndex = 54;
            // 
            // AddPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(978, 450);
            Controls.Add(comboBox3);
            Controls.Add(label4);
            Controls.Add(button12);
            Controls.Add(ClientdataGridView);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddPlanExit);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddPlan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPlan";
            Load += AddPlan_Load;
            panel1.ResumeLayout(false);
            progressSubMenu.ResumeLayout(false);
            plansSubMenu.ResumeLayout(false);
            usersSubMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClientdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel progressSubMenu;
        private Button button9;
        private Button button11;
        private Button ProgressButton;
        private Panel plansSubMenu;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button PlansButton;
        private Panel usersSubMenu;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button usersButton;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox comboBox1;
        private Button AddPlanExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private DataGridView ClientdataGridView;
        private Button button12;
        private Label label4;
        private ComboBox comboBox3;
        private Button button1;
    }
}