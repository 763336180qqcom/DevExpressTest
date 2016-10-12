using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTest
{
    public partial class frmDateEdit : XtraForm
    {


        public frmDateEdit()
        {
            InitializeComponent();
        }

        private void frmDateEdit_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(FormClose);
            //dateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            //dateEdit1.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.True;
            //dateEdit1.Properties.DisplayFormat.FormatString = "G";
            //dateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            //dateEdit1.Properties.EditFormat.FormatString = "G";
            //dateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            //dateEdit1.EditValue = DateTime.Now;
            //SqlConnection con = new SqlConnection(DB.CONNSTR);
            //try
            //{
            //    con.Open();
            //    SqlCommand cmd = null;
            //    cmd.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message+"空cmd");
            //}
        }
        private void FormClose(Object sender, FormClosedEventArgs e)
        {
            if (frm主界面.childs.Contains(Name))
                frm主界面.childs.Remove(Name);
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            txt_value.Text = dateEdit1.EditValue.ToString();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            format("y", sender);
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            format("f", sender);
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            format("F", sender);

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            format("d", sender);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            format("D", sender);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            format("t", sender);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            format("T", sender);
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            format("g", sender);
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            format("G", sender);
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            format("m", sender);
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            format("r", sender);
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            format("s", sender);
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            format("u", sender);
        }
        private SimpleButton currentBtn;
        private void format(string form, object sender)
        {
            if (currentBtn != null && currentBtn.Appearance.BackColor != Color.FromArgb(0, 0xff, 0xff, 0xff))
            {
                currentBtn.Appearance.BackColor = Color.FromArgb(0, 0xff, 0xff, 0xff);
            }
            SimpleButton btn = sender as SimpleButton;
            if (btn.Appearance.BackColor != Color.FromArgb(0x70, 0xB6, 0xEF))
            {
                btn.Appearance.BackColor = Color.FromArgb(0x70, 0xB6, 0xEF);
            }
            currentBtn = btn;
            dateEdit1.Properties.EditMask = form;
            dateEdit1.Properties.Mask.UseMaskAsDisplayFormat = true;
            txt_show.Text = dateEdit1.Text;
        }
    }
}
