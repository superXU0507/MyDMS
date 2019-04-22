using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 入库出库管理系统.data;
using 入库出库管理系统.entities;

namespace 入库出库管理系统.windows
{
    public partial class AddUser : Form
    {
        private DataGridView dataview = null;
        public AddUser(ref DataGridView dataview)
        {
            InitializeComponent();
            this.dataview = dataview;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //SetPermission sp = new SetPermission();

        }
        private void textBox4_MouseClick(object sender, EventArgs e)
        {
            if (textBox6.Focused)
            {
                SetPermission sp = new SetPermission();
                sp.Show();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserManage adduser = new UserManage();
            if (textBox1.Text == null)
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            else if (textBox5.Text == null)
            {
                MessageBox.Show("用户密码不能为空！");
                return;
            }
            else if (textBox6.Text == null)
            {
                MessageBox.Show("用户权限不能为空！");
                return;
            }
            String name = textBox1.Text;
            String password = textBox5.Text;
            int limit = Convert.ToInt32(textBox6.Text);
            int test = adduser.testUser(name);
            if (test == 1)
            {
                MessageBox.Show("用户名已经存在！");
                return;
            }

            int tt = adduser.addUser(name, password, limit);
            if (tt == 1)
            {
                MessageBox.Show("添加成功！", "添加成功");
                this.Close();

                User_service myservice = new User_service();
                IList<User> userlist = myservice.getAllUsers();
                dataview.Rows.Clear();
                for (int i = 0; i < userlist.Count; i++)
                {
                    User user = userlist[i];
                    String[] row = { user.Userid.ToString(), user.Username, user.Password, user.Limit.ToString() };
                    dataview.Rows.Add(row);
                }
            }

        }
    }
}

