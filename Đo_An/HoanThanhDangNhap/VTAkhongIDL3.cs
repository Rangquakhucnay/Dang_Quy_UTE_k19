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
    public partial class VTAkhongIDL3 : Form
    {
        public VTAkhongIDL3()
        {
            InitializeComponent();
            //  btNext.Visible = false;
            SetQuestion("Câu 3: Đo điện áp tín hiệu VTA khi cánh bướm ga mở hết.\r\n");
            SetQuestion1("Bài 10: Cảm biến vị trí bướm ga kiểu tuyến tính không có tiếp điểm IDL");
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

        private void VTAkhongIDL3_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt formkt = new formkt();
            this.Hide();
            formkt.ShowDialog();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            //VTAkhongIDL3 f = new VTAkhongIDL3();
            //this.Hide();
            //f.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            VTAkhongIDL2 f = new VTAkhongIDL2();
            this.Hide();
            f.ShowDialog();
        }

        private void btcheck_Click(object sender, EventArgs e)
        {

        }
    }
}
