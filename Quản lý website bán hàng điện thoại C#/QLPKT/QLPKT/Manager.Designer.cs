namespace QLPKT
{
    partial class Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu_chu = new System.Windows.Forms.MenuStrip();
            this.menu_home = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_customer = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_products = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_invoice = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_statistics = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_left = new System.Windows.Forms.Panel();
            this.menu_invoice_con = new System.Windows.Forms.MenuStrip();
            this.Invoicebuy_view = new System.Windows.Forms.ToolStripMenuItem();
            this.Invoicebuy_add = new System.Windows.Forms.ToolStripMenuItem();
            this.InvoiceSale_view = new System.Windows.Forms.ToolStripMenuItem();
            this.InvoiceSale_add = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_statistics_con = new System.Windows.Forms.MenuStrip();
            this.menu_statistics_grow = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_statistics_math = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_customer_con = new System.Windows.Forms.MenuStrip();
            this.menu_customer_view = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_customer_add = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_customer_feed = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_products_con = new System.Windows.Forms.MenuStrip();
            this.menu_products_view = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_products_add = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_factory_view = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_factory_add = new System.Windows.Forms.ToolStripMenuItem();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.panel_exit = new System.Windows.Forms.Panel();
            this.buttom_exit = new System.Windows.Forms.PictureBox();
            this.label_thoat = new System.Windows.Forms.Label();
            this.label_userlogin = new System.Windows.Forms.Label();
            this.menu_home_con = new System.Windows.Forms.MenuStrip();
            this.myInfomation = new System.Windows.Forms.ToolStripMenuItem();
            this.accessPermission = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_employee_con = new System.Windows.Forms.MenuStrip();
            this.menu_employee_view = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_employee_add = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_employee_per = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_nd = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.menu_chu.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.menu_invoice_con.SuspendLayout();
            this.menu_statistics_con.SuspendLayout();
            this.menu_customer_con.SuspendLayout();
            this.menu_products_con.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.panel_exit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_exit)).BeginInit();
            this.menu_home_con.SuspendLayout();
            this.menu_employee_con.SuspendLayout();
            this.panel_nd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(65, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 10);
            this.panel1.TabIndex = 1;
            // 
            // menu_chu
            // 
            this.menu_chu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_chu.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menu_chu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_home,
            this.menu_employee,
            this.menu_customer,
            this.menu_products,
            this.menu_invoice,
            this.menu_statistics});
            this.menu_chu.Location = new System.Drawing.Point(0, 0);
            this.menu_chu.Name = "menu_chu";
            this.menu_chu.Size = new System.Drawing.Size(1084, 58);
            this.menu_chu.TabIndex = 2;
            this.menu_chu.Text = "menuStrip1";
            // 
            // menu_home
            // 
            this.menu_home.ForeColor = System.Drawing.Color.OrangeRed;
            this.menu_home.Image = ((System.Drawing.Image)(resources.GetObject("menu_home.Image")));
            this.menu_home.Name = "menu_home";
            this.menu_home.Size = new System.Drawing.Size(118, 54);
            this.menu_home.Text = "Home";
            this.menu_home.Click += new System.EventHandler(this.menu_home_Click);
            // 
            // menu_employee
            // 
            this.menu_employee.ForeColor = System.Drawing.Color.OrangeRed;
            this.menu_employee.Image = ((System.Drawing.Image)(resources.GetObject("menu_employee.Image")));
            this.menu_employee.Name = "menu_employee";
            this.menu_employee.Size = new System.Drawing.Size(149, 54);
            this.menu_employee.Text = "Employee";
            this.menu_employee.Click += new System.EventHandler(this.menu_employee_Click);
            // 
            // menu_customer
            // 
            this.menu_customer.ForeColor = System.Drawing.Color.OrangeRed;
            this.menu_customer.Image = ((System.Drawing.Image)(resources.GetObject("menu_customer.Image")));
            this.menu_customer.Name = "menu_customer";
            this.menu_customer.Size = new System.Drawing.Size(148, 54);
            this.menu_customer.Text = "Customer";
            this.menu_customer.Click += new System.EventHandler(this.menu_customer_Click);
            // 
            // menu_products
            // 
            this.menu_products.ForeColor = System.Drawing.Color.OrangeRed;
            this.menu_products.Image = ((System.Drawing.Image)(resources.GetObject("menu_products.Image")));
            this.menu_products.Name = "menu_products";
            this.menu_products.Size = new System.Drawing.Size(142, 54);
            this.menu_products.Text = "Products";
            this.menu_products.Click += new System.EventHandler(this.menu_products_Click);
            // 
            // menu_invoice
            // 
            this.menu_invoice.ForeColor = System.Drawing.Color.OrangeRed;
            this.menu_invoice.Image = ((System.Drawing.Image)(resources.GetObject("menu_invoice.Image")));
            this.menu_invoice.Name = "menu_invoice";
            this.menu_invoice.Size = new System.Drawing.Size(128, 54);
            this.menu_invoice.Text = "Invoice";
            this.menu_invoice.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // menu_statistics
            // 
            this.menu_statistics.ForeColor = System.Drawing.Color.OrangeRed;
            this.menu_statistics.Image = ((System.Drawing.Image)(resources.GetObject("menu_statistics.Image")));
            this.menu_statistics.Name = "menu_statistics";
            this.menu_statistics.Size = new System.Drawing.Size(146, 54);
            this.menu_statistics.Text = "Statistics";
            this.menu_statistics.Click += new System.EventHandler(this.menu_statistics_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 10);
            this.panel2.TabIndex = 3;
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_left.Controls.Add(this.menu_invoice_con);
            this.panel_left.Controls.Add(this.menu_statistics_con);
            this.panel_left.Controls.Add(this.menu_customer_con);
            this.panel_left.Controls.Add(this.menu_products_con);
            this.panel_left.Controls.Add(this.picture1);
            this.panel_left.Controls.Add(this.panel_exit);
            this.panel_left.Controls.Add(this.menu_home_con);
            this.panel_left.Controls.Add(this.menu_employee_con);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 68);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(250, 484);
            this.panel_left.TabIndex = 4;
            // 
            // menu_invoice_con
            // 
            this.menu_invoice_con.AutoSize = false;
            this.menu_invoice_con.BackColor = System.Drawing.Color.OrangeRed;
            this.menu_invoice_con.Dock = System.Windows.Forms.DockStyle.None;
            this.menu_invoice_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_invoice_con.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menu_invoice_con.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Invoicebuy_view,
            this.Invoicebuy_add,
            this.InvoiceSale_view,
            this.InvoiceSale_add});
            this.menu_invoice_con.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menu_invoice_con.Location = new System.Drawing.Point(11, 102);
            this.menu_invoice_con.Name = "menu_invoice_con";
            this.menu_invoice_con.Size = new System.Drawing.Size(241, 149);
            this.menu_invoice_con.TabIndex = 10;
            // 
            // Invoicebuy_view
            // 
            this.Invoicebuy_view.ForeColor = System.Drawing.Color.White;
            this.Invoicebuy_view.Image = ((System.Drawing.Image)(resources.GetObject("Invoicebuy_view.Image")));
            this.Invoicebuy_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Invoicebuy_view.Name = "Invoicebuy_view";
            this.Invoicebuy_view.Size = new System.Drawing.Size(234, 34);
            this.Invoicebuy_view.Text = "View invoice buy";
            this.Invoicebuy_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Invoicebuy_view.Click += new System.EventHandler(this.Invoicebuy_view_Click);
            // 
            // Invoicebuy_add
            // 
            this.Invoicebuy_add.ForeColor = System.Drawing.Color.White;
            this.Invoicebuy_add.Image = ((System.Drawing.Image)(resources.GetObject("Invoicebuy_add.Image")));
            this.Invoicebuy_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Invoicebuy_add.Name = "Invoicebuy_add";
            this.Invoicebuy_add.Size = new System.Drawing.Size(234, 34);
            this.Invoicebuy_add.Text = "Add new invoice buy";
            this.Invoicebuy_add.Click += new System.EventHandler(this.Invoicebuy_add_Click);
            // 
            // InvoiceSale_view
            // 
            this.InvoiceSale_view.ForeColor = System.Drawing.Color.White;
            this.InvoiceSale_view.Image = ((System.Drawing.Image)(resources.GetObject("InvoiceSale_view.Image")));
            this.InvoiceSale_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InvoiceSale_view.Name = "InvoiceSale_view";
            this.InvoiceSale_view.Size = new System.Drawing.Size(234, 34);
            this.InvoiceSale_view.Text = "View invoice sale";
            this.InvoiceSale_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InvoiceSale_view.Click += new System.EventHandler(this.InvoiceSale_view_Click);
            // 
            // InvoiceSale_add
            // 
            this.InvoiceSale_add.ForeColor = System.Drawing.Color.White;
            this.InvoiceSale_add.Image = ((System.Drawing.Image)(resources.GetObject("InvoiceSale_add.Image")));
            this.InvoiceSale_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InvoiceSale_add.Name = "InvoiceSale_add";
            this.InvoiceSale_add.Size = new System.Drawing.Size(234, 34);
            this.InvoiceSale_add.Text = "Add new invoice sale";
            this.InvoiceSale_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InvoiceSale_add.Click += new System.EventHandler(this.InvoiceSale_add_Click);
            // 
            // menu_statistics_con
            // 
            this.menu_statistics_con.AutoSize = false;
            this.menu_statistics_con.BackColor = System.Drawing.Color.OrangeRed;
            this.menu_statistics_con.Dock = System.Windows.Forms.DockStyle.None;
            this.menu_statistics_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_statistics_con.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menu_statistics_con.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_statistics_grow,
            this.menu_statistics_math});
            this.menu_statistics_con.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menu_statistics_con.Location = new System.Drawing.Point(11, 102);
            this.menu_statistics_con.Name = "menu_statistics_con";
            this.menu_statistics_con.Size = new System.Drawing.Size(241, 136);
            this.menu_statistics_con.TabIndex = 9;
            // 
            // menu_statistics_grow
            // 
            this.menu_statistics_grow.ForeColor = System.Drawing.Color.White;
            this.menu_statistics_grow.Image = ((System.Drawing.Image)(resources.GetObject("menu_statistics_grow.Image")));
            this.menu_statistics_grow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_statistics_grow.Name = "menu_statistics_grow";
            this.menu_statistics_grow.Size = new System.Drawing.Size(234, 34);
            this.menu_statistics_grow.Text = "Growth rate deverlop";
            this.menu_statistics_grow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_statistics_grow.Click += new System.EventHandler(this.menu_statistics_grow_Click);
            // 
            // menu_statistics_math
            // 
            this.menu_statistics_math.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_statistics_math.Image = ((System.Drawing.Image)(resources.GetObject("menu_statistics_math.Image")));
            this.menu_statistics_math.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_statistics_math.Name = "menu_statistics_math";
            this.menu_statistics_math.Size = new System.Drawing.Size(234, 34);
            this.menu_statistics_math.Text = "Statistic";
            this.menu_statistics_math.Click += new System.EventHandler(this.menu_statistics_math_Click);
            // 
            // menu_customer_con
            // 
            this.menu_customer_con.AutoSize = false;
            this.menu_customer_con.BackColor = System.Drawing.Color.OrangeRed;
            this.menu_customer_con.Dock = System.Windows.Forms.DockStyle.None;
            this.menu_customer_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_customer_con.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menu_customer_con.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_customer_view,
            this.menu_customer_add,
            this.menu_customer_feed});
            this.menu_customer_con.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menu_customer_con.Location = new System.Drawing.Point(11, 102);
            this.menu_customer_con.Name = "menu_customer_con";
            this.menu_customer_con.Size = new System.Drawing.Size(241, 130);
            this.menu_customer_con.TabIndex = 8;
            // 
            // menu_customer_view
            // 
            this.menu_customer_view.ForeColor = System.Drawing.Color.White;
            this.menu_customer_view.Image = ((System.Drawing.Image)(resources.GetObject("menu_customer_view.Image")));
            this.menu_customer_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_customer_view.Name = "menu_customer_view";
            this.menu_customer_view.Size = new System.Drawing.Size(234, 34);
            this.menu_customer_view.Text = "View customer";
            this.menu_customer_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_customer_view.Click += new System.EventHandler(this.menu_customer_view_Click);
            // 
            // menu_customer_add
            // 
            this.menu_customer_add.ForeColor = System.Drawing.Color.White;
            this.menu_customer_add.Image = ((System.Drawing.Image)(resources.GetObject("menu_customer_add.Image")));
            this.menu_customer_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_customer_add.Name = "menu_customer_add";
            this.menu_customer_add.Size = new System.Drawing.Size(234, 34);
            this.menu_customer_add.Text = "Add customer";
            this.menu_customer_add.Click += new System.EventHandler(this.menu_customer_add_Click);
            // 
            // menu_customer_feed
            // 
            this.menu_customer_feed.ForeColor = System.Drawing.Color.White;
            this.menu_customer_feed.Image = ((System.Drawing.Image)(resources.GetObject("menu_customer_feed.Image")));
            this.menu_customer_feed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_customer_feed.Name = "menu_customer_feed";
            this.menu_customer_feed.Size = new System.Drawing.Size(234, 34);
            this.menu_customer_feed.Text = "Feedback";
            this.menu_customer_feed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_customer_feed.Click += new System.EventHandler(this.menu_customer_feed_Click);
            // 
            // menu_products_con
            // 
            this.menu_products_con.AutoSize = false;
            this.menu_products_con.BackColor = System.Drawing.Color.OrangeRed;
            this.menu_products_con.Dock = System.Windows.Forms.DockStyle.None;
            this.menu_products_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_products_con.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menu_products_con.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_products_view,
            this.menu_products_add,
            this.menu_factory_view,
            this.menu_factory_add});
            this.menu_products_con.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menu_products_con.Location = new System.Drawing.Point(11, 102);
            this.menu_products_con.Name = "menu_products_con";
            this.menu_products_con.Size = new System.Drawing.Size(241, 176);
            this.menu_products_con.TabIndex = 7;
            // 
            // menu_products_view
            // 
            this.menu_products_view.ForeColor = System.Drawing.Color.White;
            this.menu_products_view.Image = ((System.Drawing.Image)(resources.GetObject("menu_products_view.Image")));
            this.menu_products_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_products_view.Name = "menu_products_view";
            this.menu_products_view.Size = new System.Drawing.Size(234, 34);
            this.menu_products_view.Text = "View products";
            this.menu_products_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_products_view.Click += new System.EventHandler(this.menu_products_view_Click);
            // 
            // menu_products_add
            // 
            this.menu_products_add.ForeColor = System.Drawing.Color.White;
            this.menu_products_add.Image = ((System.Drawing.Image)(resources.GetObject("menu_products_add.Image")));
            this.menu_products_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_products_add.Name = "menu_products_add";
            this.menu_products_add.Size = new System.Drawing.Size(234, 34);
            this.menu_products_add.Text = "Add new products";
            this.menu_products_add.Click += new System.EventHandler(this.menu_products_add_Click);
            // 
            // menu_factory_view
            // 
            this.menu_factory_view.ForeColor = System.Drawing.Color.White;
            this.menu_factory_view.Image = ((System.Drawing.Image)(resources.GetObject("menu_factory_view.Image")));
            this.menu_factory_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_factory_view.Name = "menu_factory_view";
            this.menu_factory_view.Size = new System.Drawing.Size(234, 34);
            this.menu_factory_view.Text = "View manufacturer";
            this.menu_factory_view.Click += new System.EventHandler(this.menu_factory_view_Click);
            // 
            // menu_factory_add
            // 
            this.menu_factory_add.ForeColor = System.Drawing.Color.White;
            this.menu_factory_add.Image = ((System.Drawing.Image)(resources.GetObject("menu_factory_add.Image")));
            this.menu_factory_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_factory_add.Name = "menu_factory_add";
            this.menu_factory_add.Size = new System.Drawing.Size(234, 34);
            this.menu_factory_add.Text = "Add new manufacturer";
            this.menu_factory_add.Click += new System.EventHandler(this.menu_factory_add_Click);
            // 
            // picture1
            // 
            this.picture1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture1.BackgroundImage")));
            this.picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture1.Location = new System.Drawing.Point(89, 6);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(70, 70);
            this.picture1.TabIndex = 5;
            this.picture1.TabStop = false;
            // 
            // panel_exit
            // 
            this.panel_exit.Controls.Add(this.buttom_exit);
            this.panel_exit.Controls.Add(this.label_thoat);
            this.panel_exit.Controls.Add(this.label_userlogin);
            this.panel_exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_exit.Location = new System.Drawing.Point(0, 384);
            this.panel_exit.Name = "panel_exit";
            this.panel_exit.Size = new System.Drawing.Size(250, 100);
            this.panel_exit.TabIndex = 4;
            // 
            // buttom_exit
            // 
            this.buttom_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_exit.BackgroundImage")));
            this.buttom_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_exit.Location = new System.Drawing.Point(11, 60);
            this.buttom_exit.Name = "buttom_exit";
            this.buttom_exit.Size = new System.Drawing.Size(34, 29);
            this.buttom_exit.TabIndex = 2;
            this.buttom_exit.TabStop = false;
            this.buttom_exit.Click += new System.EventHandler(this.buttom_exit_Click);
            // 
            // label_thoat
            // 
            this.label_thoat.AutoSize = true;
            this.label_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_thoat.ForeColor = System.Drawing.Color.White;
            this.label_thoat.Location = new System.Drawing.Point(51, 60);
            this.label_thoat.Name = "label_thoat";
            this.label_thoat.Size = new System.Drawing.Size(55, 16);
            this.label_thoat.TabIndex = 3;
            this.label_thoat.Text = "Logout";
            // 
            // label_userlogin
            // 
            this.label_userlogin.AutoSize = true;
            this.label_userlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userlogin.ForeColor = System.Drawing.Color.White;
            this.label_userlogin.Location = new System.Drawing.Point(51, 76);
            this.label_userlogin.Name = "label_userlogin";
            this.label_userlogin.Size = new System.Drawing.Size(108, 16);
            this.label_userlogin.TabIndex = 1;
            this.label_userlogin.Text = "User Account: ";
            // 
            // menu_home_con
            // 
            this.menu_home_con.AutoSize = false;
            this.menu_home_con.BackColor = System.Drawing.Color.OrangeRed;
            this.menu_home_con.Dock = System.Windows.Forms.DockStyle.None;
            this.menu_home_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_home_con.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menu_home_con.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myInfomation,
            this.accessPermission,
            this.changePassword});
            this.menu_home_con.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menu_home_con.Location = new System.Drawing.Point(11, 102);
            this.menu_home_con.Name = "menu_home_con";
            this.menu_home_con.Size = new System.Drawing.Size(241, 126);
            this.menu_home_con.TabIndex = 0;
            // 
            // myInfomation
            // 
            this.myInfomation.ForeColor = System.Drawing.Color.White;
            this.myInfomation.Image = ((System.Drawing.Image)(resources.GetObject("myInfomation.Image")));
            this.myInfomation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myInfomation.Name = "myInfomation";
            this.myInfomation.Size = new System.Drawing.Size(234, 34);
            this.myInfomation.Text = "My Infomation";
            this.myInfomation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myInfomation.Click += new System.EventHandler(this.myInfomation_Click);
            // 
            // accessPermission
            // 
            this.accessPermission.ForeColor = System.Drawing.Color.White;
            this.accessPermission.Image = ((System.Drawing.Image)(resources.GetObject("accessPermission.Image")));
            this.accessPermission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accessPermission.Name = "accessPermission";
            this.accessPermission.Size = new System.Drawing.Size(234, 34);
            this.accessPermission.Text = "My access permission";
            this.accessPermission.Click += new System.EventHandler(this.accessPermission_Click);
            // 
            // changePassword
            // 
            this.changePassword.ForeColor = System.Drawing.Color.White;
            this.changePassword.Image = ((System.Drawing.Image)(resources.GetObject("changePassword.Image")));
            this.changePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(234, 34);
            this.changePassword.Text = "Change Password";
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // menu_employee_con
            // 
            this.menu_employee_con.AutoSize = false;
            this.menu_employee_con.BackColor = System.Drawing.Color.OrangeRed;
            this.menu_employee_con.Dock = System.Windows.Forms.DockStyle.None;
            this.menu_employee_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_employee_con.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menu_employee_con.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_employee_view,
            this.menu_employee_add,
            this.menu_employee_per});
            this.menu_employee_con.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menu_employee_con.Location = new System.Drawing.Point(11, 102);
            this.menu_employee_con.Name = "menu_employee_con";
            this.menu_employee_con.Size = new System.Drawing.Size(241, 126);
            this.menu_employee_con.TabIndex = 6;
            this.menu_employee_con.Text = "menuStrip1";
            // 
            // menu_employee_view
            // 
            this.menu_employee_view.BackColor = System.Drawing.Color.OrangeRed;
            this.menu_employee_view.ForeColor = System.Drawing.Color.White;
            this.menu_employee_view.Image = ((System.Drawing.Image)(resources.GetObject("menu_employee_view.Image")));
            this.menu_employee_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_employee_view.Name = "menu_employee_view";
            this.menu_employee_view.Size = new System.Drawing.Size(234, 34);
            this.menu_employee_view.Text = "View employee";
            this.menu_employee_view.Click += new System.EventHandler(this.menu_employee_view_Click);
            // 
            // menu_employee_add
            // 
            this.menu_employee_add.ForeColor = System.Drawing.Color.White;
            this.menu_employee_add.Image = ((System.Drawing.Image)(resources.GetObject("menu_employee_add.Image")));
            this.menu_employee_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_employee_add.Name = "menu_employee_add";
            this.menu_employee_add.Size = new System.Drawing.Size(234, 34);
            this.menu_employee_add.Text = "Add new employee";
            this.menu_employee_add.Click += new System.EventHandler(this.menu_employee_add_Click);
            // 
            // menu_employee_per
            // 
            this.menu_employee_per.ForeColor = System.Drawing.Color.White;
            this.menu_employee_per.Image = ((System.Drawing.Image)(resources.GetObject("menu_employee_per.Image")));
            this.menu_employee_per.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_employee_per.Name = "menu_employee_per";
            this.menu_employee_per.Size = new System.Drawing.Size(234, 34);
            this.menu_employee_per.Text = "Manage permission";
            this.menu_employee_per.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_employee_per.Click += new System.EventHandler(this.menu_employee_per_Click);
            // 
            // panel_nd
            // 
            this.panel_nd.AutoScroll = true;
            this.panel_nd.Controls.Add(this.logo);
            this.panel_nd.Controls.Add(this.label1);
            this.panel_nd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_nd.Location = new System.Drawing.Point(250, 68);
            this.panel_nd.Name = "panel_nd";
            this.panel_nd.Size = new System.Drawing.Size(834, 484);
            this.panel_nd.TabIndex = 5;
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(136, 102);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(572, 324);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 562);
            this.Controls.Add(this.panel_nd);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu_chu);
            this.MainMenuStrip = this.menu_chu;
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.menu_chu.ResumeLayout(false);
            this.menu_chu.PerformLayout();
            this.panel_left.ResumeLayout(false);
            this.menu_invoice_con.ResumeLayout(false);
            this.menu_invoice_con.PerformLayout();
            this.menu_statistics_con.ResumeLayout(false);
            this.menu_statistics_con.PerformLayout();
            this.menu_customer_con.ResumeLayout(false);
            this.menu_customer_con.PerformLayout();
            this.menu_products_con.ResumeLayout(false);
            this.menu_products_con.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.panel_exit.ResumeLayout(false);
            this.panel_exit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_exit)).EndInit();
            this.menu_home_con.ResumeLayout(false);
            this.menu_home_con.PerformLayout();
            this.menu_employee_con.ResumeLayout(false);
            this.menu_employee_con.PerformLayout();
            this.panel_nd.ResumeLayout(false);
            this.panel_nd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menu_chu;
        private System.Windows.Forms.ToolStripMenuItem menu_home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem menu_employee;
        private System.Windows.Forms.ToolStripMenuItem menu_products;
        private System.Windows.Forms.ToolStripMenuItem menu_customer;
        private System.Windows.Forms.ToolStripMenuItem menu_statistics;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_nd;
        private System.Windows.Forms.MenuStrip menu_home_con;
        private System.Windows.Forms.ToolStripMenuItem myInfomation;
        private System.Windows.Forms.ToolStripMenuItem changePassword;
        private System.Windows.Forms.Label label_thoat;
        private System.Windows.Forms.PictureBox buttom_exit;
        private System.Windows.Forms.Label label_userlogin;
        private System.Windows.Forms.Panel panel_exit;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ToolStripMenuItem accessPermission;
        private System.Windows.Forms.MenuStrip menu_employee_con;
        private System.Windows.Forms.ToolStripMenuItem menu_employee_view;
        private System.Windows.Forms.ToolStripMenuItem menu_employee_add;
        private System.Windows.Forms.MenuStrip menu_products_con;
        private System.Windows.Forms.ToolStripMenuItem menu_products_view;
        private System.Windows.Forms.ToolStripMenuItem menu_products_add;
        private System.Windows.Forms.MenuStrip menu_customer_con;
        private System.Windows.Forms.ToolStripMenuItem menu_customer_view;
        private System.Windows.Forms.ToolStripMenuItem menu_customer_add;
        private System.Windows.Forms.ToolStripMenuItem menu_factory_view;
        private System.Windows.Forms.ToolStripMenuItem menu_factory_add;
        private System.Windows.Forms.MenuStrip menu_statistics_con;
        private System.Windows.Forms.ToolStripMenuItem menu_statistics_grow;
        private System.Windows.Forms.ToolStripMenuItem menu_statistics_math;
        private System.Windows.Forms.ToolStripMenuItem menu_invoice;
        private System.Windows.Forms.MenuStrip menu_invoice_con;
        private System.Windows.Forms.ToolStripMenuItem Invoicebuy_view;
        private System.Windows.Forms.ToolStripMenuItem Invoicebuy_add;
        private System.Windows.Forms.ToolStripMenuItem InvoiceSale_view;
        private System.Windows.Forms.ToolStripMenuItem InvoiceSale_add;
        private System.Windows.Forms.ToolStripMenuItem menu_customer_feed;
        private System.Windows.Forms.ToolStripMenuItem menu_employee_per;
    }
}