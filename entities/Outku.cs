using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 入库出库管理系统.entities
{
    class Outku
    {

         private String out_id;

        private String pro_id;

        private String pro_name;

        private String out_time;

        private String cangku_id;

        private String lingquman;

        private String other_info;

        private int out_num;

        public String Out_id
        {
            set {
                this.out_id = value;
            }
            get {
                return this.out_id;
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
            set
            {
                this.cangku_id = value;
            }
            get
            {
                return this.cangku_id;
            }
        }

        public String Lingquman
        {
            set
            {
                this.lingquman = value;
            }
            get
            {
                return this.lingquman;
            }
        }

        public String Other_info
        {
            set
            {
                this.other_info = value;
            }
            get
            {
                return this.other_info;
            }
        }
        public String Out_time
        {
            set {
                this.out_time = value;
            }
            get {
                return this.out_time;
            }
        }
        public int Out_num
        {
            set {
                this.out_num = value;
            }
            get {
                return this.out_num;
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
