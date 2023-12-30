using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using QLHS.BUS;
using QLHS.DTO;
using Util;

namespace QLHS
{
    public partial class FrmTimHocSinh : XtraForm
    {
        private readonly HocSinhBUS _hocSinhBUS;
        private readonly KhoiBUS _khoiBUS;
        private readonly LopBUS _lopBUS;
        private readonly NamHocBUS _namHocBUS;

        public FrmTimHocSinh()
        {
            InitializeComponent();
            _khoiBUS = new KhoiBUS();
            _lopBUS = new LopBUS();
            _namHocBUS = new NamHocBUS();
            _hocSinhBUS = new HocSinhBUS();
        }

        /// <summary>
        /// Cập nhật lại list lớp theo khối
        /// </summary>
        private void CapNhatListLop()
        {
            // Duyệt từng khối
            foreach (TreeListNode item in treeListSearch.Nodes)
            {
                item.Nodes.Clear();
                IEnumerable<LopDTO> listLopNode = _lopBUS.LayListLop_MaNam_MaKhoi(
                    CboUtil.GetValueItem(comboBoxEditNamHoc),
                    item.GetValue("MaKhoi").ToString()
                    );
                // add các lớp vào khối item
                foreach (LopDTO lopNode in listLopNode)
                {
                    treeListSearch.AppendNode(new object[] {lopNode.MaLop, lopNode.TenLop}, item);
                }
            }
            treeListSearch.ExpandAll(); // Expand all nodes
        }

        private AutoCompleteStringCollection Tao_Data_AutoComplete_Cbo_TenHocSinh()
        {
            DataTable tb = _hocSinhBUS.LayDT_TenHocSinh();
            var cl = new AutoCompleteStringCollection();
            foreach (DataRow rd in tb.Rows)
            {
                cl.Add(rd["TenHocSinh"].ToString());
                string[] hoten = ObjectUtil.LayHoTen(rd["TenHocSinh"].ToString());
                if (hoten[0] != "")
                    cl.Add(hoten[0]);
                if (hoten[1] != "")
                    cl.Add(hoten[1]);
                if (hoten[2] != "")
                    cl.Add(hoten[2]);
            }
            return cl;
        }

        private void frmSearchHocSinh_Load(object sender, EventArgs e)
        {
            checkEditHoTen.Checked = true;
            checkEditTatCaNam.Checked = true;
            CboUtil.SetDataSource(comboBoxEditNamHoc,
                                  _namHocBUS.LayDTNamHoc(),
                                  "MaNamHoc", "TenNamHoc", 0);
            treeListSearch.ParentFieldName = "MaKhoi";
            treeListSearch.PreviewFieldName = "TenKhoi";
            treeListSearch.DataSource = _khoiBUS.LayDT_Khoi();

            textBoxTenHocSinh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxTenHocSinh.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxTenHocSinh.AutoCompleteCustomSource = Tao_Data_AutoComplete_Cbo_TenHocSinh();

            CapNhatListLop();
            // Disable controls search
            DisableControls(false);
        }

        private void comboBoxEditNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatListLop();
        }

        private void treeListSearch_AfterCheckNode(object sender, NodeEventArgs e)
        {
            TreeListUtil.SetCheckedChildNodes(e.Node, e.Node.CheckState);
            TreeListUtil.SetCheckedParentNodes(e.Node, e.Node.CheckState);
        }

        private void radioGroupTimTrong_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enable = (radioGroupTimTrong.SelectedIndex == 0);
            checkEditTatCaNam.Enabled = enable;
        }

        private void checkEditTatCaNam_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxEditNamHoc.Enabled = !checkEditTatCaNam.Checked;
            treeListSearch.Enabled = !checkEditTatCaNam.Checked;
        }

        /// <summary>
        /// Tìm kiếm học sinh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonSearch_Click(object sender, EventArgs e)
        {
            DataTable kqTimKiemDS;
            var hsTimKiemDTO = new HocSinhTimKiemDTO
                                   {MaHocSinh = textEditMaHocSinh.Text, TenHocSinh = textBoxTenHocSinh.Text};
            //lấy giá trị của radioGioiTinh
            if (checkEditGioiTinh.Checked)
            {
                hsTimKiemDTO.GioiTinh = radioGroupGioiTinh.SelectedIndex;
            }
            else
            {
                hsTimKiemDTO.GioiTinh = -1;
            }
            if (checkEditNamSinh.Checked)
            {
                hsTimKiemDTO.NamSinhTu = Convert.ToInt32(spinEditNamSinhTu.Value);
                hsTimKiemDTO.NamSinhDen = Convert.ToInt32(spinEditNamSinhDen.Value);
            }
            else
            {
                hsTimKiemDTO.NamSinhTu = 0;
                hsTimKiemDTO.NamSinhDen = 0;
            }
            hsTimKiemDTO.Email = textEditEmail.Text;
            hsTimKiemDTO.DiaChi = textEditDiaChi.Text;

            try
            {
                if (hsTimKiemDTO.NamSinhDen < hsTimKiemDTO.NamSinhTu)
                {
                    MsgboxUtil.Error("Khoảng cách năm sinh không hợp lệ!");
                    return;
                }

                if (radioGroupTimTrong.SelectedIndex == 1) // Chi tim trong ho so hoc sinh 
                {
                    kqTimKiemDS = _hocSinhBUS.TimKiem_HocSinh_ChuaPhanLop(hsTimKiemDTO);
                }
                else
                {
                    if (checkEditTatCaNam.Checked) // Tìm trong tất cả các năm, các lớp
                    {
                        kqTimKiemDS = _hocSinhBUS.TimKiem_HocSinh(hsTimKiemDTO);
                    }
                    else // Nếu ko chọn tìm kiếm tất cả các năm => Tìm kiếm trong tất cả các lớp được checked
                    {
                        var lopCheck = new List<string>();
                        foreach (TreeListNode khoi in treeListSearch.Nodes)
                        {
                            foreach (TreeListNode lop in khoi.Nodes)
                            {
                                if (lop.Checked)
                                {
                                    lopCheck.Add(lop.GetValue("MaKhoi").ToString());
                                }
                            }
                        }
                        kqTimKiemDS = _hocSinhBUS.TimKiem_HocSinh(hsTimKiemDTO, lopCheck);
                    }
                }
            }
            catch (Exception ex)
            {
                MsgboxUtil.Error(ex);
                return;
            }
            if (kqTimKiemDS.Rows.Count == 0)
            {
                MsgboxUtil.Error("Không tìm thấy học sinh!");
            }
            gridControlSearchHocSinh.DataSource = kqTimKiemDS;
        }

        private void simpleButtonXoaDK_Click(object sender, EventArgs e)
        {
            frmSearchHocSinh_Load(sender, e);
        }

        private void menucontextXemHoSo_Click(object sender, EventArgs e)
        {
            if (gridViewSearch.FocusedRowHandle < 0)
                return;
            // Lấy form Main
            var frmMainInstance = ParentForm as FrmMain;
            // Hiển thị frmHocSinh
            if (frmMainInstance == null)
                return;
            frmMainInstance.ShowMdiChildForm<FrmHocSinh>(false);
            // Lấy instance formHocSinh
            var frmHocSinhInstance = frmMainInstance.OpenForms[typeof (FrmHocSinh)] as FrmHocSinh;
            if (frmHocSinhInstance == null)
                return;
            // Gắn các properties chuẩn bị hiển thị chi tiết hồ sơ học sinh
            frmHocSinhInstance.MaHocSinh = gridViewSearch.GetFocusedRowCellValue("MaHocSinh").ToString();
            frmHocSinhInstance.MaLop = radioGroupTimTrong.SelectedIndex == 1
                                           ? null
                                           : gridViewSearch.GetFocusedRowCellValue("MaLop").ToString();
            // Hiển thị lại thông tin học sinh
            frmHocSinhInstance.HienThiLai_FrmHocSinh_TuFormTimKiem();
        }

        private void gridViewSearch_MouseMove(object sender, MouseEventArgs e)
        {
            if (gridViewSearch.FocusedRowHandle < 0)
                return;
            MsgboxUtil.ShowTooltip(toolTipController1,
                                   "Click chuột phải lên dòng để xem chi tiết hồ sơ học sinh");
        }

        private void simpleButtonDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Ẩn hiện các control khi load form

        private bool _check;

        private void DisableControls(bool show = true)
        {
            checkEditMaHocSinh.Checked = show;
            //checkEditHoTen.Checked = show;
            checkEditGioiTinh.Checked = show;
            checkEditNamSinh.Checked = show;
            checkEditEmail.Checked = show;
            checkEditDiaChi.Checked = show;

            textEditMaHocSinh.Enabled = show;
            //textBoxTenHocSinh.Enabled = show;
            radioGroupGioiTinh.Enabled = show;
            spinEditNamSinhTu.Enabled = show;
            spinEditNamSinhDen.Enabled = show;
            textEditEmail.Enabled = show;
            textEditDiaChi.Enabled = show;
        }

        private void EnableControl(CheckEdit checkEdit, TextBox textEdit)
        {
            if (checkEdit.Checked)
                _check = true;
            else
            {
                _check = false;
                textEdit.ResetText();
            }
            textEdit.ReadOnly = !_check;
            textEdit.Enabled = _check;
        }

        private void EnableControl(CheckEdit checkEdit, TextEdit textEdit)
        {
            if (checkEdit.Checked)
                _check = true;
            else
            {
                _check = false;
                textEdit.ResetText();
            }
            textEdit.Properties.ReadOnly = !_check;
            textEdit.Enabled = _check;
        }

        private void EnableControl(CheckEdit checkEdit, RadioGroup radioGroup)
        {
            if (checkEdit.Checked)
                _check = true;
            else
            {
                _check = false;
            }
            radioGroup.Properties.ReadOnly = !_check;
            radioGroup.Enabled = _check;
        }

        #endregion

        #region Ẩn/hiện textEdit khi checked (không checked) checkEdit

        private void checkEditMaHocSinh_CheckedChanged(object sender, EventArgs e)
        {
            EnableControl(checkEditMaHocSinh, textEditMaHocSinh);
        }

        private void checkEditHoTen_CheckedChanged(object sender, EventArgs e)
        {
            EnableControl(checkEditHoTen, textBoxTenHocSinh);
        }

        private void checkEditGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            EnableControl(checkEditGioiTinh, radioGroupGioiTinh);
        }

        private void checkEditNamSinh_CheckedChanged(object sender, EventArgs e)
        {
            EnableControl(checkEditNamSinh, spinEditNamSinhTu);
            EnableControl(checkEditNamSinh, spinEditNamSinhDen);
        }

        private void checkEditEmail_CheckedChanged(object sender, EventArgs e)
        {
            EnableControl(checkEditEmail, textEditEmail);
        }

        private void checkEditDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            EnableControl(checkEditDiaChi, textEditDiaChi);
        }

        #endregion
    }
}