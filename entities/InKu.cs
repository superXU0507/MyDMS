using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 入库出库管理系统.entities
{
    class InKu
    {
        private String in_id;

        private String pro_id;

        private String pro_name;

        private String in_time;

        private String cangku_id;

        private int in_num;

        public String In_id
        {
            set {
                this.in_id = value;
            }
            get {
                return this.in_id;
            }
        }

        public String Pro_id
        {
            set {
                this.pro_id = value;
            }
            get {
                return this.pro_id;
            }
        }

        public String Cangku_id
        {
            set {
                this.cangku_id = value;
            }
            get {
                return this.cangku_id;
            }
        }
        public String In_time
        {
            set {
                this.in_time = value;
            }
            get {
                return this.in_time;
            }
        }
        public int In_num
        {
            set {
                this.in_num = value;
            }
            get {
                return this.in_num;
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
