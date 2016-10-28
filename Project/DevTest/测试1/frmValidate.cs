using DevExpress.XtraEditors;
using DevTest.Common;
using System;
using System.Drawing;

namespace DevTest.测试1
{
    public partial class frmValidate : XtraFormC
    {
        private VCode mCodeCreator;

        private string mCodeStr;

        private int mWidth;
        private int mCharNum;
        private int mLineNum;
        private int mBrightness;



        public frmValidate()
        {
            InitializeComponent();
            mCodeCreator = new VCode();
            mCharNum = 4;
            mLineNum = 0;
            mWidth = pictureEdit1.Width;
            mBrightness = -1;
        }
        private void frmValidate_Load(object sender, EventArgs e)
        {
            cbxLength.SelectedIndex = 3;
            cbxLineNum.SelectedIndex = 0;
            hScrollBar1.Value = 0;
            pictureEdit1.EditValue = genCodeImg(mCharNum);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (textEdit1.EditValue != null &&
                textEdit1.EditValue.ToString().Equals(mCodeStr, StringComparison.OrdinalIgnoreCase))
                textEdit1.ErrorText = null;
            else
            {
                textEdit1.ErrorText = "验证码错误!";
                textEdit1.Focus();
            }
        }

        private void labelChange_Click(object sender, EventArgs e)
        {
            pictureEdit1.Width = mCharNum > 4 ? mWidth + (Math.Abs(mCharNum - 4) * 28) : mWidth - (Math.Abs(mCharNum - 4) * 28);
            pictureEdit1.EditValue = genCodeImg(mCharNum);
        }

        private void cbxLength_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cbx = (sender as ComboBoxEdit);
            mCharNum = Convert.ToInt32(cbx.EditValue);
        }
        private void cbxLineNum_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cbx = (sender as ComboBoxEdit);
            mLineNum = Convert.ToInt32(cbx.EditValue);
        }

        private Image genCodeImg(int length)
        {
            mCodeCreator.Width = pictureEdit1.Width;
            mCodeCreator.Height = pictureEdit1.Height;

            mCodeStr = mCodeCreator.GetRandomString(length);

            byte[] bs = mCodeCreator.CreateImage(mCodeStr);
            Bitmap org = Image.FromStream(Util.bytesToStream(bs)) as Bitmap;

            if (mLineNum > 0)
            {
                Bitmap line = mCodeCreator.DrawRandomBezier(mLineNum);
                org = mixImage(org, line, new Rectangle(0, 0, pictureEdit1.Width, pictureEdit1.Height));
            }

            org = mCodeCreator.AdjustBrightness(org, mBrightness);

            //  org = mCodeCreator.AdjustGamma(org, 100, 100, 100);

            org=mCodeCreator.AdjustRippleEffect(org,50);

            return org;
        }
        public Bitmap mixImage(Bitmap sourceBmp, Bitmap addedBitmap, Rectangle rc)
        {
            Bitmap temp = sourceBmp;
            using (Graphics g = Graphics.FromImage(temp))
            {
                g.DrawImage(addedBitmap, 0, 0, new RectangleF(rc.Left, rc.Top, rc.Width, rc.Height), GraphicsUnit.Pixel);
            }
            return temp;
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            HScrollBar sb = (sender as HScrollBar);
            mBrightness= sb.Value;
            labelControl5.Text ="当前亮度值:"+mBrightness;
        }

        private void hScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            HScrollBar sb = (sender as HScrollBar);
            string a=Convert.ToString(sb.Value,16);
            textEdit1.Text = a;
        }
    }
}
