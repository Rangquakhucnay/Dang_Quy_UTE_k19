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
    public partial class karman : Form
    {
        public karman()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            karman1 f = new karman1();
            this.Hide();
            f.ShowDialog();
        }

        private void karman_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt f = new formkt();
            this.Close();
            f.ShowDialog();
        }
    }
}
