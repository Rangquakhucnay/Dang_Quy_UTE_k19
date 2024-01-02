namespace HoanThanhDangNhap
{
    partial class formHienThiBaiHoc3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHienThiBaiHoc3));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.serCom = new System.IO.Ports.SerialPort(this.components);
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.gbBox1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDientro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDLTT = new System.Windows.Forms.TextBox();
            this.txtNhietdo = new System.Windows.Forms.TextBox();
            this.txtOnoff = new System.Windows.Forms.TextBox();
            this.txtVon = new System.Windows.Forms.TextBox();
            this.lbTendothi = new System.Windows.Forms.Label();
            this.btChaydothi = new System.Windows.Forms.Button();
            this.txtQues = new System.Windows.Forms.TextBox();
            this.chlstDapAn = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btDientinhhieu = new System.Windows.Forms.Button();
            this.picChe = new System.Windows.Forms.PictureBox();
            this.lbnhanso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtb_Baihoc = new System.Windows.Forms.RichTextBox();
            this.panelWiring = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChe)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelWiring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(-16, -11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(88, 50);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
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
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
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
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(44, 4);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(35, 35);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // serCom
            // 
            this.serCom.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCom_DataReceived);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(270, 12);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(742, 617);
            this.zedGraphControl1.TabIndex = 2;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // gbBox1
            // 
            this.gbBox1.Controls.Add(this.label10);
            this.gbBox1.Controls.Add(this.label9);
            this.gbBox1.Controls.Add(this.txtDientro);
            this.gbBox1.Controls.Add(this.label7);
            this.gbBox1.Controls.Add(this.label8);
            this.gbBox1.Controls.Add(this.label6);
            this.gbBox1.Controls.Add(this.label5);
            this.gbBox1.Controls.Add(this.txtIDLTT);
            this.gbBox1.Controls.Add(this.txtNhietdo);
            this.gbBox1.Controls.Add(this.txtOnoff);
            this.gbBox1.Controls.Add(this.txtVon);
            this.gbBox1.Controls.Add(this.lbTendothi);
            this.gbBox1.Controls.Add(this.btChaydothi);
            this.gbBox1.Controls.Add(this.zedGraphControl1);
            this.gbBox1.Location = new System.Drawing.Point(61, 3);
            this.gbBox1.Name = "gbBox1";
            this.gbBox1.Size = new System.Drawing.Size(1491, 699);
            this.gbBox1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1313, 471);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "IDLTT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1321, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ôm";
            // 
            // txtDientro
            // 
            this.txtDientro.Location = new System.Drawing.Point(1162, 349);
            this.txtDientro.Name = "txtDientro";
            this.txtDientro.Size = new System.Drawing.Size(100, 22);
            this.txtDientro.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1313, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "◦C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1059, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Đóng/ mở";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1303, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Van Trược";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1318, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "V";
            // 
            // txtIDLTT
            // 
            this.txtIDLTT.Location = new System.Drawing.Point(1162, 471);
            this.txtIDLTT.Name = "txtIDLTT";
            this.txtIDLTT.Size = new System.Drawing.Size(100, 22);
            this.txtIDLTT.TabIndex = 5;
            // 
            // txtNhietdo
            // 
            this.txtNhietdo.Location = new System.Drawing.Point(1162, 286);
            this.txtNhietdo.Name = "txtNhietdo";
            this.txtNhietdo.Size = new System.Drawing.Size(100, 22);
            this.txtNhietdo.TabIndex = 5;
            // 
            // txtOnoff
            // 
            this.txtOnoff.Location = new System.Drawing.Point(1162, 425);
            this.txtOnoff.Name = "txtOnoff";
            this.txtOnoff.Size = new System.Drawing.Size(100, 22);
            this.txtOnoff.TabIndex = 5;
            // 
            // txtVon
            // 
            this.txtVon.Location = new System.Drawing.Point(1162, 219);
            this.txtVon.Name = "txtVon";
            this.txtVon.Size = new System.Drawing.Size(100, 22);
            this.txtVon.TabIndex = 5;
            // 
            // lbTendothi
            // 
            this.lbTendothi.AutoSize = true;
            this.lbTendothi.BackColor = System.Drawing.Color.Linen;
            this.lbTendothi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTendothi.Location = new System.Drawing.Point(489, 648);
            this.lbTendothi.Name = "lbTendothi";
            this.lbTendothi.Size = new System.Drawing.Size(305, 32);
            this.lbTendothi.TabIndex = 4;
            this.lbTendothi.Text = "Tên của đồ thị ..........";
            // 
            // btChaydothi
            // 
            this.btChaydothi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btChaydothi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChaydothi.Location = new System.Drawing.Point(19, 437);
            this.btChaydothi.Name = "btChaydothi";
            this.btChaydothi.Size = new System.Drawing.Size(228, 56);
            this.btChaydothi.TabIndex = 3;
            this.btChaydothi.Text = "Chạy đồ thị";
            this.btChaydothi.UseVisualStyleBackColor = false;
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
            this.panel2.Controls.Add(this.btDientinhhieu);
            this.panel2.Controls.Add(this.picChe);
            this.panel2.Controls.Add(this.chlstDapAn);
            this.panel2.Controls.Add(this.txtQues);
            this.panel2.Location = new System.Drawing.Point(2, 687);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1496, 272);
            this.panel2.TabIndex = 11;
            // 
            // btDientinhhieu
            // 
            this.btDientinhhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDientinhhieu.Location = new System.Drawing.Point(814, 123);
            this.btDientinhhieu.Name = "btDientinhhieu";
            this.btDientinhhieu.Size = new System.Drawing.Size(179, 44);
            this.btDientinhhieu.TabIndex = 4;
            this.btDientinhhieu.Text = "Tiếp Theo";
            this.btDientinhhieu.UseVisualStyleBackColor = true;
            this.btDientinhhieu.Click += new System.EventHandler(this.btDientinhhieu_Click);
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
            // lbnhanso
            // 
            this.lbnhanso.AutoSize = true;
            this.lbnhanso.Location = new System.Drawing.Point(1701, 830);
            this.lbnhanso.Name = "lbnhanso";
            this.lbnhanso.Size = new System.Drawing.Size(44, 16);
            this.lbnhanso.TabIndex = 18;
            this.lbnhanso.Text = "label5";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rtb_Baihoc);
            this.panel1.Location = new System.Drawing.Point(37, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1638, 631);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(450, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1185, 611);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // rtb_Baihoc
            // 
            this.rtb_Baihoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_Baihoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Baihoc.Location = new System.Drawing.Point(3, 10);
            this.rtb_Baihoc.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Baihoc.Name = "rtb_Baihoc";
            this.rtb_Baihoc.ReadOnly = true;
            this.rtb_Baihoc.Size = new System.Drawing.Size(444, 611);
            this.rtb_Baihoc.TabIndex = 2;
            this.rtb_Baihoc.Text = "";
            // 
            // panelWiring
            // 
            this.panelWiring.Controls.Add(this.flowLayoutPanel3);
            this.panelWiring.Controls.Add(this.button1);
            this.panelWiring.Controls.Add(this.button2);
            this.panelWiring.Controls.Add(this.pictureBox2);
            this.panelWiring.Location = new System.Drawing.Point(23, 9);
            this.panelWiring.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelWiring.Name = "panelWiring";
            this.panelWiring.Size = new System.Drawing.Size(1649, 651);
            this.panelWiring.TabIndex = 22;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel3.Location = new System.Drawing.Point(762, 569);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(388, 46);
            this.flowLayoutPanel3.TabIndex = 1;
            this.flowLayoutPanel3.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(722, 577);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(1155, 577);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(475, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(935, 551);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // formHienThiBaiHoc3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1890, 950);
            this.Controls.Add(this.gbBox1);
            this.Controls.Add(this.panelWiring);
            this.Controls.Add(this.lbnhanso);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formHienThiBaiHoc3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài học";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formHienThiBaiHoc_FormClosed);
            this.Load += new System.EventHandler(this.formHienThiBaiHoc_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gbBox1.ResumeLayout(false);
            this.gbBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChe)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelWiring.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.IO.Ports.SerialPort serCom;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Panel gbBox1;
        private System.Windows.Forms.TextBox txtQues;
        private System.Windows.Forms.CheckedListBox chlstDapAn;
        private System.Windows.Forms.PictureBox picChe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtb_Baihoc;
        private System.Windows.Forms.Panel panelWiring;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btChaydothi;
        private System.Windows.Forms.Label lbTendothi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btDientinhhieu;
        private System.Windows.Forms.Label lbnhanso;
        private System.Windows.Forms.TextBox txtNhietdo;
        private System.Windows.Forms.TextBox txtOnoff;
        private System.Windows.Forms.TextBox txtVon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDientro;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDLTT;
       
    }
}