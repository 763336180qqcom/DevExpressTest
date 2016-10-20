using DevExpress.XtraEditors;
using DevTest.cn.webxml.getWeatherByCityName;
using DevTest.Common;
using DevTest.Entity;
using System;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace DevTest
{
    public partial class frm天气 : XFormChild
    {
        private string[] weatherInfoArray;
        private delegate WeatherInfo GetWeatherDelegate();
        private delegate void EndGetWeatherDelegate(WeatherInfo info);
        private WeatherWebService mServie;
        public frm天气()
        {
            InitializeComponent();
        }
        private void frm天气_Load(object sender, EventArgs e)
        {
        }
        private void frm天气_Shown(object sender, EventArgs e)
        {
            GetWeatherDelegate d = new GetWeatherDelegate(getWeather);
            d.BeginInvoke(new AsyncCallback(dCallBack), this);
        }
        private void dCallBack(IAsyncResult result)
        {

            GetWeatherDelegate d = (result as AsyncResult).AsyncDelegate as GetWeatherDelegate;
            EndGetWeatherDelegate endGet = new EndGetWeatherDelegate(setText);
            WeatherInfo info = d.EndInvoke(result);
            memoEdit1.Invoke(endGet, info);
        }
        private void setText(WeatherInfo info)
        {
            memoEdit1.Text = info.ToString();
        }
        private void getWeather(string city)
        {

        }
        private WeatherInfo getWeather()
        {

            mServie = new WeatherWebService();
            weatherInfoArray= mServie.getWeatherbyCityName(getCity().Replace("市","").Trim());
            WeatherInfo info = new WeatherInfo();
            info.City = weatherInfoArray[1];
            info.Tm = weatherInfoArray[4].Substring(11);

            info.Date0 = weatherInfoArray[13];
            info.IconName0A = weatherInfoArray[15];
            info.IconName0B = weatherInfoArray[16];
            info.Wind0 = weatherInfoArray[14];

            info.Date1 = weatherInfoArray[17];
            info.IconName1A = weatherInfoArray[20];
            info.IconName1B = weatherInfoArray[21];
            info.Wind1 = weatherInfoArray[19];

            return info;
        }
        private string getCity()
        {
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            try
            {
                string result=wc.DownloadString("http://ip.chinaz.com/getip.aspx?jdfwkey=yh4dr2");
                result = result.Substring(0,result.LastIndexOf(" "));
                result=result.Substring(result.LastIndexOf("'")+1);
                return result;
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                wc.Dispose();
            }
        }


    }
}
