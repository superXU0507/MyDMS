using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 入库出库管理系统.entities;
using MySql.Data.MySqlClient;
namespace 入库出库管理系统.data
{
    class Memange_service
    {
        private DBHelper helper = new DBHelper();

        public IList<Remain> getAllRemainInfos()
        {
            IList<Remain> list = new List<Remain>();
            String sql = "select * from remain_state";
          
            MySqlDataReader reader = helper.GetReader(sql);
            while (reader.Read())
            {
               Remain remain = new Remain();

               remain.Remainnum = (int)reader["remain"] ;
                
               int cangkuid = (int)reader["cangku_id"];

               int productid = (int)reader["product_id"];

               MySqlDataReader reader1 = helper.GetReader("select storehouse_name from storehouse where storehouse_id = '" + cangkuid + "'");

               if (reader1.Read())
               {
                   remain.Cangkuname = reader1["storehouse_name"].ToString();
               }

               MySqlDataReader reader2 = helper.GetReader("select product_name from product where product_id = '" + productid + "'");
              
               if (reader2.Read())
               {
                   remain.Productname = reader2["product_name"].ToString();
                  
               }
               list.Add(remain);

            }

            return list;
        }

        public int addRemain(IList<Remain> remains)
        {
            int result = 0;
            String sql = "insert into remain_state(cangku_id,product_id,remain) values('"+remains[0].Cangkuname+"','"+remains[0].Productname+"','"+remains[0].Remainnum+"')";
            if (remains.Count > 0)
            {
                for (int i = 1; i < remains.Count; i++)
                {
                    sql += ",('" + remains[i].Cangkuname + "','" + remains[i].Productname + "','" + remains[i].Remainnum + "')";
                }
            }
            Console.WriteLine(sql);
            //result返回操作影响的行数，不为0表示成功
           result =  helper.ExecuteCommand(sql);
            
            return result;
        }

        public int addRemain(Remain remain)
        {
            int result = 0;
            String sql = "insert into remain_state(cangku_id,product_id,remain) values('" + remain.Cangkuname + "','" + remain.Productname + "','" + remain.Remainnum + "')";
            result = helper.ExecuteCommand(sql);
            return result;
        }
        public int deleteRemain(IList<String> product_ids)
        {
            int result = 0;
            String sql = "delete from remain_state where product_id in('";
            int count = product_ids.Count;
            if (count != 0)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    sql += product_ids[i] + "','";
                }
                sql += product_ids[count - 1] + "')";

                result = helper.ExecuteCommand(sql);
            }

           
            return result;
        }

        public String getProIdByName(String name)
        {
            String sql = "select product_id from product where product_name = '" + name + "'";

            MySqlDataReader reader = helper.GetReader(sql);
            String result = "";
            while (reader.Read())
            {
                result = reader["product_id"].ToString();
            }


            return result;
        }
  
        public IList<Remain> getRemains(String sql)
        {
            IList<Remain> list = new List<Remain>();
            MySqlDataReader reader = helper.GetReader(sql);

            while (reader.Read())
            {
                Remain remain = new Remain();
                remain.Remainnum = (int)reader["remain"];
                int cangkuid = (int)reader["cangku_id"];

                int productid = (int)reader["product_id"];

                MySqlDataReader reader1 = helper.GetReader("select storehouse_name from storehouse where storehouse_id = '" + cangkuid + "'");

                if (reader1.Read())
                {
                    remain.Cangkuname = reader1["storehouse_name"].ToString();
                }

                MySqlDataReader reader2 = helper.GetReader("select product_name from product where product_id = '" + productid + "'");

                if (reader2.Read())
                {
                    remain.Productname = reader2["product_name"].ToString();

                }
                list.Add(remain);
            }
            return list;
        
        }

        public int updateRemain(Remain remain)
        {
            String pro_id = remain.Productname;
            String sql = "update remain_state set remain='"+remain.Remainnum+"' where product_id='"+pro_id+"'";

            int result = helper.ExecuteCommand(sql);

            return result;
        }

        public int getRemainNum(String pro_id)
        {
            String sql = "select remain from remain_state where product_id = '"+pro_id+"'";

            MySqlDataReader reader = helper.GetReader(sql);
            int result = 0;
            if (reader.Read())
            {
                result = (int)reader["remain"];
            }
            return result;
        }
        
        
    }



}
