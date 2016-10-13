namespace DevTest
{
    partial class frm收入及费用
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmb类别 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt名称 = new DevExpress.XtraEditors.TextEdit();
            this.txt金额 = new DevExpress.XtraEditors.TextEdit();
            this.txt期数 = new DevExpress.XtraEditors.TextEdit();
            this.chk状态 = new DevExpress.XtraEditors.CheckEdit();
            this.btn添加 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmb类别.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt名称.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt金额.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt期数.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk状态.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(58, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "类别";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(58, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "名称";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(58, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "金额";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(58, 164);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "期数";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(58, 208);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Padding = new System.Windows.Forms.Padding(1);
            this.labelControl5.Size = new System.Drawing.Size(26, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "状态";
            // 
            // cmb类别
            // 
            this.cmb类别.Location = new System.Drawing.Point(88, 29);
            this.cmb类别.Name = "cmb类别";
            this.cmb类别.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb类别.Properties.Items.AddRange(new object[] {
            "收入",
            "费用"});
            this.cmb类别.Size = new System.Drawing.Size(100, 20);
            this.cmb类别.TabIndex = 5;
            this.cmb类别.SelectedIndexChanged += new System.EventHandler(this.cmb类别_SelectedIndexChanged);
            // 
            // txt名称
            // 
            this.txt名称.Location = new System.Drawing.Point(88, 73);
            this.txt名称.Name = "txt名称";
            this.txt名称.Size = new System.Drawing.Size(212, 20);
            this.txt名称.TabIndex = 6;
            // 
            // txt金额
            // 
            this.txt金额.Location = new System.Drawing.Point(88, 117);
            this.txt金额.Name = "txt金额";
            this.txt金额.Properties.Mask.EditMask = "f2";
            this.txt金额.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt金额.Size = new System.Drawing.Size(100, 20);
            this.txt金额.TabIndex = 7;
            // 
            // txt期数
            // 
            this.txt期数.Location = new System.Drawing.Point(88, 161);
            this.txt期数.Name = "txt期数";
            this.txt期数.Size = new System.Drawing.Size(100, 20);
            this.txt期数.TabIndex = 8;
            // 
            // chk状态
            // 
            this.chk状态.Location = new System.Drawing.Point(88, 208);
            this.chk状态.Name = "chk状态";
            this.chk状态.Properties.Caption = "";
            this.chk状态.Size = new System.Drawing.Size(16, 19);
            this.chk状态.TabIndex = 9;
            this.chk状态.CheckedChanged += new System.EventHandler(this.chk状态_CheckedChanged);
            // 
            // btn添加
            // 
            this.btn添加.Location = new System.Drawing.Point(126, 242);
            this.btn添加.Name = "btn添加";
            this.btn添加.Size = new System.Drawing.Size(75, 23);
            this.btn添加.TabIndex = 10;
            this.btn添加.Text = "添加";
            this.btn添加.Click += new System.EventHandler(this.btn添加_Click);
            // 
            // frm收入及费用
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 277);
            this.Controls.Add(this.btn添加);
            this.Controls.Add(this.chk状态);
            this.Controls.Add(this.txt期数);
            this.Controls.Add(this.txt金额);
            this.Controls.Add(this.txt名称);
            this.Controls.Add(this.cmb类别);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frm收入及费用";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "信息";
            this.Load += new System.EventHandler(this.frm收入及费用_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb类别.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt名称.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt金额.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt期数.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk状态.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cmb类别;
        private DevExpress.XtraEditors.TextEdit txt名称;
        private DevExpress.XtraEditors.TextEdit txt金额;
        private DevExpress.XtraEditors.TextEdit txt期数;
        private DevExpress.XtraEditors.CheckEdit chk状态;
        private DevExpress.XtraEditors.SimpleButton btn添加;
    }
}