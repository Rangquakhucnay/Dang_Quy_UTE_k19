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
    public partial class delcoquang : Form
    {
        public delcoquang()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            delcoquang1 f = new delcoquang1();
            this.Hide();
            f.ShowDialog();
        }

        private void delcoquang_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt f = new formkt();
            this.Close();
            f.ShowDialog();
        }
    }
}
