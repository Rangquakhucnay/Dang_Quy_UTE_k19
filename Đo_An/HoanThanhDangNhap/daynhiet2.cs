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
    public partial class daynhiet2 : Form
    {
        public daynhiet2()
        {
            InitializeComponent();
            exitsetting();
            SetQuestion1("Bài 1: Cảm Biến Lưu Lượng Không Khí Nạp Kiểu dây nhiệt\r\n");
        }

       
        private void SetQuestion1(string question)
        {
            label1.Text = question; // Đặt nội dung câu hỏi cho Label
        }

        void exitsetting()
        {
            ControlBox = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            daynhiet3 f = new daynhiet3();
            this.Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            daynhiet1 f = new daynhiet1();
            this.Hide();
            f.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
