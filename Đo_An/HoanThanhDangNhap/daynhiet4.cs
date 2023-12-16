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
    public partial class daynhiet4 : Form
    {
        public daynhiet4()
        {
            InitializeComponent();
            btNext.Visible = false;

            SetQuestion("Câu 3: Đo điện trở cảm biến ở chân THA theo nhiệt độ môi trường.\r\n"); // Gọi phương thức SetQuestion và truyền nội dung câu hỏi
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


        private void checkedListBox1_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            // Đảm bảo rằng chỉ có một mục được chọn
            for (int i = 0; i < checkedListBox1.Items.Count; ++i)
            {
                if (i != e.Index)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }

        private void btcheck_Click(object sender, EventArgs e)
        {
            string valueToCompare = "Lấy tín hiệu R-THA";
            List<string> selectedItems = new List<string>();

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                selectedItems.Add(checkedListBox1.CheckedItems[i].ToString());
            }

            if (selectedItems.Contains(valueToCompare))
            {
                MessageBox.Show("Đáp án Đúng.");
                btNext.Visible = true;
            }
            else
            {
                MessageBox.Show("Đáp án sai.vui lòng chọn lại!!! ");
               // btcheck.Visible = false ;
               // btNext.Visible = true ;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btNext_Click(object sender, EventArgs e)
        {
            daynhiet5 f = new daynhiet5();
            //daynhiet3_1 f = new daynhiet3_1()
            this.Hide();
            f.ShowDialog();
        }

        private void daynhiet4_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt formkt = new formkt();
            this.Hide();
            formkt.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            daynhiet3_1 f = new daynhiet3_1();
             this.Hide();
            f.ShowDialog();
        }
    }
}

