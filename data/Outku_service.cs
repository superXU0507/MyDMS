using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using 入库出库管理系统.entities;
namespace 入库出库管理系统.data
{
    class Outku_service
    {
        DBHelper helper = new DBHelper();
        public int outKu(IList<Outku> outkus)
        {
            int result = 0;
            String sql = "insert into out_table(out_product,out_time,storehouse_id,out_num) values('" + outkus[0].Pro_id + "','" + outkus[0].Out_time + "','" + outkus[0].Cangku_id + "','" + outkus[0].Out_num + "')";
            if (outkus.Count > 0)
            {
                for (int i = 1; i < outkus.Count; i++)
                {
                    sql += ",('" + outkus[0].Pro_id + "','" + outkus[0].Out_time + "','" + outkus[0].Cangku_id + "','" + outkus[0].Out_num + "')";
                }
            }
            Console.WriteLine(sql);
            //result返回操作影响的行数，不为0表示成功
            result = helper.ExecuteCommand(sql);

            return result;
        }

        public IList<Outku> getAllOutkus()
        {
            IList<Outku> list = new List<Outku>();

            String sql = "select * from out_table";

            MySqlDataReader reader = helper.GetReader(sql);
            Product_service pro_ser = new Product_service();

            while (reader.Read())
            {
                Outku outku = new Outku();

                outku.Out_id = reader["idout_table"].ToString();
                outku.Pro_id = reader["out_product"].ToString();
                outku.Out_time = reader["out_time"].ToString();
                outku.Out_num = Convert.ToInt32(reader["out_num"].ToString());
                outku.Cangku_id = reader["storehouse_id"].ToString();

                list.Add(outku);
            }

            return list;
        }

        public IList<Outku> getOutkusByCangkuid(String cangkuid)
        {
            IList<Outku> list = new List<Outku>();

            String sql = "select * from out_table where storehouse_id='" + cangkuid + "'";

            MySqlDataReader reader = helper.GetReader(sql);
            Product_service pro_ser = new Product_service();

            while (reader.Read())
            {
                Outku outku = new Outku();

                outku.Out_id = reader["idout_table"].ToString();
                outku.Pro_id = reader["out_product"].ToString();
                outku.Out_time = reader["out_time"].ToString();
                outku.Out_num = Convert.ToInt32(reader["out_num"].ToString());
                outku.Cangku_id = reader["storehouse_id"].ToString();

                list.Add(outku);
            }

            return list;
        }


        public int deleteById(IList<String> ids)
        {
            int result = 0;
            String sql = "delete from out_table where idout_table in('";
            int count = ids.Count;
            if (count != 0)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    sql += ids[i] + "','";
                }
                sql += ids[count - 1] + "')";

                result = helper.ExecuteCommand(sql);
            }


            return result;

        }
    }
}
