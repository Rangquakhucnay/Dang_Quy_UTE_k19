using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HoanThanhDangNhap
{
    public partial class formchonphan1 : Form
    {
      
        public formchonphan1()
        {
            InitializeComponent();
        }

        private void btChương1_Click(object sender, EventArgs e)
        {
            this.Hide();
           formChonBaiHoc f1 = new formChonBaiHoc();
           f1.ShowDialog();
            this.Close();
          
        }

        

        private void btChuong2_Click(object sender, EventArgs e)
        {   this.Hide();
           formchonbaihoc2 f1 = new formchonbaihoc2();
            f1.ShowDialog();
            this.Close();
           
        }

       


    }
}
