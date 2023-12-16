using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoanThanhDangNhap
{
    public partial class formExam : Form
    {
        public formExam()
        {
            InitializeComponent();
        }

        // Các biến để tính điểm
        int nCauhoi = 0;
        int nDung = 0;
        int demCauHoi = 0;

        string[] nRandom;
        string[] faultCArray;

        Dictionary<string, string[]> faultCDictionary = new Dictionary<string, string[]>()
        {
            { "faultC1", new string[] { "02", "03", "10", "13", "21" } },
            { "faultC2", new string[] { "02", "03", "10", "13", "21" } },
            { "faultC3", new string[] { "02", "03", "05", "15", "22", "23" } },
            { "faultC4", new string[] { "02", "03", "04", "06", "24", "25" } },
            { "faultC5", new string[] { "02", "03", "04", "06", "07", "11", "12", "16", "20" } },
            { "faultC6", new string[] { "02", "03", "15", "17", "20", "22", "24", "25", "27" } },
            { "faultC7", new string[] { "02", "03", "04", "06", "07", "11", "12", "17", "24", "25" } },

            //chưa check
            { "faultC8", new string[] { "02", "03", "04", "06", "07", "17", "24", "25" } },
        };

        string KituFault, Ma;
        string dapan1, dapan2, hinh;
        string comp;

        private void btnNutDapAn_Click(object sender, EventArgs e)
        {
            KiemTraDapAn();
            guiMaFault("x");
            //MessageBox.Show("het fault");
            demCauHoi++;
            if (demCauHoi <= nCauhoi)
            {
                btnNutTaoFault.Text = "Câu " + demCauHoi.ToString();
                TaoFault();
            }
            else
            {
                // Tiến hành chấm điểm
                DiemSo();
                nCauhoi = 0;
                nDung = 0;
                demCauHoi = 1;

                // modify things
                btnNutTaoFault.Enabled = false;
                pictureBox1.Visible = false;
                btnNutTaoFault.Visible = false;
                chlst_comp.Visible = false;
                chlst_fault.Visible = false;
                btnNutDapAn.Visible = false;
                btnNutTaoFault.Text = "Tạo fault";
                btnNutTaoFault.Enabled = true;
                btnLoadExam.Enabled = true;
            }
            btnNutDapAn.Enabled = false;
        }

        private void chlst_comp_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckToHienthi();
        }

        private void chlst_fault_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckToHienthiNutOK();
            btnNutDapAn.Enabled = true;
        }

        private void CheckToHienthi()
        {
            if (chlst_comp.CheckedItems.Count > 0)
            {
                chlst_fault.Visible = true;

            }
            else { chlst_fault.Visible = false; }
        }
        private void CheckToHienthiNutOK()
        {
            if (chlst_fault.CheckedItems.Count > 0)
            {
                btnNutDapAn.Visible = true;

            }
            else { btnNutDapAn.Visible = false; }
        }

        private void KiemTraDapAn()
        {
            // kiem tra dap an 
            int checkedAns1 = int.Parse(dapan1);
            int checkedAns2 = int.Parse(dapan2);

            if (chlst_comp.GetItemChecked(checkedAns1) == true && chlst_fault.GetItemChecked(checkedAns2) == true)
            {
                MessageBox.Show("Đáp án Đúng");
                nDung++;
            }
            else { MessageBox.Show("Đáp án Sai"); }
            XoaCheck();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn Nộp bài?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                DiemSo();
            }
            else { return; }
        }

        private void formExam_FormClosing(object sender, FormClosingEventArgs e)
        {
            guiMaFault("x");
            this.Hide();
        }

        private void chlst_comp_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Đảm bảo rằng chỉ có một mục được chọn
            for (int i = 0; i < chlst_comp.Items.Count; ++i)
            {
                if (i != e.Index)
                {
                    chlst_comp.SetItemChecked(i, false);
                }
            }
        }

        private void chlst_fault_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Đảm bảo rằng chỉ có một mục được chọn
            for (int i = 0; i < chlst_fault.Items.Count; ++i)
            {
                if (i != e.Index)
                {
                    chlst_fault.SetItemChecked(i, false);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            formEXAMtonghop f = new formEXAMtonghop();
            f.ShowDialog();
        }

        private void formExam_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnLoadExam_Click(object sender, EventArgs e)
        {
            btnNutTaoFault.BackColor = Color.White;
            if (cbChuong.Text == "" || cbSoCauHoi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn Chương/Số lượng câu hỏi");
                return;
            }
            else
            {
                //modify things
 
                pictureBox1.Visible = true;
                btnNutTaoFault.Visible = true;
                btnNutTaoFault.Enabled = true;
                btnLoadExam.Enabled = false;
            }

            // Lấy ten chuong từ combobox
            int a = int.Parse(cbChuong.Text);

            // Lấy tên chuỗi cần truy cập dựa trên giá trị của a
            string faultCName = "faultC" + a;

            // Lấy mảng chuỗi tương ứng từ từ điển
            faultCArray = faultCDictionary[faultCName];

            nRandom = new string[int.Parse(cbSoCauHoi.Text)];

            // Tạo 1 mảng chứa các giá trị fault lỗi để các lỗi k lặp lại
            // Sử dụng mảng chuỗi trong vòng lặp
            Random random = new Random();
            for (int i = 0; i < nRandom.Length; i++)
            {
                if (faultCArray.Length == 0)  // Nếu mảng faultCArray không còn phần tử nào
                {
                    // Thiết lập lại giá trị của faultCArray từ dictionary
                    faultCArray = faultCDictionary[faultCName];
                }

                int randomIndex = random.Next(0, faultCArray.Length); // tạo một số ngẫu nhiên từ 0 đến fault.Length - 1

                nRandom[i] = faultCArray[randomIndex];               // lấy giá trị tại vị trí ngẫu nhiên trong dãy fault và gán vào vị trí i trong dãy mới nRan

                faultCArray = faultCArray.Where((val, idx) => idx != randomIndex).ToArray(); // loại bỏ giá trị đã được chọn khỏi dãy fault
            }

        }

        private void XoaCheck()
        {
            for (int i = 0; i < chlst_comp.Items.Count; i++)
            {
                chlst_comp.SetItemChecked(i, false);
            }
            for (int i = 0; i < chlst_fault.Items.Count; i++)
            {
                chlst_fault.SetItemChecked(i, false);
            }
            chlst_comp.ClearSelected();
            chlst_fault.ClearSelected();
        }

        private void btnNutTaoFault_Click(object sender, EventArgs e)
        {
            chlst_comp.Visible= true;
            nCauhoi = int.Parse(cbSoCauHoi.Text);
            demCauHoi = 1;
            TaoFault();

            // modify things
            label4.Visible = true;
            button2.Visible = true;
            btnNutTaoFault.Text = "Câu 1";
            btnNutTaoFault.BackColor = Color.LightGray;
            btnNutTaoFault.Enabled = false;

        }
        private void DiemSo()
        {
            if (nDung > (nCauhoi / 2))
            {
                MessageBox.Show("Chúc mừng bạn đã ĐẠT trong bài kiểm tra!");
            }
            else { MessageBox.Show("KHÔNG ĐẠT! Hãy học tập tốt hơn vào lần tới nhé!"); }
            nDung = 0;
            demCauHoi = 0;
            btnLoadExam.Enabled = true;
            btnNutTaoFault.Text = "Tạo fault";
            chlst_comp.Visible = false;
            chlst_fault.Visible = false;
            btnNutDapAn.Visible = false;
            guiMaFault("x");
        }


        void TaoFault()
        {
            // Lấy ten chuong từ combobox
            int a = int.Parse(cbChuong.Text);

            // lúc này demcauhoi = 1 
            btnNutTaoFault.Text = "Câu " + demCauHoi.ToString();

            // Khởi tạo excel để lấy mã lỗi và hiện lên
            // Khai báo đối tượng Excel
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excel.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\Resources\\Du lieu cau hoi\\thu vien ma loi.xlsx");
            Worksheet worksheet = workbook.Sheets[a.ToString()]; // Worksheet worksheet = workbook.Sheets["Tên sheet"];
            Range range = worksheet.UsedRange;

            // Lấy số hàng và số cột của tập tin Excel
            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;

            // Duyệt qua các hàng trong tập tin Excel để tìm kiếm dữ liệu
            try
            {
                for (int row = 1; row <= rowCount; row++)
                {
                    string firstCellValue = range.Cells[row, 1].Value2.ToString();
                    // Nếu giá trị của ô đầu tiên trong hàng bằng với giá trị cần tìm kiếm
                    string kiTuTimkiem = nRandom[demCauHoi - 1];
                    if (firstCellValue == kiTuTimkiem)
                    {
                        // Duyệt qua các ô trong hàng để lấy dữ liệu
                        for (int col = 2; col <= colCount; col++)
                        {
                            Ma = range.Cells[row, 1].Value2.ToString();
                            dapan1 = range.Cells[row, 2].Value2.ToString();
                            dapan2 = range.Cells[row, 3].Value2.ToString();
                            KituFault = range.Cells[row, 5].Value2.ToString();
                            hinh = range.Cells[row, 6].Value2.ToString();
                            comp = range.Cells[row, 7].Value2.ToString();
                            // Xử lý dữ liệu tìm được ở đây
                        }
                        break; // Thoát khỏi vòng lặp nếu đã tìm thấy hàng cần tìm kiếm
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
            }
            finally
            {
                // Đóng tập tin Excel và giải phóng bộ nhớ
                workbook.Close(false);
                excel.Quit();
                Marshal.ReleaseComObject(range);
                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excel);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            // Gửi mã đi để tạo fault ở phần cứng
            guiMaFault(KituFault);
            //MessageBox.Show("da~ gui ma tao fault chuong " + a.ToString() + " loi " + Ma);
            string[] dsDA = comp.Split(',');

            // hien thi len giao dien 
            chlst_comp.Items.Clear();
            chlst_comp.Items.AddRange(dsDA);
            pictureBox1.Image = new Bitmap(System.Windows.Forms.Application.StartupPath + hinh);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Show();

        }

        private void guiMaFault(string ft)
        {
            serialPort1.Open();
            serialPort1.Write(ft);
            serialPort1.Close();
        }
        private void formExam_Load(object sender, EventArgs e)
        {
            // Kết nối với phần cứng (arduino)
            serialPort1.PortName = LoginStudent.tenCOM;
            serialPort1.BaudRate = LoginStudent.giatribaudrate;

            // modify things
            label4.Visible = false;
            button2.Visible = false;
            btnNutDapAn.Visible = false;
            chlst_comp.Visible = false; 
            chlst_fault.Visible = false;
            chlst_comp.Items.Clear();
            pictureBox1.Visible = false;
            btnNutTaoFault.Visible = false;
        }
        
    }
}
