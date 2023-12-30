Imports System.Data.SqlClient
Public Class Form_Phan_Quyen
    Private lenh As String
    Private Sub ButtonThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonThoat.Click
        Me.Close()
    End Sub

    Private Sub Form_Phan_Quyen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadQuyen()
    End Sub

    Private Sub LoadQuyen()
        If Form_Login.LoginLoaiND = "Quan_Ly" OrElse Form_Login.LoginLoaiND = "Admin" Then
            grb_PhanQuyen.Enabled = True
        Else
            grb_PhanQuyen.Enabled = False
            btn_DongY.Enabled = False
        End If
        txt_IdNhanVien.Text = Form_Main.cbo_Username.Text

        Dim query As New SqlCommand("select * from PhanQuyen where IdNhanVien ='" + Form_Main.cbo_Username.Text + "'", connect)
        Dim DR As SqlDataReader
        connect.Open()
        DR = query.ExecuteReader
        While DR.Read() = True
            If CInt(DR.GetValue(1).ToString) = 1 Then
                ckb_xe.Checked = True
            End If
            If CInt(DR.GetValue(2).ToString) = 1 Then
                ckb_tuyen.Checked = True
            End If
            If CInt(DR.GetValue(3).ToString) = 1 Then
                ckb_ThoiDiem.Checked = True
            End If
            If CInt(DR.GetValue(4).ToString) = 1 Then
                ckb_chuyenXe.Checked = True
            End If
            If CInt(DR.GetValue(5).ToString) = 1 Then
                ckb_banve.Checked = True
            End If
        End While
        connect.Close()
    End Sub

    Private Sub btn_DongY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DongY.Click
        Dim Xe, TX, TD, CX, BV As String
        Xe = CStr(0)
        TX = CStr(0)
        TD = CStr(0)
        CX = CStr(0)
        BV = CStr(0)
        If ckb_xe.Checked = True Then
            Xe = CStr(1)
        End If
        If ckb_tuyen.Checked = True Then
            TX = CStr(1)
        End If
        If ckb_ThoiDiem.Checked = True Then
            TD = CStr(1)
        End If
        If ckb_chuyenXe.Checked = True Then
            CX = CStr(1)
        End If
        If ckb_banve.Checked = True Then
            BV = CStr(1)
        End If
        Dim dlg As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn cấp quyền cho nhân viên " & txt_IdNhanVien.Text & "!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlg = Windows.Forms.DialogResult.Yes Then
            'Duyet trong bang phan quyen xem co nhan vien ten do chua, neu chua thi insert vao
            Dim dr As SqlDataReader
            Dim lenh1 = "Select IdNhanVien from PhanQuyen"
            Dim bo_lenh As New SqlCommand(lenh1, connect)
            Dim flag As Integer = 0
            connect.Open()
            dr = bo_lenh.ExecuteReader
            While dr.Read = True
                If dr.GetValue(0).ToString = txt_IdNhanVien.Text Then
                    flag = 1
                    Exit While
                End If
            End While
            connect.Close()
            If flag = 0 Then
                lenh = "Insert into PhanQuyen values('" + txt_IdNhanVien.Text + "', " + Xe + ", " + TX + ", " + TD + ", " + CX + ", " + BV + ")"
            Else
                lenh = "Update PhanQuyen set Xe = '" + Xe + "', TuyenXe = '" + TX + "', ThoiDiem = '" + TD + "', ChuyenXe = '" + CX + "', BanVe = '" + BV + "' where IdNhanVien = '" + txt_IdNhanVien.Text + "'"
            End If
            Dim com As New SqlCommand(lenh, connect)
            'MessageBox.Show(lenh)
            Try
                connect.Open()
                com.ExecuteNonQuery()
                connect.Close()
                MessageBox.Show("Nhân viên " & txt_IdNhanVien.Text & " đã được cấp quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Cấp quyền không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End Try
        Else
            MessageBox.Show("Đã hủy thao tác cấp quyền, bạn có thể câp quyền lại hoặc thoát ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        connect.Close()
        UpdateQuyen()
    End Sub

    Public Sub UpdateQuyen()
        Dim query As New SqlCommand("select * from PhanQuyen where IdNhanVien ='" + Form_Login.LoginTenND + "'", connect)
        Dim DR As SqlDataReader
        connect.Open()
        DR = query.ExecuteReader
        While DR.Read() = True
            If CInt(DR.GetValue(1).ToString) = 0 Then
                Form_Main.TabItem_2.Visible = False
            End If
            If CInt(DR.GetValue(2).ToString) = 0 Then
                Form_Main.TabItem_3.Visible = False
            End If
            If CInt(DR.GetValue(3).ToString) = 0 Then
                Form_Main.TabItem_4.Visible = False
            End If
            If CInt(DR.GetValue(4).ToString) = 0 Then
                Form_Main.TabItem_5.Visible = False
            End If
            If CInt(DR.GetValue(5).ToString) = 0 Then
                Form_Main.TabItem_6.Visible = False
            End If
        End While
        connect.Close()
    End Sub
End Class