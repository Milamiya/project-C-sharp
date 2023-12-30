using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.BusinessObject;
using QLDiemSoHocSinhTHPT.Controller;

namespace QLDiemSoHocSinhTHPT.GiaoDien
{
    public partial class frmLopMonHoc : Form
    {
        #region LopMonHocController
        private LopMonHocController m_LopMonHocController;

        public LopMonHocController LopMonHocController
        {
            get { return m_LopMonHocController; }
            set { m_LopMonHocController = value; }
        }

        #endregion

        #region NamHocController
        private NamHocController m_NamHocController;

        public NamHocController NamHocController
        {
            get { return m_NamHocController; }
            set { m_NamHocController = value; }
        }

        #endregion

        #region KhoiLopController
        private KhoiLopController m_KhoiLopController;

        public KhoiLopController KhoiLopController
        {
            get { return m_KhoiLopController; }
            set { m_KhoiLopController = value; }
        }

        #endregion

        #region LopController
        private LopController m_LopController;

        public LopController LopController
        {
            get { return m_LopController; }
            set { m_LopController = value; }
        }
	
        #endregion

        #region MonHoc
        private MonHocController m_MonHocController;

        public MonHocController MonHocController
        {
            get { return m_MonHocController; }
            set { m_MonHocController = value; }
        }
	
        #endregion

        public frmLopMonHoc()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLopMonHoc_Load(object sender, EventArgs e)
        {
            if (this.LopMonHocController == null)
            {
                this.LopMonHocController = new LopMonHocController();
            }
            if (this.NamHocController == null) 
            {
                this.NamHocController = new NamHocController();
            }
            if (this.KhoiLopController == null)
            {
                this.KhoiLopController = new KhoiLopController();
            }
            if (this.LopController == null)
            {
                this.LopController = new LopController();
            }
            if (this.MonHocController == null)
            {
                this.MonHocController = new MonHocController();
            }

            this.NamHocController.HienThiCombobox(this.cmbNamHoc);
            this.KhoiLopController.HienThiCombobox(this.cmbKhoiLop);
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbNamHoc.SelectedIndex != -1)
            {
                if (this.cmbKhoiLop.SelectedIndex != -1)
                {
                    this.LopController.HienThiCombobox(this.cmbLop, ((DataRowView)this.cmbKhoiLop.SelectedItem).Row.ItemArray[0].ToString(), ((DataRowView)this.cmbNamHoc.SelectedItem).Row.ItemArray[0].ToString());
                    this.cmbLop.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbKhoiLop.SelectedIndex != -1)
            {
                if (this.cmbNamHoc.SelectedIndex != -1)
                {
                    this.LopController.HienThiCombobox(this.cmbLop, ((DataRowView)this.cmbKhoiLop.SelectedItem).Row.ItemArray[0].ToString(), ((DataRowView)this.cmbNamHoc.SelectedItem).Row.ItemArray[0].ToString());
                    this.cmbLop.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbLop.SelectedIndex != -1)
            {
                LopController lopCtrl = new LopController();
                LopInfo lopInfo = lopCtrl.LayTuMa(((DataRowView)this.cmbLop.SelectedItem).Row.ItemArray[0].ToString());
                this.MonHocController.HienThiDS(this.lvDMMonHoc, lopInfo);
                this.LopMonHocController.HienThiDS(this.lvDSMonHocDuocChon, lopInfo);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddAll_Click(object sender, EventArgs e)
        {
            this.cmbNamHoc.Enabled = false;
            this.cmbKhoiLop.Enabled = false;
            this.cmbLop.Enabled = false;

            IEnumerator ie = this.lvDMMonHoc.Items.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;
                this.lvDMMonHoc.Items.Remove(item);
                this.lvDSMonHocDuocChon.Items.Add(item);
                DataRow row = this.LopMonHocController.Data.DataService.NewRow();
                row["MaLop"] = ((DataRowView)this.cmbLop.SelectedItem).Row.ItemArray[0].ToString();
                row["MaMonHoc"] = item.SubItems[1].Text;
                object[] tag = (object[])item.Tag;
                tag[1] = row;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddSelected_Click(object sender, EventArgs e)
        {
            this.cmbNamHoc.Enabled = false;
            this.cmbKhoiLop.Enabled = false;
            this.cmbLop.Enabled = false;
            
            IEnumerator ie = this.lvDMMonHoc.SelectedItems.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;
                this.lvDMMonHoc.Items.Remove(item);
                this.lvDSMonHocDuocChon.Items.Add(item);
                DataRow row = this.LopMonHocController.Data.DataService.NewRow();
                row["MaLop"] = ((DataRowView)this.cmbLop.SelectedItem).Row.ItemArray[0].ToString();
                row["MaMonHoc"] = item.SubItems[1].Text;
                object[] tag = (object[])item.Tag;
                tag[1] = row;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRemoveSelected_Click(object sender, EventArgs e)
        {
            this.cmbNamHoc.Enabled = false;
            this.cmbKhoiLop.Enabled = false;
            this.cmbLop.Enabled = false;

            IEnumerator ie = this.lvDSMonHocDuocChon.SelectedItems.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;
                this.lvDSMonHocDuocChon.Items.Remove(item);
                this.lvDMMonHoc.Items.Add(item);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRemoveAll_Click(object sender, EventArgs e)
        {
            this.cmbNamHoc.Enabled = false;
            this.cmbKhoiLop.Enabled = false;
            this.cmbLop.Enabled = false;

            IEnumerator ie = this.lvDSMonHocDuocChon.Items.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;
                this.lvDSMonHocDuocChon.Items.Remove(item);
                this.lvDMMonHoc.Items.Add(item);
            }

            //Tao mot doi tuong PhanCongController dung de xoa mon hoc duoc phan cong khi mon hoc do bi xoa khoi danh sach mon hoc cua lop
            PhanCongController phanCongCtrl = new PhanCongController();
            foreach (DataRow row in this.LopMonHocController.Data.DataService.Rows)
            {
                if (row["MaLopMonHoc"].ToString() != "")
                {
                    LopMonHocInfo lopMonHoc = new LopMonHocInfo();
                    lopMonHoc.MaLopMonHoc = int.Parse(row["MaLopMonHoc"].ToString());
                    phanCongCtrl.Xoa(lopMonHoc);
                }
                this.LopMonHocController.Data.DataService.Rows[this.LopMonHocController.Data.DataService.Rows.IndexOf(row)].Delete();
            }

            this.LopMonHocController.Update();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLuu_Click(object sender, EventArgs e)
        {
            this.cmbNamHoc.Enabled = true;
            this.cmbKhoiLop.Enabled = true;
            this.cmbLop.Enabled = true;

            foreach (ListViewItem item in this.lvDSMonHocDuocChon.Items)
            {
                DataRow r = (DataRow)((object[])item.Tag)[1];
                if (this.LopMonHocController.Data.DataService.Rows.IndexOf(r) == -1)
                {
                    this.LopMonHocController.Data.DataService.Rows.Add(r);
                }
            }

            //Tao mot doi tuong PhanCongController dung de xoa mon hoc duoc phan cong khi mon hoc do bi xoa khoi danh sach mon hoc cua lop
            PhanCongController phanCongCtrl = new PhanCongController();
            bool daXoa = false;
            foreach (DataRow row in this.LopMonHocController.Data.DataService.Rows)
            {
                foreach (ListViewItem item in this.lvDSMonHocDuocChon.Items)
                {
                    DataRow r = (DataRow)((object[])item.Tag)[1];
                    if (row.Equals(r))
                    {
                        daXoa = false;
                        break;
                    }
                    daXoa = true;
                }
                if (daXoa)
                {
                    if (row["MaLopMonHoc"].ToString() != "")
                    {
                        LopMonHocInfo lopMonHoc = new LopMonHocInfo();
                        lopMonHoc.MaLopMonHoc = int.Parse(row["MaLopMonHoc"].ToString());
                        phanCongCtrl.Xoa(lopMonHoc);
                    }
                    this.LopMonHocController.Data.DataService.Rows[this.LopMonHocController.Data.DataService.Rows.IndexOf(row)].Delete();
                    daXoa = false;
                }
            }

            this.LopMonHocController.Update();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botBoQua_Click(object sender, EventArgs e)
        {
            this.cmbNamHoc.Enabled = true;
            this.cmbKhoiLop.Enabled = true;
            this.cmbLop.Enabled = true;

            LopController lopCtrl = new LopController();
            LopInfo lopInfo = lopCtrl.LayTuMa(((DataRowView)this.cmbLop.SelectedItem).Row.ItemArray[0].ToString());
            this.MonHocController.HienThiDS(this.lvDMMonHoc, lopInfo);
            this.LopMonHocController.HienThiDS(this.lvDSMonHocDuocChon, lopInfo);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}