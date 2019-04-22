using System.Windows.Forms;
namespace 入库出库管理系统.windows
{
    partial class manage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.out_menage = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.search_in = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.delete_in = new System.Windows.Forms.Button();
            this.add_in = new System.Windows.Forms.Button();
            this.inku_datagridview = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pro_id_text = new System.Windows.Forms.TextBox();
            this.cangku_id_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.update_kucun = new System.Windows.Forms.Button();
            this.delete_kucun = new System.Windows.Forms.Button();
            this.add_kucun = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button4 = new System.Windows.Forms.Button();
            this.仓库 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产品 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.库存 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.入库单号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入库产品 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入库时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入库仓库 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入库数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出库单号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出库产品 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出库时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出库仓库 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出库数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.out_menage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inku_datagridview)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // out_menage
            // 
            this.out_menage.Controls.Add(this.button13);
            this.out_menage.Controls.Add(this.button12);
            this.out_menage.Controls.Add(this.button10);
            this.out_menage.Controls.Add(this.button9);
            this.out_menage.Controls.Add(this.button8);
            this.out_menage.Controls.Add(this.button7);
            this.out_menage.Controls.Add(this.label4);
            this.out_menage.Controls.Add(this.textBox4);
            this.out_menage.Controls.Add(this.dataGridView2);
            this.out_menage.Location = new System.Drawing.Point(4, 22);
            this.out_menage.Name = "out_menage";
            this.out_menage.Padding = new System.Windows.Forms.Padding(3);
            this.out_menage.Size = new System.Drawing.Size(951, 408);
            this.out_menage.TabIndex = 1;
            this.out_menage.Text = "出库管理 ";
            this.out_menage.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(810, 290);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(89, 37);
            this.button12.TabIndex = 9;
            this.button12.Text = "退出";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(347, 349);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 37);
            this.button10.TabIndex = 7;
            this.button10.Text = "删除";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(134, 349);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 37);
            this.button9.TabIndex = 6;
            this.button9.Text = "出库";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(810, 172);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 37);
            this.button8.TabIndex = 5;
            this.button8.Text = "查询";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(810, 230);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 37);
            this.button7.TabIndex = 4;
            this.button7.Text = "全部显示";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(808, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "按仓库号查询";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(810, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.出库单号,
            this.出库产品,
            this.出库时间,
            this.出库仓库,
            this.出库数量});
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(751, 327);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(951, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "入库管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.search_in);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.delete_in);
            this.panel2.Controls.Add(this.add_in);
            this.panel2.Controls.Add(this.inku_datagridview);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 412);
            this.panel2.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(819, 296);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 37);
            this.button6.TabIndex = 9;
            this.button6.Text = "退出";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(819, 211);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 37);
            this.button5.TabIndex = 8;
            this.button5.Text = "全部显示";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // search_in
            // 
            this.search_in.Location = new System.Drawing.Point(819, 153);
            this.search_in.Name = "search_in";
            this.search_in.Size = new System.Drawing.Size(89, 37);
            this.search_in.TabIndex = 7;
            this.search_in.Text = "查询";
            this.search_in.UseVisualStyleBackColor = true;
            this.search_in.Click += new System.EventHandler(this.search_in_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(819, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(817, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "按仓库号查询";
            // 
            // delete_in
            // 
            this.delete_in.Location = new System.Drawing.Point(342, 353);
            this.delete_in.Name = "delete_in";
            this.delete_in.Size = new System.Drawing.Size(89, 37);
            this.delete_in.TabIndex = 2;
            this.delete_in.Text = "删除";
            this.delete_in.UseVisualStyleBackColor = true;
            this.delete_in.Click += new System.EventHandler(this.delete_in_Click);
            // 
            // add_in
            // 
            this.add_in.Location = new System.Drawing.Point(149, 353);
            this.add_in.Name = "add_in";
            this.add_in.Size = new System.Drawing.Size(89, 37);
            this.add_in.TabIndex = 1;
            this.add_in.Text = "入库";
            this.add_in.UseVisualStyleBackColor = true;
            this.add_in.Click += new System.EventHandler(this.add_in_Click);
            // 
            // inku_datagridview
            // 
            this.inku_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inku_datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.入库单号,
            this.入库产品,
            this.入库时间,
            this.入库仓库,
            this.入库数量});
            this.inku_datagridview.Location = new System.Drawing.Point(0, 0);
            this.inku_datagridview.Name = "inku_datagridview";
            this.inku_datagridview.RowTemplate.Height = 23;
            this.inku_datagridview.Size = new System.Drawing.Size(751, 327);
            this.inku_datagridview.TabIndex = 0;
            this.inku_datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inku_datagridview_CellContentClick);
            this.inku_datagridview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.inku_datagridview_CellValueChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.pro_id_text);
            this.tabPage1.Controls.Add(this.cangku_id_text);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(951, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "库存情况管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(807, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "退出";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(807, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "全部显示";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(807, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pro_id_text
            // 
            this.pro_id_text.Location = new System.Drawing.Point(803, 125);
            this.pro_id_text.Name = "pro_id_text";
            this.pro_id_text.Size = new System.Drawing.Size(100, 21);
            this.pro_id_text.TabIndex = 4;
            // 
            // cangku_id_text
            // 
            this.cangku_id_text.Location = new System.Drawing.Point(803, 53);
            this.cangku_id_text.Name = "cangku_id_text";
            this.cangku_id_text.Size = new System.Drawing.Size(100, 21);
            this.cangku_id_text.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(801, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "按产品编号查询";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(801, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "按仓库号查询";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.update_kucun);
            this.panel1.Controls.Add(this.delete_kucun);
            this.panel1.Controls.Add(this.add_kucun);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 399);
            this.panel1.TabIndex = 0;
            // 
            // update_kucun
            // 
            this.update_kucun.Location = new System.Drawing.Point(409, 350);
            this.update_kucun.Name = "update_kucun";
            this.update_kucun.Size = new System.Drawing.Size(89, 37);
            this.update_kucun.TabIndex = 3;
            this.update_kucun.Text = "修改";
            this.update_kucun.UseVisualStyleBackColor = true;
            this.update_kucun.Click += new System.EventHandler(this.update_kucun_Click);
            // 
            // delete_kucun
            // 
            this.delete_kucun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delete_kucun.Location = new System.Drawing.Point(244, 350);
            this.delete_kucun.Name = "delete_kucun";
            this.delete_kucun.Size = new System.Drawing.Size(89, 37);
            this.delete_kucun.TabIndex = 2;
            this.delete_kucun.Text = "删除";
            this.delete_kucun.UseVisualStyleBackColor = true;
            this.delete_kucun.Click += new System.EventHandler(this.delete_kucun_Click);
            // 
            // add_kucun
            // 
            this.add_kucun.Location = new System.Drawing.Point(89, 350);
            this.add_kucun.Name = "add_kucun";
            this.add_kucun.Size = new System.Drawing.Size(89, 37);
            this.add_kucun.TabIndex = 1;
            this.add_kucun.Text = "添加";
            this.add_kucun.UseVisualStyleBackColor = true;
            this.add_kucun.Click += new System.EventHandler(this.add_kucun_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.仓库,
            this.产品,
            this.库存});
            this.dataGridView1.Location = new System.Drawing.Point(-6, -6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(751, 327);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.out_menage);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(959, 434);
            this.tabControl1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(581, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "导出Excel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // 仓库
            // 
            this.仓库.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.仓库.HeaderText = "仓库";
            this.仓库.Name = "仓库";
            this.仓库.ReadOnly = true;
            // 
            // 产品
            // 
            this.产品.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.产品.HeaderText = "产品";
            this.产品.Name = "产品";
            this.产品.ReadOnly = true;
            // 
            // 库存
            // 
            this.库存.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.库存.HeaderText = "库存";
            this.库存.Name = "库存";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(550, 353);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(89, 37);
            this.button11.TabIndex = 10;
            this.button11.Text = "导出Excel";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(556, 349);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(89, 37);
            this.button13.TabIndex = 11;
            this.button13.Text = "导出Excel";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // 入库单号
            // 
            this.入库单号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.入库单号.HeaderText = "入库单号";
            this.入库单号.Name = "入库单号";
            this.入库单号.ReadOnly = true;
            // 
            // 入库产品
            // 
            this.入库产品.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.入库产品.HeaderText = "入库产品";
            this.入库产品.Name = "入库产品";
            // 
            // 入库时间
            // 
            this.入库时间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.入库时间.HeaderText = "入库时间";
            this.入库时间.Name = "入库时间";
            this.入库时间.ReadOnly = true;
            // 
            // 入库仓库
            // 
            this.入库仓库.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.入库仓库.HeaderText = "仓库";
            this.入库仓库.Name = "入库仓库";
            // 
            // 入库数量
            // 
            this.入库数量.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.入库数量.HeaderText = "入库数量";
            this.入库数量.Name = "入库数量";
            // 
            // 出库单号
            // 
            this.出库单号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.出库单号.HeaderText = "出库单号";
            this.出库单号.Name = "出库单号";
            this.出库单号.ReadOnly = true;
            // 
            // 出库产品
            // 
            this.出库产品.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.出库产品.HeaderText = "出库产品";
            this.出库产品.Name = "出库产品";
            // 
            // 出库时间
            // 
            this.出库时间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.出库时间.HeaderText = "出库时间";
            this.出库时间.Name = "出库时间";
            this.出库时间.ReadOnly = true;
            // 
            // 出库仓库
            // 
            this.出库仓库.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.出库仓库.HeaderText = "仓库";
            this.出库仓库.Name = "出库仓库";
            // 
            // 出库数量
            // 
            this.出库数量.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.出库数量.HeaderText = "出库数量";
            this.出库数量.Name = "出库数量";
            // 
            // manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 437);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "manage";
            this.Text = "入库出库管理";
            this.out_menage.ResumeLayout(false);
            this.out_menage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inku_datagridview)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage out_menage;
        private Button button12;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Label label4;
        private TextBox textBox4;
        private DataGridView dataGridView2;
        private TabPage tabPage2;
        private Panel panel2;
        private Button button6;
        private Button button5;
        private Button search_in;
        private TextBox textBox3;
        private Label label3;
        private Button delete_in;
        private Button add_in;
        private DataGridView inku_datagridview;
        private TabPage tabPage1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox pro_id_text;
        private TextBox cangku_id_text;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button update_kucun;
        private Button delete_kucun;
        private Button add_kucun;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private Button button4;
        private Button button13;
        private Button button11;
        private DataGridViewTextBoxColumn 仓库;
        private DataGridViewTextBoxColumn 产品;
        private DataGridViewTextBoxColumn 库存;
        private DataGridViewTextBoxColumn 出库单号;
        private DataGridViewTextBoxColumn 出库产品;
        private DataGridViewTextBoxColumn 出库时间;
        private DataGridViewTextBoxColumn 出库仓库;
        private DataGridViewTextBoxColumn 出库数量;
        private DataGridViewTextBoxColumn 入库单号;
        private DataGridViewTextBoxColumn 入库产品;
        private DataGridViewTextBoxColumn 入库时间;
        private DataGridViewTextBoxColumn 入库仓库;
        private DataGridViewTextBoxColumn 入库数量;

    }
}