namespace HoanThanhDangNhap
{
    partial class formDiToiBaiHoc2
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
            this.cbSoActiBH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btthoat = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblTenBaiHoc = new System.Windows.Forms.Label();
            this.cbSttChuongBH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbSoActiBH
            // 
            this.cbSoActiBH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoActiBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoActiBH.FormattingEnabled = true;
            this.cbSoActiBH.Location = new System.Drawing.Point(249, 114);
            this.cbSoActiBH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSoActiBH.Name = "cbSoActiBH";
            this.cbSoActiBH.Size = new System.Drawing.Size(65, 37);
            this.cbSoActiBH.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 38);
            this.label3.TabIndex = 21;
            this.label3.Text = "Hoạt động";
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(115, 201);
            this.btthoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(132, 62);
            this.btthoat.TabIndex = 19;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(172)))), ((int)(((byte)(183)))));
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(376, 201);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(132, 62);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblTenBaiHoc
            // 
            this.lblTenBaiHoc.AutoSize = true;
            this.lblTenBaiHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBaiHoc.Location = new System.Drawing.Point(348, 48);
            this.lblTenBaiHoc.Name = "lblTenBaiHoc";
            this.lblTenBaiHoc.Size = new System.Drawing.Size(387, 32);
            this.lblTenBaiHoc.TabIndex = 18;
            this.lblTenBaiHoc.Text = "hiện tên chương dài hay ngắn";
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
            "5",
            "6",
            "7",
            "8"});
            this.cbSttChuongBH.Location = new System.Drawing.Point(249, 50);
            this.cbSttChuongBH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSttChuongBH.Name = "cbSttChuongBH";
            this.cbSttChuongBH.Size = new System.Drawing.Size(65, 37);
            this.cbSttChuongBH.TabIndex = 17;
            this.cbSttChuongBH.SelectedIndexChanged += new System.EventHandler(this.cbTenChuong2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 38);
            this.label2.TabIndex = 16;
            this.label2.Text = "Bài";
            // 
            // formDiToiBaiHoc2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 321);
            this.Controls.Add(this.cbSoActiBH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTenBaiHoc);
            this.Controls.Add(this.cbSttChuongBH);
            this.Controls.Add(this.label2);
            this.Name = "formDiToiBaiHoc2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Bài Học";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formDiToiBaiHoc2_FormClosed);
            this.Load += new System.EventHandler(this.formDiToiBaiHoc2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSoActiBH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblTenBaiHoc;
        private System.Windows.Forms.ComboBox cbSttChuongBH;
        private System.Windows.Forms.Label label2;
    }
}