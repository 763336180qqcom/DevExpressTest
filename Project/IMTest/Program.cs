using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMTest
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
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-Hans");

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    DevExpress.UserSkins.BonusSkins.Register();
                    DevExpress.Skins.SkinManager.EnableFormSkins();

                    Application.Run(new V.Form1());
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
