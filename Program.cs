﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using 入库出库管理系统.windows;


//程序主入口，显示第一个登录窗口
namespace 入库出库管理系统
{   
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
            //  Application.Run(new SetPermission());
        }
    }
}
