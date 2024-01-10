using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace HoanThanhDangNhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void NutDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên đăng nhập");
            }
            else
            {
                if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập Mật khẩu");
                }
                else
                {
                    string str = string.Format(@"Data Source = {0}\DBLogin.db;Version=3;", Application.StartupPath);
                    using (SQLiteConnection conn = new SQLiteConnection(str))
                    {
                        conn.Open();

                        string TenDangNhap = txtTenDangNhap.Text.Trim();
                        string matkhaunhapvao = txtMatKhau.Text.Trim();

                        SQLiteCommand command = new SQLiteCommand();
                        command.CommandType = CommandType.Text;
                        command.CommandText = "Select * from ThongTinSinhVien where TenDangNhap='" + TenDangNhap + "'";
                        command.Connection = conn;
                        SQLiteDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            int quyen = reader.GetInt32(5);
                            string matkhausosanh = reader.GetString(3);
                            if (matkhausosanh != matkhaunhapvao)
                            {
                                MessageBox.Show("Sai mật khẩu");
                            }
                            else
                            {
                                if (quyen == 0)
                                {
                                    LoginStudent st = new LoginStudent();
                                    st.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    formGV gv = new formGV();
                                    gv.Show();
                                    this.Hide();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập không tồn tại");
                        }
                        reader.Close();
                        conn.Close();
                        conn.Dispose();
                    }
                }            
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

      

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TenDangNhapALL = txtTenDangNhap.Text;
            Properties.Settings.Default.Save();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
