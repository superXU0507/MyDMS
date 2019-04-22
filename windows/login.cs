using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 入库出库管理系统.windows;
using 入库出库管理系统.data;
using 入库出库管理系统.entities;
namespace 入库出库管理系统
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = this.textBox1.Text;
            String password = this.textBox2.Text;
            Console.WriteLine(username);
            Console.WriteLine(password);
            User_service userservice = new User_service();
            User user = userservice.getUserByName(username);

            Console.WriteLine(user.Username);
            Console.WriteLine(user.Password);
            Console.WriteLine(user.Limit);
            if (username.Equals(user.Username) && password.Equals(user.Password))
            {
                // String username_search = ;
                //  Console.WriteLine(password); 
                if (user.Limit == 1)
                {
                    Form mainform = new manage();
                    this.Visible = false;
                    mainform.Show();
                }
                else
                {
                    Form adminform = new AdminForm();
                    this.Visible = false;
                    adminform.Show();
                }

            }

            else if (username.Equals(user.Username) && !password.Equals(user.Password))
            {
                MessageBox.Show("密码错误请重新输入");
            }

            else
            {
                if (username.Length == 0)
                {
                    MessageBox.Show("请填写用户名");
                }
                else
                {
                    MessageBox.Show("系统找不到该用户");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
