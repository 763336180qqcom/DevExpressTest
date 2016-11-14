using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace IMTest.V
{
    public partial class Form1 : XtraForm
    {
        public static DevExpress.LookAndFeel.DefaultLookAndFeel IMdefaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Seven Classic";
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("PID", typeof(int));
            dt.Columns.Add("NodeName", typeof(string));
            dt.Rows.Add(0, DBNull.Value, "A");
            dt.Rows.Add(1, 0, "A1");
            dt.Rows.Add(2, 0, "A2");
            dt.Rows.Add(3, DBNull.Value, "B");
            dt.Rows.Add(4, 3, "B1");
            dt.Rows.Add(5, 3, "B2");
            dt.Rows.Add(6, 3, "B3");
            dt.Rows.Add(7, DBNull.Value, "C");
            dt.Rows.Add(8, 7, "C1");
            dt.Rows.Add(9, 7, "C11");
            dt.Rows.Add(10, 9, "C111");
            treeLeftTop.Nodes.Clear();
            treeLeftTop.DataSource = dt;
            treeLeftTop.KeyFieldName = "ID";
            treeLeftTop.ParentFieldName = "PID";
            treeLeftTop.Columns["NodeName"].Caption = "节点名称";
            treeLeftTop.Nodes[0].Expanded = true;
        }
    }
}
