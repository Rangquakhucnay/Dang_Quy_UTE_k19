﻿using Microsoft.Office.Interop.Excel;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using System.Diagnostics.Eventing.Reader;
using static System.Net.Mime.MediaTypeNames;

namespace HoanThanhDangNhap
{
    public partial class formHienThiBaiHoc3 : Form
    {
        // Khai báo các giá trị sử dụng

       

        // 1. sử dụng cho hiển thị bài học
        string dapanA = "", dapanB = "", dapanC = "", dapanD = "";
        string cauhoi = "khong lam dc", baihoc = "", hinhAnh = "";
        string hide = "0", fault = "", answer = "";
        string video = "";
        string faultTruoc = "";
        string box = "";
        
        string dien = "";
        string alldata = "";
        string madothi = "", tendothi = "";
        string chancb = "", check = "";

        string dapanhienthi;
        int nonNullRowCount = 0;
        string rowEND;
        int checka = 0;

        string dapandung="";

        string madau1, madau2, madau3, madau4;


        string giatri1, giatri2, giatri3, giatri4;

        string kk, dienabcd;
        string line1="", line2="";

        string VG, R_TH, t_TH ,TH;
        string chonloaitinhhieu;

        // cac bien hien thi panel wiring
        private int currentImageIndex = 1;
        private int maxImageIndex;
        private int buttonCount;

        // cac bien hien thi panel video

        private int currentImageIndexVideo = 1;
        private int maxImageIndexVideo;
        private int buttonCountVideo;
        public formHienThiBaiHoc3()
        {
            InitializeComponent();
           // InitializeGraph();
            double scale = 0.95; // Thiết lập tỷ lệ kích thước của Form so với kích thước màn hình
            Screen screen = Screen.PrimaryScreen;
            int width = (int)(screen.Bounds.Width * scale);
            int height = (int)(screen.Bounds.Height * scale);
            this.Size = new Size(width, height);
            Control.CheckForIllegalCrossThreadCalls = false; // phân luồng đồ thị
           // System .Windows.Forms.Timer.Mytimer = new System .Windows.Forms.Timer();
        }
        int chuong = int.Parse(formDiToiBaiHoc3.sttChuongBaiHoc3);
        int nActi = int.Parse(formDiToiBaiHoc3.SoActi);
        int nQT = formDiToiBaiHoc3.TiendoActi;
        



        //------------------------------------------------------------------------------------------------------------------main !!!
        private void formHienThiBaiHoc_Load(object sender, EventArgs e)        {
            serCom.PortName = LoginStudent.tenCOM;
            serCom.BaudRate = LoginStudent.giatribaudrate;
            this.ControlBox = false;
          //
          //serCom.Open();
          giatriLine1.Visible = false;
            giatriLine2.Visible = false;

            btDientinhhieu.Visible = false;


            von.Visible = false;
            nhietdo.Visible = false;
            dientro.Visible = false;
            vantruoc.Visible = false;
            IDLTT.Visible = false;
            PA.Visible = false;
            //-------------------------------------------------------------------------------------------------------------
            //  MessageBox.Show(LoginStudent.tenCOM.ToString());
            //  MessageBox.Show(LoginStudent.giatribaudrate.ToString());

            panelWiring.Visible = false;// ẩn panel wiring lúc bật lên
                                        // panelVideo.Visible = false; //panel Video hiển thị bài học
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
            else /*// if (nActi == 2)
            {

            }
            */
            {
                panelWiring.Visible = false;
                panelWiring.SendToBack();
                HienThiBaiHoc(nActi);
            }

            TaoVaXuLyNut(nonNullRowCount - 1); // hiển thị số acti

            HienThiBaiDaHoc(nQT);               // hiển thị các bài đã học bằng cách tô đậm
        }

       
        // @01D1#
        
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////// fix main  
        /// </summary>

        private void Delay(int milliseconds)
        {
            // Tạm dừng chương trình trong số milliseconds chỉ định
            Thread.Sleep(milliseconds);
        }

       
        private void HienThiBaiHoc(int v)
        {
            panelWiring.Visible = false;
            string str = v.ToString();
            string chuong = formDiToiBaiHoc3.sttChuongBaiHoc3;

            // Khai báo đối tượng Excel
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excel.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\Resources3\\Du lieu cau hoi\\thu vien bai hoc.xlsx");
            Worksheet worksheet = workbook.Sheets[chuong];// Worksheet worksheet = workbook.Sheets["Tên sheet"];
            Range range = worksheet.UsedRange;

            // Lấy số hàng và số cột của tập tin Excel
            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;

           // MessageBox.Show(colCount.ToString());
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
                    for (int col = 2; col <= colCount; col++)
                    {
                        video = range.Cells[row, 2].Value2.ToString();
                        hinhAnh = range.Cells[row, 3].Value2.ToString();
                        baihoc = range.Cells[row, 4].Value2.ToString();
                        hide = range.Cells[row, 5].Value2.ToString();
                        cauhoi = range.Cells[row, 6].Value2.ToString();
                        dapanA = range.Cells[row, 7].Value2.ToString();
                        dapanB = range.Cells[row, 8].Value2.ToString();
                        dapanC = range.Cells[row, 9].Value2.ToString();
                        dapanD = range.Cells[row, 10].Value2.ToString();

                        answer = range.Cells[row, 11].Value2.ToString();
                      
                       

                        box    = range.Cells[row, 12].Value2.ToString();// == 3 thì tách chuổi đồ thị đưa giá trị ra màng hình
                      tendothi = range.Cells[row, 13].Value2.ToString();
                       madothi  = range.Cells[row, 14].Value2.ToString();
                        kk = range.Cells[row, 15].Value2.ToString();// =1

                        chancb  = range.Cells[row, 16].Value2.ToString();// mã ký tự gửi xuống arduino để nhận lại giá trị điền vào abcd
                        check   = range.Cells[row, 17].Value2.ToString();// tất cả check = 0 trừ khi nào đáp án cú NULL thì =1
                        chonloaitinhhieu = range.Cells[row, 18].Value2.ToString();// chọn VG ,R_TH ,t_TH ,TH ứng với 1,2,3,4
                        dienabcd = range.Cells[row, 19].Value2.ToString();// nếu ==1  sẽ lấy giá trị của arduino điền vô ABCD


                        madau1 = range.Cells[row, 20].Value2.ToString();
                        madau2 = range.Cells[row, 21].Value2.ToString();
                        madau3 = range.Cells[row, 22].Value2.ToString();
                        madau4 = range.Cells[row, 23].Value2.ToString();
                        line1  = range.Cells[row, 24].Value2.ToString();
                        line2  = range.Cells[row, 25].Value2.ToString();





                        //

                        //----------------------------------------------------------------------------------------------------------

                        // Xử lý dữ liệu tìm được ở đây
                    }
                    break; // Thoát khỏi vòng lặp nếu đã tìm thấy hàng cần tìm kiếm
                }
                if (rowEND == "END")
                {
                    MessageBox.Show("Bạn đã hoàn thành bài học");
                    nActi = row;
                    this.Hide();
                    formDiToiBaiHoc3 f = new formDiToiBaiHoc3();
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

            
            
            
            
            void check_null()
            {
                string[] answers = new string[4] { dapanA, dapanB, dapanC, dapanD };
               // int a=0;
                for (int i = 0; i < 4; i++)
                {
                    if (answers[i] == "NULL")
                    { btDientinhhieu.Visible=true;
                        if (serCom.IsOpen) 
                        {
                            
                            serCom.Write(chancb.ToString());
                           
                        }

                        else

                        {
                            serCom.Open();
                            serCom.Write(chancb.ToString());
                          
                        }
                      

                        // array[i] = madothi;
                        // Delay(1000);
                        // serCom.Close();
                       // answers[i] = alldata;
                          checka = i;
                        break;
                    }
                   
                }
              
            }
        


                if (int.Parse(hide) == 1)
                {
                    picChe.BringToFront();
                    pictureBox1.Image = new Bitmap(System.Windows.Forms.Application.StartupPath + hinhAnh);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Show();
                    rtb_Baihoc.Clear();
                    rtb_Baihoc.Text = baihoc;
                    btDientinhhieu.Visible=false;
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
                //  btDientinhhieu.Visible = true;

                check_null();
               // MessageBox.Show("ddđ "+checka.ToString());
                // Delay(1000);
                
                if (int.Parse(check) == 0)
                    {
                       string[] dsDA = { dapanA, dapanB, dapanC, dapanD };
                     chlstDapAn.Items.AddRange(dsDA);
                    }
                }

               

                if (int.Parse(box) == 3)
                {
                // khởi tạo biểu đồ
                GraphPane myPanne = zedGraphControl1.GraphPane;
                myPanne.Title.Text = tendothi;
                myPanne.YAxis.Title.Text = "Giá Trị";
                myPanne.XAxis.Title.Text = "Thời Gian";


                RollingPointPairList List1 = new RollingPointPairList(500000);
                RollingPointPairList List2 = new RollingPointPairList(500000);

                LineItem duongline1 = myPanne.AddCurve(line1, List1, Color.Red, SymbolType.None);
                LineItem duongline2 = myPanne.AddCurve(line2, List2, Color.YellowGreen, SymbolType.None);
                myPanne.X2Axis.Scale.Min = 0; // giá trị min 
                myPanne.X2Axis.Scale.Max = 100; // giá trị max
                myPanne.X2Axis.Scale.MinorStep = 1;
                myPanne.X2Axis.Scale.MajorStep = 5;

                myPanne.YAxis.Scale.Min = 0;
                myPanne.YAxis.Scale.Max = 10;
                myPanne.YAxis.Scale.MinorStep = 0.01;
                myPanne.YAxis.Scale.MajorStep = 1;

                zedGraphControl1.AxisChange();
                // serCom.Open();
                //  btDientinhhieu.Visible= false;  
               // lbTendothi.Text = tendothi;
                    pictureBox1.Visible = false;
               
                    //pictureBox1.SendToBack();
                    panelWiring.Visible = false;
                    rtb_Baihoc.Visible = false;
                    gbBox1.Visible = true;
                    gbBox1.BringToFront();
                //  button1.Text = "nnnnnn";
                if (serCom.IsOpen)
                {
                    serCom.Write(madothi.ToString()); 
                }
                else { 
                    serCom.Open();
                    serCom.Write(madothi.ToString());
                      }

                    btnOK.Enabled = true;
                
                
                }

                else 
                 {
               // btDientinhhieu.Visible= false;
                pictureBox1.Visible = true;  /////////sửa
                pictureBox1.BringToFront();
                rtb_Baihoc.Visible = true;
                gbBox1.Visible = false;
                btnOK.Enabled = true;
                 }


        }
        private void guiMaFault(string ft)
        {
            if (serCom.IsOpen )
            {
                serCom.Write(ft);
                serCom.Close();
            }
            else 
            {   serCom.Open();
                serCom.Write(ft);
                serCom.Close();
            }
            
           
        }

        int count(string input)
        {
            char[] arr;
            arr = input.ToCharArray();

            return arr.Length;
        }

        void tachchuoidothi()
        {   
          
            string input = alldata;

            string substringToFind1 = madau1;

            string substringToFind2 = madau2;

            string substringToFind3 = madau3;

            string substringToFind4 = madau4;


            int index1 = input.IndexOf(substringToFind1);

            int index2 = input.IndexOf(substringToFind2);
            int index3 = input.IndexOf(substringToFind3);
            int index4 = input.IndexOf(substringToFind4);

            if (index1 != -1)
            {

                 giatri1 = alldata.Substring(index1 + count(madau1), 4);
            }
            if (index2 != -1)
            {

                 giatri2 = alldata.Substring(index2 + count(madau2), 4);
            }
            if (index3 != -1)
            {

                 giatri3 = alldata.Substring(index3 + count(madau3), 4);
            }
            if (index4 != -1)
            {

                 giatri4 = alldata.Substring(index4 + count(madau4), 4);
            }
            //=======================================================
            if (int.Parse(kk) == 1)
            {

                Invoke(new MethodInvoker(() => draw1(Convert.ToDouble(giatri1) ))); // in ra đồ thị
                giatriLine1.Visible = true;
                txtDientro.Text = giatri2;
                txtNhietdo.Text = giatri3;//
                txtVon.Text = giatri4;
                dientro.Visible = true;
                nhietdo.Visible = true;
                von.Visible = true;
                txtGiatri1.Visible = true;
                txtGiatri1.Text = giatri1;
            }
            else if (int.Parse(kk) == 2)
            {
              
                 Invoke(new MethodInvoker(() => draw2(Convert.ToDouble(giatri1),Convert.ToDouble(giatri2) )));
                giatriLine1.Visible = true;
                giatriLine2.Visible = true;
                lbGiatridothi1.Visible = true;
                lbGiatridothi2.Visible = true;
                txtGiatri1.Visible = true;
                txtGiatri2.Visible = true;
                txtGiatri1.Text = giatri1;
                txtGiatri2.Text = giatri2;
              
            }
            else if (int.Parse(kk) == 3)
            {
                Invoke(new MethodInvoker(() => draw1(Convert.ToDouble(giatri1))));
                giatriLine1.Visible = true;
                lbGiatridothi1.Visible=true;
                txtGiatri1.Visible=true;

                txtGiatri1.Text=giatri1;

                txtOnoff.Text = giatri2;
                vantruoc.Visible = true;
                txtNhietdo.Text = giatri3;
                nhietdo.Visible = true;

            }
            else if (int.Parse(kk) == 4)
            {
                Invoke(new MethodInvoker(() => draw1(Convert.ToDouble(giatri1))));
                giatriLine1.Visible = true;

                lbGiatridothi1.Visible = true;
                txtGiatri1.Visible = true;
                txtGiatri1.Text = giatri1;

                txtIDLTT.Text = giatri2;
                IDLTT.Visible = true;
            }
            else if (int.Parse(kk) == 5)
            {
                Invoke(new MethodInvoker(() => draw1(Convert.ToDouble(giatri1))));  
                giatriLine1.Visible = true;
                lbGiatridothi1.Visible = true;
                txtGiatri1.Visible = true;
                txtGiatri1.Text = giatri1;

            }
        }

        void tachchuoidienABCD()
        {

            string input = alldata;


            string substringToFind1 = madau1;  //VG/GHH/HJJJ
           //MessageBox.Show("madau1:"+madau1);


            string substringToFind2 = madau2;
           // MessageBox.Show("madau2:"+madau2);

            string substringToFind3 = madau3;

           // MessageBox.Show("madau3:"+madau3);

            string substringToFind4 = madau4;
           // MessageBox.Show("madau4:"+madau4);

            int index1 = input.IndexOf(substringToFind1);
             //MessageBox.Show("1== :"+index1);
            int index2 = input.IndexOf(substringToFind2);
            int index3 = input.IndexOf(substringToFind3);
            int index4 = input.IndexOf(substringToFind4);


            if (index1 != -1)
            {
                //  for (int i = 0; i < input.Length; i++)
                /* char[] arr;
                 arr = madau1.ToCharArray();

                 int count = arr.Length;*/
                
                 // MessageBox.Show("count :"+count.ToString());

                 giatri1 = alldata.Substring(index1+ count(madau1), 4);  //VGH    H2.0
              // MessageBox.Show("1 :"+alldata.Substring(index1, 3));
               // MessageBox.Show("1== :"+giatri1);

            }
            if (index2 != -1)
            {
                
                // MessageBox.Show("count :"+count.ToString());
                giatri2 = alldata.Substring(index2 + count(madau2), 4);
               // MessageBox.Show("2 :"+index2.ToString());
            }
            if (index3 != -1)
            {

                 giatri3 = alldata.Substring(index3 + count(madau3), 4);
              //  MessageBox.Show("3 :"+index3.ToString());
            }
            if (index4 != -1)
            {

                 giatri4 = alldata.Substring(index4 + count(madau4), 4);
                 // MessageBox.Show("4 :"+index4.ToString());
                // MessageBox.Show("1 :"+alldata.Substring(index4, 3));
                // MessageBox.Show("1== :"+giatri4);

            }

            if (int.Parse(chonloaitinhhieu)==1)
            {
                dapandung = giatri1;
              //  MessageBox.Show("dapan1:" + dapandung);
            }
            else if (int.Parse(chonloaitinhhieu) == 2)
            {
                dapandung= giatri2;
               // MessageBox.Show("dapan2:" + dapandung);
            }
            else if (int.Parse(chonloaitinhhieu) == 3)
            {
                dapandung =giatri3;
              //  MessageBox.Show("dapan3:" + dapandung);
            }
            else if(int.Parse(chonloaitinhhieu) ==4) 
            { 
                dapandung = giatri4;
              //  MessageBox.Show("dapan4:" + dapandung);
            }
           // MessageBox.Show("dapan:"+dapandung);
        }

        void tatmo()
        {
            lbGiatridothi1.Visible = false;
            lbGiatridothi2.Visible = false;
            txtGiatri1.Visible = false;
            txtGiatri2.Visible = false;
            tong = 0;
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        void reset()
        {
            //using ZedGraph;

            // Lấy đối tượng GraphPane từ zedGraphControl1
            GraphPane graphPane = zedGraphControl1.GraphPane;

            // Lấy danh sách đường cong từ GraphPane
            CurveList curveList = graphPane.CurveList;

            // Duyệt qua từng đường cong trong danh sách
            foreach (CurveItem curve in curveList)
            {
                // Lấy danh sách điểm của đường cong
                IPointListEdit pointList = curve.Points as IPointListEdit;

                // Xóa tất cả các điểm trong danh sách
                pointList.Clear();
            }

            // Gọi AxisChange để cập nhật trục
            zedGraphControl1.AxisChange();

            // Vẽ lại đồ thị
            zedGraphControl1.Invalidate();
            tong = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        int tong = 0;

        public void draw1(double Line1)
        {
            LineItem duongline = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            if (duongline == null)
            {
                return;
            }
            IPointListEdit list = duongline.Points as IPointListEdit;
            if (list == null)
            {
                return;

            }
            list.Add(tong, Line1);
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            tong += 1;
        }
        // Invoke(new MethodInvoker(() => draw1(Convert.ToDouble(giatri1)))); 
        
        public void draw2(double line1,double line2)
        {
            LineItem duongline1 = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            LineItem duongline2 = zedGraphControl1.GraphPane.CurveList[1] as LineItem;
            if (duongline1 == null)
            {
                return;
            }
            if (duongline2 == null)
            {
                return;
            }
            IPointListEdit list1 = duongline1.Points as IPointListEdit;
            IPointListEdit list2 = duongline2.Points as IPointListEdit;
            if (list1 == null)
            {
                return;

            }
            if (list2 == null)
            {
                return;

            }
            list1.Add(tong, line1);
            list2.Add(tong, line2);
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            tong += 1;
           /* if (txtdien.Text == "1")
            {
                list1.Clear();
                list2.Clear();
            }*/
        }


        private void serCom_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            //   string alldata = "";
            alldata = serCom.ReadLine();  // đọc dữ dữ liệu từ arduino   
            alldata = alldata.Trim();
            int lenght = alldata.Length;
            
           // MessageBox.Show(alldata);
            if (lenght > 0 && serCom.IsOpen)
            {
              //  MessageBox.Show(alldata);
                if (int.Parse(box) == 3) 
                {
                    tachchuoidothi();
                }
                if (int.Parse(dienabcd) == 1)
                {
                    tachchuoidienABCD();
                }

                // trong cái hàm nhận dữ liệu thì gán dữ liệu vựa tạo vào cái đương line 
              //  Invoke(new MethodInvoker(() => draw1(Convert.ToDouble(alldata)))); // in ra đồ thị

            }
            

        }

        private void btDientinhhieu_Click(object sender, EventArgs e)
        {
            serCom.Close();
            string[] dsDA1 = { "A. ", "B. ", "C. ", "D. " };
            
            string[] dsDA = { dapanA, dapanB, dapanC, dapanD };
            dsDA[checka] = dsDA1[checka]+ dapandung;
            chlstDapAn.Items.AddRange(dsDA);

          
            btDientinhhieu.Visible = false;
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
            string folderPath = System.Windows.Forms.Application.StartupPath + "\\Resources3\\Wiring\\" + $"wiring_c{chuong}";
            maxImageIndex = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories).Length;
            buttonCount = 7;
        }

        private void LoadImage(int index)
        {
            int chuong = int.Parse(formDiToiBaiHoc3.sttChuongBaiHoc3);
            string fileName = System.Windows.Forms.Application.StartupPath + "\\Resources3\\Wiring\\" + $"wiring_c{chuong}" + "\\" + $"hinh{index}.png";
            pictureBox2.Image = System.Drawing.Image.FromFile(fileName);
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
                button.Size = new Size(30, 30);            // mới sửa 40.40
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

        private void HienThiBaiDaHoc(int v)
        {
            // Lấy danh sách các nút hiển thị trên flowLayoutPanel2
            var buttons = flowLayoutPanel2.Controls.OfType<System.Windows.Forms.Button>().ToList();

            // Đặt thuộc tính "Enabled" cho v nút đầu tiên là "true"
            Color customColor = Color.FromArgb(110, 172, 183);

            for (int i = 0; i <= (v - 1) && i < buttons.Count; i++)
            {
                buttons[i].BackColor = customColor;
                buttons[i].Enabled = true;
            }

        }

        private void HienthiKhinhanOK(int v)
        {
            // Lấy danh sách các nút hiển thị trên flowLayoutPanel2
            var buttons = flowLayoutPanel2.Controls.OfType<System.Windows.Forms.Button>().ToList();
            Color customColor = Color.FromArgb(110, 172, 183);
            if (v > 0 && v <= buttons.Count)
            {
                buttons.ElementAt(v - 1).BackColor = customColor;
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
                // panelVideo.SendToBack();
                 guiMaFault("x");
                HienThiWiring();
                panelWiring.Visible = true;
                panelWiring.BringToFront();
                hide = "1";
            }
            else
            {
                 guiMaFault("x");
                HienThiBaiHoc(giaTriNutSoNguyen);
                btnOK.Enabled = true;
                panelWiring.Visible = false;
                panelWiring.SendToBack();
            }
            nActi = giaTriNutSoNguyen;  //set nActi về lại giá trị của cái nút mà mình bấm
            btnOK.Enabled = true;
            //  NextPicVideo.Enabled = true;
            //  PrevPicVideo.Enabled = true;
            buttonLeft.Enabled = true;
            buttonRight.Enabled = true;
        }

        private void HienThiVideo()
        {
            // lấy số hình có trong video đó
            string folderPath = System.Windows.Forms.Application.StartupPath + "\\Resources3\\VideoCacChuong\\" + $"chuong{chuong}\\" + $"video{video}";
            maxImageIndexVideo = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories).Length;
            buttonCountVideo = 7; // số nút hiển thị là 7

            // hiển thị hình ảnh video
            LoadImageVideo(currentImageIndexVideo);

        }

        private void LoadImageVideo(int index)
        {
            string fileName = System.Windows.Forms.Application.StartupPath + "\\Resources3\\VideoCacChuong\\" + $"chuong{chuong}\\" + $"video{video}\\" + $"hinh{index}";
            string imagePath = Path.ChangeExtension(fileName, ".png");
            string gifPath = Path.ChangeExtension(fileName, ".gif");    // check xem có đuôi là gif hay png

            if (File.Exists(imagePath))
            {
              //  picPanelVideo.Image = Image.FromFile(imagePath);
            }
            else if (File.Exists(gifPath))
            {
               // picPanelVideo.Image = Image.FromFile(gifPath);
            }

          //  picPanelVideo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void formHienThiBaiHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
          
          guiMaFault("x");
           if (serCom.IsOpen)
            {
                serCom.Close();
            }
            LuuTiendo();
            //MessageBox.Show("đã lưu");
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
          guiMaFault("x");
            this.Close();
            if (serCom.IsOpen)
            {
                serCom.Close();
            }
            LuuTiendo();
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
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Bật nút chuyển ảnh lên
          //  PrevPicVideo.Enabled = true;
           // NextPicVideo.Enabled = true;

            //-------------------------
            if (nActi == 1)
            {
                HienthiKhinhanOK(1);
                nActi++;
                HienThiBaiHoc(nActi);
            }
            else if (nActi > 1)
            {
                if (int.Parse(hide) == 1)
                {
                    nActi++;
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

                if (nActi <= (nonNullRowCount - 3)) 
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
              //  string truycapCot = "nqtc" + chuong.ToString();
                //--------------------------------------------------------------------------------------------------------------------------fix
                int vitriCot = chuong + 14;
                int linh = chuong + 9; 
                string truycapCot = "nqtc" + linh.ToString();

                SQLiteCommand command1 = new SQLiteCommand();
                command1.CommandType = CommandType.Text;
                command1.CommandText = "select * from ThongTinSinhVien where TenDangNhap=@tendn";
                command1.Connection = conn;
                command1.Parameters.AddWithValue("@tendn", tendangnhapform1);

                string lastTiendo = linh.ToString() + "va" + nActi.ToString();

                SQLiteDataReader reader = command1.ExecuteReader();
                if (reader.Read())
                {

                    int nqtOLD = reader.GetInt32(vitriCot);// lấy giá trị trong db ở chương so sánh vs nActi 
                    int vitri = reader.GetInt32(0);
                  //  MessageBox.Show(nqtOLD.ToString());
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
                        //------------------------------------------------------------------------------------------------------comment "luu tien do"
                        int kq2 = command.ExecuteNonQuery();
                        if (kq2 > 0)
                        {
                            MessageBox.Show("Lưu tiến độ thành công!");
                            MessageBox.Show(nqt.ToString());
                            MessageBox.Show(vitri.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Lưu tiến độ thất bại!");
                        }
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
          //  serCom.Close();
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


