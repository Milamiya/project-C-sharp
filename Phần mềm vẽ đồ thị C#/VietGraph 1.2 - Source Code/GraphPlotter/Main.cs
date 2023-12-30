
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;


namespace VietGraph
{
    public partial class Main : Form
    {
        Graph form;
        Color[] colorLevels = { Color.Red,  Color.Green, Color.Blue,  
            Color.Purple, Color.Brown, Color.Orange, Color.Chocolate, 
            Color.Maroon, Color.Navy, Color.YellowGreen };
        string[] strFunctions ={ "abs", "sin", "cos", "tan", "sec", "cosec", "cot", "arcsin", 
            "arccos", "arctan", "exp", "ln", "log", "antilog", "sqrt", "sinh", "cosh", "tanh", 
            "arcsinh", "arccosh", "arctanh" };

        public Main()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void Form1_Load(object sender, EventArgs e)
        {
            this.mode.SelectedIndex = 0;
            this.sensitivity.Enabled = false;

            this.lstExpressions.Items.Add("x");
            this.lstExpressions.Items.Add("-x");
            this.lstExpressions.Items.Add("x-3");
            this.lstExpressions.Items.Add("-x-3");
            this.lstExpressions.Items.Add("x+3");
            this.lstExpressions.Items.Add("3-x");
            //this.lstExpressions.Items.Add("5*(sin(x)+sin(3*x)/3+sin(5*x)/5+sin(7*x)/7+sin(9*x)/9+sin(11*x)/11+sin(13*x)/13)");
        }

        private void txtExpression_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = this.txtExpression.SelectionStart;
            WriteText(this.txtExpression.Text);
            this.txtExpression.SelectionStart = cursorPosition;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.CheckDuplication();    
        }

        private bool CheckDuplication()
        {
            for (int i = 0; i < lstExpressions.Items.Count; i++)
            {
                if (txtExpression.Text == lstExpressions.Items[i].ToString())
                {
                    MessageBox.Show("Đã có biểu thức này trong danh sách rồi.");
                    return false;
                }
            }

            AddExpression();
            this.lstExpressions.SelectedIndex = -1;
            this.lstExpressions.Refresh();
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lstExpressions.Items.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = this.lstExpressions.SelectedIndex;
            this.lstExpressions.Items.Remove(this.lstExpressions.SelectedItem);
            if (index == this.lstExpressions.Items.Count)
                index--;
            if (index != -1)
                this.lstExpressions.SelectedIndex = index;
        }

        private void cmdPlotGraph_Click(object sender, EventArgs e)
        {
            if (mode.Text == "Cartesian")
            {
                ExpressionHelper.Cartesian = true;
                ExpressionHelper.Polar = false;
            }
            else
            {
                ExpressionHelper.Polar = true;
                ExpressionHelper.Cartesian = false;
            }

            ExpressionHelper.XStartValue = Convert.ToDouble(startX.Value);
            ExpressionHelper.XEndValue = Convert.ToDouble(endX.Value);

            if (form == null || form.IsDisposed)
            {
                form = new Graph();
                form.Show();
            }

            form.SetRange((Double)startX.Value, (Double)endX.Value, (Double)startY.Value, (Double)endY.Value);
            form.SetDivisions((int)this.divX.Value, (int)this.divY.Value);
            form.SetPenWidth((int)this.penWidth.Value);

            if (this.mode.SelectedItem.ToString() == "Polar")
                form.SetMode(GraphMode.Polar, (int)this.sensitivity.Value);
            else
                form.SetMode(GraphMode.Rectangular, 50);

            //form.RemoveAllExpressions();
            ExpressionHelper.ArrExpression.Clear();
            for (int i = 0; i < lstExpressions.Items.Count; i++)
            {
                form.AddExpression((string)lstExpressions.Items[i], colorLevels[i % colorLevels.Length]);
                //Add expression to Array Expression (ThemBotBieuThuc form)
                ExpressionHelper.ArrExpression.Add(lstExpressions.Items[i]);
            }

            form.Refresh();
            form.Activate();
        }

        private void mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.mode.SelectedIndex == 1)
                this.sensitivity.Enabled = true;
            else
                this.sensitivity.Enabled = false;
        }

        private void txtExpression_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txtExpression.Text.Length > 0)
                AddExpression();

            //if a letter is found
            if (char.IsLetter(e.KeyChar))
            {
                int cursorPos = this.txtExpression.SelectionStart;
                if (cursorPos > 0)
                {
                    //if the previous char is a digit, add a *
                    if (char.IsDigit(this.txtExpression.Text[cursorPos - 1]))
                    {
                        this.txtExpression.Text = this.txtExpression.Text.Insert(cursorPos, "*" + e.KeyChar);
                        cursorPos += 2;
                        this.txtExpression.SelectionStart = cursorPos;
                        e.Handled = true;
                    }
                    //if a function is formed, add a "("
                    else
                    {
                        string text = string.Empty;
                        int i = cursorPos - 1;
                        while (i >= 0)
                        {
                            if (!char.IsLetter(this.txtExpression.Text[i]))
                                break;
                            i--;
                        }
                        i++;
                        //now i is the index where last text is started
                        if (i < cursorPos)
                            text = this.txtExpression.Text.Substring(i, cursorPos - i) + e.KeyChar;
                        if (IsFunction(text))
                        {
                            this.txtExpression.Text = this.txtExpression.Text.Insert(cursorPos, e.KeyChar.ToString() + "(");
                            cursorPos += 2;
                            this.txtExpression.SelectionStart = cursorPos;
                            e.Handled = true;
                        }
                    }
                }
            }
        }

        private void lstExpressions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstExpressions.SelectedIndex != -1)
                this.txtExpression.Text = this.lstExpressions.Items[this.lstExpressions.SelectedIndex].ToString();
        }

        #endregion

        #region Helper Functions
        //this functions handles coloring of expressions
        private void WriteText(string text)
        {
            int colorIndex = 0;
            this.txtExpression.Text = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    colorIndex++;
                    if (colorIndex == colorLevels.Length)
                        colorIndex = 0;
                    txtExpression.SelectionColor = colorLevels[colorIndex];
                }

                this.txtExpression.AppendText(text[i].ToString());

                if (text[i] == ')')
                {
                    colorIndex--;
                    if (colorIndex < 0)
                        colorIndex = colorLevels.Length - 1;
                    txtExpression.SelectionColor = colorLevels[colorIndex];
                }
            }
        }

        private bool IsFunction(string text)
        {
            for (int i = 0; i < strFunctions.Length; i++)
                if (string.Compare(text, strFunctions[i], true) == 0)
                    return true;
            return false;
        }

        private void AddExpression()
        {
            if (this.txtExpression.Text.Length == 0)
                return;
            this.txtExpression.Text = CompleteParenthesis(this.txtExpression.Text);
            string expText = this.txtExpression.Text;
            IEvaluatable exp = new Expression(expText);
            if (!exp.IsValid)
            {
                if (MessageBox.Show("Biểu thức bạn định thêm vào danh sách không hợp lệ! Bạn vẫn muốn thêm nó vào danh sách?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }
            this.lstExpressions.Items.Add(expText);
            this.txtExpression.Text = string.Empty;
        }
        private string CompleteParenthesis(string exp)
        {
            int leftBracket = 0;
            int rightBracket = 0;
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '(')
                    leftBracket++;
                else if (exp[i] == ')')
                    rightBracket++;
            }
            exp = exp.PadRight(exp.Length + leftBracket - rightBracket, ')');
            return exp;
        }

        #endregion

        #region Menu Area
        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TacGia frmTacGia = new TacGia();
            frmTacGia.Show();
        }



        private void absToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "abs(";
        }

        private void sinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "sin(";
        }

        private void cosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "cos(";
        }

        private void tanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "tan(";
        }

        private void secToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "sec(";
        }

        private void cosecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "cosec(";
        }

        private void cotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "cot(";
        }

        private void arcsinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "arcsin(";
        }

        private void arccosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "arccos(";
        }

        private void arctanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "arctan(";
        }

        private void expToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "exp(";
        }

        private void lnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "ln(";
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "log(";
        }

        private void antilogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "antilog(";
        }

        private void sqrtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "sqrt(";
        }

        private void sinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "sinh(";
        }

        private void coshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "cosh(";
        }

        private void tanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "tanh(";
        }

        private void arcsinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "arcsinh(";
        }

        private void arccoshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "arccosh(";
        }

        private void arctanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "arctanh(";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "+";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "-";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "*";
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "/";
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "^";
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "(";
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            txtExpression.Text += ")";
        }
        #endregion
    }
}
