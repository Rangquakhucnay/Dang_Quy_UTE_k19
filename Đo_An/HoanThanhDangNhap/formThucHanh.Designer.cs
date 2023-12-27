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
            this.label4 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnNutDapAn = new System.Windows.Forms.Button();
            this.cbChuong = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenChuong = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNutTaoFault
            // 
            this.btnNutTaoFault.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNutTaoFault.Location = new System.Drawing.Point(124, 306);
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
            this.panel3.Location = new System.Drawing.Point(850, 649);
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
            "Hở mạch",
            "Ngắn mạch nguồn",
            "Ngắn mạch GND",
            "Điện trở không mong muốn"});
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
            this.panel2.Location = new System.Drawing.Point(415, 649);
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
            "Comp #2",
            "Comp #4",
            "Comp #10"});
            this.chlst_comp.Location = new System.Drawing.Point(0, 0);
            this.chlst_comp.Name = "chlst_comp";
            this.chlst_comp.Size = new System.Drawing.Size(408, 183);
            this.chlst_comp.TabIndex = 12;
            this.chlst_comp.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chlst_comp_ItemCheck);
            this.chlst_comp.SelectedIndexChanged += new System.EventHandler(this.chlst_comp_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(408, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(858, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hãy nối dây theo mạch trên hình vẽ, sau đó nhấn nút \"Tạo lỗi\".";
            // 
            // btnNutDapAn
            // 
            this.btnNutDapAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNutDapAn.Location = new System.Drawing.Point(1258, 649);
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
            this.button1.Location = new System.Drawing.Point(124, 440);
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
            this.pictureBox1.Location = new System.Drawing.Point(415, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(980, 580);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // formThucHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 1003);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNutDapAn);
            this.Controls.Add(this.btnNutTaoFault);
            this.Controls.Add(this.label4);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formThucHanh_FormClosed);
            this.Load += new System.EventHandler(this.formThucHanh_Load);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckedListBox chlst_fault;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox chlst_comp;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnNutDapAn;
        private System.Windows.Forms.ComboBox cbChuong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenChuong;
    }
}