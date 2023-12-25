    using Org.BouncyCastle.Math.EC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoanThanhDangNhap
{
    public partial class formDiToiBaiHoc2 : Form
    {
        public formDiToiBaiHoc2()
        {
            InitializeComponent();
        }
        public static string SoActi = string.Empty;
        public static string sttChuongBaiHoc2 = string.Empty;
        public static int TiendoActi = 0;

        string[,] lookupTable_Chuong = new string[,]
        {
            { "Chương 1:", "BƠM NHIÊN LIỆU" },
            { "Chương 2:", "LỌC NHIÊN LIỆU" },
            { "Chương 3:", "BỘ DẬP DAO ĐỘNG" },
            { "Chương 4:", "BỘ ĐIỀU ÁP" },
            { "Chương 5:", "KIM PHUN" },
            { "Chương 6:", "KIM PHUN KHỞI ĐỘNG LẠNH" },
            { "Chương 7:", "BOBIN ĐÁNH LỬA" },
            { "Chương 8:", "HỆ THỐNG ĐIÊU KHIỂN TỐC ĐỘ CẦM CHỪNG" },
            { "Chương 9:", "HỆ THỐNG ĐIỀU KHIỂN BƯỚM GA ĐIỆN TỬ" },
            
            //{ "Chương 8:", "value4" },
            // và tiếp tục với các cặp khác...
        };

        private void cbTenChuong2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTenBaiHoc.Visible = true;
            cbSoActiBH.Enabled = true;
            string tendangnhapform1 = Properties.Settings.Default.TenDangNhapALL;
            int chuongBH = int.Parse(cbSttChuongBH.Text);
            int DinhviCot = chuongBH + 10;  //+11 là vì thứ tự cột bên database
            SQLiteConnection conn = null;
            string strConn = string.Format(@"Data Source = {0}\DBLogin.db;Version=3;", System.Windows.Forms.Application.StartupPath);
            if (conn == null)
                conn = new SQLiteConnection(strConn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                //MessageBox.Show("Đã kết nối");
            }
            SQLiteCommand command = new SQLiteCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from ThongTinSinhVien where TenDangNhap=@tendn";
            command.Connection = conn;
            command.Parameters.AddWithValue("@tendn", tendangnhapform1);
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                TiendoActi = reader.GetInt32(DinhviCot);
                //MessageBox.Show("chạy");
            }
            //MessageBox.Show(TiendoActi.ToString());
            string[] arrActi = new string[TiendoActi];
            for (int i = 1; i <= TiendoActi; i++)
            {
                arrActi[i - 1] = i.ToString();
            }

            // code de hien thi ten chuong va nActi
            string tenChuong = "Chương " + cbSttChuongBH.Text + ":";
            string value = null;

            for (int i = 0; i < lookupTable_Chuong.GetLength(0); i++)
            {
                if (lookupTable_Chuong[i, 0] == tenChuong)
                {
                    value = lookupTable_Chuong[i, 1];
                    break;
                }
            }

            lblTenBaiHoc.Text = value;
            cbSoActiBH.Items.Clear();
            cbSoActiBH.Items.AddRange(arrActi);

            reader.Close();
            conn.Close();
            conn.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbSoActiBH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hoạt động của chương!");
            }
            else
            {
                sttChuongBaiHoc2 = cbSttChuongBH.Text;
                SoActi = cbSoActiBH.Text;////////////////////////////////////////////////////////
                //formBaiHocChuong3 f = new formBaiHocChuong3();
                this.Hide();
                formHienThiBaiHoc2 f = new formHienThiBaiHoc2();
                int a = int.Parse(cbSttChuongBH.Text);
                f.ShowDialog();
                this.Close();
     
            }
            this.Close();
        }

        private void formDiToiBaiHoc2_Load(object sender, EventArgs e)
        {
            lblTenBaiHoc.Visible = false;
            cbSoActiBH.Enabled = false;
           // this.Close();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formDiToiBaiHoc2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        
    }
}
