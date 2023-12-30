Imports System.Data
Imports System.Data.OleDb

Public Class Form3

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If checkpss2(TextBox1.Text) = TextBox2.Text And checkuqes(TextBox1.Text) = ComboBox1.Text And checkuans(TextBox1.Text) = TextBox4.Text Then
            resetpss(TextBox1.Text, TextBox5.Text)
        Else
            MsgBox("Thông tin không chính xác, vui lòng thử lại", MsgBoxStyle.Information, "Lỗi")

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class