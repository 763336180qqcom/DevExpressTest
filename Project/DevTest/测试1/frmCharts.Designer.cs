﻿namespace DevTest.测试1
{
    partial class frmCharts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraCharts.ChartControl lineChart;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraCharts.ChartControl BarChart;
        private DevExpress.XtraCharts.ChartControl PieChart;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lineChart = new DevExpress.XtraCharts.ChartControl();
            this.BarChart = new DevExpress.XtraCharts.ChartControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.PieChart = new DevExpress.XtraCharts.ChartControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.colDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHum = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colWindDir = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colWinSpd = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTmpMax = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTmpMin = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandTmp = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.splitContainerControl3.Appearance.Options.UseBackColor = true;
            this.splitContainerControl3.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Horizontal = false;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.Controls.Add(this.splitContainerControl1);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            this.splitContainerControl3.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(1137, 673);
            this.splitContainerControl3.SplitterPosition = 373;
            this.splitContainerControl3.TabIndex = 3;
            this.splitContainerControl3.Text = "splitContainerControl3";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.splitContainerControl1.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.lineChart);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.BarChart);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1137, 373);
            this.splitContainerControl1.SplitterPosition = 733;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // lineChart
            // 
            this.lineChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineChart.Location = new System.Drawing.Point(0, 0);
            this.lineChart.Name = "lineChart";
            this.lineChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.lineChart.Size = new System.Drawing.Size(733, 373);
            this.lineChart.TabIndex = 0;
            // 
            // BarChart
            // 
            this.BarChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarChart.Location = new System.Drawing.Point(0, 0);
            this.BarChart.Name = "BarChart";
            this.BarChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.BarChart.Size = new System.Drawing.Size(399, 373);
            this.BarChart.TabIndex = 0;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.splitContainerControl2.Appearance.Options.UseBackColor = true;
            this.splitContainerControl2.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.PieChart);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1137, 295);
            this.splitContainerControl2.SplitterPosition = 484;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // PieChart
            // 
            this.PieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PieChart.Location = new System.Drawing.Point(0, 0);
            this.PieChart.Name = "PieChart";
            this.PieChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.PieChart.Size = new System.Drawing.Size(484, 295);
            this.PieChart.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(648, 295);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Appearance.Row.Options.UseTextOptions = true;
            this.advBandedGridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.bandTmp});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colDate,
            this.colTmpMax,
            this.colTmpMin,
            this.colHum,
            this.colWindDir,
            this.colWinSpd,
            this.colCount});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.Editable = false;
            this.advBandedGridView1.OptionsCustomization.AllowSort = false;
            this.advBandedGridView1.OptionsView.ColumnAutoWidth = true;
            this.advBandedGridView1.OptionsView.ShowGroupPanel = false;
            this.advBandedGridView1.OptionsView.ShowIndicator = false;
            // 
            // colDate
            // 
            this.colDate.Caption = "日期";
            this.colDate.FieldName = "日期";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            // 
            // colHum
            // 
            this.colHum.Caption = "相对湿度(%)";
            this.colHum.FieldName = "相对湿度(%)";
            this.colHum.Name = "colHum";
            this.colHum.Visible = true;
            // 
            // colWindDir
            // 
            this.colWindDir.Caption = "风向";
            this.colWindDir.FieldName = "风向";
            this.colWindDir.Name = "colWindDir";
            this.colWindDir.Visible = true;
            // 
            // colWinSpd
            // 
            this.colWinSpd.Caption = "风速(km/h)";
            this.colWinSpd.FieldName = "风速(km/h)";
            this.colWinSpd.Name = "colWinSpd";
            this.colWinSpd.Visible = true;
            // 
            // colTmpMax
            // 
            this.colTmpMax.Caption = "最高";
            this.colTmpMax.FieldName = "最高温度℃";
            this.colTmpMax.Name = "colTmpMax";
            this.colTmpMax.Visible = true;
            // 
            // colTmpMin
            // 
            this.colTmpMin.Caption = "最低";
            this.colTmpMin.FieldName = "最低温度℃";
            this.colTmpMin.Name = "colTmpMin";
            this.colTmpMin.Visible = true;
            // 
            // colCount
            // 
            this.colCount.Caption = "温差";
            this.colCount.FieldName = "温差";
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            // 
            // gridBand1
            // 
            this.gridBand1.AutoFillDown = false;
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colDate);
            this.gridBand1.Columns.Add(this.colHum);
            this.gridBand1.Columns.Add(this.colWindDir);
            this.gridBand1.Columns.Add(this.colWinSpd);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.OptionsBand.AllowMove = false;
            this.gridBand1.OptionsBand.ShowCaption = false;
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 300;
            // 
            // bandTmp
            // 
            this.bandTmp.AutoFillDown = false;
            this.bandTmp.Caption = "温度℃";
            this.bandTmp.Columns.Add(this.colTmpMax);
            this.bandTmp.Columns.Add(this.colTmpMin);
            this.bandTmp.Columns.Add(this.colCount);
            this.bandTmp.Name = "bandTmp";
            this.bandTmp.OptionsBand.AllowMove = false;
            this.bandTmp.VisibleIndex = 1;
            this.bandTmp.Width = 225;
            // 
            // frmCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 673);
            this.Controls.Add(this.splitContainerControl3);
            this.Name = "frmCharts";
            this.Text = "图表";
            this.Shown += new System.EventHandler(this.frmCharts_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHum;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colWindDir;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colWinSpd;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTmpMax;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTmpMin;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCount;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandTmp;
    }
}