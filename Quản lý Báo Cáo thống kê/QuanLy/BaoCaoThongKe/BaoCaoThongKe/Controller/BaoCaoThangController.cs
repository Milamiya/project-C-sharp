using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using BaoCaoThongKe.DataLayer;
using DevExpress.XtraGrid;
using DevExpress.XtraTreeList;

namespace BaoCaoThongKe.Controller
{
    public class BaoCaoThangController
    {
        BaoCaoThangData data = new BaoCaoThangData();

        /// Bao Cao Data member
        private BaoCaoThangData m_Data;
        public BaoCaoThangData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }

        /// lay ma lon nhat
        public int GetLastID()
        {
            if (this.Data == null)
            {
                this.Data = new BaoCaoThangData();
            }
            return Convert.ToInt32(this.Data.GetLastID());
        }

        //
        public void HienThiTreeListThang(TreeList tl, BindingNavigator bn, int maDoanhNghep, string nam)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayDSBaoCaoThang( maDoanhNghep, nam);
            bn.BindingSource = bs;
            tl.DataSource = bs;
        }

        #region Luu Bao Cao
        public void LuuBaoCaoThang(int maBaoCaoThang, String maChiTieu, int maDoanhNghiep, int thang1, int thang2, int thang3, int thang4, int thang5, int thang6, int thang7, int thang8, int thang9, int thang10, int thang11, int thang12, DateTime NgayBaoCao)
        {
            data.LuuBaoCaoThang(maBaoCaoThang, maChiTieu, maDoanhNghiep, thang1, thang2, thang3, thang4, thang5, thang6, thang7, thang8, thang9, thang10, thang11, thang12, NgayBaoCao);
        }
        #endregion

        #region Sua Bao Cao
        public void SuaBaoCaoThang(string maChiTieu, int maDoanhNghiep, string nam, int thang1, int thang2, int thang3, int thang4, int thang5, int thang6, int thang7, int thang8, int thang9, int thang10, int thang11, int thang12)
        {
            data.SuaBaoCaoThang(maChiTieu, maDoanhNghiep, nam, thang1, thang2, thang3, thang4, thang5, thang6, thang7, thang8, thang9, thang10, thang11, thang12);
        }
        #endregion

        //
        public void Update()
        {
            data.Update();
        }
    }
}
