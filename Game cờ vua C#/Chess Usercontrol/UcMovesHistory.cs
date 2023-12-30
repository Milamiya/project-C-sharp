using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace Chess_Usercontrol
{
    public partial class UcMovesHistory : UserControl
    {
        public UcMovesHistory()
        {
            InitializeComponent();
        }

        public void LoadMovesHistory(Stack stkWhite, Stack stkBlack)
        {
            listView1.Items.Clear();
            if (stkBlack.Count == 0 && stkWhite.Count == 0)
                return;
            Stack stk1 = new Stack();
            Stack stk2 = new Stack();


            foreach (string s in stkWhite)
            {
                stk1.Push(s.ToLower());
            }
            foreach (string s in stkBlack)
            {
                stk2.Push(s.ToLower());
            }

            if (stk2.Count > stk1.Count)
            {
                int i = 1;
                foreach (string s in stk2)
                {
                    ListViewItem litem = new ListViewItem();
                    litem.Text = i.ToString();
                    i++;
                    litem.SubItems.Add("");
                    litem.SubItems.Add(s);
                    listView1.Items.Add(litem);
                }
                i = 1;
                foreach (string s in stk1)
                {
                    ListViewItem litem = listView1.Items[i++ - 1];
                    litem.SubItems[1].Text = s;
                }
            }
            else
            {
                int i = 1;
                foreach (string s in stk1)
                {
                    ListViewItem litem = new ListViewItem();
                    litem.Text = i.ToString();
                    i++;
                    litem.SubItems.Add(s);
                    litem.SubItems.Add("");
                    listView1.Items.Add(litem);
                }
                i = 1;
                foreach (string s in stk2)
                {
                    ListViewItem litem = listView1.Items[i++ - 1];
                    litem.SubItems[2].Text = s;
                }
            }

            listView1.TopItem = listView1.Items[listView1.Items.Count - 1];
        }


        private void UcMovesHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
