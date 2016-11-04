using DevTest.Common;
using DevTest.Entity;
using System;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Text;
using ScrapySharp.Network;
using ScrapySharp.Extensions;
using System.Drawing;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Threading;
using System.Data;

namespace DevTest.测试1
{
    public partial class frmWeather : XtraFormC
    {
        private const string cURL = "http://apis.baidu.com/apistore/iplookupservice/iplookup?ip=";
        private delegate WeatherInfo DGetWeatherWithPara(object city);
        private delegate void DEndGetWeather(WeatherInfo info);
        private delegate void DFinishLoadName(DataTable dt, string code);
        private string strCName;
        // [DllImport("user32", EntryPoint = "HideCaret")]
        // private static extern bool HideCaret(IntPtr hWnd);
        public frmWeather()
        {
            InitializeComponent();
        }
        private void frm天气_Load(object sender, EventArgs e)
        {
        }
        
        private void frm天气_Shown(object sender, EventArgs ex)
        {
            lue省.EditValue = null;
            lue市.EditValue = null;
            lue县区.EditValue = null;
            //me0.MouseDown += me0MouseDown;
            try
            {
                string[] flags = new string[] { "P", "" };
                Thread t = new Thread(new ParameterizedThreadStart(LoadName));
                t.Start(flags);
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message);
            }
        }
        private void LoadName(object obj)
        {
            string[] flags = obj as string[];
            DataTable dtName = DB.getName(flags);
            DFinishLoadName fi = new DFinishLoadName(loadNameFinish);
            this.Invoke(fi, dtName, flags[0]);
        }

        private void loadNameFinish(DataTable dt, string code)
        {
            if (code.Equals("P"))
            {
                lue省.Properties.DisplayMember = "简称";
                lue省.Properties.DataSource = dt;
                loadWeather();
            }
            if (code.Equals("C"))
            {
                lue市.Properties.DataSource = dt;
                lue市.Properties.DisplayMember = "简称";
            }
            if (code.Equals("D"))
            {
                lue县区.Properties.DataSource = dt;
                lue县区.Properties.DisplayMember = "简称";
            }
        }
        private void loadWeather()
        {
            XtraFormP.showWait("请稍等", "正在请求www.webxml.com.cn");
            try
            {
                DGetWeatherWithPara d = new DGetWeatherWithPara(getCityWeather);
                if (lue县区.EditValue != null)
                {
                    DataRowView drv = (DataRowView)lue县区.EditValue;
                    d.BeginInvoke(string.Format("{0}||{1}", drv.Row["简称"], drv.Row["名称"]), new AsyncCallback(dCallBack), this);
                }
                else
                    d.BeginInvoke("", new AsyncCallback(dCallBack), this);
            }
            catch (Exception ex)
            {
                enableC(true);
                XtraMessageBox.Show(ex.Message);
            }
        }
        private WeatherInfo getCityWeather(object cityName)
        {
            try
            {
                if (string.IsNullOrEmpty(cityName.ToString()))
                {
                    IPInfo iin = getDefaultCity();
                    cityName = string.Format("{0}||{1}", iin._区, iin._市);
                }

                string strUrl = string.Format("http://api.map.baidu.com/telematics/v3/weather?location={0}&output=json&ak=GLXUcC7ZSpUesw3jPdRyil1jAPZSdHaP", cityName);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strUrl);
                request.Timeout = 30720;
                request.Method = "GET";
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string strJson = new StreamReader(response.GetResponseStream()).ReadToEnd();

                JObject jo = (JObject)JsonConvert.DeserializeObject(strJson);
                if (jo["error"].ToString().Equals("0"))
                {
                    int count = 0;
                    foreach (var joo in jo["results"])
                    {
                        count++;
                        WeatherInfo mainInfo = new WeatherInfo()
                        {
                            City = "当前位置:" + joo["currentCity"].ToString(),
                            ZhiShu = "\t"
                        };
                        JToken joResultA = joo["index"];
                        foreach (var i in joResultA)
                        {
                            mainInfo.ZhiShu += string.Format("{0}:{1}\r\n\t", i["title"], i["des"]);
                        };
                        JToken joResultB = joo["weather_data"];
                        foreach (var jooo in joResultB)
                        {
                            WeatherInfoA childInfo = new WeatherInfoA()
                            {
                                Date = jooo["date"].ToString(),
                                DayP = Util.getImageFromNet(jooo["dayPictureUrl"].ToString()),
                                Nightp = Util.getImageFromNet(jooo["nightPictureUrl"].ToString()),
                                Wind = jooo["wind"].ToString(),
                                Weather = jooo["weather"].ToString(),
                                Temperature = jooo["temperature"].ToString()
                            };
                            mainInfo.Weather4Days.Add(childInfo);
                        }
                        return mainInfo;
                    }
                }
                else if (!string.IsNullOrEmpty(strCName))
                {
                    getCityWeather(strCName);
                    strCName = null;
                }
                return null;
            }
            catch (Exception e)
            {
                throw new CustomException(e.Message);
            }
        }

        private IPInfo getDefaultCity()
        {
            try
            {
                ScrapingBrowser br = new ScrapingBrowser() { Language = new System.Globalization.CultureInfo("en-us"), Timeout = new TimeSpan(0, 0, 16), AllowAutoRedirect = true, Encoding = Encoding.UTF8, KeepAlive = true };
                string htmlStr = br.DownloadString(new Uri("http://www.ip.cn/"));
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(htmlStr);
                var nodes = doc.DocumentNode.CssSelect("code");
                string ip = null;
                foreach (var n in nodes)
                {
                    ip = n.InnerText;
                    break;
                }

                string strUrl = string.Format("{0}{1}", cURL, ip);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strUrl);
                request.Timeout = 30720;
                request.Headers.Add("apikey", "a55d9829dc642857afef37284f5b4a29");
                request.Method = "GET";
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string strJson = new StreamReader(response.GetResponseStream()).ReadToEnd();

                JObject jo = (JObject)JsonConvert.DeserializeObject(strJson);
                IPInfo ipi = new IPInfo()
                {
                    _网络IP = jo["retData"]["ip"].ToString(),
                    _国家 = jo["retData"]["country"].ToString(),
                    _省 = jo["retData"]["province"].ToString(),
                    _市 = jo["retData"]["city"].ToString(),
                    _区 = jo["retData"]["district"].ToString(),
                    _运营商 = jo["retData"]["carrier"].ToString()
                };
                return ipi;
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
        private void enableC(bool f)
        {
            meMain.Enabled = f ? true : false;
            me0.Enabled = f ? true : false;
            me1.Enabled = f ? true : false;
            me2.Enabled = f ? true : false;
            me3.Enabled = f ? true : false;
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
            enableC(true);

            meMain.Text = info.City + Environment.NewLine;
            meMain.Text += info.ZhiShu;

            me0.Text = info.Weather4Days[0].Date + Environment.NewLine;
            me0.Text += info.Weather4Days[0].Weather + Environment.NewLine;
            me0.Text += info.Weather4Days[0].Wind + Environment.NewLine;
            me0.Text += info.Weather4Days[0].Temperature + Environment.NewLine;
            img0A.Appearance.Image = info.Weather4Days[0].DayP;
            img0B.Appearance.Image = info.Weather4Days[0].Nightp;

            me1.Text = info.Weather4Days[1].Date + Environment.NewLine;
            me1.Text += info.Weather4Days[1].Weather + Environment.NewLine;
            me1.Text += info.Weather4Days[1].Wind + Environment.NewLine;
            me1.Text += info.Weather4Days[1].Temperature + Environment.NewLine;
            img1A.Appearance.Image = info.Weather4Days[1].DayP;
            img1B.Appearance.Image = info.Weather4Days[1].Nightp;

            me2.Text = info.Weather4Days[2].Date + Environment.NewLine;
            me2.Text += info.Weather4Days[2].Weather + Environment.NewLine;
            me2.Text += info.Weather4Days[2].Wind + Environment.NewLine;
            me2.Text += info.Weather4Days[2].Temperature + Environment.NewLine;
            img2A.Appearance.Image = info.Weather4Days[2].DayP;
            img2B.Appearance.Image = info.Weather4Days[2].Nightp;

            me3.Text = info.Weather4Days[3].Date + Environment.NewLine;
            me3.Text += info.Weather4Days[3].Weather + Environment.NewLine;
            me3.Text += info.Weather4Days[3].Wind + Environment.NewLine;
            me3.Text += info.Weather4Days[3].Temperature + Environment.NewLine;
            img3A.Appearance.Image = info.Weather4Days[3].DayP;
            img3B.Appearance.Image = info.Weather4Days[3].Nightp;
            enableC(true);
            XtraFormP.closeWait();
        }
        private void dCallBack(IAsyncResult result)
        {
            try
            {
                DGetWeatherWithPara d = (result as AsyncResult).AsyncDelegate as DGetWeatherWithPara;
                DEndGetWeather endGetDelegate = new DEndGetWeather(iniControl);
                WeatherInfo info = d.EndInvoke(result);
                this.Invoke(endGetDelegate, info);
            }
            catch (Exception e)
            {
                XtraFormP.closeWait();
                CallBackExceptionDo cbdo = new CallBackExceptionDo(dos);
                this.Invoke(cbdo, e.Message);
            }
        }
        private delegate void CallBackExceptionDo(string ex);
        private void dos(string ex)
        {
            enableC(true);
            XtraMessageBox.Show(ex);
        }
        

        private void searchLookUpEdit1View_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("楷体", 50);
            Graphics graphics = e.Graphics;
            graphics.RotateTransform(30f);
            graphics.DrawString("\u4e2d\u56fd", font, new SolidBrush(Color.Brown), panel1.Location.X + panel1.Width / 2, me0.Location.Y);
        }
        private void lue省_EditValueChanged(object sender, EventArgs e)
        {
            if (lue省.EditValue != null)
            {
                try
                {
                    DataRowView drv = (DataRowView)lue省.EditValue;
                    lue省.Text = drv.Row["简称"].ToString();
                    string[] flags = new string[] { "C", drv.Row["简称"].ToString() };
                    Thread t = new Thread(new ParameterizedThreadStart(LoadName));
                    t.Start(flags);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }
        private void lue市_EditValueChanged(object sender, EventArgs e)
        {
            if (lue市.EditValue != null)
            {
                try
                {
                    DataRowView drv = (DataRowView)lue市.EditValue;
                    lue市.Text = drv.Row["简称"].ToString();
                    strCName = string.Format("{0}||{1}", drv.Row["简称"], drv.Row["名称"]);
                    string[] flags = new string[] { "D", drv.Row["简称"].ToString() };
                    Thread t = new Thread(new ParameterizedThreadStart(LoadName));
                    t.Start(flags);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }
        private void lue县区_EditValueChanged(object sender, EventArgs e)
        {
            if (lue县区.EditValue != null)
            {
                enableC(false);
                loadWeather();
            }
        }
    }
}
