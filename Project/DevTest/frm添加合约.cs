using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevTest.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace DevTest
{
    public partial class frm添加合约 : XFormChild
    {
        public frm添加合约()
        {
            InitializeComponent();
        }
        private DataTable mTempDt合约 = null;
        public static DataTable sDt收入费用 = null;

        private void frm添加合约_Load(object sender, EventArgs e)
        {
            chk捆绑终端.Checked = false;
            chk允许老号.Checked = false;
            chk状态.Checked = false;
            dte开始时间.EditValue = DateTime.Today;
            dte结束时间.EditValue = null;
            gv信息列表.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(gv信息列表PopMenuEvent);
            try
            {
                System.Threading.Thread thread = new System.Threading.Thread(
                    new System.Threading.ParameterizedThreadStart(iniDt));
                thread.Start("v合约业务");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }
        #region Control.BeginInvoke
        private int id;
        private int id1;
        private delegate void fin();
        private void iniDt(object dtName)
        {
            id = System.Threading.Thread.CurrentThread.ManagedThreadId;
            mTempDt合约 = DB.getDt(dtName.ToString(), null);
            sDt收入费用 = DB.Ini收入费用表结构().Clone();
            fin f = new fin(afterIniDt);
            this.BeginInvoke(f);
            //f.BeginInvoke();
        }
        private void afterIniDt()
        {
            lookUpEdit1.Properties.DataSource = mTempDt合约;
            sDt收入费用.Columns.Remove("业务ID");
            id1 = System.Threading.Thread.CurrentThread.ManagedThreadId;
        }
        #endregion
        private void gv信息列表PopMenuEvent(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row && e.HitInfo.InRow)
            {
                DXMenuItem item = new DXMenuItem("删除", new EventHandler(editMenuClick), null);
                e.Menu.Items.Add(item);
            }
        }
        private void editMenuClick(object sender, EventArgs e)
        {
            int[] selectedRows = gv信息列表.GetSelectedRows();
            Util.quickSort(selectedRows);
            for (int i = selectedRows.Length - 1; i >= 0; i--)
            {
                sDt收入费用.Rows.RemoveAt(selectedRows[i]);
            }
        }


        public static int sMode = 1;
        private void btn添加费用收入_Click(object sender, EventArgs e)
        {
            sMode = 1;
            frm收入费用 f = new frm收入费用();
            if (f.ShowDialog() == DialogResult.OK)
            {
                gc信息列表.DataSource = sDt收入费用;
            }
        }

        private void btn提交_Click(object sender, EventArgs e)
        {
            if (gv信息列表.RowCount == 0 && MessageBox.Show("没有为该合约指定任何费用收入，确定提交吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                DB.提交合约及费用(txt名称.Text.Trim(), txt运营商ID.Text, (int)chk捆绑终端.EditValue, (int)chk允许老号.EditValue, txt店员价.Text, txt最低价.Text, txt毛利奖励.Text, txt现金奖励.Text, (DateTime?)dte开始时间.EditValue, (DateTime?)dte结束时间.EditValue, (int)chk状态.EditValue, sDt收入费用);
                mTempDt合约 = DB.getDt("v合约业务", null);
                lookUpEdit1.Properties.DataSource = mTempDt合约;
                clearData();
                TipForm.getInstance().showShort(800);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "提示");
            }
        }

        private void clearData()
        {
            foreach (Control control in groupControl1.Controls)
            {
                if (control is TextEdit)
                    ((TextEdit)control).Text = "";
                if (control is CheckEdit)
                    ((CheckEdit)control).Checked = false;
                if (control is DateEdit)
                    ((DateEdit)control).EditValue = null;
                if (control is LookUpEdit)
                    ((LookUpEdit)control).EditValue = null;
            }
        }

        private void chk状态_CheckedChanged(object sender, EventArgs e)
        {
            if (chk状态.Checked)
                chk状态.EditValue = 1;
            else
                chk状态.EditValue = 0;
        }

        private void chk捆绑终端_CheckedChanged(object sender, EventArgs e)
        {
            if (chk捆绑终端.Checked)
                chk捆绑终端.EditValue = 1;
            else
                chk捆绑终端.EditValue = 0;
        }

        private void chk允许老号_CheckedChanged(object sender, EventArgs e)
        {
            if (chk允许老号.Checked)
                chk允许老号.EditValue = 1;
            else
                chk允许老号.EditValue = 0;
        }

        private void gv信息列表_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
        private frm收入费用 f = new frm收入费用();
        private void gv信息列表_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                sMode = 0;
                frm收入费用.sRowIndex = e.RowHandle;
                f.str类别 = gv信息列表.GetRowCellValue(e.RowHandle, gv信息列表.Columns["类别"]).ToString();
                f.str名称 = gv信息列表.GetRowCellValue(e.RowHandle, gv信息列表.Columns["项目名称"]).ToString();
                f.str金额 = gv信息列表.GetRowCellValue(e.RowHandle, gv信息列表.Columns["金额"]).ToString();
                f.str期数 = gv信息列表.GetRowCellValue(e.RowHandle, gv信息列表.Columns["期数"]).ToString();
                f.str状态 = gv信息列表.GetRowCellValue(e.RowHandle, gv信息列表.Columns["状态"]).ToString();
                f.ShowDialog();
            }
        }
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEdit1.EditValue != null && lookUpEdit1.EditValue is DataRowView)
            {
                DataRowView drv = (DataRowView)lookUpEdit1.EditValue;
                txt名称.Text = (drv.Row)["名称"].ToString();
                txt运营商ID.Text = (drv.Row)["运营商ID"].ToString();
                if ((drv.Row)["捆绑终端"].Equals("需要"))
                    chk捆绑终端.Checked = true;
                else
                    chk捆绑终端.Checked = false;
                if ((drv.Row)["允许老号"].Equals("是"))
                    chk允许老号.Checked = true;
                else
                    chk允许老号.Checked = false;
                txt店员价.Text = (drv.Row)["店员价"].ToString();
                txt最低价.Text = (drv.Row)["最低价"].ToString();
                txt毛利奖励.Text = (drv.Row)["毛利奖励"].ToString();
                txt现金奖励.Text = (drv.Row)["现金奖励"].ToString();
                dte开始时间.EditValue = Convert.ToDateTime((drv.Row)["开始时间"]);
                if ((drv.Row)["结束时间"] != DBNull.Value)
                    dte结束时间.EditValue = Convert.ToDateTime((drv.Row)["结束时间"]);
                else
                    dte结束时间.EditValue = null;
                if ((drv.Row)["状态"].Equals("有效"))
                    chk状态.Checked = true;
                else
                    chk状态.Checked = false;
                try
                {
                    List<ConditionItem> lists = new List<ConditionItem>();
                    ConditionItem item = new ConditionItem();
                    item.Value = (drv.Row)["fID"].ToString();
                    item.Name = "业务ID";
                    item.Type = "=";
                    lists.Add(item);
                    DataTable dt = new DataTable();
                    dt = DB.getDt("v费用收入", lists);
                    dt.Columns.Remove("业务ID");
                    sDt收入费用.Clear();
                    foreach (DataRow dr in dt.Rows)
                        sDt收入费用.ImportRow(dr);
                    gc信息列表.DataSource = sDt收入费用;
                    lookUpEdit1.Properties.DisplayMember = "状态";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
        }

        private void searchLookUpEdit1View_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
        private void searchLookUpEdit1View_MouseUp(object sender, MouseEventArgs e)
        {
            lookUpEdit1.EditValue = null;
        }
    }
}
