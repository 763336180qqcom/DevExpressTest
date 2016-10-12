using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ButtonPanel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevTest
{
    public partial class frm主界面 : XtraForm
    {
        public static HashSet<string> childs = new HashSet<string>();
        public frm主界面()
        {
            InitializeComponent();
        }
        private void frm主界面_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            navBarItem1_LinkClicked(null, null);
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

            frm合约业务 hyyw = new frm合约业务();
            if (!(childs.Contains(hyyw.Name)))
            {
                childs.Add(hyyw.Name);
                hyyw.MdiParent = this;
                hyyw.Show();
            }

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

        private void tab_Main_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {

        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            frm新增合约 fysr = new frm新增合约();
            if (!(childs.Contains(fysr.Name)))
            {
                childs.Add(fysr.Name);
                fysr.MdiParent = this;
                fysr.Show();
            }
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmDateEdit f = new frmDateEdit();
            if (!(childs.Contains(f.Name)))
            {
                childs.Add(f.Name);
                f.MdiParent = this;
                f.Show();
            }
        }
        frmXRP xrp = null;
        private void navBarItem1_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xrp = new frmXRP();
            if (!childs.Contains(xrp.Name))
            {
                DevExpress.XtraReports.UI.ReportPrintTool pt = new DevExpress.XtraReports.UI.ReportPrintTool(xrp);
                pt.PreviewForm.FormClosed += new FormClosedEventHandler(ptClosed);
                pt.PreviewForm.MdiParent = this;
                pt.PreviewForm.Text = "打印预览";
                pt.ShowPreview();
                childs.Add(xrp.Name);
            }
        }
        private void ptClosed(object sender, FormClosedEventArgs e)
        {
            if (childs.Contains(xrp.Name))
                childs.Remove(xrp.Name);
        }
        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
    }
}
