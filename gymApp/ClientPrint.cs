using DGVPrinterHelper;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace gymApp
{
    public partial class ClientPrint : Form
    {
        userClass user = new userClass();
        DGVPrinter printer = new DGVPrinter();
        public ClientPrint()
        {
            InitializeComponent();
            customizeDesign();
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
        private void customizeDesign()
        {
            usersSubMenu.Visible = false;
            plansSubMenu.Visible = false;
            progressSubMenu.Visible = true;
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

        private void PtintClientPageExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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


        private void button1_Click(object sender, EventArgs e)
        {
            mainPage mainPage = new mainPage();
            mainPage.Show();
            this.Hide();
        }



        private void showData(MySqlCommand command)
        {
            ClientdataGridViewPrint.ReadOnly = true;
            ClientdataGridViewPrint.DataSource = user.getListForPrint(command);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)ClientdataGridViewPrint.Columns[12];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;


        }

        private void ClientdataGridViewPrint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientPrint_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM `user` "));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            printer.Title = "Clients list";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "GymApp";
            printer.FooterSpacing = 20;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(ClientdataGridViewPrint);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string selectedQuery = "";
            if (AllGenderradioButton1.Checked)
            {
                selectedQuery = "SELECT * FROM `user` ";
            }
            else if (MaleradioButton.Checked)
            {
                selectedQuery = "SELECT * FROM `user` WHERE `userGender`= 'Male' ";
            }
            else if (radioButton_female.Checked)
            {
                selectedQuery = "SELECT * FROM `user` WHERE `userGender`='Female' ";

            }
            showData(new MySqlCommand(selectedQuery));
        }

     

        private void button4_Click(object sender, EventArgs e)
        {
            Print_Plan PrintPlan = new Print_Plan();
            PrintPlan.Show();
            this.Hide();
        }
    }
}
