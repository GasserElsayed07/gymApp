using MySql.Data.MySqlClient;

namespace gymApp
{
    public partial class Form1 : Form
    {
        DBconnecter connection = new DBconnecter();
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void Login_button_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM trainers WHERE trianerName = @username AND trianerPassword = @pass", connection.getConnection);
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = textBox_username.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox_password.Text;
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                connection.openConnection();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    currentSessionUsername.username = textBox_username.Text;
                    mainPage mainPage = new mainPage();
                    mainPage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
                connection.closeConnection();
            }
        }

        private void textBox_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_password.Focus();
            }
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_button.PerformClick();
            }
        }

     

       
    }
}
