using System.Data;
using DevExpress.XtraEditors;

namespace Util
{
    public class CboUtil
    {
        private readonly string _sDisplay;
        private readonly string _sValue;

        public CboUtil(string svalue, string sdisplay)
        {
            _sValue = svalue;
            _sDisplay = sdisplay;
        }

        public string Value
        {
            get { return _sValue; }
        }

        public override string ToString()
        {
            return _sDisplay;
        }

        /// <summary>
        /// Gắn DataSource cho ComboBoxEdit
        /// </summary>
        /// <param name="comb">ComboBoxEdit</param>
        /// <param name="dt">DataTable</param>
        /// <param name="value">String: Value member</param>
        /// <param name="display">String: Display member</param>
        /// <param name="selectedIndex">Int: Chọn dòng</param>
        public static void SetDataSource(ComboBoxEdit comb, DataTable dt, string value, string display,
                                         int selectedIndex = 0)
        {
            if (dt == null)
                return;
            comb.Properties.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                comb.Properties.Items.Add(
                    new CboUtil(dr[value].ToString(), dr[display].ToString())
                    );
            }
            comb.SelectedIndex = selectedIndex;
        }

        /// <summary>
        /// Gắn DataSource cho ComboBoxEdit có thêm dòng đầu tiên
        /// </summary>
        /// <param name="comb">ComboBoxEdit</param>
        /// <param name="dt">DataTable</param>
        /// <param name="value">String: Value member</param>
        /// <param name="display">String: Display member</param>
        /// <param name="valueAll">String: Display member dòng đầu tiên</param>
        /// <param name="displayAll">String: Value member dòng đầu tiên</param>
        /// <param name="selectedIndex">Int: Chọn dòng</param>
        public static void SetDataSource(ComboBoxEdit comb, DataTable dt, string value, string display,
                                         string valueAll = "all", string displayAll = "Tất cả", int selectedIndex = 0)
        {
            if (dt == null)
                return;
            comb.Properties.Items.Clear();

            comb.Properties.Items.Add(new CboUtil(valueAll, displayAll));

            foreach (DataRow dr in dt.Rows)
            {
                comb.Properties.Items.Add(
                    new CboUtil(dr[value].ToString(), dr[display].ToString())
                    );
            }
            comb.SelectedIndex = selectedIndex;
        }

        /// <summary>
        /// Lấy giá trị trả về selected của ComboboxEdit
        /// </summary>
        /// <param name="comb">ComboBoxEdit</param>
        /// <returns>string: giá trị valuemember</returns>
        public static string GetValueItem(ComboBoxEdit comb)
        {
            if (comb.SelectedItem == null)
                return null;
            return ((CboUtil) comb.SelectedItem).Value;
        }

        /// <summary>
        /// Lấy giá trị hiển thị selected của ComboboxEdit
        /// </summary>
        /// <param name="comb">ComboBoxEdit</param>
        /// <returns>string: giá trị valuemember</returns>
        public static string GetDisplayItem(ComboBoxEdit comb)
        {
            if (comb.SelectedItem == null)
                return null;
            return ((CboUtil) comb.SelectedItem)._sDisplay;
        }

        /// <summary>
        /// Chọn Item ComboBoxEdit
        /// </summary>
        /// <param name="comb">ComboBoxEdit</param>
        /// <param name="svalue">String: Giá trị chọn valuemember</param>
        public static void SelectedItem(ComboBoxEdit comb, string svalue)
        {
            foreach (object item in comb.Properties.Items)
            {
                if (((CboUtil) item).Value == svalue)
                    comb.SelectedItem = item;
            }
        }

        public static bool CheckSelectedNull(ComboBoxEdit comb)
        {
            return comb.SelectedItem == null;
        }
    }
}