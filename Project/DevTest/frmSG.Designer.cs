namespace DevTest
{
    partial class frmSG
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
            this.grid1 = new SourceGrid.Grid();
            this.btAddRow = new DevExpress.XtraEditors.SimpleButton();
            this.btRemoveRow = new DevExpress.XtraEditors.SimpleButton();
            this.btMoveColumn = new DevExpress.XtraEditors.SimpleButton();
            this.btMoveRow = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.btExportHTML = new DevExpress.XtraEditors.SimpleButton();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.chkEditOnDoubleClick = new System.Windows.Forms.CheckBox();
            this.btExportCsv = new DevExpress.XtraEditors.SimpleButton();
            this.btExportImage = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid1.BackColor = System.Drawing.Color.White;
            this.grid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid1.EnableSort = true;
            this.grid1.Location = new System.Drawing.Point(8, 37);
            this.grid1.Name = "grid1";
            this.grid1.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid1.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid1.Size = new System.Drawing.Size(764, 356);
            this.grid1.TabIndex = 1;
            this.grid1.TabStop = true;
            this.grid1.ToolTipText = "";
            // 
            // btAddRow
            // 
            this.btAddRow.Location = new System.Drawing.Point(8, 8);
            this.btAddRow.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btAddRow.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btAddRow.Name = "btAddRow";
            this.btAddRow.Size = new System.Drawing.Size(84, 23);
            this.btAddRow.TabIndex = 1;
            this.btAddRow.Text = "AddRow";
            this.btAddRow.Click += new System.EventHandler(this.btAddRow_Click);
            // 
            // btRemoveRow
            // 
            this.btRemoveRow.Location = new System.Drawing.Point(96, 8);
            this.btRemoveRow.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btRemoveRow.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btRemoveRow.Name = "btRemoveRow";
            this.btRemoveRow.Size = new System.Drawing.Size(84, 23);
            this.btRemoveRow.TabIndex = 2;
            this.btRemoveRow.Text = "RemoveRow";
            this.btRemoveRow.Click += new System.EventHandler(this.btRemoveRow_Click);
            // 
            // btMoveColumn
            // 
            this.btMoveColumn.Location = new System.Drawing.Point(300, 8);
            this.btMoveColumn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btMoveColumn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btMoveColumn.Name = "btMoveColumn";
            this.btMoveColumn.Size = new System.Drawing.Size(84, 23);
            this.btMoveColumn.TabIndex = 4;
            this.btMoveColumn.Text = "Move Column";
            this.btMoveColumn.Click += new System.EventHandler(this.btMoveColumn_Click);
            // 
            // btMoveRow
            // 
            this.btMoveRow.Location = new System.Drawing.Point(208, 8);
            this.btMoveRow.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btMoveRow.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btMoveRow.Name = "btMoveRow";
            this.btMoveRow.Size = new System.Drawing.Size(84, 23);
            this.btMoveRow.TabIndex = 5;
            this.btMoveRow.Text = "Move Row";
            this.btMoveRow.Click += new System.EventHandler(this.btMoveRow_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label1.Location = new System.Drawing.Point(8, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Click column header to sort the grid";
            // 
            // btExportHTML
            // 
            this.btExportHTML.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic);
            this.btExportHTML.Appearance.Options.UseFont = true;
            this.btExportHTML.Location = new System.Drawing.Point(416, 8);
            this.btExportHTML.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btExportHTML.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btExportHTML.Name = "btExportHTML";
            this.btExportHTML.Size = new System.Drawing.Size(84, 23);
            this.btExportHTML.TabIndex = 7;
            this.btExportHTML.Text = "&Export HTML";
            this.btExportHTML.Click += new System.EventHandler(this.btExportHTML_Click);
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.Location = new System.Drawing.Point(624, 355);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(128, 20);
            this.chkReadOnly.TabIndex = 8;
            this.chkReadOnly.Text = "Read Only Cells";
            this.chkReadOnly.UseVisualStyleBackColor = true;
            this.chkReadOnly.CheckedChanged += new System.EventHandler(this.chkReadOnly_CheckedChanged);
            // 
            // chkEditOnDoubleClick
            // 
            this.chkEditOnDoubleClick.Location = new System.Drawing.Point(624, 371);
            this.chkEditOnDoubleClick.Name = "chkEditOnDoubleClick";
            this.chkEditOnDoubleClick.Size = new System.Drawing.Size(128, 20);
            this.chkEditOnDoubleClick.TabIndex = 9;
            this.chkEditOnDoubleClick.Text = "Edit On Double Click";
            this.chkEditOnDoubleClick.UseVisualStyleBackColor = true;
            this.chkEditOnDoubleClick.CheckedChanged += new System.EventHandler(this.chkEditOnDoubleClick_CheckedChanged);
            // 
            // btExportCsv
            // 
            this.btExportCsv.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btExportCsv.Location = new System.Drawing.Point(506, 8);
            this.btExportCsv.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btExportCsv.Name = "btExportCsv";
            this.btExportCsv.Size = new System.Drawing.Size(84, 23);
            this.btExportCsv.TabIndex = 13;
            this.btExportCsv.Text = "Export CSV";
            this.btExportCsv.Click += new System.EventHandler(this.btExportCsv_Click);
            // 
            // btExportImage
            // 
            this.btExportImage.Location = new System.Drawing.Point(596, 8);
            this.btExportImage.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btExportImage.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btExportImage.Name = "btExportImage";
            this.btExportImage.Size = new System.Drawing.Size(84, 23);
            this.btExportImage.TabIndex = 14;
            this.btExportImage.Text = "Export Image";
            this.btExportImage.Click += new System.EventHandler(this.btExportImage_Click);
            // 
            // frmSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 400);
            this.Controls.Add(this.chkEditOnDoubleClick);
            this.Controls.Add(this.btExportImage);
            this.Controls.Add(this.btExportCsv);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.btExportHTML);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btMoveRow);
            this.Controls.Add(this.btMoveColumn);
            this.Controls.Add(this.btRemoveRow);
            this.Controls.Add(this.btAddRow);
            this.Controls.Add(this.grid1);
            this.Name = "frmSG";
            this.Text = "SourceGrid";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSG_FormClosed);
            this.Load += new System.EventHandler(this.frmSG_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SourceGrid.Grid grid1;
        private DevExpress.XtraEditors.SimpleButton btAddRow;
        private DevExpress.XtraEditors.SimpleButton btRemoveRow;
        private DevExpress.XtraEditors.SimpleButton btMoveColumn;
        private DevExpress.XtraEditors.SimpleButton btMoveRow;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.SimpleButton btExportHTML;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.CheckBox chkEditOnDoubleClick;
        private DevExpress.XtraEditors.SimpleButton btExportCsv;
        private DevExpress.XtraEditors.SimpleButton btExportImage;
    }
}