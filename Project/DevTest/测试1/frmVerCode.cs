using DevExpress.XtraEditors;
using DevTest.Common;
using System;
using System.Drawing;
using System.Threading;

namespace DevTest.测试1
{
    public partial class frmVerCode : XtraFormC
    {
        private VerCoder mCodeCreator;

        private string mCodeStr;

        private int mWidth;
        private int mCharNum;
        private int mLineNum;
        private int mBrightness;

        private bool mStone;

        public frmVerCode()
        {
            InitializeComponent();
            mCodeCreator = new VerCoder();
            mCharNum = 4;
            mLineNum = 0;
            mWidth = pictureEdit1.Width;
            mBrightness = -1;
        }
        private void frmVerCode_Load(object sender, EventArgs e)
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
            pictureEdit1.Width = mCharNum > 4 ? mWidth + (Math.Abs(mCharNum - 4) * 30) : mWidth - (Math.Abs(mCharNum - 4) * 30);
            pictureEdit1.EditValue = genCodeImg(mCharNum);
        }

        private void cbxLength_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cbx = sender as ComboBoxEdit;
            mCharNum = Convert.ToInt32(cbx.EditValue);
        }
        private void cbxLineNum_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cbx = sender as ComboBoxEdit;
            mLineNum = Convert.ToInt32(cbx.EditValue);
        }

        private Image genCodeImg(int length)
        {
            mCodeCreator.Width = pictureEdit1.Width;
            mCodeCreator.Height = pictureEdit1.Height;

            mCodeStr = mCodeCreator.GetRandomString(length);

            if (mCodeStr.Length >= 4)
            {
                mCodeStr = mCodeCreator.GetRandomString(length - 1);
                Random ran = new Random();
                if (mCodeStr.Length > 0 && (mCodeStr.Length + 1) / 4 > 0)
                {
                    int l = (mCodeStr.Length + 1) / 4;
                    for (int i = 0; i < l; i++)
                    {
                        string val = Util.CreateGBChar(1);
                        mCodeStr = mCodeStr.Insert(ran.Next(0, length - 1), val);
                    }
                }
            }
            byte[] bs = mCodeCreator.CreateImage(mCodeStr);
            Bitmap org = Image.FromStream(Util.BytesToStream(bs)) as Bitmap;

            if (mLineNum > 0)
            {
                Bitmap line = mCodeCreator.DrawRandomBezier(mLineNum);
                org = mixImage(org, line, new Rectangle(0, 0, pictureEdit1.Width, pictureEdit1.Height));
            }

            org = mCodeCreator.AdjustBrightness(org, mBrightness);

            if (mStone)
                org = mCodeCreator.AdjustToStone(org);

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
            HScrollBar sb = sender as HScrollBar;
            mBrightness = sb.Value;
            labelControl5.Text = "当前亮度值:" + mBrightness;
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit chk = sender as CheckEdit;
            if (chk.EditValue != null)
                mStone = Convert.ToBoolean(chk.EditValue);
        }
    }
}
