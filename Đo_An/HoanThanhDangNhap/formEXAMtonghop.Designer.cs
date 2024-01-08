namespace HoanThanhDangNhap
{
    partial class formEXAMtonghop
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
            this.btnNutDapAn = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTaode = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chlst_fault = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chlst_comp = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSoCauHoi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNutTaoFault = new System.Windows.Forms.Button();
            this.btNopbai = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.rtb_Yeucau = new System.Windows.Forms.RichTextBox();
            this.btTieptuc = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picChe = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNutDapAn
            // 
            this.btnNutDapAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNutDapAn.Location = new System.Drawing.Point(1424, 734);
            this.btnNutDapAn.Name = "btnNutDapAn";
            this.btnNutDapAn.Size = new System.Drawing.Size(146, 55);
            this.btnNutDapAn.TabIndex = 29;
            this.btnNutDapAn.Text = "Đáp án";
            this.btnNutDapAn.UseVisualStyleBackColor = true;
            this.btnNutDapAn.Click += new System.EventHandler(this.btnNutDapAn_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Silver;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(213, 864);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(155, 64);
            this.btThoat.TabIndex = 28;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btTaode
            // 
            this.btTaode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaode.Location = new System.Drawing.Point(125, 563);
            this.btTaode.Name = "btTaode";
            this.btTaode.Size = new System.Drawing.Size(155, 64);
            this.btTaode.TabIndex = 36;
            this.btTaode.Text = "Tạo đề";
            this.btTaode.UseVisualStyleBackColor = true;
            this.btTaode.Click += new System.EventHandler(this.btTaode_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chlst_fault);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(947, 683);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 171);
            this.panel3.TabIndex = 34;
            // 
            // chlst_fault
            // 
            this.chlst_fault.CheckOnClick = true;
            this.chlst_fault.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlst_fault.FormattingEnabled = true;
            this.chlst_fault.Items.AddRange(new object[] {
            "Hở mạch",
            "Nối tắt GND",
            "Nối tắt nguồn",
            "Điện trở không mong muốn"});
            this.chlst_fault.Location = new System.Drawing.Point(3, 0);
            this.chlst_fault.Name = "chlst_fault";
            this.chlst_fault.Size = new System.Drawing.Size(436, 169);
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
            this.panel2.Size = new System.Drawing.Size(524, 235);
            this.panel2.TabIndex = 33;
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
            "Comp #10",
            "Đường dây VC hoặc VCPA-VCPA2"});
            this.chlst_comp.Location = new System.Drawing.Point(0, 0);
            this.chlst_comp.Name = "chlst_comp";
            this.chlst_comp.Size = new System.Drawing.Size(524, 235);
            this.chlst_comp.TabIndex = 12;
            this.chlst_comp.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chlst_comp_ItemCheck);
            this.chlst_comp.SelectedIndexChanged += new System.EventHandler(this.chlst_comp_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(172)))), ((int)(((byte)(183)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbSoCauHoi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(36, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 148);
            this.panel1.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 32);
            this.label3.TabIndex = 37;
            this.label3.Text = "TỔNG HỢP";
            // 
            // cbSoCauHoi
            // 
            this.cbSoCauHoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoCauHoi.FormattingEnabled = true;
            this.cbSoCauHoi.Items.AddRange(new object[] {
            "2",
            "5",
            "10",
            "15",
            "20"});
            this.cbSoCauHoi.Location = new System.Drawing.Point(186, 79);
            this.cbSoCauHoi.Name = "cbSoCauHoi";
            this.cbSoCauHoi.Size = new System.Drawing.Size(121, 37);
            this.cbSoCauHoi.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Số câu hỏi";
            // 
            // btnNutTaoFault
            // 
            this.btnNutTaoFault.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNutTaoFault.Location = new System.Drawing.Point(125, 649);
            this.btnNutTaoFault.Name = "btnNutTaoFault";
            this.btnNutTaoFault.Size = new System.Drawing.Size(155, 64);
            this.btnNutTaoFault.TabIndex = 31;
            this.btnNutTaoFault.Text = "Bắt đầu";
            this.btnNutTaoFault.UseVisualStyleBackColor = true;
            this.btnNutTaoFault.Click += new System.EventHandler(this.btnNutTaoFault_Click);
            // 
            // btNopbai
            // 
            this.btNopbai.BackColor = System.Drawing.Color.Silver;
            this.btNopbai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNopbai.Location = new System.Drawing.Point(22, 864);
            this.btNopbai.Name = "btNopbai";
            this.btNopbai.Size = new System.Drawing.Size(155, 64);
            this.btNopbai.TabIndex = 27;
            this.btNopbai.Text = "Nộp bài";
            this.btNopbai.UseVisualStyleBackColor = false;
            this.btNopbai.Click += new System.EventHandler(this.btNopbai_Click);
            // 
            // rtb_Yeucau
            // 
            this.rtb_Yeucau.BackColor = System.Drawing.SystemColors.Control;
            this.rtb_Yeucau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_Yeucau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Yeucau.Location = new System.Drawing.Point(22, 237);
            this.rtb_Yeucau.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Yeucau.Name = "rtb_Yeucau";
            this.rtb_Yeucau.ReadOnly = true;
            this.rtb_Yeucau.Size = new System.Drawing.Size(358, 323);
            this.rtb_Yeucau.TabIndex = 37;
            this.rtb_Yeucau.Text = "";
            // 
            // btTieptuc
            // 
            this.btTieptuc.BackColor = System.Drawing.Color.Linen;
            this.btTieptuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTieptuc.ForeColor = System.Drawing.Color.Red;
            this.btTieptuc.Location = new System.Drawing.Point(125, 734);
            this.btTieptuc.Name = "btTieptuc";
            this.btTieptuc.Size = new System.Drawing.Size(155, 64);
            this.btTieptuc.TabIndex = 36;
            this.btTieptuc.Text = "Tiếp Tục";
            this.btTieptuc.UseVisualStyleBackColor = false;
            this.btTieptuc.Click += new System.EventHandler(this.btTieptuc_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(403, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1123, 584);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(403, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1123, 584);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // picChe
            // 
            this.picChe.Location = new System.Drawing.Point(395, 646);
            this.picChe.Name = "picChe";
            this.picChe.Size = new System.Drawing.Size(1029, 292);
            this.picChe.TabIndex = 39;
            this.picChe.TabStop = false;
            // 
            // formEXAMtonghop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 1055);
            this.Controls.Add(this.picChe);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rtb_Yeucau);
            this.Controls.Add(this.btnNutDapAn);
            this.Controls.Add(this.btNopbai);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTieptuc);
            this.Controls.Add(this.btTaode);
            this.Controls.Add(this.btnNutTaoFault);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formEXAMtonghop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm tra tổng hợp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formEXAMtonghop_FormClosing);
            this.Load += new System.EventHandler(this.formEXAMtonghop_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNutDapAn;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTaode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckedListBox chlst_fault;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox chlst_comp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSoCauHoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNutTaoFault;
        private System.Windows.Forms.Button btNopbai;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RichTextBox rtb_Yeucau;
        private System.Windows.Forms.Button btTieptuc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picChe;
    }
}