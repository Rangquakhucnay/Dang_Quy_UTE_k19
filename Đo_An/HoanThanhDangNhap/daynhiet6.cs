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
    public partial class daynhiet6 : Form
    {
        public daynhiet6()
        {
            InitializeComponent();
          //  btNext.Visible = false;
            SetQuestion("Câu 5: Kiểm tra tín hiệu VG khi kết nối cảm biến.\n\r");
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
        private void daynhiet6_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt formkt = new formkt();
            this.Hide();
            formkt.ShowDialog();
        }

        private void btcheck_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            daynhiet7 f = new daynhiet7();
            this.Hide();
            f.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            daynhiet5 f = new daynhiet5();
            this.Hide();
            f.ShowDialog();
        }
    }
}
