using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 入库出库管理系统.windows
{
    public partial class SetPermission : Form
    {
        public SetPermission()
        {
            InitializeComponent();
            initialize();
        }

        private void SetPermission_load()
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView2.Rows.Add(dataGridView1.CurrentRow);
            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }
        private void initialize() //初始化填充data1，显示全部权限页面
        {
            dataGridView1.Rows.Add("1");
            dataGridView1.Rows.Add("2");
            /////////////////////////////////
            dataGridView2.Rows.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvRow in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(dgvRow);
                dataGridView2.Rows.Add(dgvRow);
                dataGridView1.Refresh();
                dataGridView2.Refresh();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvRow in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.Remove(dgvRow);
                dataGridView1.Rows.Add(dgvRow);
                dataGridView1.Refresh();
                dataGridView2.Refresh();
            }
        }
    }
}

