using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevTest
{
    public partial class frmXRP : DevExpress.XtraReports.UI.XtraReport
    {
        public frmXRP()
        {
            InitializeComponent();
        }

        private void frmXRP_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lbl日期.Text = "  日期："+DateTime.Now.ToString();
            lbl医师签名.Text = "  医师签名：签名";
            lbl病历日期.Text = "病历日期:" + DateTime.Now.ToString();
            List<ConditionItem> cl = new List<ConditionItem>();
            ConditionItem ci = new ConditionItem();
            ci.Name = "名称";
            ci.Value = "a";
            ci.Type = "=";
            cl.Add(ci);
            DataTable dt = null;
            try
            {
              dt  = DB.getDt("v合约业务", cl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            gp模块名称.DataBindings.Add("Text", dt, "名称");
            this.DataSource = dt;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            object dataSource = this.DataSource;
            List<ConditionItem> cl = new List<ConditionItem>();
            ConditionItem ci = new ConditionItem();
            ci.Name = "业务ID";
            ci.Value = GetCurrentColumnValue("fID").ToString();
            ci.Type = "=";
            cl.Add(ci);
            DataTable dt = DB.getDt("v费用收入", cl);
            DetailReport.DataSource = dt;
        }

        private void Detail1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lbldt描述.Text = DetailReport.GetCurrentColumnValue("项目名称").ToString();
            xrLabel1.Text = DetailReport.GetCurrentColumnValue("金额").ToString();
            xrLabel2.Text = DetailReport.GetCurrentColumnValue("期数").ToString();
        }

        private void xrTable1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.xrTableCell1.DataBindings.Add("Text",DetailReport.DataSource, "业务ID");
            this.xrTableCell2.DataBindings.Add("Text", DetailReport.DataSource, "类别");
            this.xrTableCell3.DataBindings.Add("Text", DetailReport.DataSource, "期数");
        }
    }
}
