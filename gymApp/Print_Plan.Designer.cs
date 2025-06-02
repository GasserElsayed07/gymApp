namespace gymApp
{
    partial class Print_Plan
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
            ProgressButton = new Button();
            plansSubMenu = new Panel();
            button6 = new Button();
            button7 = new Button();
            PlansButton = new Button();
            usersSubMenu = new Panel();
            button3 = new Button();
            button2 = new Button();
            usersButton = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            MangePlansPageExit = new Button();
            plandataGridViewPrint = new DataGridView();
            button12 = new Button();
            button8 = new Button();
            button9 = new Button();
            panel1.SuspendLayout();
            progressSubMenu.SuspendLayout();
            plansSubMenu.SuspendLayout();
            usersSubMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plandataGridViewPrint).BeginInit();
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 600);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(16, 568);
            button1.Name = "button1";
            button1.Size = new Size(165, 29);
            button1.TabIndex = 4;
            button1.Text = "Back to Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressSubMenu
            // 
            progressSubMenu.Controls.Add(button9);
            progressSubMenu.Controls.Add(button8);
            progressSubMenu.Dock = DockStyle.Top;
            progressSubMenu.Location = new Point(0, 350);
            progressSubMenu.Margin = new Padding(3, 4, 3, 4);
            progressSubMenu.Name = "progressSubMenu";
            progressSubMenu.Size = new Size(202, 91);
            progressSubMenu.TabIndex = 6;
            // 
            // ProgressButton
            // 
            ProgressButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ProgressButton.BackColor = Color.DarkRed;
            ProgressButton.Dock = DockStyle.Top;
            ProgressButton.FlatStyle = FlatStyle.Popup;
            ProgressButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProgressButton.ForeColor = SystemColors.ControlLightLight;
            ProgressButton.Location = new Point(0, 319);
            ProgressButton.Margin = new Padding(3, 4, 3, 4);
            ProgressButton.Name = "ProgressButton";
            ProgressButton.Size = new Size(202, 31);
            ProgressButton.TabIndex = 5;
            ProgressButton.Text = "Print";
            ProgressButton.TextAlign = ContentAlignment.MiddleLeft;
            ProgressButton.UseVisualStyleBackColor = false;
            ProgressButton.Click += ProgressButton_Click;
            // 
            // plansSubMenu
            // 
            plansSubMenu.Controls.Add(button6);
            plansSubMenu.Controls.Add(button7);
            plansSubMenu.Dock = DockStyle.Top;
            plansSubMenu.Location = new Point(0, 258);
            plansSubMenu.Margin = new Padding(3, 4, 3, 4);
            plansSubMenu.Name = "plansSubMenu";
            plansSubMenu.Size = new Size(202, 61);
            plansSubMenu.TabIndex = 4;
            // 
            // button6
            // 
            button6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button6.BackColor = Color.WhiteSmoke;
            button6.Dock = DockStyle.Top;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(0, 31);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(202, 31);
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
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(202, 31);
            button7.TabIndex = 0;
            button7.Text = "Add Plan";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // PlansButton
            // 
            PlansButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PlansButton.BackColor = Color.DarkRed;
            PlansButton.Dock = DockStyle.Top;
            PlansButton.FlatStyle = FlatStyle.Popup;
            PlansButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlansButton.ForeColor = SystemColors.ButtonHighlight;
            PlansButton.Location = new Point(0, 227);
            PlansButton.Margin = new Padding(3, 4, 3, 4);
            PlansButton.Name = "PlansButton";
            PlansButton.Size = new Size(202, 31);
            PlansButton.TabIndex = 3;
            PlansButton.Text = "Plans";
            PlansButton.TextAlign = ContentAlignment.MiddleLeft;
            PlansButton.UseVisualStyleBackColor = false;
            PlansButton.Click += PlansButton_Click;
            // 
            // usersSubMenu
            // 
            usersSubMenu.Controls.Add(button3);
            usersSubMenu.Controls.Add(button2);
            usersSubMenu.Dock = DockStyle.Top;
            usersSubMenu.Location = new Point(0, 164);
            usersSubMenu.Margin = new Padding(3, 4, 3, 4);
            usersSubMenu.Name = "usersSubMenu";
            usersSubMenu.Size = new Size(202, 63);
            usersSubMenu.TabIndex = 2;
            // 
            // button3
            // 
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.BackColor = Color.White;
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 31);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(202, 31);
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
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(202, 31);
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
            usersButton.Location = new Point(0, 133);
            usersButton.Margin = new Padding(3, 4, 3, 4);
            usersButton.Name = "usersButton";
            usersButton.Size = new Size(202, 31);
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
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(202, 133);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.King_bodybuilding_and_gym_logo_vector_image_Png;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MangePlansPageExit
            // 
            MangePlansPageExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MangePlansPageExit.BackColor = Color.FromArgb(192, 0, 0);
            MangePlansPageExit.FlatStyle = FlatStyle.Popup;
            MangePlansPageExit.Location = new Point(1095, 0);
            MangePlansPageExit.Margin = new Padding(3, 4, 3, 4);
            MangePlansPageExit.Name = "MangePlansPageExit";
            MangePlansPageExit.Size = new Size(25, 29);
            MangePlansPageExit.TabIndex = 52;
            MangePlansPageExit.Text = "X";
            MangePlansPageExit.UseVisualStyleBackColor = false;
            MangePlansPageExit.Click += MangePlansPageExit_Click;
            // 
            // plandataGridViewPrint
            // 
            plandataGridViewPrint.AllowUserToAddRows = false;
            plandataGridViewPrint.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            plandataGridViewPrint.BackgroundColor = Color.FromArgb(192, 0, 0);
            plandataGridViewPrint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            plandataGridViewPrint.Location = new Point(226, 49);
            plandataGridViewPrint.Name = "plandataGridViewPrint";
            plandataGridViewPrint.ReadOnly = true;
            plandataGridViewPrint.RowHeadersWidth = 51;
            plandataGridViewPrint.RowTemplate.Height = 80;
            plandataGridViewPrint.Size = new Size(864, 467);
            plandataGridViewPrint.TabIndex = 53;
            // 
            // button12
            // 
            button12.BackColor = Color.Red;
            button12.FlatStyle = FlatStyle.Popup;
            button12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.ForeColor = SystemColors.ButtonHighlight;
            button12.Location = new Point(571, 533);
            button12.Name = "button12";
            button12.Size = new Size(155, 45);
            button12.TabIndex = 54;
            button12.Text = "Print";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button8
            // 
            button8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button8.BackColor = Color.White;
            button8.Dock = DockStyle.Top;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(0, 0);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(202, 29);
            button8.TabIndex = 3;
            button8.Text = "Print Client Info";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button9.BackColor = Color.White;
            button9.Dock = DockStyle.Top;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(0, 29);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(202, 29);
            button9.TabIndex = 4;
            button9.Text = "Print Plans";
            button9.UseVisualStyleBackColor = false;
            // 
            // Print_Plan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1118, 600);
            Controls.Add(button12);
            Controls.Add(plandataGridViewPrint);
            Controls.Add(MangePlansPageExit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Print_Plan";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Print_Plan_Load;
            panel1.ResumeLayout(false);
            progressSubMenu.ResumeLayout(false);
            plansSubMenu.ResumeLayout(false);
            usersSubMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)plandataGridViewPrint).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel progressSubMenu;
        private Button ProgressButton;
        private Panel plansSubMenu;
        private Button button6;
        private Button button7;
        private Button PlansButton;
        private Panel usersSubMenu;
        private Button button3;
        private Button button2;
        private Button usersButton;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button MangePlansPageExit;
        private DataGridView plandataGridViewPrint;
        private Button button12;
        private Button button1;
        private Button button9;
        private Button button8;
    }
}