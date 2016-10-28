namespace DevTest.测试1
{
    partial class frmValidate
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cbxLength = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbxLineNum = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.hScrollBar1 = new DevExpress.XtraEditors.HScrollBar();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.hScrollBar2 = new DevExpress.XtraEditors.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLineNum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(104, 186);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 27);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "验证码:";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(162, 186);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.AutoHeight = false;
            this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textEdit1.Size = new System.Drawing.Size(150, 27);
            this.textEdit1.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::DevTest.Properties.Resources.nothing;
            this.pictureEdit1.Location = new System.Drawing.Point(162, 219);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Size = new System.Drawing.Size(150, 42);
            this.pictureEdit1.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(236, 278);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(76, 27);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "确定";
            this.simpleButton1.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbxLength
            // 
            this.cbxLength.Location = new System.Drawing.Point(162, 42);
            this.cbxLength.Name = "cbxLength";
            this.cbxLength.Properties.AutoHeight = false;
            this.cbxLength.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxLength.Properties.DropDownRows = 8;
            this.cbxLength.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbxLength.Properties.ShowToolTipForTrimmedText = DevExpress.Utils.DefaultBoolean.False;
            this.cbxLength.Properties.Sorted = true;
            this.cbxLength.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxLength.ShowToolTips = false;
            this.cbxLength.Size = new System.Drawing.Size(45, 27);
            this.cbxLength.TabIndex = 5;
            this.cbxLength.SelectedValueChanged += new System.EventHandler(this.cbxLength_SelectedValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(51, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(105, 27);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "生成验证码长度";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(230, 42);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 27);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "曲线条数";
            // 
            // cbxLineNum
            // 
            this.cbxLineNum.Location = new System.Drawing.Point(301, 42);
            this.cbxLineNum.Name = "cbxLineNum";
            this.cbxLineNum.Properties.AutoHeight = false;
            this.cbxLineNum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxLineNum.Properties.DropDownRows = 5;
            this.cbxLineNum.Properties.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cbxLineNum.Properties.ShowToolTipForTrimmedText = DevExpress.Utils.DefaultBoolean.False;
            this.cbxLineNum.Properties.Sorted = true;
            this.cbxLineNum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxLineNum.ShowToolTips = false;
            this.cbxLineNum.Size = new System.Drawing.Size(46, 27);
            this.cbxLineNum.TabIndex = 7;
            this.cbxLineNum.SelectedValueChanged += new System.EventHandler(this.cbxLineNum_SelectedValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(318, 186);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 27);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "生成";
            this.labelControl2.Click += new System.EventHandler(this.labelChange_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 20;
            this.hScrollBar1.Location = new System.Drawing.Point(494, 42);
            this.hScrollBar1.Maximum = 255;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(205, 27);
            this.hScrollBar1.TabIndex = 9;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(377, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(111, 27);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "当前亮度值:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(51, 101);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 27);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "曝光度";
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.LargeChange = 100000;
            this.hScrollBar2.Location = new System.Drawing.Point(110, 101);
            this.hScrollBar2.Maximum = 16777215;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(205, 27);
            this.hScrollBar2.SmallChange = 1000;
            this.hScrollBar2.TabIndex = 12;
            this.hScrollBar2.ValueChanged += new System.EventHandler(this.hScrollBar2_ValueChanged);
            // 
            // frmValidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 618);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbxLineNum);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cbxLength);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmValidate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm验证码";
            this.Load += new System.EventHandler(this.frmValidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLineNum.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit cbxLength;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbxLineNum;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.HScrollBar hScrollBar1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.HScrollBar hScrollBar2;
    }
}