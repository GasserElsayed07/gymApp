﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymApp
{
    public partial class AddPlan : Form
    {
        planClass plan = new planClass();
        public AddPlan()
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

        #region front end stuff
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



        private void AddPlanExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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


        #endregion





        public void showData()
        {
            planDataGridView.DataSource = plan.GetList();
        }
        public bool verify()
        {
            if ((textBox_planName.Text == "") || (textBox_planTier.Text == "") || (textBox_planDuration.Text == ""))
            {
                MessageBox.Show("Please fill all fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button_addPLan_Click(object sender, EventArgs e)
        {
            string planName = textBox_planName.Text;
            string planTier = textBox_planTier.Text;
            string planDuration = textBox_planDuration.Text;
            if (verify())
            {
                plan.insertPlan(planName, planTier, planDuration);
                MessageBox.Show("Plan Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            showData();

        }


        private void button8_Click(object sender, EventArgs e)
        {
            ClientPrint Clientprinnt = new ClientPrint();
            Clientprinnt.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Print_Plan PrintPlan = new Print_Plan();
            PrintPlan.Show();
            this.Hide();
        }

      
    }
}
