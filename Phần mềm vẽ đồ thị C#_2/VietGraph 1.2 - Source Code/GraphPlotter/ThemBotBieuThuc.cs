using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VietGraph
{
    public partial class ThemBotBieuThuc : Form
    {
        public ThemBotBieuThuc()
        {
            InitializeComponent();
        }

        private void ThemBotBieuThuc_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ExpressionHelper.ArrExpression.Count; i++)
            {
                clbExpression.Items.Add(ExpressionHelper.ArrExpression[i].ToString());
                for (int j = 0; j < clbExpression.Items.Count; j++)
                {
                    clbExpression.SetItemChecked(j, true);
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < clbExpression.Items.Count; i++)
                {
                    if (clbExpression.CheckedIndices.Contains(i))
                        Graph.expPlotter.SetExpressionVisibility(i, true);
                    else
                        Graph.expPlotter.SetExpressionVisibility(i, false);
                }
                Graph.expPlotter.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}