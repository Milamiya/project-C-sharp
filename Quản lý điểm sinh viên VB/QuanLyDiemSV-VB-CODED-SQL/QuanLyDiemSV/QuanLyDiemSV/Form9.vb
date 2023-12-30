Imports Microsoft.Reporting.WinForms

Public Class Form9

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()

        ReportViewer1.Reset()
        ReportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyDiemSV.ketqua.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()

        Dim newDataSource As ReportDataSource = New ReportDataSource("DataSet1_tblketqua", ds.Tables("ketqua"))
        ReportViewer1.LocalReport.DataSources.Add(newDataSource)

        Dim Parameters As List(Of ReportParameter) = New List(Of ReportParameter)

        Dim p1 As ReportParameter
        Dim p2 As ReportParameter
        Dim p3 As ReportParameter

        p1 = New ReportParameter("ngaysinh", ngaysinhsv(MainForm.dgv1.CurrentCell.Value))
        p2 = New ReportParameter("hoten", hotensv(MainForm.dgv1.CurrentCell.Value))
        p3 = New ReportParameter("khoa", khoasv(MainForm.dgv1.CurrentCell.Value))

        Parameters.Add(p1)
        Parameters.Add(p2)
        Parameters.Add(p3)

        ReportViewer1.LocalReport.SetParameters(Parameters)

        ReportViewer1.RefreshReport()
        ReportViewer1.LocalReport.DisplayName = "KQ"

    End Sub
End Class