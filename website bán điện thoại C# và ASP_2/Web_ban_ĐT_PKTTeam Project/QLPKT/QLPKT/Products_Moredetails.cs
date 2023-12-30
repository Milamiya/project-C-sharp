using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace QLPKT
{
    public partial class Products_Moredetails : Form
    {
        private DataTable dt;
        int i;
        string filename;
        string picname="";
        string path;
        SqlConnection conn;
        public bool bname = false;
        public bool bm = false;
        public bool bb = false;
        public bool bsl = false;

        public Products_Moredetails(DataTable dt1, int i1)
        {
            InitializeComponent();
            dt = dt1;
            i = i1;
            path = Environment.CurrentDirectory.Replace(@"\QLPKT\QLPKT\bin\Debug", "");
            Config file = new Config(Application.StartupPath + "\\config.ini");
            string connectionstring = file.ReadValue("server", "connstring");
            conn = new SqlConnection(connectionstring);
        }

        private void dataview(int i)
        {
            id.Text = dt.Rows[i][0].ToString();
            nameproducts.Text = dt.Rows[i][2].ToString();
            factory.Text = dt.Rows[i][40].ToString();
            buycost.Text = dt.Rows[i][3].ToString();
            salecost.Text = dt.Rows[i][4].ToString();
            count.Text = dt.Rows[i][6].ToString();
            clas.Text = dt.Rows[i][8].ToString();
            filename = path + @"\QLPKT\Data\Image\" + dt.Rows[i][7].ToString().Replace("Data Image/", "");
            picture.Image = Image.FromFile(filename);
            tb1.Text = dt.Rows[i][10].ToString();
            tb2.Text = dt.Rows[i][11].ToString();
            tb3.Text = dt.Rows[i][12].ToString();
            tb4.Text = dt.Rows[i][13].ToString();
            tb5.Text = dt.Rows[i][14].ToString();
            tb6.Text = dt.Rows[i][15].ToString();
            tb7.Text = dt.Rows[i][16].ToString();
            tb8.Text = dt.Rows[i][17].ToString();
            tb9.Text = dt.Rows[i][18].ToString();
            tb10.Text = dt.Rows[i][19].ToString();
            tb11.Text = dt.Rows[i][20].ToString();
            tb12.Text = dt.Rows[i][21].ToString();
            tb13.Text = dt.Rows[i][22].ToString();
            tb14.Text = dt.Rows[i][23].ToString();
            tb15.Text = dt.Rows[i][24].ToString();
            tb16.Text = dt.Rows[i][25].ToString();
            tb17.Text = dt.Rows[i][26].ToString();
            tb18.Text = dt.Rows[i][27].ToString();
            tb19.Text = dt.Rows[i][28].ToString();
            tb20.Text = dt.Rows[i][29].ToString();
            tb21.Text = dt.Rows[i][30].ToString();
            tb22.Text = dt.Rows[i][31].ToString();
            tb23.Text = dt.Rows[i][32].ToString();
            tb24.Text = dt.Rows[i][33].ToString();
            tb25.Text = dt.Rows[i][34].ToString();
            tb26.Text = dt.Rows[i][35].ToString();
            tb27.Text = dt.Rows[i][36].ToString();
            tb28.Text = dt.Rows[i][37].ToString();
            tb29.Text = dt.Rows[i][38].ToString();
            string[] ketqua = filename.Replace(@"\", "/").Split('/');
            picname = ketqua[ketqua.Length - 1];
        }

        private void factoryload()
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select MaSX,TenSX from NhaSanXuat", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            factory.DisplayMember = "TenSX";
            factory.ValueMember = "MaSX";
            factory.DataSource = dt.DefaultView;
        }

        private void buttom_cancel_Click(object sender, EventArgs e)
        {

        }

        private void Products_Moredetails_Load(object sender, EventArgs e)
        {
            factoryload();
            dataview(i);
        }

        private void buttom_backform_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttom_delete_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=BITET-PC\SQLEXPRESS;Initial Catalog=QL_PKTPHONE;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionstring);
            string sql = "delete from SanPham where MaSP=@idpro";
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("@idpro", id.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            error.Text = "Deleted!";
            erroradd2.Text = "Delete!";
        }

        private void buttom_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.InitialDirectory = @"C:\Users\Bi.Tet\Desktop";
            f.Filter = "Image Files (JPEG, GIF, BMP, etc.)|" +
              "*.jpg;*.jpeg;*.gif;*.bmp;*.tif;*.tiff;*.png|" +
              "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "GIF Files (*.gif)|*.gif|" +
              "BMP Files (*.bmp)|*.bmp|" +
              "TIFF Files (*.tif;*.tiff)|*.tif;*.tiff|" +
              "PNG Files (*.png)|*.png|" +
              "All files (*.*)|*.*";
            if (f.ShowDialog() == DialogResult.OK)
            {
                filename = f.FileName;
                picture.Image = Image.FromFile(filename);
            }
            string[] ketqua = filename.Replace(@"\", "/").Split('/');
            picname = ketqua[ketqua.Length - 1];
        }

        private void buttom_save_Click(object sender, EventArgs e)
        {
            ImageFormat format = ImageFormat.Jpeg;
            int filterIndex = -1;
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = @"F:\PKT\Data\Image";
            save.Title = "Save Image As";
            save.OverwritePrompt = true;
            save.CheckPathExists = true;
            save.ShowHelp = true;
            save.FileName = path + @"\QLPKT\Data\Image\" + picname;
            save.Filter = "Image Files (JPEG, GIF, BMP, etc.)|" +
              "*.jpg;*.jpeg;*.gif;*.bmp;*.tif;*.tiff;*.png|" +
              "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "GIF Files (*.gif)|*.gif|" +
              "BMP Files (*.bmp)|*.bmp|" +
              "TIFF Files (*.tif;*.tiff)|*.tif;*.tiff|" +
              "PNG Files (*.png)|*.png|" +
              "All files (*.*)|*.*";
            if (filterIndex != -1)
            {
                save.FilterIndex = filterIndex;
            }
            if (save.ShowDialog() == DialogResult.OK)
            {
                string fileName = save.FileName;
                if (fileName.Length != 0)
                {
                    filterIndex = save.FilterIndex;
                    switch (filterIndex)
                    {
                        case 1:
                            format = ImageFormat.Jpeg;
                            break;
                        case 2:
                            format = ImageFormat.Jpeg;
                            break;
                        case 3:
                            format = ImageFormat.Gif;
                            break;
                        case 4:
                            format = ImageFormat.Bmp;
                            break;
                        case 5:
                            format = ImageFormat.Tiff;
                            break;
                        case 6:
                            format = ImageFormat.Png;
                            break;
                        case 7:
                            format = ImageFormat.Jpeg;
                            fileName += ".jpg";
                            break;
                        default:
                            break;
                    }
                    picture.Image.Save(fileName, format);
                    filename = fileName;
                    picture.Image = Image.FromFile(filename);

                    string[] ketqua = filename.Replace(@"\", "/").Split('/');
                    picname = ketqua[ketqua.Length - 1];
                    Environment.CurrentDirectory = Environment.CurrentDirectory.Replace(@"\QLPKT\Data\Image", "") + @"\QLPKT\QLPKT\bin\Debug";
                }
            }
        }

        private void buttom_update_Click(object sender, EventArgs e)
        {
            if (bname == false ||
                  bb == false)
            {
                error.Text = "Update not success! Please check again!";
            }
            else
            {
                string autosave = path + @"\PKT Website\PKT\Data Image\" + picname;
                picture.Image.Save(autosave);

                string connectionstring = @"Data Source=BITET-PC\SQLEXPRESS;Initial Catalog=QL_PKTPHONE;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionstring);
                string sql = "update SanPham set MaSX=@idsx,TenSP=@namepro,GiaMua=@buy,GiaBan=@sale,SLTon=@count,PhanLoai=@status,HinhAnh=@pic," +
                    "CT1=@CT1,CT2=@CT2,CT3=@CT3,CT4=@CT4,CT5=@CT5,CT6=@CT6,CT7=@CT7,CT8=@CT8,CT9=@CT9,CT10=@CT10,CT11=@CT11,CT12=@CT12,CT13=@CT13," +
                    "CT14=@CT14,CT15=@CT15,CT16=@CT16,CT17=@CT17,CT18=@CT18,CT19=@CT19,CT20=@CT20,CT21=@CT21,CT22=@CT22,CT23=@CT23,CT24=@CT24," +
                    "CT25=@CT25,CT26=@CT26,CT27=@CT27,CT28=@CT28,CT29=@CT29 where MaSP=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@idsx", factory.SelectedValue);
                cmd.Parameters.AddWithValue("@namepro", nameproducts.Text);
                cmd.Parameters.AddWithValue("@buy", int.Parse(buycost.Text));
                cmd.Parameters.AddWithValue("@sale", int.Parse(salecost.Text));
                cmd.Parameters.AddWithValue("@count", int.Parse(count.Text));
                cmd.Parameters.AddWithValue("@status", clas.Text);
                cmd.Parameters.AddWithValue("@pic", "Data Image/" + picname);
                cmd.Parameters.AddWithValue("@CT1", tb1.Text);
                cmd.Parameters.AddWithValue("@CT2", tb2.Text);
                cmd.Parameters.AddWithValue("@CT3", tb3.Text);
                cmd.Parameters.AddWithValue("@CT4", tb4.Text);
                cmd.Parameters.AddWithValue("@CT5", tb5.Text);
                cmd.Parameters.AddWithValue("@CT6", tb6.Text);
                cmd.Parameters.AddWithValue("@CT7", tb7.Text);
                cmd.Parameters.AddWithValue("@CT8", tb8.Text);
                cmd.Parameters.AddWithValue("@CT9", tb9.Text);
                cmd.Parameters.AddWithValue("@CT10", tb10.Text);
                cmd.Parameters.AddWithValue("@CT11", tb11.Text);
                cmd.Parameters.AddWithValue("@CT12", tb12.Text);
                cmd.Parameters.AddWithValue("@CT13", tb13.Text);
                cmd.Parameters.AddWithValue("@CT14", tb14.Text);
                cmd.Parameters.AddWithValue("@CT15", tb15.Text);
                cmd.Parameters.AddWithValue("@CT16", tb16.Text);
                cmd.Parameters.AddWithValue("@CT17", tb17.Text);
                cmd.Parameters.AddWithValue("@CT18", tb18.Text);
                cmd.Parameters.AddWithValue("@CT19", tb19.Text);
                cmd.Parameters.AddWithValue("@CT20", tb20.Text);
                cmd.Parameters.AddWithValue("@CT21", tb21.Text);
                cmd.Parameters.AddWithValue("@CT22", tb22.Text);
                cmd.Parameters.AddWithValue("@CT23", tb23.Text);
                cmd.Parameters.AddWithValue("@CT24", tb24.Text);
                cmd.Parameters.AddWithValue("@CT25", tb25.Text);
                cmd.Parameters.AddWithValue("@CT26", tb26.Text);
                cmd.Parameters.AddWithValue("@CT27", tb27.Text);
                cmd.Parameters.AddWithValue("@CT28", tb28.Text);
                cmd.Parameters.AddWithValue("@CT29", tb29.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                error.Text = "Updated!";
            }
        }

        private void buttom_next_Click(object sender, EventArgs e)
        {
            if (i < dt.Rows.Count - 1)
            {
                i++;
                dataview(i);
            }
        }

        private void buttom_back_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                dataview(i);
            }
        }

        private void buttom_change_Click(object sender, EventArgs e)
        {

        }

        private void nameproducts_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(nameproducts.Text, "[a-zA-Z0-9]+$"))
            {
                errorProvider1.SetError(nameproducts, "Allow char");
                bname = false;
            }
            else
            {
                errorProvider1.Clear();
                bname = true;
                error.Text = "";
            }
        }

        private void buycost_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(buycost.Text, "[^0-9]+"))
            {
                bm = false;
                errorProvider1.SetError(buycost, "Allow number, not type space");
            }
            else if (buycost.Text.Length == 0)
            {
                bm = false;
                errorProvider1.SetError(buycost, "Allow number 10 characters");
            }
            else
            {
                bm = true;
                errorProvider1.Clear();
                error.Text = "";
            }
        }

        private void salecost_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(salecost.Text, "[^0-9]+"))
            {
                bb = false;
                errorProvider1.SetError(salecost, "Allow number, not type space");
            }
            else if (salecost.Text.Length == 0)
            {
                bb = false;
                errorProvider1.SetError(salecost, "Allow number 10 characters");
            }
            else
            {
                bb = true;
                errorProvider1.Clear();
                error.Text = "";
            }
        }

        private void count_TextChanged(object sender, EventArgs e)
        {

            if (Regex.IsMatch(count.Text, "[^0-9]+"))
            {
                bsl = false;
                errorProvider1.SetError(count, "Allow number, not type space");
            }
            else if (salecost.Text.Length == 0)
            {
                bsl = false;
                errorProvider1.SetError(count, "Allow number 10 characters");
            }
            else
            {
                bsl = true;
                errorProvider1.Clear();
                error.Text = "";
            }
        }
    }
}
