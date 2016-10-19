using DevExpress.XtraEditors;
using System.Windows.Forms;
using SourceGrid;
using System;
using System.IO;
using System.Reflection;
using DevAge.Drawing;
using System.Drawing;

namespace DevTest
{
    public partial class frmSG : XtraForm
    {
        public frmSG()
        {
            InitializeComponent();
        }

        //Editors
        private SourceGrid.Cells.Editors.EditorBase mEditor_Id;
        private SourceGrid.Cells.Editors.EditorBase mEditor_Name;
        private SourceGrid.Cells.Editors.EditorBase mEditor_Address;
        private SourceGrid.Cells.Editors.EditorBase mEditor_City;
        private SourceGrid.Cells.Editors.EditorBase mEditor_Birthday;
        private SourceGrid.Cells.Editors.EditorBase mEditor_Country;
        private SourceGrid.Cells.Editors.EditorBase mEditor_Price;

        private SourceGrid.Cells.Views.Cell mView_Content;
        private SourceGrid.Cells.Views.Cell mView_Header;
        private SourceGrid.Cells.Views.Cell mView_Header_0;

        private SourceGrid.Cells.Controllers.Button mController_Link;

        private void frmSG_Load(object sender, System.EventArgs e)
        {
            string[] countryList = new string[] { "意大利", "法国", "西班牙", "英国", "阿根廷", "墨西哥", "瑞士", "巴西", "德国", "葡萄牙", "瑞典", "澳大利亚" };
            grid1.RowsCount = 1;
            grid1.ColumnsCount = 10;
            grid1.FixedRows = 1;
            grid1.FixedColumns = 1;
            grid1.SelectionMode = SourceGrid.GridSelectionMode.Row;
            grid1.AutoStretchColumnsToFitWidth = true;
            grid1.Columns[0].AutoSizeMode = SourceGrid.AutoSizeMode.None;
            grid1.Columns[0].Width = 25;
            grid1.Controller.AddController(new keyDeleteController());

            mView_Content = new SourceGrid.Cells.Views.Cell();
            mView_Content.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;

            mView_Header_0 = new SourceGrid.Cells.Views.Cell();
            mView_Header_0.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            mView_Header_0.Font = new Font("幼圆", 12);
            BorderLine boderT_0 = new BorderLine();
            BorderLine boderB_0 = new BorderLine();
            BorderLine boderL_0 = new BorderLine();
            BorderLine boderR_0 = new BorderLine(Color.BlueViolet);
            boderR_0.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            RectangleBorder headBoder_0 = new RectangleBorder(boderT_0, boderB_0, boderL_0, boderR_0);
            mView_Header_0.Border = headBoder_0;

            mView_Header = new SourceGrid.Cells.Views.Cell();
            mView_Header.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            mView_Header.Font = new Font("幼圆", 12);
            BorderLine boderT = new BorderLine(Color.BlueViolet);
            boderT.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            BorderLine boderB = new BorderLine(Color.BlueViolet);
            boderB.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            BorderLine boderL = new BorderLine(Color.BlueViolet);
            boderL.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            BorderLine boderR = new BorderLine(Color.BlueViolet);
            boderR.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            RectangleBorder headBoder = new RectangleBorder(boderT, boderB, boderL, boderR);
            mView_Header.Border = headBoder;



            mController_Link = new SourceGrid.Cells.Controllers.Button();
            mController_Link.Executed += new System.EventHandler(mController_Link_Click);

            SourceGrid.Cells.Header header = new SourceGrid.Cells.Header(null);
            grid1[0, 0] = header;
            grid1[0, 0].View = mView_Header_0;

            mEditor_Id = SourceGrid.Cells.Editors.Factory.Create(typeof(int));
            mEditor_Id.EditableMode = SourceGrid.EditableMode.Focus | EditableMode.AnyKey | EditableMode.SingleClick;
            grid1[0, 1] = new SourceGrid.Cells.Header("编号");
            grid1[0, 1].View = mView_Header;

            mEditor_Name = SourceGrid.Cells.Editors.Factory.Create(typeof(string));
            mEditor_Name.EditableMode = SourceGrid.EditableMode.Focus | EditableMode.AnyKey | EditableMode.SingleClick;
            grid1[0, 2] = new SourceGrid.Cells.Header("姓名");
            grid1[0, 2].View = mView_Header;

            mEditor_Address = SourceGrid.Cells.Editors.Factory.Create(typeof(string));
            mEditor_Address.EditableMode = SourceGrid.EditableMode.Focus | EditableMode.AnyKey | EditableMode.SingleClick;
            grid1[0, 3] = new SourceGrid.Cells.Header("地址");
            grid1[0, 3].View = mView_Header;

            mEditor_City = SourceGrid.Cells.Editors.Factory.Create(typeof(string));
            mEditor_City.EditableMode = SourceGrid.EditableMode.Focus | EditableMode.AnyKey | EditableMode.SingleClick;
            grid1[0, 4] = new SourceGrid.Cells.Header("城市");
            grid1[0, 4].View = mView_Header;

            mEditor_Birthday = SourceGrid.Cells.Editors.Factory.Create(typeof(DateTime));
            mEditor_Birthday.EditableMode = SourceGrid.EditableMode.Focus | EditableMode.AnyKey | EditableMode.SingleClick;
            grid1[0, 5] = new SourceGrid.Cells.Header("出生日期");
            grid1[0, 5].View = mView_Header;

            mEditor_Country = new SourceGrid.Cells.Editors.ComboBox(typeof(string), countryList, false);
            mEditor_Country.EditableMode = EditableMode.Focus | EditableMode.AnyKey | EditableMode.SingleClick;
            grid1[0, 6] = new SourceGrid.Cells.Header("国家");
            grid1[0, 6].View = mView_Header;

            mEditor_Price = new SourceGrid.Cells.Editors.TextBoxCurrency(typeof(double));
            mEditor_Price.EditableMode = EditableMode.Focus | EditableMode.AnyKey | EditableMode.SingleClick;
            grid1[0, 7] = new SourceGrid.Cells.Header("价格($)");
            grid1[0, 7].View = mView_Header;

            grid1[0, 8] = new SourceGrid.Cells.Header("选中");
            grid1[0, 8].View = mView_Header;

            grid1[0, 9] = new SourceGrid.Cells.Header("网站");
            grid1[0, 9].View = mView_Header;

            System.IO.StreamReader reader = new System.IO.StreamReader(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevTest.Resources" + ".Data_SG.xml"));
            System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
            xmlDoc.LoadXml(reader.ReadToEnd());
            reader.Close();
            System.Xml.XmlNodeList nodes = xmlDoc.SelectNodes("/root/infoRow");
            grid1.RowsCount = nodes.Count + 1;
            int rowIndex = 1;
            foreach (System.Xml.XmlNode node in nodes)
            {
                grid1[rowIndex, 0] = new SourceGrid.Cells.RowHeader(null);
                grid1[rowIndex, 0].View = mView_Header_0;

                grid1[rowIndex, 1] = new SourceGrid.Cells.Cell(rowIndex, mEditor_Id);
                grid1[rowIndex, 1].View = mView_Content;

                grid1[rowIndex, 2] = new SourceGrid.Cells.Cell(node.Attributes["姓名"].InnerText, mEditor_Name);
                grid1[rowIndex, 2].View = mView_Content;

                grid1[rowIndex, 3] = new SourceGrid.Cells.Cell(node.Attributes["地址"].InnerText, mEditor_Address);
                grid1[rowIndex, 3].View = mView_Content;

                grid1[rowIndex, 4] = new SourceGrid.Cells.Cell(node.Attributes["城市"].InnerText, mEditor_City);
                grid1[rowIndex, 4].View = mView_Content;

                grid1[rowIndex, 5] = new SourceGrid.Cells.Cell(DateTime.Today, mEditor_Birthday);
                grid1[rowIndex, 5].View = mView_Content;

                grid1[rowIndex, 6] = new SourceGrid.Cells.Cell(node.Attributes["国家"].InnerText, mEditor_Country);
                grid1[rowIndex, 6].View = mView_Content;

                grid1[rowIndex, 7] = new SourceGrid.Cells.Cell(25.0, mEditor_Price);
                grid1[rowIndex, 7].View = mView_Content;

                grid1[rowIndex, 8] = new SourceGrid.Cells.CheckBox(null, false);

                grid1[rowIndex, 9] = new SourceGrid.Cells.Link(node.Attributes["网站"].InnerText);
                grid1[rowIndex, 9].View = mView_Content;
                grid1[rowIndex, 9].AddController(mController_Link);

                rowIndex++;
            }
            grid1.AutoSizeCells();
            chk编辑.Checked = true;
        }
        private void frmSG_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            if (frm主界面.childs.Contains(Name))
                frm主界面.childs.Remove(Name);
        }

        private void btAddRow_Click(object sender, System.EventArgs e)
        {
            int rowIndex = grid1.RowsCount;
            grid1.Rows.Insert(rowIndex);

            grid1[rowIndex, 0] = new SourceGrid.Cells.RowHeader(null);
            grid1[rowIndex, 1] = new SourceGrid.Cells.Cell(grid1.RowsCount, mEditor_Id);
            grid1[rowIndex, 2] = new SourceGrid.Cells.Cell(mEditor_Name.DefaultValue, mEditor_Name);
            grid1[rowIndex, 3] = new SourceGrid.Cells.Cell(mEditor_Address.DefaultValue, mEditor_Address);
            grid1[rowIndex, 4] = new SourceGrid.Cells.Cell(mEditor_City.DefaultValue, mEditor_City);
            grid1[rowIndex, 5] = new SourceGrid.Cells.Cell(mEditor_Birthday.DefaultValue, mEditor_Birthday);
            grid1[rowIndex, 6] = new SourceGrid.Cells.Cell(mEditor_Country.DefaultValue, mEditor_Country);
            grid1[rowIndex, 7] = new SourceGrid.Cells.Cell(25.0, mEditor_Price);
            grid1[rowIndex, 7].View = mView_Content;
            grid1[rowIndex, 8] = new SourceGrid.Cells.CheckBox(null, false);
            grid1[rowIndex, 9] = new SourceGrid.Cells.Link("http://www.baidu.com");
            grid1[rowIndex, 9].AddController(mController_Link);

            grid1.Selection.FocusRow(rowIndex);
        }

        private void btRemoveRow_Click(object sender, System.EventArgs e)
        {
            int[] selectedRowIndex = grid1.Selection.GetSelectionRegion().GetRowsIndex();
            //for(int i=0;i< selectedRowIndex.Length; i++)
            //{
            //    grid1.Rows.Remove(selectedRowIndex[i]);
            //}
            SourceGrid.RowInfo[] infos = new RowInfo[selectedRowIndex.Length];
            for (int i = 0; i < infos.Length; i++)
                infos[i] = grid1.Rows[selectedRowIndex[i]];
            foreach (SourceGrid.RowInfo info in infos)
                grid1.Rows.Remove(info.Index);
            if (grid1.RowsCount > 1)
                grid1.Selection.FocusRow(1);

        }

        private void btMoveColumn_Click(object sender, System.EventArgs e)
        {
            btAddRow.Enabled = false;
            if (grid1.ColumnsCount > 1)
                grid1.Columns.Move(grid1.ColumnsCount - 1, 1);
        }

        private void btMoveRow_Click(object sender, System.EventArgs e)
        {
            if (grid1.RowsCount > 1)
                grid1.Rows.Move(grid1.RowsCount - 1, 1);
        }

        private void btExportHTML_Click(object sender, System.EventArgs e)
        {
            try
            {
                string path = System.IO.Path.Combine("C:\\Users\\admin\\Desktop", "sg.html");
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                SourceGrid.Exporter.HTML html = new SourceGrid.Exporter.HTML(SourceGrid.Exporter.ExportHTMLMode.Default,
                    "", "", fs);
                html.Export(grid1);
                fs.Close();
                DevAge.Shell.Utilities.OpenFile(path);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "EXPORT ERROR");
            }

        }

        private void chkReadOnly_CheckedChanged(object sender, System.EventArgs e)
        {
            for (int i = 0; i < grid1.RowsCount; i++)
                for (int j = 0; j < grid1.ColumnsCount; j++)
                {
                    if (grid1[i, j].Editor != null)
                        grid1[i, j].Editor.EnableEdit = !chkReadOnly.Checked;
                }
        }

        private void chkEditOnDoubleClick_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chk编辑.Checked)
            {
                mEditor_Id.EditableMode = SourceGrid.EditableMode.F2Key | EditableMode.AnyKey | EditableMode.DoubleClick;
                mEditor_Name.EditableMode = SourceGrid.EditableMode.F2Key | EditableMode.AnyKey | EditableMode.DoubleClick;
                mEditor_Address.EditableMode = SourceGrid.EditableMode.F2Key | EditableMode.AnyKey | EditableMode.DoubleClick;
                mEditor_City.EditableMode = SourceGrid.EditableMode.F2Key | EditableMode.AnyKey | EditableMode.DoubleClick;
                mEditor_Birthday.EditableMode = SourceGrid.EditableMode.F2Key | EditableMode.AnyKey | EditableMode.DoubleClick;
                mEditor_Country.EditableMode = SourceGrid.EditableMode.F2Key | EditableMode.AnyKey | EditableMode.DoubleClick;
                mEditor_Price.EditableMode = SourceGrid.EditableMode.F2Key | EditableMode.AnyKey | EditableMode.DoubleClick;
            }
            else
            {
                mEditor_Id.EditableMode = EditableMode.Focus | EditableMode.AnyKey | EditableMode.SingleClick;
                mEditor_Name.EditableMode = EditableMode.Focus | EditableMode.AnyKey | EditableMode.SingleClick;
                mEditor_Address.EditableMode = EditableMode.Focus | EditableMode.AnyKey | EditableMode.SingleClick;
                mEditor_City.EditableMode = EditableMode.Focus | EditableMode.AnyKey | EditableMode.SingleClick;
                mEditor_Birthday.EditableMode = EditableMode.Focus | EditableMode.AnyKey | EditableMode.SingleClick;
                mEditor_Country.EditableMode = EditableMode.Focus | EditableMode.AnyKey | EditableMode.SingleClick;
                mEditor_Price.EditableMode = EditableMode.Focus | EditableMode.AnyKey | EditableMode.SingleClick;
            }
        }

        private void btExportCsv_Click(object sender, System.EventArgs e)
        {
            try
            {
                string path = System.IO.Path.Combine("C:\\Users\\admin\\Desktop", "sg.csv");
                StreamWriter writer = new StreamWriter(path, false, System.Text.Encoding.Default);
                SourceGrid.Exporter.CSV csv = new SourceGrid.Exporter.CSV();
                csv.Export(grid1, writer);
                writer.Close();
                DevAge.Shell.Utilities.OpenFile(path);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "EXPORT ERROR");
            }
        }
        private void mController_Link_Click(object sender, EventArgs e)
        {
            try
            {
                CellContext context = (CellContext)sender;
                DevAge.Shell.Utilities.OpenFile(((SourceGrid.Cells.Link)context.Cell).Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public class keyDeleteController : SourceGrid.Cells.Controllers.ControllerBase
        {
            public override void OnKeyDown(CellContext sender, KeyEventArgs e)
            {
                base.OnKeyDown(sender, e);
                if (e.KeyCode == Keys.Delete)
                {
                    Grid grid = (Grid)sender.Grid;
                    grid.Rows.Remove(sender.Position.Row);
                }
            }
        }

        private void btExportImage_Click(object sender, EventArgs e)
        {
            try
            {
                string path = System.IO.Path.Combine("C:\\Users\\admin\\Desktop", "sg.jpeg");
                SourceGrid.Exporter.Image img = new SourceGrid.Exporter.Image();
                img.Export(grid1, grid1.CompleteRange).Save(path);
                DevAge.Shell.Utilities.OpenFile(path);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "EXPORT ERROR");
            }
        }
    }
}
