namespace DevTest.测试1
{
    partial class frmWeather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWeather));
            this.panel0 = new DevExpress.XtraEditors.PanelControl();
            this.lue县区 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lue省 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lue市 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.img3B = new DevExpress.XtraEditors.LabelControl();
            this.img3A = new DevExpress.XtraEditors.LabelControl();
            this.img2B = new DevExpress.XtraEditors.LabelControl();
            this.img2A = new DevExpress.XtraEditors.LabelControl();
            this.img1B = new DevExpress.XtraEditors.LabelControl();
            this.img1A = new DevExpress.XtraEditors.LabelControl();
            this.img0B = new DevExpress.XtraEditors.LabelControl();
            this.img0A = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.me3 = new DevExpress.XtraEditors.MemoEdit();
            this.me2 = new DevExpress.XtraEditors.MemoEdit();
            this.me1 = new DevExpress.XtraEditors.MemoEdit();
            this.me0 = new DevExpress.XtraEditors.MemoEdit();
            this.meMain = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel0)).BeginInit();
            this.panel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lue县区.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue省.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue市.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.me3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.me2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.me1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.me0.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meMain.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel0
            // 
            this.panel0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel0.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel0.Appearance.Options.UseBackColor = true;
            this.panel0.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel0.Controls.Add(this.lue县区);
            this.panel0.Controls.Add(this.lue省);
            this.panel0.Controls.Add(this.lue市);
            this.panel0.Location = new System.Drawing.Point(0, 0);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(1079, 49);
            this.panel0.TabIndex = 9;
            // 
            // lue县区
            // 
            this.lue县区.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lue县区.EditValue = "";
            this.lue县区.Location = new System.Drawing.Point(481, 12);
            this.lue县区.Name = "lue县区";
            this.lue县区.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lue县区.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lue县区.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue县区.Properties.NullText = "";
            this.lue县区.Properties.ShowClearButton = false;
            this.lue县区.Properties.ShowFooter = false;
            this.lue县区.Properties.View = this.searchLookUpEdit1View;
            this.lue县区.Size = new System.Drawing.Size(109, 18);
            this.lue县区.TabIndex = 2;
            this.lue县区.EditValueChanged += new System.EventHandler(this.lue县区_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3});
            this.searchLookUpEdit1View.FixedLineWidth = 1;
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.IndicatorWidth = 35;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = true;
            this.searchLookUpEdit1View.OptionsView.EnableAppearanceOddRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowColumnHeaders = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.searchLookUpEdit1View.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "县区";
            this.gridColumn3.FieldName = "中文";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // lue省
            // 
            this.lue省.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lue省.EditValue = "";
            this.lue省.Location = new System.Drawing.Point(205, 12);
            this.lue省.Name = "lue省";
            this.lue省.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lue省.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lue省.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue省.Properties.NullText = "";
            this.lue省.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.NoBorder;
            this.lue省.Properties.ShowClearButton = false;
            this.lue省.Properties.ShowFooter = false;
            this.lue省.Properties.View = this.gridView1;
            this.lue省.Size = new System.Drawing.Size(109, 18);
            this.lue省.TabIndex = 0;
            this.lue省.EditValueChanged += new System.EventHandler(this.lue省_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.IndicatorWidth = 35;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = false;
            this.gridView1.OptionsFind.AllowFindPanel = false;
            this.gridView1.OptionsFind.ShowClearButton = false;
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "省";
            this.gridColumn1.FieldName = "省中文";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // lue市
            // 
            this.lue市.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lue市.Location = new System.Drawing.Point(343, 12);
            this.lue市.Name = "lue市";
            this.lue市.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lue市.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lue市.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue市.Properties.NullText = "";
            this.lue市.Properties.ShowClearButton = false;
            this.lue市.Properties.ShowFooter = false;
            this.lue市.Properties.View = this.gridView2;
            this.lue市.Size = new System.Drawing.Size(109, 18);
            this.lue市.TabIndex = 1;
            this.lue市.EditValueChanged += new System.EventHandler(this.lue市_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.IndicatorWidth = 35;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowColumnHeaders = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "市";
            this.gridColumn2.FieldName = "所属上级市中文";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Appearance.BackColor = System.Drawing.Color.White;
            this.panel1.Appearance.Options.UseBackColor = true;
            this.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel1.Controls.Add(this.img3B);
            this.panel1.Controls.Add(this.img3A);
            this.panel1.Controls.Add(this.img2B);
            this.panel1.Controls.Add(this.img2A);
            this.panel1.Controls.Add(this.img1B);
            this.panel1.Controls.Add(this.img1A);
            this.panel1.Controls.Add(this.img0B);
            this.panel1.Controls.Add(this.img0A);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.me3);
            this.panel1.Controls.Add(this.me2);
            this.panel1.Controls.Add(this.me1);
            this.panel1.Controls.Add(this.me0);
            this.panel1.Controls.Add(this.meMain);
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 586);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // img3B
            // 
            this.img3B.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img3B.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("img3B.Appearance.Image")));
            this.img3B.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.img3B.Location = new System.Drawing.Point(821, 170);
            this.img3B.Name = "img3B";
            this.img3B.Size = new System.Drawing.Size(79, 53);
            this.img3B.TabIndex = 72;
            // 
            // img3A
            // 
            this.img3A.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img3A.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("img3A.Appearance.Image")));
            this.img3A.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.img3A.Location = new System.Drawing.Point(723, 170);
            this.img3A.Name = "img3A";
            this.img3A.Size = new System.Drawing.Size(79, 53);
            this.img3A.TabIndex = 71;
            // 
            // img2B
            // 
            this.img2B.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img2B.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("img2B.Appearance.Image")));
            this.img2B.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.img2B.Location = new System.Drawing.Point(638, 170);
            this.img2B.Name = "img2B";
            this.img2B.Size = new System.Drawing.Size(79, 53);
            this.img2B.TabIndex = 70;
            // 
            // img2A
            // 
            this.img2A.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img2A.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("img2A.Appearance.Image")));
            this.img2A.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.img2A.Location = new System.Drawing.Point(540, 170);
            this.img2A.Name = "img2A";
            this.img2A.Size = new System.Drawing.Size(79, 53);
            this.img2A.TabIndex = 69;
            // 
            // img1B
            // 
            this.img1B.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img1B.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("img1B.Appearance.Image")));
            this.img1B.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.img1B.Location = new System.Drawing.Point(458, 170);
            this.img1B.Name = "img1B";
            this.img1B.Size = new System.Drawing.Size(79, 53);
            this.img1B.TabIndex = 68;
            // 
            // img1A
            // 
            this.img1A.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img1A.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("img1A.Appearance.Image")));
            this.img1A.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.img1A.Location = new System.Drawing.Point(357, 170);
            this.img1A.Name = "img1A";
            this.img1A.Size = new System.Drawing.Size(79, 53);
            this.img1A.TabIndex = 67;
            // 
            // img0B
            // 
            this.img0B.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img0B.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("img0B.Appearance.Image")));
            this.img0B.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.img0B.Location = new System.Drawing.Point(270, 170);
            this.img0B.Name = "img0B";
            this.img0B.Size = new System.Drawing.Size(79, 53);
            this.img0B.TabIndex = 66;
            // 
            // img0A
            // 
            this.img0A.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img0A.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("img0A.Appearance.Image")));
            this.img0A.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.img0A.Location = new System.Drawing.Point(172, 170);
            this.img0A.Name = "img0A";
            this.img0A.Size = new System.Drawing.Size(79, 53);
            this.img0A.TabIndex = 65;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(798, 184);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 39);
            this.labelControl4.TabIndex = 61;
            this.labelControl4.Text = "~";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(615, 184);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 39);
            this.labelControl3.TabIndex = 58;
            this.labelControl3.Text = "~";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(434, 184);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 39);
            this.labelControl2.TabIndex = 55;
            this.labelControl2.Text = "~";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(246, 184);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 39);
            this.labelControl1.TabIndex = 52;
            this.labelControl1.Text = "~";
            // 
            // me3
            // 
            this.me3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.me3.Enabled = false;
            this.me3.Location = new System.Drawing.Point(723, 229);
            this.me3.Name = "me3";
            this.me3.Properties.AllowFocused = false;
            this.me3.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.me3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.me3.Properties.Appearance.Options.UseBackColor = true;
            this.me3.Properties.Appearance.Options.UseFont = true;
            this.me3.Properties.Appearance.Options.UseTextOptions = true;
            this.me3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.me3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.me3.Properties.ReadOnly = true;
            this.me3.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.me3.ShowToolTips = false;
            this.me3.Size = new System.Drawing.Size(180, 187);
            this.me3.TabIndex = 48;
            this.me3.TabStop = false;
            // 
            // me2
            // 
            this.me2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.me2.Enabled = false;
            this.me2.Location = new System.Drawing.Point(540, 229);
            this.me2.Name = "me2";
            this.me2.Properties.AllowFocused = false;
            this.me2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.me2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.me2.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.me2.Properties.Appearance.Options.UseBackColor = true;
            this.me2.Properties.Appearance.Options.UseFont = true;
            this.me2.Properties.Appearance.Options.UseForeColor = true;
            this.me2.Properties.Appearance.Options.UseTextOptions = true;
            this.me2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.me2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.me2.Properties.ReadOnly = true;
            this.me2.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.me2.ShowToolTips = false;
            this.me2.Size = new System.Drawing.Size(180, 187);
            this.me2.TabIndex = 47;
            this.me2.TabStop = false;
            // 
            // me1
            // 
            this.me1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.me1.Enabled = false;
            this.me1.Location = new System.Drawing.Point(357, 229);
            this.me1.Name = "me1";
            this.me1.Properties.AllowFocused = false;
            this.me1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.me1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.me1.Properties.Appearance.Options.UseBackColor = true;
            this.me1.Properties.Appearance.Options.UseFont = true;
            this.me1.Properties.Appearance.Options.UseTextOptions = true;
            this.me1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.me1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.me1.Properties.ReadOnly = true;
            this.me1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.me1.ShowToolTips = false;
            this.me1.Size = new System.Drawing.Size(180, 187);
            this.me1.TabIndex = 46;
            this.me1.TabStop = false;
            // 
            // me0
            // 
            this.me0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.me0.Enabled = false;
            this.me0.Location = new System.Drawing.Point(172, 229);
            this.me0.Name = "me0";
            this.me0.Properties.AllowFocused = false;
            this.me0.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.me0.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.me0.Properties.Appearance.Options.UseBackColor = true;
            this.me0.Properties.Appearance.Options.UseFont = true;
            this.me0.Properties.Appearance.Options.UseTextOptions = true;
            this.me0.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.me0.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.me0.Properties.ReadOnly = true;
            this.me0.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.me0.ShowToolTips = false;
            this.me0.Size = new System.Drawing.Size(180, 187);
            this.me0.TabIndex = 45;
            this.me0.TabStop = false;
            // 
            // meMain
            // 
            this.meMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.meMain.EditValue = "";
            this.meMain.Enabled = false;
            this.meMain.Location = new System.Drawing.Point(31, 5);
            this.meMain.Name = "meMain";
            this.meMain.Properties.AcceptsReturn = false;
            this.meMain.Properties.AllowFocused = false;
            this.meMain.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.meMain.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.meMain.Properties.Appearance.Options.UseBackColor = true;
            this.meMain.Properties.Appearance.Options.UseFont = true;
            this.meMain.Properties.Appearance.Options.UseTextOptions = true;
            this.meMain.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.meMain.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.meMain.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.meMain.Properties.ReadOnly = true;
            this.meMain.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.meMain.ShowToolTips = false;
            this.meMain.Size = new System.Drawing.Size(1017, 159);
            this.meMain.TabIndex = 33;
            this.meMain.TabStop = false;
            // 
            // frmWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 631);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel0);
            this.Name = "frmWeather";
            this.Text = "天气预报";
            this.Shown += new System.EventHandler(this.frm天气_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panel0)).EndInit();
            this.panel0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lue县区.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue省.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue市.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.me3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.me2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.me1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.me0.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meMain.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panel0;
        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraEditors.MemoEdit meMain;
        private DevExpress.XtraEditors.MemoEdit me0;
        private DevExpress.XtraEditors.MemoEdit me3;
        private DevExpress.XtraEditors.MemoEdit me2;
        private DevExpress.XtraEditors.MemoEdit me1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit lue县区;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl img0A;
        private DevExpress.XtraEditors.LabelControl img3B;
        private DevExpress.XtraEditors.LabelControl img3A;
        private DevExpress.XtraEditors.LabelControl img2B;
        private DevExpress.XtraEditors.LabelControl img2A;
        private DevExpress.XtraEditors.LabelControl img1B;
        private DevExpress.XtraEditors.LabelControl img1A;
        private DevExpress.XtraEditors.LabelControl img0B;
        private DevExpress.XtraEditors.SearchLookUpEdit lue省;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit lue市;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}