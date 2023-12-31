using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.Controller;
using DevExpress.XtraGrid;

namespace BaoCaoThongKe
{
    public partial class BaoCaoHoatDongCungCapDichVu : Form
    {
        ChiTieuController ctrl = new ChiTieuController();
        
        DonViTinhData dvdata = new DonViTinhData();
        DonViTinhData data1 = new DonViTinhData();
        DonViTinhData data2 = new DonViTinhData();
        DoanhNghiepController dnctrl = new DoanhNghiepController();
        BaoCaoThangController bct = new BaoCaoThangController();
        BaoCaoQuyController bcq = new BaoCaoQuyController();
        BaoCaoNamController bcn = new BaoCaoNamController();
        BaoCaoQuyData bcqdata = new BaoCaoQuyData();
        BaoCaoNamData bcndata = new BaoCaoNamData();
        BaoCaoThangData bctdata = new BaoCaoThangData();
        ChiTieuData ctdata = new ChiTieuData();

        //Cac Bien
        //dateEdit1 = Convert.ToDateTime(DateTime.Today.ToLongDateString());

        //
        public BaoCaoHoatDongCungCapDichVu()
        {
            InitializeComponent();
            
        }

        //
        private void BaoCaoHoatDongCungCapDichVu_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = Convert.ToDateTime(DateTime.Today.ToShortDateString());
            //
            dnctrl.ComboBoxDoanhNghiep(comboBoxEx1);

            repositoryItemLookUpEdit1.DataSource = dvdata.LayDSDonViTinh();
            repositoryItemLookUpEdit1.DisplayMember = "TenDonViTinh";
            repositoryItemLookUpEdit1.ValueMember = "MaDonViTinh";
            //
            bct.HienThiTreeListThang(treeList1, bindingNavigatorHDCungCap, Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString());
            repositoryItemLookUpEdit2.DataSource = data1.LayDSDonViTinh();
            repositoryItemLookUpEdit2.DisplayMember = "TenDonViTinh";
            repositoryItemLookUpEdit2.ValueMember = "MaDonViTinh";

            //
            bcq.HienThiTreeListQuy(treeList2, bindingNavigator1, Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString());
            repositoryItemLookUpEdit3.DataSource = data2.LayDSDonViTinh();
            repositoryItemLookUpEdit3.DisplayMember = "TenDonViTinh";
            repositoryItemLookUpEdit3.ValueMember = "MaDonViTinh";

            //
            bcn.HienThiTreeListNam(treeList3, bindingNavigator2, Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString());



            
        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dateEdit1.DateTime.Date.ToShortDateString());

            if (dateEdit1.DateTime.Date.ToShortDateString() == "1/1/0001")
            {
                MessageBox.Show("Bạn chưa nhập ngày tháng báo cáo !");
            }
            else
            {
                int thang1, thang2, thang3, thang4, thang5, thang6, thang7, thang8, thang9, thang10, thang11, thang12;

                //
                for (int i = 0; i < treeList1.Nodes.Count; i++)
                {

                    //
                    if (treeList1.Nodes[i].GetValue("Thang1").ToString() == "")
                    {
                        thang1 = 0;
                    }
                    else
                    {
                        thang1 = Convert.ToInt32(treeList1.Nodes[i].GetValue("Thang1").ToString());
                        //MessageBox.Show(thang1.ToString());
                    }
                    //
                    if ((treeList1.Nodes[i].GetValue("Thang2").ToString()) == "")
                    {
                        thang2 = 0;
                    }
                    else
                    {
                        thang2 = Convert.ToInt32(treeList1.Nodes[i].GetValue("Thang2"));

                    }
                    //
                    if (treeList1.Nodes[i].GetValue("Thang3").ToString() == "")
                    {
                        thang3 = 0;
                    }
                    else
                    {
                        thang3 = Convert.ToInt32(treeList1.Nodes[i].GetValue("Thang3").ToString());
                        //MessageBox.Show(thang3.ToString());
                    }
                    //
                    if (treeList1.Nodes[i].GetValue("Thang4").ToString() == "")
                    {
                        thang4 = 0;
                    }
                    else
                    {
                        thang4 = Convert.ToInt32(treeList1.Nodes[i].GetValue("Thang4").ToString());
                        //MessageBox.Show(thang4.ToString());
                    }
                    //
                    if (treeList1.Nodes[i].GetValue("Thang5").ToString() == "")
                    {
                        thang5 = 0;
                    }
                    else
                    {
                        thang5 = Convert.ToInt32(treeList1.Nodes[i].GetValue("Thang5").ToString());
                    }
                    //
                    if (treeList1.Nodes[i].GetValue("Thang6").ToString() == "")
                    {
                        thang6 = 0;
                    }
                    else
                    {
                        thang6 = Convert.ToInt32(treeList1.Nodes[i].GetValue("Thang6").ToString());
                    }
                    //
                    if (treeList1.Nodes[i].GetValue("Thang7").ToString() == "")
                    {
                        thang7 = 0;
                    }
                    else
                    {
                        thang7 = Convert.ToInt32(treeList1.Nodes[i].GetValue("Thang7").ToString());
                    }
                    //
                    if (treeList1.Nodes[i].GetValue("Thang8").ToString() == "")
                    {
                        thang8 = 0;
                    }
                    else
                    {
                        thang8 = Convert.ToInt32(treeList1.Nodes[i].GetValue("Thang8").ToString());
                    }
                    //
                    if (treeList1.Nodes[i].GetValue("Thang9").ToString() == "")
                    {
                        thang9 = 0;
                    }
                    else
                    {
                        thang9 = Convert.ToInt32(treeList1.Nodes[i].GetValue("Thang9").ToString());
                    }
                    //
                    if (treeList1.Nodes[i].GetValue("Thang10").ToString() == "")
                    {
                        thang10 = 0;
                    }
                    else
                    {
                        thang10 = Convert.ToInt32(treeList1.Nodes[i].GetValue("Thang10").ToString());
                    }
                    //
                    if (treeList1.Nodes[i].GetValue("Thang11").ToString() == "")
                    {
                        thang11 = 0;
                    }
                    else
                    {
                        thang11 = Convert.ToInt32(treeList1.Nodes[i].GetValue("Thang11").ToString());
                    }
                    //
                    if (treeList1.Nodes[i].GetValue("Thang12").ToString() == "")
                    {
                        thang12 = 0;
                    }
                    else
                    {
                        thang12 = Convert.ToInt32(treeList1.Nodes[i].GetValue("Thang12").ToString());
                    }

                    //-------------------------------------
                    bool j = true;
                    DataTable ds = new DataTable();
                    ds = bctdata.LayDSBaoCaoThang1(Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString());

                    foreach (DataRow r in ds.Rows)
                    {
                        if (r["MaChiTieu"].ToString() == treeList1.Nodes[i].GetValue("MaChiTieu").ToString())
                        {

                            j = false;
                            //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());
                            BaoCaoThangController sbc = new BaoCaoThangController();
                            sbc.SuaBaoCaoThang(treeList1.Nodes[i].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString(), thang1, thang2, thang3, thang4, thang5, thang6, thang7, thang8, thang9, thang10, thang11, thang12);
                            //bct.Update();
                            //bct.HienThiTreeListThang(treeList1, bindingNavigatorHDCungCap);
                            break;
                        }
                    }

                    if (j)
                    {
                        bct.LuuBaoCaoThang((bct.GetLastID() + 1), treeList1.Nodes[i].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), thang1, thang2, thang3, thang4, thang5, thang6, thang7, thang8, thang9, thang10, thang11, thang12, dateEdit1.DateTime.Date);
                        //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString()+" chua co");
                    }
                    //else
                    //    MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());

                    //========================================================================



                    //
                    for (int s = 0; s < treeList1.Nodes[i].Nodes.Count; s++)
                    {
                        //
                        if (treeList1.Nodes[i].Nodes[s].GetValue("Thang1").ToString() == "")
                        {
                            thang1 = 0;
                        }
                        else
                        {
                            thang1 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].GetValue("Thang1").ToString());
                        }
                        //
                        if ((treeList1.Nodes[i].Nodes[s].GetValue("Thang2").ToString()) == "")
                        {
                            thang2 = 0;
                        }
                        else
                        {
                            thang2 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].GetValue("Thang2"));

                        }
                        //
                        if (treeList1.Nodes[i].Nodes[s].GetValue("Thang3").ToString() == "")
                        {
                            thang3 = 0;
                        }
                        else
                        {
                            thang3 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].GetValue("Thang3").ToString());
                        }
                        //
                        if (treeList1.Nodes[i].Nodes[s].GetValue("Thang4").ToString() == "")
                        {
                            thang4 = 0;
                        }
                        else
                        {
                            thang4 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].GetValue("Thang4").ToString());
                        }
                        //
                        if (treeList1.Nodes[i].Nodes[s].GetValue("Thang5").ToString() == "")
                        {
                            thang5 = 0;
                        }
                        else
                        {
                            thang5 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].GetValue("Thang5").ToString());
                        }
                        //
                        if (treeList1.Nodes[i].Nodes[s].GetValue("Thang6").ToString() == "")
                        {
                            thang6 = 0;
                        }
                        else
                        {
                            thang6 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].GetValue("Thang6").ToString());
                        }
                        //
                        if (treeList1.Nodes[i].Nodes[s].GetValue("Thang7").ToString() == "")
                        {
                            thang7 = 0;
                        }
                        else
                        {
                            thang7 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].GetValue("Thang7").ToString());
                        }
                        //
                        if (treeList1.Nodes[i].Nodes[s].GetValue("Thang8").ToString() == "")
                        {
                            thang8 = 0;
                        }
                        else
                        {
                            thang8 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].GetValue("Thang8").ToString());
                        }
                        //
                        if (treeList1.Nodes[i].Nodes[s].GetValue("Thang9").ToString() == "")
                        {
                            thang9 = 0;
                        }
                        else
                        {
                            thang9 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].GetValue("Thang9").ToString());
                        }
                        //
                        if (treeList1.Nodes[i].Nodes[s].GetValue("Thang10").ToString() == "")
                        {
                            thang10 = 0;
                        }
                        else
                        {
                            thang10 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].GetValue("Thang10").ToString());
                        }
                        //
                        if (treeList1.Nodes[i].Nodes[s].GetValue("Thang11").ToString() == "")
                        {
                            thang11 = 0;
                        }
                        else
                        {
                            thang11 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].GetValue("Thang11").ToString());
                        }
                        //
                        if (treeList1.Nodes[i].Nodes[s].GetValue("Thang12").ToString() == "")
                        {
                            thang12 = 0;
                        }
                        else
                        {
                            thang12 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].GetValue("Thang12").ToString());
                        }

                        //-------------------------------------
                        bool z = true;
                        DataTable ze = new DataTable();
                        ze = bctdata.LayDSBaoCaoThang1(Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString());

                        foreach (DataRow r in ze.Rows)
                        {
                            if (r["MaChiTieu"].ToString() == treeList1.Nodes[i].Nodes[s].GetValue("MaChiTieu").ToString())
                            {

                                z = false;
                                //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());
                                BaoCaoThangController sbe = new BaoCaoThangController();
                                sbe.SuaBaoCaoThang(treeList1.Nodes[i].Nodes[s].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString(), thang1, thang2, thang3, thang4, thang5, thang6, thang7, thang8, thang9, thang10, thang11, thang12);
                                //bct.Update();
                                //bct.HienThiTreeListThang(treeList1, bindingNavigatorHDCungCap);
                                break;
                            }
                        }

                        if (z)
                        {
                            bct.LuuBaoCaoThang((bct.GetLastID() + 1), treeList1.Nodes[i].Nodes[s].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), thang1, thang2, thang3, thang4, thang5, thang6, thang7, thang8, thang9, thang10, thang11, thang12, dateEdit1.DateTime.Date);
                            //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString()+" chua co");
                        }
                        //else
                        //    MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());

                        //========================================================================


                        //
                        for (int f = 0; f < treeList1.Nodes[i].Nodes[s].Nodes.Count; f++)
                        {
                            
                            //
                            if (treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang1").ToString() == "")
                            {
                                thang1 = 0;
                            }
                            else
                            {
                                thang1 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang1").ToString());
                            }
                            //
                            if ((treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang2").ToString()) == "")
                            {
                                thang2 = 0;
                            }
                            else
                            {
                                thang2 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang2"));

                            }
                            //
                            if (treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang3").ToString() == "")
                            {
                                thang3 = 0;
                            }
                            else
                            {
                                thang3 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang3").ToString());
                            }
                            //
                            if (treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang4").ToString() == "")
                            {
                                thang4 = 0;
                            }
                            else
                            {
                                thang4 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang4").ToString());
                            }
                            //
                            if (treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang5").ToString() == "")
                            {
                                thang5 = 0;
                            }
                            else
                            {
                                thang5 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang5").ToString());
                            }
                            //
                            if (treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang6").ToString() == "")
                            {
                                thang6 = 0;
                            }
                            else
                            {
                                thang6 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang6").ToString());
                            }
                            //
                            if (treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang7").ToString() == "")
                            {
                                thang7 = 0;
                            }
                            else
                            {
                                thang7 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang7").ToString());
                            }
                            //
                            if (treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang8").ToString() == "")
                            {
                                thang8 = 0;
                            }
                            else
                            {
                                thang8 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang8").ToString());
                            }
                            //
                            if (treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang9").ToString() == "")
                            {
                                thang9 = 0;
                            }
                            else
                            {
                                thang9 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang9").ToString());
                            }
                            //
                            if (treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang10").ToString() == "")
                            {
                                thang10 = 0;
                            }
                            else
                            {
                                thang10 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang10").ToString());
                            }
                            //
                            if (treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang11").ToString() == "")
                            {
                                thang11 = 0;
                            }
                            else
                            {
                                thang11 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang11").ToString());
                            }
                            //
                            if (treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang12").ToString() == "")
                            {
                                thang12 = 0;
                            }
                            else
                            {
                                thang12 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("Thang12").ToString());
                            }

                            //-------------------------------------
                            bool y = true;
                            DataTable ye = new DataTable();
                            ye = bctdata.LayDSBaoCaoThang1(Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString());

                            foreach (DataRow r in ye.Rows)
                            {
                                if (r["MaChiTieu"].ToString() == treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("MaChiTieu").ToString())
                                {

                                    y = false;
                                    //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());
                                    BaoCaoThangController sbc = new BaoCaoThangController();
                                    sbc.SuaBaoCaoThang(treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString(), thang1, thang2, thang3, thang4, thang5, thang6, thang7, thang8, thang9, thang10, thang11, thang12);
                                    //bct.Update();
                                    //bct.HienThiTreeListThang(treeList1, bindingNavigatorHDCungCap);
                                    break;
                                }
                            }

                            if (y)
                            {
                                bct.LuuBaoCaoThang((bct.GetLastID() + 1), treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), thang1, thang2, thang3, thang4, thang5, thang6, thang7, thang8, thang9, thang10, thang11, thang12, dateEdit1.DateTime.Date);
                                //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString()+" chua co");
                            }
                            //else
                            //    MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());

                            //========================================================================


                            //
                            for (int d = 0; d < treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes.Count; d++)
                            {

                                //
                                if (treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang1").ToString() == "")
                                {
                                    thang1 = 0;
                                }
                                else
                                {
                                    thang1 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang1").ToString());
                                }
                                //
                                if ((treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang2").ToString()) == "")
                                {
                                    thang2 = 0;
                                }
                                else
                                {
                                    thang2 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang2"));

                                }
                                //
                                if (treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang3").ToString() == "")
                                {
                                    thang3 = 0;
                                }
                                else
                                {
                                    thang3 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang3").ToString());
                                }
                                //
                                if (treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang4").ToString() == "")
                                {
                                    thang4 = 0;
                                }
                                else
                                {
                                    thang4 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang4").ToString());
                                }
                                //
                                if (treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang5").ToString() == "")
                                {
                                    thang5 = 0;
                                }
                                else
                                {
                                    thang5 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang5").ToString());
                                }
                                //
                                if (treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang6").ToString() == "")
                                {
                                    thang6 = 0;
                                }
                                else
                                {
                                    thang6 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang6").ToString());
                                }
                                //
                                if (treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang7").ToString() == "")
                                {
                                    thang7 = 0;
                                }
                                else
                                {
                                    thang7 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang7").ToString());
                                }
                                //
                                if (treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang8").ToString() == "")
                                {
                                    thang8 = 0;
                                }
                                else
                                {
                                    thang8 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang8").ToString());
                                }
                                //
                                if (treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang9").ToString() == "")
                                {
                                    thang9 = 0;
                                }
                                else
                                {
                                    thang9 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang9").ToString());
                                }
                                //
                                if (treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang10").ToString() == "")
                                {
                                    thang10 = 0;
                                }
                                else
                                {
                                    thang10 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang10").ToString());
                                }
                                //
                                if (treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang11").ToString() == "")
                                {
                                    thang11 = 0;
                                }
                                else
                                {
                                    thang11 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang11").ToString());
                                }
                                //
                                if (treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang12").ToString() == "")
                                {
                                    thang12 = 0;
                                }
                                else
                                {
                                    thang12 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Thang12").ToString());
                                }


                                //-------------------------------------
                                bool m = true;
                                DataTable me = new DataTable();
                                me = bctdata.LayDSBaoCaoThang1(Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString());

                                foreach (DataRow r in me.Rows)
                                {
                                    if (r["MaChiTieu"].ToString() == treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("MaChiTieu").ToString())
                                    {

                                        m = false;
                                        //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());
                                        BaoCaoThangController sbc = new BaoCaoThangController();
                                        sbc.SuaBaoCaoThang(treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString(), thang1, thang2, thang3, thang4, thang5, thang6, thang7, thang8, thang9, thang10, thang11, thang12);
                                        //bct.Update();
                                        //bct.HienThiTreeListThang(treeList1, bindingNavigatorHDCungCap);
                                        break;
                                    }
                                }

                                if (m)
                                {
                                    bct.LuuBaoCaoThang((bct.GetLastID() + 1), treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), thang1, thang2, thang3, thang4, thang5, thang6, thang7, thang8, thang9, thang10, thang11, thang12, dateEdit1.DateTime.Date);
                                    //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString()+" chua co");
                                }
                                //else
                                //    MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());

                                //========================================================================

                                //
                                //

                            }
                         }
                    }
                }
            }
        }

        //
        frmChiTieu chiTieu = null;
        private void AddNutGoc_Click(object sender, EventArgs e)
        {
            
            if (chiTieu == null || chiTieu.IsDisposed)
            {
                chiTieu = new frmChiTieu();
                chiTieu.Show();
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bct.HienThiTreeListThang(treeList1, bindingNavigatorHDCungCap, Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString());
        }

        private void Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateEdit1_DateTimeChanged(object sender, EventArgs e)
        {
            bct.HienThiTreeListThang(treeList1, bindingNavigatorHDCungCap, Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString());
        }

        private void comboBoxEx1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bct.HienThiTreeListThang(treeList1, bindingNavigatorHDCungCap, Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString());
        }

        private void LuuQuy_Click(object sender, EventArgs e)
        {
            int quy1, quy2, quy3, quy4;

            //
            for (int i = 0; i < treeList2.Nodes.Count; i++)
            {

                //
                if (treeList2.Nodes[i].GetValue("Quy1").ToString() == "")
                {
                    quy1 = 0;
                }
                else
                {
                    quy1 = Convert.ToInt32(treeList2.Nodes[i].GetValue("Quy1").ToString());
                    //MessageBox.Show(thang1.ToString());
                }
                //
                if ((treeList2.Nodes[i].GetValue("Quy2").ToString()) == "")
                {
                    quy2 = 0;
                }
                else
                {
                    quy2 = Convert.ToInt32(treeList2.Nodes[i].GetValue("Quy2"));

                }
                //
                if (treeList2.Nodes[i].GetValue("Quy3").ToString() == "")
                {
                    quy3 = 0;
                }
                else
                {
                    quy3 = Convert.ToInt32(treeList2.Nodes[i].GetValue("Quy3").ToString());
                    //MessageBox.Show(thang3.ToString());
                }
                //
                if (treeList2.Nodes[i].GetValue("Quy4").ToString() == "")
                {
                    quy4 = 0;
                }
                else
                {
                    quy4 = Convert.ToInt32(treeList2.Nodes[i].GetValue("Quy4").ToString());
                    //MessageBox.Show(thang4.ToString());
                }

                //-------------------------------------
                bool j = true;
                DataTable ds = new DataTable();
                ds = bcqdata.LayDSBaoCaoQuy1(Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString());

                foreach (DataRow r in ds.Rows)
                {
                    if (r["MaChiTieu"].ToString() == treeList2.Nodes[i].GetValue("MaChiTieu").ToString())
                    {

                        j = false;
                        //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());
                        BaoCaoQuyController sbc = new BaoCaoQuyController();
                        sbc.SuaBaoCaoQuy(treeList2.Nodes[i].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString(), quy1, quy2, quy3, quy4);
                        //bct.Update();
                        //bct.HienThiTreeListThang(treeList1, bindingNavigatorHDCungCap);
                        break;
                    }
                }

                if (j)
                {
                    bcq.LuuBaoCaoQuy((bcq.GetLastID() + 1), treeList2.Nodes[i].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), quy1, quy2, quy3, quy4, dateEdit1.DateTime.Date);
                    //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString()+" chua co");
                }
                //else
                //    MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());

                //========================================================================



                //
                for (int s = 0; s < treeList2.Nodes[i].Nodes.Count; s++)
                {
                    //
                    if (treeList2.Nodes[i].Nodes[s].GetValue("Quy1").ToString() == "")
                    {
                        quy1 = 0;
                    }
                    else
                    {
                        quy1 = Convert.ToInt32(treeList2.Nodes[i].Nodes[s].GetValue("Quy1").ToString());
                    }
                    //
                    if ((treeList2.Nodes[i].Nodes[s].GetValue("Quy2").ToString()) == "")
                    {
                        quy2 = 0;
                    }
                    else
                    {
                        quy2 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].GetValue("Quy2"));

                    }
                    //
                    if (treeList2.Nodes[i].Nodes[s].GetValue("Quy3").ToString() == "")
                    {
                        quy3 = 0;
                    }
                    else
                    {
                        quy3 = Convert.ToInt32(treeList2.Nodes[i].Nodes[s].GetValue("Quy3").ToString());
                    }
                    //
                    if (treeList2.Nodes[i].Nodes[s].GetValue("Quy4").ToString() == "")
                    {
                        quy4 = 0;
                    }
                    else
                    {
                        quy4 = Convert.ToInt32(treeList2.Nodes[i].Nodes[s].GetValue("Quy4").ToString());
                    }

                    //-------------------------------------
                    bool z = true;
                    DataTable ze = new DataTable();
                    ze = bcqdata.LayDSBaoCaoQuy1(Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString());

                    foreach (DataRow r in ze.Rows)
                    {
                        if (r["MaChiTieu"].ToString() == treeList2.Nodes[i].Nodes[s].GetValue("MaChiTieu").ToString())
                        {

                            z = false;
                            //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());
                            BaoCaoQuyController sbe = new BaoCaoQuyController();
                            sbe.SuaBaoCaoQuy(treeList2.Nodes[i].Nodes[s].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString(), quy1, quy2, quy3, quy4);
                            //bct.Update();
                            //bct.HienThiTreeListThang(treeList1, bindingNavigatorHDCungCap);
                            break;
                        }
                    }

                    if (z)
                    {
                        bcq.LuuBaoCaoQuy((bcq.GetLastID() + 1), treeList2.Nodes[i].Nodes[s].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), quy1, quy2, quy3, quy4, dateEdit1.DateTime.Date);
                        //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString()+" chua co");
                    }
                    //else
                    //    MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());

                    //========================================================================


                    //
                    for (int f = 0; f < treeList2.Nodes[i].Nodes[s].Nodes.Count; f++)
                    {

                        //
                        if (treeList2.Nodes[i].Nodes[s].Nodes[f].GetValue("Quy1").ToString() == "")
                        {
                            quy1 = 0;
                        }
                        else
                        {
                            quy1 = Convert.ToInt32(treeList2.Nodes[i].Nodes[s].Nodes[f].GetValue("Quy1").ToString());
                        }
                        //
                        if ((treeList2.Nodes[i].Nodes[s].Nodes[f].GetValue("Quy2").ToString()) == "")
                        {
                            quy2 = 0;
                        }
                        else
                        {
                            quy2 = Convert.ToInt32(treeList2.Nodes[i].Nodes[s].Nodes[f].GetValue("Quy2"));

                        }
                        //
                        if (treeList2.Nodes[i].Nodes[s].Nodes[f].GetValue("Quy3").ToString() == "")
                        {
                            quy3 = 0;
                        }
                        else
                        {
                            quy3 = Convert.ToInt32(treeList2.Nodes[i].Nodes[s].Nodes[f].GetValue("Quy3").ToString());
                        }
                        //
                        if (treeList2.Nodes[i].Nodes[s].Nodes[f].GetValue("Quy4").ToString() == "")
                        {
                            quy4 = 0;
                        }
                        else
                        {
                            quy4 = Convert.ToInt32(treeList2.Nodes[i].Nodes[s].Nodes[f].GetValue("Quy4").ToString());
                        }
                        

                        //-------------------------------------
                        bool y = true;
                        DataTable ye = new DataTable();
                        ye = bcqdata.LayDSBaoCaoQuy1(Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString());

                        foreach (DataRow r in ye.Rows)
                        {
                            if (r["MaChiTieu"].ToString() == treeList2.Nodes[i].Nodes[s].Nodes[f].GetValue("MaChiTieu").ToString())
                            {

                                y = false;
                                //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());
                                BaoCaoQuyController sbc = new BaoCaoQuyController();
                                sbc.SuaBaoCaoQuy(treeList2.Nodes[i].Nodes[s].Nodes[f].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString(), quy1, quy2, quy3, quy4);
                                //bct.Update();
                                //bct.HienThiTreeListThang(treeList1, bindingNavigatorHDCungCap);
                                break;
                            }
                        }

                        if (y)
                        {
                            bcq.LuuBaoCaoQuy((bcq.GetLastID() + 1), treeList2.Nodes[i].Nodes[s].Nodes[f].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), quy1, quy2, quy3, quy4, dateEdit1.DateTime.Date);
                            //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString()+" chua co");
                        }
                        //else
                        //    MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());

                        //========================================================================


                        //
                        for (int d = 0; d < treeList2.Nodes[i].Nodes[s].Nodes[f].Nodes.Count; d++)
                        {

                            //
                            if (treeList2.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Quy1").ToString() == "")
                            {
                                quy1 = 0;
                            }
                            else
                            {
                                quy1 = Convert.ToInt32(treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Quy1").ToString());
                            }
                            //
                            if ((treeList2.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Quy2").ToString()) == "")
                            {
                                quy2 = 0;
                            }
                            else
                            {
                                quy2 = Convert.ToInt32(treeList2.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Quy2"));

                            }
                            //
                            if (treeList2.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Quy3").ToString() == "")
                            {
                                quy3 = 0;
                            }
                            else
                            {
                                quy3 = Convert.ToInt32(treeList2.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Quy3").ToString());
                            }
                            //
                            if (treeList2.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Quy4").ToString() == "")
                            {
                                quy4 = 0;
                            }
                            else
                            {
                                quy4 = Convert.ToInt32(treeList2.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("Quy4").ToString());
                            }
                            

                            //-------------------------------------
                            bool m = true;
                            DataTable me = new DataTable();
                            me = bcqdata.LayDSBaoCaoQuy1(Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString());

                            foreach (DataRow r in me.Rows)
                            {
                                if (r["MaChiTieu"].ToString() == treeList2.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("MaChiTieu").ToString())
                                {

                                    m = false;
                                    //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());
                                    BaoCaoQuyController sbc = new BaoCaoQuyController();
                                    sbc.SuaBaoCaoQuy(treeList2.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString(), quy1, quy2, quy3, quy4);
                                    //bct.Update();
                                    //bct.HienThiTreeListThang(treeList1, bindingNavigatorHDCungCap);
                                    break;
                                }
                            }

                            if (m)
                            {
                                bcq.LuuBaoCaoQuy((bcq.GetLastID() + 1), treeList2.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), quy1, quy2, quy3, quy4, dateEdit1.DateTime.Date);
                                //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString()+" chua co");
                            }
                            //else
                            //    MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());

                            //========================================================================

                            //
                            //

                        }
                    }
                }
            }
        }

        private void ThoatQuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XemLai_Click(object sender, EventArgs e)
        {

        }

        private void ThemChiTeu_Click(object sender, EventArgs e)
        {
            frmChiTieu chiTieu = null;
            if (chiTieu == null || chiTieu.IsDisposed)
            {
                chiTieu = new frmChiTieu();
                //chiTieu.MdiParent = this;
                chiTieu.Show();
            }
        }

        private void ThemChiTieuNam_Click(object sender, EventArgs e)
        {
            frmChiTieu chiTieu = null;
            if (chiTieu == null || chiTieu.IsDisposed)
            {
                chiTieu = new frmChiTieu();
                //chiTieu.MdiParent = this;
                chiTieu.Show();
            }
        }

        private void XemLaiNam_Click(object sender, EventArgs e)
        {

        }

        private void LuuNam_Click(object sender, EventArgs e)
        {
            int soluong;

            //
            for (int i = 0; i < treeList3.Nodes.Count; i++)
            {

                //
                if (treeList3.Nodes[i].GetValue("SoLuong").ToString() == "")
                {
                    soluong = 0;
                }
                else
                {
                    soluong = Convert.ToInt32(treeList3.Nodes[i].GetValue("SoLuong").ToString());
                    //MessageBox.Show(thang1.ToString());
                }
                

                //-------------------------------------
                bool j = true;
                DataTable ds = new DataTable();
                ds = bcndata.LayDSBaoCaoNam1(Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString());

                foreach (DataRow r in ds.Rows)
                {
                    if (r["MaChiTieu"].ToString() == treeList3.Nodes[i].GetValue("MaChiTieu").ToString())
                    {

                        j = false;
                        //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());
                        BaoCaoNamController sbc = new BaoCaoNamController();
                        sbc.SuaBaoCaoNam(treeList3.Nodes[i].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString(), soluong);
                        //bct.Update();
                        //bct.HienThiTreeListThang(treeList1, bindingNavigatorHDCungCap);
                        break;
                    }
                }

                if (j)
                {
                    bcn.LuuBaoCaoNam((bcn.GetLastID() + 1), treeList3.Nodes[i].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), soluong, dateEdit1.DateTime.Date);
                    //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString()+" chua co");
                }
                //else
                //    MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());

                //========================================================================



                //
                for (int s = 0; s < treeList3.Nodes[i].Nodes.Count; s++)
                {
                    //
                    if (treeList3.Nodes[i].Nodes[s].GetValue("SoLuong").ToString() == "")
                    {
                        soluong = 0;
                    }
                    else
                    {
                        soluong = Convert.ToInt32(treeList3.Nodes[i].Nodes[s].GetValue("SoLuong").ToString());
                    }
                    //
                    

                    //-------------------------------------
                    bool z = true;
                    DataTable ze = new DataTable();
                    ze = bcndata.LayDSBaoCaoNam1(Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString());

                    foreach (DataRow r in ze.Rows)
                    {
                        if (r["MaChiTieu"].ToString() == treeList3.Nodes[i].Nodes[s].GetValue("MaChiTieu").ToString())
                        {

                            z = false;
                            //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());
                            BaoCaoNamController sbe = new BaoCaoNamController();
                            sbe.SuaBaoCaoNam(treeList3.Nodes[i].Nodes[s].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString(), soluong);
                            //bct.Update();
                            //bct.HienThiTreeListThang(treeList1, bindingNavigatorHDCungCap);
                            break;
                        }
                    }

                    if (z)
                    {
                        bcn.LuuBaoCaoNam((bcn.GetLastID() + 1), treeList3.Nodes[i].Nodes[s].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), soluong, dateEdit1.DateTime.Date);
                        //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString()+" chua co");
                    }
                    //else
                    //    MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());

                    //========================================================================


                    //
                    for (int f = 0; f < treeList3.Nodes[i].Nodes[s].Nodes.Count; f++)
                    {

                        //
                        if (treeList3.Nodes[i].Nodes[s].Nodes[f].GetValue("SoLuong").ToString() == "")
                        {
                            soluong = 0;
                        }
                        else
                        {
                            soluong = Convert.ToInt32(treeList3.Nodes[i].Nodes[s].Nodes[f].GetValue("SoLuong").ToString());
                        }


                        //-------------------------------------
                        bool y = true;
                        DataTable ye = new DataTable();
                        ye = bcndata.LayDSBaoCaoNam1(Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString());

                        foreach (DataRow r in ye.Rows)
                        {
                            if (r["MaChiTieu"].ToString() == treeList3.Nodes[i].Nodes[s].Nodes[f].GetValue("MaChiTieu").ToString())
                            {

                                y = false;
                                //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());
                                BaoCaoNamController sbc = new BaoCaoNamController();
                                sbc.SuaBaoCaoNam(treeList3.Nodes[i].Nodes[s].Nodes[f].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString(), soluong);
                                //bct.Update();
                                //bct.HienThiTreeListThang(treeList1, bindingNavigatorHDCungCap);
                                break;
                            }
                        }

                        if (y)
                        {
                            bcn.LuuBaoCaoNam((bcn.GetLastID() + 1), treeList3.Nodes[i].Nodes[s].Nodes[f].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), soluong, dateEdit1.DateTime.Date);
                            //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString()+" chua co");
                        }
                        //else
                        //    MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());

                        //========================================================================


                        //
                        for (int d = 0; d < treeList3.Nodes[i].Nodes[s].Nodes[f].Nodes.Count; d++)
                        {

                            //
                            if (treeList3.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("SoLuong").ToString() == "")
                            {
                                soluong = 0;
                            }
                            else
                            {
                                soluong = Convert.ToInt32(treeList3.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("SoLuong").ToString());
                            }


                            //-------------------------------------
                            bool m = true;
                            DataTable me = new DataTable();
                            me = bcndata.LayDSBaoCaoNam1(Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString());

                            foreach (DataRow r in me.Rows)
                            {
                                if (r["MaChiTieu"].ToString() == treeList3.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("MaChiTieu").ToString())
                                {

                                    m = false;
                                    //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());
                                    BaoCaoNamController sbc = new BaoCaoNamController();
                                    sbc.SuaBaoCaoNam(treeList3.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), dateEdit1.DateTime.Year.ToString(), soluong);
                                    //bct.Update();
                                    //bct.HienThiTreeListThang(treeList1, bindingNavigatorHDCungCap);
                                    break;
                                }
                            }

                            if (m)
                            {
                                bcn.LuuBaoCaoNam((bcn.GetLastID() + 1), treeList3.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("MaChiTieu").ToString(), Convert.ToInt32(comboBoxEx1.SelectedValue), soluong, dateEdit1.DateTime.Date);
                                //MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString()+" chua co");
                            }
                            //else
                            //    MessageBox.Show(treeList1.Nodes[i].GetValue("MaChiTieu").ToString());

                            //========================================================================

                            //
                            //

                        }
                    }
                }
            }
        }

        private void ThoatNam_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}