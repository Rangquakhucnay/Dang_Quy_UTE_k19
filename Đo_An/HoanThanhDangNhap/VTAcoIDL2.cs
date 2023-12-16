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
    public partial class VTAcoIDL2 : Form
    {
        public VTAcoIDL2()
        {
            InitializeComponent();
            //  btNext.Visible = false;
            SetQuestion("Câu 2: Đo điện áp tín hiệu VTA khi cánh bướm ga mở hết.\r\n");
            SetQuestion1("Bài 9: Cảm biến vị trí bướm ga kiểu tuyến tính có tiếp điểm IDL");
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

        private void VTAcoIDL2_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt formkt = new formkt();
            this.Hide();
            formkt.ShowDialog();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
          VTAcoIDL3 f = new VTAcoIDL3();
            this.Hide();
            f.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            VTAcoIDL1 f = new VTAcoIDL1();
            this.Hide();
            f.ShowDialog();
        }

        private void btcheck_Click(object sender, EventArgs e)
        {

        }
    }
}
