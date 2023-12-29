namespace HoanThanhDangNhap
{
    partial class formThucHanh
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.chlst_fault = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chlst_comp = new System.Windows.Forms.CheckedListBox();
            this.lbyeucau = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnNutDapAn = new System.Windows.Forms.Button();
            this.cbChuong = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenChuong = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelChuyencauhoi = new System.Windows.Forms.Panel();
            this.rtb_Yeucau = new System.Windows.Forms.RichTextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelChuyencauhoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNutTaoFault
            // 
            this.btnNutTaoFault.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNutTaoFault.Location = new System.Drawing.Point(107, 649);
            this.btnNutTaoFault.Name = "btnNutTaoFault";
            this.btnNutTaoFault.Size = new System.Drawing.Size(155, 64);
            this.btnNutTaoFault.TabIndex = 3;
            this.btnNutTaoFault.Text = "Tạo lỗi";
            this.btnNutTaoFault.UseVisualStyleBackColor = true;
            this.btnNutTaoFault.Click += new System.EventHandler(this.btnNutTaoFault_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chlst_fault);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(851, 667);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 183);
            this.panel3.TabIndex = 13;
            // 
            // chlst_fault
            // 
            this.chlst_fault.CheckOnClick = true;
            this.chlst_fault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chlst_fault.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlst_fault.FormattingEnabled = true;
            this.chlst_fault.Items.AddRange(new object[] {
            "0",
            "0",
            "0"});
            this.chlst_fault.Location = new System.Drawing.Point(0, 0);
            this.chlst_fault.Name = "chlst_fault";
            this.chlst_fault.Size = new System.Drawing.Size(385, 183);
            this.chlst_fault.TabIndex = 0;
            this.chlst_fault.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chlst_fault_ItemCheck);
            this.chlst_fault.SelectedIndexChanged += new System.EventHandler(this.chlst_fault_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chlst_comp);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(416, 667);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 183);
            this.panel2.TabIndex = 12;
            // 
            // chlst_comp
            // 
            this.chlst_comp.CheckOnClick = true;
            this.chlst_comp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chlst_comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlst_comp.FormattingEnabled = true;
            this.chlst_comp.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.chlst_comp.Location = new System.Drawing.Point(0, 0);
            this.chlst_comp.Name = "chlst_comp";
            this.chlst_comp.Size = new System.Drawing.Size(408, 183);
            this.chlst_comp.TabIndex = 12;
            this.chlst_comp.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chlst_comp_ItemCheck);
            this.chlst_comp.SelectedIndexChanged += new System.EventHandler(this.chlst_comp_SelectedIndexChanged);
            // 
            // lbyeucau
            // 
            this.lbyeucau.AutoSize = true;
            this.lbyeucau.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbyeucau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbyeucau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbyeucau.Location = new System.Drawing.Point(517, 24);
            this.lbyeucau.Name = "lbyeucau";
            this.lbyeucau.Size = new System.Drawing.Size(821, 32);
            this.lbyeucau.TabIndex = 4;
            this.lbyeucau.Text = "Sinh viên chọn chương và làm theo các hướng dẫn bên dưới";
            // 
            // btnNutDapAn
            // 
            this.btnNutDapAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNutDapAn.Location = new System.Drawing.Point(1260, 667);
            this.btnNutDapAn.Name = "btnNutDapAn";
            this.btnNutDapAn.Size = new System.Drawing.Size(137, 64);
            this.btnNutDapAn.TabIndex = 14;
            this.btnNutDapAn.Text = "Đáp án";
            this.btnNutDapAn.UseVisualStyleBackColor = true;
            this.btnNutDapAn.Click += new System.EventHandler(this.btnNutDapAn_Click_1);
            // 
            // cbChuong
            // 
            this.cbChuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChuong.FormattingEnabled = true;
            this.cbChuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.cbChuong.Location = new System.Drawing.Point(176, 25);
            this.cbChuong.Name = "cbChuong";
            this.cbChuong.Size = new System.Drawing.Size(121, 37);
            this.cbChuong.TabIndex = 15;
            this.cbChuong.SelectedIndexChanged += new System.EventHandler(this.cbChuong_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(107, 759);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 64);
            this.button1.TabIndex = 18;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(172)))), ((int)(((byte)(183)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbChuong);
            this.panel1.Controls.Add(this.lblTenChuong);
            this.panel1.Location = new System.Drawing.Point(24, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 165);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Chương";
            // 
            // lblTenChuong
            // 
            this.lblTenChuong.AutoSize = true;
            this.lblTenChuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenChuong.ForeColor = System.Drawing.Color.White;
            this.lblTenChuong.Location = new System.Drawing.Point(29, 70);
            this.lblTenChuong.Name = "lblTenChuong";
            this.lblTenChuong.Size = new System.Drawing.Size(305, 64);
            this.lblTenChuong.TabIndex = 17;
            this.lblTenChuong.Text = "Mạch còi hoặc mệt...... \r\n........ gì đó";
            this.lblTenChuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(413, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1026, 580);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
      
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(412, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1026, 580);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // panelChuyencauhoi
            // 
            this.panelChuyencauhoi.BackColor = System.Drawing.Color.Transparent;
            this.panelChuyencauhoi.Controls.Add(this.rtb_Yeucau);
            this.panelChuyencauhoi.Location = new System.Drawing.Point(24, 285);
            this.panelChuyencauhoi.Name = "panelChuyencauhoi";
            this.panelChuyencauhoi.Size = new System.Drawing.Size(360, 322);
            this.panelChuyencauhoi.TabIndex = 28;
            // 
            // rtb_Yeucau
            // 
            this.rtb_Yeucau.BackColor = System.Drawing.SystemColors.Control;
            this.rtb_Yeucau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_Yeucau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Yeucau.Location = new System.Drawing.Point(0, 0);
            this.rtb_Yeucau.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Yeucau.Name = "rtb_Yeucau";
            this.rtb_Yeucau.ReadOnly = true;
            this.rtb_Yeucau.Size = new System.Drawing.Size(360, 323);
            this.rtb_Yeucau.TabIndex = 29;
            this.rtb_Yeucau.Text = "";
            // 
            // formThucHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1472, 1013);
            this.Controls.Add(this.panelChuyencauhoi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNutDapAn);
            this.Controls.Add(this.btnNutTaoFault);
            this.Controls.Add(this.lbyeucau);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formThucHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thực hành";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formThucHanh_FormClosing);
            this.Load += new System.EventHandler(this.formThucHanh_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelChuyencauhoi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNutTaoFault;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckedListBox chlst_fault;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox chlst_comp;
        private System.Windows.Forms.Label lbyeucau;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnNutDapAn;
        private System.Windows.Forms.ComboBox cbChuong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenChuong;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelChuyencauhoi;
        private System.Windows.Forms.RichTextBox rtb_Yeucau;
    }
}