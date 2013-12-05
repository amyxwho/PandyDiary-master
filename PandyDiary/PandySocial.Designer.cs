namespace WindowsFormsApplication1
{
    partial class PandySocial
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.socialChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_social = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.socialChart)).BeginInit();
            this.SuspendLayout();
            // 
            // socialChart
            // 
            chartArea2.Name = "ChartArea1";
            this.socialChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Social";
            this.socialChart.Legends.Add(legend2);
            this.socialChart.Location = new System.Drawing.Point(12, 48);
            this.socialChart.MaximumSize = new System.Drawing.Size(351, 375);
            this.socialChart.MinimumSize = new System.Drawing.Size(351, 375);
            this.socialChart.Name = "socialChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Social";
            series2.Name = "Social";
            this.socialChart.Series.Add(series2);
            this.socialChart.Size = new System.Drawing.Size(351, 375);
            this.socialChart.TabIndex = 10;
            this.socialChart.Text = "chart1";
            // 
            // lbl_social
            // 
            this.lbl_social.AutoSize = true;
            this.lbl_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_social.Location = new System.Drawing.Point(12, 9);
            this.lbl_social.Name = "lbl_social";
            this.lbl_social.Size = new System.Drawing.Size(71, 25);
            this.lbl_social.TabIndex = 11;
            this.lbl_social.Text = "Social";
            // 
            // PandySocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 435);
            this.Controls.Add(this.lbl_social);
            this.Controls.Add(this.socialChart);
            this.MinimumSize = new System.Drawing.Size(391, 473);
            this.Name = "PandySocial";
            this.Text = "Social Progress Over Time";
            ((System.ComponentModel.ISupportInitialize)(this.socialChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart socialChart;
        private System.Windows.Forms.Label lbl_social;
    }
}