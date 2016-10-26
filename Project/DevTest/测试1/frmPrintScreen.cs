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

        }
    
        private void btnTest_Click(object sender, EventArgs e)
        {
        }
    }
}
