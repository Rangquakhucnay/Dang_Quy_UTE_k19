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
    public partial class delcoquang1 : Form
    {
        public delcoquang1()
        {
            InitializeComponent();
            btNext.Visible = false;
            SetQuestion("Câu 1: Xác định tín hiệu đầu ra cảm biến G và Ne?"); // Gọi phương thức SetQ
            SetQuestion1("Bài 6: Cảm Biến G và Cảm Biến Ne\r\nCảm biến quang (Bố trí trong bộ chia điện)\r\n");

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

        private void delcoquang1_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt f = new formkt();
            this.Hide();
            f.ShowDialog();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            delcoquang2 f = new delcoquang2();
            this.Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delcoquang f = new delcoquang();
            this.Hide();
            f.ShowDialog();
        }

        private void btcheck_Click(object sender, EventArgs e)
        {
            string valueToCompare = "A. Xung vuông 0 – 5V";
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

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
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
    }
}
