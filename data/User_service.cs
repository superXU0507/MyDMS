using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 入库出库管理系统.entities;
using MySql.Data.MySqlClient;
namespace 入库出库管理系统.data
{
    class User_service
    {
        private DBHelper helper = new DBHelper(); //helper实例

        //通过用户名查找用户
        public User getUserByName(String name)
        {
            User user = new User();
            String sql = "select * from user where user_name='" + name + "'";

            MySqlDataReader reader = helper.GetReader(sql);

            while (reader.Read())
            {
                user.Userid = (int)reader["id"];
                user.Username = reader["user_name"].ToString();
                user.Password = reader["password"].ToString();
                user.Limit = (int)reader["limits"];
            }
            return user;
        }
        //获取所有的用户
        public IList<User> getAllUsers()
        {
            IList<User> list = new List<User>();
            String sql = "select * from user";

            MySqlDataReader reader = helper.GetReader(sql);

            while (reader.Read())
            {
                User user = new User();
                user.Userid = (int)reader["id"];
                user.Username = reader["user_name"].ToString();
                user.Password = reader["password"].ToString();
                user.Limit = (int)reader["limits"];

                list.Add(user);
            }
            return list;
        }

        //根据仓库号查询仓库

        public CangKu getCangKuByID(int id)
        {
            CangKu cangku = new CangKu();

            String sql = "select * from storehouse where id='" + id + "'";
            MySqlDataReader reader = helper.GetReader(sql);

            while (reader.Read())
            {
                cangku.Cangku_id = (int)reader["storehouse_id"];
                cangku.Cangku_name = reader["storehouse_name"].ToString();
            }

            return cangku;
        }

        //获取所有的仓库信息

        public IList<CangKu> getAllCangku()
        {
            IList<CangKu> list = new List<CangKu>();
            String sql = "select * from storehouse";
            MySqlDataReader reader = helper.GetReader(sql);

            while (reader.Read())
            {
                CangKu cangku = new CangKu();
                cangku.Cangku_id = (int)reader["storehouse_id"];
                cangku.Cangku_name = reader["storehouse_name"].ToString();
                list.Add(cangku);
            }
            return list;
        }

        //获取所有的产品信息

        public IList<Product> getAllProduct()
        {
            IList<Product> list = new List<Product>();
            String sql = "select * from product";
            MySqlDataReader reader = helper.GetReader(sql);
            while (reader.Read())
            {
                Product product = new Product();
                product.Pro_id = reader["product_id"].ToString();
                product.Pro_name = reader["product_name"].ToString();
                list.Add(product);
            }

            return list;
        }

    }
}
