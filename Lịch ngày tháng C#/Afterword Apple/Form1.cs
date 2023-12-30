//mangciphu zola
//mangciphuz@gmail.com
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label lblDayz;
        Int32   y = 0;
        Int32 x ;
        Int32 ndayz;
        string Dayofweek,CurrentCulture;
        int  CheckDay()
        {
            DateTime time = Convert.ToDateTime(comboBoxMonth.Text +  "/01/" + textBoxYear .Text );
          //get the start day of the week for the entered date and month
            Dayofweek = Application.CurrentCulture.Calendar.GetDayOfWeek(time).ToString();
            if (Dayofweek == "Sunday")
            {
                x = 0;
            }
            else if (Dayofweek == "Monday")
            {
                x = 0+42;
                ndayz = 1;
            }
            else if (Dayofweek == "Tuesday")
            {
                x = 0 + 84;
                ndayz = 2;
            }
            else if (Dayofweek == "Wednesday")
            {
                x = 0 + 84 + 42;
                ndayz = 3;
            }
            else if (Dayofweek == "Thursday")
            {
                x = 0 + 84 + 84;
                ndayz = 4;
            }
            else if (Dayofweek == "Friday")
            {
                x = 0 + 84 + 84 + 42;
                ndayz = 5;
            }
            else if (Dayofweek == "Saturday")
            {
                x = 0 + 84 + 84 + 84;
                ndayz = 6;
            }
            return x;
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentCulture =Application .CurrentCulture .Name ;
            //display the current month
            comboBoxMonth.Text = DateTime.Now.Month.ToString();
            //display the full name of the current month
            labelMonth.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(Convert .ToInt32 ( comboBoxMonth.Text)); 
           //change culture to avoid incorrect date
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-za");
            //get the number of days in the selected month and year
            Int32 Dayz = DateTime.DaysInMonth(DateTime.Now .Year  , DateTime .Now .Month  );
            //display the current year in the textbox
            textBoxYear.Text = DateTime.Now.Year.ToString();
            //call the checkday function
            CheckDay();
            for (Int32 i = 1; i < Dayz + 1; i++)
            {
                ndayz += 1;
                lblDayz = new Label();
                lblDayz.Name = "B" + i;
                lblDayz.Text = i.ToString();
                lblDayz.BorderStyle = BorderStyle.Fixed3D;
                if (i == DateTime.Now.Day)
                {
                    lblDayz.BackColor = Color.Green;
                }
                else if (ndayz == 01)
                {
                    lblDayz.BackColor = Color.Red;
                }
                else
                {
                    lblDayz.BackColor = Color.Aquamarine;
                }
               lblDayz.Font = label31.Font;
                lblDayz.SetBounds(x, y, 37, 27);
                 x += 42;
                if (ndayz == 7)
                {
                    x = 0;
                    ndayz = 0;
                    y += 29;
                }
                panel1.Controls.Add(lblDayz);
            }
            //return all values to default
            x = 0;
            ndayz = 0;
            y = 0;
           }
             
       private void buttonGo_Click_1(object sender, EventArgs e)
        {
            if ((comboBoxMonth.Text == null) || (textBoxYear.Text == null))
            {
                MessageBox.Show("Either year or month is incorrect");
            }
            else
            {
                try
                {
                    Int32 t = Convert.ToInt32(textBoxYear.Text);
                    if ((textBoxYear.Text != "0") || (t < 1))
                    {
                        //remove all the controls in the panel
                        panel1.Controls.Clear();
                        Thread.CurrentThread.CurrentCulture = new CultureInfo(CurrentCulture);
                        //display the selected month's fullname
                        labelMonth.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(comboBoxMonth.Text));
                         Thread.CurrentThread.CurrentCulture = new CultureInfo("en-za");
                        Int32 Dayz = DateTime.DaysInMonth(Convert.ToInt32(textBoxYear.Text), Convert.ToInt32(comboBoxMonth.Text));
                        CheckDay();
                        for (Int32 i = 1; i < Dayz + 1; i++)
                        {
                            ndayz += 1;
                            lblDayz = new Label();
                            lblDayz.Text = i.ToString();
                            lblDayz.BorderStyle = BorderStyle.Fixed3D;
                            Int32 mon = Convert.ToInt32(comboBoxMonth.Text);
                            Int32 year = Convert.ToInt32(textBoxYear.Text);
                            if ((i == DateTime.Now.Day) && (mon == DateTime.Now.Month) && (year == DateTime.Now.Year))
                            {
                                //the current day must be highlighted differently
                                lblDayz.BackColor = Color.Green;
                            }
                            else if (ndayz == 01)
                            {
                                lblDayz.BackColor = Color.Red;
                            }
                            else
                            {
                                //set this color for other days in the selected month
                                lblDayz.BackColor = Color.Aquamarine;
                            }
                            lblDayz.Font = label31.Font;
                            lblDayz.SetBounds(x, y, 37, 27);

                            x += 42;
                            if (ndayz == 7)
                            {
                                x = 0;
                                ndayz = 0;
                                y += 29;
                            }
                            panel1.Controls.Add(lblDayz);
                        }
                        x = 0;
                        ndayz = 0;
                        y = 0;
                    }
                    else
                    {
                        MessageBox.Show("must be between 0 and 9999");
                        textBoxYear.Focus();
                    }
                }
                catch (FormatException )
                {
                    MessageBox.Show("Year must be between 0 and 9999");
                    textBoxYear.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 currentmonth, currentyear;
                currentyear = Convert.ToInt32(textBoxYear.Text);
                currentmonth = Convert.ToInt32(comboBoxMonth.Text);
                if (currentmonth == 12)
                {
                    currentyear += 1;
                    currentmonth = 1;
                    textBoxYear.Text = currentyear.ToString();
                    comboBoxMonth.Text = currentmonth.ToString();
                }
                else
                {
                    currentmonth += 1;
                    comboBoxMonth.Text = currentmonth.ToString();
                }

                //remove all the controls in the panel
                panel1.Controls.Clear();
                Thread.CurrentThread.CurrentCulture = new CultureInfo(CurrentCulture );
                //display the selected month's fullname
                labelMonth.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(currentmonth);
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-za");
                Int32 Dayz = DateTime.DaysInMonth(Convert.ToInt32(textBoxYear.Text), Convert.ToInt32(comboBoxMonth.Text));
                CheckDay();
                for (Int32 i = 1; i < Dayz + 1; i++)
                {
                    ndayz += 1;

                    lblDayz = new Label();
                    lblDayz.Text = i.ToString();
                    lblDayz.BorderStyle = BorderStyle.Fixed3D;
                    Int32 mon = Convert.ToInt32(comboBoxMonth.Text);
                    Int32 year=Convert .ToInt32 ( textBoxYear .Text) ;
                    if ((i == DateTime.Now.Day) && (mon == DateTime.Now.Month) && (year ==DateTime.Now .Year )  )
                    {
                        //the current day must be highlighted differently
                        lblDayz.BackColor = Color.Green;

                    }
                    else if (ndayz == 01)
                    {
                        lblDayz.BackColor = Color.Red;
                    }
                    else
                    {
                        //set this color for other days in the selected month
                        lblDayz.BackColor = Color.Aquamarine;
                    }
                    lblDayz.Font = label31.Font;
                    lblDayz.SetBounds(x, y, 37, 27);

                    x += 42;
                    if (ndayz == 7)
                    {
                        x = 0;
                        ndayz = 0;
                        y += 29;
                    }
                    panel1.Controls.Add(lblDayz);
                }
                x = 0;
                ndayz = 0;
                y = 0;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid date has been entered");
                textBoxYear.Focus();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Invalid date has been entered");
                textBoxYear.Focus();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 currentmonth, currentyear;
                currentyear = Convert.ToInt32(textBoxYear.Text);
                currentmonth = Convert.ToInt32(comboBoxMonth.Text);
                if (currentmonth == 1)
                {
                    currentyear -= 1;
                    currentmonth = 12;
                    textBoxYear.Text = currentyear.ToString();
                    comboBoxMonth.Text = currentmonth.ToString();
                }
                else
                {
                    currentmonth -= 1;
                    comboBoxMonth.Text = currentmonth.ToString();
                }

                //remove all the controls in the panel
                panel1.Controls.Clear();
                Thread.CurrentThread.CurrentCulture = new CultureInfo(CurrentCulture );
                //display the selected month's fullname
                labelMonth.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(currentmonth);
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-za");
                Int32 Dayz = DateTime.DaysInMonth(Convert.ToInt32(textBoxYear.Text), Convert.ToInt32(comboBoxMonth.Text));
                CheckDay();
                for (Int32 i = 1; i < Dayz + 1; i++)
                {
                    ndayz += 1;

                    lblDayz = new Label();
                    lblDayz.Text = i.ToString();
                    lblDayz.BorderStyle = BorderStyle.Fixed3D;
                    Int32 mon = Convert.ToInt32(comboBoxMonth.Text);
                    Int32 year = Convert.ToInt32(textBoxYear.Text);
                    if ((i == DateTime.Now.Day) && (mon == DateTime.Now.Month) && (year == DateTime.Now.Year))
                    {
                        //the current day must be highlighted differently
                        lblDayz.BackColor = Color.Green;
                    }
                    else if (ndayz == 01)
                    {
                        lblDayz.BackColor = Color.Red;
                    }
                    else
                    {
                        //set this color for other days in the selected month
                        lblDayz.BackColor = Color.Aquamarine;
                    }
                    lblDayz.Font = label31.Font;
                    lblDayz.SetBounds(x, y, 37, 27);

                    x += 42;
                    if (ndayz == 7)
                    {
                        x = 0;
                        ndayz = 0;
                        y += 29;
                    }
                    panel1.Controls.Add(lblDayz);
                }
                x = 0;
                ndayz = 0;
                y = 0;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid date has been entered");
                textBoxYear.Focus();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Invalid date has been entered");
                textBoxYear.Focus();
            }
        }
            }
            
        }

    

