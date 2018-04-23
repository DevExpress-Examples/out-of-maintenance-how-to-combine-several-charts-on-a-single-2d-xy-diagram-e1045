using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace CombineSeveralCharts2D {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create an empty chart.
            ChartControl combinedChart = new ChartControl();

            // Create two series of different types.
            Series series1 = new Series("Area Series", ViewType.StepLine);
            Series series2 = new Series("Line Series", ViewType.Spline);

            // Add points to them.
            series1.Points.Add(new SeriesPoint(1, new double[] { 10 }));
            series1.Points.Add(new SeriesPoint(2, new double[] { 2 }));
            series1.Points.Add(new SeriesPoint(3, new double[] { 14 }));
            series1.Points.Add(new SeriesPoint(4, new double[] { 17 }));

            series2.Points.Add(new SeriesPoint(1, new double[] { 5 }));
            series2.Points.Add(new SeriesPoint(2, new double[] { 16 }));
            series2.Points.Add(new SeriesPoint(3, new double[] { 4 }));
            series2.Points.Add(new SeriesPoint(4, new double[] { 11 }));

            // Add series to the chart.
            combinedChart.Series.Add(series2);
            combinedChart.Series.Add(series1);

            // Hide the legend (if necessary).
            combinedChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Add the chart to the form.
            combinedChart.Dock = DockStyle.Fill;
            this.Controls.Add(combinedChart);

        }
    }
}