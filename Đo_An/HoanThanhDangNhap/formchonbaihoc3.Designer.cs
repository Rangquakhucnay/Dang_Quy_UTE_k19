namespace HoanThanhDangNhap
{
    partial class formchonbaihoc3
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
            this.btnTat = new System.Windows.Forms.Button();
            this.btnChonBaiHoc = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTat
            // 
            this.btnTat.Font = new System.Drawing.Font("Quicksand", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTat.Location = new System.Drawing.Point(8, 246);
            this.btnTat.Name = "btnTat";
            this.btnTat.Size = new System.Drawing.Size(308, 67);
            this.btnTat.TabIndex = 6;
            this.btnTat.Text = "Thoát";
            this.btnTat.UseVisualStyleBackColor = true;
            this.btnTat.Click += new System.EventHandler(this.btnTat_Click);
            // 
            // btnChonBaiHoc
            // 
            this.btnChonBaiHoc.Font = new System.Drawing.Font("Quicksand", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonBaiHoc.Location = new System.Drawing.Point(8, 28);
            this.btnChonBaiHoc.Name = "btnChonBaiHoc";
            this.btnChonBaiHoc.Size = new System.Drawing.Size(308, 67);
            this.btnChonBaiHoc.TabIndex = 7;
            this.btnChonBaiHoc.Text = "Chọn bài học bất kỳ";
            this.btnChonBaiHoc.UseVisualStyleBackColor = true;
            this.btnChonBaiHoc.Click += new System.EventHandler(this.btnChonBaiHoc_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Font = new System.Drawing.Font("Quicksand", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepTuc.Location = new System.Drawing.Point(8, 137);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(308, 67);
            this.btnTiepTuc.TabIndex = 5;
            this.btnTiepTuc.Text = "Tiếp tục bài học cũ";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTat);
            this.panel1.Controls.Add(this.btnChonBaiHoc);
            this.panel1.Controls.Add(this.btnTiepTuc);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(29, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 342);
            this.panel1.TabIndex = 8;
            // 
            // formChonBaiHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(382, 388);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formChonBaiHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn bài học";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formChonBaiHoc_FormClosed);
          
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTat;
        private System.Windows.Forms.Button btnChonBaiHoc;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Panel panel1;
    }
}