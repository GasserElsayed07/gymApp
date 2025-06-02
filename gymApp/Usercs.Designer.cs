namespace gymApp
{
    partial class Usercs
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
            button8 = new Button();
            button3 = new Button();
            ProgressButton = new Button();
            plansSubMenu = new Panel();
            button6 = new Button();
            button7 = new Button();
            PlansButton = new Button();
            usersSubMenu = new Panel();
            MangeClientDataButton = new Button();
            button2 = new Button();
            usersButton = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox_Fname = new TextBox();
            textBox_Lname = new TextBox();
            textBox_height = new TextBox();
            textBox_weight = new TextBox();
            textBox_address = new TextBox();
            radioButton_male = new RadioButton();
            radioButton_female = new RadioButton();
            dateTimePicker_birth = new DateTimePicker();
            dateTimePicker_joinDate = new DateTimePicker();
            textBox_phone = new TextBox();
            UserPageExit = new Button();
            userPicture = new PictureBox();
            button_upload = new Button();
            button_Add = new Button();
            button_Clear = new Button();
            pictureBox3 = new PictureBox();
            comboBox_joinReason = new ComboBox();
            comboBox1 = new ComboBox();
            label11 = new Label();
            panel1.SuspendLayout();
            progressSubMenu.SuspendLayout();
            plansSubMenu.SuspendLayout();
            usersSubMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(16, 568);
            button1.Name = "button1";
            button1.Size = new Size(165, 29);
            button1.TabIndex = 31;
            button1.Text = "Back to Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressSubMenu
            // 
            progressSubMenu.Controls.Add(button8);
            progressSubMenu.Controls.Add(button3);
            progressSubMenu.Dock = DockStyle.Top;
            progressSubMenu.Location = new Point(0, 353);
            progressSubMenu.Margin = new Padding(3, 4, 3, 4);
            progressSubMenu.Name = "progressSubMenu";
            progressSubMenu.Size = new Size(202, 91);
            progressSubMenu.TabIndex = 6;
            // 
            // button8
            // 
            button8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button8.BackColor = Color.White;
            button8.Dock = DockStyle.Top;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(0, 29);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(202, 29);
            button8.TabIndex = 4;
            button8.Text = "Print Plans";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button3
            // 
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.BackColor = Color.White;
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 0);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(202, 29);
            button3.TabIndex = 3;
            button3.Text = "Print Clients Info";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ProgressButton
            // 
            ProgressButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ProgressButton.BackColor = Color.DarkRed;
            ProgressButton.Dock = DockStyle.Top;
            ProgressButton.FlatStyle = FlatStyle.Popup;
            ProgressButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProgressButton.ForeColor = SystemColors.ControlLightLight;
            ProgressButton.Location = new Point(0, 322);
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
            plansSubMenu.Size = new Size(202, 64);
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
            usersSubMenu.Controls.Add(MangeClientDataButton);
            usersSubMenu.Controls.Add(button2);
            usersSubMenu.Dock = DockStyle.Top;
            usersSubMenu.Location = new Point(0, 164);
            usersSubMenu.Margin = new Padding(3, 4, 3, 4);
            usersSubMenu.Name = "usersSubMenu";
            usersSubMenu.Size = new Size(202, 63);
            usersSubMenu.TabIndex = 2;
            // 
            // MangeClientDataButton
            // 
            MangeClientDataButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MangeClientDataButton.BackColor = Color.White;
            MangeClientDataButton.Dock = DockStyle.Top;
            MangeClientDataButton.FlatStyle = FlatStyle.Popup;
            MangeClientDataButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MangeClientDataButton.Location = new Point(0, 31);
            MangeClientDataButton.Margin = new Padding(3, 4, 3, 4);
            MangeClientDataButton.Name = "MangeClientDataButton";
            MangeClientDataButton.Size = new Size(202, 31);
            MangeClientDataButton.TabIndex = 1;
            MangeClientDataButton.Text = "Manage Clients Data ";
            MangeClientDataButton.UseVisualStyleBackColor = false;
            MangeClientDataButton.Click += MangeClientDataButton_Click;
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
            button2.Text = "Add New Client ";
            button2.UseVisualStyleBackColor = false;
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
            usersButton.Text = "Clients";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(238, 27);
            label1.Name = "label1";
            label1.Size = new Size(142, 31);
            label1.TabIndex = 2;
            label1.Text = "First Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(235, 155);
            label2.Name = "label2";
            label2.Size = new Size(166, 31);
            label2.TabIndex = 3;
            label2.Text = "Date of Birth :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(561, 155);
            label3.Name = "label3";
            label3.Size = new Size(103, 31);
            label3.TabIndex = 4;
            label3.Text = "Gender :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(237, 88);
            label4.Name = "label4";
            label4.Size = new Size(138, 31);
            label4.TabIndex = 5;
            label4.Text = "Last Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(238, 219);
            label5.Name = "label5";
            label5.Size = new Size(133, 31);
            label5.TabIndex = 6;
            label5.Text = "Join Date  :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(563, 219);
            label6.Name = "label6";
            label6.Size = new Size(75, 31);
            label6.TabIndex = 7;
            label6.Text = "Goal :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(235, 291);
            label7.Name = "label7";
            label7.Size = new Size(153, 31);
            label7.TabIndex = 8;
            label7.Text = "Weight(kg)  :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(561, 291);
            label8.Name = "label8";
            label8.Size = new Size(148, 31);
            label8.TabIndex = 9;
            label8.Text = "Height(cm) :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(560, 27);
            label9.Name = "label9";
            label9.Size = new Size(132, 31);
            label9.TabIndex = 10;
            label9.Text = "Phone No :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(562, 88);
            label10.Name = "label10";
            label10.Size = new Size(111, 31);
            label10.TabIndex = 11;
            label10.Text = "Address :";
            // 
            // textBox_Fname
            // 
            textBox_Fname.Location = new Point(245, 60);
            textBox_Fname.Name = "textBox_Fname";
            textBox_Fname.Size = new Size(247, 27);
            textBox_Fname.TabIndex = 12;
            // 
            // textBox_Lname
            // 
            textBox_Lname.Location = new Point(245, 124);
            textBox_Lname.Name = "textBox_Lname";
            textBox_Lname.Size = new Size(247, 27);
            textBox_Lname.TabIndex = 13;
            // 
            // textBox_height
            // 
            textBox_height.Location = new Point(567, 331);
            textBox_height.Name = "textBox_height";
            textBox_height.Size = new Size(247, 27);
            textBox_height.TabIndex = 15;
            textBox_height.TextChanged += textBox4_TextChanged;
            // 
            // textBox_weight
            // 
            textBox_weight.Location = new Point(242, 331);
            textBox_weight.Name = "textBox_weight";
            textBox_weight.Size = new Size(244, 27);
            textBox_weight.TabIndex = 16;
            // 
            // textBox_address
            // 
            textBox_address.Location = new Point(567, 124);
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(247, 27);
            textBox_address.TabIndex = 17;
            // 
            // radioButton_male
            // 
            radioButton_male.AutoSize = true;
            radioButton_male.Checked = true;
            radioButton_male.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_male.ForeColor = SystemColors.ButtonFace;
            radioButton_male.Location = new Point(567, 188);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(86, 32);
            radioButton_male.TabIndex = 19;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male ";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            radioButton_female.AutoSize = true;
            radioButton_female.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_female.ForeColor = SystemColors.ButtonFace;
            radioButton_female.Location = new Point(714, 188);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(100, 32);
            radioButton_female.TabIndex = 20;
            radioButton_female.Text = "Female";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_birth
            // 
            dateTimePicker_birth.Location = new Point(242, 188);
            dateTimePicker_birth.Name = "dateTimePicker_birth";
            dateTimePicker_birth.Size = new Size(250, 27);
            dateTimePicker_birth.TabIndex = 21;
            // 
            // dateTimePicker_joinDate
            // 
            dateTimePicker_joinDate.Location = new Point(242, 256);
            dateTimePicker_joinDate.Name = "dateTimePicker_joinDate";
            dateTimePicker_joinDate.Size = new Size(250, 27);
            dateTimePicker_joinDate.TabIndex = 22;
            // 
            // textBox_phone
            // 
            textBox_phone.Location = new Point(567, 60);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(247, 27);
            textBox_phone.TabIndex = 23;
            // 
            // UserPageExit
            // 
            UserPageExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UserPageExit.BackColor = Color.FromArgb(192, 0, 0);
            UserPageExit.FlatStyle = FlatStyle.Popup;
            UserPageExit.Location = new Point(1095, 0);
            UserPageExit.Margin = new Padding(3, 4, 3, 4);
            UserPageExit.Name = "UserPageExit";
            UserPageExit.Size = new Size(25, 29);
            UserPageExit.TabIndex = 24;
            UserPageExit.Text = "X";
            UserPageExit.UseVisualStyleBackColor = false;
            UserPageExit.Click += UserPageExit_Click;
            // 
            // userPicture
            // 
            userPicture.BackColor = SystemColors.AppWorkspace;
            userPicture.Location = new Point(903, 57);
            userPicture.Name = "userPicture";
            userPicture.Size = new Size(158, 157);
            userPicture.SizeMode = PictureBoxSizeMode.Zoom;
            userPicture.TabIndex = 25;
            userPicture.TabStop = false;
            // 
            // button_upload
            // 
            button_upload.BackColor = Color.Red;
            button_upload.FlatStyle = FlatStyle.Popup;
            button_upload.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_upload.ForeColor = SystemColors.ButtonHighlight;
            button_upload.Location = new Point(903, 227);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(158, 45);
            button_upload.TabIndex = 26;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click;
            // 
            // button_Add
            // 
            button_Add.BackColor = Color.Red;
            button_Add.FlatStyle = FlatStyle.Popup;
            button_Add.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Add.ForeColor = SystemColors.ButtonHighlight;
            button_Add.Location = new Point(352, 487);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(155, 45);
            button_Add.TabIndex = 27;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += button_Add_Click;
            // 
            // button_Clear
            // 
            button_Clear.BackColor = Color.Red;
            button_Clear.FlatStyle = FlatStyle.Popup;
            button_Clear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Clear.ForeColor = SystemColors.ButtonHighlight;
            button_Clear.Location = new Point(537, 487);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(155, 45);
            button_Clear.TabIndex = 28;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = false;
            button_Clear.Click += button_Clear_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.gymImage1;
            pictureBox3.ErrorImage = null;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(821, 304);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(299, 296);
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // comboBox_joinReason
            // 
            comboBox_joinReason.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_joinReason.FormattingEnabled = true;
            comboBox_joinReason.Items.AddRange(new object[] { "Lose Weight", "Healthy Life ", "Better Fitness" });
            comboBox_joinReason.Location = new Point(567, 256);
            comboBox_joinReason.Name = "comboBox_joinReason";
            comboBox_joinReason.Size = new Size(247, 28);
            comboBox_joinReason.TabIndex = 18;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "4 month", "6 month", "3 + 2 month (summer offer)" });
            comboBox1.Location = new Point(352, 411);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(340, 28);
            comboBox1.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(347, 377);
            label11.Name = "label11";
            label11.Size = new Size(129, 31);
            label11.TabIndex = 32;
            label11.Text = "Plan Type :";
            // 
            // Usercs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1118, 600);
            Controls.Add(label11);
            Controls.Add(comboBox1);
            Controls.Add(button_Clear);
            Controls.Add(button_Add);
            Controls.Add(button_upload);
            Controls.Add(userPicture);
            Controls.Add(UserPageExit);
            Controls.Add(textBox_phone);
            Controls.Add(dateTimePicker_joinDate);
            Controls.Add(dateTimePicker_birth);
            Controls.Add(radioButton_female);
            Controls.Add(radioButton_male);
            Controls.Add(comboBox_joinReason);
            Controls.Add(textBox_address);
            Controls.Add(textBox_weight);
            Controls.Add(textBox_height);
            Controls.Add(textBox_Lname);
            Controls.Add(textBox_Fname);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usercs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usercs";
            Load += Usercs_Load;
            panel1.ResumeLayout(false);
            progressSubMenu.ResumeLayout(false);
            plansSubMenu.ResumeLayout(false);
            usersSubMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button MangeClientDataButton;
        private Button button2;
        private Button usersButton;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox_Fname;
        private TextBox textBox_Lname;
        private TextBox textBox_height;
        private TextBox textBox_weight;
        private TextBox textBox_address;
        private RadioButton radioButton_male;
        private RadioButton radioButton_female;
        private DateTimePicker dateTimePicker_birth;
        private DateTimePicker dateTimePicker_joinDate;
        private TextBox textBox_phone;
        private Button UserPageExit;
        private PictureBox userPicture;
        private Button button_upload;
        private Button button_Add;
        private Button button_Clear;
        private PictureBox pictureBox3;
        private ComboBox comboBox_joinReason;
        private Button button1;
        private ComboBox comboBox1;
        private Button button8;
        private Button button3;
        private Label label11;
    }
}