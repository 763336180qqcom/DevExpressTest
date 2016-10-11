using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTest
{
    public partial class frmSG : Form
    {
        public frmSG()
        {
            InitializeComponent();
        }

        private void frmSG_Load(object sender, EventArgs e)
        {
            frmXRP f = new frmXRP();
            DevExpress.XtraReports.UI.ReportPrintTool pt = new DevExpress.XtraReports.UI.ReportPrintTool(f);
                pt.ShowPreview();
                pt.PreviewForm.MdiParent = this;
        }

        private void frmSG_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(frm主界面.childs.ContainsKey(Name)))
            {
                frm主界面.childs.Remove(Name);
            }
        }
    }
}
