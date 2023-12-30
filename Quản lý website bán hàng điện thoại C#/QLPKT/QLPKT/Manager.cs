using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLPKT
{
    public partial class Manager : Form
    {
        public string pass;
        public string name;
        public string id;
        public string manager;
        public SqlConnection conn;

        public Manager(string pass1, string name1, string id1,string manager1,SqlConnection conn1)
        {
            InitializeComponent();
            pass = pass1;
            name = name1;
            id = id1;
            manager = manager1;
            conn = conn1;
            Connect c = new Connect();
            conn = c.GetConnect();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome " + name + manager;
            label_userlogin.Text = "User ID: " + id;
            menu_customer_con.Visible = false;
            menu_home_con.Visible = true;
            menu_products_con.Visible = false;
            menu_employee_con.Visible = false;
            menu_invoice_con.Visible = false;
            menu_statistics_con.Visible = false;

            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Manager where MaM='" + manager + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((bool)reader["MASTER"] != true)
                {
                    //Home
                    if ((bool)reader["MI_VIEW"] == true)
                        myInfomation.Visible = true;
                    else
                        myInfomation.Visible = false;
                    if ((bool)reader["MI_CHANGE"] == true)
                        changePassword.Visible = true;
                    else
                        changePassword.Visible = false;
                    //Employee
                    if ((bool)reader["ME_VIEW"] == false && (bool)reader["ME_ADD"]==false)
                    {
                        menu_employee.Visible = false;
                    }
                    else
                    {
                        menu_employee_per.Visible = false;
                        if ((bool)reader["ME_VIEW"] == true)
                            menu_employee_view.Visible = true;
                        else
                            menu_employee_view.Visible = false;
                        if ((bool)reader["ME_ADD"] == true)
                            menu_employee_add.Visible = true;
                        else
                            menu_employee_add.Visible = false;
                    }
                    //Customer
                    if ((bool)reader["MC_VIEW"] == false && (bool)reader["MC_ADD"] == false)
                    {
                        menu_customer.Visible = false;
                    }
                    else
                    {
                        if ((bool)reader["MC_VIEW"] == true)
                            menu_customer_view.Visible = true;
                        else
                            menu_customer_view.Visible = false;
                        if ((bool)reader["MC_ADD"] == true)
                            menu_customer_add.Visible = true;
                        else
                            menu_customer_add.Visible = false;
                    }
                    //Product
                    if ((bool)reader["MP_VIEW"] == false && (bool)reader["MP_ADD"] == false && (bool)reader["MM_VIEW"] == false && (bool)reader["MM_ADD"] == false)
                    {
                        menu_products.Visible = false;
                    }
                    else
                    {
                        if ((bool)reader["MP_VIEW"] == true)
                            menu_products_view.Visible = true;
                        else
                            menu_products_view.Visible = false;
                        if ((bool)reader["MP_ADD"] == true)
                            menu_products_add.Visible = true;
                        else
                            menu_products_add.Visible = false;
                        if ((bool)reader["MM_VIEW"] == true)
                            menu_factory_view.Visible = true;
                        else
                            menu_factory_view.Visible = false;
                        if ((bool)reader["MM_ADD"] == true)
                            menu_factory_add.Visible = true;
                        else
                            menu_factory_add.Visible = false;
                    }
                    //Invoice
                    if ((bool)reader["MS_VIEW"] == false && (bool)reader["MS_ADD"] == false && (bool)reader["MB_VIEW"] == false && (bool)reader["MB_ADD"] == false)
                    {
                        menu_invoice.Visible = false;
                    }
                    else
                    {
                        if ((bool)reader["MS_VIEW"] == true)
                            InvoiceSale_view.Visible = true;
                        else
                            InvoiceSale_view.Visible = false;
                        if ((bool)reader["MS_ADD"] == true)
                            InvoiceSale_add.Visible = true;
                        else
                            InvoiceSale_add.Visible = false;
                        if ((bool)reader["MB_VIEW"] == true)
                            Invoicebuy_view.Visible = true;
                        else
                            Invoicebuy_view.Visible = false;
                        if ((bool)reader["MB_ADD"] == true)
                            Invoicebuy_add.Visible = true;
                        else
                            Invoicebuy_add.Visible = false;
                    }
                    //Statictis
                    if ((bool)reader["ST_VIEW"] == false)
                    {
                        menu_statistics.Visible = false;
                    }
                }
            }
            reader.Close();
            conn.Close();
        }

        private void buttom_exit_Click(object sender, EventArgs e)
        {
            //Login l = new Login();
            //l.Show();
            this.Close();
        }

        // Nhúng Form con vao pannel chính
        public void nhung(Form f)
        {
            //foreach (Control ctl in panel3.Controls)
            //ctl.Dispose();
            panel_nd.Controls.Clear();//Xõa các control trong form cũ
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;//quan trọng là dòng này thiếu là chít
            f.Visible = true;
            f.Dock = DockStyle.Fill;
            panel_nd.Controls.Add(f);//thêm form mới vào panel
            panel_nd.Show();
        }

        //Cụm menu Home
        private void menu_home_Click(object sender, EventArgs e)
        {
            Home h = new Home(name);
            nhung(h);

            menu_home_con.Visible = true;
            menu_customer_con.Visible = false;
            menu_products_con.Visible = false;
            menu_employee_con.Visible = false;
            menu_invoice_con.Visible = false;
            menu_statistics_con.Visible = false;

            myInfomation.BackColor = Color.OrangeRed;
            myInfomation.ForeColor = Color.White;
            myInfomation.Image = Image.FromFile(@"Image\menu_mat2.png");

            changePassword.BackColor = Color.OrangeRed;
            changePassword.ForeColor = Color.White;
            changePassword.Image = Image.FromFile(@"Image\menu_khoa2.png");

            accessPermission.BackColor = Color.OrangeRed;
            accessPermission.ForeColor = Color.White;
            accessPermission.Image = Image.FromFile(@"Image\menu_quyen2.png");
        }

        private void myInfomation_Click(object sender, EventArgs e)
        {
            Myinfo m = new Myinfo(id, pass, name, id,conn);
            nhung(m);
            
            myInfomation.BackColor = Color.White;
            myInfomation.ForeColor = Color.OrangeRed;
            myInfomation.Image = Image.FromFile(@"Image\menu_mat.png");

            changePassword.BackColor = Color.OrangeRed;
            changePassword.ForeColor = Color.White;
            changePassword.Image = Image.FromFile(@"Image\menu_khoa2.png");

            accessPermission.BackColor = Color.OrangeRed;
            accessPermission.ForeColor = Color.White;
            accessPermission.Image = Image.FromFile(@"Image\menu_quyen2.png");
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            changePassword.BackColor = Color.White;
            changePassword.ForeColor = Color.OrangeRed;
            changePassword.Image = Image.FromFile(@"Image\menu_khoa.png");

            myInfomation.BackColor = Color.OrangeRed;
            myInfomation.ForeColor = Color.White;
            myInfomation.Image = Image.FromFile(@"Image\menu_mat2.png");

            accessPermission.BackColor = Color.OrangeRed;
            accessPermission.ForeColor = Color.White;
            accessPermission.Image = Image.FromFile(@"Image\menu_quyen2.png");

            Changepass c = new Changepass(id, pass,conn);
            nhung(c);
        }

        private void accessPermission_Click(object sender, EventArgs e)
        {
            Permission p = new Permission(manager,conn);
            nhung(p);
            
            accessPermission.BackColor = Color.White;
            accessPermission.ForeColor = Color.OrangeRed;
            accessPermission.Image = Image.FromFile(@"Image\menu_quyen.png");

            myInfomation.BackColor = Color.OrangeRed;
            myInfomation.ForeColor = Color.White;
            myInfomation.Image = Image.FromFile(@"Image\menu_mat2.png");

            changePassword.BackColor = Color.OrangeRed;
            changePassword.ForeColor = Color.White;
            changePassword.Image = Image.FromFile(@"Image\menu_khoa2.png");
        }

        //Cụm menu Employee
        private void menu_employee_Click(object sender, EventArgs e)
        {
            menu_employee_con.Visible = true;
            menu_home_con.Visible = false;
            menu_customer_con.Visible = false;
            menu_products_con.Visible = false;
            menu_invoice_con.Visible = false;
            menu_statistics_con.Visible = false;

            menu_employee_view.BackColor = Color.OrangeRed;
            menu_employee_view.ForeColor = Color.White;
            menu_employee_view.Image = Image.FromFile(@"Image\menu_view2.png");

            menu_employee_add.BackColor = Color.OrangeRed;
            menu_employee_add.ForeColor = Color.White;
            menu_employee_add.Image = Image.FromFile(@"Image\menu_add2.png");

            menu_employee_per.BackColor = Color.OrangeRed;
            menu_employee_per.ForeColor = Color.White;
            menu_employee_per.Image = Image.FromFile(@"Image\menu_khoa2.png");

            Employee_Home eh = new Employee_Home();
            nhung(eh);
        }

        private void menu_employee_view_Click(object sender, EventArgs e)
        {
            
            Employee_View ev = new Employee_View(conn,manager,id);
            nhung(ev);
            
            menu_employee_view.BackColor = Color.White;
            menu_employee_view.ForeColor = Color.OrangeRed;
            menu_employee_view.Image = Image.FromFile(@"Image\menu_view.png");

            menu_employee_add.BackColor = Color.OrangeRed;
            menu_employee_add.ForeColor = Color.White;
            menu_employee_add.Image = Image.FromFile(@"Image\menu_add2.png");

            menu_employee_per.BackColor = Color.OrangeRed;
            menu_employee_per.ForeColor = Color.White;
            menu_employee_per.Image = Image.FromFile(@"Image\menu_khoa2.png");
        }

        private void menu_employee_add_Click(object sender, EventArgs e)
        {
            Employee_Add ed = new Employee_Add(conn);
            nhung(ed);
            
            menu_employee_add.BackColor = Color.White;
            menu_employee_add.ForeColor = Color.OrangeRed;
            menu_employee_add.Image = Image.FromFile(@"Image\menu_add.png");

            menu_employee_view.BackColor = Color.OrangeRed;
            menu_employee_view.ForeColor = Color.White;
            menu_employee_view.Image = Image.FromFile(@"Image\menu_view2.png");

            menu_employee_per.BackColor = Color.OrangeRed;
            menu_employee_per.ForeColor = Color.White;
            menu_employee_per.Image = Image.FromFile(@"Image\menu_khoa2.png");

        }

        private void menu_employee_per_Click(object sender, EventArgs e)
        {
            Employee_MP mp = new Employee_MP();
            nhung(mp);

            menu_employee_per.BackColor = Color.White;
            menu_employee_per.ForeColor = Color.OrangeRed;
            menu_employee_per.Image = Image.FromFile(@"Image\menu_khoa.png");

            menu_employee_add.BackColor = Color.OrangeRed;
            menu_employee_add.ForeColor = Color.White;
            menu_employee_add.Image = Image.FromFile(@"Image\menu_add2.png");

            menu_employee_view.BackColor = Color.OrangeRed;
            menu_employee_view.ForeColor = Color.White;
            menu_employee_view.Image = Image.FromFile(@"Image\menu_view2.png");
        }

        //Cụm menu Customer
        private void menu_customer_Click(object sender, EventArgs e)
        {
            Customer_Home ch = new Customer_Home();
            nhung(ch);

            menu_customer_con.Visible = true;
            menu_home_con.Visible = false;
            menu_products_con.Visible = false;
            menu_employee_con.Visible = false;
            menu_invoice_con.Visible = false;
            menu_statistics_con.Visible = false;

            menu_customer_add.BackColor = Color.OrangeRed;
            menu_customer_add.ForeColor = Color.White;
            menu_customer_add.Image = Image.FromFile(@"Image\menu_add2.png");

            menu_customer_view.BackColor = Color.OrangeRed;
            menu_customer_view.ForeColor = Color.White;
            menu_customer_view.Image = Image.FromFile(@"Image\menu_view2.png");

            menu_customer_feed.BackColor = Color.OrangeRed;
            menu_customer_feed.ForeColor = Color.White;
            menu_customer_feed.Image = Image.FromFile(@"Image\menu_feed2.png");
        }

        private void menu_customer_view_Click(object sender, EventArgs e)
        {
            Customer_View cv = new Customer_View(conn,manager);
            nhung(cv);

            menu_customer_view.BackColor = Color.White;
            menu_customer_view.ForeColor = Color.OrangeRed;
            menu_customer_view.Image = Image.FromFile(@"Image\menu_view.png");

            menu_customer_add.BackColor = Color.OrangeRed;
            menu_customer_add.ForeColor = Color.White;
            menu_customer_add.Image = Image.FromFile(@"Image\menu_add2.png");

            menu_customer_feed.BackColor = Color.OrangeRed;
            menu_customer_feed.ForeColor = Color.White;
            menu_customer_feed.Image = Image.FromFile(@"Image\menu_feed2.png");
        }

        private void menu_customer_add_Click(object sender, EventArgs e)
        {
            Customer_Add ca = new Customer_Add(conn);
            nhung(ca);

            menu_customer_add.BackColor = Color.White;
            menu_customer_add.ForeColor = Color.OrangeRed;
            menu_customer_add.Image = Image.FromFile(@"Image\menu_add.png");

            menu_customer_view.BackColor = Color.OrangeRed;
            menu_customer_view.ForeColor = Color.White;
            menu_customer_view.Image = Image.FromFile(@"Image\menu_view2.png");

            menu_customer_feed.BackColor = Color.OrangeRed;
            menu_customer_feed.ForeColor = Color.White;
            menu_customer_feed.Image = Image.FromFile(@"Image\menu_feed2.png");
        }

        private void menu_customer_feed_Click(object sender, EventArgs e)
        {
            Customer_Feedback f = new Customer_Feedback();
            nhung(f);

            menu_customer_add.BackColor = Color.OrangeRed;
            menu_customer_add.ForeColor = Color.White;
            menu_customer_add.Image = Image.FromFile(@"Image\menu_add2.png");

            menu_customer_view.BackColor = Color.OrangeRed;
            menu_customer_view.ForeColor = Color.White;
            menu_customer_view.Image = Image.FromFile(@"Image\menu_view2.png");

            menu_customer_feed.BackColor = Color.White;
            menu_customer_feed.ForeColor = Color.OrangeRed;
            menu_customer_feed.Image = Image.FromFile(@"Image\menu_feed.png");
        }

        //Cụm menu Product
        private void menu_products_Click(object sender, EventArgs e)
        {
            Product_Home ph = new Product_Home();
            nhung(ph);

            menu_products_con.Visible = true;
            menu_customer_con.Visible = false;
            menu_home_con.Visible = false;           
            menu_employee_con.Visible = false;
            menu_invoice_con.Visible = false;
            menu_statistics_con.Visible = false;

            menu_factory_add.BackColor = Color.OrangeRed;
            menu_factory_add.ForeColor = Color.White;
            menu_factory_add.Image = Image.FromFile(@"Image\menu_add2.png");

            menu_factory_view.BackColor = Color.OrangeRed;
            menu_factory_view.ForeColor = Color.White;
            menu_factory_view.Image = Image.FromFile(@"Image\menu_view2.png");

            menu_products_add.BackColor = Color.OrangeRed;
            menu_products_add.ForeColor = Color.White;
            menu_products_add.Image = Image.FromFile(@"Image\menu_add2.png");

            menu_products_view.BackColor = Color.OrangeRed;
            menu_products_view.ForeColor = Color.White;
            menu_products_view.Image = Image.FromFile(@"Image\menu_view2.png");
        }

        private void menu_products_view_Click(object sender, EventArgs e)
        {
            Products_View pv = new Products_View(conn,manager);
            nhung(pv);

            menu_products_view.BackColor = Color.White;
            menu_products_view.ForeColor = Color.OrangeRed;
            menu_products_view.Image=Image.FromFile(@"Image\menu_view.png");

            menu_products_add.BackColor = Color.OrangeRed;
            menu_products_add.ForeColor = Color.White;
            menu_products_add.Image = Image.FromFile(@"Image\menu_add2.png");

            menu_factory_view.BackColor = Color.OrangeRed;
            menu_factory_view.ForeColor = Color.White;
            menu_factory_view.Image = Image.FromFile(@"Image\menu_view2.png");

            menu_factory_add.BackColor = Color.OrangeRed;
            menu_factory_add.ForeColor = Color.White;
            menu_factory_add.Image = Image.FromFile(@"Image\menu_add2.png");
        }

        private void menu_products_add_Click(object sender, EventArgs e)
        {
            Products_Add pa = new Products_Add(conn);
            nhung(pa);

            menu_products_add.BackColor = Color.White;
            menu_products_add.ForeColor = Color.OrangeRed;
            menu_products_add.Image = Image.FromFile(@"Image\menu_add.png");

            menu_products_view.BackColor = Color.OrangeRed;
            menu_products_view.ForeColor = Color.White;
            menu_products_view.Image = Image.FromFile(@"Image\menu_view2.png");

            menu_factory_view.BackColor = Color.OrangeRed;
            menu_factory_view.ForeColor = Color.White;
            menu_factory_view.Image = Image.FromFile(@"Image\menu_view2.png");

            menu_factory_add.BackColor = Color.OrangeRed;
            menu_factory_add.ForeColor = Color.White;
            menu_factory_add.Image = Image.FromFile(@"Image\menu_add2.png");
        }

        private void menu_factory_view_Click(object sender, EventArgs e)
        {
            Factory_View fv = new Factory_View(conn,manager);
            nhung(fv);

            //Display
            menu_factory_view.BackColor = Color.White;
            menu_factory_view.ForeColor = Color.OrangeRed;
            menu_factory_view.Image = Image.FromFile(@"Image\menu_view.png");

            menu_products_add.BackColor = Color.OrangeRed;
            menu_products_add.ForeColor = Color.White;
            menu_products_add.Image = Image.FromFile(@"Image\menu_add2.png");

            menu_products_view.BackColor = Color.OrangeRed;
            menu_products_view.ForeColor = Color.White;
            menu_products_view.Image = Image.FromFile(@"Image\menu_view2.png");

            menu_factory_add.BackColor = Color.OrangeRed;
            menu_factory_add.ForeColor = Color.White;
            menu_factory_add.Image = Image.FromFile(@"Image\menu_add2.png");
        }

        private void menu_factory_add_Click(object sender, EventArgs e)
        {
            Factory_Add fa = new Factory_Add(conn);
            nhung(fa);

            //Display
            menu_factory_add.BackColor = Color.White;
            menu_factory_add.ForeColor = Color.OrangeRed;
            menu_factory_add.Image = Image.FromFile(@"Image\menu_add.png");

            menu_factory_view.BackColor = Color.OrangeRed;
            menu_factory_view.ForeColor = Color.White;
            menu_factory_view.Image = Image.FromFile(@"Image\menu_view2.png");

            menu_products_add.BackColor = Color.OrangeRed;
            menu_products_add.ForeColor = Color.White;
            menu_products_add.Image = Image.FromFile(@"Image\menu_add2.png");

            menu_products_view.BackColor = Color.OrangeRed;
            menu_products_view.ForeColor = Color.White;
            menu_products_view.Image = Image.FromFile(@"Image\menu_view2.png");
        }

        //Cụm menu statistics
        private void menu_statistics_Click(object sender, EventArgs e)
        {
            Statistics_Home sh = new Statistics_Home();
            nhung(sh);

            menu_statistics_con.Visible = true;
            menu_customer_con.Visible = false;
            menu_home_con.Visible = false;
            menu_products_con.Visible = false;
            menu_employee_con.Visible = false;
            menu_invoice_con.Visible = false;
        }

        private void menu_statistics_grow_Click(object sender, EventArgs e)
        {
            Statistic_Growth g = new Statistic_Growth();
            nhung(g);
        }

        //Cụm Invoice
        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice_Home f = new Invoice_Home();
            nhung(f);

            menu_invoice_con.Visible=true;
            menu_customer_con.Visible = false;
            menu_home_con.Visible = false;
            menu_products_con.Visible = false;
            menu_employee_con.Visible = false;

            Invoicebuy_view.BackColor = Color.OrangeRed;
            Invoicebuy_view.ForeColor = Color.White;
            Invoicebuy_view.Image = Image.FromFile(@"Image\menu_view2.png");

            Invoicebuy_add.BackColor = Color.OrangeRed;
            Invoicebuy_add.ForeColor = Color.White;
            Invoicebuy_add.Image = Image.FromFile(@"Image\menu_add2.png");

            InvoiceSale_view.BackColor = Color.OrangeRed;
            InvoiceSale_view.ForeColor = Color.White;
            InvoiceSale_view.Image = Image.FromFile(@"Image\menu_view2.png");

            InvoiceSale_add.BackColor = Color.OrangeRed;
            InvoiceSale_add.ForeColor = Color.White;
            InvoiceSale_add.Image = Image.FromFile(@"Image\menu_add2.png");
        }
        
        private void Invoicebuy_view_Click(object sender, EventArgs e)
        {
            Invoice_buy_view ia = new Invoice_buy_view(name,id);
            nhung(ia);

            Invoicebuy_view.BackColor = Color.White;
            Invoicebuy_view.ForeColor = Color.OrangeRed;
            Invoicebuy_view.Image = Image.FromFile(@"Image\menu_view.png");

            Invoicebuy_add.BackColor = Color.OrangeRed;
            Invoicebuy_add.ForeColor = Color.White;
            Invoicebuy_add.Image = Image.FromFile(@"Image\menu_add2.png");

            InvoiceSale_view.BackColor = Color.OrangeRed;
            InvoiceSale_view.ForeColor = Color.White;
            InvoiceSale_view.Image = Image.FromFile(@"Image\menu_view2.png");

            InvoiceSale_add.BackColor = Color.OrangeRed;
            InvoiceSale_add.ForeColor = Color.White;
            InvoiceSale_add.Image = Image.FromFile(@"Image\menu_add2.png");
        }

        private void Invoicebuy_add_Click(object sender, EventArgs e)
        {
            Invoice_buy_add ib = new Invoice_buy_add();
            nhung(ib);

            Invoicebuy_add.BackColor = Color.White;
            Invoicebuy_add.ForeColor = Color.OrangeRed;
            Invoicebuy_add.Image = Image.FromFile(@"Image\menu_add.png");

            Invoicebuy_view.BackColor = Color.OrangeRed;
            Invoicebuy_view.ForeColor = Color.White;
            Invoicebuy_view.Image = Image.FromFile(@"Image\menu_view2.png");

            InvoiceSale_view.BackColor = Color.OrangeRed;
            InvoiceSale_view.ForeColor = Color.White;
            InvoiceSale_view.Image = Image.FromFile(@"Image\menu_view2.png");

            InvoiceSale_add.BackColor = Color.OrangeRed;
            InvoiceSale_add.ForeColor = Color.White;
            InvoiceSale_add.Image = Image.FromFile(@"Image\menu_add2.png");
        }

        private void InvoiceSale_view_Click(object sender, EventArgs e)
        {
            Invoice_sale_view iv = new Invoice_sale_view(name, id);
            nhung(iv);

            InvoiceSale_view.BackColor = Color.White;
            InvoiceSale_view.ForeColor = Color.OrangeRed;
            InvoiceSale_view.Image = Image.FromFile(@"Image\menu_view.png");

            InvoiceSale_add.BackColor = Color.OrangeRed;
            InvoiceSale_add.ForeColor = Color.White;
            InvoiceSale_add.Image = Image.FromFile(@"Image\menu_add2.png");

            Invoicebuy_add.BackColor = Color.OrangeRed;
            Invoicebuy_add.ForeColor = Color.White;
            Invoicebuy_add.Image = Image.FromFile(@"Image\menu_add2.png");

            Invoicebuy_view.BackColor = Color.OrangeRed;
            Invoicebuy_view.ForeColor = Color.White;
            Invoicebuy_view.Image = Image.FromFile(@"Image\menu_view2.png");
        }

        private void InvoiceSale_add_Click(object sender, EventArgs e)
        {
            Invoice_sale_add ia = new Invoice_sale_add(name, id);
            nhung(ia);

            InvoiceSale_add.BackColor = Color.White;
            InvoiceSale_add.ForeColor = Color.OrangeRed;
            InvoiceSale_add.Image = Image.FromFile(@"Image\menu_add.png");

            InvoiceSale_view.BackColor = Color.OrangeRed;
            InvoiceSale_view.ForeColor = Color.White;
            InvoiceSale_view.Image = Image.FromFile(@"Image\menu_view2.png");

            Invoicebuy_add.BackColor = Color.OrangeRed;
            Invoicebuy_add.ForeColor = Color.White;
            Invoicebuy_add.Image = Image.FromFile(@"Image\menu_add2.png");

            Invoicebuy_view.BackColor = Color.OrangeRed;
            Invoicebuy_view.ForeColor = Color.White;
            Invoicebuy_view.Image = Image.FromFile(@"Image\menu_view2.png");
        }

        private void menu_statistics_math_Click(object sender, EventArgs e)
        {
            Statistics_Math sm = new Statistics_Math();
            nhung(sm);
        }     

    }
}
