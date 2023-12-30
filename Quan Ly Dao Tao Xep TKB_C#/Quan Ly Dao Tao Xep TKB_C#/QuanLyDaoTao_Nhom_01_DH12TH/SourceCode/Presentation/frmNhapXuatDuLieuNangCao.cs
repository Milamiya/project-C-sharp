using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyDaoTao.Utilities;
using System.Data.SqlClient;
using System.Data;
using QuanLyDaoTao.Enums;
using QuanLyDaoTao.Business;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;
using System.Text;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmNhapXuatDuLieuNangCao : XtraForm
    {
        public frmNhapXuatDuLieuNangCao()
        {
            InitializeComponent();
        }
        string tenBang = "";

        private void frmNhapXuatDuLieuNangCao_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTables();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
        
        /// <summary>
        /// Loads list of user tables from the SQL database, and fills
        ///a ListBox control with tatble names
        /// </summary>
        private void LoadTables()
        {
            try
            {
                // Conncets to database, and selects the table names.
                SqlConnection cn = new SqlConnection(QuanLyDaoTao.Properties.Settings.Default.ConnectString);
                SqlDataAdapter da = new SqlDataAdapter("select name from dbo.sysobjects where xtype = 'U' and name <> 'dtproperties' order by name", cn);
                DataTable dt = new DataTable();

                // Fills the list to an DataTable.
                da.Fill(dt);

                // Clears the ListBox
                this.lsvTables.Items.Clear();

                // Fills the table names to the ListBox.
                // Notifies user if there is no user table in the database yet.
                if (dt.Rows.Count == 0)
                {
                    MsgboxUtil.Exclamation("Không tồn tại bất kỳ bảng nào trong CSDL: " + QuanLyDaoTao.Properties.Settings.Default.DatabaseName);
                    this.lsvTables.Items.Add("< Không tồn tại bảng nào >");
                    this.btnExportToExcel.Enabled = false;
                }
                else
                {
                    this.btnExportToExcel.Enabled = true;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i][0].ToString() != "sysdiagrams")
                            this.lsvTables.Items.Add(new ListViewItem(dt.Rows[i][0].ToString()) { ImageIndex = 0 });
                    }
                    this.lsvTables.Items[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void lsvTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //bang sinh vien
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.SinhVien.ToString())
                {
                    tenBang = "SinhVien";
                    gridControl1.DataSource = SinhVienBUS.LayDuLieu();
                    return;
                }
                //bang buoi hoc
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.BuoiHoc.ToString())
                {
                    tenBang = "BuoiHoc";
                    gridControl1.DataSource = BuoiHocBUS.LayDuLieu();
                    return;
                }
                //bang thoi khoa bieu
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.ThoiKhoaBieu.ToString())
                {
                    tenBang = "ThoiKhoaBieu";
                    gridControl1.DataSource = ThoiKhoaBieuBUS.LayDuLieu();
                    return;
                }
                //bang phong hoc
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.PhongHoc.ToString())
                {
                    tenBang = "PhongHoc";
                    gridControl1.DataSource = PhongHocBUS.LayDuLieu();
                    return;
                }
                //bang đề nghị
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.DeNghi.ToString())
                {
                    tenBang = "DeNghi";
                    gridControl1.DataSource = DeNghiBUS.LayDuLieu();
                    return;
                }
                //bang lop
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.Lop.ToString())
                {
                    tenBang = "Lop";
                    gridControl1.DataSource = LopBUS.LayDuLieu();
                    return;
                }
                //bang phan cong
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.PhanCong.ToString())
                {
                    tenBang = "PhanCong";
                    gridControl1.DataSource = PhanCongBUS.LayDuLieu();
                    return; 
                }
                //bang mon hoc
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.MonHoc.ToString())
                {
                    tenBang = "MonHoc";
                    gridControl1.DataSource = MonHocBUS.LayDuLieu();
                    return;
                }
                //bang nghanh hoc
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.NganhHoc.ToString())
                {
                    tenBang = "NganhHoc";
                    gridControl1.DataSource = NganhHocBUS.LayDuLieu();
                    return;
                }
                //bang nguoi dung
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.NguoiDung.ToString())
                {
                    tenBang = "NguoiDung";
                    gridControl1.DataSource = NguoiDungBUS.LayDuLieu();
                    return;
                }
                //bang trinh do
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.TrinhDo.ToString())
                {
                    tenBang = "TrinhDo";
                    gridControl1.DataSource = TrinhDoBUS.DanhSachTrinhDo();
                    return;
                }
                //bang giang vien
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.GiangVien.ToString())
                {
                    tenBang = "GiangVien";
                    gridControl1.DataSource = GiangVienBUS.LayDuLieu();
                    return;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int GetSelectedItemIndex()
        {
            for (int i = 0; i < lsvTables.Items.Count; i++)
            {
                if (lsvTables.Items[i].Selected) { return i; }
            }
            return 0;
        }

        private void gridControl1_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable source = (DataTable)((GridControl)sender).DataSource;
                gridView1.Columns.Clear();
                foreach (DataColumn clo in source.Columns)
                {
                    GridColumn x = new GridColumn()
                    {
                        FieldName = clo.ColumnName,
                        Caption = clo.ColumnName,
                        Visible = true
                    };
                    gridView1.Columns.Add(x);
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Excel 2007-2010 (*.xlsx)|*.xlsx|All file (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    XlsxExportOptions tuyChinh = new XlsxExportOptions()
                    {
                        SheetName = tenBang,
                        ShowGridLines = true, 
                        ExportMode = XlsxExportMode.SingleFile, 
                        TextExportMode= TextExportMode.Value
                    };

                    gridControl1.ExportToXlsx(save.FileName, tuyChinh);
                    StaticClass.Log.GhiFile("Xuất dữ liệu bảng " + tenBang + " ra file Excel: " + save.FileName);
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "CSV file (*.csv)|*.csv|All file (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    CsvExportOptions tuyChinh = new CsvExportOptions()
                    {
                        TextExportMode = TextExportMode.Value,
                        Encoding = Encoding.UTF8,
                        Separator = "#",
                    };

                    gridControl1.ExportToCsv(save.FileName, tuyChinh);
                    StaticClass.Log.GhiFile("Xuất dữ liệu ra file CSV: " + save.FileName);
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnImportFromExcel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Excel 2007-2010 (*.xlsx)|*.xlsx|All file (*.*)|*.*";
                open.Multiselect = false;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (tenBang == "SinhVien")
                    {
                        SinhVienBUS.NhapTuExcel(open.FileName);
                    }
                    this.lsvTables.Items[0].Selected = true;
                    StaticClass.Log.GhiFile("Import dữ liệu vào bảng SinhVien từ file: " + open.FileName);
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}