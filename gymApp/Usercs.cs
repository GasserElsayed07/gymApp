using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gymApp
{
    public partial class Usercs : Form
    {
        userClass user = new userClass();
        public Usercs()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void customizeDesign()
        {
            usersSubMenu.Visible = true;
            plansSubMenu.Visible = false;
            progressSubMenu.Visible = false;
        }
        private void usersButton_Click(object sender, EventArgs e)
        {
            showSubMenu(usersSubMenu);
        }
        private void PlansButton_Click(object sender, EventArgs e)
        {
            showSubMenu(plansSubMenu);
        }
        private void ProgressButton_Click(object sender, EventArgs e)
        {
            showSubMenu(progressSubMenu);
        }
        private void hideSubMenu()
        {
            if (usersSubMenu.Visible == true)
                usersSubMenu.Visible = false;
            if (plansSubMenu.Visible == true)
                plansSubMenu.Visible = false;
            if (progressSubMenu.Visible == true)
                progressSubMenu.Visible = false;
        }







        private void UserPageExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string Fname = textBox_Fname.Text;
            string Lname = textBox_Lname.Text;
            DateTime bdDate = dateTimePicker_birth.Value;
            DateTime joinDate = dateTimePicker_joinDate.Value;
            int weight;
            if (!int.TryParse(textBox_weight.Text, out weight))
            {
                MessageBox.Show("Please enter a valid weight.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string phone = textBox_phone.Text;
            int height;
            if (!int.TryParse(textBox_height.Text, out height))
            {
                MessageBox.Show("Please enter a valid height.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string address = textBox_address.Text;
            string gender = "";
            if (radioButton_male.Checked)
            {
                gender = "Male";
            }
            else if (radioButton_female.Checked)
            {
                gender = "Female";
            }
            string joinReason = comboBox_joinReason.Text;
            MemoryStream memoryStream = new MemoryStream();
            if (userPicture.Image == null)
            {
                MessageBox.Show("Please select a picture.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            userPicture.Image.Save(memoryStream, userPicture.Image.RawFormat);
            byte[] image = memoryStream.ToArray();
            int birthYear = dateTimePicker_birth.Value.Year;
            int currentYear = DateTime.Now.Year;
            if (currentYear - birthYear < 18)
            {
                MessageBox.Show("You must be at least 18 years old to join the gym.");
                return;
            }
            else if (verify())
            {
                try
                {

                    if (user.insertUser(Fname, Lname, bdDate, joinDate, weight, phone, address, gender, joinReason, height, image))
                    {
                        MessageBox.Show("User added successfully!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool verify()
        {
            if ((textBox_Fname.Text == "") || (textBox_Lname.Text == "") || (textBox_phone.Text == "") || (textBox_weight.Text == "") || (textBox_height.Text == "") || (textBox_address.Text == "") || (comboBox_joinReason.Text == "") || (userPicture.Image == null))
            {
                MessageBox.Show("Please fill all the fields");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                userPicture.Image = Image.FromFile(openFileDialog.FileName);
            }


        }

        private void MangeClientDataButton_Click(object sender, EventArgs e)
        {
            MangeClientData MangeClient = new MangeClientData();
            MangeClient.Show();
            this.Hide();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            dateTimePicker_birth.Value = DateTime.Now;
            dateTimePicker_joinDate.Value = DateTime.Now;
            textBox_weight.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            textBox_height.Clear();
            userPicture.Image = null;
        }

        private void Usercs_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClientPrint Clientprinnt = new ClientPrint();
            Clientprinnt.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddPlan AddPlan = new AddPlan();
            AddPlan.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mangeplans MangePlans = new Mangeplans();
            MangePlans.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Print_Plan PrintPlan = new Print_Plan();
            PrintPlan.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ADDProgress AddProgress = new ADDProgress();
            AddProgress.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPage mainPage = new mainPage();
            mainPage.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Print_Progress PrintProgress = new Print_Progress();
            PrintProgress.Show();
            this.Hide();
        }
    }
}
