using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports;

namespace BaoCaoThongKe.Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonX1_Click(object sender, EventArgs e)
        {
            XtraReport2 report = new XtraReport2();
            report.BackColor = Color.AliceBlue;
            report.BorderColor = Color.LightYellow;
            report.BorderWidth = 23;
            report.ForeColor = Color.Aquamarine;
            //report.PrintDialog();
            report.ShowPreview();
            report.CreateDocument();

            //
            // Bind the report to data.
            //report.DataAdapter = this.oleDbDataAdapter1;
            //report.DataSource = this.dsOrders1;
            //report.DataMember = "Orders";

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            XtraReport2 report = new XtraReport2();

            report.ShowDesigner();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            //XtraReport3 report = new XtraReport3();
            //report.ShowPreview();
        }
        public void CreateMyOleDbCommand()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Categories ORDER BY CategoryID";
            command.CommandTimeout = 20;
        }

        /*
     *  public DataSet GetDataSetFromAdapter(
        DataSet dataSet, string connectionString, string queryString)
        {
        using (OleDbConnection connection =
                   new OleDbConnection(connectionString))
        {
            OleDbDataAdapter adapter =
                new OleDbDataAdapter(queryString, connection);

            // Set the parameters.
            adapter.SelectCommand.Parameters.Add(
                "@CategoryName", OleDbType.VarChar, 80).Value = "toasters";
            adapter.SelectCommand.Parameters.Add(
                "@SerialNum", OleDbType.Integer).Value = 239;

            // Open the connection and fill the DataSet.
            try
            {
                connection.Open();
                adapter.Fill(dataSet);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // The connection is automatically closed when the
            // code exits the using block.
        }
        return dataSet;
        }


        C#  Copy Code 
        using System;
        using System.Data;
        using System.Data.OleDb;

        class Class1
        {
        static void Main()
        {
            //        string x = "Provider=SQLOLEDB;Data Source=(local);Integrated Security=SSPI;Initial Catalog=Northwind";
        }

        public DataSet GetDataSetFromAdapter(
            DataSet dataSet, string connectionString, string queryString)
        {
            using (OleDbConnection connection =
                       new OleDbConnection(connectionString))
            {
                OleDbDataAdapter adapter =
                    new OleDbDataAdapter(queryString, connection);

                // Set the parameters.
                adapter.SelectCommand.Parameters.Add(
                    "@CategoryName", OleDbType.VarChar, 80).Value = "toasters";
                adapter.SelectCommand.Parameters.Add(
                    "@SerialNum", OleDbType.Integer).Value = 239;

                // Open the connection and fill the DataSet.
                try
                {
                    connection.Open();
                    adapter.Fill(dataSet);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // The connection is automatically closed when the
                // code exits the using block.
            }
            return dataSet;
        }

 
    
         */
    }

        /*
         *  using System;
            using System.Data;
            using System.Data.OleDb;
            using System.Windows.Forms;
            using DevExpress.XtraPivotGrid;
            using DevExpress.XtraReports.UI;
            using DevExpress.XtraReports.UI.PivotGrid;
            // ...

            private void button1_Click(object sender, EventArgs e) {
                // Create a cross-tab report.
                XtraReport report = CreateReport();

                // Show its Print Preview.
                report.ShowPreview();
            }

            private XtraReport CreateReport() {
                // Create a blank report.
                XtraReport rep = new XtraReport();

                // Create a detail band and add it to the report.
                DetailBand detail = new DetailBand();
                rep.Bands.Add(detail);

                // Create a pivot grid and add it to the Detail band.
                XRPivotGrid pivotGrid = new XRPivotGrid();
                detail.Controls.Add(pivotGrid);

                // Create a data connection.
                OleDbConnection connection = new
                    OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\nwind.mdb");

                // Create a data adapter.
                OleDbDataAdapter adapter = new
                    OleDbDataAdapter("SELECT CategoryName, ProductName, Country, [Sales Person], 
                    Quantity, [Extended Price] FROM SalesPerson", connection);

                // Creata a dataset and fill it.
                DataSet dataSet1 = new DataSet();
                adapter.Fill(dataSet1, "SalesPerson");


                // Bind the pivot grid to data.
                pivotGrid.DataSource = dataSet1;
                pivotGrid.DataMember = "SalesPerson";

                // Generate pivot grid's fields.
                XRPivotGridField fieldCategoryName = new XRPivotGridField("CategoryName", PivotArea.RowArea);
                XRPivotGridField fieldProductName = new XRPivotGridField("ProductName", PivotArea.RowArea);
                XRPivotGridField fieldCountry = new XRPivotGridField("Country", PivotArea.ColumnArea);
                XRPivotGridField fieldSalesPerson = new XRPivotGridField("Sales Person", PivotArea.ColumnArea);
                XRPivotGridField fieldQuantity = new XRPivotGridField("Quantity", PivotArea.DataArea);
                XRPivotGridField fieldExtendedPrice = new XRPivotGridField("Extended Price", PivotArea.DataArea);

                // Add these fields to the pivot grid.
                pivotGrid.Fields.AddRange(new PivotGridField[] {fieldCategoryName, fieldProductName, fieldCountry,
                    fieldSalesPerson, fieldQuantity, fieldExtendedPrice});

                return rep;
            }


         */
}
