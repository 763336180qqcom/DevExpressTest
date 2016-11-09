using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevTest.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTest.测试1
{
    public partial class frmCharts : XtraFormC
    {
        private DataTable mDT = null;
        private List<Color> colorList = new List<Color>() { Color.Red, Color.Gray, Color.Tomato, Color.Blue, Color.Green };
        public frmCharts()
        {
            InitializeComponent();
        }

        private void frmCharts_Load(object sender, EventArgs e)
        {
            iniData();
            iniChart();

        }
        private void iniData()
        {
            mDT = new DataTable();
            mDT.Columns.Add(new DataColumn("类型"));
            mDT.Columns.Add(new DataColumn("2005-1月", typeof(decimal)));
            mDT.Columns.Add(new DataColumn("2005-2月", typeof(decimal)));
            mDT.Columns.Add(new DataColumn("2005-3月", typeof(decimal)));
            mDT.Columns.Add(new DataColumn("2005-4月", typeof(decimal)));
            mDT.Columns.Add(new DataColumn("2005-5月", typeof(decimal)));
            mDT.Columns.Add(new DataColumn("2005-6月", typeof(decimal)));

            mDT.Rows.Add(new object[] { "员工人数", 437, 437, 414, 397, 387, 378 });
            mDT.Rows.Add(new object[] { "人均月薪", 3964, 3961, 3979, 3974, 3967, 3972 });
            mDT.Rows.Add(new object[] { "成本TEU", 3104, 1339, 3595.8, 3154.5, 2499.8, 3026 });
            mDT.Rows.Add(new object[] { "人均生产率", 7.1, 3.06, 8.69, 7.95, 6.46, 8.01 });
            mDT.Rows.Add(new object[] { "占2005年3月人数比例", 1.06, 1.06, 1, 0.96, 0.93, 0.91 });

        }
        private void iniChart()
        {

            #region Series
            //创建几个图形的对象
            Series series1 = CreateSeries("员工人数", ViewType.Line, mDT, 0);
            Series series2 = CreateSeries("人均月薪", ViewType.Line, mDT, 1);
            Series series3 = CreateSeries("成本TEU", ViewType.Line, mDT, 2);
            Series series4 = CreateSeries("人均生产率", ViewType.Line, mDT, 3);
            Series series5 = CreateSeries("占2005年3月人数比例", ViewType.Line, mDT, 4);
            #endregion

            List<Series> list = new List<Series>() { series1, series2, series3, series4, series5 };
            chartControl1.Series.AddRange(list.ToArray());
            chartControl1.Legend.Visibility = DefaultBoolean.False;
            chartControl1.SeriesTemplate.LabelsVisibility = DefaultBoolean.True;

            for (int i = 0; i < list.Count; i++)
            {
                list[i].View.Color = colorList[i];

                CreateAxisY(list[i]);
            }
        }
        /// <summary>
        /// 根据数据创建一个图形展现
        /// </summary>
        /// <param name="caption">图形标题</param>
        /// <param name="viewType">图形类型</param>
        /// <param name="dt">数据DataTable</param>
        /// <param name="rowIndex">图形数据的行序号</param>
        /// <returns></returns>
        private Series CreateSeries(string caption, ViewType viewType, DataTable dt, int rowIndex)
        {
            Series series = new Series(caption, viewType);
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                string argument = dt.Columns[i].ColumnName;//参数名称
                decimal value = (decimal)dt.Rows[rowIndex][i];//参数值
                series.Points.Add(new SeriesPoint(argument, value));
            }

            //必须设置ArgumentScaleType的类型，否则显示会转换为日期格式，导致不是希望的格式显示
            //也就是说，显示字符串的参数，必须设置类型为ScaleType.Qualitative
            series.ArgumentScaleType = ScaleType.Qualitative;
            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;//显示标注标签

            return series;
        }
        /// <summary>
        /// 创建图表的第二坐标系
        /// </summary>
        /// <param name="series">Series对象</param>
        /// <returns></returns>
        private SecondaryAxisY CreateAxisY(Series series)
        {
            SecondaryAxisY myAxis = new SecondaryAxisY(series.Name);
            ((XYDiagram)chartControl1.Diagram).SecondaryAxesY.Add(myAxis);
            ((LineSeriesView)series.View).AxisY = myAxis;
            myAxis.Title.Text = series.Name;
            myAxis.Title.Alignment = StringAlignment.Far; //顶部对齐
            myAxis.Title.Visibility = DefaultBoolean.True; //显示标题
            myAxis.Title.Font = new Font("宋体", 9.0f);

            Color color = series.View.Color;//设置坐标的颜色和图表线条颜色一致

            myAxis.Title.TextColor = color;
            myAxis.Label.TextColor = color;
            myAxis.Color = color;

            return myAxis;
        }
    }
}
