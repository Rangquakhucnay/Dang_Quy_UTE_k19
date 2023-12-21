using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoanThanhDangNhap
{
    public partial class LoginStudent : Form
    {

        Thread th;
        Thread th2;
        public LoginStudent()
        {
            InitializeComponent();
        }
        //SqlConnection conn = null;
        //string strConn = @"Data Source=LAPTOP-J8V4PEES\VUHAO;Initial Catalog=QuanLyTaiKhoan;Integrated Security=True";
        public static string tenCOM;
        public static int giatribaudrate; 
        string[] pause = { "1200", "2400", "4800", "9600", "19200", "38400" };



        private void LoginStudent_Load(object sender, EventArgs e)
        {
            string[] listnamecom = SerialPort.GetPortNames();           // quet coi co cac port nao
            listcom.Items.AddRange(listnamecom);
            listrate.Items.AddRange(pause);

            string tendangnhapform1 = Properties.Settings.Default.TenDangNhapALL;
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
                lblTenNguoiDung.Text = reader.GetString(1);
            }
            reader.Close();
            conn.Close();
            conn.Dispose();
        }


            /*if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                //MessageBox.Show("Đã kết nối");
            }

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from ThongTinTaiKhoan";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
            }
            label1.Text = "";*/
        

       

        private void label3_Click(object sender, EventArgs e) // form thuc hanh 1
        {
            if (btnNutKetNoi.Text == "Kết nối")
            {
                MessageBox.Show("Vui lòng kết nối với mô hình trước khi sử dụng");
            }
            else
            {
                formThucHanh f111 = new formThucHanh();
                f111.ShowDialog();
            }  
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 f122 = new Form1();
            f122.Show();
        }

        private void label2_Click(object sender, EventArgs e)       //form chon chuong 1
        {
            if (btnNutKetNoi.Text == "Kết nối")
            {
                MessageBox.Show("Vui lòng kết nối với mô hình trước khi sử dụng");
            }
            else
            {
                formchonphan1 f21 = new formchonphan1();
                f21.ShowDialog();
            }
            
        }

        private void btnNutKetNoi_Click(object sender, EventArgs e)
        {
            if (listcom.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn cổng COM", "Lưu Ý");
                return;
            }
            if (listrate.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn BaudRate", "Lưu Ý");
                return;
            }
            if (btnNutKetNoi.Text == "Ngắt kết nối")
            {
                MessageBox.Show("Ngắt kết nối đồng nghĩa với việc không sử dụng được phần mềm");
                btnNutKetNoi.Text = "Kết nối";
            }
            else if (btnNutKetNoi.Text == "Kết nối")
            {
                tenCOM = listcom.Text;
                giatribaudrate = int.Parse(listrate.Text);
                serialPort1.PortName = tenCOM;
                serialPort1.BaudRate = giatribaudrate;
                btnNutKetNoi.Text = "Ngắt kết nối";
            }
        }

        private void label4_Click(object sender, EventArgs e) // form kiem tra 1
        {
            if (btnNutKetNoi.Text == "Kết nối")
            {
                MessageBox.Show("Vui lòng kết nối với mô hình trước khi sử dụng");
            }
            else
            {
                formExam f99 = new formExam();
                f99.ShowDialog();
            }
        }

        private void NutDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f100 = new Form1();
            f100.Show();
        }

        private void panelBaiHoc_Click(object sender, EventArgs e)// form chon chuong 2
        {
            if (btnNutKetNoi.Text == "Kết nối")
            {
                MessageBox.Show("Vui lòng kết nối với mô hình trước khi sử dụng");
            }
            else
            {
                formchonphan1 f14 = new formchonphan1();
                f14.ShowDialog();
            }
        }

        private void panelThucHanh_Click(object sender, EventArgs e) // form thuc hanh 2
        {
            if (btnNutKetNoi.Text == "Kết nối")
            {
                MessageBox.Show("Vui lòng kết nối với mô hình trước khi sử dụng");
            }
            else
            {
                formThucHanh f56 = new formThucHanh();
                f56.ShowDialog();
            }
        }

        private void panelKiemTra_Click(object sender, EventArgs e) // form kiem tra 2
        {
            if (btnNutKetNoi.Text == "Kết nối")
            {
                MessageBox.Show("Vui lòng kết nối với mô hình trước khi sử dụng");
            }
            else
            {
                formExam f12 = new formExam();
                f12.ShowDialog();
            }
        }



        private void Thuchanh2_Click(object sender, EventArgs e)// form cam  bien 1
        {
            if (btnNutKetNoi.Text == "Kết nối")
            {
                MessageBox.Show("Vui lòng kết nối với mô hình trước khi sử dụng");
            }
            else
            {
              // this.Hide();
                formchonphan2 f1 = new formchonphan2(); 
                f1.ShowDialog();
               // this.Close();
                
                
            }
        }
        
        private void panelThuchanh2_Click(object sender, EventArgs e) // form carm bien 2
        {

            if (btnNutKetNoi.Text == "Kết nối")
            {
                MessageBox.Show("Vui lòng kết nối với mô hình trước khi sử dụng");
            }
            else
            {
               // this.Hide();
           formchonphan2 f1 =   new formchonphan2();
                f1.ShowDialog();
                //this.Close();
               
            }
        }

       

        private void panelBaiHoc_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
