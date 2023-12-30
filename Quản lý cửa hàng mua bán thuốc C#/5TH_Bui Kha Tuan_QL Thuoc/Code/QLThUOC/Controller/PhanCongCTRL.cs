using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class PhanCongCTRL
    {
        PhanCongDATA data = new PhanCongDATA();
        public void HienThiPhanCong(ComboBox ctxMaTDV,ComboBox ctxMaDB,ComboBox ctxMaThuoc,DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayDSPhanCong();
            dg.DataSource = bs;
            bn.BindingSource = bs;
            ctxMaTDV.DataBindings.Add("SelectedValue", bs, "MATDV");
            ctxMaDB.DataBindings.Add("SelectedValue", bs, "MADB");
            ctxMaThuoc.DataBindings.Add("SelectedValue", bs, "MATHUOC");
            //Load comboBoxMaTDV
            TrinhDuocVienCTRL ctrlTDV = new TrinhDuocVienCTRL();
            ctrlTDV.HienThiComboBoxMaTDV(ctxMaTDV);
            dg.Columns.Add(ctrlTDV.LoadComboxMATDV());
            dg.Columns.Remove("MATDV");
            //Load comboBoxMaDB
            DiaBanCTRL ctrlDiaBan = new DiaBanCTRL();
            ctrlDiaBan.HienThiComboBoxMaDB(ctxMaDB);
            dg.Columns.Add(ctrlDiaBan.LoadComBoxMaDB());
            dg.Columns.Remove("MADB");
            //Load comboBoxMaThuoc
            ThuocCTRL ctrlThuoc = new ThuocCTRL();
            ctrlThuoc.HienThiComboBoxMaThuoc(ctxMaThuoc);
            dg.Columns.Add(ctrlThuoc.LoadComboBoxMaThuoc());
            dg.Columns.Remove("MATHUOC");
        }
        public void Update()
        {
            data.Update();
        }
    }
}
