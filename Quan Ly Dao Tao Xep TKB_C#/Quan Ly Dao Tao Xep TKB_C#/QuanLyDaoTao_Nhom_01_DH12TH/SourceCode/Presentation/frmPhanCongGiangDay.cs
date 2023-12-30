using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.Business;
using QuanLyDaoTao.DataAccess;
using System.Windows.Forms;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmPhanCongGiangDay : XtraForm
    {
        LogFile log;
        public frmPhanCongGiangDay()
        {
            InitializeComponent();
            log = new LogFile();
        }

        private void LoadSourceGridControl()
        {
            try
            {
                gridControl1.DataSource = PhanCongBUS.DanhSachTuyChinh();
                gridView1.ExpandAllGroups();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmPhanCongGiangDay_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaPC.Text = PhanCongBUS.SinhMa();

                cmbGiangVien.Properties.DataSource = GiangVienBUS.DanhSachTuyChinh();
                cmbGiangVien.EditValue = cmbGiangVien.Properties.GetDataSourceValue("MaGV", 0);
                
                cmbMonHoc.Properties.DataSource = MonHocBUS.DanhSachTuyChinh();
                cmbMonHoc.EditValue = cmbMonHoc.Properties.GetDataSourceValue("MaMH", 0);
                
                cmbLop.Properties.DataSource = LopBUS.DanhSachTuyChinh();
                cmbLop.EditValue = cmbLop.Properties.GetDataSourceValue("MaLop", 0);

                LoadSourceGridControl();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                PhanCong pc = new PhanCong()
                {
                    MaPC = txtMaPC.Text,
                    MaGV = cmbGiangVien.EditValue.ToString(),
                    MaLop = cmbLop.EditValue.ToString(),
                    MaMH = cmbMonHoc.EditValue.ToString(),
                    NamHoc = dateNamHoc.DateTime.Year,
                    HocKy = (byte)numHocKy.Value
                };
                if (!PhanCongBUS.KiemTraTonTai(pc))
                {
                    PhanCongBUS.Them(pc);
                    StaticClass.LuuThayDoi();
                    log.GhiFile("Thêm phân công giảng dạy: " + pc.MaPC);
                    LoadSourceGridControl();
                    txtMaPC.Text = PhanCongBUS.SinhMa();
                }
                else
                    MsgboxUtil.Exclamation("Đã tồn tại một phân công y hệt như thế này rồi. Vui lòng kiểm tra lại");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void toolStripMenuXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int[] i = gridView1.GetSelectedRows();
                string maPC = gridView1.GetRowCellDisplayText(i[0], "MaPC");
                if (MsgboxUtil.YesNo("Bạn chắc chắn muốn xóa phân công " + maPC + "?") == DialogResult.Yes)
                {
                    if (i.Length > 0)
                    {
                        gridView1.DeleteRow(i[0]);
                        PhanCongBUS.Xoa(maPC);
                        StaticClass.LuuThayDoi();
                        log.GhiFile("Xóa phân công giảng dạy: " + maPC);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}