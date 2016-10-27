using DevTest.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTest
{
    public partial class frmPrintScreen : XtraFormC
    {

        public frmPrintScreen()
        {
            InitializeComponent();
        }
        private SaveFileDialog sfd;
        private void frm截屏_Load(object sender, EventArgs e)
        {
            sfd = new SaveFileDialog() { FileName = "Test.jpg", Filter = @"所有类型|*.*|jpeg|*.jpg|bmp|*.bmp|png|*.png" };
        }
        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(image);
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.CopyFromScreen(0, 0, 0, 0, new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));
            SaveImage(image);
        }
        private void SaveImage(Image image)
        {
            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                image.Save(sfd.FileName);
            }
        }
        private void btnTestPtScreen_Click(object sender, EventArgs e)
        {
            StartCapture(true);
        }
        private FrmCapture m_frmCapture;
        private void StartCapture(bool bFromClip)
        {//源码http://blog.csdn.net/crystal_lz/article/details/51737713
            if (m_frmCapture == null || m_frmCapture.IsDisposed)
                m_frmCapture = new FrmCapture(true, false);//是否捕获鼠标
            m_frmCapture.Show();
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            FromHwndHwnd(null);
        }
        private void FromHwndHwnd(PaintEventArgs e)
        {
            // Get handle to form.
            IntPtr hwnd = this.Handle;
            // Create new graphics object using handle to window.
            Graphics newGraphics = Graphics.FromHwnd(hwnd);
            // Draw rectangle to screen.
            newGraphics.DrawRectangle(new Pen(Color.Red, 3), simpleButton4.Location.X+ simpleButton4.Width, simpleButton4.Location.Y+ simpleButton4.Width, 200, 100);
            // Dispose of new graphics.
            newGraphics.Dispose();
        }
    }
}
