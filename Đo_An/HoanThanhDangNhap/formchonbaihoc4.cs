﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HoanThanhDangNhap
{
    public partial class formchonbaihoc4 : Form
    {
        public formchonbaihoc4()
        {
            InitializeComponent();
        }

        private void btnTat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formChonBaiHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnChonBaiHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDiToiBaiHoc4 f = new formDiToiBaiHoc4();
            f.ShowDialog();
            this.Close();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {   int em = 0;
            int lastChuong = 0;
            int lastnActi = 0;
            int TiendoHoanthanhChuong = 0;
            string lastTiendo = "";
            SQLiteConnection conn = null;
            string strConn = string.Format(@"Data Source = {0}\DBLogin.db;Version=3;", System.Windows.Forms.Application.StartupPath);
            try
            {
                conn = new SQLiteConnection(strConn);
                conn.Open();

                string tendangnhapform1 = Properties.Settings.Default.TenDangNhapALL;
                SQLiteCommand command = new SQLiteCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from ThongTinSinhVien where TenDangNhap=@tendn";
                command.Connection = conn;
                command.Parameters.AddWithValue("@tendn", tendangnhapform1);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    lastTiendo = reader.GetString(41);
                }


                string[] parts = lastTiendo.Split(new[] { "va" }, StringSplitOptions.None);
                lastChuong = int.Parse(parts[0]);
                lastnActi = int.Parse(parts[1]);

                int vitriCot = lastChuong + 5;

               // em = int.Parse(parts[0]) - 32;
                string nlastChuong = (lastChuong-23).ToString();
                string nlastnActi = lastnActi.ToString();
                SQLiteCommand command1 = new SQLiteCommand();
                command1.CommandType = CommandType.Text;
                command1.CommandText = "select * from ThongTinSinhVien where TenDangNhap=@tendn";
                command1.Connection = conn;
                command1.Parameters.AddWithValue("@tendn", tendangnhapform1);
                SQLiteDataReader reader1 = command1.ExecuteReader();
                if (reader1.Read())
                {
                    TiendoHoanthanhChuong = reader.GetInt32(vitriCot);
                }

                if (TiendoHoanthanhChuong < lastnActi)
                {
                    formDiToiBaiHoc4.TiendoActi = int.Parse(nlastnActi);
                }
                else
                {
                    formDiToiBaiHoc4.TiendoActi = TiendoHoanthanhChuong;
                }
                formDiToiBaiHoc4.sttChuongBaiHoc4 = nlastChuong;
                formDiToiBaiHoc4.SoActi = nlastnActi;
                reader.Close();
                reader1.Close();
                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            this.Hide();
            formHienThiBaiHoc4 f = new formHienThiBaiHoc4();
            f.ShowDialog();
            this.Close  ();

        }

        private void formChonBaiHoc_Load(object sender, EventArgs e)
        {

        }
    }
}
