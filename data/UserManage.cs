using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using 入库出库管理系统.entities;

namespace 入库出库管理系统.data
{
    class UserManage
    {
        public int testUser(String name)
        {
            
            DBHelper helper = new DBHelper();
            String sql = "select * from user where user_name='"+name+"'";
            MySqlDataReader reader = helper.GetReader(sql);
            if (reader.HasRows)
            {
                return 1;
            }
            return 0;
        }
        public User selectUser(int id)
        {
            User user = new User();
            DBHelper helper = new DBHelper();
            String sql = "select * from user where id='"+id+"'";
            MySqlDataReader dataReader = helper.GetReader(sql); ;
            if (dataReader.Read())
            {
                user.Username = dataReader["user_name"].ToString();
                user.Password = dataReader["password"].ToString();
                user.Limit = Convert.ToInt32(dataReader["limits"]);
            }
           
            return user;
        }
        public int addUser(String name, String password,int limit)
        {
            int result;
            DBHelper helper = new DBHelper();
            String sql = "insert into user(user_name,password,limits) values('" + name + "','" + password + "', '"+limit+"' )";
            result = helper.ExecuteCommand(sql);
            return result;
        }
        public int updateUser(int id,String name, String password, int limit)
        {
            int result;
            DBHelper helper = new DBHelper();
            String sql = "update user set user_name='" + name + "',password='"+password+"',limits='"+limit+"'where id='"+id+"'";
            result = helper.ExecuteCommand(sql);
            return result;
        }
        public int deleteUser(int id)
        {
            int result;
            DBHelper helper = new DBHelper();
            String sql = "delete from user where id = '" + id + "'";
            result = helper.ExecuteCommand(sql);
            return result;
        }

    }
}
