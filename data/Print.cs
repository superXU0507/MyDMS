using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 入库出库管理系统.data
{
    class Print
    {
        public void printDataGridView(string fname,DataGridView dataGridView1)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "excel文件|*.xls";
            sf.FileName = fname;
            if (sf.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = File.Open(sf.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("gb2312"));
                string line = "";
                foreach (DataGridViewColumn dvc in dataGridView1.Columns)
                {
                    line += dvc.Name + "\t";
                }
                sw.WriteLine(line);
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    line = "";
                    foreach (DataGridViewCell dc in dr.Cells)
                    {
                        line += dc.Value + "\t";
                    }
                    sw.WriteLine(line);
                }
                sw.Close();
                fs.Close();
                MessageBox.Show("导出成功！", "提示");
            } 
        }
    }
}
