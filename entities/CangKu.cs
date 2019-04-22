using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 入库出库管理系统.entities
{
    class CangKu
    {
        private int cangku_id;
        private String cangku_name;

        public int Cangku_id
        {
            set {
                this.cangku_id = value;
            }
            get {
                return this.cangku_id;
            }
        }

        public String Cangku_name
        {
            set {
                this.cangku_name = value;
            }
            get {
                return this.cangku_name;
            }
        }


    }
}
