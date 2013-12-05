namespace WindowsFormsApplication1
{
    partial class PandyRest
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
            this.restChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_rest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restChart)).BeginInit();
            this.SuspendLayout();
            // 
            // restChart
            // 
            chartArea1.Name = "ChartArea1";
            this.restChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.restChart.Legends.Add(legend1);
            this.restChart.Location = new System.Drawing.Point(9, 46);
            this.restChart.MaximumSize = new System.Drawing.Size(351, 375);
            this.restChart.MinimumSize = new System.Drawing.Size(351, 375);
            this.restChart.Name = "restChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.restChart.Series.Add(series1);
            this.restChart.Size = new System.Drawing.Size(351, 375);
            this.restChart.TabIndex = 0;
            this.restChart.Text = "chart1";
            // 
            // lbl_rest
            // 
            this.lbl_rest.AutoSize = true;
            this.lbl_rest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rest.Location = new System.Drawing.Point(12, 9);
            this.lbl_rest.Name = "lbl_rest";
            this.lbl_rest.Size = new System.Drawing.Size(56, 25);
            this.lbl_rest.TabIndex = 1;
            this.lbl_rest.Text = "Rest";
            // 
            // PandyRest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 435);
            this.Controls.Add(this.lbl_rest);
            this.Controls.Add(this.restChart);
            this.MinimumSize = new System.Drawing.Size(391, 473);
            this.Name = "PandyRest";
            this.Text = "Pandy Rest Over Time";
            ((System.ComponentModel.ISupportInitialize)(this.restChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart restChart;
        private System.Windows.Forms.Label lbl_rest;
    }
}