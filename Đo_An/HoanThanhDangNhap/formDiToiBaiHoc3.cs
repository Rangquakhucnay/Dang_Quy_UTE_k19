﻿using Org.BouncyCastle.Math.EC;
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
            { "Chương 1:", "CẢM BIẾN LƯU LƯỢNG KHÔNG KHÍ NẠP KIỂU DÂY NHIỆT" },
            { "Chương 2:", "CẢM BIẾN LƯU LƯỢNG KHÔNG KHÍ NẠP KIỂU KARMAN SIÊU ÂM" },
            { "Chương 3:", "CẢM BIẾN LƯU LƯỢNG KHÔNG KHÍ NẠP VAN TRƯỢT" },
            { "Chương 4:", "CẢM BIẾN ÁP SUẤT KHÔNG KHÍ NẠP" },
            { "Chương 5:", "CẢM BIẾN G VÀ CẢM BIẾN NE. CẢM BIẾN ĐIỆN TỪ (BỐ TRÍ TRONG BỘ CHIA ĐIỆN)" },
           { "Chương 6:", "CẢM BIẾN G VÀ CẢM BIẾN NE. CẢM BIẾN HALL (BỐ TRÍ TRONG BỘ CHIA ĐIỆN)" },
           { "Chương 7:", "CẢM BIẾN G VÀ CẢM BIẾN NE. CẢM BIẾN QUANG (BỐ TRÍ TRONG BỘ CHIA ĐIỆN) " },
           { "Chương 8:", "CẢM BIẾN NHIỆT ĐỘ" },
           { "Chương 9:", "CẢM BIẾN VỊ TRÍ BƯỚM GA VỊ TRÍ TIẾP ĐIỂM" },
           { "Chương 10:", "CẢM BIẾN VỊ TRÍ BƯỚM GA KIỂU TUYẾN TÍNH CÓ TIẾP ĐIỂM IDL" },
           { "Chương 11:", "CẢM BIẾN VỊ TRÍ BƯỚM GA KIỂU TUYẾN TÍNH KHÔNG CÓ TIẾP ĐIỂM IDL" },
           { "Chương 12:", "CẢM BIẾN VỊ TRÍ BƯỚM GA KIỂU PHẦN TỬ HALL" },
           { "Chương 13:", "CẢM BIẾN BÀN ĐẠP GA KIỂU TUYẾN TÍNH" },
           { "Chương 14:", "CẢM BIẾN BÀN ĐẠP GA KIỂU PHẦN TỬ HALL" },
          
            //{ "Chương 8:", "value4" },
            // và tiếp tục với các cặp khác...
        };

        private void cbTenChuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTenBaiHoc.Visible = true;
            cbSoActiBH.Enabled = true;
            string tendangnhapform1 = Properties.Settings.Default.TenDangNhapALL;
            int chuongBH = int.Parse(cbSttChuongBH.Text);
            int DinhviCot = chuongBH + 14;  //+4 là vì thứ tự cột bên database
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
            }//-----------------------------------------------------------------
           //MessageBox.Show(TiendoActi.ToString());
            string[] arrActi = new string[TiendoActi];
            for (int i = 1; i <= TiendoActi; i++)
            {
                arrActi[i - 1] = i.ToString();
            }
            //-----------------------------------------------------------------------
           // string message = string.Join(Environment.NewLine, arrActi);

            // Hiển thị mảng trong MessageBox
           // MessageBox.Show(message);

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
                SoActi = cbSoActiBH.Text;
                //formBaiHocChuong3 f = new formBaiHocChuong3();
                //  formHienThiBaiHoc f = new formHienThiBaiHoc();
                // int a = int.Parse(cbSttChuongBH.Text);
                // f.ShowDialog();

                this.Hide();
                formHienThiBaiHoc3 f1 = new formHienThiBaiHoc3();
                int a = int.Parse(cbSttChuongBH.Text);
                f1.ShowDialog();
                this.Close();
            }
            this.Close();
        }

        private void formDiToiBaiHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSoActiBH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formDiToiBaiHoc_Load(object sender, EventArgs e)
        {
            lblTenBaiHoc.Visible = false;
            cbSoActiBH.Enabled = false;
        }
    }
}
