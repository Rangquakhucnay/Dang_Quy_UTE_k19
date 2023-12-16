namespace HoanThanhDangNhap
{
    partial class formchonbaihocchuong2
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
            this.btnTat2 = new System.Windows.Forms.Button();
            this.btnChonBaiHoc2 = new System.Windows.Forms.Button();
            this.btnTiepTuc2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTat2);
            this.panel1.Controls.Add(this.btnChonBaiHoc2);
            this.panel1.Controls.Add(this.btnTiepTuc2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 342);
            this.panel1.TabIndex = 9;
            // 
            // btnTat2
            // 
            this.btnTat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTat2.Location = new System.Drawing.Point(8, 246);
            this.btnTat2.Name = "btnTat2";
            this.btnTat2.Size = new System.Drawing.Size(308, 67);
            this.btnTat2.TabIndex = 6;
            this.btnTat2.Text = "Thoát";
            this.btnTat2.UseVisualStyleBackColor = true;
            this.btnTat2.Click += new System.EventHandler(this.btnTat2_Click);
            // 
            // btnChonBaiHoc2
            // 
            this.btnChonBaiHoc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonBaiHoc2.Location = new System.Drawing.Point(8, 28);
            this.btnChonBaiHoc2.Name = "btnChonBaiHoc2";
            this.btnChonBaiHoc2.Size = new System.Drawing.Size(308, 67);
            this.btnChonBaiHoc2.TabIndex = 7;
            this.btnChonBaiHoc2.Text = "Chọn bài học bất kỳ";
            this.btnChonBaiHoc2.UseVisualStyleBackColor = true;
            this.btnChonBaiHoc2.Click += new System.EventHandler(this.btnChonBaiHoc2_Click);
            // 
            // btnTiepTuc2
            // 
            this.btnTiepTuc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepTuc2.Location = new System.Drawing.Point(8, 137);
            this.btnTiepTuc2.Name = "btnTiepTuc2";
            this.btnTiepTuc2.Size = new System.Drawing.Size(308, 67);
            this.btnTiepTuc2.TabIndex = 5;
            this.btnTiepTuc2.Text = "Tiếp tục bài học cũ";
            this.btnTiepTuc2.UseVisualStyleBackColor = true;
            this.btnTiepTuc2.Click += new System.EventHandler(this.btnTiepTuc2_Click);
            // 
            // formchonbaihocchuong2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 414);
            this.Controls.Add(this.panel1);
            this.Name = "formchonbaihocchuong2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Bài Học";
            this.Load += new System.EventHandler(this.formchonbaihocchuong2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTat2;
        private System.Windows.Forms.Button btnChonBaiHoc2;
        private System.Windows.Forms.Button btnTiepTuc2;
    }
}