using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 入库出库管理系统.data
{
    class ProductManage
    {
        public int addProduct(int product_id,String name)
        {
            DBHelper helper = new DBHelper();
            String sql = "insert into product(product_id,product_name) value('"+product_id+"','"+name+"')";
            int result = helper.ExecuteCommand(sql);
            return result;
        }
        public int deleteProduct(int product_id)
        {
                      
            DBHelper helper = new DBHelper();
            String sql = "delete from product where product_id='"+product_id+"' ";
            int result = helper.ExecuteCommand(sql);
            return result;
            
        }
        public int updateProduct(int product_id, String product_name)
        {
            int result;
            DBHelper helper = new DBHelper();
            string sql = "update product set product_name='" +product_name + "' where product_id='" + product_id + "' ";
            result = helper.ExecuteCommand(sql);
            return result;
        }
    }
}
