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

                    Application.Run(new frmMain());
                }
                else
                {
                    MessageBox.Show(null, "程序已经运行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Environment.Exit(0);
                }
            }
        }
    }
}
