using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Threading;
using DevExpress.XtraEditors;
using DevExpress.Utils;

namespace DevTest
{
    public partial class frm合约业务 : DevExpress.XtraEditors.XtraForm
    {
        public frm合约业务()
        {
            InitializeComponent();
        }
        private BackgroundWorker mBgw;
        private int currentProgress = 0;
        private void frm合约业务_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            try
            {
                gc_Hy.DataSource = DB.getDt("v合约业务", null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gv_Hy.ExpandAllGroups();
            gv_Hy.BestFitColumns();

            gv_Fy.BestFitColumns();
            gv_Fy.ExpandAllGroups();

            Util.CreateCopyCellItem(gv_Hy);
            pgb.EditValue = 0;
            pgb.Properties.Maximum = 100;
            pgb.Properties.Minimum = 0;
            pgb.Properties.Step = 1;
            ts.IsOn = true;
            groupControl1.Parent = this;
            groupControl2.Parent = this;
        }

        private void gv_hy_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
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
                    mainId = (int)gv_Hy.GetRowCellValue(gv_Hy.GetSelectedRows()[0], "fID");
                }
                if (mainId >= 0)
                {
                    currentProgress = 0;
                    pgb.Text = null;
                    mBgw = new BackgroundWorker();
                    mBgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
                    mBgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
                    mBgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
                    mBgw.WorkerReportsProgress = true;
                    mBgw.WorkerSupportsCancellation = true;
                    mBgw.RunWorkerAsync(mainId);
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
                if (mBgw.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                mBgw.ReportProgress(i * 20);
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
                gc_fy.DataSource = (DataTable)e.Result;
                currentProgress = 0;
                ts.IsOn = true;
                mBgw = null;
            }

        }

        private void frm合约业务_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frm主界面.childs.Contains(Name))
                frm主界面.childs.Remove(Name);
        }

        private void ts_Toggled(object sender, EventArgs e)
        {
            if (mBgw != null && !ts.IsOn && currentProgress != 100)
            {
                mBgw.CancelAsync();
                currentProgress = 0;
            }else if (mBgw == null)
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
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hitInfo = gv_Hy.CalcHitInfo(new Point(e.X, e.Y));
            if (hitInfo.RowHandle < 0 && hitInfo.Column == null)
                return;
            string tip = "双击加载收入及费用信息！";
            ToolTipControllerShowEventArgs args = toolTipController1.CreateShowArgs();
            args.ToolTip = tip;
            toolTipController1.ShowHint(args,Control.MousePosition);
        }

        private void gc_Hy_MouseHover(object sender, EventArgs e)
        {
         
        }
    }
}
