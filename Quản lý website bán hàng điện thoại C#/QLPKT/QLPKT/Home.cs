using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLPKT
{
    public partial class Home : Form
    {
        private string name;

        public Home(string name1)
        {
            InitializeComponent();
            name = name1;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            label_wel.Text = "Welcome " + name;
        }
    }
}
