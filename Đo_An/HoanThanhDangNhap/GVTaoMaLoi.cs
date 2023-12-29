using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoanThanhDangNhap
{
    public partial class GVTaoMaLoi : Form
    {
        public GVTaoMaLoi()
        {
            InitializeComponent();
        }
        int MaLoi = 0;
        string[] pause = { "1200", "2400", "4800", "9600", "19200", "38400" };
        private void guiMaFault(string ft)
        {
            serialPort1.Open();
            serialPort1.Write(ft);
            //MessageBox.Show("đã gửi");
            serialPort1.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NutKetNoi.Text == "Kết nối")
            {
                MessageBox.Show("Vui lòng kết nối với mô hình trước khi sử dụng");
            }
            else
            {
                if (int.TryParse(txtMaLoi.Text, out MaLoi) == false)
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng mã lỗi!");
                    txtMaLoi.Text = string.Empty;
                    return;
                }

                switch (int.Parse(txtMaLoi.Text))
                {
                    case 1:
                        guiMaFault("p1");
                        break;
                    case 2:
                        guiMaFault("p2");
                        break;
                    case 3:
                        guiMaFault("p3");
                        break;
                    case 4:
                        guiMaFault("p4");
                      //  MessageBox.Show("check D");
                        break;
                    case 5:
                        guiMaFault("p5");
                        break;
                    case 6:
                        guiMaFault("p6");
                        break;
                    case 7:
                        guiMaFault("p7");
                        break;
                    case 8:
                        guiMaFault("p8");
                        break;
                    case 9:
                        guiMaFault("p9");
                        break;
                    case 10:
                        guiMaFault("p10");
                        break;
                    case 11:
                        guiMaFault("p11");
                        break;
                    case 12:
                        guiMaFault("p12");
                        break;
                    case 13:
                        guiMaFault("p13");
                        break;
                    case 14:
                        guiMaFault("p14");
                        break;
                    case 15:
                        guiMaFault("p15");
                        break;
                    case 16:
                        guiMaFault("p16");
                        break;
                    case 17:
                        guiMaFault("p17");
                        break;
                    case 18:
                        guiMaFault("p18");
                        break;
                    case 19:
                        guiMaFault("p119");
                        break;
                    case 20:
                        guiMaFault("p20");
                        break;
                    
                        
                    default:
                        MessageBox.Show("Vui lòng nhập đúng mã lỗi có trong danh sách");
                        break;
                }
                txtMaLoi.Text = "";
            }
        }
            

        private void NutXoaLoi_Click(object sender, EventArgs e)
        {
            if (NutKetNoi.Text == "Kết nối")
            {
                MessageBox.Show("Vui lòng kết nối với mô hình trước khi sử dụng");
            }
            else
            {
                guiMaFault("x");
            }
        }

        private void GVTaoMaLoi_Load(object sender, EventArgs e)
        {
            string[] listnamecom = SerialPort.GetPortNames();           // quet coi co cac port nao
            listcom.Items.AddRange(listnamecom);
            listrate.Items.AddRange(pause);
        }

        private void NutKetNoi_Click(object sender, EventArgs e)
        {
            if (listcom.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn cổng COM", "Lưu Ý");
                return;
            }
            if (listrate.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn BaudRate", "Lưu Ý");
                return;
            }

            if (NutKetNoi.Text == "Kết nối")
            {
                NutKetNoi.Text = "Ngắt kết nối";
                serialPort1.PortName = listcom.Text;
                serialPort1.BaudRate = int.Parse(listrate.Text);
            }
            else if (NutKetNoi.Text == "Ngắt kết nối")
            {
                NutKetNoi.Text = "Kết nối";
            }
        }

        private void NutThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*
            formGV f = new formGV();
            f.Show();*/
        }

        private void GVTaoMaLoi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
