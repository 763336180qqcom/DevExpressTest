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

namespace DevTest
{
    public partial class frm合约业务 : XFormChild
    {
        public frm合约业务()
        {
            InitializeComponent();
        }
        private BackgroundWorker mBgw进度测试;
        private int currentProgress = 0;
        private int mfocusedIndex = -1;
        private void frm合约业务_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            try
            {
                grid_合约.DataSource = DB.getDt("v合约业务", null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gv_合约.ExpandAllGroups();
            gv_合约.BestFitColumns();

            gv_Fy.BestFitColumns();
            gv_Fy.ExpandAllGroups();

            Util.createCopyCellItem(gv_合约);
            Util.createExportToExcelItem(gv_合约);
            gv_合约.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(createEditMenuPop);
            gv_合约.ClearSelection();
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
                gv_合约.FocusedRowHandle = e.HitInfo.RowHandle;
                e.Menu.Items.Add(edit);
            }
        }


        private void editClickEventHandler(object sender, EventArgs e)
        {
            int rowIndex = (int)((DXMenuItem)sender).Tag;
            frm编辑合约.str名称 = gv_合约.GetRowCellValue(gv_合约.FocusedRowHandle, "名称").ToString();
            frm编辑合约.dte开始 = Convert.ToDateTime(gv_合约.GetRowCellValue(gv_合约.FocusedRowHandle, "开始时间"));
            if (gv_合约.GetRowCellValue(gv_合约.FocusedRowHandle, "结束时间") != DBNull.Value)
                frm编辑合约.dte结束 = Convert.ToDateTime(gv_合约.GetRowCellValue(gv_合约.FocusedRowHandle, "结束时间"));
            else
                frm编辑合约.dte结束 = null;
            frm编辑合约.fID = gv_合约.GetRowCellValue(gv_合约.FocusedRowHandle, "fID").ToString();
            frm编辑合约 f = new frm编辑合约();
            if (f.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    grid_合约.DataSource = DB.getDt("v合约业务", null);
                    grid_收入费用.DataSource = null;
                    gv_合约.FocusedRowHandle = rowIndex;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                    mainId = (int)gv_合约.GetRowCellValue(gv_合约.GetSelectedRows()[0], "fID");
                }
                if (mainId >= 0)
                {
                    currentProgress = 0;
                    pgb.Text = null;
                    mBgw进度测试 = new BackgroundWorker();
                    mBgw进度测试.DoWork += new DoWorkEventHandler(bgw_DoWork);
                    mBgw进度测试.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
                    mBgw进度测试.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
                    mBgw进度测试.WorkerReportsProgress = true;
                    mBgw进度测试.WorkerSupportsCancellation = true;
                    mBgw进度测试.RunWorkerAsync(mainId);
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
                if (mBgw进度测试.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                mBgw进度测试.ReportProgress(i * 20);
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
                MessageBox.Show(this, "Error", "提示");
            }
            else
            {
                grid_收入费用.DataSource = (DataTable)e.Result;
                currentProgress = 0;
                ts.IsOn = true;
                mBgw进度测试 = null;
            }

        }

        private void ts_Toggled(object sender, EventArgs e)
        {
            if (mBgw进度测试 != null && !ts.IsOn && currentProgress != 100)
            {
                mBgw进度测试.CancelAsync();
                currentProgress = 0;
            }
            else if (mBgw进度测试 == null)
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
            GridHitInfo hitInfo = gv_合约.CalcHitInfo(new Point(e.X, e.Y));
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
        private void bw刷新合约_DoWork(object sender, DoWorkEventArgs e)
        {
            if ((sender as BackgroundWorker).CancellationPending == false)
            {
                try
                {
                    mDtHy = DB.getDt("v合约业务", null);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void bw刷新合约_ProgressChanged(object sender, ProgressChangedEventArgs e)
        { }
        private void bw刷新合约_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            grid_合约.DataSource = mDtHy;
            gv_合约.ClearSelection();
            gv_合约.FocusedRowHandle = mfocusedIndex;
            if (frm主界面.sSelectedTabName.Equals(Name) && frm主界面.sCurrentFromName.Equals(frm主界面.sText))
                TipForm.getInstance().showShort("已刷新！", 800);
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
