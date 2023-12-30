Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Public Class Form_Xe_30_Cho
    Private lenh As String
    Private lenh1 As String
    Private Ban_ve As New Ban_ve
    Private IdChuyen As String
    Private bang_dat_ve As DataTable

    Private Sub btn_Thoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Thoat.Click
        Ban_ve.Update_Ve_xe()
        Me.Close()
    End Sub

    Private Sub btn_TaiXe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TaiXe.Click
        MessageBox.Show("Chỗ này của tài xế bạn ơi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Sub

    Private Sub Duyet_danh_sach_cho_ngoi()
        With Form_Main
            lenh = "Select IdChuyen from ChuyenXe where IdTuyen = '" + .cbo_TenTuyenVe.SelectedValue.ToString + "'"
            lenh &= " and  NgayDi =  '" + FormatDateTime(CDate(.cbo_NgayVe.SelectedValue.ToString), DateFormat.ShortDate) + "' and Gio = '" + .cbo_GioVe.SelectedValue.ToString + "'"
            lenh &= " and So_Xe = '" + .cbo_XeVe.SelectedValue.ToString + "'"
            'Lay Idchuyen cua chuyen do ra
            bang_dat_ve = Doc_bang(lenh)
            IdChuyen = bang_dat_ve.Rows(0)("IdChuyen").ToString
        End With

        lenh = "Select * from ChoNgoi where IdChuyen = '" + IdChuyen + "' and So_Xe = '" + Form_Main.cbo_XeVe.SelectedValue.ToString + "'"
        Dim com As New SqlCommand(lenh, connect)
        Try
            connect.Open()
            Dim dr As SqlDataReader = com.ExecuteReader
            While dr.Read = True
                For i As Integer = 0 To grb_30.Controls.Count - 1
                    If dr.GetValue(2).ToString = grb_30.Controls(i).Text Then
                        CType(grb_30.Controls(i), DevComponents.DotNetBar.ButtonX).Image = My.Resources.hanh_khach
                    End If
                Next
            End While
            connect.Close()
        Catch ex As Exception
            MessageBox.Show("Không đọc được danh sách chỗ ngồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub Form_Xe_30_Cho_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Duyet_danh_sach_cho_ngoi()
    End Sub

    Private Sub Duyet(ByVal but As DevComponents.DotNetBar.ButtonX)
        Dim dg As DialogResult = MessageBox.Show("Ban có chắn chắc muốn đặt:" & vbNewLine & _
                                "- Xe: " & Form_Main.cbo_XeVe.SelectedValue.ToString & vbNewLine & _
                                "- Vị trí chỗ ngồi: " & but.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dg = Windows.Forms.DialogResult.Yes Then
            lenh = "Insert into ChoNgoi Values('" + IdChuyen + "', '" + Form_Main.cbo_XeVe.Text + "', '" + but.Text + "')"
            lenh1 = "Insert into BanVe(IdChuyen, TenHanhKhach, SDTHanhKhach) "
            lenh1 &= "Values('" + IdChuyen + "', N'" + Form_Main.txt_TenHanhKhach.Text + "', '" + Form_Main.txt_SoDTHanhKhach.Text + "')"
            Dim com As New SqlCommand(lenh, connect)
            Dim com1 As New SqlCommand(lenh1, connect)
            Try
                connect.Open()
                com.ExecuteNonQuery()
                com1.ExecuteNonQuery()
                connect.Close()
                MessageBox.Show("Đặt chỗ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Duyet_danh_sach_cho_ngoi()
            Catch ex As Exception
                MessageBox.Show("Chỗ này đã có người đặt rồi bạn ơi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                connect.Close()
            End Try
        Else
            MessageBox.Show("Đã hủy thao tác chọn chỗ ngồi, bạn có thể chọn chỗ khác nếu muốn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_8.Click
        Duyet(btn_8)
    End Sub
    Private Sub btn_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_7.Click
        Duyet(btn_7)
    End Sub
    Private Sub btn_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_3.Click
        Duyet(btn_3)
    End Sub
    Private Sub btn_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_4.Click
        Duyet(btn_4)
    End Sub
    Private Sub btn_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_6.Click
        Duyet(btn_6)
    End Sub
    Private Sub btn_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_5.Click
        Duyet(btn_5)
    End Sub
    Private Sub btn_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_2.Click
        Duyet(btn_2)
    End Sub
    Private Sub btn_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_1.Click
        Duyet(btn_1)
    End Sub

    Private Sub btn_20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_20.Click
        Duyet(btn_20)
    End Sub

    Private Sub btn_19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_19.Click
        Duyet(btn_19)
    End Sub

    Private Sub btn_18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_18.Click
        Duyet(btn_18)
    End Sub

    Private Sub btn_17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_17.Click
        Duyet(btn_17)
    End Sub

    Private Sub btn_16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_16.Click
        Duyet(btn_16)
    End Sub

    Private Sub btn_15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_15.Click
        Duyet(btn_15)
    End Sub

    Private Sub btn_14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_14.Click
        Duyet(btn_14)
    End Sub

    Private Sub btn_13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_13.Click
        Duyet(btn_13)
    End Sub

    Private Sub btn_12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_12.Click
        Duyet(btn_12)
    End Sub

    Private Sub btn_11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_11.Click
        Duyet(btn_11)
    End Sub

    Private Sub btn_10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_10.Click
        Duyet(btn_10)
    End Sub

    Private Sub btn_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_9.Click
        Duyet(btn_9)
    End Sub

    Private Sub btn_29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_29.Click
        Duyet(btn_29)
    End Sub

    Private Sub btn_28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_28.Click
        Duyet(btn_28)
    End Sub

    Private Sub btn_27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_27.Click
        Duyet(btn_27)
    End Sub

    Private Sub btn_26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_26.Click
        Duyet(btn_26)
    End Sub

    Private Sub btn_25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_25.Click
        Duyet(btn_25)
    End Sub

    Private Sub btn_24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_24.Click
        Duyet(btn_24)
    End Sub

    Private Sub btn_23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_23.Click
        Duyet(btn_23)
    End Sub

    Private Sub btn_22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_22.Click
        Duyet(btn_22)
    End Sub

    Private Sub btn_21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_21.Click
        Duyet(btn_21)
    End Sub

End Class