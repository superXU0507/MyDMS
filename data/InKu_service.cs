using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 入库出库管理系统.entities;
using MySql.Data.MySqlClient;
namespace 入库出库管理系统.data
{
    class InKu_service
    {
        DBHelper helper = new DBHelper();

        public int addKu(IList<InKu> inkus)
        {
            int result = 0;
            String sql = "insert into in_table(idin_table,in_cangku_id,in_product_id,in_time,in_num,supplier,other_info) values('" + inkus[0].In_id + "','" + inkus[0].Cangku_id + "','" + inkus[0].Pro_id + "','" + inkus[0].In_time + "','" + inkus[0].In_num + "','" + inkus[0].Supplier + "','" + inkus[0].Other_info + "')";
            if (inkus.Count > 0)
            {
                for (int i = 1; i < inkus.Count; i++)
                {
                    sql += ",('" + inkus[0].In_id + "','" + inkus[0].Cangku_id + "','" + inkus[0].Pro_id + "','" + inkus[0].In_time + "','" + inkus[0].In_num + "','" + inkus[0].Supplier + "','" + inkus[0].Other_info + "')";
                }
            }
            Console.WriteLine(sql);
            //result返回操作影响的行数，不为0表示成功
            result = helper.ExecuteCommand(sql);

            return result;
            
        }

        public IList<InKu> getAllInkus()
        {
            IList<InKu> list = new List<InKu>();

            String sql = "select * from in_table";

            MySqlDataReader reader = helper.GetReader(sql);
            Product_service pro_ser = new Product_service();

            while (reader.Read())
            {
                InKu inku = new InKu();

                inku.In_id = reader["idin_table"].ToString();
                inku.Pro_id = reader["in_product"].ToString();
                inku.In_time = reader["in_time"].ToString();
                inku.In_num = Convert.ToInt32(reader["in_num"].ToString());
                inku.Cangku_id = reader["storehouse_id"].ToString();

                list.Add(inku);
            }

            return list;
        }

        public IList<InKu> getInkusByCangkuid(String cangkuid)
        {
            IList<InKu> list = new List<InKu>();

            String sql = "select * from in_table where storehouse_id='"+cangkuid+"'";

            MySqlDataReader reader = helper.GetReader(sql);
            Product_service pro_ser = new Product_service();

            while (reader.Read())
            {
                InKu inku = new InKu();

                inku.In_id = reader["idin_table"].ToString();
                inku.Pro_id = reader["in_product"].ToString();
                inku.In_time = reader["in_time"].ToString();
                inku.In_num = Convert.ToInt32(reader["in_num"].ToString());
                inku.Cangku_id = reader["storehouse_id"].ToString();

                list.Add(inku);
            }

            return list;
        }

        public int deleteById(IList<String> ids)
        {
            int result = 0;
            String sql = "delete from in_table where idin_table in('";
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
