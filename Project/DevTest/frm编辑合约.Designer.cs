namespace DevTest
{
    partial class frm编辑合约
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
            this.txt名称 = new DevExpress.XtraEditors.TextEdit();
            this.dte开始时间 = new DevExpress.XtraEditors.DateEdit();
            this.dte结束时间 = new DevExpress.XtraEditors.DateEdit();
            this.btn保存 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt名称.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte开始时间.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte开始时间.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte结束时间.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte结束时间.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(40, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "名称";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(40, 147);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "结束时间";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(40, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "开始时间";
            // 
            // txt名称
            // 
            this.txt名称.Location = new System.Drawing.Point(94, 38);
            this.txt名称.Name = "txt名称";
            this.txt名称.Size = new System.Drawing.Size(160, 20);
            this.txt名称.TabIndex = 3;
            // 
            // dte开始时间
            // 
            this.dte开始时间.EditValue = null;
            this.dte开始时间.Location = new System.Drawing.Point(94, 91);
            this.dte开始时间.Name = "dte开始时间";
            this.dte开始时间.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte开始时间.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte开始时间.Properties.DisplayFormat.FormatString = "";
            this.dte开始时间.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte开始时间.Properties.EditFormat.FormatString = "";
            this.dte开始时间.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte开始时间.Properties.Mask.EditMask = " yyyy年MM月dd日";
            this.dte开始时间.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dte开始时间.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dte开始时间.Size = new System.Drawing.Size(160, 20);
            this.dte开始时间.TabIndex = 4;
            // 
            // dte结束时间
            // 
            this.dte结束时间.EditValue = null;
            this.dte结束时间.Location = new System.Drawing.Point(94, 144);
            this.dte结束时间.Name = "dte结束时间";
            this.dte结束时间.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte结束时间.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte结束时间.Properties.DisplayFormat.FormatString = "";
            this.dte结束时间.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte结束时间.Properties.EditFormat.FormatString = "";
            this.dte结束时间.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte结束时间.Properties.Mask.EditMask = " yyyy年MM月dd日";
            this.dte结束时间.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dte结束时间.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dte结束时间.Size = new System.Drawing.Size(160, 20);
            this.dte结束时间.TabIndex = 5;
            // 
            // btn保存
            // 
            this.btn保存.Location = new System.Drawing.Point(94, 196);
            this.btn保存.Name = "btn保存";
            this.btn保存.Size = new System.Drawing.Size(75, 23);
            this.btn保存.TabIndex = 6;
            this.btn保存.Text = "保存";
            this.btn保存.Click += new System.EventHandler(this.btn保存_Click);
            // 
            // frm编辑合约
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 259);
            this.Controls.Add(this.btn保存);
            this.Controls.Add(this.txt名称);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dte开始时间);
            this.Controls.Add(this.dte结束时间);
            this.Name = "frm编辑合约";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm编辑合约";
            this.Load += new System.EventHandler(this.frm编辑合约_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt名称.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte开始时间.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte开始时间.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte结束时间.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte结束时间.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dte结束时间;
        private DevExpress.XtraEditors.SimpleButton btn保存;
        private DevExpress.XtraEditors.TextEdit txt名称;
        private DevExpress.XtraEditors.DateEdit dte开始时间;
    }
}