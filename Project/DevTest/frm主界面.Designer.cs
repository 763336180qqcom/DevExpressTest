using DevExpress.XtraEditors;
using DevTest.Common;
using System;

namespace DevTest
{
    partial class frm主界面:XtraFormP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm主界面));
            this.gc_Left = new DevExpress.XtraEditors.GroupControl();
            this.nbc_Left = new DevExpress.XtraNavBar.NavBarControl();
            this.nbg_First = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBar合约业务 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBar新增合约 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarDateEdit = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarReports = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSGRID = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarWeather = new DevExpress.XtraNavBar.NavBarItem();
            this.myNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.MaincontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pc_Left = new DevExpress.XtraEditors.PanelControl();
            this.tab_Main = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.navBar截屏 = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Left)).BeginInit();
            this.gc_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbc_Left)).BeginInit();
            this.MaincontextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_Main)).BeginInit();
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
            this.gc_Left.Name = "gc_Left";
            this.gc_Left.Size = new System.Drawing.Size(198, 682);
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
            this.navBar截屏});
            this.nbc_Left.Location = new System.Drawing.Point(2, 2);
            this.nbc_Left.Name = "nbc_Left";
            this.nbc_Left.OptionsNavPane.ExpandedWidth = 173;
            this.nbc_Left.Size = new System.Drawing.Size(173, 678);
            this.nbc_Left.TabIndex = 1;
            this.nbc_Left.Text = "navBarControl2";
            // 
            // nbg_First
            // 
            this.nbg_First.Appearance.Options.UseTextOptions = true;
            this.nbg_First.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nbg_First.Caption = "测试";
            this.nbg_First.Expanded = true;
            this.nbg_First.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBar合约业务),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBar新增合约),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDateEdit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarReports),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSGRID),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarWeather),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBar截屏)});
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
            this.pc_Left.Size = new System.Drawing.Size(196, 681);
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
            // navBar截屏
            // 
            this.navBar截屏.Caption = "截屏";
            this.navBar截屏.Name = "navBar截屏";
            this.navBar截屏.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBar截屏.SmallImage")));
            this.navBar截屏.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBar截屏_LinkClicked);
            // 
            // frm主界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 681);
            this.Controls.Add(this.gc_Left);
            this.Controls.Add(this.pc_Left);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frm主界面";
            this.Text = "主界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm主界面_FormClosing);
            this.Load += new System.EventHandler(this.frm主界面_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Left)).EndInit();
            this.gc_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbc_Left)).EndInit();
            this.MaincontextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pc_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_Main)).EndInit();
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
    }
}