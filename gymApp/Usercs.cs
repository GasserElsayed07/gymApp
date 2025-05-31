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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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
            int weight = int.Parse(textBox_weight.Text);
            string phone = textBox_phone.Text;
            int height = int.Parse(textBox_height.Text);
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
            userPicture.Image.Save(memoryStream,userPicture.Image.RawFormat);
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

                    if(user.insertUser(Fname, Lname, bdDate, joinDate, weight, phone, address, gender, joinReason, height, image))
                    {
                        MessageBox.Show("User added successfully!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }catch(Exception ex)

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
    }
}
