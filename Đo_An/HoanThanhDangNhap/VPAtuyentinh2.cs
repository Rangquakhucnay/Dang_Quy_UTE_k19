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
    public partial class VPAtuyentinh2 : Form
    {
        public VPAtuyentinh2()
        {
            InitializeComponent();
            SetQuestion("Câu 2: Đo điện áp tín hiệu VPA1 khi cánh bướm ga mở hết.\r\n");
            SetQuestion1("Bài 12: cảm biến bàn đạp ga kiểu tuyến tính");
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

        private void VTAhall1_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt formkt = new formkt();
            this.Hide();
            formkt.ShowDialog();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            VTAhall2 f = new VTAhall2();
            this.Hide();
            f.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            VTAhall f = new VTAhall();
            this.Hide();
            f.ShowDialog();
        }

        private void btcheck_Click(object sender, EventArgs e)
        {

        }
    }
}
