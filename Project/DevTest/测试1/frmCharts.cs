using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevTest.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTest.测试1
{
    public partial class frmCharts : XtraFormC
    {
        private delegate void DAfterIniData(List<ChartControl> cs);
        private delegate void DThreadError(string error);
        private DataTable mDT = null;
        public frmCharts()
        {
            InitializeComponent();
        }
        private void frmCharts_Shown(object sender, EventArgs e)
        {
            try
            {
                XtraFormP.showWait("", "Loading");
                new Thread(new ThreadStart(iniData)).Start();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        private void iniData()
        {
            try
            {
                Uri u = new Uri("http://apis.baidu.com/heweather/weather/free?city=shanghai");
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(u);
                request.Timeout = 30720;
                request.Headers.Add("apikey", "a55d9829dc642857afef37284f5b4a29");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                string jResult = new StreamReader(response.GetResponseStream()).ReadToEnd();
                JObject jRoot = (JObject)JsonConvert.DeserializeObject(jResult);
                JToken jo = jRoot["HeWeather data service 3.0"][0];
                if (jo["status"].ToString().Equals("ok"))
                {
                    mDT = new DataTable();
                    mDT.Columns.Add("日期", typeof(string));
                    mDT.Columns.Add("最高温度℃", typeof(int));
                    mDT.Columns.Add("最低温度℃", typeof(int));
                    mDT.Columns.Add("相对湿度(%)", typeof(int));
                    mDT.Columns.Add("风向", typeof(string));
                    mDT.Columns.Add("风速(km/h)", typeof(int));
                    mDT.Columns.Add("温差", typeof(int));
                    mDT.Columns["温差"].Expression = "最高温度℃-最低温度℃";
                    foreach (JToken joo in jo["daily_forecast"])
                    {
                        mDT.Rows.Add(new object[] { Convert.ToDateTime(joo["date"]).ToString("MM月dd日"), joo["tmp"]["max"], joo["tmp"]["min"], joo["hum"], joo["wind"]["dir"], joo["wind"]["spd"] });
                    }
                    DAfterIniData d = new DAfterIniData(iniChart);
                    this.Invoke(d, new List<ChartControl> { lineChart, BarChart, PieChart });
                }
                else
                    throw new CustomException(jo["status"].ToString());
            }
            catch (Exception ex)
            {
                DThreadError d = new DThreadError(threadError);
                this.Invoke(d, ex.Message);
            }
        }
        private void threadError(string error)
        {
            XtraMessageBox.Show(error);
        }

        private void iniChart(List<ChartControl> chartList)
        {
            try
            {
                gridControl1.DataSource = mDT;

                for (int i = 0; i < chartList.Count; i++)
                {
                    ChartControl chart = chartList[i];
                    chart.Legend.Visibility = DefaultBoolean.True;//右边标注框
                    chart.Legend.Antialiasing = true;
                    chart.Legend.Font = new Font("微软雅黑", 9f, FontStyle.Bold);
                    chart.Legend.Border.Color = Color.Black;
                    if (i < 2)
                    {
                        ViewType t = ViewType.Line;
                        if (i == 1)
                            t = ViewType.Bar;
                        Series sTmpMax = ini2Diagram("最高温度℃", t, "最高温度℃");
                        Series sTmpMin = ini2Diagram("最低温度℃", t, "最低温度℃");
                        Series sHum = ini2Diagram("相对湿度(%)", t, "相对湿度(%)");
                        Series sWindSc = ini2Diagram("风速(km/h)", t, "风速(km/h)");

                        Series[] ss = new Series[] { sTmpMax, sTmpMin, sHum, sWindSc };

                        chart.Series.AddRange(ss.ToArray());
                        chart.EmptyChartText.Text = "数据为空！";

                        chart.Legend.Direction = LegendDirection.TopToBottom;
                        chart.Legend.MarkerSize = new Size(40, 40);
                        chart.Legend.UseCheckBoxes = true;

                        chart.BorderOptions.Color = Color.HotPink;//chart边框
                        chart.BorderOptions.Thickness = 2;
                        chart.CacheToMemory = true;
                        chart.CrosshairEnabled = DefaultBoolean.True;

                        chart.CrosshairOptions.ArgumentLineColor = Color.Black;
                        chart.CrosshairOptions.ArgumentLineStyle.Thickness = 2;
                        chart.CrosshairOptions.ArgumentLineStyle.DashStyle = DashStyle.Dot;
                        chart.CrosshairOptions.CommonLabelPosition.OffsetX = 2;
                        chart.CrosshairOptions.CommonLabelPosition.OffsetY = 2;
                        chart.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowCommonForAllSeries;
                        for (int j = 0; j < ss.Length; j++)
                        {
                            ss[j].View.Color = Util.GetRandomColor();
                            if (j != 0)
                                ini2rdAxisY(ss[j], i);
                        }
                    }
                    else
                    {
                        DataTable DTNew = new DataTable();
                        DTNew.Columns.Add("风向", typeof(string));
                        DTNew.Columns.Add("出现次数", typeof(int));

                        var queryResult = from Drs in mDT.AsEnumerable()
                                          group Drs by new { STRDir = Drs.Field<string>("风向") } into ig
                                          select new { ig.Key.STRDir, COUNT = ig.Count(dr1 => dr1.Field<string>("风向").Length > 0) };

                        if (queryResult.ToList().Count > 0)
                        {
                            queryResult.ToList().ForEach(q =>
                            {
                                DTNew.Rows.Add(q.STRDir, q.COUNT);
                            });
                        }
                        else
                            throw new CustomException("query失败");

                        Series sWindDir = new Series("风向", ViewType.Pie);

                        SeriesPoint point;
                        for (int j = 0; j < DTNew.Rows.Count; j++)
                        {
                            point = new SeriesPoint(DTNew.Rows[j]["风向"], DTNew.Rows[j]["出现次数"]);
                            sWindDir.Points.Add(point);
                        }

                        sWindDir.ToolTipEnabled = DefaultBoolean.True;
                        sWindDir.LegendTextPattern = "{A}：{V:N0}次";
                        sWindDir.LabelsVisibility = DefaultBoolean.True;
                        sWindDir.Label.TextPattern = "{VP:P0}";
                        sWindDir.Label.Font = new Font("微软雅黑", 8, FontStyle.Italic);
                        sWindDir.Label.Antialiasing = true;
                        sWindDir.Label.LineLength = 50;

                        sWindDir.ArgumentScaleType = ScaleType.Qualitative;
                        sWindDir.ValueScaleType = ScaleType.Numerical;
                        sWindDir.ShowInLegend = true;
                        chart.Series.Add(sWindDir);
                    }
                }
                XtraFormP.closeWait();
            }
            catch (Exception e)
            {
                XtraFormP.closeWait();
                XtraMessageBox.Show(e.Message);
            }
        }
        private Series ini2Diagram(string name, ViewType viewType, string targetColName)
        {
            Series series = new Series(name, viewType);
            for (int i = 0; i < mDT.Columns.Count; i++)
            {
                string argument = mDT.Rows[i]["日期"].ToString();
                Object value = Convert.ToInt32(mDT.Rows[i][targetColName]);
                series.Points.Add(new SeriesPoint(argument, value));
            }
            series.ArgumentScaleType = ScaleType.Qualitative;
            series.LabelsVisibility = DefaultBoolean.True;//显示折点信息

            return series;
        }
        private SecondaryAxisY ini2rdAxisY(Series series, int num)
        {
            SecondaryAxisY _2rdAxisY = new SecondaryAxisY(series.Name);
            if (num == 0)
            {
                ((XYDiagram)lineChart.Diagram).SecondaryAxesY.Add(_2rdAxisY);
                ((LineSeriesView)series.View).AxisY = _2rdAxisY;
            }
            else
            {
                ((XYDiagram)BarChart.Diagram).SecondaryAxesY.Add(_2rdAxisY);
                ((BarSeriesView)series.View).AxisY = _2rdAxisY;
            }
            _2rdAxisY.Title.Text = series.Name;
            _2rdAxisY.Title.Antialiasing = true;
            _2rdAxisY.Title.Alignment = StringAlignment.Far;
            _2rdAxisY.Title.Visibility = DefaultBoolean.True;
            _2rdAxisY.Title.Font = new Font("微软雅黑", 10f);
            _2rdAxisY.Label.Angle = 10;
            _2rdAxisY.Label.Font = new Font("微软雅黑", 10f);
            _2rdAxisY.Thickness = 2;
            _2rdAxisY.Tickmarks.CrossAxis = false;
            _2rdAxisY.Tickmarks.Length = 4;
            _2rdAxisY.Tickmarks.MinorVisible = true;
            _2rdAxisY.Tickmarks.MinorLength = 2;
            //数字颜色和刻度条颜色
            _2rdAxisY.Title.TextColor = series.View.Color;
            _2rdAxisY.Label.TextColor = series.View.Color;
            _2rdAxisY.Color = series.View.Color;
            return _2rdAxisY;
        }
    }
}
