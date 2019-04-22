using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using 入库出库管理系统.data;
using 入库出库管理系统.entities;
namespace 入库出库管理系统.windows
{
    public partial class AdminForm : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

        public AdminForm() //构造函数
        {
            InitializeComponent();
            InitialData();

            //使用数据绑定对datagridview填充数据
        }
        //初始化数据
        public void InitialData()
        {
            User_service myservice = new User_service();

            IList<User> userlist = myservice.getAllUsers();
            IList<CangKu> cangkulist = myservice.getAllCangku();
            //  IList<Product> productlist = myservice.getAllProduct();
            this.dataGridView1.Rows.Clear();
            //this.dataGridView2.Rows.Clear();
            this.Userdataview.Rows.Clear();

            for (int i = 0; i < userlist.Count; i++)
            {
                User user = userlist[i];
                String[] row = { user.Userid.ToString(), user.Username, user.Password, user.Limit.ToString() };
                this.Userdataview.Rows.Add(row);
            }

            for (int j = 0; j < cangkulist.Count; j++)
            {
                CangKu cangku = cangkulist[j];
                String[] row1 = { cangku.Cangku_id.ToString(), cangku.Cangku_name };
                this.dataGridView1.Rows.Add(row1);
            }


            /* for (int k = 0; k < productlist.Count;k++ )
             {
                 Product product = productlist[k];
                 String[] row2 = { product.Pro_id.ToString(),product.Pro_name};
                 this.dataGridView2.Rows.Add(row2);
             }
            */
            /*
            String connectionString = "server = localhost; database = menagesystem; user id = root; password = 123456;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            String sql = "select *from product";
            DataSet ds = new DataSet();         
            MySqlDataAdapter da = new MySqlDataAdapter(sql,connection);
            da.Fill(ds, "product");
            dataGridView2.DataSource = ds.DefaultViewManager;
            */

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = bindingSource1;  //在窗体加载的时候绑定数据,绑定产品
            GetData("select * from product");

            //向tabcontrol中动态添加自定义控件
            System.Windows.Forms.TabPage tabPage = new System.Windows.Forms.TabPage(); //创建选项页
            UserControl1 uc = new UserControl1();//自定义的控件
            uc.Dock = System.Windows.Forms.DockStyle.Fill; //设置userControl的停靠
            tabPage.Text = "选项卡";
            tabPage.Controls.Add(uc);//将自定义控件添加到选项页

            tabControl1.TabPages.Add(tabPage);//将选项页添加到TabControl

        }
        private void GetData(string selectCommand)    //获取数据
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                String connectionString =
                    "server = localhost; database = menagesystem; user id = root; password = 123456;";

                // Create a new data adapter based on the specified query.
                dataAdapter = new MySqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                //dataGridView2.AutoResizeColumns(
                //DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dataGridView2.Columns[0].ReadOnly = true;

                dataGridView2.Columns[0].HeaderText = "产品ID";
                dataGridView2.Columns[1].HeaderText = "产品名称";

            }
            catch (MySqlException)
            {

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Userdataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView1的第一列隐藏
            //Userdataview.Columns[0].Visible = false;
            // DataGridView1的第一行隐藏
            //Userdataview.Rows[0].Visible = false;
            if (e.ColumnIndex == 5) //删除用户
            {
                if (MessageBox.Show(this, "确定删除吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UserManage deleteuser = new UserManage();

                    int id = Convert.ToInt32(Userdataview.CurrentRow.Cells[0].Value);
                    int tt = deleteuser.deleteUser(id);
                    if (tt == 1)
                    {
                        MessageBox.Show("删除成功！", "删除成功");
                        InitialData();
                    }

                }
            }
            if (e.ColumnIndex == 4) //修改用户
            {
                UserManage updateuser = new UserManage();
                User user = new User();

                int id = Convert.ToInt32(Userdataview.CurrentRow.Cells[0].Value);
                String user_name = Userdataview.CurrentRow.Cells[1].Value.ToString();
                String password = Userdataview.CurrentRow.Cells[2].Value.ToString();
                int limit = Convert.ToInt32(Userdataview.CurrentRow.Cells[3].Value);

                //判断用户信息是否有改动
                user = updateuser.selectUser(id);
                if (user.Username == user_name && user.Password == password && user.Limit == limit)
                {
                }
                else if (limit != 1 && limit != 2)
                {
                    MessageBox.Show("用户权限为1或为2！", "提示");
                    InitialData();
                    return;
                }
                else
                {
                    int tt = updateuser.updateUser(id, user_name, password, limit);
                    if (tt == 1)
                    {
                        MessageBox.Show("修改成功！", "提示");
                        InitialData();
                    }
                }
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CangKuManage addcangku = new CangKuManage();
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                return;
            }
            else if (dataGridView1.CurrentRow.Cells[1].Value == null)
            {
                MessageBox.Show("仓库名称不能为空！");
                return;
            }
            int num = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            String name = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            int tt = addcangku.addCangKu(num, name);
            if (tt == 1)
            {
                MessageBox.Show("添加成功！", "添加成功");
                InitialData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "确定删除吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CangKuManage deletecangku = new CangKuManage();   //可以一次删除多条
                IList<int> deleId = new List<int>();
                int delcount = 0; //作为删除条数的记录
                int count = dataGridView1.Rows.Count;
                int selectCount = dataGridView1.SelectedRows.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        int id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        deleId.Add(id);
                    }
                }
                for (int j = 0; j < deleId.Count; j++)
                {
                    int tt = 0;
                    tt = deletecangku.deleteCangKu(deleId[j]);
                    if (tt == 1)
                    {
                        delcount++;
                    }
                }

                if (delcount == selectCount)
                {
                    MessageBox.Show("删除成功！", "提示");
                    InitialData();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(ref Userdataview);
            addUser.Show();
            /*
            UserManage adduser = new UserManage();
            
            if (Userdataview.CurrentRow.Cells[0].Value != null)
            {
                return;
            }
            if (Userdataview.CurrentRow.Cells[1].Value == null)
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            else if (Userdataview.CurrentRow.Cells[2].Value == null)
            {
                MessageBox.Show("用户密码不能为空！");
                return;
            }
            else if (Userdataview.CurrentRow.Cells[3].Value == null)
            {
                MessageBox.Show("用户权限不能为空！");
                return;
            }
            String name = Userdataview.CurrentRow.Cells[1].Value.ToString();
            String password = Userdataview.CurrentRow.Cells[2].Value.ToString();
            int limit = Convert.ToInt32(Userdataview.CurrentRow.Cells[3].Value);
            if (limit != 1 && limit != 2)
            {
                MessageBox.Show("用户权限为1或为2！", "提示");
                InitialData();
                return;
            }

            int test = adduser.testUser(name);
            if (test==1)
            {
                MessageBox.Show("用户名已经存在！");                
                return;
            }

            int tt = adduser.addUser(name, password,limit);
            if (tt == 1)
            {
                MessageBox.Show("添加成功！", "添加成功");
                InitialData();
            }
            */
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "确定批量删除吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UserManage deleteuser = new UserManage();

                IList<int> deleId = new List<int>();
                int delcount = 0; //作为删除条数的记录
                int count = Userdataview.Rows.Count;
                int selectCount = Userdataview.SelectedRows.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    if (Userdataview.Rows[i].Selected)
                    {
                        int id = Convert.ToInt32(Userdataview.Rows[i].Cells[0].Value);
                        deleId.Add(id);
                    }
                }
                for (int j = 0; j < deleId.Count; j++)
                {
                    int tt = 0;
                    tt = deleteuser.deleteUser(deleId[j]);
                    if (tt == 1)
                    {
                        delcount++;
                    }
                }

                if (delcount == selectCount)
                {
                    MessageBox.Show("删除成功！", "提示");
                    InitialData();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        private void dataGridView2_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*
            ProductManage addproduct = new ProductManage();
            if (dataGridView2.CurrentRow.Cells[0].Value != null)
            {
                return;
            }
            else if (dataGridView2.CurrentRow.Cells[1].Value == null)
            {
                MessageBox.Show("产品名称不能为空！");
                return;
            }
            int num = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            String name = dataGridView2.CurrentRow.Cells[1].Value.ToString();

            int tt = addproduct.addProduct(num, name);
            if (tt == 1)
            {
                MessageBox.Show("添加成功！", "添加成功");
                InitialData();
            }
             */
            GetData(dataAdapter.SelectCommand.CommandText);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "确认要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ProductManage deleteproduct = new ProductManage();
                int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                int tt = deleteproduct.deleteProduct(id);
                if (tt == 1)
                {
                    MessageBox.Show("删除成功!", "提示");
                    GetData(dataAdapter.SelectCommand.CommandText);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CangKuManage updatecangku = new CangKuManage();
            if (dataGridView1.CurrentRow.Cells[0] != null)
            {
                int cangku_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                String cangku_name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                int tt = updatecangku.updateCangKu(cangku_id, cangku_name);
                if (tt == 1)
                {
                    MessageBox.Show("修改成功！", "提示");
                    InitialData();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserManage updateuser = new UserManage();
            if (Userdataview.CurrentRow.Cells[0].Value != null)
            {
                int id = Convert.ToInt32(Userdataview.CurrentRow.Cells[0].Value);
                String user_name = Userdataview.CurrentRow.Cells[1].Value.ToString();
                String password = Userdataview.CurrentRow.Cells[2].Value.ToString();
                int limit = Convert.ToInt32(Userdataview.CurrentRow.Cells[3].Value);
                if (limit != 1 && limit != 2)
                {
                    MessageBox.Show("用户权限为1或为2！", "提示");
                    InitialData();
                    return;
                }
                int tt = updateuser.updateUser(id, user_name, password, limit);
                if (tt == 1)
                {
                    MessageBox.Show("修改成功！", "提示");
                    InitialData();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            /*
            ProductManage updateproduct = new ProductManage();
            if (dataGridView2.CurrentRow.Cells[0] != null)
            {
                int product_id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                String product_name = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                int tt = updateproduct.updateProduct(product_id, product_name);
                if (tt == 1)
                {
                    MessageBox.Show("修改成功！", "提示");
                    InitialData();
                }
            }
             */
            dataAdapter.Update((DataTable)bindingSource1.DataSource);
            GetData(dataAdapter.SelectCommand.CommandText);
        }
    }
}

