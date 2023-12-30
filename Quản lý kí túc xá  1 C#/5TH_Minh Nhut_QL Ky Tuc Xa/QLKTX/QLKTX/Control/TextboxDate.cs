using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QLKTX.Control
{
    public class TextboxDate: DevComponents.DotNetBar.Controls.TextBoxX
    {
        DateTime t;
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return base.ToString();
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            String str = "0123456789/";
            if (!str.Contains(e.KeyChar.ToString()))
            {
                e.Handled = true;
             
            }                        
        }
        
        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
        {
            if (Keys.Enter.Equals(e.KeyData) || Keys.Tab.Equals(e.KeyData) || Keys.Up.Equals(e.KeyData)
                || Keys.Down.Equals(e.KeyData) )
            {
                KiemTra();
                
            }
            
        }
        protected override void OnMouseLeave(EventArgs e)
        {
           // KiemTra();
        }
        public void KiemTra()
        {
            string str = this.Text;
           

            bool bo = DateTime.TryParse(str, out t);

            if (!bo)
            {
                MessageBox.Show("Ngày nhập không hợp lệ.", "Lỗi");
                this.Focus();
                this.SelectAll();
            }
        }
        public int Day
        {
            get
            {
                if (DateTime.TryParse(this.Text, out t))
                    return t.Day;
                else return 1;
            }            
        }
        public int Month
        {
            get
            {
                if (DateTime.TryParse(this.Text, out t))
                    return t.Month;
                else return 1;
            }
        }
        public DateTime Date
        {
            get
            {
                if (DateTime.TryParse(this.Text, out t))
                    return t;
                return t;
            }
        }
        public int Year
        {
            get
            {
                if (DateTime.TryParse(this.Text, out t))
                    return t.Year;
                else return 1;
            }
        }
        
    }
}
