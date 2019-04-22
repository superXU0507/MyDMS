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
    public partial class manage : Form
    {
        private IList<Remain> WitchToUpdate = new List<Remain>();
        private IList<String> WhatToInKu = new List<String>();

        public manage()
        {
            InitializeComponent();
            initalData();
        }

        private void initalData()
        {
            Memange_service myservice = new Memange_service();
            InKu_service inservice = new InKu_service();
            Outku_service outservice = new Outku_service();
            IList<Remain> remainlist = myservice.getAllRemainInfos();
            IList<InKu> inkulist = inservice.getAllInkus();
            IList<Outku> outkulist = outservice.getAllOutkus();
            this.dataGridView1.Rows.Clear();
            this.inku_datagridview.Rows.Clear();
            this.dataGridView2.Rows.Clear();

            for (int i = 0; i < remainlist.Count; i++)
            {
                Remain remain = remainlist[i];
                String[] row = { remain.Cangkuname, remain.Productname, remain.Remainnum.ToString() };
                this.dataGridView1.Rows.Add(row);
            }

            for (int j = 0; j < inkulist.Count; j++)
            {
                InKu inku = inkulist[j];
                String[] row1 = { inku.In_id, inku.Pro_id, inku.In_time, inku.Cangku_id, inku.In_num.ToString() };
                this.inku_datagridview.Rows.Add(row1);
            }


            for (int k = 0; k < outkulist.Count; k++)
            {
                Outku outku = outkulist[k];
                String[] row2 = { outku.Out_id, outku.Pro_id, outku.Out_time, outku.Cangku_id, outku.Out_num.ToString() };
                this.dataGridView2.Rows.Add(row2);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Memange_service menageservice = new Memange_service();

            IList<Remain> list = menageservice.getAllRemainInfos();
            this.dataGridView1.Rows.Clear();



            for (int i = 0; i < list.Count; i++)
            {
                Remain remain = list[i];

                String[] row = { remain.Cangkuname, remain.Productname, remain.Remainnum.ToString() };

                this.dataGridView1.Rows.Add(row);


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //添加库存情况
        private void add_kucun_Click(object sender, EventArgs e)
        {
            Form addremains = new AddRemain();

            addremains.Show();
        }

        private void delete_kucun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "确定删除吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IList<String> pro_ids = new List<String>();
                Memange_service service = new Memange_service();
                int count = this.dataGridView1.SelectedRows.Count;
                for (int i = 0; i < count; i++)
                {
                    if (this.dataGridView1.SelectedRows[i].Cells[1].Value != null)
                    {
                        String name = this.dataGridView1.SelectedRows[i].Cells[1].Value.ToString();
                        Console.WriteLine(name);
                        String id = service.getProIdByName(name);
                        Console.WriteLine(id);
                        pro_ids.Add(id);
                    }
                }

                int result = service.deleteRemain(pro_ids);

                if (result != 0)
                {
                    MessageBox.Show("删除成功!");
                    initalData();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }


        //修改。。。。
        private void update_kucun_Click(object sender, EventArgs e)
        {
            Memange_service service = new Memange_service();
            int count = WitchToUpdate.Count;
            IList<String> errorList = new List<String>();
            for (int i = 0; i < count; i++)
            {
                String id = service.getProIdByName(WitchToUpdate[0].Productname);
                Remain remain = new Remain();

                remain.Productname = id;
                remain.Remainnum = WitchToUpdate[0].Remainnum;
                remain.Cangkuname = WitchToUpdate[0].Cangkuname;
                int result = service.updateRemain(remain);
                WitchToUpdate.RemoveAt(0);

                if (result == 0)
                {
                    errorList.Add(WitchToUpdate[i].Productname);
                }
            }


            if (errorList.Count != 0)
            {

                String note = "";
                for (int j = 0; j < errorList.Count; j++)
                {
                    note += errorList[j] + "修改失败!\n";
                }
                MessageBox.Show(note);

            }
            else
            {
                MessageBox.Show("修改成功！");
                initalData();
            }
        }


        //查询。。。
        private void button1_Click(object sender, EventArgs e)
        {
            String cangku_id = this.cangku_id_text.Text;
            String product_id = this.pro_id_text.Text;
            IList<Remain> remains = null;
            Memange_service service = new Memange_service();
            if (product_id.Length != 0 && cangku_id.Length != 0)//11
            {
                String sql = "select * from remain_state where cangku_id='" + cangku_id + "' and product_id='" + product_id + "'";
                remains = service.getRemains(sql);

            }
            else if (product_id.Length != 0 && cangku_id.Length == 0)//10
            {
                String sql = "select * from remain_state where  product_id='" + product_id + "'";
                remains = service.getRemains(sql);
            }
            else if (product_id.Length == 0 && cangku_id.Length != 0)//01
            {
                String sql = "select * from remain_state where cangku_id='" + cangku_id + "'";
                remains = service.getRemains(sql);
            }
            else//00
            {
                MessageBox.Show("请选择查询方式！");
            }


            if (remains != null)
            {
                this.dataGridView1.Rows.Clear();
                for (int i = 0; i < remains.Count; i++)
                {
                    Remain remain = remains[i];
                    String[] row = { remain.Cangkuname, remain.Productname, remain.Remainnum.ToString() };

                    this.dataGridView1.Rows.Add(row);

                }
            }

        }

        private void dataGridView1_CellValueChanged(
        object sender, DataGridViewCellEventArgs e)
        {

            Console.WriteLine(e.RowIndex + "--------" + e.ColumnIndex);
            Remain remain = new Remain();

            if (e.RowIndex >= 0)
            {
                remain.Cangkuname = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                remain.Productname = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                remain.Remainnum = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                WitchToUpdate.Add(remain);
            }
        }
        //添加入库
        private void add_in_Click(object sender, EventArgs e)
        {
            Product_service pro_ser = new Product_service();
            Memange_service me_ser = new Memange_service();
            InKu_service in_ser = new InKu_service();

            IList<InKu> WhatToInKus = new List<InKu>();
            //添加之前先检查库存是否有这种产品，要是没有，就添加，同时插入产品表，以及库存表，要是没有，添加，然后修改库存表
            for (int i = 0; i < WhatToInKu.Count / 3; i++)
            {
                InKu inku = new InKu();
                // inku.In_id = WhatToInKu[3 * i + 0];
                //获取产品ID
                String id = pro_ser.getIdByName(WhatToInKu[3 * i + 0]);
                if (id.Length == 0)
                {
                    //插入产品及库存

                    pro_ser.addProduct(WhatToInKu[3 * i + 0]);

                    Remain remain = new Remain();
                    remain.Cangkuname = WhatToInKu[3 * i + 1];
                    remain.Remainnum = Convert.ToInt32(WhatToInKu[3 * i + 2]);
                    remain.Productname = pro_ser.getIdByName(WhatToInKu[3 * i + 0]);
                    int k = me_ser.addRemain(remain);//插入库存表

                    Console.WriteLine(k + "[][][][][][][]");

                }
                else
                {
                    //修改库存表

                    Remain remain = new Remain();
                    remain.Cangkuname = WhatToInKu[3 * i + 1];
                    remain.Remainnum = Convert.ToInt32(WhatToInKu[3 * i + 2]) + me_ser.getRemainNum(pro_ser.getIdByName(WhatToInKu[3 * i + 0]));
                    remain.Productname = pro_ser.getIdByName(WhatToInKu[3 * i + 0]);
                    me_ser.updateRemain(remain);
                }
                inku.Pro_id = pro_ser.getIdByName(WhatToInKu[3 * i + 0]);
                inku.In_time = DateTime.Now.Date.ToShortDateString();
                inku.Cangku_id = WhatToInKu[3 * i + 1];
                inku.In_num = Convert.ToInt32(WhatToInKu[3 * i + 2]);
                WhatToInKus.Add(inku);
            }

            int result = in_ser.addKu(WhatToInKus);

            if (result != 0)
            {
                MessageBox.Show("添加成功！");
                initalData();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
            int count = WhatToInKu.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                WhatToInKu.RemoveAt(i);
            }

        }
        private void inku_datagridview_CellValueChanged(
        object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.RowIndex + "----------------" + e.ColumnIndex + "-------" + DateTime.Now.AddDays(0).ToString("yyyy-MM-dd"));

            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                // inku.In_id = this.inku_datagridview.Rows[rowindex].Cells[0].Value.ToString();
                WhatToInKu.Add(this.inku_datagridview.Rows[rowindex].Cells[e.ColumnIndex].Value.ToString());
                Console.WriteLine(this.inku_datagridview.Rows[rowindex].Cells[e.ColumnIndex].Value.ToString());
            }
        }
        //显示所有
        private void button5_Click(object sender, EventArgs e)
        {
            InKu_service in_ser = new InKu_service();
            IList<InKu> list = in_ser.getAllInkus();
            this.inku_datagridview.Rows.Clear();
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                InKu inku = list[i];

                String[] row = { inku.In_id, inku.Pro_id, inku.In_time, inku.Cangku_id, inku.In_num.ToString() };
                this.inku_datagridview.Rows.Add(row);
            }


        }
        //查询
        private void search_in_Click(object sender, EventArgs e)
        {
            InKu_service in_ser = new InKu_service();
            String cangkuid = this.textBox3.Text;
            IList<InKu> list = in_ser.getInkusByCangkuid(cangkuid);
            this.inku_datagridview.Rows.Clear();

            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                InKu inku = list[i];

                String[] row = { inku.In_id, inku.Pro_id, inku.In_time, inku.Cangku_id, inku.In_num.ToString() };
                this.inku_datagridview.Rows.Add(row);
            }
        }

        private void delete_in_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "确定删除吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IList<String> in_id = new List<String>();
                InKu_service service = new InKu_service();
                int count = this.inku_datagridview.SelectedRows.Count;
                for (int i = 0; i < count; i++)
                {
                    if (this.inku_datagridview.SelectedRows[i].Cells[0].Value != null)
                    {
                        String id = this.inku_datagridview.SelectedRows[i].Cells[0].Value.ToString();
                        Console.WriteLine(id);

                        in_id.Add(id);
                    }
                }

                int result = service.deleteById(in_id);

                if (result != 0)
                {
                    MessageBox.Show("删除成功!");
                    initalData();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        private void inku_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Product_service pro_ser = new Product_service();
            Memange_service me_ser = new Memange_service();
            Outku_service out_ser = new Outku_service();

            IList<Outku> WhatToInKus = new List<Outku>();
            // 出库之前先检查库存是否有这种产品，要是没有，出库失败，要是有，添加出库单，然后修改库存表
            for (int i = 0; i < WhatToInKu.Count / 3; i++)
            {
                Outku outku = new Outku();
                // inku.In_id = WhatToInKu[3 * i + 0];
                //获取产品ID
                String id = pro_ser.getIdByName(WhatToInKu[3 * i + 0]);

                if (id.Length == 0)
                {
                    //插入产品及库存

                    MessageBox.Show("仓库中不存在" + WhatToInKu[3 * i + 0]);
                    return;

                }
                else
                {
                    //修改库存表

                    Remain remain = new Remain();
                    remain.Cangkuname = WhatToInKu[3 * i + 1];
                    Console.WriteLine(me_ser.getRemainNum(pro_ser.getIdByName(WhatToInKu[3 * i + 0])));
                    Console.WriteLine(Convert.ToInt32(WhatToInKu[3 * i + 2]));

                    remain.Remainnum = me_ser.getRemainNum(pro_ser.getIdByName(WhatToInKu[3 * i + 0])) - Convert.ToInt32(WhatToInKu[3 * i + 2]);
                    Console.WriteLine(remain.Remainnum);
                    remain.Productname = pro_ser.getIdByName(WhatToInKu[3 * i + 0]);
                    me_ser.updateRemain(remain);
                }
                outku.Pro_id = pro_ser.getIdByName(WhatToInKu[3 * i + 0]);
                outku.Out_time = DateTime.Now.Date.ToShortDateString();
                outku.Cangku_id = WhatToInKu[3 * i + 1];
                outku.Out_num = Convert.ToInt32(WhatToInKu[3 * i + 2]);
                WhatToInKus.Add(outku);
            }

            int result = out_ser.outKu(WhatToInKus);

            if (result != 0)
            {
                MessageBox.Show("出库成功！");
                initalData();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
            int count = WhatToInKu.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                WhatToInKu.RemoveAt(i);
            }
        }

        private void dataGridView2_CellValueChanged(
       object sender, DataGridViewCellEventArgs e)
        {

            Console.WriteLine(e.RowIndex + "----------------" + e.ColumnIndex + "-------" + DateTime.Now.AddDays(0).ToString("yyyy-MM-dd"));

            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                // inku.In_id = this.inku_datagridview.Rows[rowindex].Cells[0].Value.ToString();
                WhatToInKu.Add(this.dataGridView2.Rows[rowindex].Cells[e.ColumnIndex].Value.ToString());
                Console.WriteLine(this.dataGridView2.Rows[rowindex].Cells[e.ColumnIndex].Value.ToString());
            }
        }
        //显示所有的出库单内容
        private void button7_Click(object sender, EventArgs e)
        {
            Outku_service out_ser = new Outku_service();
            IList<Outku> list = out_ser.getAllOutkus();
            this.dataGridView2.Rows.Clear();
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                Outku outku = list[i];

                String[] row = { outku.Out_id, outku.Pro_id, outku.Out_time, outku.Cangku_id, outku.Out_num.ToString() };
                this.dataGridView2.Rows.Add(row);
            }

        }
        //按仓库号查询
        private void button8_Click(object sender, EventArgs e)
        {
            Outku_service out_ser = new Outku_service();
            String cangkuid = this.textBox4.Text;
            IList<Outku> list = out_ser.getOutkusByCangkuid(cangkuid);
            this.dataGridView2.Rows.Clear();

            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                Outku outku = list[i];

                String[] row = { outku.Out_id, outku.Pro_id, outku.Out_time, outku.Cangku_id, outku.Out_num.ToString() };
                this.dataGridView2.Rows.Add(row);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "确定删除吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IList<String> in_id = new List<String>();
                Outku_service service = new Outku_service();
                int count = this.dataGridView2.SelectedRows.Count;
                for (int i = 0; i < count; i++)
                {
                    if (this.dataGridView2.SelectedRows[i].Cells[0].Value != null)
                    {
                        String id = this.dataGridView2.SelectedRows[i].Cells[0].Value.ToString();
                        Console.WriteLine(id);

                        in_id.Add(id);
                    }
                }

                int result = service.deleteById(in_id);

                if (result != 0)
                {
                    MessageBox.Show("删除成功!");
                    initalData();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Print print = new Print();
            String fname = "库存信息.xls";
            print.printDataGridView(fname, dataGridView1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Print print = new Print();
            String fname = "入库信息.xls";
            print.printDataGridView(fname, inku_datagridview);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Print print = new Print();
            String fname = "出库信息.xls";
            print.printDataGridView(fname, dataGridView2);
        }
    }
}