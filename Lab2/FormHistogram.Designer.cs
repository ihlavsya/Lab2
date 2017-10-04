namespace Lab2
{
    partial class FormHistogram
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
            this.chartColor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartColor)).BeginInit();
            this.SuspendLayout();
            // 
            // chartColor
            // 
            chartArea1.Name = "ChartArea1";
            this.chartColor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartColor.Legends.Add(legend1);
            this.chartColor.Location = new System.Drawing.Point(33, 31);
            this.chartColor.Name = "chartColor";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartColor.Series.Add(series1);
            this.chartColor.Size = new System.Drawing.Size(556, 386);
            this.chartColor.TabIndex = 0;
            this.chartColor.Text = "chartColor";
            // 
            // FormHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 449);
            this.Controls.Add(this.chartColor);
            this.Name = "FormHistogram";
            this.Text = "FormHistogram";
            this.Load += new System.EventHandler(this.FormHistogram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartColor;
    }
}