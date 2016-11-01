using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace IPlugins
{
    [DefaultEvent("SwitchChanged")]
    public class SwitchBox : Control
    {
        public SwitchBox() {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.White;
            this.Cursor = Cursors.Hand;
        }

        private bool _IsON;

        public bool IsON {
            get { return _IsON; }
            set {
                if (_IsON == value) return;
                _IsON = value;
                this.OnSwitchChanged(EventArgs.Empty);
                this.Invalidate();
            }
        }

        private string _OFFText = "OFF";

        public string OFFText {
            get { return _OFFText; }
            set {
                if (value == _OFFText) return;
                _OFFText = value;
                this.Invalidate();
            }
        }

        private string _ONText = "NO";

        public string ONText {
            get { return _ONText; }
            set {
                if (_ONText == value) return;
                _ONText = value;
                this.Invalidate();
            }
        }

        private Color _OFFColor = Color.Gray;

        public Color OFFColor {
            get { return _OFFColor; }
            set {
                if (_OFFColor == value) return;
                _OFFColor = value;
                this.Invalidate();
            }
        }

        private Color _ONColor = Color.DodgerBlue;

        public Color ONColor {
            get { return _ONColor; }
            set {
                if (_ONColor == value) return;
                _ONColor = value;
                this.Invalidate();
            }
        }

        protected override void OnClick(EventArgs e) {
            this._IsON = !this._IsON;
            this.Invalidate();
            this.OnSwitchChanged(EventArgs.Empty);
            base.OnClick(e);
        }

        public event EventHandler SwitchChanged;

        protected virtual void OnSwitchChanged(EventArgs e) {
            if (this.SwitchChanged != null) this.SwitchChanged(this, e);
        }

        protected override void OnMouseDown(MouseEventArgs e) {
            this.Focus();
            base.OnMouseDown(e);
        }

        protected override void OnPaint(PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            using (SolidBrush sb = new SolidBrush(this._IsON ? this._ONColor : this._OFFColor)) {
                g.FillPath(
                    sb,
                    RenderHelper.CreateRoundedRectanglePath(new Rectangle(0, 2, this.Width - 1, this.Height - 5), 5)
                    );
            }
            using (LinearGradientBrush lgb = new LinearGradientBrush(
                new Point(0, 2), new Point(0, this.Height - 3),
                Color.FromArgb(60, 0, 0, 0), Color.FromArgb(125, 255, 255, 255))) {
                g.DrawPath(
                    new Pen(lgb),
                    RenderHelper.CreateRoundedRectanglePath(new Rectangle(0, 3, this.Width - 1, this.Height - 6), 5)
                    );
            }
            using (LinearGradientBrush lgb = new LinearGradientBrush(
               new Point(0, 2), new Point(0, this.Height - 3),
               Color.FromArgb(100, 0, 0, 0), Color.Transparent)) {
                g.DrawPath(
                    new Pen(lgb),
                    RenderHelper.CreateRoundedRectanglePath(new Rectangle(0, 2, this.Width - 1, this.Height - 6), 5)
                    );
            }

            using (SolidBrush sb = new SolidBrush(this.ForeColor)) {
                g.DrawString(this._IsON ? this._ONText : this._OFFText, this.Font, sb, new Rectangle(this._IsON ? 1 : 26, 3, this.Width - 27, this.Height - 6), sf);
            }
            //==============
            int nLeft = this._IsON ? this.Width - 26 : 0;
            using (LinearGradientBrush lgb = new LinearGradientBrush(
                new Point(0, 1), new Point(0, this.Height),
                Color.White, Color.FromArgb(60, 60, 60))) {
                g.DrawPath(
                    new Pen(lgb),
                    RenderHelper.CreateRoundedRectanglePath(new Rectangle(nLeft, 1, 25, this.Height - 2), 5)
                    );
            }
            using (LinearGradientBrush lgb = new LinearGradientBrush(
                new Point(0, 1), new Point(0, this.Height),
                Color.FromArgb(255, 255, 255), Color.FromArgb(240, 240, 240))) {
                g.FillPath(
                    lgb,
                    RenderHelper.CreateRoundedRectanglePath(new Rectangle(nLeft, 1, 25, this.Height - 2), 5)
                    );
            }
            using (LinearGradientBrush lgb = new LinearGradientBrush(
               new Point(0, 0), new Point(0, this.Height - 1),
               Color.FromArgb(200, 200, 200), Color.FromArgb(127, 127, 127))) {

                g.DrawPath(
                    new Pen(lgb),
                    RenderHelper.CreateRoundedRectanglePath(new Rectangle(nLeft, 0, 25, this.Height - 2), 5)
                    );
            }
            base.OnPaint(e);
        }
    }
}
