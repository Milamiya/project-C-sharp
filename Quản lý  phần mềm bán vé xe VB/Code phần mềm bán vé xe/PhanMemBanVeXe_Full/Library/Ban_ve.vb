Imports System.Data.SqlClient
Public Class Ban_ve
    Private bang_tuyen_xe As DataTable
    Private bang_Thoi_diem_ngay As DataTable
    Private bang_Thoi_diem_gio As DataTable
    Private bang_Xe As DataTable
    Private bang_Thong_tin_xe As DataTable

    Private bang_dat_ve As DataTable
    Public IdChuyen As String
    Public So_cho_ngoi As String

    Private lenh As String
 
    Public Sub Update_Ve_xe()
        Doc_tuyen_xe()
        doc_bang_ve()
        Clear_Controls()
    End Sub

    Private Sub doc_bang_ve()
        lenh = "Select IdVe, TenHanhKhach, SDTHanhKhach, TenTuyen, NgayDi, Gio, So_Xe from BanVe, ChuyenXe, TuyenXe "
        lenh &= " where BanVe.IdChuyen = ChuyenXe.IdChuyen and ChuyenXe.IdTuyen = TuyenXe.IdTuyen"
        bang_dat_ve = Doc_bang(lenh)
        With Form_Main.cbo_MaSoVe
            .DataSource = bang_dat_ve
            .ValueMember = "IdVe"
            .DisplayMember = "IdVe"
        End With

        'Tao lien ket
        Form_Main.luoi_ThongTinDatVe.DataSource = bang_dat_ve

    End Sub




    Private Sub Clear_Controls()
        With Form_Main
            .cbo_TenTuyenVe.Text = ""
            .cbo_NgayVe.Text = ""
            .cbo_GioVe.Text = ""
            .cbo_XeVe.Text = ""
        End With
    End Sub

    Private Sub Doc_tuyen_xe()
        lenh = "Select Distinct ChuyenXe.IdTuyen, TenTuyen from ChuyenXe, TuyenXe where TuyenXe.IdTuyen = ChuyenXe.IdTuyen"
        bang_tuyen_xe = Doc_bang(lenh)
        With Form_Main.cbo_TenTuyenVe
            .DataSource = bang_tuyen_xe
            .DisplayMember = "TenTuyen"
            .ValueMember = "IdTuyen"
        End With
    End Sub

    Public Sub Chon_tuyen()
        If Form_Main.cbo_TenTuyenVe.SelectedIndex < 0 Then Exit Sub
        Loc_ngay_theo_tuyen(Form_Main.cbo_TenTuyenVe.SelectedValue.ToString)
    End Sub

    Private Sub Loc_ngay_theo_tuyen(ByVal IdTuyen As String)
        lenh = "Select Distinct NgayDi from ChuyenXe where IdTuyen = '" + IdTuyen + "'"
        bang_Thoi_diem_ngay = Doc_bang(lenh)
        With Form_Main.cbo_NgayVe
            .DataSource = bang_Thoi_diem_ngay
            .ValueMember = "NgayDi"
            .DisplayMember = "NgayDi"
        End With
    End Sub

    Public Sub Chon_ngay()
        If Form_Main.cbo_GioVe.Text = "" And Form_Main.cbo_XeVe.Text = "" Then
            Form_Main.cbo_NgayVe.Text = ""
        End If
        If Form_Main.cbo_NgayVe.SelectedIndex < 0 Then Exit Sub
        Loc_gio_theo_ngay(Form_Main.cbo_NgayVe.SelectedValue.ToString)
    End Sub

    Private Sub Loc_gio_theo_ngay(ByVal Ngay As String)
        lenh = "Select Gio from ChuyenXe where NgayDi = '" + Ngay + "' and IdTuyen = '" + Form_Main.cbo_TenTuyenVe.SelectedValue.ToString + "'"
        bang_Thoi_diem_gio = Doc_bang(lenh)
        With Form_Main.cbo_GioVe
            .DataSource = bang_Thoi_diem_gio
            .ValueMember = "Gio"
            .DisplayMember = "Gio"
        End With
    End Sub

    Public Sub Chon_xe()
        If Form_Main.cbo_XeVe.Text = "" Then
            Form_Main.cbo_GioVe.Text = ""
        End If
        If Form_Main.cbo_GioVe.SelectedIndex < 0 Then Exit Sub
        Loc_xe_theo_gio(Form_Main.cbo_GioVe.SelectedValue.ToString)
    End Sub

    Private Sub Loc_xe_theo_gio(ByVal Gio As String)
        lenh = "Select So_Xe from ChuyenXe where Gio = '" + Gio + "' and IdTuyen = '" + Form_Main.cbo_TenTuyenVe.SelectedValue.ToString + "' and NgayDi = '" + Form_Main.cbo_NgayVe.SelectedValue.ToString + "'"
        bang_Xe = Doc_bang(lenh)
        With Form_Main.cbo_XeVe
            .DataSource = bang_Xe
            .ValueMember = "So_Xe"
            .DisplayMember = "So_Xe"
        End With
    End Sub

    Public Sub Chon_thong_tin_xe()
        If Form_Main.cbo_GioVe.Text = "" Then
            Form_Main.cbo_XeVe.Text = ""
        End If
        If Form_Main.cbo_TenTuyenVe.Text <> "" And Form_Main.cbo_XeVe.Text <> "" And Form_Main.cbo_GioVe.Text <> "" And Form_Main.cbo_NgayVe.Text <> "" Then
            If Form_Main.cbo_XeVe.SelectedIndex < 0 Then Exit Sub
            Loc_thong_tin_theo_so_xe(Form_Main.cbo_XeVe.SelectedValue.ToString)

        End If
    End Sub

    Private Sub Loc_thong_tin_theo_so_xe(ByVal So_Xe As String)
        lenh = "Select * From Xe where So_Xe = '" + So_Xe + "'"
        bang_Thong_tin_xe = Doc_bang(lenh)
        Form_Main.luoi_XeVe.DataSource = bang_Thong_tin_xe
    End Sub

    'Xu ly nut chon cho ngoi
    Public Sub Chon_cho_ngoi()
        With Form_Main
            If Kiem_tra_thong_tin_dat_ve() Then
                lenh = "Select So_Cho_Ngoi From Xe where So_Xe = '" + .cbo_XeVe.SelectedValue.ToString + "'"
                bang_Thong_tin_xe = Doc_bang(lenh)
                So_cho_ngoi = bang_Thong_tin_xe.Rows(0)("So_Cho_Ngoi").ToString

                If CInt(So_cho_ngoi) = 7 Then
                    Dim frm_xe_7 As New Form_Xe_7_Cho()
                    frm_xe_7.Show()
                End If

                If CInt(So_cho_ngoi) = 16 Then
                    Dim frm_xe_16 As New Form_Xe_16_Cho()
                    frm_xe_16.Show()
                End If

                If CInt(So_cho_ngoi) = 25 Then
                    Dim frm_xe_25 As New Form_Xe_25_Cho()
                    frm_xe_25.Show()
                End If

                If CInt(So_cho_ngoi) = 30 Then
                    Dim frm_xe_30 As New Form_Xe_30_Cho()
                    frm_xe_30.Show()
                End If

                If CInt(So_cho_ngoi) = 45 Then
                    Dim frm_xe_45 As New Form_Xe_45_Cho()
                    frm_xe_45.Show()
                End If

            End If
        End With

    End Sub

    Private Function Kiem_tra_thong_tin_dat_ve() As Boolean
        Kiem_tra_thong_tin_dat_ve = True
        With Form_Main
            If .cbo_TenTuyenVe.Text = "" OrElse .cbo_NgayVe.Text = "" OrElse .cbo_GioVe.Text = "" OrElse .cbo_XeVe.Text = "" _
             OrElse .txt_TenHanhKhach.Text = "" OrElse .txt_SoDTHanhKhach.Text = "" Then
                Kiem_tra_thong_tin_dat_ve = False
                MessageBox.Show("Phải nhập đầy đủ thông tin đặt vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If

            If .txt_SoDTHanhKhach.Text.Length > 12 OrElse .txt_SoDTHanhKhach.Text.Length < 9 Then
                Kiem_tra_thong_tin_dat_ve = False
                MessageBox.Show("So điện thoại từ 9 đến 12 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
        End With
    End Function
End Class
