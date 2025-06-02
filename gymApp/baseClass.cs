using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymApp
{
    internal class baseClass
    {
        protected DBconnecter connect = new DBconnecter();

        protected virtual string GetQuery()
        {
            return "";
        }
        public DataTable GetList()
        {
            string query = GetQuery();

            MySqlCommand command = new MySqlCommand(query, connect.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        protected virtual string TableName { get; }
        protected virtual string PrimaryKeyColumn { get; }

        public virtual bool deleteById(int id)
        {
            string sql = $"DELETE FROM `{TableName}` WHERE `{PrimaryKeyColumn}`=@id";
            MySqlCommand command = new MySqlCommand(sql, connect.getConnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            connect.openConnection();
            bool result = command.ExecuteNonQuery() == 1;
            connect.closeConnection();

            return result;
        }
    }
}
