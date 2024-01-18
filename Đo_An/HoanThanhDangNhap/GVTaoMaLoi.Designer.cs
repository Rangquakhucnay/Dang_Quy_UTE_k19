namespace HoanThanhDangNhap
{
    partial class GVTaoMaLoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtMaLoi = new System.Windows.Forms.TextBox();
            this.NutTaoLoi = new System.Windows.Forms.Button();
            this.NutXoaLoi = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NutKetNoi = new System.Windows.Forms.Button();
            this.listrate = new System.Windows.Forms.ComboBox();
            this.listcom = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NutThoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaLoi
            // 
            this.txtMaLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoi.Location = new System.Drawing.Point(323, 22);
            this.txtMaLoi.Name = "txtMaLoi";
            this.txtMaLoi.Size = new System.Drawing.Size(90, 38);
            this.txtMaLoi.TabIndex = 1;
            this.txtMaLoi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NutTaoLoi
            // 
            this.NutTaoLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutTaoLoi.Location = new System.Drawing.Point(60, 101);
            this.NutTaoLoi.Name = "NutTaoLoi";
            this.NutTaoLoi.Size = new System.Drawing.Size(156, 56);
            this.NutTaoLoi.TabIndex = 2;
            this.NutTaoLoi.Text = "Tạo PAN";
            this.NutTaoLoi.UseVisualStyleBackColor = true;
            this.NutTaoLoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // NutXoaLoi
            // 
            this.NutXoaLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutXoaLoi.Location = new System.Drawing.Point(287, 101);
            this.NutXoaLoi.Name = "NutXoaLoi";
            this.NutXoaLoi.Size = new System.Drawing.Size(156, 56);
            this.NutXoaLoi.TabIndex = 3;
            this.NutXoaLoi.Text = "Reset";
            this.NutXoaLoi.UseVisualStyleBackColor = true;
            this.NutXoaLoi.Click += new System.EventHandler(this.NutXoaLoi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(172)))), ((int)(((byte)(183)))));
            this.panel1.Controls.Add(this.NutXoaLoi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NutTaoLoi);
            this.panel1.Controls.Add(this.txtMaLoi);
            this.panel1.Location = new System.Drawing.Point(908, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 187);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập mã lỗi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.NutKetNoi);
            this.panel2.Controls.Add(this.listrate);
            this.panel2.Controls.Add(this.listcom);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(908, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 336);
            this.panel2.TabIndex = 5;
            // 
            // NutKetNoi
            // 
            this.NutKetNoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutKetNoi.Location = new System.Drawing.Point(149, 260);
            this.NutKetNoi.Name = "NutKetNoi";
            this.NutKetNoi.Size = new System.Drawing.Size(208, 57);
            this.NutKetNoi.TabIndex = 6;
            this.NutKetNoi.Text = "Kết nối";
            this.NutKetNoi.UseVisualStyleBackColor = true;
            this.NutKetNoi.Click += new System.EventHandler(this.NutKetNoi_Click);
            // 
            // listrate
            // 
            this.listrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listrate.FormattingEnabled = true;
            this.listrate.Location = new System.Drawing.Point(244, 198);
            this.listrate.Name = "listrate";
            this.listrate.Size = new System.Drawing.Size(191, 33);
            this.listrate.TabIndex = 7;
            // 
            // listcom
            // 
            this.listcom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listcom.FormattingEnabled = true;
            this.listcom.Location = new System.Drawing.Point(244, 126);
            this.listcom.Name = "listcom";
            this.listcom.Size = new System.Drawing.Size(191, 33);
            this.listcom.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Baud Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cổng COM";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HoanThanhDangNhap.Properties.Resources.Iconsmind_Outline_Information_512;
            this.pictureBox2.Location = new System.Drawing.Point(16, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(319, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "phần mềm với mô hình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(414, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trước khi bắt đầu, hãy kết nối";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NutThoat
            // 
            this.NutThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutThoat.Location = new System.Drawing.Point(1080, 673);
            this.NutThoat.Name = "NutThoat";
            this.NutThoat.Size = new System.Drawing.Size(156, 71);
            this.NutThoat.TabIndex = 6;
            this.NutThoat.Text = "EXIT";
            this.NutThoat.UseVisualStyleBackColor = true;
            this.NutThoat.Click += new System.EventHandler(this.NutThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HoanThanhDangNhap.Properties.Resources.z5061536431857_7d36129f9fca2cefaba4b95903d32a66;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(868, 870);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GVTaoMaLoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1448, 884);
            this.Controls.Add(this.NutThoat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GVTaoMaLoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giảng viên tạo mã lỗi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GVTaoMaLoi_FormClosed);
            this.Load += new System.EventHandler(this.GVTaoMaLoi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMaLoi;
        private System.Windows.Forms.Button NutTaoLoi;
        private System.Windows.Forms.Button NutXoaLoi;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox listrate;
        private System.Windows.Forms.ComboBox listcom;
        private System.Windows.Forms.Button NutKetNoi;
        private System.Windows.Forms.Button NutThoat;
    }
}