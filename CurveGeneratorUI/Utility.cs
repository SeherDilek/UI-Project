using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Model;

namespace CurveGeneratorUI
{
    public class Utility
    {
        public static string ConvertString(string input)
        {
            StringBuilder result = new StringBuilder();
            bool isFirstChar = true;

            foreach (char c in input)
            {
                if (isFirstChar)
                {
                    result.Append(char.ToUpper(c));
                    isFirstChar = false;
                    continue;
                }

                if (char.IsUpper(c))
                {
                    result.Append(' ');
                    result.Append(char.ToUpper(c));
                }
                else
                {
                    result.Append(char.ToLower(c));
                }
            }

            return result.ToString();
        }

        public static bool ValidateInput(string input)
        {
            if (double.TryParse(input, out var val))
            {
                if (val > 0.0)
                    return true;
            }
            return false;
        }

        public static void ReportCurve(DataGridView dgv, List<CurvePoint> pyCurve)
        {
            dgv.Rows.Clear();
            foreach (var dataPoint in pyCurve)
            {
                var rowIndex = dgv.Rows.Add();
                dgv.Rows[rowIndex].Cells["y"].Value = dataPoint.X.ToString("0.###E+0");
                dgv.Rows[rowIndex].Cells["P"].Value = dataPoint.Y.ToString("#,##0.00");
            }
        }

        public static void DrawCurve(System.Windows.Forms.DataVisualization.Charting.Chart chartPYCurve, List<CurvePoint> pyCurve)
        {
            chartPYCurve.Series.Clear();
            var pyCurveSeries = new System.Windows.Forms.DataVisualization.Charting.Series();
            pyCurveSeries.Name = "PY Curve";
            pyCurveSeries.Color = System.Drawing.Color.DarkGray;
            pyCurveSeries.BorderWidth = 3;
            pyCurveSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartPYCurve.Series.Add(pyCurveSeries);

            foreach (var point in pyCurve)
            {
                double y = point.X;
                double p = point.Y;
                pyCurveSeries.Points.AddXY(y, p);
            }

            chartPYCurve.ChartAreas[0].AxisX.Minimum = 0;
            chartPYCurve.ChartAreas[0].AxisY.Minimum = 0;
            chartPYCurve.ChartAreas[0].AxisX.LabelStyle.Format = "0.#####E+0";
            chartPYCurve.ChartAreas[0].AxisY.LabelStyle.Format = "#.##0.00";
            chartPYCurve.ChartAreas[0].AxisX.Title = "y (m)";
            chartPYCurve.ChartAreas[0].AxisY.Title = "P (N/m)";
        }
    }
}
