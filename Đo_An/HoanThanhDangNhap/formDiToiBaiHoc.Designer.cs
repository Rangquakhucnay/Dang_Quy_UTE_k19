namespace HoanThanhDangNhap
{
    partial class formDiToiBaiHoc
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbSttChuongBH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSoActiBH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTenBaiHoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(106, 204);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 62);
            this.button2.TabIndex = 12;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(172)))), ((int)(((byte)(183)))));
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(367, 204);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(132, 62);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbSttChuongBH
            // 
            this.cbSttChuongBH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSttChuongBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSttChuongBH.FormattingEnabled = true;
            this.cbSttChuongBH.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbSttChuongBH.Location = new System.Drawing.Point(243, 43);
            this.cbSttChuongBH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSttChuongBH.Name = "cbSttChuongBH";
            this.cbSttChuongBH.Size = new System.Drawing.Size(65, 37);
            this.cbSttChuongBH.TabIndex = 10;
            this.cbSttChuongBH.SelectedIndexChanged += new System.EventHandler(this.cbTenChuong_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bài";
            // 
            // cbSoActiBH
            // 
            this.cbSoActiBH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoActiBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoActiBH.FormattingEnabled = true;
            this.cbSoActiBH.Location = new System.Drawing.Point(243, 117);
            this.cbSoActiBH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSoActiBH.Name = "cbSoActiBH";
            this.cbSoActiBH.Size = new System.Drawing.Size(65, 37);
            this.cbSoActiBH.TabIndex = 15;
            this.cbSoActiBH.SelectedIndexChanged += new System.EventHandler(this.cbSoActiBH_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 38);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hoạt động";
            // 
            // lblTenBaiHoc
            // 
            this.lblTenBaiHoc.AutoSize = true;
            this.lblTenBaiHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBaiHoc.Location = new System.Drawing.Point(361, 48);
            this.lblTenBaiHoc.Name = "lblTenBaiHoc";
            this.lblTenBaiHoc.Size = new System.Drawing.Size(387, 32);
            this.lblTenBaiHoc.TabIndex = 11;
            this.lblTenBaiHoc.Text = "hiện tên chương dài hay ngắn";
            // 
            // formDiToiBaiHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 298);
            this.Controls.Add(this.cbSoActiBH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTenBaiHoc);
            this.Controls.Add(this.cbSttChuongBH);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formDiToiBaiHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn bài học";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formDiToiBaiHoc_FormClosed);
            this.Load += new System.EventHandler(this.formDiToiBaiHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbSttChuongBH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSoActiBH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTenBaiHoc;
    }
}