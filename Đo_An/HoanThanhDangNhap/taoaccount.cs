using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoanThanhDangNhap
{
    public partial class taoaccount : Form
    {
        public taoaccount()
        {
            InitializeComponent();
        }
        SQLiteConnection conn = null;
        string strConn = string.Format(@"Data Source = {0}\DBLogin.db;Version=3;", Application.StartupPath);

        string SvCanXemTienDo;

        private void connectSqlite()
        {
            if (conn == null)
                conn = new SQLiteConnection(strConn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                //MessageBox.Show("Đã kết nối");
            }
        }
        private void LoadLop()
        {
            connectSqlite();

            SQLiteCommand command = new SQLiteCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * from ThongTinLop";
            command.Connection = conn;

            lvLop.Items.Clear();

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                ListViewItem lvi = new ListViewItem(reader.GetString(1));
                lvi.SubItems.Add(reader.GetInt32(0) + "");
                lvLop.Items.Add(lvi);
            }
            reader.Close();

        }
        private void LoadSinhVien()
        {
            if (lvLop.SelectedItems.Count == 0) return;
            string line = lvLop.SelectedItems[0].SubItems[0].Text;

            connectSqlite();

            SQLiteCommand command = new SQLiteCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from ThongTinSinhVien Join ThongTinLop On ThongTinSinhVien.MaLop = ThongTinLop.IdMaLop where TenLop=@TenLop";
            command.Connection = conn;

            command.Parameters.AddWithValue("@TenLop", line);

            lvDanhSachLop.Items.Clear();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string TenSinhVien = reader.GetString(1);
                string TenDangNhap = reader.GetString(2);
                string MatKhau = reader.GetString(3);
                ListViewItem lvi = new ListViewItem(TenSinhVien);
                lvi.SubItems.Add(TenDangNhap);
                lvi.SubItems.Add(MatKhau);
                lvDanhSachLop.Items.Add(lvi);

            }
            reader.Close();
        }

        private void XoaTxt()
        {
            txtTensinhvienmoi.Clear();
            txtTendangnhapmoi.Clear();
            txtMatkhaumoi.Clear();
            txtLopmoi.Clear();
            lvDanhSachLop.SelectedItems.Clear();
        }
    
        //Hiện thông tin sinh viên ở khung Thêm/sửa thông tin
        private void lvDanhSachLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachLop.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvDanhSachLop.SelectedItems[0];
            ListViewItem lvi2 = lvLop.SelectedItems[0];

            NutXemTienDo.Visible = true;
            NutXemTienDo.Enabled = true;
            txtTensinhvienmoi.Text = lvi.SubItems[0].Text;
            txtTendangnhapmoi.Text = lvi.SubItems[1].Text;
            txtMatkhaumoi.Text = lvi.SubItems[2].Text;
            txtLopmoi.Text = lvi2.SubItems[1].Text;
        }
        
        //Thêm sinh viên mới
        private void NutThem_Click(object sender, EventArgs e)
        {
            string tensvmoi = txtTensinhvienmoi.Text;
            string tendnmoi = txtTendangnhapmoi.Text;
            string mkmoi = txtMatkhaumoi.Text;

            if (tensvmoi == "" || tendnmoi == "" || mkmoi == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
            }
            else
            {
                connectSqlite();

                //Check trùng tên đăng nhập
                SQLiteCommand command1 = new SQLiteCommand();
                command1.CommandType = CommandType.Text;
                command1.CommandText = "Select * from ThongTinSinhVien where TenDangNhap=@tendn";
                command1.Parameters.AddWithValue("@tendn", txtTendangnhapmoi.Text);
                command1.Connection = conn;
                SQLiteDataReader reader = command1.ExecuteReader();

                //check lớp không tồn tại
                string lopmoi = txtLopmoi.Text;
                SQLiteCommand command2 = new SQLiteCommand();
                command2.CommandType = CommandType.Text;
                command2.CommandText = "Select * from ThongTinLop where IdMaLop=@malop";
                command2.Parameters.AddWithValue("@malop", lopmoi);
                command2.Connection = conn;
                SQLiteDataReader reader2 = command2.ExecuteReader();
                if (reader2.Read()) 
                {
                    if (reader.Read())
                    {
                        string tenDNdaco = reader.GetString(2);
                        if (tenDNdaco == txtTendangnhapmoi.Text)
                        {
                            MessageBox.Show("Tên đăng nhập này đã tồn tại");
                            //XoaTxt();
                        }
                    }
                    else
                    {
                        //Thêm dữ liệu sinh viên
                        SQLiteCommand command = new SQLiteCommand();
                        command.CommandType = CommandType.Text;
                        string sql = "Insert into ThongTinSinhVien(TenSinhVien,TenDangNhap,MatKhau,MaLop,Quyen,nqtc1,nqtc2,nqtc3,nqtc4,nqtc5,nqtc6,nqtc7,nqtc8,nqtc9,nqtc10,nqtc11,nqtc12,nqtc13,nqtc14,nqtc15,nqtc16) values(@tensv,@tendn,@matkhau,@malop,@quyen,@nqtc1,@nqtc2,@nqtc3,@nqtc4,@nqtc5,@nqtc6,@nqtc7,@nqtc8,@nqtc9,@nqtc10,@nqtc11,@nqtc12,@nqtc13,@nqtc14,@nqtc15,@nqtc16)";
                        command.CommandText = sql;
                        command.Connection = conn;
                        command.Parameters.AddWithValue("@tensv", txtTensinhvienmoi.Text);
                        command.Parameters.AddWithValue("@tendn", txtTendangnhapmoi.Text);
                        command.Parameters.AddWithValue("@matkhau", txtMatkhaumoi.Text);
                        command.Parameters.AddWithValue("@malop", txtLopmoi.Text);
                        command.Parameters.AddWithValue("@quyen", 0);

                        command.Parameters.AddWithValue("@nqtc1", 17);
                        command.Parameters.AddWithValue("@nqtc2", 13);
                        command.Parameters.AddWithValue("@nqtc3", 4);
                        command.Parameters.AddWithValue("@nqtc4", 8);
                        command.Parameters.AddWithValue("@nqtc5", 3);
                        command.Parameters.AddWithValue("@nqtc6", 5);
                        command.Parameters.AddWithValue("@nqtc7", 5);
                        command.Parameters.AddWithValue("@nqtc8", 13);
                        command.Parameters.AddWithValue("@nqtc9", 1);
                        command.Parameters.AddWithValue("@nqtc10", 3);
                        command.Parameters.AddWithValue("@nqtc11", 2);
                        command.Parameters.AddWithValue("@nqtc12", 10);
                        command.Parameters.AddWithValue("@nqtc13", 3);
                        command.Parameters.AddWithValue("@nqtc14", 14);
                        command.Parameters.AddWithValue("@nqtc15", 6);
                        command.Parameters.AddWithValue("@nqtc16", 9);
                        // command.Parameters.AddWithValue("@nqtc10000", 1);
                        int kq = command.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Thêm sinh viên mới thành công!");
                            LoadSinhVien();
                            XoaTxt();
                        }
                        else
                        {
                            MessageBox.Show("Thất bại!");
                        }
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Mã lớp không tồn tại");
                }

                
            }
        }

        //Sửa thông tin sinh viên
        private void NutSua_Click(object sender, EventArgs e)
        {
            if (lvDanhSachLop.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn đối tượng");
                return;
            }
            connectSqlite();

            //Check trùng tên đăng nhập
            SQLiteCommand command1 = new SQLiteCommand();
            command1.CommandType = CommandType.Text;
            command1.CommandText = "Select * from ThongTinSinhVien where TenDangNhap=@tendn";
            command1.Parameters.AddWithValue("@tendn", txtTendangnhapmoi.Text);
            command1.Connection = conn;
            SQLiteDataReader reader = command1.ExecuteReader();
            if (reader.Read())
            {
                string tenDNdaco = reader.GetString(2);
                if (tenDNdaco == txtTendangnhapmoi.Text)
                {
                    MessageBox.Show("Tên đăng nhập này đã tồn tại");
                    XoaTxt();
                }
            }
            else
            {
                ListViewItem lvi = lvDanhSachLop.SelectedItems[0];
                string hangdangchon = lvi.Text.Trim();
                SQLiteCommand command2 = new SQLiteCommand();
                command2.CommandType = CommandType.Text;
                command2.CommandText = "select * from ThongTinSinhVien where TenSinhVien=@tensinhvien";
                command2.Connection = conn;
                command2.Parameters.AddWithValue("@tensinhvien", hangdangchon);
                SQLiteDataReader reader2 = command2.ExecuteReader();
                if (reader2.Read())
                {
                    int vitri = reader2.GetInt32(0);
                    SQLiteCommand command = new SQLiteCommand();
                    command.CommandType = CommandType.Text;
                    string sql = "update ThongTinSinhVien set TenSinhVien=@tensv, TenDangNhap=@tendn, MatKhau=@matkhau, MaLop=@malop where IDSV=@idsv";
                    command.CommandText = sql;
                    command.Connection = conn;

                    ListViewItem lvi2 = lvLop.SelectedItems[0];

                    command.Parameters.AddWithValue("@tensv", txtTensinhvienmoi.Text);
                    command.Parameters.AddWithValue("@tendn", txtTendangnhapmoi.Text);
                    command.Parameters.AddWithValue("@matkhau", txtMatkhaumoi.Text);
                    command.Parameters.AddWithValue("@malop", txtLopmoi.Text);
                    command.Parameters.AddWithValue("@idsv", vitri);

                    int kq = command.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        LoadSinhVien();
                        XoaTxt();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin thất bại!");
                    }
                }
            }
            reader.Close();
        }
        
        //Hiển thị danh sách sinh viên theo tên lớp
        private void lvLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSinhVien();
        }
        
        //Thêm lớp mới
        private void button1_Click(object sender, EventArgs e)
        {
            connectSqlite();
            string line = txtTenLopMoi.Text;
            if (line.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên lớp");
            }
            else
            {
                //Check trùng tên lớp
                SQLiteCommand command1 = new SQLiteCommand();
                command1.CommandType = CommandType.Text;
                command1.CommandText = "Select * from ThongTinLop where TenLop=@tenlop";
                command1.Parameters.AddWithValue("@tenlop", line);
                command1.Connection = conn;
                SQLiteDataReader reader = command1.ExecuteReader();
                if (reader.Read())
                {
                    string tenlopdaco = reader.GetString(1);
                    if (tenlopdaco == line)
                    {
                        MessageBox.Show("Tên lớp này đã tồn tại");  
                    }
                }
                else
                {
                    SQLiteCommand command = new SQLiteCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "Insert into ThongTinLop(TenLop) values(@tenlop)"; ;
                    command.Connection = conn;

                    command.Parameters.AddWithValue("@tenlop", line);

                    int kq = command.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm lớp mới thành công!");
                        LoadLop();
                        txtTenLopMoi.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm lớp mới thất bại!");
                    }
                }
                reader.Close();
            }
        }

        private void LoginAd_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*Form1 f = new Form1();
            f.Show();*/
            this.Hide();
            conn.Close();
            conn.Dispose();
        }

        private void LoginAd_Click(object sender, EventArgs e)
        {
            XoaTxt();
            txtTenLopMoi.Clear();
            lvDanhSachLop.SelectedItems.Clear();
            NutXemTienDo.Enabled = false;
        }

        private void NutXoa_Click(object sender, EventArgs e)
        {
            if (lvDanhSachLop.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn đối tượng để xóa");
                return;
            }

            ListViewItem lvi = lvDanhSachLop.SelectedItems[0];
            string xoa = lvi.Text.Trim();
            DialogResult res = MessageBox.Show("Bạn có chắc muốn Xóa tài khoản này?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                connectSqlite();
                SQLiteCommand command = new SQLiteCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "delete from ThongTinSinhVien where TenSinhVien=@tensinhvien";
                command.Connection = conn;
                command.Parameters.AddWithValue("@tensinhvien", xoa);

                int kq = command.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Xóa tài khoản sinh viên thành công!");
                    LoadSinhVien();
                    XoaTxt();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản sinh viên thất bại!");
                }
            }
            if (res == DialogResult.No)
            {
                return;
            }
        }

        //Xóa lớp
        private void NutXoaLop_Click(object sender, EventArgs e)
        {
            if (lvLop.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn đối tượng để xóa");
                return;
            }
            DialogResult res = MessageBox.Show("Bạn có chắc muốn Xóa lớp này?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                connectSqlite();

                ListViewItem lvi1 = lvLop.SelectedItems[0];
                int ma = int.Parse(lvi1.SubItems[1].Text);
                SQLiteCommand command2 = new SQLiteCommand();
                command2.CommandType = CommandType.Text;
                command2.CommandText = "Select * from ThongTinSinhVien where MaLop=@malop";
                command2.Connection = conn;
                command2.Parameters.AddWithValue("@malop", ma);
                SQLiteDataReader reader = command2.ExecuteReader();
                int n = 0;
                while (reader.Read()) { n = n + 1; }

                //kiểm tra trong lớp đó còn sinh viên hay không? Nếu còn thì xóa cả 2. Nếu không thì xóa lớp.
                if (n == 0)
                {
                    ListViewItem lvi = lvLop.SelectedItems[0];
                    string xoa = lvi.Text.Trim();
                    SQLiteCommand command = new SQLiteCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "delete from ThongTinLop where TenLop=@tenlop";
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@tenlop", xoa);
                    int kq = command.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa lớp thành công!");
                        LoadLop();
                        lvDanhSachLop.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa lớp thất bại!");
                    }
                }
                else
                {
                    //Xoá tất cả sinh viên trong lớp đó
                    SQLiteCommand command1 = new SQLiteCommand();
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = "delete from ThongTinSinhVien where MaLop=@malop";
                    command1.Connection = conn;
                    command1.Parameters.AddWithValue("@malop", ma);
                    int kq1 = command1.ExecuteNonQuery();
                    //Xóa lớp đó
                    ListViewItem lvi = lvLop.SelectedItems[0];
                    string xoa = lvi.Text.Trim();
                    SQLiteCommand command = new SQLiteCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "delete from ThongTinLop where TenLop=@tenlop";
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@tenlop", xoa);
                    int kq = command.ExecuteNonQuery();
                    if (kq > 0 && kq1 > 0)
                    {
                        MessageBox.Show("Xóa lớp thành công!");
                        LoadLop();
                        lvDanhSachLop.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa lớp thất bại!");
                    }
                }
                reader.Close();
            }
            if (res == DialogResult.No)
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e) //Nút đăng xuất
        {
            this.Hide();
            conn.Close();
            conn.Dispose();
        }

        private void LoginAd_Load(object sender, EventArgs e)
        {
            LoadLop();  //Hiện form AD lên thì ở bảng lớp cũng hiện danh sách các lớp
            NutXemTienDo.Visible = false;
            
        }

        private void NutXemTienDo_Click(object sender, EventArgs e)
        {
            connectSqlite();
            ListViewItem lvi = lvDanhSachLop.SelectedItems[0];
            string hangdangchon = lvi.Text.Trim();
            SQLiteCommand command = new SQLiteCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from ThongTinSinhVien where TenSinhVien=@tensinhvien";
            command.Connection = conn;
            command.Parameters.AddWithValue("@tensinhvien", hangdangchon);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                SvCanXemTienDo = reader.GetString(2);
            }
            reader.Close();
            Properties.Settings.Default.TenDangNhapALL = SvCanXemTienDo;
            Properties.Settings.Default.Save();
            //MessageBox.Show(SvCanXemTienDo);
            TienDoSV f = new TienDoSV();
            f.ShowDialog();
        }
    }
}
