using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 入库出库管理系统.entities
{
    class User
    {
        private String username;

        private String password;

        private int limit;

        private int userid;

        public int Userid
        {
            get { return this.userid; }
            set { this.userid = value; }
        }

       public String Password
        {
            set {
                this.password = value;
            }
            get {
                return this.password;
            }
        }

       public String Username
       {
           set {
               this.username = value;
           }
           get {
               return this.username;
           }
       }

       public int Limit
       {
           set {
               this.limit = value;
           }

           get {
               return this.limit;
           }
       }

    }
}
