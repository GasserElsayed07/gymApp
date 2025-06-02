using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace gymApp
{
    internal class planClass : baseClass
    {
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

        protected override string GetQuery()
        {
            return "SELECT * FROM `userplan`";
        }

        public bool updatePlan(int planId, string planName, string planTier, string planDuration)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `userplan` SET `name`=@_name,`tier`=@_tier,`duration`=@_duration WHERE `id`=@_id", connect.getConnection);
            command.Parameters.Add("@_id", MySqlDbType.Int32).Value = planId;
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


        protected override string TableName => "userplan";
        protected override string PrimaryKeyColumn => "id";
    }
}
