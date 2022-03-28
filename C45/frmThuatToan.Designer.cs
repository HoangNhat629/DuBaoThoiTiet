
namespace C45
{
    partial class frmThuatToan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuatToan));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_KiemTra = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_HuanLuyen = new System.Windows.Forms.DataGridView();
            this.gbInputData = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chuyểnHuấnLuyệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnKiểmTraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_TabHuanLuyen = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_KiemThudulieu = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnDuBao = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lb_tt = new System.Windows.Forms.Label();
            this.pic_weather = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cboDoAm = new System.Windows.Forms.ComboBox();
            this.cboNhietDo = new System.Windows.Forms.ComboBox();
            this.rb_may_3 = new System.Windows.Forms.RadioButton();
            this.rb_may_2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_may_1 = new System.Windows.Forms.RadioButton();
            this.rb_may_0 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KiemTra)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HuanLuyen)).BeginInit();
            this.gbInputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabHuanLuyen)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KiemThudulieu)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_weather)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(990, 430);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gbInputData);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(916, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Xử lý dữ liệu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_KiemTra);
            this.groupBox3.Location = new System.Drawing.Point(638, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 309);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dữ liệu kiểm tra";
            // 
            // dgv_KiemTra
            // 
            this.dgv_KiemTra.AllowUserToAddRows = false;
            this.dgv_KiemTra.AllowUserToDeleteRows = false;
            this.dgv_KiemTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KiemTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_KiemTra.Location = new System.Drawing.Point(3, 16);
            this.dgv_KiemTra.Name = "dgv_KiemTra";
            this.dgv_KiemTra.ReadOnly = true;
            this.dgv_KiemTra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KiemTra.Size = new System.Drawing.Size(278, 290);
            this.dgv_KiemTra.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_HuanLuyen);
            this.groupBox1.Location = new System.Drawing.Point(323, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 309);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ liệu huấn luyện";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgv_HuanLuyen
            // 
            this.dgv_HuanLuyen.AllowUserToAddRows = false;
            this.dgv_HuanLuyen.AllowUserToDeleteRows = false;
            this.dgv_HuanLuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HuanLuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HuanLuyen.Location = new System.Drawing.Point(3, 16);
            this.dgv_HuanLuyen.Name = "dgv_HuanLuyen";
            this.dgv_HuanLuyen.ReadOnly = true;
            this.dgv_HuanLuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HuanLuyen.Size = new System.Drawing.Size(278, 290);
            this.dgv_HuanLuyen.TabIndex = 1;
            // 
            // gbInputData
            // 
            this.gbInputData.Controls.Add(this.dataGridView1);
            this.gbInputData.Location = new System.Drawing.Point(8, 16);
            this.gbInputData.Name = "gbInputData";
            this.gbInputData.Size = new System.Drawing.Size(284, 309);
            this.gbInputData.TabIndex = 26;
            this.gbInputData.TabStop = false;
            this.gbInputData.Text = "Dữ liệu vào";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(278, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chuyểnHuấnLuyệnToolStripMenuItem,
            this.chuyểnKiểmTraToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // chuyểnHuấnLuyệnToolStripMenuItem
            // 
            this.chuyểnHuấnLuyệnToolStripMenuItem.Name = "chuyểnHuấnLuyệnToolStripMenuItem";
            this.chuyểnHuấnLuyệnToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.chuyểnHuấnLuyệnToolStripMenuItem.Text = "Chuyển huấn luyện";
            this.chuyểnHuấnLuyệnToolStripMenuItem.Click += new System.EventHandler(this.chuyểnHuấnLuyệnToolStripMenuItem_Click);
            // 
            // chuyểnKiểmTraToolStripMenuItem
            // 
            this.chuyểnKiểmTraToolStripMenuItem.Name = "chuyểnKiểmTraToolStripMenuItem";
            this.chuyểnKiểmTraToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.chuyểnKiểmTraToolStripMenuItem.Text = "Chuyển kiểm tra";
            this.chuyểnKiểmTraToolStripMenuItem.Click += new System.EventHandler(this.chuyểnKiểmTraToolStripMenuItem_Click);
            // 
            // button11
            // 
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.ImageIndex = 2;
            this.button11.Location = new System.Drawing.Point(360, 331);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(117, 41);
            this.button11.TabIndex = 24;
            this.button11.Text = "Thoát";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button9
            // 
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.ImageIndex = 0;
            this.button9.Location = new System.Drawing.Point(6, 331);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(144, 41);
            this.button9.TabIndex = 23;
            this.button9.Text = "Chọn file dữ liệu";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(982, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Huấn luyện";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.Location = new System.Drawing.Point(858, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 46);
            this.button1.TabIndex = 29;
            this.button1.Text = "Huấn luyện";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_TabHuanLuyen);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 370);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu huấn luyện";
            // 
            // dgv_TabHuanLuyen
            // 
            this.dgv_TabHuanLuyen.AllowUserToAddRows = false;
            this.dgv_TabHuanLuyen.AllowUserToDeleteRows = false;
            this.dgv_TabHuanLuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TabHuanLuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TabHuanLuyen.Location = new System.Drawing.Point(3, 16);
            this.dgv_TabHuanLuyen.Name = "dgv_TabHuanLuyen";
            this.dgv_TabHuanLuyen.ReadOnly = true;
            this.dgv_TabHuanLuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TabHuanLuyen.Size = new System.Drawing.Size(840, 351);
            this.dgv_TabHuanLuyen.TabIndex = 1;
            this.dgv_TabHuanLuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TabHuanLuyen_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(982, 404);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kiểm thử dữ liệu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 0;
            this.button2.Location = new System.Drawing.Point(840, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 30;
            this.button2.Text = "Kiểm thử";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_KiemThudulieu);
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(829, 370);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dữ liệu kiểm tra";
            // 
            // dgv_KiemThudulieu
            // 
            this.dgv_KiemThudulieu.AllowUserToAddRows = false;
            this.dgv_KiemThudulieu.AllowUserToDeleteRows = false;
            this.dgv_KiemThudulieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KiemThudulieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_KiemThudulieu.Location = new System.Drawing.Point(3, 16);
            this.dgv_KiemThudulieu.Name = "dgv_KiemThudulieu";
            this.dgv_KiemThudulieu.ReadOnly = true;
            this.dgv_KiemThudulieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KiemThudulieu.Size = new System.Drawing.Size(823, 351);
            this.dgv_KiemThudulieu.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnDuBao);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(982, 404);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dự đoán";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // btnDuBao
            // 
            this.btnDuBao.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuBao.Location = new System.Drawing.Point(450, 154);
            this.btnDuBao.Name = "btnDuBao";
            this.btnDuBao.Size = new System.Drawing.Size(90, 32);
            this.btnDuBao.TabIndex = 27;
            this.btnDuBao.Text = "Dự báo";
            this.btnDuBao.UseVisualStyleBackColor = true;
            this.btnDuBao.Click += new System.EventHandler(this.btnDuBao_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.lb_tt);
            this.groupBox5.Controls.Add(this.pic_weather);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Blue;
            this.groupBox5.Location = new System.Drawing.Point(567, 143);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 229);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thời tiết hôm nay";
            // 
            // lb_tt
            // 
            this.lb_tt.AutoSize = true;
            this.lb_tt.BackColor = System.Drawing.Color.White;
            this.lb_tt.ForeColor = System.Drawing.Color.Black;
            this.lb_tt.Location = new System.Drawing.Point(18, 200);
            this.lb_tt.Name = "lb_tt";
            this.lb_tt.Size = new System.Drawing.Size(0, 17);
            this.lb_tt.TabIndex = 0;
            // 
            // pic_weather
            // 
            this.pic_weather.BackColor = System.Drawing.Color.White;
            this.pic_weather.ForeColor = System.Drawing.Color.Black;
            this.pic_weather.Location = new System.Drawing.Point(21, 33);
            this.pic_weather.Name = "pic_weather";
            this.pic_weather.Size = new System.Drawing.Size(277, 146);
            this.pic_weather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_weather.TabIndex = 0;
            this.pic_weather.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.cboDoAm);
            this.groupBox6.Controls.Add(this.cboNhietDo);
            this.groupBox6.Controls.Add(this.rb_may_3);
            this.groupBox6.Controls.Add(this.rb_may_2);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.rb_may_1);
            this.groupBox6.Controls.Add(this.rb_may_0);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox6.Location = new System.Drawing.Point(61, 143);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(368, 229);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nhiệt độ(*C) :";
            // 
            // cboDoAm
            // 
            this.cboDoAm.FormattingEnabled = true;
            this.cboDoAm.Items.AddRange(new object[] {
            "0.25",
            "0.28",
            "0.3",
            "0.31",
            "0.32",
            "0.33",
            "0.34",
            "0.35",
            "0.36",
            "0.38",
            "0.39",
            "0.4",
            "0.41",
            "0.43",
            "0.44",
            "0.45",
            "0.46",
            "0.47",
            "0.49",
            "0.51",
            "0.52",
            "0.53",
            "0.55",
            "0.56",
            "0.58",
            "0.59",
            "0.62",
            "0.63",
            "0.66",
            "0.67",
            "0.7",
            "0.71",
            "0.74",
            "0.75",
            "0.79",
            "0.83",
            "0.84",
            "0.89",
            "0.94",
            "1"});
            this.cboDoAm.Location = new System.Drawing.Point(143, 88);
            this.cboDoAm.Name = "cboDoAm";
            this.cboDoAm.Size = new System.Drawing.Size(190, 25);
            this.cboDoAm.TabIndex = 31;
            this.cboDoAm.SelectedIndexChanged += new System.EventHandler(this.cboDoAm_SelectedIndexChanged);
            // 
            // cboNhietDo
            // 
            this.cboNhietDo.FormattingEnabled = true;
            this.cboNhietDo.Items.AddRange(new object[] {
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37"});
            this.cboNhietDo.Location = new System.Drawing.Point(143, 41);
            this.cboNhietDo.Name = "cboNhietDo";
            this.cboNhietDo.Size = new System.Drawing.Size(190, 25);
            this.cboNhietDo.TabIndex = 30;
            // 
            // rb_may_3
            // 
            this.rb_may_3.AutoSize = true;
            this.rb_may_3.BackColor = System.Drawing.Color.White;
            this.rb_may_3.ForeColor = System.Drawing.Color.Black;
            this.rb_may_3.Location = new System.Drawing.Point(273, 145);
            this.rb_may_3.Name = "rb_may_3";
            this.rb_may_3.Size = new System.Drawing.Size(54, 21);
            this.rb_may_3.TabIndex = 29;
            this.rb_may_3.TabStop = true;
            this.rb_may_3.Tag = "Mua";
            this.rb_may_3.Text = "Mưa";
            this.rb_may_3.UseVisualStyleBackColor = false;
            this.rb_may_3.CheckedChanged += new System.EventHandler(this.rb_may_0_CheckedChanged);
            // 
            // rb_may_2
            // 
            this.rb_may_2.AutoSize = true;
            this.rb_may_2.BackColor = System.Drawing.Color.White;
            this.rb_may_2.ForeColor = System.Drawing.Color.Black;
            this.rb_may_2.Location = new System.Drawing.Point(143, 145);
            this.rb_may_2.Name = "rb_may_2";
            this.rb_may_2.Size = new System.Drawing.Size(111, 21);
            this.rb_may_2.TabIndex = 28;
            this.rb_may_2.TabStop = true;
            this.rb_may_2.Tag = "May mot phan";
            this.rb_may_2.Text = "Mây một phần";
            this.rb_may_2.UseVisualStyleBackColor = false;
            this.rb_may_2.CheckedChanged += new System.EventHandler(this.rb_may_0_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Độ ẩm(%) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhiệt độ(*C) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mây";
            // 
            // rb_may_1
            // 
            this.rb_may_1.AutoSize = true;
            this.rb_may_1.BackColor = System.Drawing.Color.White;
            this.rb_may_1.ForeColor = System.Drawing.Color.Black;
            this.rb_may_1.Location = new System.Drawing.Point(273, 118);
            this.rb_may_1.Name = "rb_may_1";
            this.rb_may_1.Size = new System.Drawing.Size(64, 21);
            this.rb_may_1.TabIndex = 4;
            this.rb_may_1.TabStop = true;
            this.rb_may_1.Tag = "It may";
            this.rb_may_1.Text = "Ít mây";
            this.rb_may_1.UseVisualStyleBackColor = false;
            this.rb_may_1.CheckedChanged += new System.EventHandler(this.rb_may_0_CheckedChanged);
            // 
            // rb_may_0
            // 
            this.rb_may_0.AutoSize = true;
            this.rb_may_0.BackColor = System.Drawing.Color.White;
            this.rb_may_0.ForeColor = System.Drawing.Color.Black;
            this.rb_may_0.Location = new System.Drawing.Point(143, 118);
            this.rb_may_0.Name = "rb_may_0";
            this.rb_may_0.Size = new System.Drawing.Size(72, 21);
            this.rb_may_0.TabIndex = 3;
            this.rb_may_0.TabStop = true;
            this.rb_may_0.Tag = "Co may";
            this.rb_may_0.Text = "Có mây";
            this.rb_may_0.UseVisualStyleBackColor = false;
            this.rb_may_0.CheckedChanged += new System.EventHandler(this.rb_may_0_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ForeColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(976, 130);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // frmThuatToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 430);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmThuatToan";
            this.Text = "DỰ BÁO THỜI TIẾT";
            this.Load += new System.EventHandler(this.frmThuatToan_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KiemTra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HuanLuyen)).EndInit();
            this.gbInputData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabHuanLuyen)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KiemThudulieu)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_weather)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbInputData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgv_KiemTra;
        private System.Windows.Forms.DataGridView dgv_HuanLuyen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chuyểnHuấnLuyệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnKiểmTraToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_TabHuanLuyen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_KiemThudulieu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnDuBao;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lb_tt;
        private System.Windows.Forms.PictureBox pic_weather;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rb_may_3;
        private System.Windows.Forms.RadioButton rb_may_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_may_1;
        private System.Windows.Forms.RadioButton rb_may_0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboDoAm;
        private System.Windows.Forms.ComboBox cboNhietDo;
    }
}