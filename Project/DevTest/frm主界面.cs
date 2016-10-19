using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ButtonPanel;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace DevTest
{
    public partial class frm主界面 : XtraForm
    {
        public frm主界面()
        {
            InitializeComponent();
        }
        public static string sSelectedTabName = "";
        public static string sCurrentFromName = "";
        public static string sText = "";

        public static HashSet<string> childs = new HashSet<string>();

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowText(IntPtr hWnd, [Out, MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpString, int nMaxCount);
        private string GetText(IntPtr hWnd)
        {
            StringBuilder result = new StringBuilder(128);
            GetWindowText(hWnd, result, result.Capacity);
            return result.ToString();
        }

        private void frm主界面_Load(object sender, EventArgs e)
        {
            sText = this.Text;
            StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            navBarItem1_LinkClicked(null, null);
        }
        private void midPageEvent(object sender, EventArgs e)
        {
            if (((DevExpress.XtraTabbedMdi.XtraTabbedMdiManager)sender).SelectedPage != null)
                sSelectedTabName = ((DevExpress.XtraTabbedMdi.XtraTabbedMdiManager)sender).SelectedPage.MdiChild.Name;
        }
        private void frm主界面_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("点击'否'最小化到系统托盘,点击'是'退出应用.", "确定当前应用吗?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            frm合约业务 f = new frm合约业务();
            frmShow(f);
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
            nbc_Left.Dock = (nbc_Left.Dock == DockStyle.Left ? DockStyle.Fill : DockStyle.Left);
            if (nbc_Left.Width == 169)
            {
                nbc_Left.Width = 0;
                gc_Left.Width = 29;
                pc_Left.Width = 27;
            }
            else
            {
                nbc_Left.Width = 169;
                gc_Left.Width = 198;
                pc_Left.Width = 196;
            }
            for (int i = 0; i < gc_Left.CustomHeaderButtons.Count; i++)
            {
                IBaseButton btn = gc_Left.CustomHeaderButtons[i];
                if (btn.IsChecked == true && btn.Properties.Caption.Equals("固定"))
                {
                    btn.Properties.Caption = "隐藏";
                }

            }
        }

        private void gc_Left_MouseEnter(object sender, EventArgs e)
        {
            //nbc_Left.Dock = DockStyle.Fill;
            //nbc_Left.Width = 169;
            //gc_Left.Width = 198;
        }

        private void gc_Left_MouseLeave(object sender, EventArgs e)
        {
            //nbc_Left.Dock = DockStyle.Left;
            //nbc_Left.Width = 0;
            //gc_Left.Width = 29;

        }

        private void myNotify_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Maximized;
            Activate();
        }


        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm添加合约 f = new frm添加合约();
            frmShow(f);
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmDateEdit f = new frmDateEdit();
            frmShow(f);
        }

        private PrintPreviewFormEx pv = null;
        private void navBarItem1_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmXRP xrp = new frmXRP();
            pv = new ReportPrintTool(xrp).PreviewForm;
            if (!childs.Contains(pv.Name))
            {
                pv.FormClosed += new FormClosedEventHandler(ptClosed);
                pv.MdiParent = this;
                pv.Text = "打印预览";
                childs.Add(pv.Name);
                xrp.ShowPreview();
            }
        }
        private void ptClosed(object sender, FormClosedEventArgs e)
        {
            if (childs.Contains(pv.Name))
                childs.Remove(pv.Name);
        }
        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmSG f = new frmSG();
            frmShow(f);
        }

        private void frmShow(XtraForm f)
        {
            if (!(childs.Contains(f.Name)))
            {
                childs.Add(f.Name);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void timer_getWindowText_Tick(object sender, EventArgs e)
        {
            sCurrentFromName = GetText(GetForegroundWindow());
        }
    }
}
