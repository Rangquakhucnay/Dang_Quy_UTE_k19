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
    public partial class formthuchanhnew : Form
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


        int chuong = int.Parse(formDiToiBaiHoc.sttChuongBaiHoc);
        int nActi = int.Parse(formDiToiBaiHoc.SoActi);
        int nQT = formDiToiBaiHoc.TiendoActi;


        public formthuchanhnew()
        {
            InitializeComponent();
            double scale = 0.9; // Thiết lập tỷ lệ kích thước của Form so với kích thước màn hình
            Screen screen = Screen.PrimaryScreen;
            int width = (int)(screen.Bounds.Width * scale);
            int height = (int)(screen.Bounds.Height * scale);
            this.Size = new Size(width, height);
        }

    }
}
