using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymApp
{
    public partial class Mangeplans : Form
    {
        planClass plan = new planClass();
        public Mangeplans()
        {
            InitializeComponent();
            customizeDesign();
            showData();
        }
        private void customizeDesign()
        {
            usersSubMenu.Visible = false;
            plansSubMenu.Visible = true;
            progressSubMenu.Visible = false;
        }

        #region front-end stuff
        private void usersButton_Click(object sender, EventArgs e)
        {
            showSubMenu(usersSubMenu);

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

        private void button2_Click(object sender, EventArgs e)
        {
            Usercs AddUser = new Usercs();
            AddUser.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MangeClientData MangeClient = new MangeClientData();
            MangeClient.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClientPrint Clientprinnt = new ClientPrint();
            Clientprinnt.Show();
            this.Hide();
        }

        private void MangePlansPageExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddPlan AddPlan = new AddPlan();
            AddPlan.Show();
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
        #endregion

        public void showData()
        {
            managePlandataGridView.DataSource = plan.GetList();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Mangeplans_Load(object sender, EventArgs e)
        {

        }

        private void managePlandataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_managePlanID.Text = managePlandataGridView.SelectedRows[0].Cells[0].Value.ToString();
            textBox_managePlanName.Text = managePlandataGridView.SelectedRows[0].Cells[1].Value.ToString();
            textBox_managePlanTier.Text = managePlandataGridView.SelectedRows[0].Cells[2].Value.ToString();
            textBox_managePlanDuration.Text = managePlandataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_managePlanID.Clear();
            textBox_managePlanName.Clear();
            textBox_managePlanTier.Clear();
            textBox_managePlanDuration.Clear();
        }

        private bool verify()
        {
            if ((textBox_managePlanName.Text == "") || (textBox_managePlanTier.Text == "") || (textBox_managePlanDuration.Text == ""))
            {
                MessageBox.Show("Please fill all fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(textBox_managePlanID.Text, out id))
            {
                MessageBox.Show("Please select a valid plan ID to update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string planName = textBox_managePlanName.Text;
            string planTier = textBox_managePlanTier.Text;
            string planDuration = textBox_managePlanDuration.Text;
            if (verify())
            {
                if (plan.updatePlan(id, planName, planTier, planDuration))
                {
                    MessageBox.Show("Plan updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                }
                else
                {
                    MessageBox.Show("Failed to update plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_managePlanID.Text);
            if (MessageBox.Show("Are you sure you want to remove this plan", "Remove Plan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (plan.deleteById(id))
                {
                    showData();
                    MessageBox.Show("Plan Removed", "Remove plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button_Clear.PerformClick();
                }
            }
        }

        private void managePlandataGridView_Click(object sender, EventArgs e)
        {
            textBox_managePlanID.Text = managePlandataGridView.SelectedRows[0].Cells[0].Value.ToString();
            textBox_managePlanName.Text = managePlandataGridView.SelectedRows[0].Cells[1].Value.ToString();
            textBox_managePlanTier.Text = managePlandataGridView.SelectedRows[0].Cells[2].Value.ToString();
            textBox_managePlanDuration.Text = managePlandataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }
    }

}
   

