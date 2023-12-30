using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyDaoTao.Utilities;
using System.Collections.ObjectModel;
using System.IO;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmXemNhatKy : XtraForm
    {
        string tenFile;
        LogFile log;
        Collection<LogFile> logs;
        public frmXemNhatKy()
        {
            try
            {
                InitializeComponent();
                tenFile = string.Empty;
                log = new LogFile();
                logs = new Collection<LogFile>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmXemNhatKy_Load(object sender, EventArgs e)
        {
            try
            {
                dateNgay.DateTime = DateTime.Now;
                tenFile = "Thang_" + dateNgay.DateTime.ToString("MM-yyyy") + "_log.log";
                LoadLogs();
                dateBatDau.DateTime = dateNgay.DateTime;
                dateKetThuc.DateTime = dateBatDau.DateTime.AddDays(3);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void LoadLogs()
        {
            try
            {
                if (File.Exists(tenFile))
                {
                    listViewEx1.Items.Clear();
                    logs = LogFile.DocFile(tenFile);
                    if (logs.Count > 0)
                    {
                        groupControl1.Text = "Nhật ký hệ thống tháng: " + dateNgay.DateTime.ToString("MM/yyyy");
                        foreach (var log in logs)
                        {
                            ListViewItem item = new ListViewItem(new string[] 
                            { log.ThoiGian.ToString("HH:mm:ss dd/MM/yyyy"), 
                                log.Quyen, 
                                log.TenNguoiDung, 
                                log.ThaoTac 
                            });
                            listViewEx1.Items.Add(item);
                        }
                    }
                }
                else
                {
                    MsgboxUtil.Exclamation("Không tồn tại lịch sử cho tháng này");
                    dateNgay.DateTime = DateTime.Parse(listViewEx1.Items[0].Text);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dateNgay_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                tenFile = "Thang_" + dateNgay.DateTime.ToString("MM-yyyy") + "_log.log";
                LoadLogs();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            try
            {
                LoadLogs();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                listViewEx1.Items.Clear();
                if (logs.Count > 0)
                {
                    foreach (var log in logs)
                    {
                        if (log.ThoiGian.Date >= dateBatDau.DateTime.Date && log.ThoiGian.Date <= dateKetThuc.DateTime.Date)
                        {
                            ListViewItem item = new ListViewItem(new string[] 
                            { log.ThoiGian.ToString("HH:mm:ss dd/MM/yyyy"), 
                                log.Quyen, 
                                log.TenNguoiDung, 
                                log.ThaoTac 
                            });
                            listViewEx1.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}