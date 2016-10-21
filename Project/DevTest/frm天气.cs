using DevTest.Common;
using DevTest.Entity;
using System;
using System.Net;
using System.Runtime.Remoting.Messaging;
using DevTest.CN_GetWeather;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using DevExpress.XtraEditors;
using System.Xml;
using System.Collections.Generic;

namespace DevTest
{
    public partial class frm天气 : XFormChild
    {
        private string[] weatherResult;
        private delegate WeatherInfo GetWeatherDelegate();
        private delegate void EndGetWeatherDelegate(WeatherInfo info);
        private WeatherWS mService;
        private string mCityName;
        private bool selected ;
        private List<Province> mPS;
       // [DllImport("user32", EntryPoint = "HideCaret")]
       // private static extern bool HideCaret(IntPtr hWnd);

        public frm天气()
        {
            selected = false;
            mPS = new List<Province>();
            InitializeComponent();
        }
        private void frm天气_Load(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ReadXmlNodes));
            t.Start();
            //me0.MouseDown += me0MouseDown;
        }
        private void me0MouseDown(object sender, MouseEventArgs e)
        {
            //HideCaret((sender as MemoEdit).Handle);
        }
        private void iniLabel(WeatherInfo info)
        {
            meMain.Text = "\t" + info.City + "/";
            meMain.Text += info.Area + "\r\n\t";
            meMain.Text += info.Tm + "\r\n\t";
            meMain.Text += info.ToDay + "\r\n\t";
            meMain.Text += info.Uv + "\r\n\t";
            meMain.Text += info.UvIndex.Replace("。", "。\r\n\t");

            me0.Text = info.Weather5Days[0].ToDay + "\r\n";
            me0.Text += info.Weather5Days[0].T.Replace("/", "~") + "\r\n";
            me0.Text += info.Weather5Days[0].Wind + "\r\n";
            imageEdit0A.EditValue = info.Weather5Days[0].IconA;
            imageEdit0B.EditValue = info.Weather5Days[0].IconB;

            me1.Text = info.Weather5Days[1].ToDay + "\r\n";
            me1.Text += info.Weather5Days[1].T.Replace("/", "~") + "\r\n";
            me1.Text += info.Weather5Days[1].Wind + "\r\n";
            imageEdit1A.EditValue = info.Weather5Days[1].IconA;
            imageEdit1B.EditValue = info.Weather5Days[1].IconB;

            me2.Text = info.Weather5Days[2].ToDay + "\r\n";
            me2.Text += info.Weather5Days[2].T.Replace("/", "~") + "\r\n";
            me2.Text += info.Weather5Days[2].Wind + "\r\n";
            imageEdit2A.EditValue = info.Weather5Days[2].IconA;
            imageEdit2B.EditValue = info.Weather5Days[2].IconB;

            me3.Text = info.Weather5Days[3].ToDay + "\r\n";
            me3.Text += info.Weather5Days[3].T.Replace("/", "~") + "\r\n";
            me3.Text += info.Weather5Days[3].Wind + "\r\n";
            imageEdit3A.EditValue = info.Weather5Days[3].IconA;
            imageEdit3B.EditValue = info.Weather5Days[3].IconB;

            me4.Text = info.Weather5Days[4].ToDay + "\r\n";
            me4.Text += info.Weather5Days[4].T.Replace("/", "~") + "\r\n";
            me4.Text += info.Weather5Days[4].Wind + "\r\n";
            imageEdit4A.EditValue = info.Weather5Days[4].IconA;
            imageEdit4B.EditValue = info.Weather5Days[4].IconB;

        }
        private void frm天气_Shown(object sender, EventArgs ex)
        {
            try
            {
                GetWeatherDelegate d = new GetWeatherDelegate(getWeather);
                d.BeginInvoke(new AsyncCallback(dCallBack), this);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void dCallBack(IAsyncResult result)
        {
            try
            {
                GetWeatherDelegate d = (result as AsyncResult).AsyncDelegate as GetWeatherDelegate;
                EndGetWeatherDelegate endGet = new EndGetWeatherDelegate(iniLabel);
                WeatherInfo info = d.EndInvoke(result);
                this.Invoke(endGet, info);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    
        private WeatherInfo getWeather(string city)
        {
            return null;
        }
        private WeatherInfo getWeather()
        {
            try
            {
                mService = new WeatherWS();
                if (selected)
                    mCityName = cmb市.EditValue.ToString();
                else
                    mCityName = getCity().Replace("市", "").Trim();
                weatherResult = mService.getWeather(mCityName, "3573dee3157c41c8ad5fd76feef41cdd");
                WeatherInfo info = new WeatherInfo();

                info.City = weatherResult[0];
                info.Area = weatherResult[1];
                info.Tm = weatherResult[3];
                info.ToDay = weatherResult[4];
                info.Uv = weatherResult[5];
                info.UvIndex = weatherResult[6];

                WeatherInfoA a = new WeatherInfoA();
                a.ToDay = weatherResult[7];
                a.T = weatherResult[8];
                a.Wind = weatherResult[9];
                a.IconA= Util.getImage(weatherResult[10]);
                a.IconB= Util.getImage(weatherResult[11]);
                info.Weather5Days.Add(a);

                a = new WeatherInfoA();
                a.ToDay = weatherResult[12];
                a.T = weatherResult[13];
                a.Wind = weatherResult[14];
                a.IconA = Util.getImage(weatherResult[15]);
                a.IconB = Util.getImage(weatherResult[16]);
                info.Weather5Days.Add(a);

                a = new WeatherInfoA();
                a.ToDay = weatherResult[17];
                a.T = weatherResult[18];
                a.Wind = weatherResult[19];
                a.IconA = Util.getImage(weatherResult[20]);
                a.IconB = Util.getImage(weatherResult[21]);
                info.Weather5Days.Add(a);

                a = new WeatherInfoA();
                a.ToDay = weatherResult[22];
                a.T = weatherResult[23];
                a.Wind = weatherResult[24];
                a.IconA = Util.getImage(weatherResult[25]);
                a.IconB = Util.getImage(weatherResult[26]);
                info.Weather5Days.Add(a);

                a = new WeatherInfoA();
                a.ToDay = weatherResult[27];
                a.T = weatherResult[28];
                a.Wind = weatherResult[29];
                a.IconA = Util.getImage(weatherResult[30]);
                a.IconB = Util.getImage(weatherResult[31]);
                info.Weather5Days.Add(a);
                return info;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null ;
            }
        }
        private string getCity()
        {
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            try
            {
                string result = wc.DownloadString("http://ip.chinaz.com/getip.aspx");
                result = result.Substring(0, result.LastIndexOf(" "));
                result = result.Substring(result.LastIndexOf("'") + 1);
                return result;
            }
            catch (Exception e)
            {
                throw new CustomException(e.Message); 
            }
            finally
            {
                wc.Dispose();
            }
        }
        private void ReadXmlNodes()
        {
            List<Province> ps = new List<Province>();
            string fileName = Application.StartupPath.Replace("\\bin\\Debug", "\\Resources\\" + "Area.xml");
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(fileName);
                XmlNodeList nodes_P = xmlDoc.SelectNodes("//Province");
                Province p = new Province();
                foreach (XmlNode node in nodes_P)
                {
                    p.Name = node.Attributes["name"].Value;
                    XmlNodeList nodes_C = node.ChildNodes;
                    List<string> cNames = new List<string>();
                    foreach (XmlNode node0 in nodes_C)
                    {
                        string name = node0.InnerText;
                        cNames.Add(name);
                    }
                    p.Childs = cNames;
                }
                ps.Add(p);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ps;
        }
        private void cmb市_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb市.EditValue != null)
            {
                selected = true;
                try
                {
                    GetWeatherDelegate d = new GetWeatherDelegate(getWeather);
                    d.BeginInvoke(new AsyncCallback(dCallBack), this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
