using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School._forms
{
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;

        public MDIParent()
        {
            InitializeComponent();
        }
        _class.cLsImageList cLsImage_List = new School._class.cLsImageList();
        private void ShowNewForm(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            Form childForm = new Form();
            // Make it a child of this MDI form before showing it.
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                // TODO: Add code here to open the file.
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                // TODO: Add code here to save the current contents of the form to a file.
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        

        

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
           
            School._class.cLsImageList.SetListView(lvShortcuts, "Class Setup", 0, i64x64);
            School._class.cLsImageList.SetListView(lvShortcuts, "Student Setup", 1, i64x64);
            School._class.cLsImageList.SetListView(lvShortcuts, "Employee Setup", 2, i64x64);
            School._class.cLsImageList.SetListView(lvShortcuts, "Expense Head", 3, i64x64);
            School._class.cLsImageList.SetListView(lvShortcuts, "Expense Detail", 4, i64x64);
            School._class.cLsImageList.SetListView(lvShortcuts, "Subject Setup", 5, i64x64);
            School._class.cLsImageList.SetListView(lvShortcuts, "Fee Setup", 6, i64x64);
            School._class.cLsImageList.SetListView(lvShortcuts, "Employee Attendence Setup", 7, i64x64);
            School._class.cLsImageList.SetListView(lvShortcuts, "Student Attendence Setup", 11, i64x64);
            School._class.cLsImageList.SetListView(lvShortcuts, "Examination Setup", 8, i64x64);
            School._class.cLsImageList.SetListView(lvShortcuts, "Exam Detail", 9, i64x64);
            School._class.cLsImageList.SetListView(lvShortcuts, "Exit", 10, i64x64);
            //Contents For Report List
           School._class.cLsImageList.SetListView(lvShortcuts2, "Report1", 12, this.i64x64);
           School._class.cLsImageList.SetListView(lvShortcuts2, "Report1", 12, this.i64x64);
           School._class.cLsImageList.SetListView(lvShortcuts2, "Report1", 12, this.i64x64);
           School._class.cLsImageList.SetListView(lvShortcuts2, "Report1", 12, this.i64x64);
           School._class.cLsImageList.SetListView(lvShortcuts2, "Report1", 12, this.i64x64);
           School._class.cLsImageList.SetListView(lvShortcuts2, "Report1", 12, this.i64x64);
           School._class.cLsImageList.SetListView(lvShortcuts2, "Report1", 12, this.i64x64);


        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lvShortcuts_DoubleClick(object sender, EventArgs e)
        {
            switch (lvShortcuts.Items[lvShortcuts.FocusedItem.Index].SubItems[0].Text)
            {
                case "Class Setup":
                    frmQclass frm_Qclass = new frmQclass();
                    frm_Qclass.Show();
                   /* frmClass frm_Class = new frmClass();
                    frm_Class.Show();*/
                    
                    break;
                case "Student Setup":
                    frmQstudent frm_Qstudent = new frmQstudent();
                    frm_Qstudent.Show();
                  /*  frmStudent frm_Student = new frmStudent();
                    frm_Student.Show();*/
                    break;

                case "Employee Setup":
                    frmQemployee frm_qEmp = new frmQemployee();
                    frm_qEmp.Show ();
                   /* frmEmployee frm_Employee = new frmEmployee();
                    frm_Employee.Show();*/                    
                    break;
                case "Expense Head":
                    frmQexp frm_Qexp=new frmQexp ();
                    frm_Qexp.Show ();
                    break ;
                case "Expense Detail":
                    frmQexpD frm_QexpD = new frmQexpD();
                    frm_QexpD.Show();
                    break;

                case "Subject Setup":
                    frmQsubject frm_Qsubject = new frmQsubject();
                    frm_Qsubject.Show();
                   /* frmSubject frm_Subject = new frmSubject();
                    frm_Subject.Show();*/                    
                    break;

                case "Fee Setup":
                    frmFee frm_Fee = new frmFee();
                    frm_Fee.Show();                    
                    break;
                case "Employee Attendence Setup":
                    frmQaEmp frm_QaEmp = new frmQaEmp();
                    frm_QaEmp.Show();
                    /*frmAttEmp frm_AttEmp = new frmAttEmp();
                    frm_AttEmp.Show(); */                  
                    break;
                case "Student Attendence Setup":
                    frmAttStu frm_AttStu = new frmAttStu();
                    frm_AttStu.Show();                   
                    break;
                case "Examination Setup":
                    frmQexam frm_Qexam = new frmQexam();
                    frm_Qexam.Show();
                    /*frmExam frm_Exam = new frmExam();
                    frm_Exam.Show(); */                   
                    break;

                case "Exit":
                    
                    DialogResult ret;
                    ret = MessageBox.Show("Are you want to Exit!", "Exit".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (ret == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        return;
                    }
                    break;
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAboutUs frm_Abouus = new frmAboutUs();
            frm_Abouus.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        

       

        

        


        
    }
}
