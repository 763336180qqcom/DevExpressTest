using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.Repository;

namespace DevTest
{
    public partial class frm新增合约 : XtraForm
    {
        private DataTable mTempDt_Fy = null;
        private DataTable mFloatTable = null;
        private DataTable mTempDt_Hy = null;
        private string mToken = "";
        private Hashtable mHtIDs = new Hashtable();
        public frm新增合约()
        {
            InitializeComponent();
        }
       private  void cb_state_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            e.Value = e.Value.ToString();
            e.Handled = true;
        }
        private void frm费用收入_Load(object sender, EventArgs e)
        {
            cb_state_hy.ParseEditValue += new ConvertEditValueEventHandler(cb_state_ParseEditValue);
            mFloatTable = DB.getDt("v合约业务", null);
            lue_Data.Properties.DataSource = mFloatTable;
            lue_Data.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            searchLookUpEditView.IndicatorWidth = 20;
            gv_hy.ExpandAllGroups();
            gv_hy.BestFitColumns();
            gv_fy.BestFitColumns();
            gv_fy.ExpandAllGroups();
            getFyTableStructure();

        }
        private void lue_Data_EditValueChanged(object sender, EventArgs e)
        {
            if (lue_Data.EditValue != null)
            {
                DataRowView drv = (DataRowView)lue_Data.EditValue;
                DataRow dr = drv.Row;
                int id = new Random().Next(200);
                if (gc_hy.DataSource == null)
                {
                    mTempDt_Hy = mFloatTable.Clone();
                    mTempDt_Hy.Clear();
                    mTempDt_Hy.ImportRow(dr);
                    gc_hy.DataSource = mTempDt_Hy;
                    mHtIDs.Add(0, id);
                }
                else
                {
                    mTempDt_Hy = gc_hy.DataSource as DataTable;
                    mTempDt_Hy.ImportRow(dr);
                    gc_hy.RefreshDataSource();
                    while (mHtIDs.ContainsValue(id))
                    {
                        id = new Random().Next(200);
                    }
                    mHtIDs.Add(mTempDt_Hy.Rows.Count - 1, id);
                }
                lue_Data.Properties.DisplayMember = "状态";
            }
        }

        private void frm费用收入_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frm主界面.childs.Contains(Name))
            {
                frm主界面.childs.Remove(Name);
            }
        }

        private void gv_hy_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }

        }


        private void btn_NewClick(object sender, EventArgs e)
        {
            int id = new Random().Next(200);
            if (gc_hy.DataSource == null)
            {
                mTempDt_Hy = mFloatTable.Clone();
                mTempDt_Hy.Clear();
                mTempDt_Hy.Rows.Add(0, "", 0, "", "", 0, 0, 0, 0, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortDateString(), "");
                gc_hy.DataSource = mTempDt_Hy;
                mHtIDs.Add(0, id);
            }
            else
            {
                mTempDt_Hy = gc_hy.DataSource as DataTable;
                mTempDt_Hy.Rows.Add(0, "", 0, "", "", 0, 0, 0, 0, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortDateString(), "");
                gc_hy.RefreshDataSource();
                while (mHtIDs.ContainsValue(id))
                {
                    id = new Random().Next(200);
                }
                mHtIDs.Add(mTempDt_Hy.Rows.Count - 1, id);
            }

        }

        private void searchLookUpEdit1View_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void btn_SaveClick(object sender, EventArgs e)
        {

        }


        private void gv_hy_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == GridMenuType.Row && e.HitInfo.InRow)
            {
                GridView grid = sender as GridView;
                grid.FocusedRowHandle = e.HitInfo.RowHandle;

                DXMenuItem itemDelete = new DXMenuItem("删除选中行", new EventHandler(onDeleteClick), null);
                itemDelete.Tag = grid;

                DXMenuItem itemAdd = new DXMenuItem("增加费用或收入项", new EventHandler(onAddClick), null);
                itemAdd.Tag = grid;
                e.Menu.Items.Add(itemDelete);
                if (grid.Name.Equals(gv_hy.Name))
                    e.Menu.Items.Add(itemAdd);

                DXMenuItem itemCommit = new DXMenuItem("提交该条信息", new EventHandler(onCommitClick), null);
                itemCommit.Tag = grid;
                if (grid.Name.Equals(gv_hy.Name))
                    e.Menu.Items.Add(itemCommit);
            }
        }
        private void onCommitClick(object sender, EventArgs e)
        {
            try
            {
                GridView v = (GridView)(((DXMenuItem)sender).Tag);
                int rowHandle = v.FocusedRowHandle;
                int token = (int)mHtIDs[rowHandle];
                Hashtable paraHt_HY = new Hashtable();
                paraHt_HY.Add("名称", (string)mTempDt_Hy.Rows[rowHandle]["名称"]);
                paraHt_HY.Add("运营商ID", Convert.ToInt32(mTempDt_Hy.Rows[rowHandle]["运营商ID"]));
                if ( mTempDt_Hy.Rows[rowHandle]["捆绑终端"].ToString().Equals("需要"))
                    paraHt_HY.Add("捆绑终端", 1);
                else
                    paraHt_HY.Add("捆绑终端", 0);
                if (mTempDt_Hy.Rows[rowHandle]["允许老号"].ToString().Equals("是"))
                    paraHt_HY.Add("允许老号", 1);
                else
                    paraHt_HY.Add("允许老号", 0);
                if (mTempDt_Hy.Rows[rowHandle]["状态"].ToString().Equals("有效"))
                {
                    paraHt_HY.Add("状态", 1);
                }
                else if (mTempDt_Hy.Rows[rowHandle]["状态"].ToString().Equals("无效"))
                {
                    paraHt_HY.Add("状态", 0);
                }
                else
                {
                    MessageBox.Show("选择状态!","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                paraHt_HY.Add("店员价", (decimal)mTempDt_Hy.Rows[rowHandle]["店员价"]);
                paraHt_HY.Add("最低价", (decimal)mTempDt_Hy.Rows[rowHandle]["最低价"]);
                paraHt_HY.Add("毛利奖励", (decimal)mTempDt_Hy.Rows[rowHandle]["毛利奖励"]);
                paraHt_HY.Add("现金奖励", (decimal)mTempDt_Hy.Rows[rowHandle]["现金奖励"]);
                paraHt_HY.Add("开始时间", Convert.ToDateTime(mTempDt_Hy.Rows[rowHandle]["开始时间"]));
                paraHt_HY.Add("结束时间", Convert.ToDateTime(mTempDt_Hy.Rows[rowHandle]["结束时间"]));
                List<Hashtable> paraHt_FYS = new List<Hashtable>();
                for (int i = 0; i < mTempDt_Fy.Rows.Count; i++)
                {
                    if ((int)mTempDt_Fy.Rows[i]["业务ID"] == token)
                    {
                        Hashtable paraHt_FY = new Hashtable();
                        {
                            if (mTempDt_Fy.Rows[i]["类别"].Equals("费用"))
                                paraHt_FY.Add("type", -1);
                            else
                                paraHt_FY.Add("type", 1);
                            paraHt_FY.Add("名称", (string)mTempDt_Fy.Rows[i]["项目名称"]);
                            paraHt_FY.Add("金额", (decimal)mTempDt_Fy.Rows[i]["金额"]);
                            if (mTempDt_Fy.Rows[i]["类别"].Equals("费用"))
                                paraHt_FY.Add("期数", 1);
                            else
                                paraHt_FY.Add("期数", (int)mTempDt_Fy.Rows[i]["期数"]);
                            if (mTempDt_Fy.Rows[i]["状态"].Equals("有效"))
                                paraHt_FY.Add("状态", 1);
                            else
                                paraHt_FY.Add("状态", 0);
                        }
                        paraHt_FYS.Add(paraHt_HY);
                    }
                }
                DB.提交合约及费用(paraHt_HY, paraHt_FYS);
                MessageBox.Show("插入成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void onDeleteClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除选中行的数据吗？", "确认提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                GridView v = (GridView)(((DXMenuItem)sender).Tag);
                if (v.Equals(gv_hy))
                {
                    for (int i = v.GetSelectedRows().Length - 1; i >= 0; i--)
                    {
                        int focusedRowId = v.GetSelectedRows()[i];
                        string token = mHtIDs[focusedRowId].ToString();
                        mTempDt_Hy.Rows.RemoveAt(focusedRowId); ;
                        int count = mHtIDs.Count;
                        for (int key = focusedRowId + 1; key <= count; key++)
                        {
                            mHtIDs.Remove(key - 1);
                            if (key != count)
                            {
                                mHtIDs.Add(key - 1, mHtIDs[key]);
                            }
                        }
                        for (int j = mTempDt_Fy.Rows.Count - 1; j >= 0; j--)
                        {
                            if (mTempDt_Fy.Rows[j]["业务ID"].ToString().Equals(token))
                            {
                                mTempDt_Fy.Rows.RemoveAt(j);
                            }
                        }
                    }
                }
                else
                {
                    for (int i = v.GetSelectedRows().Length - 1; i >= 0; i--)
                    {
                        int focusedRowId = v.GetSelectedRows()[i];
                        mTempDt_Fy.Rows.RemoveAt(focusedRowId);
                    }
                }
                gc_fy.RefreshDataSource();
                gc_hy.RefreshDataSource();
            }
        }
        private void onAddClick(object sender, EventArgs e)
        {
            GridView v = (GridView)(((DXMenuItem)sender).Tag);
            if (v.GetSelectedRows().Length != 1)
            {
                MessageBox.Show("选择一条数据!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable dataTable = ((DataView)v.DataSource).Table;
                mToken = mHtIDs[v.FocusedRowHandle].ToString();//dataTable.Rows[v.GetSelectedRows()[0]]["fID"].ToString();
                mTempDt_Fy.Rows.Add(mToken, "", "", 0, 1, "无效");
                gc_fy.DataSource = mTempDt_Fy;
            }

        }


        private DataTable getFyTableStructure()
        {
            if (mTempDt_Fy == null)
            {
                mTempDt_Fy = new DataTable();
                mTempDt_Fy.Columns.Add("业务ID", Type.GetType("System.String"));
                mTempDt_Fy.Columns.Add("类别", Type.GetType("System.String"));
                mTempDt_Fy.Columns.Add("项目名称", Type.GetType("System.String"));
                mTempDt_Fy.Columns.Add("金额", Type.GetType("System.Decimal"));
                mTempDt_Fy.Columns.Add("期数", Type.GetType("System.Int32"));
                mTempDt_Fy.Columns.Add("状态", Type.GetType("System.String"));
            }
            return mTempDt_Fy;

        }

        private void gv_fy_RowStyle(object sender, RowStyleEventArgs e)
        {


        }


        private void gv_hy_RowCellClick(object sender, RowCellClickEventArgs e)
        {

        }

        private void gv_hy_MouseDown(object sender, MouseEventArgs e)
        {
            if (mTempDt_Fy != null && gv_hy.GetSelectedRows().Length == 1)
            {
                GridHitInfo hit = gv_hy.CalcHitInfo(e.X, e.Y);
                if (hit.InRow && e.Button == MouseButtons.Left)
                {
                    DataTable dataTable = ((DataView)gv_hy.DataSource).Table;
                    mToken = mHtIDs[hit.RowHandle].ToString();
                    if (gc_fy.DataSource != null)
                    {
                        gc_fy.RefreshDataSource();
                    }
                }
            }

        }

        private void gv_fy_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (gc_fy.DataSource != null && mTempDt_Fy != null && gv_hy.GetSelectedRows().Length == 1)
            {
                for (int i = 0; i < mTempDt_Fy.Rows.Count; i++)
                {
                    if (mTempDt_Fy.Rows[i]["业务ID"].ToString().Equals(mToken) && e.RowHandle == i)
                    {
                        e.Appearance.BackColor = Color.LightGreen;
                    }
                    else if (e.RowHandle == i)
                    {
                        e.Appearance.BackColor = Color.White;
                    }
                }
            }
        }

        private void searchLookUpEditView_MouseUp(object sender, MouseEventArgs e)
        {
            lue_Data.EditValue = null;
        }

        private void gv_hy_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void gv_hy_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName.Equals("运营商ID") && !Util.IsNumber((string)e.Value))
            {
                //int result;
                // if (!int.TryParse((string)e.Value, out result))
                MessageBox.Show("运营商ID 为数字！   ");
                gv_hy.SetFocusedRowCellValue("运营商ID", null);
                return;
            }
        }
    }
}
