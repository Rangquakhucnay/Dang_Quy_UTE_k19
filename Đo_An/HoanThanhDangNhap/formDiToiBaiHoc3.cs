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
    public partial class formDiToiBaiHoc3 : Form
    {
        public formDiToiBaiHoc3()
        {
            InitializeComponent();
        }

        public static string SoActi = string.Empty;
        public static string sttChuongBaiHoc3 = string.Empty;
        public static int TiendoActi = 0;

        string[,] lookupTable_Chuong = new string[,]
        {
            { "Chương 1:", "CẢM BIẾN LƯU LƯỢNG KHÔNG KHÍ NẠP DÂY NHIỆT" },
            { "Chương 2:", "CẢM BIẾN LƯU LƯỢNG KHÔNG KHÍ NẠP KIỂU KARMAN SIÊU ÂM" },
            { "Chương 3:", "CẢM BIẾN ÁP SUẤT KHÔNG KHÍ NẠP" },
            { "Chương 4:", "CẢM BIẾN G VÀ CẢM BIẾN NE,CẢM BIẾN ĐIỆN TỪ (BỐ TRÍ TRONG BỘ CHIA ĐIỆN)" },
            { "Chương 5:", "CẢM BIẾN G VÀ CẢM BIẾN NE,CẢM BIẾN HALL (BỐ TRÍ TRONG BỘ CHIA ĐIỆN)" },
            { "Chương 6:", "CẢM BIẾN G VÀ CẢM BIẾN NE,CẢM BIÉN QUANG (BỐ TRÍ TRONG BỘ CHIA ĐIỆN)" },
            { "Chương 7:", "CẢM BIẾN NHIỆT ĐỘ" },
            { "Chương 8:", "CẢM BIẾN VỊ TRÍ BƯỚM GA KIỂU TIẾP ĐIỂM" },
            { "Chương 9:", "CẢM BIẾN VỊ TRÍ BƯỚM GA KIỂU TUYẾN TÍNH CÓ IDL" },
            { "Chương 10:", "CẢM BIẾN VỊ TRÍ BƯỚM GA KIỂU TUYẾN TÍNH KHÔNG CÓ IDL" },
            { "Chương 11:", "CẢM BIẾN VỊ TRÍ BƯỚM GA KIỂU PHẦN TỬ HALL" },
            { "Chương 12:", "CẢM BIẾN BÀN ĐẠP GA KIỂU TUYẾN TÍNH" },
            { "Chương 13:", "CẢM BIẾN BÀN ĐẠP GA KIỂU PHẦN TỬ HALL" },
           
            //{ "Chương 14:", "value4" },
            // và tiếp tục với các cặp khác...
        };

        private void cbTenChuong2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTenBaiHoc.Visible = true;
            cbSoActiBH.Enabled = true;
            string tendangnhapform1 = Properties.Settings.Default.TenDangNhapALL;
            int chuongBH = int.Parse(cbSttChuongBH.Text);
            int DinhviCot = chuongBH + 18;  //+18 là vì thứ tự cột bên database
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
                sttChuongBaiHoc3 = cbSttChuongBH.Text;
                SoActi = cbSoActiBH.Text;////////////////////////////////////////////////////////
                //formBaiHocChuong3 f = new formBaiHocChuong3();
                formHienThiBaiHoc3 f = new formHienThiBaiHoc3();
                int a = int.Parse(cbSttChuongBH.Text);
                f.ShowDialog();
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
