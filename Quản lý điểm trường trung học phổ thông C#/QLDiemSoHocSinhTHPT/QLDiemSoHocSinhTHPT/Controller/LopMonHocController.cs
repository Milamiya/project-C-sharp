using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class LopMonHocController
    {
        #region Data
        private LopMonHocData m_Data;

        public LopMonHocData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }
	
        #endregion

        public LopMonHocController()
        {
            this.Data = new LopMonHocData();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgvDS"></param>
        /// <param name="bnDS"></param>
        public void HienThiDS(DataGridView dgvDS, BindingNavigator bnDS)
        {
            if (this.Data == null)
            {
                this.Data = new LopMonHocData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS(false);
            bnDS.BindingSource = bs;
            dgvDS.DataSource = bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgvDS"></param>
        /// <param name="bnDS"></param>
        /// <param name="maLop"></param>
        public void HienThiDS(DataGridView dgvDS, BindingNavigator bnDS, LopInfo lopInfo)
        {
            if (this.Data == null)
            {
                this.Data = new LopMonHocData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS(lopInfo, false);
            bnDS.BindingSource = bs;
            dgvDS.DataSource = bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lvDS"></param>
        public void HienThiDS(ListView lvDS)
        {
            if (this.Data == null)
            {
                this.Data = new LopMonHocData();
            }
            DataTable table = this.Data.LayDS(false);
            lvDS.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                LopMonHocInfo info = new LopMonHocInfo();
                info.MaLopMonHoc = int.Parse(row["MaLopMonHoc"].ToString());
                LopController lopCtrl = new LopController();
                info.Lop = lopCtrl.LayTuMa(row["MaLop"].ToString());
                MonHocController monHocCtrl = new MonHocController();
                info.MonHoc = monHocCtrl.LayTuMa(row["MaMonHoc"].ToString());

                ListViewItem item = new ListViewItem();
                item.Text = info.Lop.TenLop;
                item.SubItems.Add(info.MonHoc.TenMonHoc);

                object[] tag = new object[2];
                tag[0] = info;
                tag[1] = row;

                item.Tag = tag;
                lvDS.Items.Add(item);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lvDS"></param>
        /// <param name="lopInfo"></param>
        public void HienThiDS(ListView lvDS, LopInfo lopInfo)
        {
            if (this.Data == null)
            {
                this.Data = new LopMonHocData();
            }
            DataTable table = this.Data.LayDS(lopInfo, false);
            lvDS.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                LopMonHocInfo info = new LopMonHocInfo();
                info.MaLopMonHoc = int.Parse(row["MaLopMonHoc"].ToString());
                LopController lopCtrl = new LopController();
                info.Lop = lopCtrl.LayTuMa(row["MaLop"].ToString());
                MonHocController monHocCtrl = new MonHocController();
                info.MonHoc = monHocCtrl.LayTuMa(row["MaMonHoc"].ToString());

                ListViewItem item = new ListViewItem();
                item.Text = info.MonHoc.TenMonHoc;
                item.SubItems.Add(info.Lop.TenLop);

                object[] tag = new object[2];
                tag[0] = info;
                tag[1] = row;

                item.Tag = tag;
                lvDS.Items.Add(item);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmb"></param>
        public void HienThiComboBox(ComboBox cmb)
        {
            if (this.Data == null)
            {
                this.Data = new LopMonHocData();
            }
            cmb.DataSource = this.Data.LayDS(true);
            cmb.ValueMember = "MaLopMonHoc";
            cmb.DisplayMember = "TenMonHoc";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="maLop"></param>
        public void HienThiComboBox(ComboBox cmb, LopInfo lopInfo)
        {
            if (this.Data == null)
            {
                this.Data = new LopMonHocData();
            }
            cmb.DataSource = this.Data.LayDS(lopInfo, true);
            cmb.ValueMember = "MaLopMonHoc";
            cmb.DisplayMember = "TenMonHoc";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="lopInfo"></param>
        /// <param name="giaoVien"></param>
        public void HienThiComboBox(ComboBox cmb, LopInfo lopInfo, GiaoVienInfo giaoVien)
        {
            if (this.Data == null)
            {
                this.Data = new LopMonHocData();
            }
            cmb.DataSource = this.Data.LayDS(lopInfo, giaoVien, true);
            cmb.ValueMember = "MaLopMonHoc";
            cmb.DisplayMember = "TenMonHoc";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn col)
        {
            if (this.Data == null)
            {
                this.Data = new LopMonHocData();
            }
            col.DataSource = this.Data.LayDS(true);
            col.ValueMember = "MaLopMonHoc";
            col.DisplayMember = "TenMonHoc";
            col.DataPropertyName = "MaLopMonHoc";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="maLop"></param>
        public void HienThiComboBoxDSChuaPhanCong(ComboBox cmb, string maLop)
        {
            if (this.Data == null)
            {
                this.Data = new LopMonHocData();
            }
            cmb.DataSource = this.Data.LayDSChuaPhanCong(maLop);
            cmb.ValueMember = "MaLopMonHoc";
            cmb.DisplayMember = "TenMonHoc";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        /// <param name="maLop"></param>
        public void HienThiDataGridViewComboBoxColumnDSChuaPhanCong(DataGridViewComboBoxColumn col, string maLop)
        {
            if (this.Data == null)
            {
                this.Data = new LopMonHocData();
            }
            col.DataSource = this.Data.LayDSChuaPhanCong(maLop);
            col.ValueMember = "MaLopMonHoc";
            col.DisplayMember = "TenMonHoc";
            col.DataPropertyName = "MaLopMonHoc";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maLopMonHoc"></param>
        /// <returns></returns>
        public LopMonHocInfo LayTuMa(int maLopMonHoc)
        {
            if (this.Data == null)
            {
                this.Data = new LopMonHocData();
            }
            DataTable table = this.Data.LayTuMa(maLopMonHoc);
            if (table.Rows.Count > 0)
            {
                LopMonHocInfo info = new LopMonHocInfo();
                info.MaLopMonHoc = int.Parse(table.Rows[0]["MaLopMonHoc"].ToString());
                LopController lopCtrl = new LopController();
                info.Lop = lopCtrl.LayTuMa(table.Rows[0]["MaLop"].ToString());
                MonHocController monHocCtrl = new MonHocController();
                info.MonHoc = monHocCtrl.LayTuMa(table.Rows[0]["MaMonHoc"].ToString());
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
    }
}
