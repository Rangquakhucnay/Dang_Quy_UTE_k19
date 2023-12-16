namespace HoanThanhDangNhap
{
    partial class formExam
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
            this.btnNutTaoFault = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNutDapAn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chlst_fault = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chlst_comp = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChuong = new System.Windows.Forms.ComboBox();
            this.cbSoCauHoi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnLoadExam = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNutTaoFault
            // 
            this.btnNutTaoFault.Font = new System.Drawing.Font("Quicksand", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNutTaoFault.Location = new System.Drawing.Point(127, 363);
            this.btnNutTaoFault.Name = "btnNutTaoFault";
            this.btnNutTaoFault.Size = new System.Drawing.Size(155, 64);
            this.btnNutTaoFault.TabIndex = 16;
            this.btnNutTaoFault.Text = "Bắt đầu";
            this.btnNutTaoFault.UseVisualStyleBackColor = true;
            this.btnNutTaoFault.Click += new System.EventHandler(this.btnNutTaoFault_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Quicksand", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(396, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 41);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hãy đấu dây theo mạch sau";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Quicksand", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(127, 750);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Quicksand", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(127, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "Nộp bài";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNutDapAn
            // 
            this.btnNutDapAn.Font = new System.Drawing.Font("Quicksand", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNutDapAn.Location = new System.Drawing.Point(1238, 649);
            this.btnNutDapAn.Name = "btnNutDapAn";
            this.btnNutDapAn.Size = new System.Drawing.Size(146, 55);
            this.btnNutDapAn.TabIndex = 8;
            this.btnNutDapAn.Text = "Đáp án";
            this.btnNutDapAn.UseVisualStyleBackColor = true;
            this.btnNutDapAn.Click += new System.EventHandler(this.btnNutDapAn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chlst_fault);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(834, 649);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(389, 183);
            this.panel3.TabIndex = 19;
            // 
            // chlst_fault
            // 
            this.chlst_fault.CheckOnClick = true;
            this.chlst_fault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chlst_fault.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlst_fault.FormattingEnabled = true;
            this.chlst_fault.Items.AddRange(new object[] {
            "Hở mạch",
            "Nối tắt GND",
            "Nối tắt nguồn",
            "Điện trở không mong muốn"});
            this.chlst_fault.Location = new System.Drawing.Point(0, 0);
            this.chlst_fault.Name = "chlst_fault";
            this.chlst_fault.Size = new System.Drawing.Size(389, 183);
            this.chlst_fault.TabIndex = 0;
            this.chlst_fault.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chlst_fault_ItemCheck);
            this.chlst_fault.SelectedIndexChanged += new System.EventHandler(this.chlst_fault_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chlst_comp);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(403, 649);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 183);
            this.panel2.TabIndex = 18;
            // 
            // chlst_comp
            // 
            this.chlst_comp.CheckOnClick = true;
            this.chlst_comp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chlst_comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlst_comp.FormattingEnabled = true;
            this.chlst_comp.Items.AddRange(new object[] {
            "Comp #2",
            "Comp #4",
            "Comp #10"});
            this.chlst_comp.Location = new System.Drawing.Point(0, 0);
            this.chlst_comp.Name = "chlst_comp";
            this.chlst_comp.Size = new System.Drawing.Size(407, 183);
            this.chlst_comp.TabIndex = 12;
            this.chlst_comp.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chlst_comp_ItemCheck);
            this.chlst_comp.SelectedIndexChanged += new System.EventHandler(this.chlst_comp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Quicksand", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 41);
            this.label1.TabIndex = 21;
            this.label1.Text = "Chương";
            // 
            // cbChuong
            // 
            this.cbChuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChuong.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChuong.FormattingEnabled = true;
            this.cbChuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbChuong.Location = new System.Drawing.Point(184, 22);
            this.cbChuong.Name = "cbChuong";
            this.cbChuong.Size = new System.Drawing.Size(121, 42);
            this.cbChuong.TabIndex = 22;
            // 
            // cbSoCauHoi
            // 
            this.cbSoCauHoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoCauHoi.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoCauHoi.FormattingEnabled = true;
            this.cbSoCauHoi.Items.AddRange(new object[] {
            "2",
            "5",
            "10",
            "15",
            "20"});
            this.cbSoCauHoi.Location = new System.Drawing.Point(185, 88);
            this.cbSoCauHoi.Name = "cbSoCauHoi";
            this.cbSoCauHoi.Size = new System.Drawing.Size(121, 42);
            this.cbSoCauHoi.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Quicksand", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 41);
            this.label2.TabIndex = 23;
            this.label2.Text = "Số câu hỏi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(172)))), ((int)(((byte)(183)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbSoCauHoi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbChuong);
            this.panel1.Location = new System.Drawing.Point(38, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 148);
            this.panel1.TabIndex = 25;
            // 
            // btnLoadExam
            // 
            this.btnLoadExam.Font = new System.Drawing.Font("Quicksand", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadExam.Location = new System.Drawing.Point(127, 261);
            this.btnLoadExam.Name = "btnLoadExam";
            this.btnLoadExam.Size = new System.Drawing.Size(155, 64);
            this.btnLoadExam.TabIndex = 26;
            this.btnLoadExam.Text = "Tạo đề";
            this.btnLoadExam.UseVisualStyleBackColor = true;
            this.btnLoadExam.Click += new System.EventHandler(this.btnLoadExam_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(403, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(981, 582);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Quicksand", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(67, 649);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 68);
            this.button1.TabIndex = 27;
            this.button1.Text = "Kiểm tra tổng hợp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 1003);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNutDapAn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLoadExam);
            this.Controls.Add(this.btnNutTaoFault);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm tra theo chương";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formExam_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formExam_FormClosed);
            this.Load += new System.EventHandler(this.formExam_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNutTaoFault;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNutDapAn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckedListBox chlst_fault;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox chlst_comp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChuong;
        private System.Windows.Forms.ComboBox cbSoCauHoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnLoadExam;
        private System.Windows.Forms.Button button1;
    }
}