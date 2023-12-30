using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using BaoCaoThongKe.DataLayer;
using DevExpress.XtraGrid;
using DevExpress.XtraTreeList;

namespace BaoCaoThongKe.Controller
{
    public class BaoCaoQuyController
    {
        BaoCaoQuyData data = new BaoCaoQuyData();

        /// Bao Cao Data member
        private BaoCaoQuyData m_Data;
        public BaoCaoQuyData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }

        /// lay ma lon nhat
        public int GetLastID()
        {
            if (this.Data == null)
            {
                this.Data = new BaoCaoQuyData();
            }
            return Convert.ToInt32(this.Data.GetLastID());
        }

        //
        public void HienThiTreeListQuy(TreeList tl, BindingNavigator bn, int maDoanhNghep, string nam)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayDSBaoCaoQuy(maDoanhNghep, nam);
            bn.BindingSource = bs;
            tl.DataSource = bs;
        }

        #region Luu Bao Cao
        public void LuuBaoCaoQuy(int maBaoCaoQuy, String maChiTieu, int maDoanhNghiep, int quy1, int quy2, int quy3, int quy4, DateTime NgayBaoCao)
        {
            data.LuuBaoCaoQuy(maBaoCaoQuy, maChiTieu, maDoanhNghiep, quy1, quy2, quy3, quy4, NgayBaoCao);
        }
        #endregion

        #region Sua Bao Cao
        public void SuaBaoCaoQuy(string maChiTieu, int maDoanhNghiep, string nam, int quy1, int quy2, int quy3, int quy4)
        {
            data.SuaBaoCaoQuy(maChiTieu, maDoanhNghiep, nam, quy1, quy2, quy3, quy4);
        }
        #endregion

        //
        public void Update()
        {
            data.Update();
        }
    }
}
