using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace IMTest.V
{
    public partial class Form1 : XtraForm
    {
        public static DevExpress.LookAndFeel.DefaultLookAndFeel IMdefaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();
        private DataTable mDtTestLeft;
        private DataTable mDtTestMid;
        private DataTable mDtTestRight;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Visual Studio 2013 Light";

            iniTestData1();
            iniTreeLeftTop();
            iniTreeLeftBot();

            iniTestData2();
            iniTreeMid();

            iniTestData3();
            iniTreeRight();

            XtraForm f = new XtraForm() { TopLevel = false };
            f.Dock = DockStyle.Fill;
            f.BackColor = Color.LightGray;
            f.FormBorderStyle = FormBorderStyle.None;
            xtraTabPage1.Controls.Add(f);
            f.Show();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            splitContainerControl1.SplitterPosition = gc1.Height / 2;
        }
        private void iniTestData1()
        {
            mDtTestLeft = new DataTable();
            mDtTestLeft.Columns.Add("ID", typeof(int));
            mDtTestLeft.Columns.Add("PID", typeof(int));
            mDtTestLeft.Columns.Add("NodeName", typeof(string));
            mDtTestLeft.Rows.Add(1001, DBNull.Value, "等待开始");
            mDtTestLeft.Rows.Add(10011, 1001, "等待应答");
            mDtTestLeft.Rows.Add(1002, DBNull.Value, "用户(在线)");
            mDtTestLeft.Rows.Add(10021, 1002, "对话中");
            mDtTestLeft.Rows.Add(10022, 1002, "转接中");
            mDtTestLeft.Rows.Add(10023, 1002, "邀请中");
            mDtTestLeft.Rows.Add(10024, 1002, "内部对话");
            mDtTestLeft.Rows.Add(1003, DBNull.Value, "在线访客");
            mDtTestLeft.Rows.Add(10031, 1003, "访问中");
            mDtTestLeft.Rows.Add(10032, 1003, "已离开");
            mDtTestLeft.Rows.Add(100321, 10032, "客人001");
            mDtTestLeft.Rows.Add(100322, 10032, "客人002");
            mDtTestLeft.Rows.Add(100323, 10032, "客人003");
            mDtTestLeft.Rows.Add(100324, 10032, "客人004");
            mDtTestLeft.Rows.Add(100325, 10032, "客人005");
        }
        private void iniTreeLeftTop()
        {
            treeLeftTop.Height = gc2.Height / 2;
            treeLeftTop.Nodes.Clear();
            treeLeftTop.DataSource = mDtTestLeft;
            treeLeftTop.KeyFieldName = "ID";
            treeLeftTop.ParentFieldName = "PID";
            treeLeftTop.Columns["NodeName"].Caption = "员工对话列表";
            treeLeftTop.Columns[0].OptionsColumn.AllowSort = false;
            treeLeftTop.ExpandAll();

        }
        private void iniTreeLeftBot()
        {
            treeLeftBot.Height = gc2.Height / 2;
            treeLeftBot.Nodes.Clear();
            treeLeftBot.DataSource = mDtTestLeft.Copy();
            treeLeftBot.KeyFieldName = "ID";
            treeLeftBot.ParentFieldName = "PID";
            treeLeftBot.Columns["NodeName"].Caption = "客户对话列表";
            treeLeftBot.Columns[0].OptionsColumn.AllowSort = false;
            treeLeftBot.ExpandAll();
        }
        private void iniTestData2()
        {
            mDtTestMid = mDtTestLeft.Clone();
            mDtTestMid.Rows.Add(1001, DBNull.Value, "介绍自己");
            mDtTestMid.Rows.Add(10011, 1001, "开始问候");
            mDtTestMid.Rows.Add(10012, 1001, "电话详谈");
            mDtTestMid.Rows.Add(10013, 1001, "客户联系电话");
            mDtTestMid.Rows.Add(1002, DBNull.Value, "等待");
            mDtTestMid.Rows.Add(10021, 1002, "等待1");
            mDtTestMid.Rows.Add(10022, 1002, "等待2");
            mDtTestMid.Rows.Add(1003, DBNull.Value, "道别");
            mDtTestMid.Rows.Add(10031, 1003, "道别1");
            mDtTestMid.Rows.Add(10032, 1003, "道别2");
            mDtTestMid.Rows.Add(1004, DBNull.Value, "致歉");
            mDtTestMid.Rows.Add(10041, 1004, "致歉1");
            mDtTestMid.Rows.Add(10042, 1004, "致歉2");
            mDtTestMid.Rows.Add(1005, DBNull.Value, "感谢");
            mDtTestMid.Rows.Add(10051, 1005, "感谢1");
            mDtTestMid.Rows.Add(10052, 1005, "感谢2");
            mDtTestMid.Rows.Add(1006, DBNull.Value, "技术部专用");
            mDtTestMid.Rows.Add(10061, 1006, "开始问候");
            mDtTestMid.Rows.Add(10062, 1006, "中间问候");
            mDtTestMid.Rows.Add(10063, 1006, "合作愉快");
            mDtTestMid.Rows.Add(1007, DBNull.Value, "财务部专用");
            mDtTestMid.Rows.Add(10071, 1007, "汇款帐号");
            mDtTestMid.Rows.Add(10072, 1007, "联系");
            mDtTestMid.Rows.Add(1008, DBNull.Value, "客服1专用");
            mDtTestMid.Rows.Add(10081, 1008, "新项1");

        }
        private void iniTreeMid()
        {
            treeMid.Nodes.Clear();
            treeMid.DataSource = mDtTestMid;
            treeMid.KeyFieldName = "ID";
            treeMid.ParentFieldName = "PID";
            treeMid.Columns["NodeName"].Caption = "快捷回复列表";
            treeMid.Columns[0].OptionsColumn.AllowSort = false;
            treeMid.ExpandAll();
        }
        private void iniTestData3()
        {
            mDtTestRight = mDtTestLeft.Clone();
            mDtTestRight.Rows.Add(1001, DBNull.Value, "分组一");
            mDtTestRight.Rows.Add(10011, 1001, "姓名1");
            mDtTestRight.Rows.Add(1002, DBNull.Value, "分组二");
            mDtTestRight.Rows.Add(10021, 1002, "姓名1");
            mDtTestRight.Rows.Add(10022, 1002, "姓名2");
            mDtTestRight.Rows.Add(10023, 1002, "姓名3");
            mDtTestRight.Rows.Add(10024, 1002, "姓名4");
            mDtTestRight.Rows.Add(1003, DBNull.Value, "分组三");
            mDtTestRight.Rows.Add(10031, 1003, "姓名1");
            mDtTestRight.Rows.Add(10032, 1003, "姓名2");
            mDtTestRight.Rows.Add(10033, 1003, "姓名3");
            mDtTestRight.Rows.Add(10034, 1003, "姓名4");
        }
        private void iniTreeRight()
        {
            treeRight.Nodes.Clear();
            treeRight.DataSource = mDtTestRight;
            treeRight.KeyFieldName = "ID";
            treeRight.ParentFieldName = "PID";
            treeRight.Columns["NodeName"].Caption = "联系人列表";
            treeRight.Columns[0].OptionsColumn.AllowSort = false;
            treeRight.ExpandAll();
        }
        private void treeLeftTop_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            switch (e.Node.Level)
            {
                case 0:
                    e.Appearance.BackColor = Color.FromArgb(100, 189, 220);
                    break;
                case 1:
                    e.Appearance.BackColor = Color.FromArgb(183, 226, 200);
                    break;
                case 2:
                    e.Appearance.BackColor = Color.FromArgb(255, 238, 238, 242);
                    break;
                default:
                    break;
            }
            if (e.Node == (sender as TreeList).FocusedNode && e.Node.Level != 0)
                e.Appearance.BackColor = Color.RoyalBlue;
        }
        private void treeLeftTop_CustomDrawNodeImages(object sender, CustomDrawNodeImagesEventArgs e)
        {
            switch (e.Node.Level)
            {
                case 0:
                    e.SelectImageIndex = 0;
                    break;
                case 1:
                    e.SelectImageIndex = 1;
                    break;
                case 2:
                    e.SelectImageIndex = 2;
                    break;
                default:
                    e.SelectImageIndex = -1;
                    break;
            }
        }

        private void treeRight_DoubleClick(object sender, EventArgs e)
        {
            TreeList tree = sender as TreeList;
            string FormName = string.Format("对话({0})",tree.FocusedNode.GetDisplayText("Name"));
        }
    }
}
