using DevExpress.XtraEditors;
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
    public partial class frm收入及费用 : XtraForm
    {
        public frm收入及费用()
        {
            InitializeComponent();
        }
        private int m类别=0;
        private void frm收入及费用_Load(object sender, EventArgs e)
        {
            chk状态.Checked = false;
        }

        private void btn添加_Click(object sender, EventArgs e)
        {
            frm添加合约.sDt收入费用.Rows.Add(m类别,txt名称.Text.Trim(),txt金额.Text.Trim(),txt期数.Text.Trim(),(int)chk状态.EditValue);
            this.DialogResult = DialogResult.OK;
        }

        private void cmb类别_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb类别.EditValue.ToString().Equals("费用"))
            {
                m类别 = -1;
                txt期数.EditValue = 1;
                txt期数.Enabled = false;
            }
            else
            {
                m类别 = 1;
                txt期数.Enabled = true;
            }
        }

        private void chk状态_CheckedChanged(object sender, EventArgs e)
        {
            if (chk状态.Checked)
                chk状态.EditValue = 1;
            else
                chk状态.EditValue = 0;
        }
    }
}
