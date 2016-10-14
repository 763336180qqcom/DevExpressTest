using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class frm添加合约 : XtraForm
    {
        public frm添加合约()
        {
            InitializeComponent();
        }
        public static DataTable sDt收入费用 = null;
        private void frm添加合约_Load(object sender, EventArgs e)
        {
            chk捆绑终端.Checked = false;
            chk允许老号.Checked = false;
            chk状态.Checked = false;
            dte开始时间.EditValue = DateTime.Now;
            dte结束时间.EditValue = DateTime.Now;
            sDt收入费用 = new DataTable();
            sDt收入费用.Columns.Add("类别", Type.GetType("System.String"));
            sDt收入费用.Columns.Add("项目名称", Type.GetType("System.String"));
            sDt收入费用.Columns.Add("金额", Type.GetType("System.String"));
            sDt收入费用.Columns.Add("期数", Type.GetType("System.String"));
            sDt收入费用.Columns.Add("状态", Type.GetType("System.String"));
        }

        private void btn添加费用收入_Click(object sender, EventArgs e)
        {
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
                if (sDt收入费用 != null)
                {
                    for (int i = 0; i < sDt收入费用.Rows.Count; i++)
                    {
                        if (sDt收入费用.Rows[i]["类别"].ToString().Equals("收入"))
                            sDt收入费用.Rows[i]["类别"] = 1;
                        else
                            sDt收入费用.Rows[i]["类别"] = -1;
                    }
                }
                DB.提交合约及费用(txt名称.EditValue.ToString().Trim(), txt运营商ID.EditValue.ToString().Trim(), (int)chk捆绑终端.EditValue, (int)chk允许老号.EditValue, txt店员价.EditValue.ToString().Trim(), txt最低价.EditValue.ToString().Trim(), txt毛利奖励.EditValue.ToString().Trim(), txt现金奖励.EditValue.ToString().Trim(), (DateTime?)dte开始时间.EditValue, (DateTime?)dte结束时间.EditValue, (int)chk状态.EditValue, sDt收入费用);
                TipForm.getInstance().showShortTip("提交成功！", 800);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "提示");
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

        private void gv信息列表_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                frm收入费用 f = new frm收入费用();
                f.str类别 = gv信息列表.GetRowCellValue(e.RowHandle, gv信息列表.Columns["类别"]).ToString();
                f.str名称 = gv信息列表.GetRowCellValue(e.RowHandle, gv信息列表.Columns["项目名称"]).ToString();
                f.str金额 = gv信息列表.GetRowCellValue(e.RowHandle, gv信息列表.Columns["金额"]).ToString();
                f.str期数 = gv信息列表.GetRowCellValue(e.RowHandle, gv信息列表.Columns["期数"]).ToString();
                f.str状态 = gv信息列表.GetRowCellValue(e.RowHandle, gv信息列表.Columns["状态"]).ToString();
                f.Show();
            }
        }
    }
}
