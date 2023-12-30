using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

/// <summary>
/// Summary description for Tool
/// </summary>
public class Tool
{
    public Tool()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public void LoadDropDownList(
            DropDownList ddlName, 
            DataTable dtbName, 
            string strTenTruongHienThi, 
            string strTenTruongGiaTri)
        {
            ddlName.DataSource = dtbName;
            ddlName.DataTextField = strTenTruongHienThi;
            ddlName.DataValueField = strTenTruongGiaTri;
            ddlName.DataBind();
        }
        // Load dữ liệu từ table và0 Combobox
        public void LoadCombobox(
            DropDownList cboName, 
            DataTable dtbName, 
            string strTenTruongHienThi, 
            string strTenTruongGiaTri, 
            string ValueDefault,
            string TextDefault)
        {
            ListItem item = new ListItem();
            cboName.Items.Clear();
            cboName.Items.Add(item);
            item.Selected = true;
            item.Value = ValueDefault;
            item.Text = TextDefault;
            cboName.DataSource = dtbName;
            cboName.DataTextField = strTenTruongHienThi;
            cboName.DataValueField = strTenTruongGiaTri;
            cboName.DataBind();
        }
        // Get Hex from string
        public long HexToDec(string hexString)
        {
            long lgDecRs = 0;
            if (hexString.Length > 0)
            {
                lgDecRs = Int64.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
            }
            return lgDecRs;
        }
        // Giai mã từ Hex
        public string DecToHex(long DexValue)
        {
            string ResultValue = "";
            ResultValue = DexValue.ToString("X");
            return ResultValue;
        }
        //Mã hóa theo ToBase64String
        public string Encode64(string dec)
        {
            Byte[] bt;
            bt = Encoding.Unicode.GetBytes(dec);
            string enc;
            enc = Convert.ToBase64String(bt);
            return enc;
        }
        //Giải mã theo 
        public string Decode64(string enc)
        {
            Byte[] bt;
            bt = Convert.FromBase64String(enc);
            string dec;
            dec = Encoding.Unicode.GetString(bt);
            return dec;
        }
        // Hàm tạo chuỗi ngẫu nhiên (So Ky tu muon lay, Chuoi nguon (--Lấy từ chuỗi nào))
        public string TaoChuoiNgauNhien(int SoKyTuMuonLay, string ChuoiNguon)
        {
            Random randNum = new Random();
            char[] chars = new char[SoKyTuMuonLay];
            int allowedCharCount = ChuoiNguon.Length;

            for (int i = 0; i < SoKyTuMuonLay; i++)
            {
                chars[i] = ChuoiNguon[(int)((ChuoiNguon.Length) * randNum.NextDouble())];
            }

            return new string(chars);
        }
        // Hàm tạo chuỗi Pass ngẫu nhiên từ danh sách các kỹ tự
        public static string CreateRandomPassword(int PasswordLength)
        {
            string _allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            Random randNum = new Random();
            char[] chars = new char[PasswordLength];
            int allowedCharCount = _allowedChars.Length;

            for (int i = 0; i < PasswordLength; i++)
            {
                chars[i] = _allowedChars[(int)((_allowedChars.Length) * randNum.NextDouble())];
            }

            return new string(chars);
        }
        //Hàm Export từ Grid ra Excel. inluoi=true nếu muốn export có lưới
        public void Export(string fileName, GridView gv, bool inluoi)
        {
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.AddHeader(
                "content-disposition", string.Format("attachment; filename={0}", fileName));
            HttpContext.Current.Response.ContentType = "application/ms-excel";

            using (StringWriter sw = new StringWriter())
            {
                using (HtmlTextWriter htw = new HtmlTextWriter(sw))
                {
                    Table table = new Table();
                    if (inluoi == true)
                    {
                        table.GridLines = gv.GridLines;
                    }
                    
                    if (gv.HeaderRow != null)
                    {
                        Tool.PrepareControlForExport(gv.HeaderRow);
                        table.Rows.Add(gv.HeaderRow);
                    }

                    foreach (GridViewRow row in gv.Rows)
                    {
                        Tool.PrepareControlForExport(row);
                        table.Rows.Add(row);
                    }
                    if (gv.FooterRow != null)
                    {
                        Tool.PrepareControlForExport(gv.FooterRow);
                        table.Rows.Add(gv.FooterRow);
                    }
                    table.RenderControl(htw);
                    HttpContext.Current.Response.Write(sw.ToString());
                    HttpContext.Current.Response.End();
                }
            }
        }
        private static void PrepareControlForExport(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                Control current = control.Controls[i];
                if (current is LinkButton)
                {
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl((current as LinkButton).Text));
                }
                else if (current is ImageButton)
                {
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl((current as ImageButton).AlternateText));
                }
                else if (current is HyperLink)
                {
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl((current as HyperLink).Text));
                }
                else if (current is DropDownList)
                {
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl((current as DropDownList).SelectedItem.Text));
                }
                else if (current is CheckBox)
                {
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl((current as CheckBox).Checked ? "True" : "False"));
                }

                if (current.HasControls())
                {
                    Tool.PrepareControlForExport(current);
                }
            }
        }

        private string CleanStringForURL(string str)
        {
            StringBuilder sb = new StringBuilder();
            str = HttpContext.Current.Server.HtmlDecode(str.Trim());
            str = str.Replace("&", "and");
            str = Regex.Replace(str, "Đ|đ|&#273;|&#272;", "d", RegexOptions.IgnoreCase);
            str = str.Normalize(NormalizationForm.FormKD);
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsWhiteSpace(str[i])) sb.Append('-');
                else if (char.GetUnicodeCategory(str[i]) != UnicodeCategory.NonSpacingMark
                    && !char.IsPunctuation(str[i])
                    && !char.IsSymbol(str[i])
                    )
                    sb.Append(str[i]);
            }
            return sb.ToString();
        }
}
