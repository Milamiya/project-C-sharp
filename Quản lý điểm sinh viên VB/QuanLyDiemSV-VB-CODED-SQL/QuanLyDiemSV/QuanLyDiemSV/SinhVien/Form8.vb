Imports Microsoft.Reporting.WinForms

Public Class Form8

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()

        ReportViewer1.Reset()
        ReportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyDiemSV.sinhvien.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()

        Dim newDataSource As ReportDataSource = New ReportDataSource("DataSet1_tblsinhvien", ds.Tables("sinhvien"))
        ReportViewer1.LocalReport.DataSources.Add(newDataSource)

        ReportViewer1.RefreshReport()
        ReportViewer1.LocalReport.DisplayName = "List"
    End Sub
End Class