namespace DevTest
{
    partial class frmPrintScreen
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.btn全屏 = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn当前子窗体 = new DevExpress.XtraEditors.SimpleButton();
            this.btnTest = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(56, 45);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(276, 141);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(56, 281);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(276, 141);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "simpleButton2";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(431, 45);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(276, 141);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "simpleButton3";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(431, 281);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(276, 141);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "simpleButton4";
            // 
            // btn全屏
            // 
            this.btn全屏.Location = new System.Drawing.Point(3, 3);
            this.btn全屏.Name = "btn全屏";
            this.btn全屏.Size = new System.Drawing.Size(74, 34);
            this.btn全屏.TabIndex = 4;
            this.btn全屏.Text = "保存全屏";
            this.btn全屏.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn全屏);
            this.flowLayoutPanel1.Controls.Add(this.btn当前子窗体);
            this.flowLayoutPanel1.Controls.Add(this.btnTest);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(893, 40);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btn当前子窗体
            // 
            this.btn当前子窗体.Location = new System.Drawing.Point(83, 3);
            this.btn当前子窗体.Name = "btn当前子窗体";
            this.btn当前子窗体.Size = new System.Drawing.Size(98, 34);
            this.btn当前子窗体.TabIndex = 5;
            this.btn当前子窗体.Text = "保存当前子窗体";
            this.btn当前子窗体.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(187, 3);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(98, 34);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "保存当";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // frm截屏
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 561);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "frm截屏";
            this.Text = "frm截屏";
            this.Load += new System.EventHandler(this.frm截屏_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton btn全屏;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btn当前子窗体;
        private DevExpress.XtraEditors.SimpleButton btnTest;
    }
}