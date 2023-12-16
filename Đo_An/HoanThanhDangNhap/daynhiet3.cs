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
    public partial class daynhiet3 : Form
    {
        public daynhiet3()
        {
            InitializeComponent();
            groupBox2.Visible = false;
            btNext.Visible = false;
            SetQuestion("Câu 1: Xác định các chân của cảm biến (Theo hướng giắc đực).\r\n"); // Gọi phương thức SetQuestion và truyền nội dung câu hỏi
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
        private void btCheck_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="" && textBox2.Text== "" && textBox3.Text=="" && textBox4.Text== "" && textBox5.Text =="")
            {
                MessageBox.Show("  Vui Lòng Điền Đúng Thứ Tự Các Chân 1-5 Vào ô Trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                TextBox[] textBoxes = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5 };
                Label[] labels = new Label[] { label7, label8, label9, label10, label11 };

               // int[] numbersToCompare = new int[] { 1, 2, 3, 4, 5 };

                bool areNumbersEqualAndOrdered = true;

                // Lấy giá trị từ các TextBox và Label và so sánh với mảng numbersToCompare
                for (int i = 0; i < 5; i++)
                {
                    string textBoxValue = textBoxes[i].Text;
                    string labelValue = labels[i].Text;

                    bool isValidTextBox = int.TryParse(textBoxValue, out int textBoxNumber);
                    bool isValidLabel = int.TryParse(labelValue, out int labelNumber);

                    // Kiểm tra xem giá trị từ TextBox và Label có hợp lệ hay không
                    if (!isValidTextBox || !isValidLabel || textBoxNumber != labelNumber )
                    {
                        areNumbersEqualAndOrdered = false;
                        break;
                    }
                }

                if (areNumbersEqualAndOrdered)
                {
                    // Các số từ TextBox và Label bằng nhau và theo thứ tự cho trước
                     MessageBox.Show("Bạn Đã Điền Đúng Các Chân !!!");
                    btNext.Visible = true;
                }
                else
                {
                    // Các số từ TextBox và Label không bằng nhau hoặc không theo thứ tự cho trước
                    MessageBox.Show("Sai Thứ Tự Chân Vui Lòng Điền Lại!!!");
                }

            }
            // groupBox2.Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            daynhiet3_1 f= new daynhiet3_1();   
            this.Hide();
            f.ShowDialog(); 
        }

        private void daynhiet3_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt formkt = new formkt();
            formkt.ShowDialog();
        }
    }
}
