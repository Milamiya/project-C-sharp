using System.Windows.Forms;
using System.Data;
using BaoCaoThongKe.DataLayer;
using DevExpress.XtraGrid;
using DevExpress.XtraTreeList;

namespace BaoCaoThongKe.Controller
{
    class ChiTieuController
    {
        ChiTieuData data = new ChiTieuData();
        
        //
        public void HienThiTreeList(TreeList tl, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayDSChiTieu();
            bn.BindingSource = bs;
            tl.DataSource = bs;
        }

        public void Update()
        {
            data.Update();
        }
    }
}
