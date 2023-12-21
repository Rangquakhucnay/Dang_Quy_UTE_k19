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
    public partial class formchonphan2 : Form
    {
        
        public formchonphan2()
        {
            InitializeComponent();
        }


        private void btChương1_Click(object sender, EventArgs e)
        {
            this.Hide();
         formchonbaihoc3 f1 =    new formchonbaihoc3();
            f1.ShowDialog();
            this.Close();
           
        }

        private void btChuong2_Click(object sender, EventArgs e)
        {   
            this.Hide();
            formchonbaihoc4 f1 = new formchonbaihoc4();
            f1.ShowDialog();
            this.Close();
           
        }

        

        
    }
}
