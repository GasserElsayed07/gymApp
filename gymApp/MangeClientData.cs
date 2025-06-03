using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace gymApp
{
    public partial class MangeClientData : Form
    {
        userClass user = new userClass();
        public MangeClientData()
        {
            InitializeComponent();
            customizeDesign();
            showData();
            fillPlansComboBox();
        }
        private void customizeDesign()
        {
            usersSubMenu.Visible = true;
            plansSubMenu.Visible = false;
            progressSubMenu.Visible = false;
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

        private void hideSubMenu()
        {
            if (usersSubMenu.Visible == true)
                usersSubMenu.Visible = false;
            if (plansSubMenu.Visible == true)
                plansSubMenu.Visible = false;
            if (progressSubMenu.Visible == true)
                progressSubMenu.Visible = false;
        }

        private void MangeClientPageExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usercs AddUser = new Usercs();
            AddUser.Show();
            this.Hide();
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


        private void showData()
        {
            ClientdataGridView.DataSource = user.GetList();

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)ClientdataGridView.Columns[12];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

        }

        private void ClientdataGridView_Click(object sender, EventArgs e)
        {

            dateTimePicker_manageJoinDate.Value = Convert.ToDateTime(ClientdataGridView.CurrentRow.Cells[4].Value);
            textBox_manageWeight.Text = ClientdataGridView.CurrentRow.Cells[5].Value.ToString();
            textBox_managePhone.Text = ClientdataGridView.CurrentRow.Cells[6].Value.ToString();
            textBox_manageAddress.Text = ClientdataGridView.CurrentRow.Cells[7].Value.ToString();

            textBox_manageHeight.Text = ClientdataGridView.CurrentRow.Cells[10].Value.ToString();
            comboBox_manageUserPlan.SelectedItem = ClientdataGridView.CurrentRow.Cells[11].Value.ToString();
        }

        

        private void button_Clear_Click(object sender, EventArgs e)
        {
            dateTimePicker_manageJoinDate.Value = DateTime.Now;
            textBox_manageWeight.Clear();
            textBox_managePhone.Clear();
            textBox_manageAddress.Clear();

            textBox_manageHeight.Clear();

        }

        private void button_search_click(object sender, EventArgs e)
        {
            ClientdataGridView.DataSource = user.searchForUser(textBox_search.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)ClientdataGridView.Columns[12];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        bool verify()
        {
            if ((textBox_managePhone.Text == "") || (textBox_manageWeight.Text == "") || (textBox_manageHeight.Text == "") || (textBox_manageAddress.Text == ""))
            {
                MessageBox.Show("Please fill all the fields");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(ClientdataGridView.CurrentRow.Cells[0].Value.ToString(), out id))
            {
                MessageBox.Show("Please select a row with a valid ID to update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime joinDate = dateTimePicker_manageJoinDate.Value;
            int weight;
            if (!int.TryParse(textBox_manageWeight.Text, out weight))
            {
                MessageBox.Show("Please enter a valid weight.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string phone = textBox_managePhone.Text;
            int height;
            if (!int.TryParse(textBox_manageHeight.Text, out height))
            {
                MessageBox.Show("Please enter a valid height.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string address = textBox_manageAddress.Text;
       
            string plan = comboBox_manageUserPlan.SelectedItem.ToString();

            if (verify())
            {
                try
                {

                    if (user.updateUser(id, joinDate, weight, phone, address, height, plan))
                    {
                        MessageBox.Show("User updated successfully!", "update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
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

        private void UserPageExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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




        private void button1_Click(object sender, EventArgs e)
        {
            mainPage mainPage = new mainPage();
            mainPage.Show();
            this.Hide();
        }



        private void button13_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ClientdataGridView.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("Are you sure you want to remove this user", "Remove User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (user.deleteById(id))
                {
                    showData();
                    MessageBox.Show("User Removed", "Remove user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button_Clear.PerformClick();
                }
            }
        }





        private void button8_Click(object sender, EventArgs e)
        {
            ClientPrint Clientprinnt = new ClientPrint();
            Clientprinnt.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Print_Plan PrintPlan = new Print_Plan();
            PrintPlan.Show();
            this.Hide();

        }

        private void textBox_manageHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillPlansComboBox()
        {
            planClass plan = new planClass();
            DataTable dt = plan.GetList();

            comboBox_manageUserPlan.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string planName = dt.Rows[i]["name"].ToString();
                comboBox_manageUserPlan.Items.Add(planName);
            }

            if (comboBox_manageUserPlan.Items.Count > 0)
            {
                comboBox_manageUserPlan.SelectedIndex = 0;
            }
        }
    }
}
