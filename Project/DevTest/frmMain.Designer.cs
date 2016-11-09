using DevExpress.XtraEditors;
using DevTest.Common;
using System;

namespace DevTest
{
    partial class frmMain:XtraFormP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gc_Left = new DevExpress.XtraEditors.GroupControl();
            this.nbc_Left = new DevExpress.XtraNavBar.NavBarControl();
            this.nbg_First = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBar合约业务 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBar新增合约 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarDateEdit = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarReports = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSGRID = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarWeather = new DevExpress.XtraNavBar.NavBarItem();
            this.navBar截屏 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarVCode = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarEF = new DevExpress.XtraNavBar.NavBarItem();
            this.myNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.MaincontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pc_Left = new DevExpress.XtraEditors.PanelControl();
            this.tab_Main = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.cmbUI = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.navBarChart = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Left)).BeginInit();
            this.gc_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbc_Left)).BeginInit();
            this.MaincontextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUI)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_Left
            // 
            this.gc_Left.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gc_Left.AppearanceCaption.Options.UseTextOptions = true;
            this.gc_Left.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_Left.CaptionLocation = DevExpress.Utils.Locations.Right;
            this.gc_Left.Controls.Add(this.nbc_Left);
            this.gc_Left.Location = new System.Drawing.Point(0, 0);
            this.gc_Left.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.gc_Left.Name = "gc_Left";
            this.gc_Left.Size = new System.Drawing.Size(198, 653);
            this.gc_Left.TabIndex = 0;
            this.gc_Left.Text = "菜单";
            this.gc_Left.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcLeft_CustomButtonClick);
            // 
            // nbc_Left
            // 
            this.nbc_Left.ActiveGroup = this.nbg_First;
            this.nbc_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nbc_Left.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbg_First});
            this.nbc_Left.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBar合约业务,
            this.navBar新增合约,
            this.navBarDateEdit,
            this.navBarReports,
            this.navBarSGRID,
            this.navBarWeather,
            this.navBar截屏,
            this.navBarVCode,
            this.navBarEF,
            this.navBarChart});
            this.nbc_Left.Location = new System.Drawing.Point(2, 2);
            this.nbc_Left.Name = "nbc_Left";
            this.nbc_Left.OptionsNavPane.ExpandedWidth = 175;
            this.nbc_Left.Size = new System.Drawing.Size(175, 649);
            this.nbc_Left.TabIndex = 1;
            this.nbc_Left.Text = "navBarControl2";
            // 
            // nbg_First
            // 
            this.nbg_First.Appearance.Options.UseTextOptions = true;
            this.nbg_First.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nbg_First.Caption = "测试1";
            this.nbg_First.Expanded = true;
            this.nbg_First.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBar合约业务),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBar新增合约),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDateEdit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarReports),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSGRID),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarWeather),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBar截屏),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarVCode),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarEF),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarChart)});
            this.nbg_First.Name = "nbg_First";
            this.nbg_First.ShowIcons = DevExpress.Utils.DefaultBoolean.True;
            this.nbg_First.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbg_First.SmallImage")));
            // 
            // navBar合约业务
            // 
            this.navBar合约业务.Appearance.Options.UseTextOptions = true;
            this.navBar合约业务.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBar合约业务.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.navBar合约业务.CanDrag = false;
            this.navBar合约业务.Caption = "合约业务";
            this.navBar合约业务.Name = "navBar合约业务";
            this.navBar合约业务.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBar合约业务.SmallImage")));
            this.navBar合约业务.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBar合约业务_LinkClicked);
            // 
            // navBar新增合约
            // 
            this.navBar新增合约.CanDrag = false;
            this.navBar新增合约.Caption = "新增合约";
            this.navBar新增合约.Name = "navBar新增合约";
            this.navBar新增合约.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBar新增合约.SmallImage")));
            this.navBar新增合约.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBar新增合约_LinkClicked);
            // 
            // navBarDateEdit
            // 
            this.navBarDateEdit.Caption = "DateEdit";
            this.navBarDateEdit.Name = "navBarDateEdit";
            this.navBarDateEdit.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarDateEdit.SmallImage")));
            this.navBarDateEdit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarDateEdit_LinkClicked);
            // 
            // navBarReports
            // 
            this.navBarReports.Caption = "XtraReports";
            this.navBarReports.Name = "navBarReports";
            this.navBarReports.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarReports.SmallImage")));
            this.navBarReports.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarReports_LinkClicked);
            // 
            // navBarSGRID
            // 
            this.navBarSGRID.Caption = "SourceGrid";
            this.navBarSGRID.Name = "navBarSGRID";
            this.navBarSGRID.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarSGRID.SmallImage")));
            this.navBarSGRID.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarSGRID_LinkClicked);
            // 
            // navBarWeather
            // 
            this.navBarWeather.Caption = "天气";
            this.navBarWeather.Name = "navBarWeather";
            this.navBarWeather.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarWeather.SmallImage")));
            this.navBarWeather.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarWeather_LinkClicked);
            // 
            // navBar截屏
            // 
            this.navBar截屏.Caption = "截屏";
            this.navBar截屏.Name = "navBar截屏";
            this.navBar截屏.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBar截屏.SmallImage")));
            this.navBar截屏.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBar截屏_LinkClicked);
            // 
            // navBarVCode
            // 
            this.navBarVCode.Caption = "验证码";
            this.navBarVCode.Name = "navBarVCode";
            this.navBarVCode.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarVCode.SmallImage")));
            this.navBarVCode.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarVCode_LinkClicked);
            // 
            // navBarEF
            // 
            this.navBarEF.Caption = "EF6";
            this.navBarEF.Name = "navBarEF";
            this.navBarEF.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarEF.SmallImage")));
            this.navBarEF.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarEF_LinkClicked);
            // 
            // myNotify
            // 
            this.myNotify.ContextMenuStrip = this.MaincontextMenuStrip;
            this.myNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("myNotify.Icon")));
            this.myNotify.Text = "合约业务";
            this.myNotify.DoubleClick += new System.EventHandler(this.myNotify_DoubleClick);
            // 
            // MaincontextMenuStrip
            // 
            this.MaincontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Show,
            this.toolStripMenuItem_Exit});
            this.MaincontextMenuStrip.Name = "MaincontextMenuStrip";
            this.MaincontextMenuStrip.Size = new System.Drawing.Size(101, 48);
            // 
            // toolStripMenuItem_Show
            // 
            this.toolStripMenuItem_Show.Name = "toolStripMenuItem_Show";
            this.toolStripMenuItem_Show.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem_Show.Text = "显示";
            this.toolStripMenuItem_Show.Click += new System.EventHandler(this.toolStripMenuItem_Show_Click);
            // 
            // toolStripMenuItem_Exit
            // 
            this.toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
            this.toolStripMenuItem_Exit.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem_Exit.Text = "退出";
            this.toolStripMenuItem_Exit.Click += new System.EventHandler(this.toolStripMenuItem_Exit_Click);
            // 
            // pc_Left
            // 
            this.pc_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pc_Left.Location = new System.Drawing.Point(0, 0);
            this.pc_Left.Name = "pc_Left";
            this.pc_Left.Size = new System.Drawing.Size(196, 653);
            this.pc_Left.TabIndex = 2;
            // 
            // tab_Main
            // 
            this.tab_Main.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.tab_Main.FloatOnDrag = DevExpress.Utils.DefaultBoolean.True;
            this.tab_Main.FloatPageDragMode = DevExpress.XtraTabbedMdi.FloatPageDragMode.Preview;
            this.tab_Main.MdiParent = this;
            this.tab_Main.SelectedPageChanged += new System.EventHandler(this.midPageChangedEventHandler);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer_getWindowText_Tick);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barEditItem1});
            this.barManager1.MaxItemId = 3;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbUI});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem1)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DisableClose = true;
            this.bar3.OptionsBar.DisableCustomization = true;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "界面风格：";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditItem1
            // 
            this.barEditItem1.Edit = this.cmbUI;
            this.barEditItem1.Id = 2;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Width = 150;
            // 
            // cmbUI
            // 
            this.cmbUI.AutoHeight = false;
            this.cmbUI.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUI.Name = "cmbUI";
            this.cmbUI.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbUI.SelectedValueChanged += new System.EventHandler(this.cmbUI_SelectedValueChanged);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1068, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 653);
            this.barDockControlBottom.Size = new System.Drawing.Size(1068, 28);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 653);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1068, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 653);
            // 
            // navBarChart
            // 
            this.navBarChart.Caption = "图表";
            this.navBarChart.Name = "navBarItem1";
            this.navBarChart.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.SmallImage")));
            this.navBarChart.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarChart_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 681);
            this.Controls.Add(this.gc_Left);
            this.Controls.Add(this.pc_Left);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "主界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm主界面_FormClosing);
            this.Load += new System.EventHandler(this.frm主界面_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Left)).EndInit();
            this.gc_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbc_Left)).EndInit();
            this.MaincontextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pc_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gc_Left;
        private DevExpress.XtraNavBar.NavBarControl nbc_Left;
        private DevExpress.XtraNavBar.NavBarGroup nbg_First;
        private DevExpress.XtraNavBar.NavBarItem navBar合约业务;
        private DevExpress.XtraNavBar.NavBarItem navBar新增合约;
        private DevExpress.XtraNavBar.NavBarItem navBarDateEdit;
        private System.Windows.Forms.NotifyIcon myNotify;
        private System.Windows.Forms.ContextMenuStrip MaincontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Show;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Exit;
        private PanelControl pc_Left;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager tab_Main;
        private DevExpress.XtraNavBar.NavBarItem navBarReports;
        private DevExpress.XtraNavBar.NavBarItem navBarSGRID;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraNavBar.NavBarItem navBarWeather;
        private DevExpress.XtraNavBar.NavBarItem navBar截屏;
        private DevExpress.XtraNavBar.NavBarItem navBarVCode;
        private DevExpress.XtraNavBar.NavBarItem navBarEF;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmbUI;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraNavBar.NavBarItem navBarChart;
    }
}