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
            int[] MaxActi = { 26, 15, 20, 15, 7, 8, 18 };

            int[] nqtc = new int[7];
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
                for (int i = 0; i <= 6; i++)
                {
                    if (reader.IsDBNull(i+6))
                    {
                        nqtc[i] = 0;
                    }
                    else
                    {
                        nqtc[i] = reader.GetInt32(i+6);
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
            
            /*
            int[] nActiTungChuong = new int[16];
            nActiTungChuong = { }
            for (int i = 0; i <= 15; i++)
            {
                string chapterName = "Chương" + (i + 1).ToString();
                int chapterProgress = nqtc[i]/nActiTungChuong[i]*100 ;
                int numActivities = 100;

                TienDoHocTap.Series["Tiến độ hiện tại"].Points.AddXY(chapterName, chapterProgress);
                TienDoHocTap.Series["Số hoạt động của chương"].Points.AddXY(chapterName, numActivities);

                TienDoHocTap.Series["Tiến độ hiện tại"].ChartType = SeriesChartType.StackedColumn;
                TienDoHocTap.Series["Số hoạt động của chương"].ChartType = SeriesChartType.StackedColumn;

                TienDoHocTap.Series["Số hoạt động của chương"].SetCustomProperty("StackedGroupName", "Tiến độ hiện tại");
            }
            */
            for (int i = 0; i <= 6; i++)
            {
                string chapterName = "Chương" + (i + 1).ToString();
                int chapterProgress = nqtc[i];
                //int numActivities = MaxActi[i] - chapterProgress;
                double percentComplete = (double)chapterProgress / (double)MaxActi[i] * 100.0;

                TienDoHocTap.Series["Số hoạt động đã học"].Points.AddXY(chapterName, percentComplete);
                TienDoHocTap.Series["Số hoạt động còn lại"].Points.AddXY(chapterName, 100.0 - percentComplete);
                // Đổi vị trí của Legend xuống dưới
                TienDoHocTap.Legends[0].Docking = Docking.Bottom;
                TienDoHocTap.ChartAreas[0].AxisY.LabelStyle.Format = "{0}%";
            }
        }

    }
}
