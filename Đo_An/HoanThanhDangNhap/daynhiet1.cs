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
    public partial class daynhiet1 : Form
    {
        public daynhiet1()
        {
            InitializeComponent();
            exitsetting();
        }

        void exitsetting()
        {
            ControlBox = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            daynhiet2 f = new daynhiet2();
            this.Hide();
            f.ShowDialog();
        }

        private void daynhiet1_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt f = new formkt();
            this.Close();
            f.ShowDialog();
        }
    }
}
