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

namespace DevTest.Common
{
    public partial class XFormChild : XtraForm
    {
        public XFormChild()
        {
            InitializeComponent();
        }

        private void XFormChild_Load(object sender, EventArgs e)
        {

        }

        private void XFormChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Util.childs.Contains(Name))
                Util.childs.Remove(Name);
        }
    }
}
