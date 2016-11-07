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
        private delegate WeatherInfo DGetWeatherWithPara(object city);
        private delegate void DEndGetWeather(WeatherInfo info);
        private delegate void DFinishLoadName(DataTable dt, string code);
        private delegate void CallBackExceptionDo(string ex);
        private bool firstStart = true;
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
                enableC(false);
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
            DataTable dtName = DB.getNames(flags);
            DFinishLoadName fi = new DFinishLoadName(loadNameFinish);
            this.Invoke(fi, dtName, flags[0]);
        }

        private void loadNameFinish(DataTable dt, string code)
        {
            if (code.Equals("P"))
            {
                lue省.Properties.DataSource = dt;
                lue省.Properties.DisplayMember = "省中文";
                if (firstStart)
                    loadWeather();
                firstStart = false;
            }
            if (code.Equals("C"))
            {
                lue市.Properties.DataSource = dt;
                lue市.Properties.DisplayMember = "所属上级市中文";
            }
            if (code.Equals("D"))
            {
                lue县区.Properties.DataSource = dt;
                lue县区.Properties.DisplayMember = "中文";
            }
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

        private void dos(string ex)
        {
            enableC(true);
            XtraMessageBox.Show(ex);
        }

        private void loadWeather()
        {
            XtraFormP.showWait("请稍等", "正在加载天气信息...");
            try
            {
                DGetWeatherWithPara d = new DGetWeatherWithPara(getCityWeather);
                if (lue县区.EditValue != null)
                {
                    DataRowView drv = (DataRowView)lue县区.EditValue;
                    d.BeginInvoke(drv.Row["中文"].ToString(), new AsyncCallback(dCallBack), this);
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
                    cityName = string.Format("{0}", iin._市.Replace("市", ""));
                }

                string strUrl = string.Format("http://apis.baidu.com/heweather/weather/free?city={0}", cityName);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strUrl);
                request.Timeout = 30720;
                request.Method = "GET";
                request.Headers.Add("apikey", "a55d9829dc642857afef37284f5b4a29");
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string strJson = new StreamReader(response.GetResponseStream()).ReadToEnd();
                JObject jRoot = (JObject)JsonConvert.DeserializeObject(strJson);
                JToken J0 = jRoot["HeWeather data service 3.0"][0];

                if (J0["status"].ToString().Equals("ok"))
                {
                    WeatherInfo mainInfo = new WeatherInfo()
                    {
                        City = "当前位置:" + string.Format("{0},{1},{2}℃,能见度{3}km",
                        J0["basic"]["city"],
                        J0["now"]["cond"]["txt"], J0["now"]["tmp"],
                        J0["now"]["vis"])
                    };
                    mainInfo.ZhiShu += string.Format("舒适度指数:{0}\r\n\t穿衣指数:{1}\r\n\t" +
                        "感冒指数:{2}\r\n\t运动指数:{3}\r\n\t旅游指数:{4}",
                       J0["suggestion"]["comf"]["txt"], J0["suggestion"]["drsg"]["txt"],
                       J0["suggestion"]["flu"]["txt"], J0["suggestion"]["sport"]["txt"], J0["suggestion"]["trav"]["txt"]);
                    JToken joo = J0["daily_forecast"];
                    int count = 0;
                    foreach (var jooo in joo)
                    {
                        if (count == 4)
                            break;
                        WeatherInfoA childInfo = new WeatherInfoA()
                        {
                            Date = jooo["date"].ToString(),
                            DayP = Util.getImageFromNet(string.Format("http://files.heweather.com/cond_icon/{0}.png", jooo["cond"]["code_d"])),
                            Nightp = Util.getImageFromNet(string.Format("http://files.heweather.com/cond_icon/{0}.png", jooo["cond"]["code_n"])),
                            Wind = string.Format("{0}，{1}级", jooo["wind"]["dir"], jooo["wind"]["sc"]),
                            Weather = string.Format("白天天气：{0}{1}夜间天气：{2}", jooo["cond"]["txt_d"], Environment.NewLine, jooo["cond"]["txt_n"]),
                            Temperature = string.Format("温度：{0}℃~{1}℃", jooo["tmp"]["max"], jooo["tmp"]["min"]),
                            Sunrise = string.Format("日出时间:{0}", jooo["astro"]["sr"]),
                            Sunset = string.Format("日落时间:{0}", jooo["astro"]["ss"]),
                        };
                        mainInfo.Weather4Days.Add(childInfo);
                        count++;
                    }
                    return mainInfo;
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

                string strUrl = string.Format("http://ip.taobao.com/service/getIpInfo.php?ip={0}", ip);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strUrl);
                request.Timeout = 30720;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string strJson = new StreamReader(response.GetResponseStream()).ReadToEnd();

                    JObject jo = (JObject)JsonConvert.DeserializeObject(strJson);
                    IPInfo ipi = new IPInfo()
                    {
                        _网络IP = jo["data"]["ip"].ToString(),
                        _国家 = jo["data"]["country"].ToString(),
                        _省 = jo["data"]["region"].ToString(),
                        _市 = jo["data"]["city"].ToString(),
                        _区 = jo["data"]["city"].ToString(),
                        _运营商 = jo["data"]["city"].ToString()
                    };
                    return ipi;
                }
                return null;
            }
            catch (Exception e)
            {
                throw new CustomException(e.Message);
            }
        }
        //private void me0MouseDown(object sender, MouseEventArgs e)
        //{
        //    //HideCaret((sender as MemoEdit).Handle);
        //}
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

            meMain.Text = Environment.NewLine + info.City + Environment.NewLine + info.ZhiShu;

            
            me0.Text = info.Weather4Days[0].Date + Environment.NewLine;
            me0.Text += info.Weather4Days[0].Sunrise + Environment.NewLine;
            me0.Text += info.Weather4Days[0].Sunset + Environment.NewLine;
            me0.Text += info.Weather4Days[0].Weather + Environment.NewLine;
            me0.Text += info.Weather4Days[0].Wind + Environment.NewLine;
            me0.Text += info.Weather4Days[0].Temperature + Environment.NewLine;
            img0A.Appearance.Image = info.Weather4Days[0].DayP;
            img0B.Appearance.Image = info.Weather4Days[0].Nightp;


            me1.Text = info.Weather4Days[1].Date + Environment.NewLine;
            me1.Text += info.Weather4Days[1].Sunrise + Environment.NewLine;
            me1.Text += info.Weather4Days[1].Sunset + Environment.NewLine;
            me1.Text += info.Weather4Days[1].Weather + Environment.NewLine;
            me1.Text += info.Weather4Days[1].Wind + Environment.NewLine;
            me1.Text += info.Weather4Days[1].Temperature + Environment.NewLine;
            img1A.Appearance.Image = info.Weather4Days[1].DayP;
            img1B.Appearance.Image = info.Weather4Days[1].Nightp;


            me2.Text = info.Weather4Days[2].Date + Environment.NewLine;
            me2.Text += info.Weather4Days[2].Sunrise + Environment.NewLine;
            me2.Text += info.Weather4Days[2].Sunset + Environment.NewLine;
            me2.Text += info.Weather4Days[2].Weather + Environment.NewLine;
            me2.Text += info.Weather4Days[2].Wind + Environment.NewLine;
            me2.Text += info.Weather4Days[2].Temperature + Environment.NewLine;
            img2A.Appearance.Image = info.Weather4Days[2].DayP;
            img2B.Appearance.Image = info.Weather4Days[2].Nightp;


            me3.Text = info.Weather4Days[3].Date + Environment.NewLine;
            me3.Text += info.Weather4Days[3].Sunrise + Environment.NewLine;
            me3.Text += info.Weather4Days[3].Sunset + Environment.NewLine;
            me3.Text += info.Weather4Days[3].Weather + Environment.NewLine;
            me3.Text += info.Weather4Days[3].Wind + Environment.NewLine;
            me3.Text += info.Weather4Days[3].Temperature + Environment.NewLine;
            img3A.Appearance.Image = info.Weather4Days[3].DayP;
            img3B.Appearance.Image = info.Weather4Days[3].Nightp;

            XtraFormP.closeWait();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("楷体", 50);
            Graphics graphics = e.Graphics;
            graphics.RotateTransform(30f);
            graphics.DrawString("中国", font, new SolidBrush(Color.Brown), panel1.Location.X + panel1.Width / 2, me0.Location.Y);
        }
        private void lue省_EditValueChanged(object sender, EventArgs e)
        {
            if (lue省.EditValue != null)
            {
                try
                {
                    lue市.EditValue = null;
                    lue县区.EditValue = null;
                    DataRowView drv = (DataRowView)lue省.EditValue;
                    string[] flags = new string[] { "C", drv.Row["省中文"].ToString() };
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
                    lue县区.EditValue = null;
                    DataRowView drv = (DataRowView)lue市.EditValue;
                    string[] flags = new string[] { "D", drv.Row["所属上级市中文"].ToString() };
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
        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

    }
}
