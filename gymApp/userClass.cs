using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace gymApp
{
    internal class userClass
    {
        DBconnecter connect = new DBconnecter();
        public bool insertUser(string Fname, string Lname, DateTime bdDate, DateTime joinDate, int weight,
            string phone, string address, string gender, string joinReason, int height, byte[] image)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `user`(`userFirstName`, `userLastName`, `userBirthDate`, `userJoinDate`, `userWeight`, `userPhone`, `userAddress`, `userGender`, `userJoinReason`, `userHeight`, `userImage`) VALUES(@Fname, @Lname, @Bdate, @Jdate, @weight, @phone, @address, @gender, @Jreason, @height, @image)",connect.getConnection);
            // @Fname, @Lname, @Bdate, @Jdate, @weight, @phone, @address, @gender, @Jreason, @height, @image
            command.Parameters.Add("@Fname", MySqlDbType.VarChar).Value = Fname;
            command.Parameters.Add("@Lname", MySqlDbType.VarChar).Value = Lname;
            command.Parameters.Add("@Bdate", MySqlDbType.Date).Value = bdDate;
            command.Parameters.Add("@Jdate", MySqlDbType.Date).Value = joinDate;
            command.Parameters.Add("@weight", MySqlDbType.Int32).Value = weight;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@gender", MySqlDbType.VarString).Value = gender;
            command.Parameters.Add("@Jreason", MySqlDbType.VarChar).Value = joinReason;
            command.Parameters.Add("@height", MySqlDbType.Int32).Value = height;
            command.Parameters.Add("@image", MySqlDbType.Blob).Value = image;
            connect.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnection();
                return true;
            }
            else
            {
                connect.closeConnection();
                return false;
            }

        }

        public DataTable getUsersList()
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user`", connect.getConnection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            return dataTable;
  
        }

        public DataTable searchForUser(string searchQuery)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE CONCAT(`userFirstName`, `userLastName`, `userPhone`) LIKE '%"+ searchQuery +"%'", connect.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool updateUser(int id, DateTime joinDate, int weight,
            string phone, string address,string joinReason, int height)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `userJoinDate`= @Jdate ,`userWeight`= @weight ,`userPhone`= @phone ,`userAddress`= @address, `userJoinReason`= @Jreason,`userHeight`=@height WHERE `userID`=@id", connect.getConnection);
            // @Fname, @Lname, @Bdate, @Jdate, @weight, @phone, @address, @gender, @Jreason, @height, @image
            command.Parameters.Add("@Jdate", MySqlDbType.Date).Value = joinDate;
            command.Parameters.Add("@weight", MySqlDbType.Int32).Value = weight;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@Jreason", MySqlDbType.VarChar).Value = joinReason;
            command.Parameters.Add("@height", MySqlDbType.Int32).Value = height;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            connect.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnection();
                return true;
            }
            else
            {
                connect.closeConnection();
                return false;
            }

        }

        public DataTable getListForPrint(MySqlCommand command)
        {
            command.Connection = connect.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool deleteUser(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `user` WHERE `userID`=@id", connect.getConnection);

            //@id
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            connect.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnection();
                return true;
            }
            else
            {
                connect.closeConnection();
                return false;
            }

        }
    }
}
