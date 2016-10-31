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
            this.sLue = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmb省 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.img4B = new DevExpress.XtraEditors.LabelControl();
            this.img4A = new DevExpress.XtraEditors.LabelControl();
            this.img3B = new DevExpress.XtraEditors.LabelControl();
            this.img3A = new DevExpress.XtraEditors.LabelControl();
            this.img2B = new DevExpress.XtraEditors.LabelControl();
            this.img2A = new DevExpress.XtraEditors.LabelControl();
            this.img1B = new DevExpress.XtraEditors.LabelControl();
            this.img1A = new DevExpress.XtraEditors.LabelControl();
            this.img0B = new DevExpress.XtraEditors.LabelControl();
            this.img0A = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.me4 = new DevExpress.XtraEditors.MemoEdit();
            this.me3 = new DevExpress.XtraEditors.MemoEdit();
            this.me2 = new DevExpress.XtraEditors.MemoEdit();
            this.me1 = new DevExpress.XtraEditors.MemoEdit();
            this.me0 = new DevExpress.XtraEditors.MemoEdit();
            this.meMain = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel0)).BeginInit();
            this.panel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sLue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb省.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.me4.Properties)).BeginInit();
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
            this.panel0.Controls.Add(this.sLue);
            this.panel0.Controls.Add(this.cmb省);
            this.panel0.Location = new System.Drawing.Point(0, 0);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(1079, 49);
            this.panel0.TabIndex = 9;
            // 
            // sLue
            // 
            this.sLue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sLue.EditValue = "";
            this.sLue.Location = new System.Drawing.Point(350, 12);
            this.sLue.Name = "sLue";
            this.sLue.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.sLue.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.sLue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sLue.Properties.NullText = "";
            this.sLue.Properties.ShowClearButton = false;
            this.sLue.Properties.ShowFooter = false;
            this.sLue.Properties.View = this.searchLookUpEdit1View;
            this.sLue.Size = new System.Drawing.Size(109, 18);
            this.sLue.TabIndex = 1;
            this.sLue.EditValueChanged += new System.EventHandler(this.sLue_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FixedLineWidth = 1;
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.IndicatorWidth = 35;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = true;
            this.searchLookUpEdit1View.OptionsView.EnableAppearanceOddRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowColumnHeaders = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.searchLookUpEdit1View.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.searchLookUpEdit1View_CustomDrawRowIndicator);
            // 
            // cmb省
            // 
            this.cmb省.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb省.Location = new System.Drawing.Point(205, 12);
            this.cmb省.Name = "cmb省";
            this.cmb省.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmb省.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb省.Properties.DropDownRows = 10;
            this.cmb省.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb省.Size = new System.Drawing.Size(109, 18);
            this.cmb省.TabIndex = 0;
            this.cmb省.SelectedValueChanged += new System.EventHandler(this.cmb省_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Appearance.BackColor = System.Drawing.Color.White;
            this.panel1.Appearance.Options.UseBackColor = true;
            this.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel1.Controls.Add(this.img4B);
            this.panel1.Controls.Add(this.img4A);
            this.panel1.Controls.Add(this.img3B);
            this.panel1.Controls.Add(this.img3A);
            this.panel1.Controls.Add(this.img2B);
            this.panel1.Controls.Add(this.img2A);
            this.panel1.Controls.Add(this.img1B);
            this.panel1.Controls.Add(this.img1A);
            this.panel1.Controls.Add(this.img0B);
            this.panel1.Controls.Add(this.img0A);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.me4);
            this.panel1.Controls.Add(this.me3);
            this.panel1.Controls.Add(this.me2);
            this.panel1.Controls.Add(this.me1);
            this.panel1.Controls.Add(this.me0);
            this.panel1.Controls.Add(this.meMain);
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 586);
            this.panel1.TabIndex = 11;
            // 
            // img4B
            // 
            this.img4B.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img4B.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("img4B.Appearance.Image")));
            this.img4B.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.img4B.Location = new System.Drawing.Point(885, 209);
            this.img4B.Name = "img4B";
            this.img4B.Size = new System.Drawing.Size(44, 24);
            this.img4B.TabIndex = 74;
            // 
            // img4A
            // 
            this.img4A.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img4A.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("img4A.Appearance.Image")));
            this.img4A.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.img4A.Location = new System.Drawing.Point(826, 209);
            this.img4A.Name = "img4A";
            this.img4A.Size = new System.Drawing.Size(44, 24);
            this.img4A.TabIndex = 73;
            // 
            // img3B
            // 
            this.img3B.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img3B.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("img3B.Appearance.Image")));
            this.img3B.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.img3B.Location = new System.Drawing.Point(704, 209);
            this.img3B.Name = "img3B";
            this.img3B.Size = new System.Drawing.Size(44, 24);
            this.img3B.TabIndex = 72;
            // 
            // img3A
            // 
            this.img3A.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img3A.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("img3A.Appearance.Image")));
            this.img3A.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.img3A.Location = new System.Drawing.Point(644, 209);
            this.img3A.Name = "img3A";
            this.img3A.Size = new System.Drawing.Size(44, 24);
            this.img3A.TabIndex = 71;
            // 
            // img2B
            // 
            this.img2B.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img2B.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("img2B.Appearance.Image")));
            this.img2B.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.img2B.Location = new System.Drawing.Point(521, 209);
            this.img2B.Name = "img2B";
            this.img2B.Size = new System.Drawing.Size(44, 24);
            this.img2B.TabIndex = 70;
            // 
            // img2A
            // 
            this.img2A.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img2A.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("img2A.Appearance.Image")));
            this.img2A.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.img2A.Location = new System.Drawing.Point(458, 209);
            this.img2A.Name = "img2A";
            this.img2A.Size = new System.Drawing.Size(44, 24);
            this.img2A.TabIndex = 69;
            // 
            // img1B
            // 
            this.img1B.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img1B.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("img1B.Appearance.Image")));
            this.img1B.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.img1B.Location = new System.Drawing.Point(338, 209);
            this.img1B.Name = "img1B";
            this.img1B.Size = new System.Drawing.Size(44, 24);
            this.img1B.TabIndex = 68;
            // 
            // img1A
            // 
            this.img1A.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img1A.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("img1A.Appearance.Image")));
            this.img1A.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.img1A.Location = new System.Drawing.Point(279, 209);
            this.img1A.Name = "img1A";
            this.img1A.Size = new System.Drawing.Size(44, 24);
            this.img1A.TabIndex = 67;
            // 
            // img0B
            // 
            this.img0B.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img0B.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("img0B.Appearance.Image")));
            this.img0B.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.img0B.Location = new System.Drawing.Point(149, 209);
            this.img0B.Name = "img0B";
            this.img0B.Size = new System.Drawing.Size(44, 24);
            this.img0B.TabIndex = 66;
            // 
            // img0A
            // 
            this.img0A.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img0A.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("img0A.Appearance.Image")));
            this.img0A.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.img0A.Location = new System.Drawing.Point(90, 209);
            this.img0A.Name = "img0A";
            this.img0A.Size = new System.Drawing.Size(44, 24);
            this.img0A.TabIndex = 65;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(864, 200);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(29, 39);
            this.labelControl5.TabIndex = 64;
            this.labelControl5.Text = "~";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(681, 200);
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
            this.labelControl3.Location = new System.Drawing.Point(498, 200);
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
            this.labelControl2.Location = new System.Drawing.Point(317, 200);
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
            this.labelControl1.Location = new System.Drawing.Point(129, 200);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 39);
            this.labelControl1.TabIndex = 52;
            this.labelControl1.Text = "~";
            // 
            // me4
            // 
            this.me4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.me4.Enabled = false;
            this.me4.Location = new System.Drawing.Point(789, 245);
            this.me4.Name = "me4";
            this.me4.Properties.AllowFocused = false;
            this.me4.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.me4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.me4.Properties.Appearance.Options.UseBackColor = true;
            this.me4.Properties.Appearance.Options.UseFont = true;
            this.me4.Properties.Appearance.Options.UseTextOptions = true;
            this.me4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.me4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.me4.Properties.ReadOnly = true;
            this.me4.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.me4.ShowToolTips = false;
            this.me4.Size = new System.Drawing.Size(180, 319);
            this.me4.TabIndex = 49;
            this.me4.TabStop = false;
            // 
            // me3
            // 
            this.me3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.me3.Enabled = false;
            this.me3.Location = new System.Drawing.Point(606, 245);
            this.me3.Name = "me3";
            this.me3.Properties.AllowFocused = false;
            this.me3.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.me3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.me3.Properties.Appearance.Options.UseBackColor = true;
            this.me3.Properties.Appearance.Options.UseFont = true;
            this.me3.Properties.Appearance.Options.UseTextOptions = true;
            this.me3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.me3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.me3.Properties.ReadOnly = true;
            this.me3.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.me3.ShowToolTips = false;
            this.me3.Size = new System.Drawing.Size(180, 319);
            this.me3.TabIndex = 48;
            this.me3.TabStop = false;
            // 
            // me2
            // 
            this.me2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.me2.Enabled = false;
            this.me2.Location = new System.Drawing.Point(423, 245);
            this.me2.Name = "me2";
            this.me2.Properties.AllowFocused = false;
            this.me2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.me2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.me2.Properties.Appearance.Options.UseBackColor = true;
            this.me2.Properties.Appearance.Options.UseFont = true;
            this.me2.Properties.Appearance.Options.UseTextOptions = true;
            this.me2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.me2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.me2.Properties.ReadOnly = true;
            this.me2.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.me2.ShowToolTips = false;
            this.me2.Size = new System.Drawing.Size(180, 319);
            this.me2.TabIndex = 47;
            this.me2.TabStop = false;
            // 
            // me1
            // 
            this.me1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.me1.Enabled = false;
            this.me1.Location = new System.Drawing.Point(240, 245);
            this.me1.Name = "me1";
            this.me1.Properties.AllowFocused = false;
            this.me1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.me1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.me1.Properties.Appearance.Options.UseBackColor = true;
            this.me1.Properties.Appearance.Options.UseFont = true;
            this.me1.Properties.Appearance.Options.UseTextOptions = true;
            this.me1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.me1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.me1.Properties.ReadOnly = true;
            this.me1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.me1.ShowToolTips = false;
            this.me1.Size = new System.Drawing.Size(180, 319);
            this.me1.TabIndex = 46;
            this.me1.TabStop = false;
            // 
            // me0
            // 
            this.me0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.me0.Enabled = false;
            this.me0.Location = new System.Drawing.Point(55, 245);
            this.me0.Name = "me0";
            this.me0.Properties.AllowFocused = false;
            this.me0.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.me0.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.me0.Properties.Appearance.Options.UseBackColor = true;
            this.me0.Properties.Appearance.Options.UseFont = true;
            this.me0.Properties.Appearance.Options.UseTextOptions = true;
            this.me0.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.me0.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.me0.Properties.ReadOnly = true;
            this.me0.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.me0.ShowToolTips = false;
            this.me0.Size = new System.Drawing.Size(180, 319);
            this.me0.TabIndex = 45;
            this.me0.TabStop = false;
            // 
            // meMain
            // 
            this.meMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.meMain.Enabled = false;
            this.meMain.Location = new System.Drawing.Point(31, 5);
            this.meMain.Name = "meMain";
            this.meMain.Properties.AllowFocused = false;
            this.meMain.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.meMain.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.meMain.Properties.Appearance.Options.UseBackColor = true;
            this.meMain.Properties.Appearance.Options.UseFont = true;
            this.meMain.Properties.Appearance.Options.UseTextOptions = true;
            this.meMain.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.Load += new System.EventHandler(this.frm天气_Load);
            this.Shown += new System.EventHandler(this.frm天气_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panel0)).EndInit();
            this.panel0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sLue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb省.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.me4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.me3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.me2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.me1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.me0.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meMain.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panel0;
        private DevExpress.XtraEditors.ComboBoxEdit cmb省;
        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraEditors.MemoEdit meMain;
        private DevExpress.XtraEditors.MemoEdit me0;
        private DevExpress.XtraEditors.MemoEdit me4;
        private DevExpress.XtraEditors.MemoEdit me3;
        private DevExpress.XtraEditors.MemoEdit me2;
        private DevExpress.XtraEditors.MemoEdit me1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit sLue;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl img0A;
        private DevExpress.XtraEditors.LabelControl img4B;
        private DevExpress.XtraEditors.LabelControl img4A;
        private DevExpress.XtraEditors.LabelControl img3B;
        private DevExpress.XtraEditors.LabelControl img3A;
        private DevExpress.XtraEditors.LabelControl img2B;
        private DevExpress.XtraEditors.LabelControl img2A;
        private DevExpress.XtraEditors.LabelControl img1B;
        private DevExpress.XtraEditors.LabelControl img1A;
        private DevExpress.XtraEditors.LabelControl img0B;
    }
}