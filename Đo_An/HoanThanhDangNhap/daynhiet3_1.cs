using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoanThanhDangNhap
{
    public partial class daynhiet3_1 : Form
    {
        public daynhiet3_1()
        {
            InitializeComponent();
          
            SetQuestion("Câu 2: Đo điện trở cảm biến ở chân THA theo nhiệt độ môi trường\r\nYêu cầu: Ngắt kết nối cảm biến khỏi bảng mạch, tiến hành đo điện trở, \r\nsau đó kết nối lại bảng mạch và chọn Tiếp theo.\r\n"); // Gọi phương thức SetQuestion và truyền nội dung câu hỏi
            SetQuestion1("Bài 1: Cảm Biến Lưu Lượng Không Khí Nạp Kiểu dây nhiệt\r\n");
            exitsetting();
        }

        void exitsetting()
        {
            ControlBox = false;
        }

        private void SetQuestion(string question)
        {
            lbCauhoi.Text = question; // Đặt nội dung câu hỏi cho Label
        }
        private void SetQuestion1(string question)
        {
            label1.Text = question; // Đặt nội dung câu hỏi cho Label
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            daynhiet4 f= new daynhiet4();
            this.Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            daynhiet3 f = new daynhiet3();
            this.Hide();
            f.ShowDialog();
        }

        private void daynhiet3_1_Load(object sender, EventArgs e)
        {
            
        }

        private void daynhiet3_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt formkt = new formkt();
            this.Hide();
            formkt.ShowDialog();
        }

        private void lbCauhoi_Click(object sender, EventArgs e)
        {

        }
    }
}
