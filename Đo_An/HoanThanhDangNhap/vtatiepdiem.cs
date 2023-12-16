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
    public partial class vtatiepdiem : Form
    {
        public vtatiepdiem()
        {
            InitializeComponent();
            exitsetting();
        }

        void exitsetting()
        {
            ControlBox = false;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            vtatiepdiem1 f =    new vtatiepdiem1();
            this.Hide();
            f.ShowDialog();
        }

        private void vtatiepdiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt f = new formkt();
            this.Close();
            f.ShowDialog();
        }
    }
}
