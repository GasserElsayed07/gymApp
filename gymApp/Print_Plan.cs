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
using DGVPrinterHelper;


namespace gymApp
{
    public partial class Print_Plan : Form
    {
        planClass plan = new planClass();
        DGVPrinter printer = new DGVPrinter();
        public Print_Plan()
        {
            InitializeComponent();
            customizeDesign();
        }

        #region front-end stuff
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
        private void customizeDesign()
        {
            usersSubMenu.Visible = false;
            plansSubMenu.Visible = true;
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

        private void MangePlansPageExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Print_Progress PrintProgress = new Print_Progress();
            PrintProgress.Show();
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

        #endregion
        private void Print_Plan_Load(object sender, EventArgs e)
        {
            plandataGridViewPrint.DataSource = plan.GetList();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            printer.Title = "Plans list";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "GymApp";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(plandataGridViewPrint);
        }
    }
}
