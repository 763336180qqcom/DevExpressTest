using DevExpress.XtraEditors;
using DevTest.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTest.测试2
{
    public partial class frmEF1 : XtraFormC
    {
        private delegate void dlgIniCt();
        private StringBuilder b;
        public frmEF1()
        {
            InitializeComponent();
        }
        private void iniCt()
        {
            memoEdit1.Text = b.ToString();
        }
        private void frmEF1_Load(object sender, EventArgs e)
        {

        }
        private void findEF1Name()
        {
            using (var context = new EF1ModelContext())
            {
                b= new StringBuilder();
                var hys = context.v合约业务;
                foreach (var i in hys)
                {
                    b.Append(i.fID);
                    b.Append(Environment.NewLine);
                    b.Append(i.名称);
                    b.Append(Environment.NewLine);
                }
                var fys = context.v费用收入;
                foreach (var j in fys)
                {
                    b.Append(j.业务ID);
                    b.Append(Environment.NewLine);
                }
            }
            dlgIniCt d = new dlgIniCt(iniCt);
            memoEdit1.Invoke(d);
        }
        private void addEF1()
        {
            using (var context = new EF1ModelContext())
            {
                var hy = new t合约业务();
                hy.允许老号 = 1;
                hy.名称 = "ef1";
                hy.店员价 = 100;
                hy.开始时间 = DateTime.Now;
                hy.捆绑终端 = 1;
                hy.最低价 = 50;
                hy.毛利奖励 = 10;
                hy.状态 = 1;
                hy.现金奖励 = 20;
                hy.结束时间 = hy.开始时间.AddDays(10);
                hy.运营商ID = 110;
                var fy = new t费用收入()
                {
                    fPID = 1,
                    type = 1,
                    名称 = "ef11",
                    金额 = 2,
                    期数 = 2,
                    状态 = 1
                };
                hy.t费用收入.Add(fy);
                context.t合约业务.Add(hy);
                context.SaveChanges();
            }
        }
        private void deleteEF1()
        {
        }
        private void updateEF1()
        {
        }
        private void operate(object obj)
        {
            SimpleButton btn = obj as SimpleButton;
            switch (btn.Text)
            {
                case "查询":
                    findEF1Name();
                    break;
                case "添加":
                    addEF1();
                    break;
                case "删除":
                    deleteEF1();
                    break;
                case "更新":
                    updateEF1();
                    break;
            }
        }
        private void start(object sender)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(operate));
            thread.Start(sender);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            start(sender);
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            start(sender);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            start(sender);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            start(sender);
        }
    }
}
