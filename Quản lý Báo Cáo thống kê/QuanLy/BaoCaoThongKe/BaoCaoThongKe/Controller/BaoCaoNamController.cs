using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using BaoCaoThongKe.DataLayer;
using DevExpress.XtraGrid;
using DevExpress.XtraTreeList;

namespace BaoCaoThongKe.Controller
{
    public class BaoCaoNamController
    {
        BaoCaoNamData data = new BaoCaoNamData();

        /// Bao Cao Data member
        private BaoCaoNamData m_Data;
        public BaoCaoNamData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }

        /// lay ma lon nhat
        public int GetLastID()
        {
            if (this.Data == null)
            {
                this.Data = new BaoCaoNamData();
            }
            return Convert.ToInt32(this.Data.GetLastID());
        }

        //
        public void HienThiTreeListNam(TreeList tl, BindingNavigator bn, int maDoanhNghep, string nam)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayDSBaoCaoNam(maDoanhNghep, nam);
            bn.BindingSource = bs;
            tl.DataSource = bs;
        }

        #region Luu Bao Cao
        public void LuuBaoCaoNam(int maBaoCaoNam, String maChiTieu, int maDoanhNghiep, int soluong, DateTime NgayBaoCao)
        {
            data.LuuBaoCaoNam(maBaoCaoNam, maChiTieu, maDoanhNghiep, soluong, NgayBaoCao);
        }
        #endregion

        #region Sua Bao Cao
        public void SuaBaoCaoNam(string maChiTieu, int maDoanhNghiep, string nam, int soluong)
        {
            data.SuaBaoCaoNam(maChiTieu, maDoanhNghiep, nam, soluong);
        }
        #endregion

        //
        public void Update()
        {
            data.Update();
        }
    }
}
