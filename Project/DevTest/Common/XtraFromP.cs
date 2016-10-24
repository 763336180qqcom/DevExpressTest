using DevExpress.XtraEditors;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace DevTest.Common
{
    public partial class XtraFormP : XtraForm
    {
        
        public XtraFormP()
        {
            LoadFirst = true;
            InitializeComponent();
        }
        public static DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();
        public static string sSelectedTabName;
        public static string sCurrentWindowText;
        public static string sFormText;
        private static string mSplashCaption;
        private static string mSplashDes;
        public static string SplashCaption
        {
            get
            {
                return mSplashCaption;
            }

            set
            {
                mSplashCaption = value;
            }
        }

        public static string SplashDes
        {
            get
            {
                return mSplashDes;
            }

            set
            {
                mSplashDes = value;
            }
        }
        public static void showWait(string caption, string dex)
        {
            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormCaption(caption + "...");
                splashScreenManager1.SetWaitFormDescription(dex + "...");
            }
        }
        public static void closeWait()
        {
            if (splashScreenManager1.IsSplashFormVisible)
                splashScreenManager1.CloseWaitForm();
        }
        [DllImport("user32.dll")]
        protected static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        protected static extern int GetWindowText(IntPtr hWnd, [Out, MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpString, int nMaxCount);
        protected string GetText(IntPtr hWnd)
        {
            StringBuilder result = new StringBuilder(128);
            GetWindowText(hWnd, result, result.Capacity);
            return result.ToString();
        }
        private bool LoadFirst;
        protected void LoadFrm(XtraForm f)
        {
            if (!(Util.childs.Contains(f.Name)))
            {
                Util.childs.Add(f.Name);
                f.MdiParent = this;
                if (LoadFirst)
                {
                    f.Tag = "1stPage";
                    LoadFirst = false;
                }
                f.Show();
                
            }
        }
    }
}
