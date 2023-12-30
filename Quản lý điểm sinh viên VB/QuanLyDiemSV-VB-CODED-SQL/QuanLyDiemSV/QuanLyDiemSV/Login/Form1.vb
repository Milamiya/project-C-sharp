Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cnnt()
        Catch ex As SqlException
            MsgBox("Không thể kết nối đến cơ sở dữ liệu, vui lòng kiểm tra lại", MsgBoxStyle.Information, "Lỗi")
        End Try

        ds.Tables.Add("taikhoan")
        loadtk()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Bạn phải điền đủ ID và mật khẩu", MsgBoxStyle.Information, "Lỗi")
            Exit Sub

        End If
        If checktk(TextBox1.Text) = TextBox2.Text Then

            ds.Tables.Add("monhoc")
            ds.Tables.Add("sinhvien")
            ds.Tables.Add("sinhviennam")
            ds.Tables.Add("sinhviennu")
            ds.Tables.Add("khoa")
            ds.Tables.Add("ketqua")

            MainForm.Show()

            Me.Hide()

        Else
            MsgBox("Thông tin đăng nhập sai", MsgBoxStyle.Information, "Lỗi")
        End If
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        con.Close()
        Close()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If checktk(txtid.Text) = "" Then
            addtk(txtid.Text, txtpss.Text, txtpss2.Text, ComboBox1.Text, txtans.Text, False)
            MsgBox("Thành công", MsgBoxStyle.Information, "Chúc mừng")
        Else
            MsgBox("Tài khoản đã tồn tại", MsgBoxStyle.Information, "Lỗi")
        End If
        txtid.Clear()
        txtpss.Clear()
        txtpss2.Clear()
        txtans.Clear()
        ComboBox1.Refresh()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txtid.Clear()
        txtpss.Clear()
        txtpss2.Clear()
        txtans.Clear()
        ComboBox1.Refresh()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If checkpss2(txtid1.Text) = txtpss21.Text And checkuqes(txtid1.Text) = ComboBox2.Text And checkuans(txtid1.Text) = txtans1.Text Then
            resetpss(txtid1.Text, txtpss1.Text)
            MsgBox("Thành công", MsgBoxStyle.Information, "Chúc mừng")
            txtid1.Clear()
            txtpss1.Clear()
            txtpss21.Clear()
            txtans1.Clear()
            ComboBox2.Refresh()
        Else
            MsgBox("Thông tin không chính xác, vui lòng thử lại", MsgBoxStyle.Information, "Lỗi")
            txtid1.Clear()
            txtpss1.Clear()
            txtpss21.Clear()
            txtans1.Clear()
            ComboBox2.Refresh()

        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        txtid1.Clear()
        txtpss1.Clear()
        txtpss21.Clear()
        txtans1.Clear()
        ComboBox2.Refresh()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
