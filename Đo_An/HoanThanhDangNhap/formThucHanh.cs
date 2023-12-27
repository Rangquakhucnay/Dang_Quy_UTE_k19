using MathNet.Numerics;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HoanThanhDangNhap
{
    public partial class formThucHanh : Form
    {
        public formThucHanh()
        {
            InitializeComponent();
        }

        // Bảng để dò tên chương sử dụng mảng 2 chiều
        string[,] lookupTable_Chuong = new string[,]
        {
            { "Chương 1:","CẢM BIẾN ĐO GIÓ DÂY NHIỆT" },
            { "Chương 2:", "CẢM BIẾN KARMAN SIÊU ÂM" },
            { "Chương 3:", "CẢM BIẾN ĐO GIÓ VAN TRƯỢT" },
            { "Chương 4:", "CẢM BIẾN CHÂN KHÔNG" },
            { "Chương 5:", "CẢM BIẾN NE" },
            { "Chương 6:", "CẢM BIẾN NHIỆT ĐỘ" },
            { "Chương 7:", "BƯỚM GA TUYẾN TÍNH CÓ IDL" },
            { "Chương 8:", "BƯỚM GA TIÊP ĐIỂM" },
            { "Chương 9:", "BƯỚM GA TUYẾN TÍNH KHÔNG CÓ IDL" },
            { "Chương 10:", "CẢM BIẾN VỊ TRÍ BÀN ĐẠP GA" },
            { "Chương 11:", "HỆ THỐNG BƠM NHIÊN LIỆU" },
            { "Chương 12:", "HỆ THỐNG ĐÁNH LỬA" },
            { "Chương 13:", "HỆ THỐNG PHUN XĂNG" },
            { "Chương 14:", "HỆ THỐNG ĐIỀU KHIỂN BƯỚM GA" },
           
            // và tiếp tục với các cặp khác...
        };


        // Thư viện lỗi
        Dictionary<string, string[]> faultCDictionary = new Dictionary<string, string[]>()
        {
            { "faultC1", new string[] { "01", "02" } },
            { "faultC2", new string[] { "03", } },
            { "faultC3", new string[] {  "05", "04" } },
            { "faultC4", new string[] { "06" } },
            { "faultC5", new string[] { "07" } },
            { "faultC6", new string[] { "08","09" } },
            { "faultC7", new string[] { "10" } },
            { "faultC8", new string[] { "11" } },
            { "faultC9", new string[] { "12" } },
            { "faultC10", new string[] { "13" } },
            { "faultC11", new string[] { "14","15","16" } },
            { "faultC12", new string[] { "17" } },
            { "faultC13", new string[] { "18"} },
            { "faultC14", new string[] { "19", "20" } },
        

           
        };

        // các biến để lưu kí tự excel lấy được
        string KituFault, Ma;
        string comp1, comp2, comp3, comp4, comp5, comp6, comp7, comp8, comp9, comp10;
        string dapan1, dapan2, hinh;

        // các biến để tạo lỗi
        string[] nRandom;
        string[] faultCArray;
        int dem = 0;
        int soCauhoiMax = 10;

        private void formThucHanh_Load(object sender, EventArgs e)
        {
            // kết nối phần cứng
            serialPort1.PortName = LoginStudent.tenCOM;
            serialPort1.BaudRate = LoginStudent.giatribaudrate;


            // modify things
            lblTenChuong.Visible = false;
            btnNutDapAn.Visible = false;
            chlst_comp.Visible = false;
            chlst_fault.Visible = false;
            chlst_comp.Items.Clear();

        }
        private void guiMaFault(string ft)// gửi ký tự bất kỳ xuống arduino để đọc /////////////////////////////////
        {
            serialPort1.Open();
            serialPort1.Write(ft);
            serialPort1.Close();
        }
        private void LoadHinhvaComp() 
        {
           string chuong = cbChuong.Text;

            // Khai báo đối tượng Excel
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excel.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\Resources\\Du lieu cau hoi\\thu vien comp.xlsx");
            Worksheet worksheet = workbook.Sheets[1]; // Worksheet worksheet = workbook.Sheets["Tên sheet"];
            Range range = worksheet.UsedRange;

            // Lấy số hàng và số cột của tập tin Excel
            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;

            // Duyệt qua các hàng trong tập tin Excel để tìm kiếm dữ liệu
            for (int row = 1; row <= rowCount; row++)
            {
                string firstCellValue = range.Cells[row, 1].Value2.ToString();
                // Nếu giá trị của ô đầu tiên trong hàng bằng với giá trị cần tìm kiếm
                if (firstCellValue == chuong)
                {
                    // Duyệt qua các ô trong hàng để lấy dữ liệu
                    for (int col = 2; col <= colCount; col++)
                    {
                        comp1 = range.Cells[row, 2].Value2.ToString();
                        comp2 = range.Cells[row, 3].Value2.ToString();
                        comp3 = range.Cells[row, 4].Value2.ToString();
                        comp4 = range.Cells[row, 5].Value2.ToString();
                        comp5 = range.Cells[row, 6].Value2.ToString();
                        comp6 = range.Cells[row, 7].Value2.ToString();
                        comp7 = range.Cells[row, 8].Value2.ToString();
                        comp8 = range.Cells[row, 9].Value2.ToString();      
                        comp9 = range.Cells[row,10].Value2.ToString();
                        comp10 = range.Cells[row,11].Value2.ToString();
                        

                        hinh  = range.Cells[row,12].Value2.ToString();
                        // Xử lý dữ liệu tìm được ở đây
                    }
                    break; // Thoát khỏi vòng lặp nếu đã tìm thấy hàng cần tìm kiếm
                }
            }
            // Đóng tập tin Excel
            workbook.Close(true, Type.Missing, Type.Missing);
            excel.Quit();
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(excel);

            // xu ly danh sach comp
            string[] comps = { comp1, comp2, comp3, comp4, comp5, comp6, comp7, comp8, comp9, comp10 };// vị trí có thể xảy ra lỗi!!
            List<string> danhSachChuoi = new List<string>();
            foreach (string comp in comps)
            {
                if (comp != "0")
                {
                    danhSachChuoi.Add(comp);
                }
            }
            chlst_comp.Items.Clear();
            string[] dsDA = danhSachChuoi.ToArray();

            // hien thi len giao dien 
            chlst_comp.Items.AddRange(dsDA);// dồn câu hỏi để hiển thị ra checklistbox      
            pictureBox1.Image = new Bitmap(System.Windows.Forms.Application.StartupPath + hinh);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Show();
        }


        void TaoFault()
        {
            if (cbChuong.Text != "")
            {

                // lấy tên chương để mở sheet 
                int a = int.Parse(cbChuong.Text);
                if (dem == soCauhoiMax) { dem = 1; }
                else
                {
                    dem++;
                }
           

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
            for (int row = 1; row <= rowCount; row++)
            {
                string firstCellValue = range.Cells[row, 1].Value2.ToString();
                // Nếu giá trị của ô đầu tiên trong hàng bằng với giá trị cần tìm kiếm
                string kiTuTimkiem = nRandom[dem - 1];
                if (firstCellValue == kiTuTimkiem)
                {
                    // Duyệt qua các ô trong hàng để lấy dữ liệu
                    for (int col = 2; col <= colCount; col++)
                    {
                        Ma = range.Cells[row, 1].Value2.ToString();
                        dapan1 = range.Cells[row, 2].Value2.ToString();
                        dapan2 = range.Cells[row, 3].Value2.ToString();
                        KituFault = range.Cells[row, 5].Value2.ToString();
                        // Xử lý dữ liệu tìm được ở đây
                    }
                    break; // Thoát khỏi vòng lặp nếu đã tìm thấy hàng cần tìm kiếm
                }
            }
            // Đóng tập tin Excel
            workbook.Close(true, Type.Missing, Type.Missing);
            excel.Quit();
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(excel);

            // Gửi mã đi để tạo fault ở phần cứng @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            guiMaFault(KituFault);
            MessageBox.Show("Đã gửi mã tạo fault chuong " + a.ToString() + " loi " + Ma);// mơi thay ///////////////////////////////

            }
            else
            {
                MessageBox.Show("vui lòng chon chương","Thông Báo",MessageBoxButtons.OK);
            }
        }// tới đay rồi

        private void cbChuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            // code de hien thi ten chuong va nActi
            string tenChuong = "Chương " + cbChuong.Text + ":";
            string value = null;

            for (int i = 0; i < lookupTable_Chuong.GetLength(0); i++)
            {
                if (lookupTable_Chuong[i, 0] == tenChuong)
                {
                    value = lookupTable_Chuong[i, 1];
                    break;
                }
            }

            lblTenChuong.Visible = true;
            lblTenChuong.Text = value;
            lblTenChuong.AutoSize = true;
            lblTenChuong.MaximumSize = new Size(220, 0); // 0 để setting chiều cao là không giới hạn
            lblTenChuong.TextAlign = ContentAlignment.MiddleCenter;

            // load câu hỏi và câu trả lời 
            LoadHinhvaComp();

            // load fault 
            LoadFault();
        }

        private void LoadFault()
        {
            // load các fault của chương đã chọn trước đó
            // Lấy ten chuong từ combobox
            int a = int.Parse(cbChuong.Text);

            // Lấy tên chuỗi cần truy cập dựa trên giá trị của a
            string faultCName = "faultC" + a;

            // Lấy mảng chuỗi tương ứng từ từ điển
            faultCArray = faultCDictionary[faultCName];

            nRandom = new string[soCauhoiMax];

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

                int randomIndex = random.Next(0, faultCArray.Length); // tạo một số ngẫu nhiên từ 0 đến fault.Length - 1//
              /*  random là một đối tượng của lớp Random trong C#, được sử dụng để tạo số ngẫu nhiên.
.Next(0, faultCArray.Length) là một phương thức của đối tượng random, được sử dụng để tạo một số nguyên ngẫu nhiên nằm trong khoảng từ 0 đến faultCArray.Length - 1.*/




                nRandom[i] = faultCArray[randomIndex];               // lấy giá trị tại vị trí ngẫu nhiên trong dãy fault và gán vào vị trí i trong dãy mới nRan

                faultCArray = faultCArray.Where((val, idx) => idx != randomIndex).ToArray(); // loại bỏ giá trị đã được chọn khỏi dãy fault
            }
        }

        private void chlst_comp_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Đảm bảo rằng chỉ có một mục được chọn
            for (int i = 0; i < chlst_comp.Items.Count; ++i)
            {
                if (i != e.Index)
                {
                    chlst_comp.SetItemChecked(i,false );
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
                    chlst_fault.SetItemChecked(i, false);// setItermchecked : xem thằng nào có tính hiệu Index dc chọn ở ngoài chlst_fault thì hiện ra
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void formThucHanh_FormClosing(object sender, FormClosingEventArgs e)
        {
           // guiMaFault("x");
           // MessageBox.Show("het fault");// moi sua lại ////////////////////////////////
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnNutDapAn_Click_1(object sender, EventArgs e)
        {
            KiemTraDapAn();
            guiMaFault("x");
            MessageBox.Show("het fault");// moi sủa lại ......................................
            chlst_comp.Visible = false;
            chlst_fault.Visible = false;
            btnNutDapAn.Visible = false;
            btnNutTaoFault.Enabled = true;
        }

        private void formThucHanh_FormClosed(object sender, FormClosedEventArgs e)
        {
                
        }

        private void btnNutTaoFault_Click(object sender, EventArgs e)
        {
            chlst_comp.Visible = true;
            TaoFault(); 
            btnNutTaoFault.Enabled = true;
        }
        private void KiemTraDapAn()
        {
            // kiem tra dap an 
            int checkedAns1 = int.Parse(dapan1);
            int checkedAns2 = int.Parse(dapan2);
                        if (chlst_comp.GetItemChecked(checkedAns1) == true  && chlst_fault.GetItemChecked(checkedAns2) == true )
            {
                MessageBox.Show("Đáp án Đúng");
            }
            else { MessageBox.Show("Đáp án Sai"); }
            XoaCheck();
        }

        private void CheckToHienthi()
        {
            if (chlst_comp.CheckedItems.Count > 0) //có ít nhất một mục được chọn trong chlst_comp thì mới hiển thị ra chlst_fault
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

        private void chlst_comp_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckToHienthi();

        }

        private void chlst_fault_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckToHienthiNutOK();
        }
    }
}
