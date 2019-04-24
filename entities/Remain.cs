using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 入库出库管理系统.entities
{
    class Remain
    {
        private String cangkuname;
        private String productname;
        private int remainnum;
        private int totalprice;
        private String supplier;
        private String other_info;

        public String Cangkuname
        {
            set {
                this.cangkuname = value;
            }
            get {
                return this.cangkuname;
            }
        }

        public String Productname
        {
            set {
                this.productname = value;
            }
            get {
                return this.productname;
            }
        }

        public int Remainnum
        {
            set
            {
                this.remainnum = value;
            }
            get
            {
                return this.remainnum;
            }
        }

        public int Totalprice
        {
            set
            {
                this.totalprice = value;
            }
            get
            {
                return this.totalprice;
            }
        }

        public String Supplier
        {
            set
            {
                this.supplier = value;
            }
            get
            {
                return this.supplier;
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


    }
}
