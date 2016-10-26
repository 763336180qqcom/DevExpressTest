using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Runtime.InteropServices;
using System.Text;
using DevTest.Common;
using DevExpress.XtraSplashScreen;

namespace DevTest
{
    public partial class frmHYYW : XtraFormC
    {
        public frmHYYW()
        {
            InitializeComponent();
        }
        private BackgroundWorker mBgwForProGress;
        private int currentProgress = 0;
        private int mfocusedIndex = -1;
        private void frmAddHY_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            try
            {
                mDtHy = DB.getDt("v合约业务", null);
                gc合约.DataSource = mDtHy;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            gvHY.ExpandAllGroups();
            gvHY.BestFitColumns();

            gv_Fy.BestFitColumns();
            gv_Fy.ExpandAllGroups();

            Util.createCopyCellItem(gvHY);
            Util.createExportToExcelItem(gvHY);
            gvHY.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(createEditMenuPop);
            gvHY.ClearSelection();
            pgb.EditValue = 0;
            pgb.Properties.Maximum = 100;
            pgb.Properties.Minimum = 0;
            pgb.Properties.Step = 1;
            ts.IsOn = true;
            groupControl1.Parent = this;
            groupControl2.Parent = this;
        }
        private void createEditMenuPop(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row && e.HitInfo.InRow)
            {
                DXMenuItem edit = new DXMenuItem("编辑", new EventHandler(editClickEventHandler), null);
                edit.Tag = e.HitInfo.RowHandle;
                gvHY.FocusedRowHandle = e.HitInfo.RowHandle;
                e.Menu.Items.Add(edit);
            }
        }


        private void editClickEventHandler(object sender, EventArgs e)
        {
            int rowIndex = (int)((DXMenuItem)sender).Tag;
            frmEditHY.str名称 = gvHY.GetRowCellValue(gvHY.FocusedRowHandle, "名称").ToString();
            frmEditHY.dte开始 = Convert.ToDateTime(gvHY.GetRowCellValue(gvHY.FocusedRowHandle, "开始时间"));
            if (gvHY.GetRowCellValue(gvHY.FocusedRowHandle, "结束时间") != DBNull.Value)
                frmEditHY.dte结束 = Convert.ToDateTime(gvHY.GetRowCellValue(gvHY.FocusedRowHandle, "结束时间"));
            else
                frmEditHY.dte结束 = null;
            frmEditHY.fID = gvHY.GetRowCellValue(gvHY.FocusedRowHandle, "fID").ToString();
            frmEditHY f = new frmEditHY();
            if (f.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    gc合约.DataSource = DB.getDt("v合约业务", null);
                    grid_收入费用.DataSource = null;
                    gvHY.FocusedRowHandle = rowIndex;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void gv_hy_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                mfocusedIndex = e.RowHandle;
            }
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                if (currentProgress != 0)
                {
                    return;
                }
                else
                {
                    ts.IsOn = true;
                }
                int mainId = -1;
                if (e.RowHandle >= 0 && e.Button == MouseButtons.Left)
                {
                    mainId = (int)gvHY.GetRowCellValue(gvHY.GetSelectedRows()[0], "fID");
                }
                if (mainId >= 0)
                {
                    currentProgress = 0;
                    pgb.Text = null;
                    mBgwForProGress = new BackgroundWorker();
                    mBgwForProGress.DoWork += new DoWorkEventHandler(bgw_DoWork);
                    mBgwForProGress.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
                    mBgwForProGress.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
                    mBgwForProGress.WorkerReportsProgress = true;
                    mBgwForProGress.WorkerSupportsCancellation = true;
                    mBgwForProGress.RunWorkerAsync(mainId);
                }
            }
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            List<ConditionItem> cis = new List<ConditionItem>();
            ConditionItem ci = new ConditionItem();
            ci.Type = "=";
            ci.Name = "业务ID";
            ci.Value = e.Argument.ToString();
            cis.Add(ci);
            for (int i = 1; i <= 5; i++)
            {
                if (mBgwForProGress.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                mBgwForProGress.ReportProgress(i * 20);
                Thread.Sleep(500);
                if (i == 5)
                {
                    DataTable dt = DB.getDt("v费用收入", cis);
                    e.Result = dt;
                }
            }

        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            currentProgress = e.ProgressPercentage;
            pgb.Text = currentProgress.ToString();

        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                return;
            }
            else if (e.Error != null)
            {
                XtraMessageBox.Show(this, "Error", "提示");
            }
            else
            {
                grid_收入费用.DataSource = (DataTable)e.Result;
                currentProgress = 0;
                ts.IsOn = true;
                mBgwForProGress = null;
            }

        }

        private void ts_Toggled(object sender, EventArgs e)
        {
            if (mBgwForProGress != null && !ts.IsOn && currentProgress != 100)
            {
                mBgwForProGress.CancelAsync();
                currentProgress = 0;
            }
            else if (mBgwForProGress == null)
            {
                ts.IsOn = true;
            }
        }

        private void gv_hy_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gv_Hy_MouseMove(object sender, MouseEventArgs e)
        {
            GridHitInfo hitInfo = gvHY.CalcHitInfo(new Point(e.X, e.Y));
            if (hitInfo.InRow == false || hitInfo.RowHandle < 0 || hitInfo.Column == null)
            {
                toolTipController1.HideHint();
                return;
            }
            showHint();
        }
        private void showHint()
        {
            string tip = "双击加载收入及费用信息！";
            ToolTipControllerShowEventArgs args = toolTipController1.CreateShowArgs();
            args.ToolTip = tip;
            toolTipController1.ShowHint(args, Control.MousePosition);
        }

        private void gv_Hy_MouseLeave(object sender, EventArgs e)
        {
            toolTipController1.HideHint();
        }
        private DataTable mDtHy = null;
        private string mLastStamp = "-1";
        private void bwRefreshHY_DoWork(object sender, DoWorkEventArgs e)
        {
            if ((sender as BackgroundWorker).CancellationPending == false)
            {
                try
                {
                    e.Result = DB.sRefreshHY(ref mLastStamp);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void bwRefreshHY_ProgressChanged(object sender, ProgressChangedEventArgs e)
        { }
        private void bwRefreshHY_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                gc合约.DataSource = e.Result;
                gvHY.ClearSelection();
                gvHY.FocusedRowHandle = mfocusedIndex;
                if (XtraFormP.sSelectedTabName.Equals(Name) && XtraFormP.sCurrentWindowText.Equals(frmMain.sFormText))
                    TipForm.getInstance().shortTip("已刷新！", 800);
            }
        }
        private void frm合约业务_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled && !bw刷新合约.IsBusy)
                bw刷新合约.RunWorkerAsync();
        }

        private void gv_Hy_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            grid_收入费用.DataSource = null;
        }
    }
}
