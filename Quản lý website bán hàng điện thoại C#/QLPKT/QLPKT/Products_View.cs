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
    public partial class Products_View : Form
    {
        DataTable dt;
        int i;
        string filename;
        string picname;
        string path;
        string manager;
        SqlConnection conn;
        public bool bname = false;
        public bool bm = false;
        public bool bb = false;
        public bool bsl = false;

        public Products_View(SqlConnection conn1,string m)
        {
            InitializeComponent();
            path = Environment.CurrentDirectory.Replace(@"\QLPKT\QLPKT\bin\Debug", "");
            conn = conn1;
            manager = m;
        }

        private void Products_View_Load(object sender, EventArgs e)
        {
            factoryload();
            search2.Text = "";
            nameproducts.Enabled = false;
            factory.Enabled = false;
            buycost.Enabled = false;
            salecost.Enabled = false;
            count.Enabled = false;
            clas.Enabled = false;
            buttom_load.Enabled = false;
            buttom_save.Enabled = false;
            type.Text = "Name";

            buttom_search.BackgroundImage = Image.FromFile(@"Image\buttom_search3.png");
            buttom_change.Enabled = false;
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
            buttom_update.Enabled = false;
            buttom_update.BackgroundImage = Image.FromFile(@"Image\buttom_update3.png");
            buttom_delete.Enabled = false;
            buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete3.png");
            buttom_load.Enabled = false;
            buttom_load.BackgroundImage = Image.FromFile(@"Image\buttom_load3.png");
            buttom_save.Enabled = false;
            buttom_save.BackgroundImage = Image.FromFile(@"Image\buttom_save3.png");
            buttom_more.Enabled = false;
            buttom_more.BackgroundImage = Image.FromFile(@"Image\buttom_more_detail3.png");
            buttom_cancel_Click(sender, e);
        }

        // Cụm tìm kiếm
        private void buttom_showall_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select SanPham.*,TenSX  from SanPham join NhaSanXuat on SanPham.MaSX = NhaSanXuat.MaSX order by MaSP desc", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            data.DataSource = dt.DefaultView;
            data.Visible = true;
        }

        private void searchwith(string type)
        {
            string sql = "select SanPham.*,TenSX  from SanPham join NhaSanXuat on SanPham.MaSX = NhaSanXuat.MaSX where " + type + " like N'%" + search.Text + search2.Text + "%' order by MaSP desc";
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            data.DataSource = dt;
            if (dt.Rows.Count == 0)
                data.Visible = false;
            else data.Visible = true;
            errorProvider1.Clear();
            error.Text = "";
            nameproducts.Text = "";
            factory.Text = "";
            buycost.Text = "";
            salecost.Text = "";
            count.Text = "";
            clas.Text = "";
            picture.Image=Image.FromFile(path + @"\QLPKT\Data\Image\none.png");
            buttom_change.Enabled = false;
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
            buttom_update.Enabled = false;
            buttom_update.BackgroundImage = Image.FromFile(@"Image\buttom_update3.png");
            buttom_delete.Enabled = false;
            buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete3.png");
        }

        private void buttom_search_Click(object sender, EventArgs e)
        {
            if (type.Text == "Name")
            {
                searchwith("TenSP");
            }
            if (type.Text == "ID")
            {
                searchwith("MaSP");
            }
            if (type.Text == "Brand")
            {
                searchwith("TenSX");
            }

        }

        private void search_Click(object sender, EventArgs e)
        {
            search.Text = "";
        }

        private void search2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (search2.Text == "")
            {
                buttom_search.Enabled = false;
                buttom_search.BackgroundImage = Image.FromFile(@"Image\buttom_search3.png");
            }
            else
            {
                buttom_search.Enabled = true;
                buttom_search.BackgroundImage = Image.FromFile(@"Image\buttom_search.png");
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                buttom_search.Enabled = false;
                buttom_search.BackgroundImage = Image.FromFile(@"Image\buttom_search3.png");
            }
            else
            {
                buttom_search.Enabled = true;
                buttom_search.BackgroundImage = Image.FromFile(@"Image\buttom_search.png");
            }
        }

        // Display
        private void dataview(int i)
        {
            id.Text = dt.Rows[i][0].ToString();
            nameproducts.Text = dt.Rows[i][2].ToString();
            factory.Text = dt.Rows[i][41].ToString();
            buycost.Text = dt.Rows[i][3].ToString();
            salecost.Text = dt.Rows[i][4].ToString();
            count.Text = dt.Rows[i][6].ToString();
            clas.Text = dt.Rows[i][8].ToString();
            filename = path + @"\QLPKT\Data\Image\" + dt.Rows[i][7].ToString().Replace("Data Image/","");
            picture.Image = Image.FromFile(filename);
            string[] ketqua = filename.Replace(@"\", "/").Split('/');
            picname = ketqua[ketqua.Length - 1];

            // Phan quyen
            buttom_change.Enabled = true;
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change.png");
            buttom_delete.Enabled = true;
            buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete.png");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Manager where MaM='" + manager + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((bool)reader["MASTER"] != true)
                {
                    if ((bool)reader["MP_DELETE"] == false)
                    {
                        buttom_delete.Enabled = false;
                        buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete3.png");
                    }
                    if ((bool)reader["MP_CHANGE"] == false)
                    {
                        buttom_change.Enabled = false;
                        buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
                    }
                }
            }
            reader.Close();
            conn.Close();
            error.Text = "";
            errorProvider1.Clear();
        }

        private void factoryload()
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select MaSX,TenSX from NhaSanXuat order by MaSX", conn);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            adapter.Fill(dt);
            adapter.Fill(dt2);
            adapter.Dispose();
            factory.DisplayMember = "TenSX";
            factory.ValueMember = "MaSX";
            factory.DataSource = dt.DefaultView;
            search2.ValueMember = "TenSX";
            search2.DataSource = dt2.DefaultView;
        }

        // Buttom
        private void buttom_more_Click(object sender, EventArgs e)
        {
            Products_Moredetails pm = new Products_Moredetails(dt, i);
            pm.ShowDialog();
            if (pm.DialogResult == DialogResult.OK)
            {
                buttom_search_Click(sender, e);
            } 
        }

        private void buttom_next_Click(object sender, EventArgs e)
        {
            if (i < dt.Rows.Count - 1)
            {
                i++;
                dataview(i);
                data.Rows[i].Selected = true;
            }
        }

        private void buttom_back_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                dataview(i);
                data.Rows[i].Selected = true;
            }
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
                filename = save.FileName;
                if (filename.Length != 0)
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
                            filename += ".jpg";
                            break;
                        default:
                            break;
                    }
                    picture.Image.Save(filename, format);
                    picture.Image = Image.FromFile(filename);

                    //Lấy tên hình
                    string[] ketqua = filename.Replace(@"\", "/").Split('/');
                    picname = ketqua[ketqua.Length - 1];
                    Environment.CurrentDirectory = Environment.CurrentDirectory.Replace(@"\QLPKT\Data\Image", "") + @"\QLPKT\QLPKT\bin\Debug";
                }
            }
        }

        private void buttom_change_Click(object sender, EventArgs e)
        {
            nameproducts.Enabled = true;
            factory.Enabled = true;
            salecost.Enabled = true;
            clas.Enabled = true;
            buttom_load.Enabled = true;
            buttom_save.Enabled = true;

            buttom_update.Enabled = true;
            buttom_update.BackgroundImage = Image.FromFile(@"Image\buttom_update.png");
            buttom_load.Enabled = true;
            buttom_load.BackgroundImage = Image.FromFile(@"Image\buttom_load.png");
            buttom_save.Enabled = true;
            buttom_save.BackgroundImage = Image.FromFile(@"Image\buttom_save.png");
            buttom_more.Enabled = true;
            buttom_more.BackgroundImage = Image.FromFile(@"Image\buttom_more_detail.png");
        }

        private void buttom_cancel_Click(object sender, EventArgs e)
        {
            nameproducts.Enabled = false;
            factory.Enabled = false;
            buycost.Enabled = false;
            salecost.Enabled = false;
            count.Enabled = false;
            clas.Enabled = false;
            buttom_load.Enabled = false;
            buttom_save.Enabled = false;

            buttom_update.Enabled = false;
            buttom_update.BackgroundImage = Image.FromFile(@"Image\buttom_update3.png");
            buttom_load.Enabled = false;
            buttom_load.BackgroundImage = Image.FromFile(@"Image\buttom_load3.png");
            buttom_save.Enabled = false;
            buttom_save.BackgroundImage = Image.FromFile(@"Image\buttom_save3.png");
            buttom_more.Enabled = false;
            buttom_more.BackgroundImage = Image.FromFile(@"Image\buttom_more_detail3.png");
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

                string sql = "update SanPham set MaSX=@idsx,TenSP=@namepro,GiaBan=@sale,PhanLoai=@status,HinhAnh=@pic where MaSP=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@idsx", factory.SelectedValue);
                cmd.Parameters.AddWithValue("@namepro", nameproducts.Text);
                cmd.Parameters.AddWithValue("@sale", int.Parse(salecost.Text));
                cmd.Parameters.AddWithValue("@status", clas.Text);
                cmd.Parameters.AddWithValue("@pic", "Data Image/" + picname);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                error.Text = "Updated!";
                buttom_cancel_Click(sender, e);
            }
        }

        private void buttom_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from ChiTietHoaDonMua where MaSP='"+id.Text+"'", conn);
            int c1 = (int)cmd.ExecuteScalar();
            cmd.CommandText = "select count(*) from ChiTietHoaDonBan where MaSP='" + id.Text + "'";
            int c2 = (int)cmd.ExecuteScalar();
            if (c1 > 0 || c2 > 0)
            {
                MessageBox.Show("Không thể xóa sản phẩm này. Sản phẩm này có liên quan tới:\n" + c1 + " Hóa đơn mua.\n" + c2 + " Hóa đơn bán.", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (data.RowCount > 1)
                {
                    cmd.CommandText= "delete from SanPham where MaSP=@idpro";
                    cmd.Parameters.AddWithValue("@idpro", id.Text);
                    cmd.ExecuteNonQuery();
                    dt.Rows.RemoveAt(i);

                    error.Text = "Deleted!";
                }
                else error.Text = "No data";
            }
            conn.Close();
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if (i >= 0)
            {
                dataview(i);
            }
        }

        private void data_KeyDown(object sender, KeyEventArgs e)
        {
            i = i + 1;
            dataview(i);
        }


        // Kiem tra
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

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.Text == "Brand")
            {
                search2.Visible = true;
                search.Visible = false;
                search.Text = "";

            }
            if (type.Text == "ID")
            {
                search2.Visible = false;
                search.Visible = true;
                search.Text = "ID có định dạng SP0000";
                search2.Text = "";
            }
                
            if (type.Text == "Name")
            {
                search2.Visible = false;
                search.Visible = true;
                search.Text = "Nhập sản phẩm cần tìm";
                search2.Text = "";
            }     
        }

    }
}
