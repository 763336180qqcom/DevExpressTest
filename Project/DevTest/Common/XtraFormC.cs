using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTest.Common
{
    public partial class XtraFormC : XtraForm
    {
        public XtraFormC()
        {
            InitializeComponent();
        }

        private void XFormChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Util.childs.Contains(Name))
                Util.childs.Remove(Name);
        }
        private void XFormChild_Shown(object sender, EventArgs e)
        {
            if (Tag!=null&&Tag.Equals("1stPage"))
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
            }
        }
    }
}
