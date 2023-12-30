using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

/* ======================== ĐỔI TỪ DEC SANG BIN =================================== */

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string a = textBox1.Text;
                string[] b = a.Split('.'); //cat chuoi

           /* ############## Doi phan nguyen ############*/

                Int32 n = Convert.ToInt32(b[0]);
                Int32 i = 0;
                double d, s1 = 0;
                while (n > 0)
                {
                    d = n % 2;
                    n = n / 2;
                    s1 = s1 + d * Math.Pow(10, i);//lay gia tri bin
                    i++;
                };

          /* ############## Doi phan le ############*/

                string f = "0." + b[1];
                string s2 = "";
                double g = Convert.ToDouble(f);
                Int32 w;
                while (g != 0)
                {
                    g = g * 2;
                    w = Convert.ToInt32(g);//phan nguyen co lam tron
                    if (w <= g)//lam tron < g
                    {
                        s2 = s2 + Convert.ToString(w);
                        g = g - w;
                    }
                    else //lam tron > g
                    {
                        s2 = s2 + Convert.ToString(w - 1);//lam tron tang len 1 nen khi in phan nguyen phai tru 1
                        g = g + 1 - w;//g phai tang len 1 roi moi tru cho phan nguyen
                    }

                };
                textBox2.Text = Convert.ToString(s1) + "." + s2;
            }

            catch
            {
                Int32 n = Int32.Parse(textBox1.Text);//chuyen chuoi trong textBox1 thanh kieu so nguyen
                double s = 0, i = 0, k;// s phai la kieu double vi chua ham mu
                while (n > 0)
                {
                    k = n % 2;
                    n = n / 2;
                    s = s + k * Math.Pow(10, i);// dao nguoc so k vua tinh thanh bin can tim
                    i++;
                };
                string b = Convert.ToString(s);//chuyen s ve kieu string
                textBox2.Text = b;
            }
        }

/* ================================ ĐỔI TỪ  DEC SANG OCT ==================================== */

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string a = textBox1.Text;
                string[] P = a.Split('.'); //cat chuoi
                Int32 n = Convert.ToInt32(P[0]);

                /* ############## Doi phan nguyen ############ */

                Int32 i = 0;
                double d, s1 = 0;
                while (n > 0)
                {
                    d = n % 8;
                    n = n / 8;
                    s1 = s1 + d * Math.Pow(10, i);//lay gia tri bin
                    i++;
                };

                /* ########## Doi phan le ########### */

                string f = "0." + P[1];
                string s2 = "";
                double g = Convert.ToDouble(f);
             
                Int32 w;
                while (g != 0)//vong lap ket thuc khi phan le =0
                {
                    g = g * 8;
                    w = Convert.ToInt32(g);//phan nguyen co lam tron
                    if (w <= g)//lam tron < g
                    {
                        s2 = s2 + Convert.ToString(w);
                        g = g - w;
                    }
                    else //lam tron > g
                    {
                        s2 = s2 + Convert.ToString(w - 1);//lam tron tang len 1 nen khi in phan nguyen phai tru 1
                        g = g + 1 - w;//g phai tang len 1 roi moi tru cho phan nguyen
                    }

                };
                textBox2.Text = Convert.ToString(s1) + "." + s2;

            }
            catch
            {
                Int32 n = Int32.Parse(textBox1.Text);//chuyen chuoi trong textBox1 thanh kieu so nguyen
                double s = 0, i = 0, k;// s phai la kieu double vi chua ham mu
                while (n > 0)
                {
                    k = n % 8;
                    n = n / 8;
                    s = s + k * Math.Pow(10, i);// dao nguoc so k vua tinh thanh oct can tim
                    i++;
                };
                string b = Convert.ToString(s);//chuyen s ve kieu string
                textBox2.Text = b;
            }

           
        }

/* ==================================== ĐỔI TỪ DEC SANG HEX ====================================== */

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string m = textBox1.Text;
                string[] P = m.Split('.'); //cat chuoi

                /* ########### Doi phan nguyen ########### */

                Int32 n1 = Convert.ToInt32(P[0]);
                string[] A;  // vi he thap luc phan la chuoi
                A = new string[100];
                string s1 = "";

                Int32 i = 0;
                while (n1 > 0)
                {

                    A[i] = Convert.ToString(n1 % 16);  // vi a[i] thuoc kieu string
                    n1 = n1 / 16;
                    i++;
                };

                //in ra he thap luc phan
                for (Int32 j = i - 1; j >= 0; j--)// lay j giam de dc he thap luc phan can tim
                {
                    if (A[j] == "10") A[j] = "A";//a[j] la kieu chuoi
                    if (A[j] == "11") A[j] = "B";
                    if (A[j] == "12") A[j] = "C";
                    if (A[j] == "13") A[j] = "D";
                    if (A[j] == "14") A[j] = "E";
                    if (A[j] == "15") A[j] = "F";

                    s1 = s1 + A[j];
                }

                textBox2.Text = s1;

                /* ########### Doi phan le ########### */

                string f = "0." + P[1];
                string s2 = "";
                double g = Convert.ToDouble(f);
                
                Int64 w;
                
                while (g != 0)//vong lap ket thuc khi phan le =0
                {
                    g = g * 16;
                    w = Convert.ToInt64(g);//phan nguyen co lam tron
                    if (w <= g)//lam tron < g
                    {

                        if (w == 10) s2 = s2 + "A";
                        else if (w == 11) s2 = s2 + "B";
                        else if (w == 12) s2 = s2 + "C";
                        else if (w == 13) s2 = s2 + "D";
                        else if (w == 14) s2 = s2 + "E";
                        else if (w == 15) s2 = s2 + "F";
                        else s2 = s2 + Convert.ToString(w);
                            g = g - w;
                        
                    }
                    else //lam tron > g
                    {
                        if (w-1 == 10) s2 = s2 + "A";
                        else if (w-1 == 11) s2 = s2 + "B";
                        else if (w-1 == 12) s2 = s2 + "C";
                        else if (w-1 == 13) s2 = s2 + "D";
                        else if (w-1 == 14) s2 = s2 + "E";
                        else if (w - 1 == 15) s2 = s2 + "F";
                        else s2 = s2 + Convert.ToString(w - 1);//lam tron tang len 1 nen khi in phan nguyen phai tru 1
                            g = g + 1 - w;//g phai tang len 1 roi moi tru cho phan nguyen
                        
                    }
                    textBox2.Text = Convert.ToString(s1) + "." + s2;
                };
                
            }

            catch
            
            {
                string[] a;  // vi he thap luc phan la chuoi
                a = new string[50];
                string b = "";

                Int32 n = Int32.Parse(textBox1.Text);
                Int32 i = 0;
                while (n > 0)
                {

                    a[i] = Convert.ToString(n % 16);  // vi a[i] thuoc kieu string
                    n = n / 16;
                    i++;
                };

                //in ra he thap luc phan
                for (Int32 j = i - 1; j >= 0; j--)// lay j giam de dc he thap luc phan can tim
                {
                    if (a[j] == "10") a[j] = "A";//a[j] la kieu chuoi
                    if (a[j] == "11") a[j] = "B";
                    if (a[j] == "12") a[j] = "C";
                    if (a[j] == "13") a[j] = "D";
                    if (a[j] == "14") a[j] = "E";
                    if (a[j] == "15") a[j] = "F";

                    b = b + a[j];
                }

                textBox2.Text = b;
            }

        }

/* ================================= ĐỔI TỪ BIN SANG DEC ========================================= */

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string a = textBox1.Text;
                string[] P = a.Split('.');

                /* ############# doi phan nguyen ############### */

                Int32 n1 = Convert.ToInt32(P[0]);
                double s1 = 0, i = 0, k = 0;
                while (n1 > 0)
                {
                    k = n1 % 10; // lay ra phan tu cuoi cung cua bin
                    n1 = n1 / 10;
                    s1 = s1 + k * Math.Pow(2, i);
                    i++;
                };


                /* ############## Doi phan le ############## */

                string n2 = P[1];//phan sau dau cham
                Int32 j = n2.Length;//dem chieu dai chuoi

                Int32 m = Convert.ToInt32(n2);//chuyen kieu chuoi sang kieu int
                double s2 = 0;
                Int32 t = 0;
                while (j > 0)
                {
                    t = m % 10;
                    m = m / 10;
                    s2 = s2 + t * Math.Pow(2, (-1) * j);
                    j--;

                }
                double z = s1 + s2;
                textBox2.Text = Convert.ToString(z);
            }

            catch 
            {
                Int32 n = Int32.Parse(textBox1.Text);
                double s = 0, i = 0, k = 0;
                while (n > 0)
                {
                    k = n % 10; // lay ra phan tu cuoi cung cua bin
                    n = n / 10;
                    s = s + k * Math.Pow(2, i);
                    i++;
                };
                string b = Convert.ToString(s);
                textBox2.Text = b;
            }

        }

/* ==================================== ĐỔI TỪ BIN SANG OCT ======================================= */

        private void button5_Click(object sender, EventArgs e)
        {
          try
          {
            string a = textBox1.Text;
            string[] P = a.Split('.');

            /* ############ doi phan nguyen ############ */
            
              // DOI TU BIN SANG DEC

            Int32 n1 = Convert.ToInt32(P[0]);
            double s1 = 0, i = 0, k = 0;
            while (n1 > 0)
            {
                k = n1 % 10; // lay ra phan tu cuoi cung cua bin
                n1 = n1 / 10;
                s1 = s1 + k * Math.Pow(2, i);
                i++;
            };

            //DOI TU DEC SANG OCT

            Int32 n = Convert.ToInt32(s1);
            double s2 = 0,l=0;// s phai la kieu double vi chua ham mu
            while (n > 0)
            {
                k = n % 8;
                n = n / 8;
                s2 = s2 + k * Math.Pow(10, l);// dao nguoc so k vua tinh thanh oct can tim
                l++;
            };

          /* ############ doi phan le ############ */

            // DOI TU BIN SANG DEC
 
            string n2 = P[1];//phan sau dau cham
            Int32 j = n2.Length;//dem chieu dai chuoi

            Int32 m = Convert.ToInt32(n2);//chuyen kieu chuoi sang kieu int
            double s3 = 0;
            Int32 t = 0;
            while (j > 0)
            {
                t = m % 10;
                m = m / 10;
                s3 = s3 + t * Math.Pow(2, (-1) * j);
                j--;

            }
            //DOI TU DEC SANG OCT
            
            string s4 = "";
            double g = s3;
            Int32 w;
            while (g != 0)//vong lap ket thuc khi phan le =0
            {
                g = g * 8;
                w = Convert.ToInt32(g);//phan nguyen co lam tron
                if (w <= g)//lam tron < g
                {
                    s4 = s4 + Convert.ToString(w);
                    g = g - w;
                }
                else //lam tron > g
                {
                    s4 = s4 + Convert.ToString(w - 1);//lam tron tang len 1 nen khi in phan nguyen phai tru 1
                    g = g + 1 - w;//g phai tang len 1 roi moi tru cho phan nguyen
                }
            };
            textBox2.Text = Convert.ToString(s2)+ '.'+s4;
          }
      catch
            {
                //DOI TU BIN SANG DEC
                string a = textBox1.Text;
                Int32 n1 = Convert.ToInt32(a);
                double s1 = 0, i = 0, k = 0;
                while (n1 > 0)
                {
                    k = n1 % 10; // lay ra phan tu cuoi cung cua bin
                    n1 = n1 / 10;
                    s1 = s1 + k * Math.Pow(2, i);
                    i++;
                };

                //DOI TU DEC SANG OCT 

                Int32 n = Convert.ToInt32(s1);
                double s2 = 0, l = 0;// s phai la kieu double vi chua ham mu
                while (n > 0)
                {
                    k = n % 8;
                    n = n / 8;
                    s2 = s2 + k * Math.Pow(10, l);// dao nguoc so k vua tinh thanh oct can tim
                    l++;
                };
                textBox2.Text = Convert.ToString(s2);
            }
        }

/* ================================== ĐỔI TỪ BIN SANG HEX ========================================== */

        private void button6_Click(object sender, EventArgs e)
        {
            try
          {
            string c = textBox1.Text;
            string[] P = c.Split('.');

          /* ############## doi phan nguyen ############# */

            // DOI TU BIN SANG DEC  

            Int32 n = Convert.ToInt32(P[0]);
            double s1 = 0, i = 0, k = 0;
            while (n > 0)
            {
                k = n % 10; //lay ra phan tu cuoi cung cua bin
                n = n / 10;
                s1 = s1 + k * Math.Pow(2,i);
                i++;
            };

            // DOI TU DEC SANG HEX

            string[] a;
            a = new string[50];
            string s2 = "";

            /*   lay so thap phan s vua tim doi thanh kieu so nguyen
                  roi chuyen thanh he thap luc phan    */
            
            Int32 m = Convert.ToInt32(s1);
            int q= 0;
            while (m > 0)
            {

                a[q] = Convert.ToString(m % 16);  // vi a[q] thuoc kieu string
                m = m / 16;
                q++;
            };
            //in ra he thap luc phan
            for (Int32 j = q - 1; j >= 0; j--)
            {
                if (a[j] == "10") a[j] = "A";//a[j] la kieu chuoi
                if (a[j] == "11") a[j] = "B";
                if (a[j] == "12") a[j] = "C";
                if (a[j] == "13") a[j] = "D";
                if (a[j] == "14") a[j] = "E";
                if (a[j] == "15") a[j] = "F";

                s2 = s2+ a[j];
            }
         /* ################### doi phan le ################ */

            // DOI TU BIN SANG DEC 
 
                 string n2 = P[1];//phan sau dau cham
                Int32 l = n2.Length;//dem chieu dai chuoi

                Int32 h = Convert.ToInt32(n2);//chuyen kieu chuoi sang kieu int
                double s3 = 0;
                Int32 t = 0;
                while (l > 0)
                {
                    t = h % 10;
                    h = h / 10;
                    s3 = s3 + t * Math.Pow(2, (-1) * l);
                    l--;

                }
                // DOI TU DEC SANG HEX
                
                string s4 = "";
                double g = s3;
                
                Int64 w;
                
                while (g != 0)//vong lap ket thuc khi phan le =0
                {
                    g = g * 16;
                    w = Convert.ToInt64(g);//phan nguyen co lam tron
                    if (w <= g)//lam tron < g
                    {

                        if (w == 10) s4 = s4 + "A";
                        else if (w == 11) s4 = s4 + "B";
                        else if (w == 12) s4 = s4 + "C";
                        else if (w == 13) s4 = s4 + "D";
                        else if (w == 14) s4 = s4 + "E";
                        else if (w == 15) s4 = s4 + "F";
                        else s4 = s4 + Convert.ToString(w);
                            g = g - w;
                        
                    }
                    else //lam tron > g
                    {
                        if (w-1 == 10) s4 = s4 + "A";
                        else if (w-1 == 11) s4 = s4 + "B";
                        else if (w-1 == 12) s4 = s4 + "C";
                        else if (w-1 == 13) s4 = s4 + "D";
                        else if (w-1 == 14) s4 = s4 + "E";
                        else if (w - 1 == 15) s4 = s4 + "F";
                        else s4= s4 + Convert.ToString(w - 1);//lam tron tang len 1 nen khi in phan nguyen phai tru 1
                            g = g + 1 - w;//g phai tang len 1 roi moi tru cho phan nguyen
                    }
                }
                    textBox2.Text = Convert.ToString(s2) + "." + s4;
               
            }
    catch
         {
             // DOI TU BIN SANG DEC  

            Int32 n = Int32.Parse(textBox1.Text);
            double s = 0, i = 0, k = 0;
            while (n > 0)
            {
                k = n % 10; //lay ra phan tu cuoi cung cua bin
                n = n / 10;
                s = s + k * Math.Pow(2,i);
                i++;
            };

            // DOI TU DEC SANG HEX

            string[] a;
            a = new string[50];
            string b = "";

            /*   lay so thap phan s vua tim doi thanh kieu so nguyen
                  roi chuyen thanh he thap luc phan    */
            
            Int32 m = Convert.ToInt32(s);
            int q= 0;
            while (m > 0)
            {

                a[q] = Convert.ToString(m % 16);  // vi a[q] thuoc kieu string
                m = m / 16;
                q++;
            };
            //in ra he thap luc phan
            for (Int32 j = q - 1; j >= 0; j--)
            {
                if (a[j] == "10") a[j] = "A";//a[j] la kieu chuoi
                if (a[j] == "11") a[j] = "B";
                if (a[j] == "12") a[j] = "C";
                if (a[j] == "13") a[j] = "D";
                if (a[j] == "14") a[j] = "E";
                if (a[j] == "15") a[j] = "F";

                b = b + a[j];
            }

            textBox2.Text = b;
         }
        }
  
/* ========================================= ĐỔI TỪ OCT SANG DEC ============================================= */

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {

                string a = textBox1.Text;
                string[] P = a.Split('.');

                /* ############## doi phan nguyen ############ */

                Int32 n1 = Convert.ToInt32(P[0]);
                double s1 = 0, i = 0, k = 0;
                while (n1 > 0)
                {
                    k = n1 % 10; // lay ra phan tu cuoi cung cua bin
                    n1 = n1 / 10;
                    s1 = s1 + k * Math.Pow(8, i);
                    i++;
                };


                /* ############ Doi phan le ##################*/

                string n2 = P[1];//phan sau dau cham
                Int32 j = n2.Length;//dem chieu dai chuoi

                Int32 m = Convert.ToInt32(n2);//chuyen kieu chuoi sang kieu int
                double s2 = 0;
                Int32 t = 0;
                while (j > 0)
                {
                    t = m % 10;
                    m = m / 10;
                    s2 = s2 + t * Math.Pow(8, (-1) * j);
                    j--;

                }
                double z = s1 + s2;
                textBox2.Text = Convert.ToString(z);
            }

            catch
            {



                Int32 n = Int32.Parse(textBox1.Text);
                double s = 0, i = 0, k = 0;
                while (n > 0)
                {
                    k = n % 10;// lay ra phan tu cuoi cung cua oct
                    n = n / 10;
                    s = s + k * Math.Pow(8, i);
                    i++;
                };
                string b = Convert.ToString(s);
                textBox2.Text = b;
            }
        }


/* =================================== ĐỔI TỪ OCT SANG BIN ========================================*/

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string a = textBox1.Text;
                string[] P = a.Split('.');

                /* ############## doi phan nguyen ###########*/

                //DOI TU OCT SANG DEC

                Int32 n = Convert.ToInt32(P[0]);
                double s1 = 0, i = 0, k = 0, s2 = 0;
                while (n > 0)
                {
                    k = n % 10; // lay ra phan tu cuoi cung cua oct
                    n = n / 10;
                    s1 = s1 + k * Math.Pow(8, i);
                    i++;
                };

                //DOI TU DEC SANG BIN

                Int32 q = Convert.ToInt32(s1);
                i = 0;
                while (q > 0)
                {
                    k = q % 2;
                    q = q / 2;
                    s2 = s2 + k * Math.Pow(10, i); //doi bin k vua tinh ra nguoc lai de duoc bin can tim
                    i++;
                };

                /* ############## doi phan le ###########*/

                //DOI TU OCT SANG DEC 

                string n2 = P[1];//phan sau dau cham
                Int32 j = n2.Length;//dem chieu dai chuoi

                Int32 m = Convert.ToInt32(n2);//chuyen kieu chuoi sang kieu int
                double s3 = 0;
                Int32 t = 0;
                while (j > 0)
                {
                    t = m % 10;
                    m = m / 10;
                    s3 = s3 + t * Math.Pow(8, (-1) * j);
                    j--;

                }

                //DOI TU DEC SANG BIN

                string s4 = "";
                double g = s3;
                Int32 w;
                while (g != 0)
                {
                    g = g * 2;
                    w = Convert.ToInt32(g);//phan nguyen co lam tron
                    if (w <= g)//lam tron < g
                    {
                        s4 = s4 + Convert.ToString(w);
                        g = g - w;
                    }
                    else //lam tron > g
                    {
                        s4 = s4 + Convert.ToString(w - 1);//lam tron tang len 1 nen khi in phan nguyen phai tru 1
                        g = g + 1 - w;//g phai tang len 1 roi moi tru cho phan nguyen
                    }
                };
                textBox2.Text = Convert.ToString(s2) + '.' + s4;
            }
            catch
            {
                // DOI TU OCT SANG DEC

                Int32 n = Int32.Parse(textBox1.Text);
                double s1 = 0, i = 0, k = 0, s2 = 0;
                while (n > 0)
                {
                    k = n % 10; // lay ra phan tu cuoi cung cua oct
                    n = n / 10;
                    s1 = s1 + k * Math.Pow(8, i);
                    i++;
                };

                //DOI TU DEC SANG BIN

                Int32 q = Convert.ToInt32(s1);
                i = 0;
                while (q > 0)
                {
                    k = q % 2;
                    q = q / 2;
                    s2 = s2 + k * Math.Pow(10, i); //doi bin k vua tinh ra nguoc lai de duoc bin can tim
                    i++;
                };
                textBox2.Text = Convert.ToString(s2);
            }
        }

/* ===================================== ĐỔI TỪ OCT SANG HEX =============================================== */

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string b = textBox1.Text;
                string[] P = b.Split('.');

              /* ############## doi phan nguyen ############ */

                //DOI TU OCT SANG DEC

                Int32 n = Convert.ToInt32(P[0]);
                double s1 = 0, i = 0, k = 0;
                while (n > 0)
                {
                    k = n % 10;//lay ra phan tu cuoi cung cua oct
                    n = n / 10;
                    s1 = s1 + k * Math.Pow(8, i);
                    i++;
                }

                //DOI TU DEC SANG HEX

                string[] a;
                a = new string[100];
                string s2 = "";

                /*   lay so thap phan s1 vua tim doi thanh kieu so nguyen
                      roi chuyen thanh he thap luc phan    */

                Int32 m = Convert.ToInt32(s1);
                Int32 q = 0;
                while (m > 0)
                {
                    a[q] = Convert.ToString(m % 16);
                    m = m / 16;
                    q++;
                }
                //in he thap luc phan
                for (Int32 j = q - 1; j >= 0; j--)
                {
                    if (a[j] == "10") a[j] = "A";//a[j] la kieu chuoi
                    if (a[j] == "11") a[j] = "B";
                    if (a[j] == "12") a[j] = "C";
                    if (a[j] == "13") a[j] = "D";
                    if (a[j] == "14") a[j] = "E";
                    if (a[j] == "15") a[j] = "F";

                    s2 = s2 + a[j];
                }
                /* ############ Doi phan le ##################*/

                //DOI TU OCT SANG DEC

                string n2 = P[1];//phan sau dau cham
                Int32 l = n2.Length;//dem chieu dai chuoi

                Int32 m1 = Convert.ToInt32(n2);//chuyen kieu chuoi sang kieu int
                double s3 = 0;
                Int32 t = 0;
                while (l > 0)
                {
                    t = m1 % 10;
                    m1 = m1 / 10;
                    s3 = s3 + t * Math.Pow(8, (-1) * l);
                    l--;
                }
                //DOI TU DEC SANG HEC

                string s4 = "";
                double g = s3;

                Int64 w;

                while (g != 0)//vong lap ket thuc khi phan le =0
                {
                    g = g * 16;
                    w = Convert.ToInt64(g);//phan nguyen co lam tron
                    if (w <= g)//lam tron < g
                    {

                        if (w == 10) s4 = s4 + "A";
                        else if (w == 11) s4 = s4 + "B";
                        else if (w == 12) s4 = s4 + "C";
                        else if (w == 13) s4 = s4 + "D";
                        else if (w == 14) s4 = s4 + "E";
                        else if (w == 15) s4 = s4 + "F";
                        else s4 = s4 + Convert.ToString(w);
                        g = g - w;

                    }
                    else //lam tron > g
                    {
                        if (w - 1 == 10) s4 = s4 + "A";
                        else if (w - 1 == 11) s4 = s4 + "B";
                        else if (w - 1 == 12) s4 = s4 + "C";
                        else if (w - 1 == 13) s4 = s4 + "D";
                        else if (w - 1 == 14) s4 = s4 + "E";
                        else if (w - 1 == 15) s4 = s4 + "F";
                        else s4 = s4 + Convert.ToString(w - 1);//lam tron tang len 1 nen khi in phan nguyen phai tru 1
                        g = g + 1 - w;//g phai tang len 1 roi moi tru cho phan nguyen

                    }
                }
                textBox2.Text = Convert.ToString(s2) + "." + s4;
            }

            catch
            {
                //DOI TU OCT SANG DEC

                Int32 n = Int32.Parse(textBox1.Text);
                double s = 0, i = 0, k = 0;
                while (n > 0)
                {
                    k = n % 10;//lay ra phan tu cuoi cung cua oct
                    n = n / 10;
                    s = s + k * Math.Pow(8, i);
                    i++;
                }

                //DOI TU DEC SANG HEC 

                string[] a;
                a = new string[50];
                string b = "";

                /*   lay so thap phan s vua tim doi thanh kieu so nguyen
                      roi chuyen thanh he thap luc phan    */

                Int32 m = Convert.ToInt32(s);
                Int32 q = 0;
                while (m > 0)
                {
                    a[q] = Convert.ToString(m % 16);
                    m = m / 16;
                    q++;
                }
                //in he thap luc phan
                for (Int32 j = q - 1; j >= 0; j--)
                {
                    if (a[j] == "10") a[j] = "A";//a[j] la kieu chuoi
                    if (a[j] == "11") a[j] = "B";
                    if (a[j] == "12") a[j] = "C";
                    if (a[j] == "13") a[j] = "D";
                    if (a[j] == "14") a[j] = "E";
                    if (a[j] == "15") a[j] = "F";

                    b = b + a[j];
                }

                textBox2.Text = b;
            }

        }
/* ================================== ĐỔI TỪ HEX SANG DEC ========================================= */

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string c = textBox1.Text;
                string[] P = c.Split('.');

          /* ############## doi phan nguyen ############# */
                
                string n1=P[0];
                string[] a;
                string[] b;
                a = new string[100];
                b = new string[100];
                Int32 i = n1.Length - 1;// i bang chieu dai chuoi
                double s1 = 0, j = 0;
                while (i >= 0)
                {
                    a[i] = n1.Substring(i,1);// cat chuoi co do dai bang 1
                    if (a[i] == "A") b[i] = "10";
                    else if (a[i] == "B") b[i] = "11";
                    else if (a[i] == "C") b[i] = "12";
                    else if (a[i] == "D") b[i] = "13";
                    else if (a[i] == "E") b[i] = "14";
                    else if (a[i] == "F") b[i] = "15";
                    else b[i] = a[i];
                    s1 = s1 + Convert.ToDouble(b[i]) * Math.Pow(16, j);
                    i--;//chieu dai chuoi giam
                    j++;//so mu 16 tang

                }
         /* ############## doi phan le ############# */

                string n2 = P[1];
                string[] A;
                string[] B;
                A = new string[100];
                B= new string[100];
                Int32 l = n2.Length - 1;// l bang chieu dai chuoi
                double s2 = 0;
                while (l >= 0)
                {
                    A[l] = n2.Substring(l, 1);// cat chuoi co do dai bang 1
                    if      (A[l] == "A")   B[l] = "10";
                    else if (A[l] == "B") B[l] = "11";
                    else if (A[l] == "C") B[l] = "12";
                    else if (A[l] == "D") B[l] = "13";
                    else if (A[l] == "E") B[l] = "14";
                    else if (A[l] == "F") B[l] = "15";
                    else B[l] = A[l];
                    s2 = s2 + Convert.ToDouble(B[l]) * Math.Pow(16, (-1) * (l + 1));
                    l--;//chieu dai chuoi giam
                }
                double s3 = s1 + s2;
                textBox2.Text = Convert.ToString(s3);
            }

            catch
            {
                string n = textBox1.Text;
                string[] a;
                string[] b;
                a = new string[100];
                b = new string[100];
                Int32 i = n.Length - 1;// i bang chieu dai chuoi
                double s = 0, j = 0;
                while (i >= 0)
                {
                    a[i] = n.Substring(i, 1);// cat chuoi co do dai bang 1
                    if (a[i] == "A") b[i] = "10";
                    else if (a[i] == "B") b[i] = "11";
                    else if (a[i] == "C") b[i] = "12";
                    else if (a[i] == "D") b[i] = "13";
                    else if (a[i] == "E") b[i] = "14";
                    else if (a[i] == "F") b[i] = "15";
                    else b[i] = a[i];
                    s = s + Convert.ToDouble(b[i]) * Math.Pow(16, j);
                    i--;//chieu dai chuoi giam
                    j++;//so mu 16 tang

                }
                    textBox2.Text = Convert.ToString(s);
            }
        }

/* ======================================= ĐỔI TỪ HEX SANG BIN ===================================== */

        private void button11_Click(object sender, EventArgs e)
        {
            try 
            {
                string c = textBox1.Text;
                string[] P = c.Split('.');

         /* ############## doi phan nguyen ############# */

                // DOI TU HEX SANG DEC

                string n1 = P[0];
                string[] a;
                string[] b;
                a = new string[100];
                b = new string[100];
                Int32 i = n1.Length - 1;// i bang chieu dai chuoi
                double s1 = 0, j = 0;
                while (i >= 0)
                {
                    a[i] = n1.Substring(i, 1);// cat chuoi co do dai bang 1
                    if (a[i] == "A") b[i] = "10";
                    else if (a[i] == "B") b[i] = "11";
                    else if (a[i] == "C") b[i] = "12";
                    else if (a[i] == "D") b[i] = "13";
                    else if (a[i] == "E") b[i] = "14";
                    else if (a[i] == "F") b[i] = "15";
                    else b[i] = a[i];
                    s1 = s1 + Convert.ToDouble(b[i]) * Math.Pow(16, j);
                    i--;//chieu dai chuoi giam
                    j++;//so mu 16 tang

                }
                // DOI TU DEC SANG BIN

                Int32 n = Convert.ToInt32(s1);
                Int32 t = 0;
                double d, s2 = 0;
                while (n > 0)
                {
                    d = n % 2;
                    n = n / 2;
                    s2 = s2 + d * Math.Pow(10, t);//lay gia tri bin
                    t++;
                }

        /* ############## doi phan le ############# */

                // DOI TU HEX SANG DEC

                string n2 = P[1];
                string[] A;
                string[] B;
                A = new string[100];
                B = new string[100];
                Int32 l = n2.Length - 1;// i bang chieu dai chuoi
                double s3 = 0;
                while (l >= 0)
                {
                    A[l] = n2.Substring(l, 1);// cat chuoi co do dai bang 1
                    if (A[l] == "A") B[l] = "10";
                    else if (A[l] == "B") B[l] = "11";
                    else if (A[l] == "C") B[l] = "12";
                    else if (A[l] == "D") B[l] = "13";
                    else if (A[l] == "E") B[l] = "14";
                    else if (A[l] == "F") B[l] = "15";
                    else B[l] = A[l];
                    s3 = s3 + Convert.ToDouble(B[l]) * Math.Pow(16, (-1) * (l + 1));
                    l--;//chieu dai chuoi giam
                }

                // DOI TU DEC SANG BIN

                string s4 = "";
                double g = s3;
                Int32 w;
                while (g != 0)
                {
                    g = g * 2;
                    w = Convert.ToInt32(g);//phan nguyen co lam tron
                    if (w <= g)//lam tron < g
                    {
                        s4 = s4+ Convert.ToString(w);
                        g = g - w;
                    }
                    else //lam tron > g
                    {
                        s4 = s4 + Convert.ToString(w - 1);//lam tron tang len 1 nen khi in phan nguyen phai tru 1
                        g = g + 1 - w;//g phai tang len 1 roi moi tru cho phan nguyen
                    }
                }
                textBox2.Text = Convert.ToString(s2)+'.'+Convert.ToString(s4);

            }
            catch
            {
                //DOI TU HEX SANG DEC

                string n = textBox1.Text;
                string[] a;
                string[] b;
                a = new string[100];
                b = new string[100];
                Int32 i = n.Length - 1;// i bang chieu dai chuoi
                double s = 0, j = 0;
                while (i >= 0)
                {
                    a[i] = n.Substring(i, 1);//cat chuoi, co chieu dai bag 1
                    if (a[i] == "A") b[i] = "10";
                    else if (a[i] == "B") b[i] = "11";
                    else if (a[i] == "C") b[i] = "12";
                    else if (a[i] == "D") b[i] = "13";
                    else if (a[i] == "E") b[i] = "14";
                    else if (a[i] == "F") b[i] = "15";
                    else b[i] = a[i];
                    s = s + Convert.ToDouble(b[i]) * Math.Pow(16, j);
                    i--;
                    j++;

                }
                //DOI TU DEC SANG BIN

                Int32 m = Convert.ToInt32(s);
                double t = 0, l = 0, q;
                while (m > 0)
                {
                    q = m % 2;
                    m = m / 2;
                    t = t + q * Math.Pow(10, l);
                    l++;
                }
                textBox2.Text = Convert.ToString(t);
            }
        }

/* ================================= ĐỔI TỪ HEX SANG OCT ===================================== */

        private void button12_Click(object sender, EventArgs e)
        {
            try
            { 
                string c = textBox1.Text;
                string[] P = c.Split('.');

          /* ############## doi phan nguyen ############# */
                
                //DOI TU HEX SANG DEC

                string n1=P[0];
                string[] a;
                string[] b;
                a = new string[100];
                b = new string[100];
                Int32 i = n1.Length - 1;// i bang chieu dai chuoi
                double s1 = 0, j = 0;
                while (i >= 0)
                {
                    a[i] = n1.Substring(i, 1);// cat chuoi co do dai bang 1
                    if (a[i] == "A") b[i] = "10";
                    else if (a[i] == "B") b[i] = "11";
                    else if (a[i] == "C") b[i] = "12";
                    else if (a[i] == "D") b[i] = "13";
                    else if (a[i] == "E") b[i] = "14";
                    else if (a[i] == "F") b[i] = "15";
                    else b[i] = a[i];
                    s1 = s1 + Convert.ToDouble(b[i]) * Math.Pow(16, j);
                    i--;//chieu dai chuoi giam
                    j++;//so mu 16 tang
                }

                //DOI TU DEC SANG OCT

                Int32 n = Convert.ToInt32(s1);
                Int32 t = 0;
                double d, s2 = 0;
                while (n > 0)
                {
                    d = n % 8;
                    n = n / 8;
                    s2 = s2 + d * Math.Pow(10, t);//lay gia tri bin
                    t++;
                };

        /* ############## doi phan le ############# */

                // DOI TU HEX SANG DEC

                string n2 = P[1];
                string[] A;
                string[] B;
                A = new string[100];
                B = new string[100];
                Int32 l = n2.Length - 1;// i bang chieu dai chuoi
                double s3 = 0;
                while (l >= 0)
                {
                    A[l] = n2.Substring(l, 1);// cat chuoi co do dai bang 1
                    if (A[l] == "A") B[l] = "10";
                    else if (A[l] == "B") B[l] = "11";
                    else if (A[l] == "C") B[l] = "12";
                    else if (A[l] == "D") B[l] = "13";
                    else if (A[l] == "E") B[l] = "14";
                    else if (A[l] == "F") B[l] = "15";
                    else B[l] = A[l];
                    s3= s3 + Convert.ToDouble(B[l]) * Math.Pow(16, (-1) * (l + 1));
                    l--;//chieu dai chuoi giam
                }

               // DOI TU DEC SANG OCT

                string s4 = "";
                double g = s3;

                Int32 w;
                while (g != 0)//vong lap ket thuc khi phan le =0
                {
                    g = g * 8;
                    w = Convert.ToInt32(g);//phan nguyen co lam tron
                    if (w <= g)//lam tron < g
                    {
                        s4 = s4 + Convert.ToString(w);
                        g = g - w;
                    }
                    else //lam tron > g
                    {
                        s4 = s4 + Convert.ToString(w - 1);//lam tron tang len 1 nen khi in phan nguyen phai tru 1
                        g = g + 1 - w;//g phai tang len 1 roi moi tru cho phan nguyen
                    }
                };
                textBox2.Text = Convert.ToString(s2) + '.' + Convert.ToString(s4);
        }

            catch
            {
                //DOI TU HEX SANG DEC

                string n = textBox1.Text;
                string[] a;
                string[] b;
                a = new string[100];
                b = new string[100];
                Int32 i = n.Length - 1;
                double s = 0, j = 0;
                while (i >= 0)
                {
                    a[i] = n.Substring(i, 1);
                    if (a[i] == "A") b[i] = "10";
                    else if (a[i] == "B") b[i] = "11";
                    else if (a[i] == "C") b[i] = "12";
                    else if (a[i] == "D") b[i] = "13";
                    else if (a[i] == "E") b[i] = "14";
                    else if (a[i] == "F") b[i] = "15";
                    else b[i] = a[i];
                    s = s + Convert.ToDouble(b[i]) * Math.Pow(16, j);
                    i--;
                    j++;

                }
                textBox2.Text = Convert.ToString(s);

                //DOI TU DEC SANG OCT

                Int32 m = Convert.ToInt32(s);//chuyen hex s vua tinh thanh kieu so nguyen
                double t = 0, l = 0, q;
                while (m > 0)
                {
                    q = m % 8;
                    m = m / 8;
                    t = t + q * Math.Pow(10, l);
                    l++;
                }
                textBox2.Text = Convert.ToString(t);
            }
        }

    private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Niên luận 1 học kì 2 niên khóa 2008-2009\rĐề tài: Chuyển đổi cơ số\rDo Phan Thị Tươi thực hiện\rMSSV: 1071496\rGVHD: Thái Minh Tuấn", "Thông tin chương trình", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

   
    }
}
