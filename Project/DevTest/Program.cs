using DevExpress.LookAndFeel;
using System;
using System.Threading;
using System.Windows.Forms;

namespace DevTest
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew = false;
            using (Mutex mutext = new Mutex(true, "Instance", out createdNew))
            {
                if (createdNew)
                {
                    DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(SplashScreen1));

                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-Hans");

                    DB.CONNSTR = System.Configuration.ConfigurationManager.ConnectionStrings["AppConnectString"].ToString();

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    DevExpress.UserSkins.BonusSkins.Register();
                    DevExpress.Skins.SkinManager.EnableFormSkins();

                    Application.Run(new frm主界面());
                }
                else
                {
                    MessageBox.Show("程序已经运行");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
            }
        }
    }
}
