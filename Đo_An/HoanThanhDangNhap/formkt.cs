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
    public partial class formkt : Form
    {
        public formkt()
        {
            InitializeComponent();
        }

        

        

       

        private void btMap_Click(object sender, EventArgs e)
        {
           
        }

        private void btDelcodientu_Click(object sender, EventArgs e)
        {
            
        }

        private void btDelcohall_Click(object sender, EventArgs e)
        {
            delcohall f = new delcohall();
            this.Hide(); 
            f.ShowDialog();
        }

        private void btTHW_Click(object sender, EventArgs e)
        {
           thw f = new thw();
            this.Hide();
            f.ShowDialog();
        }

        private void btVTAtiepdiem_Click(object sender, EventArgs e)
        {
            vtatiepdiem f = new vtatiepdiem();
            this.Hide();
            f.ShowDialog();
        }

        private void btVTAcoIDL_Click(object sender, EventArgs e)
        {
            VTAcoIDL f = new VTAcoIDL();
            this.Hide();
            f.ShowDialog();
             
        }

        private void btVTAkoIDL_Click(object sender, EventArgs e)
        {
            VTAkhongIDL f = new VTAkhongIDL();
            this.Hide();
            f.ShowDialog();
        }

        private void btVTAhall_Click(object sender, EventArgs e)
        {
           VTAhall f = new VTAhall();
            this.Hide();
            f.ShowDialog();    
        }

        private void btVPAtuyentinh_Click(object sender, EventArgs e)
        {
            VPAtuyentinh f = new VPAtuyentinh();
            this.Hide(); 
            f.ShowDialog();
        }

       

        private void btVPAhall_Click(object sender, EventArgs e)
        {
            VPAhall f = new VPAhall();
            this.Hide();
            f.ShowDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDelcoquang_Click(object sender, EventArgs e)
        {
            delcoquang delcoquang = new delcoquang();
            this.Hide();
            delcoquang.ShowDialog();
        }

        private void lbKarmanSiêuÂm_Click(object sender, EventArgs e)
        {
            karman f = new karman();
            this.Hide();
            f.ShowDialog();
        }

        private void lbCảmBiếnDâyNhiệt_Click(object sender, EventArgs e)
        {
            daynhiet1 k1 = new daynhiet1();
            this.Hide();
            k1.ShowDialog();
        }

        private void lbMap_Click(object sender, EventArgs e)
        {
            map f = new map();
            this.Hide();
            f.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            delcodientu f = new delcodientu();
            this.Hide();
            f.ShowDialog();
        }
    }
    }

