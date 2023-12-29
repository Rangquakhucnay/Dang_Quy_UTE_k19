using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoanThanhDangNhap
{
    public partial class formHienThiBaiHoc : Form
    {
        // Khai báo các giá trị sử dụng



        // 1. sử dụng cho hiển thị bài học
        string dapanA = "", dapanB = "", dapanC = "";
        string cauhoi = "khong lam dc", baihoc = "", hinhAnh = "";
        string hide = "0", fault = "", answer = "";
        string video = "";
        string faultTruoc = "0";

        int nonNullRowCount = 0;
        string rowEND;

        // cac bien hien thi panel wiring
        private int currentImageIndex = 1;
        private int maxImageIndex;
        private int buttonCount;

        // cac bien hien thi panel video

        private int currentImageIndexVideo = 1;
        private int maxImageIndexVideo;
        private int buttonCountVideo;
        public formHienThiBaiHoc()
        {
            InitializeComponent();
            double scale = 0.95; // Thiết lập tỷ lệ kích thước của Form so với kích thước màn hình
            Screen screen = Screen.PrimaryScreen;
            int width = (int)(screen.Bounds.Width * scale);
            int height = (int)(screen.Bounds.Height * scale);
            this.Size = new Size(width, height);
        }
        int chuong = int.Parse(formDiToiBaiHoc.sttChuongBaiHoc);
        int nActi = int.Parse(formDiToiBaiHoc.SoActi);
        int nQT = formDiToiBaiHoc.TiendoActi;

        //
        private void formHienThiBaiHoc_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = LoginStudent.tenCOM;
            serialPort1.BaudRate = LoginStudent.giatribaudrate;
            //
            panelWiring.Visible = false;// ẩn panel wiring lúc bật lên
            panelVideo.Visible = false; //panel Video hiển thị bài học
                                        //groupBox1.Visible =false

            //-------------------------------------------------------------------------fix
            if (nActi == 1)
            {

                LaySoHinh();  //lấy số hình của panel wiring
                HienThiBaiHoc(2);
                HienThiWiring();
                panelWiring.Visible = true;
                panelWiring.BringToFront();
                btnOK.Enabled = false;
            }
            else 
            {
                panelWiring.Visible = false;
                panelWiring.SendToBack();
                HienThiBaiHoc(nActi);
            }

            TaoVaXuLyNut(nonNullRowCount - 1); // hiển thị số acti

            HienThiBaiDaHoc(nQT);               // hiển thị các bài đã học bằng cách tô đậm
        }
        private void HienThiWiring()
        {
            panelWiring.Visible = true;
            LoadImage(currentImageIndex);
            LoadButtonsWiring(currentImageIndex, buttonCount);
            picChe.BringToFront(); //pic che hiện lên để che cái chỗ câu hỏi
        }
        private void HienThiGroupBox()
        {
            panelWiring.Visible = true;
           // LoadImage(currentImageIndex);
           // LoadButtonsWiring(currentImageIndex, buttonCount);
            picChe.BringToFront(); //pic che hiện lên để che cái chỗ câu hỏi

        }
        
        private void LaySoHinh()
        {
            string folderPath = System.Windows.Forms.Application.StartupPath + "\\Resources\\Wiring\\" + $"wiring_c{chuong}";
            maxImageIndex = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories).Length;
            buttonCount = 7;
        }

        private void LoadImage(int index)
        {
            int chuong = int.Parse(formDiToiBaiHoc.sttChuongBaiHoc);
            string fileName = System.Windows.Forms.Application.StartupPath + "\\Resources\\Wiring\\" + $"wiring_c{chuong}" + "\\" + $"hinh{index}.png";
            pictureBox2.Image = Image.FromFile(fileName);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LoadButtonsWiring(int currentIndex, int count)
        {
            int halfCount = count / 2;
            int startIndex = currentIndex - halfCount;
            if (startIndex < 1)
            {
                startIndex = 1;
            }
            int endIndex = startIndex + count - 1;
            if (endIndex > maxImageIndex)
            {
                endIndex = maxImageIndex;
                startIndex = endIndex - count + 1;
                if (startIndex < 1)
                {
                    startIndex = 1;
                }
            }

            flowLayoutPanel1.Controls.Clear();
            for (int i = startIndex; i <= endIndex; i++)
            {
                int buttonIndex = i - startIndex;
                System.Windows.Forms.Button button = new System.Windows.Forms.Button();
                button.Text = i.ToString();
                button.Size = new Size(35, 35);
                if (i == currentIndex)
                {
                    button.BackColor = Color.Silver;
                }
                button.Click += (sender, e) =>
                {
                    System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
                    int index = int.Parse(clickedButton.Text);
                    currentImageIndex = index;
                    LoadImage(currentImageIndex);
                    LoadButtonsWiring(currentImageIndex, buttonCount);
                };
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void LoadButtonsVideo(int currentIndexVideo, int countVideo)
        {
            int halfCountVideo = countVideo / 2;
            int startIndexVideo = currentIndexVideo - halfCountVideo;
            if (startIndexVideo < 1)
            {
                startIndexVideo = 1;
            }
            int endIndexVideo = startIndexVideo + countVideo - 1;
            if (endIndexVideo > maxImageIndexVideo)
            {
                endIndexVideo = maxImageIndexVideo;
                startIndexVideo = endIndexVideo - countVideo + 1;
                if (startIndexVideo < 1)
                {
                    startIndexVideo = 1;
                }
            }

            for (int i = startIndexVideo; i <= endIndexVideo; i++)
            {
                int buttonIndexVideo = i - startIndexVideo;
                System.Windows.Forms.Button button = new System.Windows.Forms.Button();
                button.Text = i.ToString();
                button.Size = new Size(30, 30);            
                if (i == currentIndexVideo)
                {
                    button.BackColor = Color.Silver;
                }
                button.Click += (sender, e) =>
                {
                    System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
                    int index = int.Parse(clickedButton.Text);
                    currentImageIndexVideo = index;
                    LoadImageVideo(currentImageIndexVideo);
                    LoadButtonsVideo(currentImageIndexVideo, buttonCountVideo);
                };
            }
        }
        private void TaoVaXuLyNut(int dodai)
        {
            // Tạo các nút mới
            for (int i = 1; i <= dodai; i++)
            {
                System.Windows.Forms.Button button2 = new System.Windows.Forms.Button();
                button2.Size = new Size(62, 40);         // ( chọn cac câu bên phải 1-26)
                button2.Text = (i).ToString();
                button2.Name = "nut" + i.ToString();
                button2.Click += new EventHandler(Nut_Click);
                button2.Enabled = false;
                flowLayoutPanel2.Controls.Add(button2);
                if (i % 2 == 0) // Chuyển sang hàng mới sau mỗi 2 nút
                {
                    flowLayoutPanel2.SetFlowBreak(button2, true);
                }
            }
        }

        private void HienThiBaiDaHoc(int v)// tô đậm giá trị câu đã làm 
        {
            // Lấy danh sách các nút hiển thị trên flowLayoutPanel2
            var buttons = flowLayoutPanel2.Controls.OfType<System.Windows.Forms.Button>().ToList();

            // Đặt thuộc tính "Enabled" cho v nút đầu tiên là "true"
            Color customColor = Color.FromArgb(110, 172, 183);

            for (int i = 0; i <= (v-1) && i < buttons.Count; i++)
            {
                buttons[i].BackColor = customColor;
                buttons[i].Enabled = true;
            }

        }

        private void HienthiKhinhanOK(int v)
        {
            // Lấy danh sách các nút hiển thị trên flowLayoutPanel2
            var buttons = flowLayoutPanel2.Controls.OfType<System.Windows.Forms.Button>().ToList();
            // định nghĩa một màu tùy chỉnh (customColor) sử dụng giá trị mã màu RGB.
            Color customColor = Color.FromArgb(110, 172, 183);
            // Kiểm tra v có giá trị hợp lệ trong khoảng từ 1 đến số lượng nút
            if (v > 0 && v <= buttons.Count)
            {
                // Đặt màu nút vừa chọn thành màu tùy chỉnh
                buttons.ElementAt(v - 1).BackColor = customColor;
                // Kích hoạt nút vừa chọn
                buttons.ElementAt(v - 1).Enabled = true;
            }
        }
        private void Nut_Click(object sender, EventArgs e) 
        {
            // Lấy ra nút được nhấn
            System.Windows.Forms.Button nut = sender as System.Windows.Forms.Button;
            // Xử lý các hành động tùy ý ở đây
            // Lấy giá trị số nguyên từ chuỗi ký tự của nút
            string giaTriNutChuoi = nut.Text;
            string soNguyenStr = new String(giaTriNutChuoi.Where(Char.IsDigit).ToArray());
            int giaTriNutSoNguyen = int.Parse(soNguyenStr);
            Color customColor = Color.FromArgb(110, 172, 183);
            nut.BackColor = customColor;
            if (giaTriNutSoNguyen == 1) 
            {
                panelVideo.SendToBack();
              //  guiMaFault("x");
                HienThiWiring();
                panelWiring.Visible = true;
                panelWiring.BringToFront();
                hide = "1";
            }   
            else
            {
               //guiMaFault("x");
                HienThiBaiHoc(giaTriNutSoNguyen);
                btnOK.Enabled = true;
                panelWiring.Visible = false;
                panelWiring.SendToBack();
            }
            nActi = giaTriNutSoNguyen;  //set nActi về lại giá trị của cái nút mà mình bấm
            btnOK.Enabled = true;
            NextPicVideo.Enabled = true;
            PrevPicVideo.Enabled = true;
            buttonLeft.Enabled = true;
            buttonRight.Enabled = true;
        }

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        
        private void HienThiBaiHoc(int v)
        {
            panelWiring.Visible = false;
            string str = v.ToString();
            string chuong = formDiToiBaiHoc.sttChuongBaiHoc;

            // Khai báo đối tượng Excel
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excel.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\Resources\\Du lieu cau hoi\\thu vien bai hoc.xlsx");
            Worksheet worksheet = workbook.Sheets[chuong];// Worksheet worksheet = workbook.Sheets["Tên sheet"];
            Range range = worksheet.UsedRange;

            // Lấy số hàng và số cột của tập tin Excel
            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;

            // Lấy giá trị của các ô trong phạm vi
            object[,] values = range.Value2;

            // Đếm số hàng có giá trị khác null
            for (int i = 1; i <= rowCount; i++)
            {
                bool hasNonNullValue = false;
                for (int j = 1; j <= colCount; j++)
                {
                    if (values[i, j] != null)
                    {
                        hasNonNullValue = true;
                        break;
                    }
                }
                if (hasNonNullValue)
                {
                    nonNullRowCount++; // =27 của chương1
                }
                bt1.Text = nonNullRowCount.ToString();//-----------------------------------------------------fix
            }
            ////////////////

            // Duyệt qua các hàng trong tập tin Excel để tìm kiếm dữ liệu
            for (int row = 1; row <= nonNullRowCount; row++)
            {
                string firstCellValue = range.Cells[row, 1].Value2.ToString();
                rowEND = range.Cells[row + 1, 1].Value2.ToString();
                // Nếu giá trị của ô đầu tiên trong hàng bằng với giá trị cần tìm kiếm
                if (firstCellValue == str)
                {
                    // Duyệt qua các ô trong hàng để lấy dữ liệu
                  // for (int col = 2; col <= colCount; col++)
                  //  {
                        video = range.Cells[row, 2].Value2.ToString();
                        hinhAnh = range.Cells[row, 3].Value2.ToString();
                        baihoc = range.Cells[row, 4].Value2.ToString();
                        hide = range.Cells[row, 5].Value2.ToString();
                        cauhoi = range.Cells[row, 6].Value2.ToString();
                        dapanA = range.Cells[row, 7].Value2.ToString();
                        dapanB = range.Cells[row, 8].Value2.ToString();
                        dapanC = range.Cells[row, 9].Value2.ToString();
                        answer = range.Cells[row, 10].Value2.ToString();
                        fault = range.Cells[row, 11].Value2.ToString();
                        

                        //
                        if (row > 2)
                        {
                            faultTruoc = range.Cells[row - 1, 11].Value2.ToString();
                        }
                        //

                        // Xử lý dữ liệu tìm được ở đây
                  //  }
                    break; // Thoát khỏi vòng lặp nếu đã tìm thấy hàng cần tìm kiếm
                }
                if (rowEND == "END")
                {
                    MessageBox.Show("Bạn đã hoàn thành bài học");
                    nActi = row;
                    this.Hide();
                    formDiToiBaiHoc f = new formDiToiBaiHoc();
                    f.ShowDialog();
                    this.Close();

                    return;
                }
                else if (rowEND == "ENDEND")
                {
                    MessageBox.Show("Bạn đã hoàn thành bài học");
                    nActi = row;
                    this.Close();
                    return;
                }
            }
            // Đóng tập tin Excel và giải phóng các tài nguyên
            workbook.Close(true, Type.Missing, Type.Missing);
            excel.Quit();
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(excel);

            // Hien thi du lieu len form 
           /*
            if (fault != "0")           // phast hien co fault thi` gui di ne`
            {
                if (fault == faultTruoc)
                {
                    guiMaFault(fault);
                    //MessageBox.Show("a");
                }
                else
                {
                    if (faultTruoc != "0")
                    {
                        guiMaFault("x");
                        //MessageBox.Show("xoa loi");
                        guiMaFault(fault);
                        //MessageBox.Show("a");
                    }
                    else
                    {
                        guiMaFault(fault);
                        //MessageBox.Show("a");
                    }
                }
            }
            else        // neu khong co thi` gui ma fault xoa fault
            {
                guiMaFault("x");
            }*/

            //---------------------------------------------------------------------------------------
            if (int.Parse(video) != 0)
            {
                panelVideo.Visible = true;
                panelVideo.BringToFront();
                currentImageIndexVideo = 1;
                HienThiVideo();
                btnOK.Enabled = false;
            }
            else
            {
                panelVideo.SendToBack();
                panelVideo.Visible = false;
                btnOK.Enabled = true;
            }

            /*   if (int.Parse(box) != 0)
               {
                  GroupBox1.Visible = true;
                   GroupBox1.BringToFront();


                   btnOK.Enabled = true;
               }
               else
               {
                   GroupBox1.SendToBack();
                   GroupBox1.Visible = false;
                   btnOK.Enabled = true;
               }
            */
            if (int.Parse(hide) == 1)
            {
                picChe.BringToFront();
                pictureBox1.Image = new Bitmap(System.Windows.Forms.Application.StartupPath + hinhAnh);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Show();
                rtb_Baihoc.Clear();
                rtb_Baihoc.Text = baihoc;
            }
            else
            {
                picChe.SendToBack();
                pictureBox1.Image = new Bitmap(System.Windows.Forms.Application.StartupPath + hinhAnh);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Show();
                rtb_Baihoc.Clear();
                rtb_Baihoc.Text = baihoc;
                txtQues.Text = cauhoi;
                chlstDapAn.Items.Clear();

                string[] dsDA = { dapanA, dapanB, dapanC };
                chlstDapAn.Items.AddRange(dsDA);
            }
        }

        private void HienThiVideo()
        {
            // lấy số hình có trong video đó
            string folderPath = System.Windows.Forms.Application.StartupPath + "\\Resources\\VideoCacChuong\\" + $"chuong{chuong}\\" + $"video{video}";
            maxImageIndexVideo = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories).Length;
            buttonCountVideo = 7; // số nút hiển thị là 7

            // hiển thị hình ảnh video
            LoadImageVideo(currentImageIndexVideo);

        }

        private void LoadImageVideo(int index)
        {
            string fileName = System.Windows.Forms.Application.StartupPath + "\\Resources\\VideoCacChuong\\" + $"chuong{chuong}\\" + $"video{video}\\" + $"hinh{index}";
            string imagePath = Path.ChangeExtension(fileName, ".png");
            string gifPath = Path.ChangeExtension(fileName, ".gif");    // check xem có đuôi là gif hay png

            if (File.Exists(imagePath))
            {
                picPanelVideo.Image = Image.FromFile(imagePath);
            }
            else if (File.Exists(gifPath))
            {
                picPanelVideo.Image = Image.FromFile(gifPath);
            }

            picPanelVideo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void formHienThiBaiHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
           // guiMaFault("x");
            LuuTiendo();
            //MessageBox.Show("đã lưu");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // guiMaFault("x");
            this.Close();
        }

        private void chlstDapAn_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Đảm bảo rằng chỉ có một mục được chọn
            for (int i = 0; i < chlstDapAn.Items.Count; ++i)
            {
                if (i != e.Index)
                {
                    chlstDapAn.SetItemChecked(i, false);
                }
            }
        }

        private void PrevPicVideo_Click(object sender, EventArgs e)
        {
            if (currentImageIndexVideo > 1)
            {
                currentImageIndexVideo--;
                LoadImageVideo(currentImageIndexVideo);
                LoadButtonsVideo(currentImageIndexVideo, buttonCountVideo);
                NextPicVideo.Enabled = true;
            }
            if (currentImageIndexVideo == 1)
            {
                PrevPicVideo.Enabled = false;
            }
            
        }

        private void NextPicVideo_Click(object sender, EventArgs e)
        {
            if (currentImageIndexVideo < maxImageIndexVideo)
            {
                currentImageIndexVideo++;
                LoadImageVideo(currentImageIndexVideo);
                LoadButtonsVideo(currentImageIndexVideo, buttonCountVideo);
                PrevPicVideo.Enabled = true;
            }
            if (currentImageIndexVideo == maxImageIndexVideo)
            {
                NextPicVideo.Enabled = false;
                btnOK.Enabled = true;
            }
        }

        private void panelWiring_Paint(object sender, PaintEventArgs e)
        {

        }



        /*private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (currentImageIndexVideo > 1)
            {
                currentImageIndexVideo--;
                LoadImageVideo(currentImageIndexVideo);
                LoadButtonsVideo(currentImageIndexVideo, buttonCountVideo);
                NextPicVideo.Enabled = true;
            }
            if (currentImageIndexVideo == 1)
            {
                PrevPicVideo.Enabled = false;
                pictureBox3.Enabled = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (currentImageIndexVideo < maxImageIndexVideo)
            {
                currentImageIndexVideo++;
                LoadImageVideo(currentImageIndexVideo);
                LoadButtonsVideo(currentImageIndexVideo, buttonCountVideo);
                PrevPicVideo.Enabled = true;
            }
            if (currentImageIndexVideo == maxImageIndexVideo)
            {
                NextPicVideo.Enabled = false;
                pictureBox4.Enabled = false;
                btnOK.Enabled = true;
            }
        }
        */
        private void guiMaFault(string ft)
        {
            serialPort1.Open();
            serialPort1.Write(ft);
            serialPort1.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Bật nút chuyển ảnh lên
            PrevPicVideo.Enabled = true;
            NextPicVideo.Enabled = true;

            //-------------------------
            if (nActi == 1)
            {
                HienthiKhinhanOK(2);
                nActi++;
                HienThiBaiHoc(nActi);
            }
            else if (nActi > 1)
            {
                if (int.Parse(hide) == 1)
                {
                    nActi++;//3
                    HienThiBaiHoc(nActi);
                    HienthiKhinhanOK(nActi);
                }
                else if (int.Parse(hide) == 0)
                {
                    CheckDapAn();
                    HienThiBaiHoc(nActi);
                }
            }
        }
        private void CheckDapAn()
        {
            if (chlstDapAn.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đáp án");
                return;
            }
            else
            {
                if (chlstDapAn.GetItemChecked(int.Parse(answer)) == true)
                {
                    MessageBox.Show("Đáp án Đúng");
                }
                else { MessageBox.Show("Đáp án Sai"); }

                nActi++;

                if (nActi <= (nonNullRowCount - 3)) // vừa sửa lại -2
                {
                    HienthiKhinhanOK(nActi);
                }
            }
        }
        private void LuuTiendo()
        {
            SQLiteConnection conn = null;
            string strConn = string.Format(@"Data Source = {0}\DBLogin.db;Version=3;", System.Windows.Forms.Application.StartupPath);
            try
            {
                conn = new SQLiteConnection(strConn);
                conn.Open();

                string tendangnhapform1 = Properties.Settings.Default.TenDangNhapALL;
                string truycapCot = "nqtc" + chuong.ToString();
                int vitriCot = chuong + 5;

                SQLiteCommand command1 = new SQLiteCommand();
                command1.CommandType = CommandType.Text;
                command1.CommandText = "select * from ThongTinSinhVien where TenDangNhap=@tendn";
                command1.Connection = conn;
                command1.Parameters.AddWithValue("@tendn", tendangnhapform1);

                string lastTiendo = chuong.ToString() + "va" + nActi.ToString();
              
                SQLiteDataReader reader = command1.ExecuteReader();
                if (reader.Read())
                {

                    int nqtOLD = reader.GetInt32(vitriCot);
                    MessageBox.Show(nqtOLD.ToString());

                    int vitri = reader.GetInt32(0);
                    int nqt = 0;
                    if (nqtOLD < nActi)
                    {
                        nqt = nActi;

                        SQLiteCommand command = new SQLiteCommand();
                        command.CommandType = CommandType.Text;
                        command.CommandText = "update ThongTinSinhVien set " + truycapCot + "=@nqt where IDSV=@idsv";
                        command.Connection = conn;
                        command.Parameters.AddWithValue("@nqt", nqt);
                        command.Parameters.AddWithValue("@idsv", vitri);

                        int kq2 = command.ExecuteNonQuery();
                        /*if (kq > 0)
                        {
                            MessageBox.Show("Lưu tiến độ thành công!");
                            MessageBox.Show(nqt.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Lưu tiến độ thất bại!");
                        }*/
                    }
                    SQLiteCommand command2 = new SQLiteCommand();
                    command2.CommandType = CommandType.Text;
                    command2.CommandText = "update ThongTinSinhVien set lasttiendo=@ltd where IDSV=@idsv";
                    command2.Connection = conn;
                    command2.Parameters.AddWithValue("@idsv", vitri);
                    command2.Parameters.AddWithValue("@ltd", lastTiendo);
                    int kq = command2.ExecuteNonQuery();

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)  // nút tiến wiring
        {
            if (currentImageIndex < maxImageIndex)
            {
                currentImageIndex++;
                LoadImage(currentImageIndex);
                LoadButtonsWiring(currentImageIndex, buttonCount);
                buttonLeft.Enabled = true;
                buttonRight.Enabled = true;
            }
            if (currentImageIndex == maxImageIndex)
            {
                buttonLeft.Enabled = false;
                btnOK.Enabled = true;
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)  // nút lùi wiring
        {
            if (currentImageIndex > 1)
            {
                currentImageIndex--;
                LoadImage(currentImageIndex);
                LoadButtonsWiring(currentImageIndex, buttonCount);
                buttonRight.Enabled = true;
                buttonLeft.Enabled = true;
            }
            if (currentImageIndex == 1)
            {
                buttonRight.Enabled = false;
            }
        }
    }
}
//private void HienThiWiring() 2
//private void LaySoHinh() 1
//private void LoadImage(int index) 4
//private void LoadButtonsWiring(int currentIndex, int count) 4
//private void LoadButtonsVideo(int currentIndexVideo, int countVideo) 3
//private void TaoVaXuLyNut(int dodai) 1
//private void HienThiBaiDaHoc(int v) 1
//private void HienthiKhinhanOK(int v) 3
//private void Nut_Click(object sender, EventArgs e) 1
//private void HienThiBaiHoc(int v) 6
//private void HienThiVideo() 1
//private void LoadImageVideo(int index) 4
//private void formHienThiBaiHoc_FormClosed(object sender, FormClosedEventArgs e) 1
//private void button3_Click(object sender, EventArgs e) 1
//private void chlstDapAn_ItemCheck(object sender, ItemCheckEventArgs e) 1
//private void PrevPicVideo_Click(object sender, EventArgs e)  1
//private void NextPicVideo_Click(object sender, EventArgs e) 1
// private void guiMaFault(string ft) 9
//private void btnOK_Click(object sender, EventArgs e) 1
// private void CheckDapAn() 1
//private void LuuTiendo() 1
//private void buttonLeft_Click(object sender, EventArgs e)  // nút tiến wiring 1 
// private void buttonRight_Click(object sender, EventArgs e)  // nút lùi wiring 1

