using DevExpress.XtraEditors;
using System;

namespace DevTest
{
    partial class frm主界面:XtraForm
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
            this.navBarItem_Hyyw = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.myNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.MaincontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pc_Left = new DevExpress.XtraEditors.PanelControl();
            this.tab_Main = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.gc_Left.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("固定", null)});
            this.gc_Left.Location = new System.Drawing.Point(0, 0);
            this.gc_Left.Name = "gc_Left";
            this.gc_Left.Size = new System.Drawing.Size(198, 682);
            this.gc_Left.TabIndex = 0;
            this.gc_Left.Text = "菜单";
            this.gc_Left.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcLeft_CustomButtonClick);
            this.gc_Left.MouseEnter += new System.EventHandler(this.gc_Left_MouseEnter);
            this.gc_Left.MouseLeave += new System.EventHandler(this.gc_Left_MouseLeave);
            // 
            // nbc_Left
            // 
            this.nbc_Left.ActiveGroup = this.nbg_First;
            this.nbc_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nbc_Left.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbg_First});
            this.nbc_Left.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem_Hyyw,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem1,
            this.navBarItem4});
            this.nbc_Left.Location = new System.Drawing.Point(2, 2);
            this.nbc_Left.Name = "nbc_Left";
            this.nbc_Left.OptionsNavPane.ExpandedWidth = 169;
            this.nbc_Left.Size = new System.Drawing.Size(169, 678);
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
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_Hyyw),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
            this.nbg_First.Name = "nbg_First";
            this.nbg_First.ShowIcons = DevExpress.Utils.DefaultBoolean.True;
            this.nbg_First.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbg_First.SmallImage")));
            // 
            // navBarItem_Hyyw
            // 
            this.navBarItem_Hyyw.Appearance.Options.UseTextOptions = true;
            this.navBarItem_Hyyw.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarItem_Hyyw.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.navBarItem_Hyyw.CanDrag = false;
            this.navBarItem_Hyyw.Caption = "合约业务";
            this.navBarItem_Hyyw.Name = "navBarItem_Hyyw";
            this.navBarItem_Hyyw.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem_Hyyw.SmallImage")));
            this.navBarItem_Hyyw.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // navBarItem2
            // 
            this.navBarItem2.CanDrag = false;
            this.navBarItem2.Caption = "新增合约";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.SmallImage")));
            this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked);
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "DateEdit";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.SmallImage")));
            this.navBarItem3.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "XtraReports";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.SmallImage")));
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked_1);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "SourceGrid";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.SmallImage")));
            this.navBarItem4.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem4_LinkClicked);
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
            tab_Main.SelectedPageChanged += new EventHandler(midPageEvent);

            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer_getWindowText_Tick);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private DevExpress.XtraNavBar.NavBarItem navBarItem_Hyyw;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private System.Windows.Forms.NotifyIcon myNotify;
        private System.Windows.Forms.ContextMenuStrip MaincontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Show;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Exit;
        private PanelControl pc_Left;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager tab_Main;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private System.Windows.Forms.Timer timer1;
    }
}