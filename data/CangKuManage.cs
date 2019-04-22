using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 入库出库管理系统.entities;

namespace 入库出库管理系统.data
{
    class CangKuManage
    {
        public int addCangKu(int num,String name) 
        {
            int result;
            DBHelper helper = new DBHelper();
            String sql = "insert into storehouse(storehouse_id,storehouse_name) value('" + num + "','" + name + "')";
            result = helper.ExecuteCommand(sql);
            return result;
        }
        public int updateCangKu(int cangku_id,String cangku_name)
        {
            int result;
            DBHelper helper = new DBHelper();
            string sql = "update storehouse set storehouse_name='"+cangku_name+"' where storehouse_id='"+cangku_id+"' ";
            result = helper.ExecuteCommand(sql);
            return result;
        }
        public int deleteCangKu(int cangku_id)
        {
            int result;
            DBHelper helper = new DBHelper();
            String sql = "delete from storehouse where storehouse_id = '" + cangku_id + "'";
            result = helper.ExecuteCommand(sql);
            return result;
        }
    }
}
