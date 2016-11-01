using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ButtonPanel;
using DevExpress.XtraNavBar;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using DevTest.Common;
using DevTest.测试1;
using DevTest.测试2;
using System;
using System.Windows.Forms;

namespace DevTest
{
    public partial class frmMain : XtraFormP
    {
        private DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton gpBoxBtn_Hide;
        public frmMain()
        {
            sSelectedTabName = "";
            sCurrentWindowText = "";
            sFormText = "";
            InitializeComponent();
        }
        private void frm主界面_Load(object sender, EventArgs e)
        {
            gpBoxBtn_Hide = new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("隐藏", null) { Tag = "hide" };
            this.gc_Left.CustomHeaderButtons.AddRange(new IBaseButton[] { gpBoxBtn_Hide });
            sFormText = this.Text;
            StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            navBarWeather_LinkClicked(null, null);
        }
        private void midPageChangedEventHandler(object sender, EventArgs e)
        {
            if (((DevExpress.XtraTabbedMdi.XtraTabbedMdiManager)sender).SelectedPage != null)
                sSelectedTabName = ((DevExpress.XtraTabbedMdi.XtraTabbedMdiManager)sender).SelectedPage.MdiChild.Name;
        }
        private void frm主界面_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (XtraMessageBox.Show("点击'否'最小化到系统托盘,点击'是'退出应用.", "确定当前应用吗?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    myNotify.Dispose();
                    Dispose();
                    Application.Exit();
                }
                else
                {
                    myNotify.Visible = true;
                    e.Cancel = true;
                    Hide();
                }
            }
        }
        private void navBar合约业务_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadFrm(new frmHYYW());
        }

        private void toolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            myNotify.Dispose();
            Dispose();
            Application.Exit();
        }
        private void toolStripMenuItem_Show_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Maximized;
            Activate();
        }
        private void gcLeft_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "hide":
                    nbc_Left.Dock = (nbc_Left.Dock == DockStyle.Left ? DockStyle.Fill : DockStyle.Left);
                    switch (e.Button.Properties.Caption)
                    {
                        case "固定":
                            nbc_Left.Width = 169;
                            gc_Left.Width = 198;
                            pc_Left.Width = 196;
                            e.Button.Properties.Caption = "隐藏";
                            break;
                        case "隐藏":
                            nbc_Left.Width = 0;
                            gc_Left.Width = 29;
                            pc_Left.Width = 27;
                            e.Button.Properties.Caption = "固定";
                            break;
                    }
                    break;
            }
        }
        private void myNotify_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Maximized;
            Activate();
        }
        private void navBar新增合约_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadFrm(new frmAddHY());
        }
        private void navBarDateEdit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadFrm(new frmDateEdit());
        }
        private PrintPreviewFormEx pv = null;
        private void navBarReports_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmXRP xrp = new frmXRP();
            pv = new ReportPrintTool(xrp).PreviewForm;
            if (!Util.childs.Contains(pv.Name))
            {
                pv.FormClosed += new FormClosedEventHandler(ptClosed);
                pv.MdiParent = this;
                pv.Text = "打印预览";
                Util.childs.Add(pv.Name);
                xrp.ShowPreview();
            }
        }
        private void ptClosed(object sender, FormClosedEventArgs e)
        {
            if (Util.childs.Contains(pv.Name))
                Util.childs.Remove(pv.Name);
        }
        private void navBarSGRID_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadFrm(new frmSG());
        }
        private void timer_getWindowText_Tick(object sender, EventArgs e)
        {
            sCurrentWindowText = GetText(GetForegroundWindow());
        }
        private void navBarWeather_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadFrm(new frmWeather());
        }
        private void navBar截屏_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadFrm(new frmPrintScreen());
        }

        private void navBarVCode_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            LoadFrm(new frmVerCode());
        }

        private void navBarEF1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            LoadFrm(new frmEF1());
        }
    }
}
