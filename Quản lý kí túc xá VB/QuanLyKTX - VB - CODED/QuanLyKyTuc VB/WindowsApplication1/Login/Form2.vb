Imports System.Data
Imports System.Data.OleDb

Public Class Form2

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If checktk(TextBox1.Text) = "" Then
            addtk(TextBox1.Text, TextBox2.Text, TextBox4.Text, ComboBox1.Text, TextBox6.Text)
            MsgBox("Thành công", MsgBoxStyle.Information, "Chúc mừng")
        Else
            MsgBox("Tài khoản đã tồn tại", MsgBoxStyle.Information, "Lỗi")
        End If
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        ComboBox1.Refresh()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class