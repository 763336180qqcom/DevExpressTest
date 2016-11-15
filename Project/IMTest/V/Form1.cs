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
            dt.Rows.Add(1001, DBNull.Value, "等待开始");
            dt.Rows.Add(10011, 1001, "等待应答");
            dt.Rows.Add(1002, DBNull.Value, "用户(在线)");
            dt.Rows.Add(10021, 1002, "对话中");
            dt.Rows.Add(10022, 1002, "转接中");
            dt.Rows.Add(10023, 1002, "邀请中");
            dt.Rows.Add(10024, 1002, "内部对话");
            dt.Rows.Add(1003, DBNull.Value, "在线访客");
            dt.Rows.Add(10031, 1003, "访问中");
            dt.Rows.Add(10032, 1003, "已离开");
            dt.Rows.Add(100321, 10032, "客人001");
            dt.Rows.Add(100322, 10032, "客人002");
            dt.Rows.Add(100323, 10032, "客人003");
            dt.Rows.Add(100324, 10032, "客人004");
            dt.Rows.Add(100325, 10032, "客人005");
            treeLeftTop.Nodes.Clear();
            treeLeftTop.DataSource = dt;
            treeLeftTop.KeyFieldName = "ID";
            treeLeftTop.ParentFieldName = "PID";
            treeLeftTop.Columns["NodeName"].Caption = "对话列表";
            treeLeftTop.Nodes[0].Expanded = true;
        }
    }
}
