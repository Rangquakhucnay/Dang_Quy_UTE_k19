namespace HoanThanhDangNhap
{
    partial class TienDoSV
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tenSv = new System.Windows.Forms.Label();
            this.TienDoHocTap = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TienDoHocTap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tenSv);
            this.panel1.Controls.Add(this.TienDoHocTap);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2100, 1092);
            this.panel1.TabIndex = 0;
            // 
            // tenSv
            // 
            this.tenSv.AutoSize = true;
            this.tenSv.BackColor = System.Drawing.Color.White;
            this.tenSv.Font = new System.Drawing.Font("Quicksand", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenSv.Location = new System.Drawing.Point(645, 907);
            this.tenSv.Name = "tenSv";
            this.tenSv.Size = new System.Drawing.Size(284, 70);
            this.tenSv.TabIndex = 2;
            this.tenSv.Text = "Một Cái Tên";
            this.tenSv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TienDoHocTap
            // 
            this.TienDoHocTap.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.TienDoHocTap.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.TienDoHocTap.ChartAreas.Add(chartArea1);
            this.TienDoHocTap.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Số hoạt động đã học";
            this.TienDoHocTap.Legends.Add(legend1);
            this.TienDoHocTap.Location = new System.Drawing.Point(0, 0);
            this.TienDoHocTap.Name = "TienDoHocTap";
            this.TienDoHocTap.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Color = System.Drawing.Color.MediumSeaGreen;
            series1.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Số hoạt động đã học";
            series1.Name = "Số hoạt động đã học";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Color = System.Drawing.Color.LightGray;
            series2.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Số hoạt động đã học";
            series2.Name = "Số hoạt động còn lại";
            this.TienDoHocTap.Series.Add(series1);
            this.TienDoHocTap.Series.Add(series2);
            this.TienDoHocTap.Size = new System.Drawing.Size(2100, 930);
            this.TienDoHocTap.TabIndex = 0;
            this.TienDoHocTap.Text = "chart1";
            // 
            // TienDoSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TienDoSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiến độ học tập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TienDoHocTap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart TienDoHocTap;
        private System.Windows.Forms.Label tenSv;
    }
}