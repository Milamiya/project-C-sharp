Imports System.Data
Imports System.Data.OleDb


Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      
        loadkhoa()
        DataGridView1.DataSource = ds.Tables("khoa")

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim res As Long
        If checkmkhoa(TextBox1.Text) = 0 Then
            res = MsgBox("Bạn muốn thêm mới", MsgBoxStyle.OkCancel, "Thông Báo")
            If res = vbOK Then
                addkhoa(TextBox1.Text, TextBox2.Text)

            Else : res = vbCancel

            End If

        Else
            res = MsgBox("Mã khoa đã tồn tại,bạn có muốn sửa ?", MsgBoxStyle.OkCancel, "Thông Báo ")
            If res = vbOK Then
                updkhoa(TextBox1.Text, TextBox2.Text)

            Else : res = vbCancel


            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If checkmkhoa(TextBox1.Text) = 0 Then
            MsgBox("Không có mã khoa này , không xóa được", MsgBoxStyle.Information, "Thông báo")
        Else
            delkhoa(TextBox1.Text)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class