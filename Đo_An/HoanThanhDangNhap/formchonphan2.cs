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
        Thread th;
        Thread th2;
        public formchonphan2()
        {
            InitializeComponent();
        }


        private void btChương1_Click(object sender, EventArgs e)
        {

         formchonbaihoc3 f1 =    new formchonbaihoc3();
            f1.ShowDialog();
            this.Close();
            th = new Thread(Opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Opennewform(object obj)
        {
            Application.Run(new formchonbaihoc3());
        }

        private void btChuong2_Click(object sender, EventArgs e)
        {
            formchonbaihoc4 f1 = new formchonbaihoc4();
            f1.ShowDialog();
            this.Close();
            th2 = new Thread(Opennewform);
            th2.SetApartmentState(ApartmentState.STA);
            th2.Start();
        }

        private void Opennewform1(object obj)
        {
            Application.Run(new formchonbaihoc4());
        }


    }
}
