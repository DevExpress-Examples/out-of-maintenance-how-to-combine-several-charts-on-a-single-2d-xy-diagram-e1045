Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace CombineSeveralCharts2D
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create an empty chart.
			Dim combinedChart As New ChartControl()

			' Create two series of different types.
			Dim series1 As New Series("Area Series", ViewType.StepLine)
			Dim series2 As New Series("Line Series", ViewType.Spline)

			' Hide their labels (if necessary).
			series1.Label.Visible = False
			series2.Label.Visible = False

			' Add points to them.
			series1.Points.Add(New SeriesPoint(1, New Double() { 10 }))
			series1.Points.Add(New SeriesPoint(2, New Double() { 2 }))
			series1.Points.Add(New SeriesPoint(3, New Double() { 14 }))
			series1.Points.Add(New SeriesPoint(4, New Double() { 17 }))

			series2.Points.Add(New SeriesPoint(1, New Double() { 5 }))
			series2.Points.Add(New SeriesPoint(2, New Double() { 16 }))
			series2.Points.Add(New SeriesPoint(3, New Double() { 4 }))
			series2.Points.Add(New SeriesPoint(4, New Double() { 11 }))

			' Add series to the chart.
			combinedChart.Series.Add(series2)
			combinedChart.Series.Add(series1)

			' Hide the legend (if necessary).
			combinedChart.Legend.Visible = False

			' Add the chart to the form.
			combinedChart.Dock = DockStyle.Fill
			Me.Controls.Add(combinedChart)

		End Sub
	End Class
End Namespace