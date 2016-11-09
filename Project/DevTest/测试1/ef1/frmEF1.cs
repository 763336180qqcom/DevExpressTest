using DevExpress.XtraEditors;
using DevTest.Common;
using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DevTest.测试1.ef1
{
    public partial class frmEF1 : XtraFormC
    {
        private delegate void dlgIniCt();
        private StringBuilder str;
        public frmEF1()
        {
            InitializeComponent();
        }

        private void frmEF1_Load(object sender, EventArgs e)
        {
            memoEdit2.Text = "SELECT 类别, 业务ID,COUNT(业务ID)" +
                "次数,SUM(金额) 消费 FROM dbo.v费用收入 GROUP BY 业务ID, 类别  ORDER BY 业务ID DESC";
            gridControl1.DataSource = DB.getDt("v费用收入", null);
            string hostName = Dns.GetHostName();
            IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
            string ip = null;
            for (int i = 0; i < hostEntry.AddressList.Length; i++)
            {
                if (hostEntry.AddressList[i].AddressFamily.ToString() == "InterNetwork")
                {
                    ip = hostEntry.AddressList[i].MapToIPv4().ToString();
                    break;
                }
            }

        }
        private void iniCt()
        {
            if (str != null)
                memoEdit1.Text = str.ToString();
            DataTable dt = DB.getDt("v费用收入", null);
            dt.DefaultView.Sort = "业务ID desc";
            gridControl1.DataSource = dt;

        }
        private void BTN_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(operate));
            thread.Start(sender);
        }

        private void operate(object obj)
        {
            try
            {
                SimpleButton btn = obj as SimpleButton;
                switch (btn.Text)
                {
                    case "查询":
                        findFY();
                        break;
                    case "添加":
                        addEF1();
                        break;
                    case "删除":
                        deleteEF1();
                        break;
                    case "更新":
                        updateEF1JE();
                        break;
                }
                dlgIniCt d = new dlgIniCt(iniCt); ;
                memoEdit2.Invoke(d);
            }
            catch (Exception e)
            {
                iniSkin();
                XtraMessageBox.Show(e.Message);
            }
        }
        private void iniSkin()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Coffee";
        }
        private void findFY()
        {
            using (var DBContext = new DevTest.测试1.ef1.EF1ModelContext())
            {
                str = new StringBuilder();


                var fys = DBContext.v费用收入.GroupBy(g => new { g.业务ID, g.类别 })
                    .Select(s => new { s.Key.类别, s.Key.业务ID, 次数 = s.Count(c => c.业务ID > 0), 消费 = s.Sum(su => su.金额) })
                    .OrderByDescending(o => o.业务ID);
                //var fys = from fy in DBContext.v费用收入
                //          group fy by new { fy.类别, fy.业务ID } into b
                //          select new { b.Key.类别, b.Key.业务ID, 次数 = b.Count(a => a.业务ID > 0), 消费 = b.Sum(a => a.金额) }
                //          into c
                //          orderby c.业务ID descending
                //          select c;
                //  select new { c.业务ID, c.次数, c.消费, c.类别 };
                foreach (var j in fys)
                {
                    str.Append("\t");
                    str.Append(j.类别 + "\t");
                    str.Append(j.业务ID + "\t");
                    str.Append(j.次数 + "\t");
                    str.Append(j.消费 + "\t");
                    str.Append(Environment.NewLine);
                }
                if (!string.IsNullOrEmpty(str.ToString()))
                    DBContext.SaveChanges();
                else
                    throw new CustomException("没有找到");
            }

        }
        private void addEF1()
        {
            using (var DBContext = new DevTest.测试1.ef1.EF1ModelContext())
            {
                var fy = new t费用收入()
                {
                    fPID = 1,
                    type = 1,
                    名称 = "aEF1",
                    金额 = 2,
                    期数 = 2,
                    状态 = 1
                };
                var hy = new t合约业务() { 允许老号 = 1, 名称 = "aEF" };
                foreach (var i in DBContext.v合约业务)
                {
                    if (i.名称.Equals(hy.名称))
                    {
                        throw new CustomException("重复名称");
                    }
                }
                hy.店员价 = 100;
                hy.开始时间 = DateTime.Now;
                hy.捆绑终端 = 1;
                hy.最低价 = 50;
                hy.毛利奖励 = 10;
                hy.状态 = 1;
                hy.现金奖励 = 20;
                hy.结束时间 = hy.开始时间.AddDays(10);
                hy.运营商ID = 110;
                hy.t费用收入.Add(fy);
                DBContext.t合约业务.Add(hy);
                DBContext.SaveChanges();
            }
        }
        private void deleteEF1()
        {
            using (var DBContext = new DevTest.测试1.ef1.EF1ModelContext())
            {
                bool f = false;
                foreach (var i in DBContext.t合约业务)
                {
                    if (i.名称 == "aEF")
                    {
                        f = true;
                        DBContext.t合约业务.Remove(i);
                    }
                }
                if (f)
                    DBContext.SaveChanges();
                else
                    throw new CustomException("记录不存在");
            }
        }
        private void updateEF1JE()
        {
            using (var DBContext = new DevTest.测试1.ef1.EF1ModelContext())
            {
                var hys = DBContext.t合约业务.Where(w => w.名称 == "aEF");
                {
                    bool f = false;
                    foreach (var i in hys)
                    {
                        f = true;
                        i.店员价 = 99;
                        foreach (var j in i.t费用收入)
                        {
                            j.金额 = 99;
                        }
                        break;
                    }
                    if (f)
                        DBContext.SaveChanges();
                    else
                        throw new CustomException("记录不存在");
                }
            }
        }
    }
}
