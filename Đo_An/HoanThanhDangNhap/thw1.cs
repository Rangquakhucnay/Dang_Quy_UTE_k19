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
    public partial class thw1 : Form
    {
        public thw1()
        {
            InitializeComponent();
          //  btNext.Visible = false;
            SetQuestion("Câu 1: Đo điện trở cảm biến ở chân THW theo nhiệt độ môi trường\r\nYêu cầu: Ngắt kết nối cảm biến khỏi bảng mạch, tiến hành đo điện trở, \r\nsau đó kết nối lại bảng mạch và chọn Tiếp theo.\r\n"); // Gọi phương thức SetQ
            SetQuestion1("Bài 7: Cảm Biến Nhiệt Độ\r\n");
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

        private void thw1_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt f = new formkt();
            this.Hide();
            f.ShowDialog();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            thw2 f = new thw2();
            this.Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thw f = new thw();
            this.Hide();
            f.ShowDialog();
        }

        
    }
}
