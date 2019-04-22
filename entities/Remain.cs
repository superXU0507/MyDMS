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
            set {
                this.remainnum = value;
            }
            get {
                return this.remainnum;
            }
        }


    }
}
