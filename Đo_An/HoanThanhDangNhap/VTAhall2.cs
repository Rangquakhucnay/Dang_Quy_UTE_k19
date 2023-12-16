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
    public partial class VTAhall2 : Form
    {
        public VTAhall2()
        {
            InitializeComponent();
            SetQuestion("Câu 2: Đo điện áp tín hiệu VTA2 khi cánh bướm ga mở hết.\r\n");
            SetQuestion1("Bài 11: Cảm biến vị trí bướm ga kiểu phần tử Hall");
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

        private void VTAhall2_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt formkt = new formkt();
            this.Hide();
            formkt.ShowDialog();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
           // VTAhall2 f = new VTAhall2();
           // this.Hide();
           // f.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            VTAhall1 f = new VTAhall1();
            this.Hide();
            f.ShowDialog();
        }

        private void btcheck_Click(object sender, EventArgs e)
        {

        }
    }
}
