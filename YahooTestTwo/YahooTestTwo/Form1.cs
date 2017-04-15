using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DailyStockPriceMovementChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();
            string symbol = comboBoxSymbols.Text;
            string URI2 = "http://chartapi.finance.yahoo.com/instrument/1.0/" + symbol + "/chartdata;type=quote;range=1d/json";
            Uri combined = new Uri(URI2);
            rClient.endPoint = combined.ToString();
            string strResponse = rClient.makeRequest();
            strResponse = strResponse.Substring(30, strResponse.Length - 32);

            RootObject root = JsonConvert.DeserializeObject<RootObject>(strResponse);
            companyName.Text = root.meta.companyName;

            
            // Clear Chart
            this.chart1.Series.Clear();
            this.chart1.Legends.Clear();
            this.chart1.ChartAreas.Clear();
            this.chart1.Titles.Clear();

            // Build Chart
            this.ChartSeries(root);
            this.ChartAreas(root);
            this.ChartTitle(root);
            this.chart1.Invalidate();

            var latestDt = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(root.series[root.series.Count - 1].Timestamp).ToLocalTime();
            latestTime.Text = latestDt.ToString();
            latestClosingPrice.Text = root.series[root.series.Count - 1].close.ToString();



        }

        void ChartAreas(RootObject root)
        {
            var axisX = new System.Windows.Forms.DataVisualization.Charting.Axis
            {
                Interval = 30,
                Title = "Minutes Since Day Open",
            };

            var axisY = new System.Windows.Forms.DataVisualization.Charting.Axis
            {
                Minimum = root.ranges.close.min,
                Maximum = root.ranges.close.max,
                Title = "Stock Price",
            };

            var chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea
            {
                AxisX = axisX,
                AxisY = axisY,
            };

            this.chart1.ChartAreas.Add(chartArea1);
        }

        void ChartTitle(RootObject root)
        {
            var titles1 = new System.Windows.Forms.DataVisualization.Charting.Title
            {
                Name = root.meta.companyName,
                Text = root.meta.companyName,
                Visible = true,
            };
            this.chart1.Titles.Add(titles1);
        }

        
        void ChartLegends(string name)
        {
            var legends1 = new System.Windows.Forms.DataVisualization.Charting.Legend
            {
                Name = name,
            };
            this.chart1.Legends.Add(legends1);
        }
        

        void ChartSeries(RootObject root)
        {
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = root.meta.companyName,
                Color = System.Drawing.Color.Blue,
                BorderWidth = 1,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
            };

            for (int i = 0; i < root.series.Count; i++)
            {
                double xValue = 0;
                double yValue = 0;
                xValue = (root.series[i].Timestamp - 1491917400) / (60 * 1000 * 60);
                yValue = root.series[i].close;
                series1.Points.AddXY(xValue, yValue);
            }

            this.chart1.Series.Add(series1);
            Visible = true;
            //this.ChartLegends(root.meta.companyName);
            
        }

    }
}
