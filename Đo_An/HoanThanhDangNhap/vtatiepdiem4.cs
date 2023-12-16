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
    public partial class vtatiepdiem4 : Form
    {
        public vtatiepdiem4()
        {
            InitializeComponent();
            btNext.Visible = false;
            SetQuestion("Câu 4: Khi ở chế độ đầy tải tín hiệu cảm biến gửi về là ? (Chọn đáp án đúng nhất)\r\n"); // Gọi phương thức SetQ
            SetQuestion1("Bài 8: Cảm biến vị trí bướm ga kiểu tiếp điểm");
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

        private void vtatiepdiem4_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt f = new formkt();
            this.Hide();
            f.ShowDialog();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
           // vtatiepdiem3 f = new vtatiepdiem3();
           // this.Hide();
           // f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vtatiepdiem3 f = new vtatiepdiem3();
            this.Hide();
            f.ShowDialog();
        }

        private void btcheck_Click(object sender, EventArgs e)
        {
            string valueToCompare = "D. Cả A và C đều đúng.";
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
