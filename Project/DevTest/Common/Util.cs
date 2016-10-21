using DevExpress.Utils.Menu;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DevTest
{
    class Util
    {
        public static HashSet<string> childs= new HashSet<string>();
        public static bool IsDecimal(string str)
        {
            if (str != null && str.Equals("0"))
            {
                str = Convert.ToDecimal(0).ToString("F2");
                return true;
            }
            decimal d;
            Decimal.TryParse(str, out d);
            if (d == 0)
                return false;
            return true;
        }
        public static bool IsInt(string str)
        {
            int i;
            Int32.TryParse(str, out i);
            if (i == 0)
                return false;
            return true;
        }
        public static bool IsNumber(string str)
        {
            if (str == null || str.Length == 0)    //验证这个参数是否为空  
                return false;                           //是，就返回False  
            ASCIIEncoding ascii = new ASCIIEncoding();//new ASCIIEncoding 的实例  
            byte[] bytestr = ascii.GetBytes(str);         //把string类型的参数保存到数组里  

            foreach (byte c in bytestr)                   //遍历这个数组里的内容  
            {
                if (c < 48 || c > 57)                          //判断是否为数字  
                {
                    return false;                              //不是，就返回False  
                }
            }
            return true;                                        //是，就返回True  
        }

        #region 导出Pdf
        public static void createExportToPdfItem(GridView gv)
        {
            gv.PopupMenuShowing += new PopupMenuShowingEventHandler(popupMenuShowingEventHandler_Pdf);
        }
        private static void popupMenuShowingEventHandler_Pdf(object sender,PopupMenuShowingEventArgs e)
        {
            if (e.MenuType==GridMenuType.Row&&e.HitInfo.InRow)
            {
                DXMenuItem item = new DXMenuItem("导出PDF",new EventHandler(exportPdfClickEventHandler),null);
                item.Tag = ((GridView)sender).GridControl;
                e.Menu.Items.Add(item);
            }
        }
        private static void exportPdfClickEventHandler(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "导出PDF文件";
            dialog.Filter = "PDF文件(*.pdf)|*.pdf";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ((GridControl)((DXMenuItem)(sender)).Tag).ExportToPdf(dialog.FileName);
                TipForm.getInstance().showShort("导出成功！", 800);
            }
        }

        #endregion

        #region 导出Excel
        public static void createExportToExcelItem(GridView gv)
        {
            gv.PopupMenuShowing += new PopupMenuShowingEventHandler(popupMenuShowingEventHandler_Excel);
        }
        private static void popupMenuShowingEventHandler_Excel(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row && e.HitInfo.InRow)
            {
                DXMenuItem excel = new DXMenuItem("导出Excel", new EventHandler(exportExcelClickEventHandler), null);
                GridView view = (GridView)sender;
                excel.Tag = view.GridControl;
                view.FocusedRowHandle = e.HitInfo.RowHandle;
                e.Menu.Items.Add(excel);
            }

        }
        private static void exportExcelClickEventHandler(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "导出Excel表格";
            save.Filter = "Excel文件(*.xls)|*.xls";
            if (save.ShowDialog() == DialogResult.OK)
            {
                DevExpress.XtraPrinting.XlsExportOptions option = new DevExpress.XtraPrinting.XlsExportOptions();
                ((GridControl)(((DXMenuItem)sender).Tag)).ExportToXls(save.FileName,option);
                TipForm.getInstance().showShort("导出成功！", 800);
            }
        }
        #endregion

        #region 复制单元格
        public static void createCopyCellItem(GridView gv)
        {
            gv.PopupMenuShowing += new PopupMenuShowingEventHandler(popupMenuShowingEventHandler_Copy);
        }
        private static void popupMenuShowingEventHandler_Copy(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == GridMenuType.Row && e.HitInfo.InRow)
            {
                GridView view = (GridView)sender;
                view.FocusedRowHandle = e.HitInfo.RowHandle;
                DXMenuItem copyItem = new DXMenuItem("复制单元格", new EventHandler(OnCopyCellClick), null);
                copyItem.Tag = e.HitInfo.Column;
                e.Menu.Items.Add((copyItem));
            }
        }
        private static void OnCopyCellClick(object sender, EventArgs e)
        {
            GridColumn col = (GridColumn)((DXMenuItem)sender).Tag;
            Clipboard.SetDataObject(col.View.GetRowCellDisplayText(col.View.FocusedRowHandle, col), true);
            TipForm.getInstance().showShort("导出成功！", 800);
        }
        #endregion
        private static void quick_sort(int[] s, int l, int r)
        {
            if (l < r)
            {
                //Swap(s[l], s[(l + r) / 2]); //将中间的这个数和第一个数交换 参见注1  
                int i = l, j = r, x = s[l];
                while (i < j)
                {
                    while (i < j && s[j] >= x) // 从右向左找第一个小于x的数  
                        j--;
                    if (i < j)
                        s[i++] = s[j];

                    while (i < j && s[i] < x) // 从左向右找第一个大于等于x的数  
                        i++;
                    if (i < j)
                        s[j--] = s[i];
                }
                s[i] = x;
                quick_sort(s, l, i - 1); // 递归调用   
                quick_sort(s, i + 1, r);
            }
        }
        public static void quickSort(int[] s)
        {
            quick_sort(s, 0, s.Length - 1);
        }

        /// <summary>
        /// ImageName->img文件夹内的图片
        /// </summary>
        public static Bitmap getImage(string picName)
        {
            FileStream fs = File.OpenRead(Application.StartupPath.Replace("\\bin\\Debug", "\\img\\weather\\"+picName)); //OpenRead
            int filelength = 0;
            filelength = (int)fs.Length; //获得文件长度 
            Byte[] image = new Byte[filelength]; //建立一个字节数组 
            fs.Read(image, 0, filelength); //按字节流读取 
            System.Drawing.Image result = System.Drawing.Image.FromStream(fs);
            fs.Close();
            Bitmap bit = new Bitmap(result);
            return bit;
        }
    }
}
