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
        private delegate void DAfterIniData();
        private delegate void DThreadError(string error);
        private DataTable mDT = null;
        private DataTable mDTNew = null;
        private List<Color> colorList = new List<Color>() { Color.Green, Color.Red, Color.Purple, Color.Blue };
        public frmCharts()
        {
            InitializeComponent();
        }

        private void frmCharts_Load(object sender, EventArgs e)
        {
            try
            {
                new Thread(new ThreadStart(iniData)).Start();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            // iniData()
            
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
                    mDT.Columns.Add("最高温度", typeof(Int32));
                    mDT.Columns.Add("最低温度", typeof(Int32));
                    mDT.Columns.Add("相对湿度(%)", typeof(Int32));
                    mDT.Columns.Add("能见度(km)", typeof(Int32));
                    mDT.Columns.Add("风速(km/h)", typeof(Int32));
                    foreach (JToken joo in jo["daily_forecast"])
                    {
                        mDT.Rows.Add(new object[] { Convert.ToDateTime(joo["date"]).ToString("MM月dd日"), joo["tmp"]["max"], joo["tmp"]["min"], joo["hum"], joo["vis"], joo["wind"]["spd"] });
                    }
                        DAfterIniData d = new DAfterIniData(iniChart);
                        this.Invoke(d);
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

        private void iniChart()
        {
            try
            {
                gridControl1.DataSource = mDT;

                Series sTmpMax = CreateSeries("最高温度℃", ViewType.Line, mDT, 1);
                Series sTmpMin = CreateSeries("最低温度℃", ViewType.Line, mDT, 2);
                Series sHum = CreateSeries("相对湿度(%)", ViewType.Line, mDT, 3);
                Series sWindSc = CreateSeries("风速(km/h)", ViewType.Line, mDT, 5);

                List<Series> list = new List<Series>() { sWindSc, sTmpMax, sTmpMin, sHum };
                chartControl1.Series.AddRange(list.ToArray());
                chartControl1.Legend.Visibility = DefaultBoolean.True;
                chartControl1.Legend.Antialiasing = true;
                chartControl1.Legend.Font = new Font("微软雅黑",9f,FontStyle.Bold);
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].View.Color = colorList[i];
                    if (i != 0)
                        CreateAxisY(list[i]);
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message);
            }

        }
        private Series CreateSeries(string name, ViewType viewType, DataTable dt, int colIndexOfInfo)
        {
            Series series = new Series(name, viewType);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                string argument = dt.Rows[i]["日期"].ToString();
                Object value = null;
                if (name.Equals("日期"))
                    value = dt.Rows[i][colIndexOfInfo];
                else
                    value = Convert.ToInt32(dt.Rows[i][colIndexOfInfo]);
                series.Points.Add(new SeriesPoint(argument, value));
            }
            series.ArgumentScaleType = ScaleType.Qualitative;
            series.LabelsVisibility = DefaultBoolean.True;//显示折点信息

            return series;
        }
        private SecondaryAxisY CreateAxisY(Series series)
        {
            SecondaryAxisY sa = new SecondaryAxisY(series.Name);
            ((XYDiagram)chartControl1.Diagram).SecondaryAxesY.Add(sa);
            ((LineSeriesView)series.View).AxisY = sa;
            sa.Title.Text = series.Name;
            sa.Title.Antialiasing = true;
            sa.Title.Alignment = StringAlignment.Far; 
            sa.Title.Visibility = DefaultBoolean.True; 
            sa.Title.Font = new Font("微软雅黑", 10f);
            sa.Label.Angle = 10;
            sa.Label.Font = new Font("微软雅黑", 10f);
            sa.Thickness = 2;
            sa.Tickmarks.CrossAxis = false;
            sa.Tickmarks.Length = 4;
            sa.Tickmarks.MinorVisible = true;
            sa.Tickmarks.MinorLength = 2;
            //数字颜色和刻度条颜色
            sa.Title.TextColor = series.View.Color;
            sa.Label.TextColor = series.View.Color;
            sa.Color = series.View.Color;
            return sa;
        }
    }
}
