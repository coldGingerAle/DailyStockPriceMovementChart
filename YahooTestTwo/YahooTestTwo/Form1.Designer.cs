﻿namespace DailyStockPriceMovementChart
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBoxSymbols = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.latestTime = new System.Windows.Forms.Label();
            this.latestClosingPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSymbols
            // 
            this.comboBoxSymbols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSymbols.FormattingEnabled = true;
            this.comboBoxSymbols.Items.AddRange(new object[] {
            "YHOO",
            "GOOG",
            "AAPL",
            "FLIR",
            "M",
            "TWX",
            "HAS"});
            this.comboBoxSymbols.Location = new System.Drawing.Point(12, 14);
            this.comboBoxSymbols.Name = "comboBoxSymbols";
            this.comboBoxSymbols.Size = new System.Drawing.Size(150, 21);
            this.comboBoxSymbols.TabIndex = 0;
            this.comboBoxSymbols.SelectedIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(257, 9);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(85, 13);
            this.companyNameLabel.TabIndex = 2;
            this.companyNameLabel.Text = "Company Name:";
            // 
            // companyName
            // 
            this.companyName.AutoSize = true;
            this.companyName.Location = new System.Drawing.Point(348, 9);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(10, 13);
            this.companyName.TabIndex = 3;
            this.companyName.Text = "-";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(15, 57);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(503, 438);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Latest:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Closing Price:";
            // 
            // latestTime
            // 
            this.latestTime.AutoSize = true;
            this.latestTime.Location = new System.Drawing.Point(302, 22);
            this.latestTime.Name = "latestTime";
            this.latestTime.Size = new System.Drawing.Size(10, 13);
            this.latestTime.TabIndex = 8;
            this.latestTime.Text = "-";
            // 
            // latestClosingPrice
            // 
            this.latestClosingPrice.AutoSize = true;
            this.latestClosingPrice.Location = new System.Drawing.Point(334, 35);
            this.latestClosingPrice.Name = "latestClosingPrice";
            this.latestClosingPrice.Size = new System.Drawing.Size(10, 13);
            this.latestClosingPrice.TabIndex = 9;
            this.latestClosingPrice.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 518);
            this.Controls.Add(this.latestClosingPrice);
            this.Controls.Add(this.latestTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxSymbols);
            this.Name = "Form1";
            this.Text = "Today\'s Stock Price Movement";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSymbols;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label companyName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label latestTime;
        private System.Windows.Forms.Label latestClosingPrice;
    }
}

