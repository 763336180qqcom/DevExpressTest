using DevExpress.XtraEditors;

namespace DevTest
{
    public partial class frmSG :XtraForm
    {
        public frmSG()
        {
            InitializeComponent();
        }

        private void frmSG_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            if (frm主界面.childs.Contains(Name))
                frm主界面.childs.Remove(Name);
        }
    }
}
