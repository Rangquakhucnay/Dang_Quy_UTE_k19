namespace HoanThanhDangNhap
{
    partial class VPAtuyentinh2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdapan = new System.Windows.Forms.TextBox();
            this.lbCauhoi = new System.Windows.Forms.Label();
            this.btNext = new System.Windows.Forms.Button();
            this.btcheck = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 423);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(451, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 700);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhiệt độ môi trường trong lúc này là:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(341, 296);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HoanThanhDangNhap.Properties.Resources.Screenshot_2023_12_08_153203;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(815, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btBack);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtdapan);
            this.panel3.Controls.Add(this.lbCauhoi);
            this.panel3.Controls.Add(this.btNext);
            this.panel3.Controls.Add(this.btcheck);
            this.panel3.Location = new System.Drawing.Point(3, 518);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1419, 215);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lấy tín hiệu VTA (sai số ± 0,3 V)";
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(1240, 129);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(145, 53);
            this.btBack.TabIndex = 6;
            this.btBack.Text = "BACK";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(673, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "V";
            // 
            // txtdapan
            // 
            this.txtdapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdapan.Location = new System.Drawing.Point(484, 111);
            this.txtdapan.Name = "txtdapan";
            this.txtdapan.Size = new System.Drawing.Size(152, 34);
            this.txtdapan.TabIndex = 4;
            // 
            // lbCauhoi
            // 
            this.lbCauhoi.AutoSize = true;
            this.lbCauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCauhoi.Location = new System.Drawing.Point(18, 19);
            this.lbCauhoi.Name = "lbCauhoi";
            this.lbCauhoi.Size = new System.Drawing.Size(883, 29);
            this.lbCauhoi.TabIndex = 3;
            this.lbCauhoi.Text = "Câu 2: Đo điện trở cảm biến ở chân THA theo nhiệt độ môi trường Yêu cầu: ";
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(1240, 44);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(145, 53);
            this.btNext.TabIndex = 1;
            this.btNext.Text = "NEXT";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btcheck
            // 
            this.btcheck.Location = new System.Drawing.Point(1024, 116);
            this.btcheck.Name = "btcheck";
            this.btcheck.Size = new System.Drawing.Size(173, 53);
            this.btcheck.TabIndex = 0;
            this.btcheck.Text = "Check";
            this.btcheck.UseVisualStyleBackColor = true;
            this.btcheck.Click += new System.EventHandler(this.btcheck_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1419, 79);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(808, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bài 1: Cảm Biến Lưu Lượng Không Khí Nạp Kiểu Dây Nhiệt";
            // 
            // VTAhall1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 734);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "VTAhall1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VTAhall1_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btcheck;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbCauhoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdapan;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label4;
    }
}