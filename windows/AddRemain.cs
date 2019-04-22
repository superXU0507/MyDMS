using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 入库出库管理系统.entities;
using 入库出库管理系统.data;

namespace 入库出库管理系统.windows
{
    public partial class AddRemain : Form
    {
        public AddRemain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = this.dataGridView1.Rows.Count;
            IList<Remain> remains = new List<Remain>();
            for (int i = 0; i < count - 1; i++)
            {
                Remain remain = new Remain();
                Console.WriteLine(i);
                remain.Cangkuname = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                remain.Productname = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                remain.Remainnum = Convert.ToInt32(this.dataGridView1.Rows[i].Cells[2].Value.ToString());

                remains.Add(remain);
            }

            Memange_service myservice = new Memange_service();

            int result = myservice.addRemain(remains);
            this.Close();
            if (result != 0)
            {
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败，请检查原因！");
            }
        }
    }
}
