namespace HoanThanhDangNhap
{
    partial class formHienThiBaiHoc2
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtb_Baihoc = new System.Windows.Forms.RichTextBox();
            this.chlstDapAn = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picChe = new System.Windows.Forms.PictureBox();
            this.txtQues = new System.Windows.Forms.TextBox();
            this.panelVideo = new System.Windows.Forms.Panel();
            this.PrevPicVideo = new System.Windows.Forms.Button();
            this.NextPicVideo = new System.Windows.Forms.Button();
            this.picPanelVideo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelWiring = new System.Windows.Forms.Panel();
            this.bt1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChe)).BeginInit();
            this.panelVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPanelVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelWiring.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonRight);
            this.flowLayoutPanel1.Controls.Add(this.buttonLeft);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(70, 47);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(89, 46);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.Transparent;
            this.buttonRight.BackgroundImage = global::HoanThanhDangNhap.Properties.Resources.Icons8_Ios7_Arrows_Back_512;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(3, 4);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(35, 35);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.Transparent;
            this.buttonLeft.BackgroundImage = global::HoanThanhDangNhap.Properties.Resources.Icons8_Ios7_Arrows_Forward_512;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(44, 4);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(35, 35);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1783, 46);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(108, 854);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1558, 801);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 68);
            this.button3.TabIndex = 14;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(1558, 701);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 68);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtb_Baihoc);
            this.panel1.Location = new System.Drawing.Point(2, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 669);
            this.panel1.TabIndex = 10;
            // 
            // rtb_Baihoc
            // 
            this.rtb_Baihoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_Baihoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Baihoc.Location = new System.Drawing.Point(7, 0);
            this.rtb_Baihoc.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Baihoc.Name = "rtb_Baihoc";
            this.rtb_Baihoc.ReadOnly = true;
            this.rtb_Baihoc.Size = new System.Drawing.Size(800, 669);
            this.rtb_Baihoc.TabIndex = 2;
            this.rtb_Baihoc.Text = "";
            // 
            // chlstDapAn
            // 
            this.chlstDapAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chlstDapAn.CheckOnClick = true;
            this.chlstDapAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlstDapAn.FormattingEnabled = true;
            this.chlstDapAn.Items.AddRange(new object[] {
            "ggggggggggg",
            "yyyyyyyyyyyyyy",
            "pppppp",
            "XXXXXXXXXX"});
            this.chlstDapAn.Location = new System.Drawing.Point(0, 123);
            this.chlstDapAn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chlstDapAn.Name = "chlstDapAn";
            this.chlstDapAn.Size = new System.Drawing.Size(1496, 167);
            this.chlstDapAn.TabIndex = 1;
            this.chlstDapAn.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chlstDapAn_ItemCheck);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picChe);
            this.panel2.Controls.Add(this.chlstDapAn);
            this.panel2.Controls.Add(this.txtQues);
            this.panel2.Location = new System.Drawing.Point(2, 687);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1496, 272);
            this.panel2.TabIndex = 11;
            // 
            // picChe
            // 
            this.picChe.BackColor = System.Drawing.Color.Transparent;
            this.picChe.Location = new System.Drawing.Point(-1, 0);
            this.picChe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picChe.Name = "picChe";
            this.picChe.Size = new System.Drawing.Size(1497, 318);
            this.picChe.TabIndex = 17;
            this.picChe.TabStop = false;
            // 
            // txtQues
            // 
            this.txtQues.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtQues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQues.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQues.Location = new System.Drawing.Point(0, 0);
            this.txtQues.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQues.Multiline = true;
            this.txtQues.Name = "txtQues";
            this.txtQues.ReadOnly = true;
            this.txtQues.Size = new System.Drawing.Size(1496, 124);
            this.txtQues.TabIndex = 0;
            // 
            // panelVideo
            // 
            this.panelVideo.Controls.Add(this.PrevPicVideo);
            this.panelVideo.Controls.Add(this.NextPicVideo);
            this.panelVideo.Controls.Add(this.picPanelVideo);
            this.panelVideo.Location = new System.Drawing.Point(121, 162);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(1651, 514);
            this.panelVideo.TabIndex = 3;
            // 
            // PrevPicVideo
            // 
            this.PrevPicVideo.BackgroundImage = global::HoanThanhDangNhap.Properties.Resources.Icons8_Ios7_Arrows_Back_512;
            this.PrevPicVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PrevPicVideo.Location = new System.Drawing.Point(3, 285);
            this.PrevPicVideo.Name = "PrevPicVideo";
            this.PrevPicVideo.Size = new System.Drawing.Size(60, 55);
            this.PrevPicVideo.TabIndex = 1;
            this.PrevPicVideo.UseVisualStyleBackColor = true;
            this.PrevPicVideo.Click += new System.EventHandler(this.PrevPicVideo_Click);
            // 
            // NextPicVideo
            // 
            this.NextPicVideo.BackgroundImage = global::HoanThanhDangNhap.Properties.Resources.Icons8_Ios7_Arrows_Forward_512;
            this.NextPicVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NextPicVideo.Location = new System.Drawing.Point(1715, 301);
            this.NextPicVideo.Name = "NextPicVideo";
            this.NextPicVideo.Size = new System.Drawing.Size(60, 55);
            this.NextPicVideo.TabIndex = 2;
            this.NextPicVideo.UseVisualStyleBackColor = true;
            this.NextPicVideo.Click += new System.EventHandler(this.NextPicVideo_Click);
            // 
            // picPanelVideo
            // 
            this.picPanelVideo.Location = new System.Drawing.Point(69, 3);
            this.picPanelVideo.Name = "picPanelVideo";
            this.picPanelVideo.Size = new System.Drawing.Size(1706, 668);
            this.picPanelVideo.TabIndex = 0;
            this.picPanelVideo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(815, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(954, 678);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1778, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hoạt động:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(-16, -11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(88, 50);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(1783, 900);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(39, 30);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(336, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1115, 655);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelWiring
            // 
            this.panelWiring.Controls.Add(this.pictureBox2);
            this.panelWiring.Location = new System.Drawing.Point(9, 10);
            this.panelWiring.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelWiring.Name = "panelWiring";
            this.panelWiring.Size = new System.Drawing.Size(1768, 683);
            this.panelWiring.TabIndex = 15;
            this.panelWiring.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWiring_Paint);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(1613, 907);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 20;
            this.bt1.Text = "button1";
            this.bt1.UseVisualStyleBackColor = true;
            // 
            // formHienThiBaiHoc2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1890, 950);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelWiring);
            this.Controls.Add(this.panelVideo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formHienThiBaiHoc2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài học";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formHienThiBaiHoc_FormClosed);
            this.Load += new System.EventHandler(this.formHienThiBaiHoc_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChe)).EndInit();
            this.panelVideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPanelVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelWiring.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtb_Baihoc;
        private System.Windows.Forms.CheckedListBox chlstDapAn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picChe;
        private System.Windows.Forms.TextBox txtQues;
        private System.Windows.Forms.Panel panelVideo;
        private System.Windows.Forms.Button NextPicVideo;
        private System.Windows.Forms.Button PrevPicVideo;
        private System.Windows.Forms.PictureBox picPanelVideo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelWiring;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bt1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}