using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevTest
{
    public partial class TipForm : Form
    {

        private Label label1;
        private Timer timer1;
        private Timer timer2;
        private Timer timer3;
        private static TipForm f = null;
        private int waitime = 0;
        private int time = 0;
        public TipForm()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(93, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "执行成功!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.BR_timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.MID_timer_MouseLeave_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 30;
            this.timer3.Tick += new System.EventHandler(this.MID_timer_MouseEnter_Tick);
            // 
            // TipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(93, 40);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TipForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);

        }
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
        public static TipForm getInstance()
        {
            if (f == null || f.IsDisposed)
                f = new TipForm();
            return f;
        }

        /// <summary>
        /// 在右下角显示
        /// </summary>
        public void longTip(string text, int d)
        {
            this.Width = 200;
            this.Height = 80;
            timer2.Enabled = false;
            timer3.Enabled = false;
            Point p = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.PointToClient(p);
            this.Location = p;
            this.waitime = d;
            this.label1.Text = text;
            this.Show();
            for (int i = 0; i < this.Height; i++)
            {
                this.Location = new Point(p.X, p.Y - i);
                System.Threading.Thread.Sleep(10);
            }
        }
        /// <summary>
        /// 在中间显示
        /// </summary>
        public void showShort(int d)
        {
            label1.Text = "执行成功！";
            this.Width = 120;
            this.Width = 40;
            timer1.Enabled = false;
            this.waitime = d;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Show();
        }
        public void shortTip(string text,int d)
        {
            this.Width = 120;
            this.Width = 40;
            label1.Text = text;
            timer1.Enabled = false;
            this.waitime = d;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Show();
        }
        private void BR_timer1_Tick(object sender, EventArgs e)
        {
            if (time == 0)
            {
                time++;
                System.Threading.Thread.Sleep(waitime);
            }
            timer1.Enabled = false;
            for (int i = 0; i <= this.Height; i++)
            {
                Point p = new Point(this.Location.X, this.Location.Y + i);//弹出框向下移动消失
                this.PointToScreen(p);
                this.Location = p;
                System.Threading.Thread.Sleep(60);//时间越小向下消失的速度越快。
            }
            this.Close();
            this.Dispose();
        }

        private void MID_timer_MouseLeave_Tick(object sender, EventArgs e)
        {
            if (time == 0)
            {
                time++;
                System.Threading.Thread.Sleep(waitime);
            }
            timer3.Enabled = false;//停止timer3计时器，
            if (this.Opacity != 0)//开始执行弹出窗渐渐透明
            {
                this.Opacity = this.Opacity - 0.04;
            }
            if (Control.MousePosition.X >= this.Location.X && Control.MousePosition.X <= (this.Location.X + this.Width)
                && Control.MousePosition.Y >= this.Location.Y && Control.MousePosition.Y <= (this.Location.Y + this.Height))
            {
                timer3.Enabled = true;//如果鼠标在弹出窗上的时候，timer3开始工作
                timer1.Enabled = false;//timer2停止工作。
            }
            if (this.Opacity <= 0)
            {
                this.Close();
                this.Dispose();
                timer2.Enabled = false;
                timer3.Enabled = false;
            }
        }

        private void MID_timer_MouseEnter_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            this.Opacity = 1;
            if (Control.MousePosition.Y > (this.Location.Y + this.Height) || Control.MousePosition.X > (this.Location.X + this.Width) || Control.MousePosition.X < this.Location.X || Control.MousePosition.Y < this.Location.Y)//如下
            {
                timer2.Enabled = true;
                timer3.Enabled = false;
            }
        }

    }
}
