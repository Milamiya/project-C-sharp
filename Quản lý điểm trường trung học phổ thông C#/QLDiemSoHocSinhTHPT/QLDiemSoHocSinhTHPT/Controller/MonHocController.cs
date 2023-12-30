using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class MonHocController
    {
        #region Data
        private MonHocData m_Data;

        public MonHocData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }
	
        #endregion

        public MonHocController()
        {
            this.Data = new MonHocData();
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
                this.Data = new MonHocData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS();
            bnDS.BindingSource = bs;
            dgvDS.DataSource = bs;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lvDS"></param>
        public void HienThiDS(ListView lvDS, LopInfo lopInfo)
        {
            if (this.Data == null)
            {
                this.Data = new MonHocData();
            }
            DataTable table = this.Data.LayDS(lopInfo);
            lvDS.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                MonHocInfo info = new MonHocInfo();
                info.MaMonHoc = row["MaMonHoc"].ToString();
                info.TenMonHoc = row["TenMonHoc"].ToString();
                info.SoTiet = int.Parse(row["SoTiet"].ToString());
                info.HeSo = int.Parse(row["HeSo"].ToString());

                ListViewItem item = new ListViewItem();
                item.Text = info.TenMonHoc;
                item.SubItems.Add(info.MaMonHoc);
                item.SubItems.Add(info.SoTiet.ToString());
                item.SubItems.Add(info.HeSo.ToString());

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
        /// <param name="col"></param>
        public void HienThiDataGridComboBoxColumn(DataGridViewComboBoxColumn col)
        {
            if (this.Data == null)
            {
                this.Data = new MonHocData();
            }
            col.DataSource = this.Data.LayDS();
            col.DisplayMember = "TenMonHoc";
            col.ValueMember = "MaMonHoc";
            col.DataPropertyName = "MaMonHoc";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmb"></param>
        public void HienThiCombobox(ComboBox cmb)
        {
            if (this.Data == null)
            {
                this.Data = new MonHocData();
            }
            cmb.DataSource = this.Data.LayDS();
            cmb.DisplayMember = "TenMonHoc";
            cmb.ValueMember = "MaMonHoc";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="lopInfo"></param>
        public void HienThiCombobox(ComboBox cmb, LopInfo lopInfo)
        {
            if (this.Data == null)
            {
                this.Data = new MonHocData();
            }
            cmb.DataSource = this.Data.LayDS(lopInfo);
            cmb.DisplayMember = "TenMonHoc";
            cmb.ValueMember = "MaMonHoc";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataGridViewComboBoxColumn LoadComboBoxColumn()
        {
            if (this.Data == null)
            {
                this.Data = new MonHocData();
            }
            DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
            col.DataSource = this.Data.LayDS();
            col.DisplayMember = "TenMonHoc";
            col.ValueMember = "MaMonHoc";

            col.DataPropertyName = "MaMonHoc";
            return col;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maMonHoc"></param>
        /// <returns></returns>
        public MonHocInfo LayTuMa(string maMonHoc)
        {
            if (this.Data == null)
            {
                this.Data = new MonHocData();
            }
            DataTable table = this.Data.LayTuMa(maMonHoc);
            if (table.Rows.Count > 0)
            {
                MonHocInfo info = new MonHocInfo();
                info.MaMonHoc = table.Rows[0]["MaMonHoc"].ToString();
                info.TenMonHoc = table.Rows[0]["TenMonHoc"].ToString();
                info.SoTiet = int.Parse(table.Rows[0]["SoTiet"].ToString());
                info.HeSo = int.Parse(table.Rows[0]["HeSo"].ToString());
                return info;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string LayMaCuoi()
        {
            if (this.Data == null)
            {
                this.Data = new MonHocData();
            }
            return Convert.ToString(this.Data.LayMaCuoi());
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
