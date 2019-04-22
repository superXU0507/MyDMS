using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 入库出库管理系统.entities
{
    class Product
    {
        private String pro_id;
        private String pro_name;

        public String Pro_id
        {
            set {
                this.pro_id = value;
            }
            get {
                return this.pro_id;
            }
        }
        public String Pro_name
        {
            set {
                this.pro_name = value;
            }
            get {
                return this.pro_name;
            }
        }
    }
}
