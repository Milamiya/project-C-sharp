using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class GiaoVienController
    {
        #region Data
        private GiaoVienData m_Data;

        public GiaoVienData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }
        #endregion

        public GiaoVienController()
        {
            this.Data = new GiaoVienData();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="txtMaGiaoVien"></param>
        /// <param name="txtHoTen"></param>
        /// <param name="dpNgaySinh"></param>
        /// <param name="cbxGioiTinh"></param>
        /// <param name="cmbChuyenMon"></param>
        /// <param name="txtDienThoai"></param>
        /// <param name="txtNoiSinh"></param>
        /// <param name="txtDiaChi"></param>
        /// <param name="dg"></param>
        /// <param name="bn"></param>
        public void HienThiDS( DataGridView dgvDS, BindingNavigator bnDS, TextBox txtMaGiaoVien, TextBox txtHoTen, DateTimePicker dpNgaySinh, CheckBox cbxGioiTinh, ComboBox cmbMonHoc, TextBox txtDienThoai, TextBox txtNoiSinh, TextBox txtDiaChi)
        {
            if (this.Data == null)
            {
                this.Data = new GiaoVienData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS();
            bnDS.BindingSource = bs;
            dgvDS.DataSource = bs;
            txtMaGiaoVien.DataBindings.Add("Text", bs, "MaGiaoVien");
            txtHoTen.DataBindings.Add("Text", bs, "HoTen");
            dpNgaySinh.DataBindings.Add("Text", bs, "NgaySinh");
            cbxGioiTinh.DataBindings.Add("Checked", bs, "GioiTinh");
            cmbMonHoc.DataBindings.Add("SelectedValue", bs, "MaMonHoc");
            txtDienThoai.DataBindings.Add("Text", bs, "DienThoai");
            txtNoiSinh.DataBindings.Add("Text", bs, "NoiSinh");
            txtDiaChi.DataBindings.Add("Text", bs, "DiaChi");
        }

        public void HienThiDS(DataGridView dg, BindingNavigator bn)
        {
            if (this.Data == null)
            {
                this.Data = new GiaoVienData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS();
            bn.BindingSource = bs;
            dg.DataSource = bs;

            ////them cot MON_HOC Vao bang giao vien

            //MonHocController monHocCtrl = new MonHocController();
            //dg.Columns.Add(monHocCtrl.LoadComboBoxColumn());

        }

        public void HienThiDS(DataGridView dg)
        {
            if (this.Data == null)
            {
                this.Data = new GiaoVienData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS();
            dg.DataSource = bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        public void HienThiDataGridComboBoxColumn(DataGridViewComboBoxColumn col)
        {
            if (this.Data == null)
            {
                this.Data = new GiaoVienData();
            }
            col.DataSource = this.Data.LayDS();
            col.DisplayMember = "HoTen";
            col.ValueMember = "MaGiaoVien";
            col.DataPropertyName = "MaGiaoVien";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmb"></param>
        public void HienThiComboBox(ComboBox cmb)
        {
            if (this.Data == null)
            {
                this.Data = new GiaoVienData();
            }
            cmb.DataSource = this.Data.LayDS();
            cmb.DisplayMember = "HoTen";
            cmb.ValueMember = "MaGiaoVien";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        /// <param name="monHocInfo"></param>
        public void HienThiDataGridComboBoxColumn(DataGridViewComboBoxColumn col, MonHocInfo monHocInfo)
        {
            if (this.Data == null)
            {
                this.Data = new GiaoVienData();
            }
            col.DataSource = this.Data.LayDS(monHocInfo);
            col.DisplayMember = "HoTen";
            col.ValueMember = "MaGiaoVien";
            col.DataPropertyName = "MaGiaoVien";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="monHocInfo"></param>
        public void HienThiComboBox(ComboBox cmb, MonHocInfo monHocInfo)
        {
            if (this.Data == null)
            {
                this.Data = new GiaoVienData();
            }
            cmb.DataSource = this.Data.LayDS(monHocInfo);
            cmb.DisplayMember = "HoTen";
            cmb.ValueMember = "MaGiaoVien";
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="bn"></param>
        /// <param name="tengv"></param>
        public void TimTheoTen(DataGridView dg, BindingNavigator bn, String tengv)
        {
            if (this.Data == null)
            {
                this.Data = new GiaoVienData();
            }
            BindingSource bs = new BindingSource();
            DataTable tbl = this.Data.TimTheoTen(tengv);
            bs.DataSource = tbl;
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maGiaoVien"></param>
        /// <returns></returns>
        public GiaoVienInfo LayTuMa(string maGiaoVien)
        {
            if (this.Data == null)
            {
                this.Data = new GiaoVienData();
            }
            DataTable table = this.Data.LayTuMa(maGiaoVien);
            if (table.Rows.Count > 0)
            {
                GiaoVienInfo info = new GiaoVienInfo();
                info.MaGiaoVien = table.Rows[0]["MaGiaoVien"].ToString();
                info.HoTen = table.Rows[0]["HoTen"].ToString();
                info.GioiTinh = (bool)table.Rows[0]["GioiTinh"];
                info.NgaySinh = (DateTime)table.Rows[0]["NgaySinh"];
                info.NoiSinh = table.Rows[0]["NoiSinh"].ToString();
                info.DiaChi = table.Rows[0]["DiaChi"].ToString();
                info.DienThoai = table.Rows[0]["DienThoai"].ToString();
                return info;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Update()
        {
            return this.Data.Update();
        }

        /// <summary>
        /// 
        /// </summary>
        public string LayMaCuoi()
        {
            if (this.Data == null)
            {
                this.Data = new GiaoVienData();
            }
            return Convert.ToString(this.Data.LayMaCuoi());
        }
    }
}
