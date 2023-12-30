using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShutdownManager
{
    public partial class frmAboutAuthor : Form
    {
        public frmAboutAuthor()
        {
            InitializeComponent();
        }

        #region Event
        private void frmAboutAuthor_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(299, 154);
        }
        #endregion

    }
}