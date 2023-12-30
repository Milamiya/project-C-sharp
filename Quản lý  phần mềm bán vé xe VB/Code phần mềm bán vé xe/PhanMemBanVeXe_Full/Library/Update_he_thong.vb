Imports System.Data.SqlClient
Public Class Update_he_thong
    Private lenh As String
    Private bang As DataTable

    Public Sub update_()
        lenh = "Delete from ChiTietTuyen where IdThoiDiem in (Select IdThoiDiem from ThoiDiem where Ngay < '" + CStr(Today.Date) + "')"
        'MessageBox.Show(lenh)
        Dim com1 As New SqlCommand(lenh, connect)
        Try
            connect.Open()
            com1.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception
            connect.Close()
            'MessageBox.Show("Xoa ko thanh cong")
        End Try
        lenh = "Select * from ChiTietTuyen"
        bang = Doc_bang(lenh)
        If bang.Rows.Count = 0 Then
            'MessageBox.Show(bang.Rows.Count.ToString)
            lenh = "Delete from ThoiDiem"
        Else
            'MessageBox.Show(bang.Rows.Count.ToString)
            lenh = "Delete from ThoiDiem where Ngay < '" + CStr(Today.Date) + "'"
            'IdThoiDiem <> (Select distinct IdThoiDiem from ChiTietTuyen) and 
            'MessageBox.Show(lenh)
        End If

        'MessageBox.Show(lenh1)
        'MessageBox.Show(lenh)
        ''connect.Close()
        Dim com2 As New SqlCommand(lenh, connect)
        Try
            connect.Open()
            com2.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception
            connect.Close()
            'MessageBox.Show("Xoa ko thanh cong")
        End Try

        '--------------------------------------------------Xu ly voi bang chuyenxxe, chongoi, banve
        lenh = "Delete from BanVe where IdChuyen in( Select IdChuyen from ChuyenXe where NgayDi < '" + CStr(Today.Date) + "')"
        Dim com As New SqlCommand(lenh, connect)
        Try
            connect.Open()
            com.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception
            connect.Close()
            'MessageBox.Show("Xoa ko thanh cong")
        End Try

        lenh = "Delete from ChoNgoi where IdChuyen in( Select IdChuyen from ChuyenXe where NgayDi < '" + CStr(Today.Date) + "')"
        Dim com4 As New SqlCommand(lenh, connect)
        Try
            connect.Open()
            com4.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception
            connect.Close()
            'MessageBox.Show("Xoa ko thanh cong")
        End Try


        lenh = "Select * from BanVe"
        bang = Doc_bang(lenh)
        If bang.Rows.Count = 0 Then
            'MessageBox.Show(bang.Rows.Count.ToString)
            lenh = "Delete from ChuyenXe"
        Else
            'MessageBox.Show(bang.Rows.Count.ToString)
            lenh = "Delete from ChuyenXe where IdChuyen <> (Select IdChuyen from BanVe)"
        End If

        'MessageBox.Show(lenh)
        'MessageBox.Show(lenh)
        'connect.Close()
        Dim com3 As New SqlCommand(lenh, connect)
        Try
            connect.Open()
            com3.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception
            connect.Close()
            'MessageBox.Show("Xoa ko thanh cong")
        End Try

    End Sub
End Class
