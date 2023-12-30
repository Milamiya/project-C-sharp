using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LichCongTac
{
    public partial class frmChuyenDonVi : Form
    {
        public frmChuyenDonVi()
        {
            InitializeComponent();
        }

        Modules.Global global = new LichCongTac.Modules.Global();
        Modules.StringMessage strMess = new LichCongTac.Modules.StringMessage();

        private string strCauHinh = null;

        private void frmChuyenDonVi_Load(object sender, EventArgs e)
        {
            comboLoaiChuyenDoi.Items.Add("Nhiệt Độ");
            comboLoaiChuyenDoi.Items.Add("Tiền Tệ");
            comboLoaiChuyenDoi.Items.Add("Trọng Lượng");
            comboLoaiChuyenDoi.Items.Add("Độ Dài");
            //comboLoaiChuyenDoi.Items.Add("Diện Tích");
            //comboLoaiChuyenDoi.Items.Add("Thể Tích");
        }

        private void comboLoaiChuyenDoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboCauHinh.Items.Clear();
            comboCauHinh.Text = "";
            txtDonViCanDoi.Text = "";
            txtKetQua.Text = "";
            string strLoaiChuyenDoi = comboLoaiChuyenDoi.SelectedItem.ToString();
            if (strLoaiChuyenDoi == "Nhiệt Độ")
            {
                comboCauHinh.Items.Add("Fahrenheit <==> Celsius");
                comboCauHinh.Items.Add("Celsius <==> Fahrenheit");
                comboCauHinh.Items.Add("Fahrenheit <==> kelvin");
                comboCauHinh.Items.Add("kelvin <==> Fahrenheit");
            }
            if (strLoaiChuyenDoi == "Tiền Tệ")
            {
                comboCauHinh.Items.Add("USD <==> VND");
                comboCauHinh.Items.Add("VND <==> USD");
                comboCauHinh.Items.Add("GBP <==> VND");
                comboCauHinh.Items.Add("VND <==> GBP");
                comboCauHinh.Items.Add("EUR <==> VND");
                comboCauHinh.Items.Add("VND <==> EUR");
                comboCauHinh.Items.Add("INR <==> VND");
                comboCauHinh.Items.Add("VND <==> INR");
            }
            if (strLoaiChuyenDoi == "Trọng Lượng")
            {
                comboCauHinh.Items.Add("Kilonewton(kN) <==> Kilogram(kg)");
                comboCauHinh.Items.Add("Hectogram(hg) <==> Kilogram(kg)");
                comboCauHinh.Items.Add("Long ton <==> Kilogram(kg)");
                comboCauHinh.Items.Add("Short ton <==> Kilogram(kg)");
                comboCauHinh.Items.Add("Long hundredweight <==> Kilogram(kg)");
                comboCauHinh.Items.Add("Short hundredweight <==> Kilogram(kg)");
                comboCauHinh.Items.Add("Pound(lb) <==> Kilogram(kg)");
            }
            if (strLoaiChuyenDoi == "Độ Dài")
            {
                comboCauHinh.Items.Add("Centimeters <==> Inches");
                comboCauHinh.Items.Add("Centimeters <==> Feet");
                comboCauHinh.Items.Add("Centimeters <==> Yards");
                comboCauHinh.Items.Add("Centimeters <==> Meters");
                comboCauHinh.Items.Add("Centimeters <==> Chains");
                comboCauHinh.Items.Add("Centimeters <==> Kilometers");
            }
        }

        private void comboCauHinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            strCauHinh = comboCauHinh.SelectedItem.ToString();
            txtDonViCanDoi.Text = "";
            txtKetQua.Text = "";
        }

        private void txtDonViCanDoi_TextChanged(object sender, EventArgs e)
        {
            string strDonViCanDoi = txtDonViCanDoi.Text.ToString().Trim();
            double doubleKetQua = 0;
            if ((global.TestNumber(strDonViCanDoi)) || strDonViCanDoi != "")
            {

                //Nhiệt Độ

                if (strCauHinh == "Fahrenheit <==> Celsius")
                {
                    doubleKetQua = (Double.Parse(strDonViCanDoi) - 32) / 1.8;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "Celsius <==> Fahrenheit")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) * 1.8 + 32;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "Fahrenheit <==> kelvin")
                {
                    doubleKetQua = (Double.Parse(strDonViCanDoi) - 32) / 1.8 + 273.15;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "kelvin <==> Fahrenheit")
                {
                    doubleKetQua = (Double.Parse(strDonViCanDoi) - 273.15) * 1.8 + 32;
                    txtKetQua.Text = doubleKetQua.ToString();
                }

                //Tiền Tệ

                if (strCauHinh == "USD <==> VND")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) * 16150.00;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "VND <==> USD")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) / 16150.00;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "GBP <==> VND")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) * 31374.58;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "VND <==> GBP")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) / 31374.58;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "EUR <==> VND")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) * 24746.63;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "VND <==> EUR")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) / 24746.63;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "INR <==> VND")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) * 383.79;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "VND <==> INR")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) / 383.79;
                    txtKetQua.Text = doubleKetQua.ToString();
                }

                //Trọng Lượng
                if (strCauHinh == "Kilonewton(kN) <==> Kilogram(kg)")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) * 101.97;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "Hectogram(hg) <==> Kilogram(kg)")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) * 0.1;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "Long ton <==> Kilogram(kg)")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) * 1016.05;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "Short ton <==> Kilogram(kg)")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) * 907.18;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "Long hundredweight <==> Kilogram(kg)")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) * 50.8;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "Short hundredweight <==> Kilogram(kg)")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) * 45.36;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "Pound(lb) <==> Kilogram(kg)")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) * 6.35;
                    txtKetQua.Text = doubleKetQua.ToString();
                }

                //Độ Dài
                if (strCauHinh == "Centimeters <==> Inches")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) * 0.39370;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "Centimeters <==> Feet")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) * 0.03281;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "Centimeters <==> Yard")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) * 0.01094;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "Centimeters <==> Meters")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) * 0.01000;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "Centimeters <==> Chains")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) * 0.00049;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
                if (strCauHinh == "Centimeters <==> Kilometers")
                {
                    doubleKetQua = Double.Parse(strDonViCanDoi) * 0.00001;
                    txtKetQua.Text = doubleKetQua.ToString();
                }
            }
            else
            {
                if (strDonViCanDoi == "")
                {

                }
                else
                {
                    MessageBox.Show("Bạn Đã Nhập Sai Đơn Vị Tính", strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}