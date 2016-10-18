using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTest
{
    class Util
    {
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
        #region 添加复制Cell菜单
        public static void CreateCopyCellItem(GridView View)
        {
            View.PopupMenuShowing += new PopupMenuShowingEventHandler(Create_CopyCellItem);
        }

        static void Create_CopyCellItem(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == GridMenuType.Row)
            {
                if (e.HitInfo.InRow)
                {
                    GridView view = (GridView)sender;
                    view.FocusedRowHandle = e.HitInfo.RowHandle;
                    e.Menu.Items.Add(CreateCopyCellMenuItem(e.HitInfo.Column));
                  //  e.Menu.Items.Add(CreateCopyRowMenuItem(view.GetDataRow(e.HitInfo.RowHandle)));
                }
            }
        }

        static DXMenuItem CreateCopyCellMenuItem(GridColumn column)
        {
            //DXMenuItem copyItem = new DXMenuItem("复制 [" + column.Caption+"]",
            //    new EventHandler(OnCopyCellClick), null);
            DXMenuItem copyItem = new DXMenuItem("复制单元格",
               new EventHandler(OnCopyCellClick), null);
            copyItem.Tag = column;
            return copyItem;

        }
        static DXMenuItem CreateCopyRowMenuItem(DataRow Row)
        {
            DXMenuItem copyRow = new DXMenuItem("复制整行",
                new EventHandler(OnCopyRowClick), null);
            copyRow.Tag = Row;
            return copyRow;

        }

        static void OnCopyCellClick(object sender, EventArgs e)
        {
            GridColumn col = (GridColumn)((DXMenuItem)sender).Tag;
            // string filed = col.FieldName;
            Clipboard.SetDataObject(col.View.GetRowCellDisplayText(col.View.FocusedRowHandle, col), true);
        }
        static void OnCopyRowClick(object sender, EventArgs e)
        {
            DataRow row = (DataRow)((DXMenuItem)sender).Tag;
            Clipboard.SetDataObject(row, true);
        }
        #endregion
    }
}
