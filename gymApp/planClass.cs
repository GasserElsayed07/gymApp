using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace gymApp
{
    internal class planClass
    {
        DBconnecter connect = new DBconnecter();
        public bool insertPlan(string planName, string planTier, string planDuration)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `userplan`(`name`, `tier`, `duration`) VALUES (@_name,@_tier,@_duration)",connect.getConnection);
            command.Parameters.Add("@_name", MySqlDbType.VarChar).Value = planName;
            command.Parameters.Add("@_tier", MySqlDbType.VarChar).Value = planTier;
            command.Parameters.Add("@_duration", MySqlDbType.VarChar).Value = planDuration;
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

        public DataTable getPlansList()
        {
            MySqlCommand command = new MySqlCommand("Select * from userplan", connect.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable plansDataTable = new DataTable();
            adapter.Fill(plansDataTable);
            return plansDataTable;
        }
    }
}
