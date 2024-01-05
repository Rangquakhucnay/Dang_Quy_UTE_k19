using MathNet.Numerics.RootFinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HoanThanhDangNhap
{
    public partial class TienDoSV : Form
    {
        public TienDoSV()
        {
            InitializeComponent();

            // Khai báo và khởi tạo một mảng kiểu double với giá trị ban đầu
            int[] MaxActi = { 39, 31, 74, 32 };

            int[] nqtc = new int[28];
            SQLiteConnection conn = null;
            string strConn = string.Format(@"Data Source = {0}\DBLogin.db;Version=3;", Application.StartupPath);
            string SvCanXemTienDo = Properties.Settings.Default.TenDangNhapALL;
            string ten = "";
            //MessageBox.Show(SvCanXemTienDo);
            if (conn == null)
                conn = new SQLiteConnection(strConn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SQLiteCommand command = new SQLiteCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from ThongTinSinhVien where TenDangNhap=@tendn";
            command.Parameters.AddWithValue("@tendn", SvCanXemTienDo);
            command.Connection = conn;
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                ten = reader.GetString(1);
                for (int i = 1; i <= 28; i++)
                {
                    if (reader.IsDBNull(i+5))
                    {
                        nqtc[i-1] = 0;
                    }
                    else
                    {
                        nqtc[i-1] = reader.GetInt32(i+5);
                       // MessageBox.Show(nqtc[i-1].ToString());
                    }
                    
                }
            }
            string chuoi = "Tiến độ học tập của: " + ten;
            tenSv.Text = chuoi;

            reader.Close();
            conn.Close();
            conn.Dispose();
            //string message = string.Join(", ", nqtc);
            //MessageBox.Show(message);
            TienDoHocTap.ChartAreas["ChartArea1"].AxisX.Interval = 1;

          //  MessageBox.Show(nqtc[22].ToString());
            for (int i = 1; i <= 4; i++)
            {
                int tong=0;
                string chapterName = "Phần " + (i).ToString();
                //  MessageBox.Show(chapterName);
                //===========================================================================

                if (i == 1)
                {
                   //tong = 0;
                    for (int j = 0; j <= 4; j++)
                    {
                        tong =tong+ nqtc[j];
                    }
                  //  MessageBox.Show(tong.ToString());
                }
                if (i == 2)
                {//tong = 0;
                    for (int j = 5; j <= 8; j++)
                    {
                        tong += nqtc[j];
                    }
                  // MessageBox.Show(tong.ToString());
                }
                if (i == 3)
                {
                   // tong = 0;
                    for (int j = 9; j <= 22; j++)
                    {
                        tong =tong + nqtc[j];
                    }
                 //   MessageBox.Show(tong.ToString());
                }
                if (i == 4)
                {
                  // tong = 0;
                    for (int j = 23; j <= 27; j++)
                    {
                        tong += nqtc[j];
                    }
                 //   MessageBox.Show(tong.ToString());
                }
                int chapterProgress = tong ;
              //  MessageBox.Show(chapterProgress.ToString());
               // MessageBox.Show(MaxActi[i-1].ToString());
                //int numActivities = MaxActi[i] - chapterProgress;
                double percentComplete = (double)chapterProgress / (double)MaxActi[i-1] * 100.0;

                TienDoHocTap.Series["Số hoạt động đã học"].Points.AddXY(chapterName, percentComplete);
                TienDoHocTap.Series["Số hoạt động còn lại"].Points.AddXY(chapterName, 100.0 - percentComplete);
                // Đổi vị trí của Legend xuống dưới
                TienDoHocTap.Legends[0].Docking = Docking.Bottom;
                TienDoHocTap.ChartAreas[0].AxisY.LabelStyle.Format = "{0}%";
            }
        }

    }
}
