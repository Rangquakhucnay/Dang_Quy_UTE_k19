namespace HoanThanhDangNhap
{
    partial class taoaccount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenLopMoi = new System.Windows.Forms.TextBox();
            this.NutThemLop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NutXoaLop = new System.Windows.Forms.Button();
            this.lvDanhSachLop = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NutXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NutXemTienDo = new System.Windows.Forms.Button();
            this.NutSua = new System.Windows.Forms.Button();
            this.txtLopmoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatkhaumoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTendangnhapmoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NutThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTensinhvienmoi = new System.Windows.Forms.TextBox();
            this.lvLop = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NutDangXuat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenLopMoi);
            this.groupBox1.Controls.Add(this.NutThemLop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo lớp mới:";
            // 
            // txtTenLopMoi
            // 
            this.txtTenLopMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLopMoi.Location = new System.Drawing.Point(120, 58);
            this.txtTenLopMoi.Name = "txtTenLopMoi";
            this.txtTenLopMoi.Size = new System.Drawing.Size(294, 38);
            this.txtTenLopMoi.TabIndex = 5;
            // 
            // NutThemLop
            // 
            this.NutThemLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutThemLop.Location = new System.Drawing.Point(240, 118);
            this.NutThemLop.Name = "NutThemLop";
            this.NutThemLop.Size = new System.Drawing.Size(174, 44);
            this.NutThemLop.TabIndex = 6;
            this.NutThemLop.Text = "Thêm lớp";
            this.NutThemLop.UseVisualStyleBackColor = true;
            this.NutThemLop.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên lớp:";
            // 
            // NutXoaLop
            // 
            this.NutXoaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutXoaLop.Location = new System.Drawing.Point(286, 904);
            this.NutXoaLop.Name = "NutXoaLop";
            this.NutXoaLop.Size = new System.Drawing.Size(174, 50);
            this.NutXoaLop.TabIndex = 7;
            this.NutXoaLop.Text = "Xóa lớp";
            this.NutXoaLop.UseVisualStyleBackColor = true;
            this.NutXoaLop.Click += new System.EventHandler(this.NutXoaLop_Click);
            // 
            // lvDanhSachLop
            // 
            this.lvDanhSachLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDanhSachLop.FullRowSelect = true;
            this.lvDanhSachLop.GridLines = true;
            this.lvDanhSachLop.HideSelection = false;
            this.lvDanhSachLop.Location = new System.Drawing.Point(513, 249);
            this.lvDanhSachLop.Name = "lvDanhSachLop";
            this.lvDanhSachLop.Size = new System.Drawing.Size(1000, 624);
            this.lvDanhSachLop.TabIndex = 11;
            this.lvDanhSachLop.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachLop.View = System.Windows.Forms.View.Details;
            this.lvDanhSachLop.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachLop_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên sinh viên";
            this.columnHeader3.Width = 270;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên đăng nhập";
            this.columnHeader4.Width = 240;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mật khẩu";
            this.columnHeader5.Width = 237;
            // 
            // NutXoa
            // 
            this.NutXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutXoa.Location = new System.Drawing.Point(1253, 904);
            this.NutXoa.Name = "NutXoa";
            this.NutXoa.Size = new System.Drawing.Size(260, 50);
            this.NutXoa.TabIndex = 13;
            this.NutXoa.Text = "Xóa tài khoản";
            this.NutXoa.UseVisualStyleBackColor = true;
            this.NutXoa.Click += new System.EventHandler(this.NutXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.NutXemTienDo);
            this.groupBox2.Controls.Add(this.NutSua);
            this.groupBox2.Controls.Add(this.txtLopmoi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMatkhaumoi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTendangnhapmoi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NutThem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTensinhvienmoi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1567, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 576);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm/Sửa Tài khoản sinh viên:";
            // 
            // NutXemTienDo
            // 
            this.NutXemTienDo.Location = new System.Drawing.Point(126, 484);
            this.NutXemTienDo.Name = "NutXemTienDo";
            this.NutXemTienDo.Size = new System.Drawing.Size(182, 71);
            this.NutXemTienDo.TabIndex = 10;
            this.NutXemTienDo.Text = "Xem tiến độ";
            this.NutXemTienDo.UseVisualStyleBackColor = true;
            this.NutXemTienDo.Click += new System.EventHandler(this.NutXemTienDo_Click);
            // 
            // NutSua
            // 
            this.NutSua.Location = new System.Drawing.Point(248, 386);
            this.NutSua.Name = "NutSua";
            this.NutSua.Size = new System.Drawing.Size(132, 61);
            this.NutSua.TabIndex = 9;
            this.NutSua.Text = "Sửa";
            this.NutSua.UseVisualStyleBackColor = true;
            this.NutSua.Click += new System.EventHandler(this.NutSua_Click);
            // 
            // txtLopmoi
            // 
            this.txtLopmoi.Location = new System.Drawing.Point(199, 285);
            this.txtLopmoi.Name = "txtLopmoi";
            this.txtLopmoi.Size = new System.Drawing.Size(225, 34);
            this.txtLopmoi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã lớp:";
            // 
            // txtMatkhaumoi
            // 
            this.txtMatkhaumoi.Location = new System.Drawing.Point(199, 214);
            this.txtMatkhaumoi.Name = "txtMatkhaumoi";
            this.txtMatkhaumoi.Size = new System.Drawing.Size(225, 34);
            this.txtMatkhaumoi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mật khẩu:";
            // 
            // txtTendangnhapmoi
            // 
            this.txtTendangnhapmoi.Location = new System.Drawing.Point(199, 145);
            this.txtTendangnhapmoi.Name = "txtTendangnhapmoi";
            this.txtTendangnhapmoi.Size = new System.Drawing.Size(225, 34);
            this.txtTendangnhapmoi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên đăng nhập:";
            // 
            // NutThem
            // 
            this.NutThem.Location = new System.Drawing.Point(55, 386);
            this.NutThem.Name = "NutThem";
            this.NutThem.Size = new System.Drawing.Size(132, 61);
            this.NutThem.TabIndex = 2;
            this.NutThem.Text = "Thêm";
            this.NutThem.UseVisualStyleBackColor = true;
            this.NutThem.Click += new System.EventHandler(this.NutThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên sinh viên:";
            // 
            // txtTensinhvienmoi
            // 
            this.txtTensinhvienmoi.Location = new System.Drawing.Point(199, 72);
            this.txtTensinhvienmoi.Name = "txtTensinhvienmoi";
            this.txtTensinhvienmoi.Size = new System.Drawing.Size(225, 34);
            this.txtTensinhvienmoi.TabIndex = 0;
            // 
            // lvLop
            // 
            this.lvLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLop.FullRowSelect = true;
            this.lvLop.GridLines = true;
            this.lvLop.HideSelection = false;
            this.lvLop.Location = new System.Drawing.Point(31, 249);
            this.lvLop.Name = "lvLop";
            this.lvLop.Size = new System.Drawing.Size(429, 624);
            this.lvLop.TabIndex = 7;
            this.lvLop.UseCompatibleStateImageBehavior = false;
            this.lvLop.View = System.Windows.Forms.View.Details;
            this.lvLop.SelectedIndexChanged += new System.EventHandler(this.lvLop_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Lớp";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Lớp";
            this.columnHeader2.Width = 119;
            // 
            // NutDangXuat
            // 
            this.NutDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NutDangXuat.Location = new System.Drawing.Point(1368, 83);
            this.NutDangXuat.Name = "NutDangXuat";
            this.NutDangXuat.Size = new System.Drawing.Size(145, 66);
            this.NutDangXuat.TabIndex = 16;
            this.NutDangXuat.Text = "Thoát";
            this.NutDangXuat.UseVisualStyleBackColor = true;
            this.NutDangXuat.Click += new System.EventHandler(this.button2_Click);
            // 
            // taoaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NutDangXuat);
            this.Controls.Add(this.lvLop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.NutXoa);
            this.Controls.Add(this.lvDanhSachLop);
            this.Controls.Add(this.NutXoaLop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "taoaccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginAd_FormClosed);
            this.Load += new System.EventHandler(this.LoginAd_Load);
            this.Click += new System.EventHandler(this.LoginAd_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenLopMoi;
        private System.Windows.Forms.Button NutThemLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NutXoaLop;
        private System.Windows.Forms.ListView lvDanhSachLop;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button NutXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button NutThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTensinhvienmoi;
        private System.Windows.Forms.Button NutSua;
        private System.Windows.Forms.TextBox txtLopmoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatkhaumoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTendangnhapmoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvLop;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button NutDangXuat;
        private System.Windows.Forms.Button NutXemTienDo;
    }
}