using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HoanThanhDangNhap
{
    public partial class formGV : Form
    {
        public formGV()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            taoaccount ad = new taoaccount();
            ad.ShowDialog();
        }


        private void formGV_Load(object sender, EventArgs e)
        {
        }




        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void formGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            GVTaoMaLoi f = new GVTaoMaLoi();
            f.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            GVTaoMaLoi f = new GVTaoMaLoi();
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
