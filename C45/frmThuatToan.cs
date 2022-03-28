using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C45
{
    public partial class frmThuatToan : Form
    {
        public frmThuatToan()
        {
            InitializeComponent();
        }

        private void frmThuatToan_Load(object sender, EventArgs e)
        {

        }
        DataTable dt = new DataTable();
        private void button9_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (openFileDialog1.FileName != string.Empty)
                {
                    StringBuilder result = new StringBuilder();
                    
                    int STT = 1;

                    // dt.Columns.Add(new DataColumn("ID"));
                    // dt.Columns.Add(new DataColumn("TXT_E"));
                    // dt.Columns.Add(new DataColumn("TXT_V"));
                    GetExcel(openFileDialog1.FileName);

                    dataGridView1.DataSource = dt;
                    dgv_HuanLuyen.DataSource = dtHuanLuyen;
                    dgv_KiemTra.DataSource = dtKiemTra;
                    MessageBox.Show("Xong!!!");
                }

            }
        }
        private DataTable GetDataTable(string sql, string connectionString)
        {
            

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    using (OleDbDataReader rdr = cmd.ExecuteReader())
                    {
                        dt.Load(rdr);
                        return dt;
                    }
                }
            }
        }
        DataTable dtHuanLuyen = new DataTable();
        DataTable dtKiemTra = new DataTable();
        string[] columnNames;
        string[] inputColumns ;
        string outputColumn;
        private void GetExcel(string pPath)
        {
            string fullPathToExcel = pPath; //ie C:\Temp\YourExcel.xls
            string connString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=yes'", fullPathToExcel);
            dt = GetDataTable("SELECT * from [Data$]", connString);
            DataColumn[] cls = new DataColumn[dt.Columns.Count];
            columnNames = new string[dt.Columns.Count];
            inputColumns=new string[dt.Columns.Count-1];
            outputColumn = dt.Columns[dt.Columns.Count - 1].ColumnName;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                cls[i] = dt.Columns[i];
                columnNames[i] = dt.Columns[i].ColumnName;
                dtKiemTra.Columns.Add(dt.Columns[i].ColumnName);
                dtHuanLuyen.Columns.Add(dt.Columns[i].ColumnName);
                if(i != dt.Columns.Count-1)
                {
                    inputColumns[i] = dt.Columns[i].ColumnName;
                }
                
            }
            
         //   dtKiemTra.Columns.AddRange(cls);
         //   dtHuanLuyen.Columns.AddRange(cls);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void chuyểnHuấnLuyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    DataRow row = dtHuanLuyen.NewRow();
                    // DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                    //dataGridView1.Rows[i].DataBoundItem;
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        row[j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                    dtHuanLuyen.Rows.Add(row);
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
        }

        private void chuyểnKiểmTraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i=dataGridView1.Rows.Count-1;i>=0;i--)
            {
                if(dataGridView1.Rows[i].Selected==true)
                {
                    DataRow row = dtKiemTra.NewRow();
                    // DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                    //dataGridView1.Rows[i].DataBoundItem;
                    for (int j = 0; j < dt.Columns.Count; j++)
                    { 
                        row[j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                    dtKiemTra.Rows.Add(row);
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TT");
        }

        DataTable dtKiemTraDuLieu = new DataTable();
        DataTable dtDuLieuDuBao= new DataTable();
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex==1)
            {
                dgv_TabHuanLuyen.DataSource = dtHuanLuyen;
            }
            if (tabControl1.SelectedIndex == 2)
            {
                try
                {
                    dtKiemTraDuLieu.Columns.Remove("C45");
                }
                catch
                {

                }
                dtKiemTraDuLieu = new DataTable();
                dtKiemTraDuLieu = dtKiemTra;
                dtKiemTraDuLieu.Columns.Add("C45");
                dgv_KiemThudulieu.DataSource = dtKiemTraDuLieu;
            }
            if (tabControl1.SelectedIndex == 3)
            {
                
            }
        }
        [Obsolete]
        C45_Learning dtC45= new C45_Learning();
        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {

            dtC45.ThuatToanC45(columnNames, dtHuanLuyen, inputColumns, outputColumn);

            MessageBox.Show("Huấn luyện xong");

        }
        [Obsolete]
        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i< dgv_KiemThudulieu.Rows.Count;i++)
            {
                string[] inputvalue= new string[dt.Columns.Count - 1];

                for(int j=0;j< dgv_KiemThudulieu.Columns.Count-2;j++)
                {
                    inputvalue[j ] = ((dgv_KiemThudulieu.Rows[i].Cells[j].Value.ToString())).ToString();
                }
                string kq = dtC45.KetQua(inputvalue);
                dgv_KiemThudulieu.Rows[i].Cells[dt.Columns.Count].Value = kq;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
               
                if (openFileDialog2.FileName != string.Empty)
                {
                    string fullPathToExcel = openFileDialog2.FileName; //ie C:\Temp\YourExcel.xls
                    string connString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=yes'", fullPathToExcel);
                    dtDuLieuDuBao = GetDataTable("SELECT * from [Data$]", connString);
                  
                  //  gv_DuBao.DataSource = dtDuLieuDuBao;
                }
            }
        }
        [Obsolete]
        private void button4_Click(object sender, EventArgs e)
        {

            //for (int i = 0; i < gv_DuBao.Rows.Count; i++)
            //{
            //    string[] inputvalue = new string[dt.Columns.Count - 2];

            //    for (int j = 1; j < gv_DuBao.Columns.Count - 1; j++)
            //    {
            //        inputvalue[j - 1] = ((double)double.Parse(gv_DuBao.Rows[i].Cells[j].Value.ToString())).ToString();
            //    }
            //    string kq = dtC45.KetQua(inputvalue);
            //    gv_DuBao.Rows[i].Cells[dt.Columns.Count-1].Value = kq;
            //}
        }

        private void dgv_TabHuanLuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        public void rain()
        {
            lb_tt.Text = "Trời sẽ có mưa";
            //lb_cy2.Text = "Các bạn ra ngoài nhớ mang theo ô dù hoặc áo mưa, tốt nhất nên di chuyển bằng xe bus để tránh tai nạn đáng tiếc";
            Image img = Image.FromFile("anh\\rain2.png");
             
            pic_weather.Image = img;
        }
        public void sunny()
        {
            lb_tt.Text = "Trời sẽ nắng";
            //lb_cy2.Text = "Các bạn ra ngoài nhớ mang theo ô dù, hạn chế ra ngoài vào buổi trưa và chiều, rất dễ bị say nắng";
            Image img = Image.FromFile("anh\\sun2.png");
            
            pic_weather.Image = img;
        }
        public void cool()
        {
            lb_tt.Text = "Trời râm mát";
            //lb_cy2.Text = "Thời tiết tốt, rất thuận lợi cho những chuyến đi chơi, nghỉ mát.";
            Image img = Image.FromFile("anh\\cool.png");
            
            pic_weather.Image = img;
        }
        public void Khac()
        {
            lb_tt.Text = "Chưa đủ dữ liệu!!";
            //lb_cy2.Text = "Thời tiết tốt, rất thuận lợi cho những chuyến đi chơi, nghỉ mát.";
            Image img = Image.FromFile("anh\\30744.png");

            pic_weather.Image = img;
        }
        [Obsolete]
        private void btnDuBao_Click(object sender, EventArgs e)
        {
            if(cboNhietDo.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập nhiệt độ!");
                return;
            }
            if (cboDoAm.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập độ ẩm!");
                return;
            }
            if (_May == "")
            {
                MessageBox.Show("Bạn chưa chọn mây!");
                return;
            }
            string[] inputvalue = new string[dt.Columns.Count - 1];
            inputvalue[0] = cboNhietDo.Text;
            inputvalue[1] = cboDoAm.Text;
            inputvalue[2] = _May;

            string kq = dtC45.KetQua(inputvalue);
            if(kq== "Mat me")
            {
                cool();
            }
            if (kq == "Nang")
            {
                sunny();
            }
            if (kq == "Mua")
            {
                rain();
            }
            if (kq == "Khac")
            {
                Khac();
            }
        }

        private void cboDoAm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string _May = "";
        private void rb_may_0_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_may_0.Checked)
                _May = rb_may_0.Tag.ToString();
            if (rb_may_1.Checked)
                _May = rb_may_1.Tag.ToString();
            if (rb_may_2.Checked)
                _May = rb_may_2.Tag.ToString();
            if (rb_may_3.Checked)
                _May = rb_may_3.Tag.ToString();
        }
    }
}
