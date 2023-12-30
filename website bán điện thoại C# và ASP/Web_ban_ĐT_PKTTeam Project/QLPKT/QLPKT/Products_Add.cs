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
using System.IO;
using System.Text.RegularExpressions;

namespace QLPKT
{
    public partial class Products_Add : Form
    {
        string filename;
        string picname="";
        string path;
        SqlConnection conn;
        public bool bname = false;
        public bool bb = false;
        List<ComboBox> hili;
        List<TextBox> tb;
        List<Label> lb;
        string noibat="";


        public Products_Add(SqlConnection conn1)
        {
            InitializeComponent();
            path = Environment.CurrentDirectory.Replace(@"\QLPKT\QLPKT\bin\Debug", "");
            conn = conn1;
            Ngay_Load();
            hightlight_load();
            tb_load();
        }

        private void buttom_add_Click(object sender, EventArgs e)
        {
            noibat = "";
            //Lay thong tin noi bat
            for (int i = 1; i < 11; i++)
            {
                for (int j = 0; j < hili.Count; j++)
                {
                    if (hili[j].Text.Length != 0)
                    {
                        if (i == int.Parse(hili[j].Text))
                            noibat = noibat + " - "+ lb[j].Text.Replace(":","")+" "+ tb[j].Text + "<br />";
                    }
                }
            }

            if (bname == false || bb == false)
            {
                error.Text = "Add not success! Please check again!";
            }
            else
            {
                string autosave = path + @"\PKT Website\PKT\Data Image\" + picname;
                picture.Image.Save(autosave);

                string sql = "insert SanPham (MaSP,MaSX,TenSP,GiaBan,NgayNhap,PhanLoai,HinhAnh,CT1,CT2,CT3,CT4,CT5,CT6,CT7,CT8,CT9,CT10,CT11,CT12,CT13,CT14,CT15,CT16,CT17,CT18,CT19,CT20,CT21,CT22,CT23,CT24,CT25,CT26,CT27,CT28,CT29,NoiBat)" +
                    "values('',@idfac,@namepro,@sale,@date,@status,@pic,@CT1,@CT2,@CT3,@CT4,@CT5,@CT6,@CT7,@CT8,@CT9,@CT10,@CT11,@CT12,@CT13,@CT14,@CT15,@CT16,@CT17,@CT18,@CT19,@CT20,@CT21,@CT22,@CT23,@CT24,@CT25,@CT26,@CT27,@CT28,@CT29,@noibat)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@idfac", factory.SelectedValue);
                cmd.Parameters.AddWithValue("@namepro", nameproducts.Text);
                cmd.Parameters.AddWithValue("@sale", int.Parse(salecost.Text));
                cmd.Parameters.AddWithValue("@date", month.Text + "/" + day.Text + "/" + year.Text);
                cmd.Parameters.AddWithValue("@status", clas.Text);
                cmd.Parameters.AddWithValue("@noibat", noibat);
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
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select top(1) MaSP from SanPham order by MaSP desc";
                id.Text = (string)cmd.ExecuteScalar();
                conn.Close();
                error.Text = "Add success!";
                erroradd2.Text = "Add success!";
                //this.DialogResult = DialogResult.OK;
            }
        }

        private void menu_products_add_Load(object sender, EventArgs e)
        {
            factoryload();
            DateTime date = DateTime.Today;
            day.Text = date.Day.ToString();
            month.Text = date.Month.ToString();
            year.Text = date.Year.ToString();
            picture.Image = Image.FromFile(path + @"\QLPKT\Data\Image\none.png");
            picname = "none.png";
        }

        private void factoryload()
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select MaSX,TenSX from NhaSanXuat", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            factory.DisplayMember="TenSX";
            factory.ValueMember = "MaSX";
            factory.DataSource = dt.DefaultView;
        }

        private void buttom_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog() ;
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
            //Lấy tên hình
            string[] ketqua = filename.Replace(@"\","/").Split('/');
            picname=ketqua[ketqua.Length-1];
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
            save.FileName = path+ @"\QLPKT\Data\Image\"+picname;
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

        private void nameproducts_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(nameproducts.Text, "[a-zA-Z0-9]+$"))
            {
                errorProvider1.SetError(nameproducts, "Allow char");
                bname = false;
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from SanPham where TenSP=@tensp", conn);
                cmd.Parameters.AddWithValue("@tensp", nameproducts.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    errorProvider1.SetError(nameproducts, "The name is exist!");
                }
                else
                {
                    errorProvider1.Clear();
                    bname = true;
                    error.Text = "";
                }
                reader.Close();
                conn.Close();
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


        private void buttom_clear_Click(object sender, EventArgs e)
        {
            nameproducts.Focus();
            nameproducts.Clear();
            salecost.Clear();
            picture.Refresh();
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
            tb4.Clear();
            tb5.Clear();
            tb6.Clear();
            tb7.Clear();
            tb8.Clear();
            tb9.Clear();
            tb10.Clear();
            tb11.Clear();
            tb12.Clear();
            tb13.Clear();
            tb14.Clear();
            tb15.Clear();
            tb16.Clear();
            tb17.Clear();
            tb18.Clear();
            tb19.Clear();
            tb20.Clear();
            tb21.Clear();
            tb22.Clear();
            tb23.Clear();
            tb24.Clear();
            tb25.Clear();
            tb26.Clear();
            tb27.Clear();
            tb28.Clear();
            tb29.Clear();
            id.Clear();
            error.Text = "";
            errorProvider1.Clear();
        }

        private void day_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select* from Thang where @ngay<=Ngay", conn);
            cmd.Parameters.AddWithValue("@ngay", day.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            month.DisplayMember = "Thang";
            month.ValueMember = "Thang";
            month.DataSource = dt.DefaultView;
        }

        protected void Ngay_Load()
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select Ngay from Ngay", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            day.DisplayMember = "Ngay";
            day.ValueMember = "Ngay";
            day.DataSource = dt.DefaultView;
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            int d = int.Parse(day.SelectedValue.ToString());
            int m = int.Parse(month.SelectedValue.ToString());
            if (d == 29 && m == 2)
            {
                string sql = "select* from NamNhuan";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                year.DisplayMember = "Nam";
                year.ValueMember = "Nam";
                year.DataSource = dt.DefaultView;
            }
            else
            {
                string sql = "select* from Nam";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                year.DisplayMember = "Nam";
                year.ValueMember = "Nam";
                year.DataSource = dt.DefaultView;
            }
        }


        private void loaditem (ComboBox c)
        {
            c.Items.Add(1);
            c.Items.Add(2);
            c.Items.Add(3);
            c.Items.Add(4);
            c.Items.Add(5);
            c.Items.Add(6);
            c.Items.Add(7);
            c.Items.Add(8);
            c.Items.Add(9);
            c.Items.Add(10);
        }

        private void deleteitem(ComboBox c, int i)
        {
            c.Items.Remove(i);
        }

        private void additem(ComboBox c, int i)
        {
            c.Items.Add(i);
        }

        private void hightlight_load()
        {
            hili = new List<ComboBox>();
            hili.Add(comboBox1);hili.Add(comboBox2);hili.Add(comboBox3);hili.Add(comboBox4);hili.Add(comboBox5);
            hili.Add(comboBox6);hili.Add(comboBox7);hili.Add(comboBox8);hili.Add(comboBox9);hili.Add(comboBox10);
            hili.Add(comboBox11);hili.Add(comboBox12);hili.Add(comboBox13);hili.Add(comboBox14);hili.Add(comboBox15);
            hili.Add(comboBox16);hili.Add(comboBox17);hili.Add(comboBox18);hili.Add(comboBox19);hili.Add(comboBox20);
            hili.Add(comboBox21);hili.Add(comboBox22);hili.Add(comboBox23);hili.Add(comboBox24);hili.Add(comboBox25);
            hili.Add(comboBox26);hili.Add(comboBox27);hili.Add(comboBox28);hili.Add(comboBox29);

            for (int i=0 ; i< hili.Count ; i++)
            {
                loaditem(hili[i]);
            }
        }

        private void tb_load()
        {
            tb= new List<TextBox>();
            tb.Add(tb1); tb.Add(tb2); tb.Add(tb3); tb.Add(tb4); tb.Add(tb5);
            tb.Add(tb6); tb.Add(tb7); tb.Add(tb8); tb.Add(tb9); tb.Add(tb10);
            tb.Add(tb11); tb.Add(tb12); tb.Add(tb13); tb.Add(tb14); tb.Add(tb15);
            tb.Add(tb16); tb.Add(tb17); tb.Add(tb18); tb.Add(tb19); tb.Add(tb20);
            tb.Add(tb21); tb.Add(tb22); tb.Add(tb23); tb.Add(tb24); tb.Add(tb25);
            tb.Add(tb26); tb.Add(tb27); tb.Add(tb28); tb.Add(tb29);

            lb = new List<Label>();
            lb.Add(lb1); lb.Add(lb2); lb.Add(lb3); lb.Add(lb4); lb.Add(lb5);
            lb.Add(lb6); lb.Add(lb7); lb.Add(lb8); lb.Add(lb9); lb.Add(lb10);
            lb.Add(lb11); lb.Add(lb12); lb.Add(lb13); lb.Add(lb14); lb.Add(lb15);
            lb.Add(lb16); lb.Add(lb17); lb.Add(lb18); lb.Add(lb19); lb.Add(lb20);
            lb.Add(lb21); lb.Add(lb22); lb.Add(lb23); lb.Add(lb24); lb.Add(lb25);
            lb.Add(lb26); lb.Add(lb27); lb.Add(lb28); lb.Add(lb29);
        }

        private void buttom_remark_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                hili[i].Items.Clear();
                hili[i].Text = "";
            }

            hightlight_load();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 0)
                {
                    deleteitem(hili[i], int.Parse(comboBox1.Text));
                }
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 8)
                {
                    deleteitem(hili[i], int.Parse(comboBox9.Text));
                }
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 6)
                {
                    deleteitem(hili[i], int.Parse(comboBox7.Text));
                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 4)
                {
                    deleteitem(hili[i], int.Parse(comboBox5.Text));
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 2)
                {
                    deleteitem(hili[i], int.Parse(comboBox3.Text));
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 1)
                {
                    deleteitem(hili[i], int.Parse(comboBox2.Text));
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 3)
                {
                    deleteitem(hili[i], int.Parse(comboBox4.Text));
                }
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 5)
                {
                    deleteitem(hili[i], int.Parse(comboBox6.Text));
                }
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 7)
                {
                    deleteitem(hili[i], int.Parse(comboBox8.Text));
                }
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 9)
                {
                    deleteitem(hili[i], int.Parse(comboBox10.Text));
                }
            }
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 11)
                {
                    deleteitem(hili[i], int.Parse(comboBox12.Text));
                }
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 10)
                {
                    deleteitem(hili[i], int.Parse(comboBox11.Text));
                }
            }
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 12)
                {
                    deleteitem(hili[i], int.Parse(comboBox13.Text));
                }
            }
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 13)
                {
                    deleteitem(hili[i], int.Parse(comboBox14.Text));
                }
            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 14)
                {
                    deleteitem(hili[i], int.Parse(comboBox15.Text));
                }
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 15)
                {
                    deleteitem(hili[i], int.Parse(comboBox16.Text));
                }
            }
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 17)
                {
                    deleteitem(hili[i], int.Parse(comboBox18.Text));
                }
            }
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 19)
                {
                    deleteitem(hili[i], int.Parse(comboBox20.Text));
                }
            }
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 21)
                {
                    deleteitem(hili[i], int.Parse(comboBox22.Text));
                }
            }
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 16)
                {
                    deleteitem(hili[i], int.Parse(comboBox17.Text));
                }
            }
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 18)
                {
                    deleteitem(hili[i], int.Parse(comboBox19.Text));
                }
            }
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 20)
                {
                    deleteitem(hili[i], int.Parse(comboBox21.Text));
                }
            }
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 22)
                {
                    deleteitem(hili[i], int.Parse(comboBox23.Text));
                }
            }
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 24)
                {
                    deleteitem(hili[i], int.Parse(comboBox25.Text));
                }
            }
        }

        private void comboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 26)
                {
                    deleteitem(hili[i], int.Parse(comboBox27.Text));
                }
            }
        }

        private void comboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 28)
                {
                    deleteitem(hili[i], int.Parse(comboBox29.Text));
                }
            }
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 23)
                {
                    deleteitem(hili[i], int.Parse(comboBox24.Text));
                }
            }
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 25)
                {
                    deleteitem(hili[i], int.Parse(comboBox26.Text));
                }
            }
        }

        private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hili.Count; i++)
            {
                if (i != 27)
                {
                    deleteitem(hili[i], int.Parse(comboBox28.Text));
                }
            }
        }
    }
}
