using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TCP_Private_Server
{
    public partial class Form_About : Form
    {
        public Form_About()
        {
            InitializeComponent();
        }
        // Note: Because this form is opened by frmMain using the ShowDialog command, we simply set the
        // DialogResult property of cmdOK to OK which causes the form to close when clicked.
        private void Form_About_Load(object sender, EventArgs e)
        {
            try
            {
                // Set this Form's Text + Icon properties by using values from the parent form
                this.Text = "About " + this.Owner.Text;
                this.Icon = this.Owner.Icon;
                // Set this Form's Picture Box's image using the parent's icon 
                // However, we need to convert it to a Bitmap since the Picture Box Control
                // will not accept a raw Icon.
                this.pictureBox_About.Image = this.Owner.Icon.ToBitmap();
                // Set the labels identitying the Title, Version, and Description by
                // reading Assembly meta-data originally entered in the AssemblyInfo.cs file
                // using the AssemblyInfo class defined in the same file
                AssemblyInfo ainfo = new AssemblyInfo();
                this.label_Title.Text = ainfo.Title;
                this.label_Version.Text = string.Format("Version {0}", ainfo.Version);
                this.label_Copyright.Text = ainfo.Copyright;
                this.label_Description.Text = ainfo.Description;
                this.label_CodeDatabase.Text = ainfo.CodeBase;
            }
            catch (System.Exception exp)
            {
                // This catch will trap any unexpected error.
                MessageBox.Show(exp.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}