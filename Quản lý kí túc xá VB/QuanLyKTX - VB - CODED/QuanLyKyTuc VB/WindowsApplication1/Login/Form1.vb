Imports System.Data
Imports System.Data.OleDb

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            cnnt()
        Catch ex As OleDbException
            MsgBox("Không thể kết nối đến cơ sở dữ liệu, vui lòng kiểm tra lại", MsgBoxStyle.Information, "Lỗi")
            Exit Sub
        End Try
        ds.Tables.Add("taikhoan")
        loadtk()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If checktk(TextBox1.Text) = TextBox2.Text And TextBox1.Text <> "" And TextBox2.Text <> "" Then

            ds.Tables.Add("khoa")
            ds.Tables.Add("phong")
            ds.Tables.Add("kytuc")
            ds.Tables.Add("phongtkt")
            ds.Tables.Add("hoso")

            Form7.Show()
            Me.Hide()

        Else
            MsgBox("Thông tin đăng nhập sai", MsgBoxStyle.Information, "Lỗi")
        End If
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form2.Show()

    End Sub
End Class