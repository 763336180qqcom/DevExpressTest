namespace DevTest
{
    partial class frm合约业务
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
            this.cb_type = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cb_zt = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gc_Hy = new DevExpress.XtraGrid.GridControl();
            this.gv_Hy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn_fID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_kbzd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_yysId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_yxlh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_dyj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_zdj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_mljl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_xjjl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_kssj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_jssj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.zt_hy_hyyw = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem_Add = new DevExpress.XtraBars.BarButtonItem();
            this.gc_fy = new DevExpress.XtraGrid.GridControl();
            this.gv_Fy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_JinEr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_QiShu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.zt_fy_hyyw = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pgb = new DevExpress.XtraEditors.ProgressBarControl();
            this.ts = new DevExpress.XtraEditors.ToggleSwitch();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitterControl2 = new DevExpress.XtraEditors.SplitterControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cb_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_zt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Hy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Hy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_fy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Fy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_type
            // 
            this.cb_type.AutoHeight = false;
            this.cb_type.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_type.Items.AddRange(new object[] {
            "费用",
            "收入"});
            this.cb_type.Name = "cb_type";
            // 
            // cb_zt
            // 
            this.cb_zt.AutoHeight = false;
            this.cb_zt.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_zt.Items.AddRange(new object[] {
            "有效",
            "无效"});
            this.cb_zt.Name = "cb_zt";
            // 
            // gc_Hy
            // 
            this.gc_Hy.Dock = System.Windows.Forms.DockStyle.Left;
            this.gc_Hy.Location = new System.Drawing.Point(2, 2);
            this.gc_Hy.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gc_Hy.MainView = this.gv_Hy;
            this.gc_Hy.Name = "gc_Hy";
            this.gc_Hy.Size = new System.Drawing.Size(967, 527);
            this.gc_Hy.TabIndex = 0;
            this.gc_Hy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Hy});
            this.gc_Hy.MouseHover += new System.EventHandler(this.gc_Hy_MouseHover);
            // 
            // gv_Hy
            // 
            this.gv_Hy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn_fID,
            this.gridColumn_Name,
            this.gridColumn_kbzd,
            this.gridColumn_yysId,
            this.gridColumn_yxlh,
            this.gridColumn_dyj,
            this.gridColumn_zdj,
            this.gridColumn_mljl,
            this.gridColumn_xjjl,
            this.gridColumn_kssj,
            this.gridColumn_jssj,
            this.zt_hy_hyyw});
            this.gv_Hy.GridControl = this.gc_Hy;
            this.gv_Hy.IndicatorWidth = 30;
            this.gv_Hy.Name = "gv_Hy";
            this.gv_Hy.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv_Hy.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv_Hy.OptionsBehavior.Editable = false;
            this.gv_Hy.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Hy.OptionsView.EnableAppearanceOddRow = true;
            this.gv_Hy.OptionsView.ShowGroupPanel = false;
            this.gv_Hy.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_hy_RowClick);
            this.gv_Hy.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gv_hy_CustomDrawRowIndicator);
            this.gv_Hy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gv_Hy_MouseMove);
            // 
            // gridColumn_fID
            // 
            this.gridColumn_fID.Caption = "编号";
            this.gridColumn_fID.FieldName = "fID";
            this.gridColumn_fID.Name = "gridColumn_fID";
            this.gridColumn_fID.Visible = true;
            this.gridColumn_fID.VisibleIndex = 0;
            this.gridColumn_fID.Width = 58;
            // 
            // gridColumn_Name
            // 
            this.gridColumn_Name.Caption = "名称";
            this.gridColumn_Name.FieldName = "名称";
            this.gridColumn_Name.Name = "gridColumn_Name";
            this.gridColumn_Name.Visible = true;
            this.gridColumn_Name.VisibleIndex = 1;
            this.gridColumn_Name.Width = 58;
            // 
            // gridColumn_kbzd
            // 
            this.gridColumn_kbzd.Caption = "捆绑终端";
            this.gridColumn_kbzd.FieldName = "捆绑终端";
            this.gridColumn_kbzd.Name = "gridColumn_kbzd";
            this.gridColumn_kbzd.Visible = true;
            this.gridColumn_kbzd.VisibleIndex = 3;
            this.gridColumn_kbzd.Width = 58;
            // 
            // gridColumn_yysId
            // 
            this.gridColumn_yysId.Caption = "运营商ID";
            this.gridColumn_yysId.FieldName = "运营商ID";
            this.gridColumn_yysId.Name = "gridColumn_yysId";
            this.gridColumn_yysId.Visible = true;
            this.gridColumn_yysId.VisibleIndex = 2;
            this.gridColumn_yysId.Width = 58;
            // 
            // gridColumn_yxlh
            // 
            this.gridColumn_yxlh.Caption = "允许老号";
            this.gridColumn_yxlh.FieldName = "允许老号";
            this.gridColumn_yxlh.Name = "gridColumn_yxlh";
            this.gridColumn_yxlh.Visible = true;
            this.gridColumn_yxlh.VisibleIndex = 4;
            this.gridColumn_yxlh.Width = 61;
            // 
            // gridColumn_dyj
            // 
            this.gridColumn_dyj.Caption = "店员价";
            this.gridColumn_dyj.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn_dyj.FieldName = "店员价";
            this.gridColumn_dyj.Name = "gridColumn_dyj";
            this.gridColumn_dyj.Visible = true;
            this.gridColumn_dyj.VisibleIndex = 5;
            this.gridColumn_dyj.Width = 61;
            // 
            // gridColumn_zdj
            // 
            this.gridColumn_zdj.Caption = "最低价";
            this.gridColumn_zdj.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn_zdj.FieldName = "最低价";
            this.gridColumn_zdj.Name = "gridColumn_zdj";
            this.gridColumn_zdj.Visible = true;
            this.gridColumn_zdj.VisibleIndex = 6;
            this.gridColumn_zdj.Width = 61;
            // 
            // gridColumn_mljl
            // 
            this.gridColumn_mljl.Caption = "毛利奖励";
            this.gridColumn_mljl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn_mljl.FieldName = "毛利奖励";
            this.gridColumn_mljl.Name = "gridColumn_mljl";
            this.gridColumn_mljl.Visible = true;
            this.gridColumn_mljl.VisibleIndex = 7;
            this.gridColumn_mljl.Width = 61;
            // 
            // gridColumn_xjjl
            // 
            this.gridColumn_xjjl.Caption = "现金奖励";
            this.gridColumn_xjjl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn_xjjl.FieldName = "现金奖励";
            this.gridColumn_xjjl.Name = "gridColumn_xjjl";
            this.gridColumn_xjjl.Visible = true;
            this.gridColumn_xjjl.VisibleIndex = 8;
            this.gridColumn_xjjl.Width = 61;
            // 
            // gridColumn_kssj
            // 
            this.gridColumn_kssj.Caption = "开始时间";
            this.gridColumn_kssj.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gridColumn_kssj.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn_kssj.FieldName = "开始时间";
            this.gridColumn_kssj.Name = "gridColumn_kssj";
            this.gridColumn_kssj.Visible = true;
            this.gridColumn_kssj.VisibleIndex = 9;
            this.gridColumn_kssj.Width = 123;
            // 
            // gridColumn_jssj
            // 
            this.gridColumn_jssj.Caption = "结束时间";
            this.gridColumn_jssj.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gridColumn_jssj.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn_jssj.FieldName = "结束时间";
            this.gridColumn_jssj.Name = "gridColumn_jssj";
            this.gridColumn_jssj.Visible = true;
            this.gridColumn_jssj.VisibleIndex = 10;
            this.gridColumn_jssj.Width = 86;
            // 
            // zt_hy_hyyw
            // 
            this.zt_hy_hyyw.Caption = "状态";
            this.zt_hy_hyyw.FieldName = "状态";
            this.zt_hy_hyyw.Name = "zt_hy_hyyw";
            this.zt_hy_hyyw.Visible = true;
            this.zt_hy_hyyw.VisibleIndex = 11;
            this.zt_hy_hyyw.Width = 70;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem_Add});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1303, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 564);
            this.barDockControlBottom.Size = new System.Drawing.Size(1303, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 564);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1303, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 564);
            // 
            // barButtonItem_Add
            // 
            this.barButtonItem_Add.Id = 1;
            this.barButtonItem_Add.Name = "barButtonItem_Add";
            // 
            // gc_fy
            // 
            this.gc_fy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_fy.Location = new System.Drawing.Point(969, 2);
            this.gc_fy.MainView = this.gv_Fy;
            this.gc_fy.Name = "gc_fy";
            this.gc_fy.Size = new System.Drawing.Size(332, 527);
            this.gc_fy.TabIndex = 23;
            this.gc_fy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Fy});
            // 
            // gv_Fy
            // 
            this.gv_Fy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_Id,
            this.c_Type,
            this.c_Name,
            this.c_JinEr,
            this.c_QiShu,
            this.zt_fy_hyyw});
            this.gv_Fy.GridControl = this.gc_fy;
            this.gv_Fy.IndicatorWidth = 30;
            this.gv_Fy.Name = "gv_Fy";
            this.gv_Fy.OptionsView.ColumnAutoWidth = false;
            this.gv_Fy.OptionsView.ShowGroupPanel = false;
            this.gv_Fy.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gv_hy_CustomDrawRowIndicator);
            // 
            // c_Id
            // 
            this.c_Id.Caption = "编号";
            this.c_Id.FieldName = "业务ID";
            this.c_Id.Name = "c_Id";
            this.c_Id.OptionsColumn.AllowEdit = false;
            // 
            // c_Type
            // 
            this.c_Type.Caption = "类别";
            this.c_Type.FieldName = "类别";
            this.c_Type.Name = "c_Type";
            this.c_Type.OptionsColumn.AllowEdit = false;
            this.c_Type.Visible = true;
            this.c_Type.VisibleIndex = 2;
            // 
            // c_Name
            // 
            this.c_Name.Caption = "项目名称";
            this.c_Name.FieldName = "项目名称";
            this.c_Name.Name = "c_Name";
            this.c_Name.OptionsColumn.AllowEdit = false;
            this.c_Name.Visible = true;
            this.c_Name.VisibleIndex = 0;
            // 
            // c_JinEr
            // 
            this.c_JinEr.Caption = "金额";
            this.c_JinEr.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.c_JinEr.FieldName = "金额";
            this.c_JinEr.Name = "c_JinEr";
            this.c_JinEr.OptionsColumn.AllowEdit = false;
            this.c_JinEr.Visible = true;
            this.c_JinEr.VisibleIndex = 1;
            // 
            // c_QiShu
            // 
            this.c_QiShu.Caption = "期数";
            this.c_QiShu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.c_QiShu.FieldName = "期数";
            this.c_QiShu.Name = "c_QiShu";
            this.c_QiShu.OptionsColumn.AllowEdit = false;
            this.c_QiShu.Visible = true;
            this.c_QiShu.VisibleIndex = 3;
            // 
            // zt_fy_hyyw
            // 
            this.zt_fy_hyyw.Caption = "状态";
            this.zt_fy_hyyw.FieldName = "状态";
            this.zt_fy_hyyw.Name = "zt_fy_hyyw";
            this.zt_fy_hyyw.OptionsColumn.AllowEdit = false;
            this.zt_fy_hyyw.Visible = true;
            this.zt_fy_hyyw.VisibleIndex = 4;
            // 
            // pgb
            // 
            this.pgb.Dock = System.Windows.Forms.DockStyle.Right;
            this.pgb.Location = new System.Drawing.Point(1155, 2);
            this.pgb.MenuManager = this.barManager1;
            this.pgb.Name = "pgb";
            this.pgb.Properties.ShowTitle = true;
            this.pgb.Properties.TextOrientation = DevExpress.Utils.Drawing.TextOrientation.Horizontal;
            this.pgb.Size = new System.Drawing.Size(146, 29);
            this.pgb.TabIndex = 28;
            // 
            // ts
            // 
            this.ts.Dock = System.Windows.Forms.DockStyle.Right;
            this.ts.EditValue = true;
            this.ts.Location = new System.Drawing.Point(969, 2);
            this.ts.MenuManager = this.barManager1;
            this.ts.Name = "ts";
            this.ts.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.ts.Properties.OffText = "任务已被取消";
            this.ts.Properties.OnText = "点击取消任务";
            this.ts.Size = new System.Drawing.Size(186, 27);
            this.ts.TabIndex = 33;
            this.ts.Toggled += new System.EventHandler(this.ts_Toggled);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(72, 153);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Add)});
            this.bar1.Offset = 19;
            this.bar1.Text = "Tools";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.splitterControl2);
            this.groupControl1.Controls.Add(this.gc_fy);
            this.groupControl1.Controls.Add(this.gc_Hy);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 33);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1303, 531);
            this.groupControl1.TabIndex = 43;
            this.groupControl1.Text = "groupControl1";
            // 
            // splitterControl2
            // 
            this.splitterControl2.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.splitterControl2.Appearance.Options.UseBackColor = true;
            this.splitterControl2.Location = new System.Drawing.Point(969, 2);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new System.Drawing.Size(5, 527);
            this.splitterControl2.TabIndex = 24;
            this.splitterControl2.TabStop = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ts);
            this.groupControl2.Controls.Add(this.pgb);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(1303, 33);
            this.groupControl2.TabIndex = 44;
            this.groupControl2.Text = "groupControl2";
            // 
            // toolTipController1
            // 
            this.toolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.Standard;
            // 
            // frm合约业务
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 564);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm合约业务";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "合约业务";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm合约业务_FormClosing);
            this.Load += new System.EventHandler(this.frm合约业务_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cb_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_zt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Hy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Hy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_fy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Fy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Hy;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Hy;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_fID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_Name;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_jssj;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_yysId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_yxlh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_dyj;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_zdj;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_mljl;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_xjjl;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_kssj;
        private DevExpress.XtraGrid.Columns.GridColumn zt_hy_hyyw;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_kbzd;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Add;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gc_fy;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Fy;
        private DevExpress.XtraGrid.Columns.GridColumn c_Type;
        private DevExpress.XtraGrid.Columns.GridColumn c_Name;
        private DevExpress.XtraGrid.Columns.GridColumn c_JinEr;
        private DevExpress.XtraGrid.Columns.GridColumn c_QiShu;
        private DevExpress.XtraGrid.Columns.GridColumn zt_fy_hyyw;
        private DevExpress.XtraEditors.ProgressBarControl pgb;
        private DevExpress.XtraEditors.ToggleSwitch ts;
        private DevExpress.XtraGrid.Columns.GridColumn c_Id;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cb_type;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cb_zt;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}