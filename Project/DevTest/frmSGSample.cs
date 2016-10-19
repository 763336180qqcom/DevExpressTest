using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTest
{
    public partial class frmSample03 : XtraForm
    {
        public frmSample03()
        {
            InitializeComponent();
        }

        private void frmSGSample_Load(object sender, EventArgs e)
        {

        }
        private EventHandler InvertDisabledCheckBox(int row)
        {
            return delegate
            {
                grid[row, 2].Value = !(((bool)grid[row, 2].Value));
            };
        }
        private void CellButton_Click(object sender, EventArgs e)
        {
            SourceGrid.CellContext context = (SourceGrid.CellContext)sender;
            SourceGrid.Cells.Button btnCell = (SourceGrid.Cells.Button)context.Cell;
            btnCell.Value = DateTime.Now.TimeOfDay.ToString();
        }

        private void CellLink_Click(object sender, EventArgs e)
        {
            SourceGrid.CellContext context = (SourceGrid.CellContext)sender;
            SourceGrid.Cells.Link btnCell = (SourceGrid.Cells.Link)context.Cell;
            btnCell.Value = DateTime.Now.TimeOfDay.ToString();
        }
        private class RoundView : SourceGrid.Cells.Views.Cell
        {
            public RoundView()
            {
                TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                base.Background = mBackground;
                Border = DevAge.Drawing.RectangleBorder.NoBorder;
            }

            public double Round
            {
                get { return mBackground.Round; }
                set { mBackground.Round = value; }
            }

            private BackVisualElement mBackground = new BackVisualElement();

            private class BackVisualElement : DevAge.Drawing.VisualElements.VisualElementBase
            {
                #region Constuctor
                /// <summary>
                /// Default constructor
                /// </summary>
                public BackVisualElement()
                {
                }

                /// <summary>
                /// Copy constructor
                /// </summary>
                /// <param name="other"></param>
                public BackVisualElement(BackVisualElement other)
                    : base(other)
                {
                    Round = other.Round;
                }
                #endregion
                /// <summary>
                /// Clone
                /// </summary>
                /// <returns></returns>
                public override object Clone()
                {
                    return new BackVisualElement(this);
                }

                private double mRound = 0.5;
                public double Round
                {
                    get { return mRound; }
                    set { mRound = value; }
                }

                protected override void OnDraw(DevAge.Drawing.GraphicsCache graphics, RectangleF area)
                {
                    DevAge.Drawing.RoundedRectangle rounded = new DevAge.Drawing.RoundedRectangle(Rectangle.Round(area), Round);
                    using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(area, Color.RoyalBlue, Color.WhiteSmoke, System.Drawing.Drawing2D.LinearGradientMode.Vertical))
                    {
                        graphics.Graphics.FillRegion(brush, new Region(rounded.ToGraphicsPath()));
                    }


                    //Border
                    DevAge.Drawing.Utilities.DrawRoundedRectangle(graphics.Graphics, rounded, Pens.RoyalBlue);

                }

                protected override SizeF OnMeasureContent(DevAge.Drawing.MeasureHelper measure, SizeF maxSize)
                {
                    return SizeF.Empty;
                }
            }
        }
        private class RotatedText : DevAge.Drawing.VisualElements.TextGDI
        {
            public RotatedText(float angle)
            {
                Angle = angle;
            }

            public float Angle = 0;

            protected override void OnDraw(DevAge.Drawing.GraphicsCache graphics, RectangleF area)
            {
                System.Drawing.Drawing2D.GraphicsState state = graphics.Graphics.Save();
                try
                {
                    float width2 = area.Width / 2;
                    float height2 = area.Height / 2;

                    //For a better drawing use the clear type rendering
                    graphics.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                    //Move the origin to the center of the cell (for a more easy rotation)
                    graphics.Graphics.TranslateTransform(area.X + width2, area.Y + height2);

                    graphics.Graphics.RotateTransform(Angle);

                    StringFormat.Alignment = StringAlignment.Center;
                    StringFormat.LineAlignment = StringAlignment.Center;
                    graphics.Graphics.DrawString(Value, Font, graphics.BrushsCache.GetBrush(ForeColor), 0, 0, StringFormat);
                }
                finally
                {
                    graphics.Graphics.Restore(state);
                }
            }

            //TODO Implement Clone and MeasureContent
            //Here I should also implement MeasureContent (think also for a solution to allow rotated text with any kind of allignment)
        }
        private class GDITextView : SourceGrid.Cells.Views.Cell
        {
            public GDITextView()
            {
                ElementText = new DevAge.Drawing.VisualElements.TextGDI();
            }

            private System.Drawing.StringFormatFlags mFormatFlags = StringFormatFlags.NoWrap;
            public System.Drawing.StringFormatFlags FormatFlags
            {
                get { return mFormatFlags; }
                set { mFormatFlags = value; }
            }

            protected override void PrepareVisualElementText(SourceGrid.CellContext context)
            {
                base.PrepareVisualElementText(context);

                ((DevAge.Drawing.VisualElements.TextGDI)ElementText).StringFormat.FormatFlags = FormatFlags;
            }

            protected override SizeF OnMeasureContent(DevAge.Drawing.MeasureHelper measure, SizeF maxSize)
            {
                //TODO Here I must add some fixed pixels because seems that there are some little
                // difference from the measured content and the actual drawing surface (probably this is a little bug ... I must check)
                SizeF result = base.OnMeasureContent(measure, maxSize);
                return new SizeF(result.Width + 1, result.Height + 1);
            }
        }
        private class EditorFileDialog : SourceGrid.Cells.Editors.TextBoxButton
        {
            public EditorFileDialog()
                : base(typeof(string))
            {
                Control.DialogOpen += new EventHandler(Control_DialogOpen);
            }

            void Control_DialogOpen(object sender, EventArgs e)
            {
                using (OpenFileDialog dg = new OpenFileDialog())
                {
                    dg.FileName = (string)Control.Value;

                    if (dg.ShowDialog(EditCellContext.Grid) == DialogResult.OK)
                    {
                        Control.Value = dg.FileName;
                    }
                }
            }
        }

        private void frmSample03_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frm主界面.childs.Contains(Name))
                frm主界面.childs.Remove(Name);
        }
    }
}
