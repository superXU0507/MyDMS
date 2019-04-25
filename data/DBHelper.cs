using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace 入库出库管理系统.data
{
    class DBHelper
    {

        private MySqlConnection connection;

        public MySqlConnection Connection
        {
            get
            {

                String connectionString = "server = localhost; database = my_base; user id = root; password = 19960930;";

                connection = new MySqlConnection(connectionString);

                connection.Open();

                Console.WriteLine("连接成功");
                return connection;
            }
        }

        public int ExecuteCommand(String sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            Console.WriteLine(sql);
            int result = cmd.ExecuteNonQuery();
            
            return result;
        }

        public int ExecuteCommand(String sql, MySqlParameter[] values)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connection);

            cmd.Parameters.AddRange(values);

            return cmd.ExecuteNonQuery();
        }

        public MySqlDataReader GetReader(String sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }


        public MySqlDataReader GetReader(String sql, MySqlParameter[] values)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connection);

            cmd.Parameters.AddRange(values);

            MySqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

    }
}
