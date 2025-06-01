namespace gymApp
{
    partial class Mangeplans
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
            MangePlansPageExit = new Button();
            pictureBox3 = new PictureBox();
            managePlandataGridView = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            button_Clear = new Button();
            button_update = new Button();
            button13 = new Button();
            textBox_managePlanID = new TextBox();
            textBox_managePlanName = new TextBox();
            textBox_managePlanTier = new TextBox();
            textBox_managePlanDuration = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            progressSubMenu.SuspendLayout();
            plansSubMenu.SuspendLayout();
            usersSubMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)managePlandataGridView).BeginInit();
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
            panel1.TabIndex = 2;
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
            button1.TabIndex = 2;
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
            PlansButton.Location = new Point(0, 191);
            PlansButton.Name = "PlansButton";
            PlansButton.Size = new Size(177, 23);
            PlansButton.TabIndex = 3;
            PlansButton.Text = "Plans";
            PlansButton.TextAlign = ContentAlignment.MiddleLeft;
            PlansButton.UseVisualStyleBackColor = false;
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
            // MangePlansPageExit
            // 
            MangePlansPageExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MangePlansPageExit.BackColor = Color.FromArgb(192, 0, 0);
            MangePlansPageExit.FlatStyle = FlatStyle.Popup;
            MangePlansPageExit.Location = new Point(958, 0);
            MangePlansPageExit.Name = "MangePlansPageExit";
            MangePlansPageExit.Size = new Size(22, 22);
            MangePlansPageExit.TabIndex = 51;
            MangePlansPageExit.Text = "X";
            MangePlansPageExit.UseVisualStyleBackColor = false;
            MangePlansPageExit.Click += MangePlansPageExit_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.gymImage1;
            pictureBox3.ErrorImage = null;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(718, 228);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(262, 222);
            pictureBox3.TabIndex = 52;
            pictureBox3.TabStop = false;
            // 
            // managePlandataGridView
            // 
            managePlandataGridView.AllowUserToAddRows = false;
            managePlandataGridView.AllowUserToDeleteRows = false;
            managePlandataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            managePlandataGridView.BackgroundColor = Color.FromArgb(192, 0, 0);
            managePlandataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            managePlandataGridView.Location = new Point(195, 27);
            managePlandataGridView.Margin = new Padding(3, 2, 3, 2);
            managePlandataGridView.Name = "managePlandataGridView";
            managePlandataGridView.ReadOnly = true;
            managePlandataGridView.RowHeadersWidth = 50;
            managePlandataGridView.RowTemplate.Height = 40;
            managePlandataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            managePlandataGridView.Size = new Size(765, 188);
            managePlandataGridView.TabIndex = 53;
            managePlandataGridView.CellContentClick += managePlandataGridView_CellContentClick;
            managePlandataGridView.Click += managePlandataGridView_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(190, 235);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 54;
            label1.Text = "Enter ID  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(190, 334);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 56;
            label3.Text = "Plan Tier  :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(190, 286);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 58;
            label4.Text = "Name :";
            label4.Click += label4_Click;
            // 
            // button_Clear
            // 
            button_Clear.BackColor = Color.Red;
            button_Clear.FlatStyle = FlatStyle.Popup;
            button_Clear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Clear.ForeColor = SystemColors.ButtonHighlight;
            button_Clear.Location = new Point(545, 272);
            button_Clear.Margin = new Padding(3, 2, 3, 2);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(136, 34);
            button_Clear.TabIndex = 60;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = false;
            button_Clear.Click += button_Clear_Click;
            // 
            // button_update
            // 
            button_update.BackColor = Color.Red;
            button_update.FlatStyle = FlatStyle.Popup;
            button_update.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_update.ForeColor = SystemColors.ButtonHighlight;
            button_update.Location = new Point(545, 328);
            button_update.Margin = new Padding(3, 2, 3, 2);
            button_update.Name = "button_update";
            button_update.Size = new Size(136, 34);
            button_update.TabIndex = 61;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Red;
            button13.FlatStyle = FlatStyle.Popup;
            button13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.ForeColor = SystemColors.ButtonHighlight;
            button13.Location = new Point(545, 387);
            button13.Margin = new Padding(3, 2, 3, 2);
            button13.Name = "button13";
            button13.Size = new Size(136, 34);
            button13.TabIndex = 62;
            button13.Text = "Delete";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // textBox_managePlanID
            // 
            textBox_managePlanID.Location = new Point(195, 261);
            textBox_managePlanID.Margin = new Padding(3, 2, 3, 2);
            textBox_managePlanID.Name = "textBox_managePlanID";
            textBox_managePlanID.Size = new Size(186, 23);
            textBox_managePlanID.TabIndex = 63;
            // 
            // textBox_managePlanName
            // 
            textBox_managePlanName.Location = new Point(195, 312);
            textBox_managePlanName.Margin = new Padding(3, 2, 3, 2);
            textBox_managePlanName.Name = "textBox_managePlanName";
            textBox_managePlanName.Size = new Size(186, 23);
            textBox_managePlanName.TabIndex = 64;
            // 
            // textBox_managePlanTier
            // 
            textBox_managePlanTier.Location = new Point(195, 361);
            textBox_managePlanTier.Margin = new Padding(3, 2, 3, 2);
            textBox_managePlanTier.Name = "textBox_managePlanTier";
            textBox_managePlanTier.Size = new Size(186, 23);
            textBox_managePlanTier.TabIndex = 65;
            // 
            // textBox_managePlanDuration
            // 
            textBox_managePlanDuration.Location = new Point(195, 413);
            textBox_managePlanDuration.Margin = new Padding(3, 2, 3, 2);
            textBox_managePlanDuration.Name = "textBox_managePlanDuration";
            textBox_managePlanDuration.Size = new Size(186, 23);
            textBox_managePlanDuration.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(190, 386);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 66;
            label2.Text = "Duration  :";
            // 
            // Mangeplans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(978, 450);
            Controls.Add(textBox_managePlanDuration);
            Controls.Add(label2);
            Controls.Add(textBox_managePlanTier);
            Controls.Add(textBox_managePlanName);
            Controls.Add(textBox_managePlanID);
            Controls.Add(button13);
            Controls.Add(button_update);
            Controls.Add(button_Clear);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(managePlandataGridView);
            Controls.Add(pictureBox3);
            Controls.Add(MangePlansPageExit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Mangeplans";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mangeplans";
            Load += Mangeplans_Load;
            panel1.ResumeLayout(false);
            progressSubMenu.ResumeLayout(false);
            plansSubMenu.ResumeLayout(false);
            usersSubMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)managePlandataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
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
        private Button MangePlansPageExit;
        private PictureBox pictureBox3;
        private DataGridView managePlandataGridView;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button button_Clear;
        private Button button_update;
        private Button button13;
        private TextBox textBox_managePlanID;
        private TextBox textBox_managePlanName;
        private TextBox textBox_managePlanTier;
        private TextBox textBox_managePlanDuration;
        private Label label2;
    }
}