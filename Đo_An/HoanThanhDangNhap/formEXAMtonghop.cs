using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoanThanhDangNhap
{
    public partial class formEXAMtonghop : Form
    {
        public formEXAMtonghop()
        {
            InitializeComponent();
            this.Size = new Size(1200, 1050);
           

        }

        // Các biến để tính điểm
        int nCauhoi = 0;
        int nDung = 0;
        int demCauHoi = 0;

        static List<int> lstQuesRand = new List<int>(50);
        private static Random rand = new Random();
        private static List<int> lstTemp = new List<int>();

        string KituFault, Ma, ChuongExcel;
        string dapan1, dapan2, hinh1 ,hinh2;
        string yeucau1,yeucau2;
        string comp1,comp2; 

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
                btTieptuc.Visible = true;
                pictureBox2.Visible = false;
                
            }
            else
            {
                // Tiến hành chấm điểm
                DiemSo();
                nCauhoi = 0;
                nDung = 0;
                demCauHoi = 0;
                cbSoCauHoi.Text = "";

                // modify things
               
                pictureBox1.Visible = false;
                pictureBox2 .Visible = false;

                chlst_comp.Visible = false;
                chlst_fault.Visible = false;

                btnNutTaoFault.Visible = false;
                btnNutTaoFault.Text = "Tạo fault";
                btnNutDapAn.Visible = false;

               // btnNutTaoFault.Enabled = true;
                btTaode.Enabled = true;
                btTieptuc.Visible = false;
                btTaode.Visible = true;

                rtb_Yeucau.Clear();
            }
            btnNutDapAn.Enabled = false;
        }

        private void btnNutTaoFault_Click(object sender, EventArgs e)
        {
            lbYeucau.Visible = true;
            btNopbai.Visible = true;
            demCauHoi = 1;
            btnNutTaoFault.Text = "Câu 1";
            pictureBox1.Visible = true;
            btnNutTaoFault.Enabled = false;
            chlst_comp.Visible = true;
            taoSocauhoiNgaunhien();
            TaoFault();
            //btnNutTaoFault.Visible= false;  
       
            btTaode.Visible = false;
            btTieptuc.Visible = true;
           


        }
        private void btTieptuc_Click(object sender, EventArgs e)
        {
           
            btTieptuc.Visible=false;
            LoadHinh();
            pictureBox2.Visible = true;
        }

        private void LoadHinh() // lấy danhsachchuoi comp đẩy vào trong checklistBox////// bỏ
        {
            // Khai báo đối tượng Excel
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excel.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\Resources\\Du lieu cau hoi\\Thu vien tong hop fault.xlsx");
            Worksheet worksheet = workbook.Sheets[1]; // Worksheet worksheet = workbook.Sheets["Tên sheet"];
            Range range = worksheet.UsedRange;

            // Lấy số hàng và số cột của tập tin Excel
            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;

            // Duyệt qua các hàng trong tập tin Excel để tìm kiếm dữ liệu
            for (int row = 1; row <= rowCount; row++)
            {
                string firstCellValue = range.Cells[row, 2].Value2.ToString();
                // Nếu giá trị của ô đầu tiên trong hàng bằng với giá trị cần tìm kiếm
                string kiTuTimkiem = lstQuesRand[demCauHoi - 1].ToString();
                if (firstCellValue == kiTuTimkiem)
                {
                    // Duyệt qua các ô trong hàng để lấy dữ liệu
                    for (int col = 2; col <= colCount; col++)
                    {


                        Ma = range.Cells[row, 3].Value2.ToString();
                        KituFault = range.Cells[row, 4].Value2.ToString();
                        dapan1 = range.Cells[row, 5].Value2.ToString();
                        dapan2 = range.Cells[row, 6].Value2.ToString();

                        hinh1 = range.Cells[row, 7].Value2.ToString();
                        hinh2 = range.Cells[row, 8].Value2.ToString();

                        comp1 = range.Cells[row, 9].Value2.ToString();
                       

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

            //  xu ly danh sach comp
            // string[] dsDA = comp.Split(',');
            // hien thi len giao dien 
            // chlst_comp.Items.Clear();
            // chlst_comp.Items.AddRange(dsDA);
            pictureBox2.Image = new Bitmap(System.Windows.Forms.Application.StartupPath + hinh2);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Show();
            rtb_Yeucau.Clear();
            string textToAdd = yeucau2;
            rtb_Yeucau.AppendText(textToAdd);
        }

        private void TaoFault()
        {
            // Khai báo đối tượng Excel
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excel.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\Resources\\Du lieu cau hoi\\Thu vien tong hop fault.xlsx");
            Worksheet worksheet = workbook.Sheets[1]; // Worksheet worksheet = workbook.Sheets["Tên sheet"];
            Range range = worksheet.UsedRange;

            // Lấy số hàng và số cột của tập tin Excel
            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;

            // Duyệt qua các hàng trong tập tin Excel để tìm kiếm dữ liệu
            for (int row = 1; row <= rowCount; row++)
            {
                string firstCellValue = range.Cells[row, 2].Value2.ToString();
                // Nếu giá trị của ô đầu tiên trong hàng bằng với giá trị cần tìm kiếm
                string kiTuTimkiem = lstQuesRand[demCauHoi - 1].ToString();
                if (firstCellValue == kiTuTimkiem)
                {
                    // Duyệt qua các ô trong hàng để lấy dữ liệu
                    for (int col = 2; col <= colCount; col++)
                    {
                      //  ChuongExcel = range.Cells[row, 1].Value2.ToString();
                        Ma = range.Cells[row, 3].Value2.ToString();
                        KituFault = range.Cells[row, 4].Value2.ToString();
                        dapan1 = range.Cells[row, 5].Value2.ToString();
                        dapan2 = range.Cells[row, 6].Value2.ToString();

                        hinh1 = range.Cells[row, 7].Value2.ToString();
                        hinh2 = range.Cells[row, 8].Value2.ToString();

                        
                        yeucau1 = range.Cells[row, 9].Value2.ToString();
                        yeucau2 = range.Cells[row, 10].Value2.ToString();
                        comp1 = range.Cells[row, 11].Value2.ToString();
                        comp2 = range.Cells[row, 12].Value2.ToString();
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
            string[] dsDA1 = comp1.Split(',');
            // hien thi len giao dien 
            chlst_comp.Items.Clear();
            chlst_comp.Items.AddRange(dsDA1);
            //---------------------------------

            string[] dsDA2 = comp2.Split(',');
            chlst_fault.Items.Clear();
            chlst_fault.Items.AddRange(dsDA2);

            pictureBox1.Image = new Bitmap(System.Windows.Forms.Application.StartupPath + hinh1);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Show();

          //  pictureBox1.Visible = true;
             guiMaFault(KituFault);
            MessageBox.Show( " loi " + Ma);// mơi thay ///////////////////////////////

            rtb_Yeucau.Clear();
            string textToAdd = yeucau1;
            rtb_Yeucau.AppendText(textToAdd);
        }
        //  LoadExcelTH();
        //MessageBox.Show("da~ gui ma tao fault chuong " + ChuongExcel.ToString() + " loi " + Ma);





        private void btNopbai_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn Nộp bài?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                DiemSo();
            }
            else { return; }
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

        private void formEXAMtonghop_FormClosing(object sender, FormClosingEventArgs e)
        {
            guiMaFault("x");
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

        private void DiemSo()
        {
            if (nDung > (nCauhoi / 2))
            {
                MessageBox.Show("Chúc mừng bạn đã ĐẠT trong bài kiểm tra!");
            }
            else { MessageBox.Show("KHÔNG ĐẠT! Hãy học tập tốt hơn vào lần tới nhé!"); }
            nDung = 0;
            demCauHoi = 1;

            // modify things
            btTaode.Enabled = true;
            btnNutTaoFault.Text = "Bắt đầu";
            chlst_comp.Visible = false;
            chlst_fault.Visible = false;
            btnNutDapAn.Visible = false;
            guiMaFault("x"); 
        }

       

        private void taoSocauhoiNgaunhien()
        {
            int n = 20; // Số phần tử cho trước
            int m = int.Parse(cbSoCauHoi.Text); // Số phần tử cần lấy ngẫu nhiên
            lstTemp.Clear(); // Xóa danh sách số ngẫu nhiên trước đó

            while (lstTemp.Count < m)
            {
                int num = rand.Next(n) + 1; // Tạo một số ngẫu nhiên từ 1 đến n         //int randomIndex = random.Next(0, faultCArray.Length); 
                if (!lstTemp.Contains(num)) // Kiểm tra số vừa tạo có tồn tại trong danh sách chưa
                {
                    lstTemp.Add(num); // Nếu chưa tồn tại, thêm số vào danh sách
                }
            }

            lstQuesRand = lstTemp; // Gán danh sách số ngẫu nhiên cho danh sách câu hỏi ngẫu nhiên
        }

        private void guiMaFault(string ft)
        {
            serialPort1.Open();
            serialPort1.Write(ft);
            serialPort1.Close();
        }

       
        private void btTaode_Click(object sender, EventArgs e)
        {
            btnNutTaoFault.BackColor = Color.White;
            if (cbSoCauHoi.Text == "")
            {
                MessageBox.Show("Vui lòng chọn số câu hỏi để tạo đề!","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else
            {
                //modify things

                btnNutTaoFault.Visible = true;
                btnNutTaoFault.Enabled = true;
                btTaode.Enabled = false;
                //  btTieptuc.Visible = false;
                nCauhoi = int.Parse(cbSoCauHoi.Text);
            }
            
        }

        private void formEXAMtonghop_Load(object sender, EventArgs e)
        {
            //Kết nối với phần cứng (arduino)
            serialPort1.PortName = LoginStudent.tenCOM;
            serialPort1.BaudRate = LoginStudent.giatribaudrate;

            // modify things
            lbYeucau.Visible = false;
            btNopbai.Visible = false;
            btnNutDapAn.Visible = false;
            chlst_comp.Visible = false;
            chlst_fault.Visible = false;
            chlst_comp.Items.Clear();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;    
            btnNutTaoFault.Visible = false;
            btTieptuc.Visible = false;
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

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
