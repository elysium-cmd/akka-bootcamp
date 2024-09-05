namespace ChartApp
{
    partial class Main
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
            sysChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cpuButton = new System.Windows.Forms.Button();
            memoryButton = new System.Windows.Forms.Button();
            diskButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(sysChart)).BeginInit();
            SuspendLayout();
            // 
            // sysChart
            // 
            chartArea2.Name = "ChartArea1";
            this.sysChart.ChartAreas.Add(chartArea2);
            this.sysChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.sysChart.Legends.Add(legend2);
            this.sysChart.Location = new System.Drawing.Point(0, 0);
            this.sysChart.Name = "sysChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.sysChart.Series.Add(series2);
            this.sysChart.Size = new System.Drawing.Size(684, 446);
            this.sysChart.TabIndex = 0;
            this.sysChart.Text = "sysChart";
            // 
            // cpuButton
            // 
            cpuButton.Location = new System.Drawing.Point(670, 329);
            cpuButton.Name = "cpuButton";
            cpuButton.Size = new System.Drawing.Size(100, 40);
            cpuButton.TabIndex = 1;
            cpuButton.Text = "CPU (ON)";
            cpuButton.UseVisualStyleBackColor = true;
            cpuButton.Click += cpuButton_Click;
            // 
            // memoryButton
            // 
            memoryButton.Location = new System.Drawing.Point(670, 375);
            memoryButton.Name = "memoryButton";
            memoryButton.Size = new System.Drawing.Size(100, 40);
            memoryButton.TabIndex = 2;
            memoryButton.Text = "MEMORY (OFF)";
            memoryButton.UseVisualStyleBackColor = true;
            memoryButton.Click += memoryButton_Click;
            // 
            // diskButton
            // 
            diskButton.Location = new System.Drawing.Point(670, 421);
            diskButton.Name = "diskButton";
            diskButton.Size = new System.Drawing.Size(100, 40);
            diskButton.TabIndex = 3;
            diskButton.Text = "DISK (OFF)";
            diskButton.UseVisualStyleBackColor = true;
            diskButton.Click += diskButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(798, 515);
            Controls.Add(diskButton);
            Controls.Add(memoryButton);
            Controls.Add(cpuButton);
            Controls.Add(sysChart);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Main";
            Text = "System Metrics";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)(sysChart)).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sysChart;
        private System.Windows.Forms.Button cpuButton;
        private System.Windows.Forms.Button memoryButton;
        private System.Windows.Forms.Button diskButton;
    }
}

