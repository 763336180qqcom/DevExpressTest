using DevTest.Common;
using DevTest.Entity;
using System;
using System.Net;
using System.Runtime.Remoting.Messaging;
using DevTest.CN_GetWeather;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml;
using System.Collections.Generic;
using DevExpress.Utils;
using System.IO;
using System.Text;
using ScrapySharp.Network;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System.Net.Cache;

namespace DevTest.测试1
{
    public partial class frmWeather : XtraFormC
    {
        private List<Province> mPro;
        private string[] weatherResult;
        private delegate WeatherInfo mGetWeatherWithPara(string city);
        private delegate void EndGetWeather(WeatherInfo info);
        private WeatherWS mService;
        private List<string> citys = new List<string>();
        // [DllImport("user32", EntryPoint = "HideCaret")]
        // private static extern bool HideCaret(IntPtr hWnd);
        public frmWeather()
        {
            InitializeComponent();
        }
        private void frm天气_Load(object sender, EventArgs e)
        {
            //me0.MouseDown += me0MouseDown;
            sLue.Properties.DataSource = citys;
        }
        private void frm天气_Shown(object sender, EventArgs ex)
        {
            loadWeather();
        }
        private void loadWeather()
        {
            XtraFormP.showWait("请稍等", "正在请求www.webxml.com.cn");
            try
            {
                mGetWeatherWithPara d = new mGetWeatherWithPara(getWeatherWithPara);
                if (sLue.EditValue != null)
                    d.BeginInvoke(sLue.EditValue.ToString(), new AsyncCallback(dCallBack), this);
                else
                    d.BeginInvoke("", new AsyncCallback(dCallBack), this);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        private string getDefaultCity()
        {
            try
            {
                //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://ip.chinaz.com/getip.aspx?");
                //request.Timeout = 30720;
                //request.AllowAutoRedirect = true;
                //request.Method = "GET";
                //request.ContentType = "text/xml; charset=utf-8";
                //request.Credentials = CredentialCache.DefaultCredentials;
                //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                //string result = new StreamReader(response.GetResponseStream(), Encoding.UTF8).ReadToEnd();
                //result = result.Substring(0, result.LastIndexOf(" "));
                //result = result.Substring(result.LastIndexOf("'") + 1);
                ScrapingBrowser br = new ScrapingBrowser() { Language = new System.Globalization.CultureInfo("en-us"), Timeout = new TimeSpan(0, 0, 16), AllowAutoRedirect = true, Encoding = Encoding.UTF8 };
                string htmlStr = br.DownloadString(new Uri("http://www.ip.cn/"));
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(htmlStr);
                var nodes = doc.DocumentNode.CssSelect("code");
                string result = null;
                foreach (var n in nodes)
                    result = n.InnerText;
                result = result.Substring(0, result.LastIndexOf(" "));
                return result;
            }
            catch (Exception e)
            {
                throw new CustomException(e.Message);
            }
        }
        private void me0MouseDown(object sender, MouseEventArgs e)
        {
            //HideCaret((sender as MemoEdit).Handle);
        }
        private void enableC()
        {
            meMain.Enabled = !meMain.Enabled;
            me0.Enabled = !me0.Enabled;
            me1.Enabled = !me1.Enabled;
            me2.Enabled = !me2.Enabled;
            me3.Enabled = !me3.Enabled;
            me4.Enabled = !me4.Enabled;
        }
        private void iniControl(WeatherInfo info)
        {
            if (info == null)
            {
                XtraFormP.closeWait();
                if (XtraMessageBox.Show(this, "获取信息失败,是否重试？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    loadWeather();
                }
                return;
            }
            enableC();
            meMain.Text = string.Format("\t{0}/", info.City);
            meMain.Text += info.Area + "\r\n\t";
            meMain.Text += info.Tm + "\r\n\t";
            meMain.Text += info.ToDay + "\r\n\t";
            meMain.Text += info.Uv + "\r\n\t";
            meMain.Text += info.UvIndex.Replace("。", "。\r\n\t");

            me0.Text = info.Weather5Days[0].ToDay + Environment.NewLine;
            me0.Text += info.Weather5Days[0].T.Replace("/", "~") + Environment.NewLine;
            me0.Text += info.Weather5Days[0].Wind + Environment.NewLine;
            img0A.Appearance.Image = info.Weather5Days[0].IconA;
            img0B.Appearance.Image = info.Weather5Days[0].IconB;

            me1.Text = info.Weather5Days[1].ToDay + Environment.NewLine;
            me1.Text += info.Weather5Days[1].T.Replace("/", "~") + Environment.NewLine;
            me1.Text += info.Weather5Days[1].Wind + Environment.NewLine;
            img1A.Appearance.Image = info.Weather5Days[1].IconA;
            img1B.Appearance.Image = info.Weather5Days[1].IconB;

            me2.Text = info.Weather5Days[2].ToDay + Environment.NewLine;
            me2.Text += info.Weather5Days[2].T.Replace("/", "~") + Environment.NewLine;
            me2.Text += info.Weather5Days[2].Wind + Environment.NewLine;
            img2A.Appearance.Image = info.Weather5Days[2].IconA;
            img2B.Appearance.Image = info.Weather5Days[2].IconB;

            me3.Text = info.Weather5Days[3].ToDay + Environment.NewLine;
            me3.Text += info.Weather5Days[3].T.Replace("/", "~") + Environment.NewLine;
            me3.Text += info.Weather5Days[3].Wind + Environment.NewLine;
            img3A.Appearance.Image = info.Weather5Days[3].IconA;
            img3B.Appearance.Image = info.Weather5Days[3].IconB;

            me4.Text = info.Weather5Days[4].ToDay + Environment.NewLine;
            me4.Text += info.Weather5Days[4].T.Replace("/", "~") + Environment.NewLine;
            me4.Text += info.Weather5Days[4].Wind + Environment.NewLine;
            img4A.Appearance.Image = info.Weather5Days[4].IconA;
            img4B.Appearance.Image = info.Weather5Days[4].IconB;
            if (mPro.Count > 0)
            {
                cmb省.Properties.Items.Clear();
                foreach (Province p in mPro)
                    cmb省.Properties.Items.Add(p.Name);
            }
            XtraFormP.closeWait();
        }
        private void dCallBack(IAsyncResult result)
        {
            try
            {
                mGetWeatherWithPara d = (result as AsyncResult).AsyncDelegate as mGetWeatherWithPara;
                EndGetWeather endGetDelegate = new EndGetWeather(iniControl);
                WeatherInfo info = d.EndInvoke(result);
                this.Invoke(endGetDelegate, info);
            }
            catch (Exception)
            {
                XtraFormP.closeWait();
            }
        }

        private WeatherInfo getWeatherWithPara(string city)
        {
            try
            {
                mService = new WeatherWS();
                if (string.IsNullOrEmpty(city))
                    city = getDefaultCity().Replace("市", "").Trim();
                mService.Timeout = 16384;
                weatherResult = mService.getWeather(city, "3573dee3157c41c8ad5fd76feef41cdd");
                if (weatherResult.Length < 2)
                    return null;

                WeatherInfo info = new WeatherInfo() { City = weatherResult[0], Area = weatherResult[1], Tm = weatherResult[3], ToDay = weatherResult[4], Uv = weatherResult[5], UvIndex = weatherResult[6] };

                WeatherInfoA a = new WeatherInfoA();
                a.ToDay = weatherResult[7];
                a.T = weatherResult[8];
                a.Wind = weatherResult[9];
                a.IconA = Util.getImage(weatherResult[10]);
                a.IconB = Util.getImage(weatherResult[11]);
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
                if (mPro == null)
                    ReadXmlNodes();
                return info;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message);
                return null;
            }
        }
        private void ReadXmlNodes()
        {
            mPro = new List<Province>();
            string fileName = Application.StartupPath.Replace("\\bin\\Debug", "\\Resources\\" + "Area.xml");
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(fileName);
                XmlNodeList nodes_P = xmlDoc.SelectNodes("//Province");
                foreach (XmlNode node in nodes_P)
                {
                    Province p = new Province();
                    p.Name = node.Attributes["name"].Value;
                    XmlNodeList nodes_C = node.ChildNodes;
                    List<string> cNames = new List<string>();
                    foreach (XmlNode node0 in nodes_C)
                    {
                        string name = node0.InnerText;
                        cNames.Add(name);
                    }
                    p.Childs = cNames;
                    mPro.Add(p);
                }
                if (mPro.Count == 0)
                {
                    throw new Exception("获取位置名称失败！");
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message);
                return;
            }
        }


        private void cmb省_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb省.EditValue != null && mPro.Count > 0)
            {
                for (int i = 0; i < mPro.Count; i++)
                {
                    if (mPro[i].Name.Equals(cmb省.EditValue.ToString()))
                    {
                        citys.Clear();
                        citys.AddRange(mPro[i].Childs);
                        searchLookUpEdit1View.RefreshData();
                        sLue.Text = citys[0];
                        break;
                    }
                }
            }
        }
        private void sLue_EditValueChanged(object sender, EventArgs e)
        {
            if (sLue.EditValue != null)
            {
                enableC();
                sLue.Text = sLue.EditValue.ToString();
                loadWeather();
            }
        }

        private void searchLookUpEdit1View_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}
