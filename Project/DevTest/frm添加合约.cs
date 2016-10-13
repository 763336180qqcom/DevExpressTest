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
            sDt收入费用.Columns.Add("类别", Type.GetType("System.Int32"));
            sDt收入费用.Columns.Add("项目名称", Type.GetType("System.String"));
            sDt收入费用.Columns.Add("金额", Type.GetType("System.Decimal"));
            sDt收入费用.Columns.Add("期数", Type.GetType("System.Int32"));
            sDt收入费用.Columns.Add("状态", Type.GetType("System.Int32"));
        }

        private void btn添加费用收入_Click(object sender, EventArgs e)
        {
            frm收入及费用 f = new frm收入及费用();
            if (f.ShowDialog()==DialogResult.OK)
            {
                gc信息列表.DataSource = sDt收入费用;
            }
        }

        private void btn提交_Click(object sender, EventArgs e)
        {
            if (gv信息列表.RowCount == 0)
            {
                if (MessageBox.Show("没有为该合约指定任何费用收入，确定提交吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    return;
                }
            }
            try
            {
                DB.提交合约及费用(txt名称.Text.Trim(), txt运营商ID.Text.Trim(), (int)chk捆绑终端.EditValue, (int)chk允许老号.EditValue, txt店员价.Text.Trim(), txt最低价.Text.Trim(), txt毛利奖励.Text.Trim(), txt现金奖励.Text.Trim(), (DateTime?)dte开始时间.EditValue, (DateTime?)dte结束时间.EditValue, (int)chk状态.EditValue, sDt收入费用);
                MessageBox.Show("添加成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
