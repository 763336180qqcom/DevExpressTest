using DevExpress.LookAndFeel;
using System;
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
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(SplashScreen1));

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-Hans");
            DB.CONNSTR = System.Configuration.ConfigurationManager.ConnectionStrings["AppConnectString"].ToString();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
           
            Application.Run(new frm主界面());
        }
    }
}
