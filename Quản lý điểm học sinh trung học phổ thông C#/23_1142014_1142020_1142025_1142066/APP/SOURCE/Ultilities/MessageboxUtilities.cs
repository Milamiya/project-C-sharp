using System;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace Util
{
    public static class MsgboxUtil
    {
        public static DialogResult Error(Exception ex)
        {
            return XtraMessageBox.Show(ex.Message,
                                       "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Error(string message)
        {
            return XtraMessageBox.Show("Lỗi: " + message, "LỖI",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Success(string message)
        {
            return XtraMessageBox.Show(message, "THÀNH CÔNG",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Info(string message)
        {
            return XtraMessageBox.Show(message, "THÔNG TIN",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult YesNo(string message)
        {
            return XtraMessageBox.Show(message, "HỎI",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static DialogResult OkCancel(string message)
        {
            return XtraMessageBox.Show(message, "HỎI",
                                       MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        public static void ShowTooltip(ToolTipController tooltip, string msg, string title = "<b>Hướng dẫn</b>")
        {
            var targ = new ToolTipControllerShowEventArgs
                           {
                               Title = title,
                               ToolTip = msg,
                               ShowBeak = true,
                               Rounded = true,
                               RoundRadius = 7,
                               ToolTipType = ToolTipType.SuperTip,
                               IconType = ToolTipIconType.Information,
                               IconSize = ToolTipIconSize.Small
                           };
            tooltip.ShowHint(targ);
        }
    }
}