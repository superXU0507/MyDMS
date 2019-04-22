using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace 入库出库管理系统.data
{
    class Product_service
    {
        DBHelper helper = new DBHelper();
        public String getIdByName(String name) //获取产品的ID
        {
            String sql = "select product_id from product where product_name ='"+name+"'";

            MySqlDataReader reader = helper.GetReader(sql);
            String result = "";
            while (reader.Read())
            {
                result = reader["product_id"].ToString();
            }


            return result;
         
        }

        public int addProduct(String pro_name)
        {
            String sql = "insert into product(product_name) values ('"+pro_name+"')";

            return helper.ExecuteCommand(sql);
        }

    }
}
