Imports System.Data.SqlClient
Public Class Form_ChiTietTuyen
    Private bang_thoi_diem As DataTable
    Private bang_Tuyen_xe As DataTable
    Private lenh As String
    Private vi_tri_hien_hanh As Integer
    Private flag As Boolean = True
    Private bang_danh_sach As DataTable

    Private Sub Form_ChiTietTuyen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Update_ChiTietTuyen()
    End Sub

    Private Sub cbo_MaSoTuyen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_MaSoTuyen.SelectedIndexChanged
        If cbo_MaSoTuyen.SelectedIndex < 0 Then Exit Sub
        Loc_Thoi_diem_theo_IdTuyen(cbo_MaSoTuyen.SelectedValue.ToString)
    End Sub

    Public Sub Update_ChiTietTuyen()
        Doc_Thoi_diem()
        Doc_tuyen_xe()
        vi_tri_hien_hanh = 0
    End Sub

#Region "Doc thoi diem, doc tuyen xe da xong"
    Private Sub Doc_Thoi_diem()
        luoi_Thoi_diem.ClearSelection()
        lenh = "Select IdTuyen, ThoiDiem.IdThoiDiem , Ngay, Gio from ThoiDiem, ChiTietTuyen where ChiTietTuyen.IdThoiDiem = ThoiDiem.IdThoiDiem "
        bang_thoi_diem = Doc_bang(lenh)
        luoi_Thoi_diem.DataSource = bang_thoi_diem
    End Sub

    Private Sub Doc_tuyen_xe()
        lenh = "Select IdTuyen, TenTuyen from TuyenXe"
        bang_Tuyen_xe = Doc_bang(lenh)

        With cbo_MaSoTuyen
            .DataSource = bang_Tuyen_xe
            .DisplayMember = "IdTuyen"
            .ValueMember = "IdTuyen"
        End With
        cbo_MaSoTuyen1.Text = cbo_MaSoTuyen.Text
        Xoa_lien_ket()
        Tao_lien_ket()
    End Sub
#End Region

#Region "Tao lien ket voi xoa lien ket da xong"
    Private Sub Tao_lien_ket()
        cbo_MaSoTuyen1.DataBindings.Add("Text", bang_thoi_diem, "IdTuyen")
        cbo_TenTuyen.DataBindings.Add("text", bang_Tuyen_xe, "TenTuyen")
        cbo_MaThoiDiem.DataBindings.Add("text", bang_thoi_diem, "IdThoiDiem")
        date_Chay.DataBindings.Add("text", bang_thoi_diem, "Ngay")
        txt_GioChay.DataBindings.Add("text", bang_thoi_diem, "Gio")
    End Sub

    Private Sub Xoa_lien_ket()
        cbo_MaSoTuyen1.DataBindings.Clear()
        cbo_TenTuyen.DataBindings.Clear()
        cbo_MaThoiDiem.DataBindings.Clear()
        date_Chay.DataBindings.Clear()
        txt_GioChay.DataBindings.Clear()
    End Sub
#End Region

#Region "Loc danh sach thoi diem da xong"
    Public Sub Loc_Thoi_diem_theo_IdTuyen(ByVal pMa_so_tuyen As String)
        Dim dieu_kien As String = "IdTuyen = '" + pMa_so_tuyen + "'"
        bang_thoi_diem.DefaultView.RowFilter = dieu_kien
    End Sub
#End Region

#Region "Xy ly button hien, loc danh sach da xong"
    Private Sub btn_HienDanhSach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HienDanhSach.Click
        If flag Then
            luoi_Thoi_diem.ClearSelection()
            lenh = "Select ChiTietTuyen.IdTuyen, TenTuyen , ThoiDiem.IdThoiDiem , Ngay, Gio from ThoiDiem, ChiTietTuyen, TuyenXe "
            lenh &= " where ChiTietTuyen.IdThoiDiem = ThoiDiem.IdThoiDiem and TuyenXe.IdTuyen = ChiTietTuyen.IdTuyen"
            bang_danh_sach = Doc_bang(lenh)
            luoi_Thoi_diem.DataSource = bang_danh_sach
            With cbo_MaSoTuyen
                .DataSource = bang_danh_sach
                .DisplayMember = "IdTuyen"
                .ValueMember = "IdTuyen"
            End With
            cbo_MaSoTuyen1.DataBindings.Clear()
            cbo_TenTuyen.DataBindings.Clear()
            cbo_MaThoiDiem.DataBindings.Clear()
            date_Chay.DataBindings.Clear()
            txt_GioChay.DataBindings.Clear()

            cbo_MaSoTuyen1.DataBindings.Add("Text", bang_danh_sach, "IdTuyen")
            cbo_TenTuyen.DataBindings.Add("text", bang_danh_sach, "TenTuyen")
            cbo_MaThoiDiem.DataBindings.Add("text", bang_danh_sach, "IdThoiDiem")
            date_Chay.DataBindings.Add("text", bang_danh_sach, "Ngay")
            txt_GioChay.DataBindings.Add("text", bang_danh_sach, "Gio")
            btn_HienDanhSach.Text = "Lọc danh sách tuyến"
            flag = False
        Else
            Update_ChiTietTuyen()
            btn_HienDanhSach.Text = "Hiện tất cả danh sách"
            flag = True
        End If
    End Sub
#End Region

    Private Sub btn_thoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_thoat.Click
        Me.Close()
    End Sub

    Private Sub btn_Xoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Xoa.Click
        If cbo_MaSoTuyen.Text = "" OrElse cbo_MaThoiDiem.Text = "" Then
            MessageBox.Show("Bạn chưa chọn Mã số tuyến và thời điểm cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim qs = MessageBox.Show("Bạn chắc chắn muốn xóa tất cả thông tin về:" & vbNewLine & _
                        " - Ma số tuyến: " & cbo_MaSoTuyen.Text & vbNewLine & _
                        " - Mã thời điểm: " & cbo_MaThoiDiem.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If qs = DialogResult.Yes Then
            Dim lenh1 As String = "Select IdTuyen, NgayDi, Gio from ChuyenXe"
            Dim dr As SqlDataReader
            Dim com As New SqlCommand(lenh1, connect)
            connect.Open()
            dr = com.ExecuteReader
            While dr.Read = True
                'MessageBox.Show(dr.GetValue(0).ToString & dr.GetValue(1).ToString & dr.GetValue(2).ToString)
                If dr.GetValue(0).ToString = cbo_MaSoTuyen.Text And FormatDateTime(CDate(dr.GetValue(1).ToString), DateFormat.ShortDate) = date_Chay.Text And dr.GetValue(2).ToString = txt_GioChay.Text Then
                    MessageBox.Show("Thoi diem nay da duoc gan cho chuyen xe, bạn phai xoa chuyen đó trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    connect.Close()
                    Exit Sub
                End If
            End While
            connect.Close()
            lenh = "Delete from ChiTietTuyen where IdThoiDiem = '" + cbo_MaThoiDiem.Text + "'"
            Dim query1 As New SqlCommand(lenh, connect)
            Try
                connect.Open()
                query1.ExecuteNonQuery()
                connect.Close()
                Update_ChiTietTuyen()
                MsgBox("Dữ liệu đã xóa thành công", vbInformation, "Thông báo")
            Catch ex As Exception
                MsgBox("Xóa dữ liệu không thành công!", vbExclamation, "Thông báo")
            End Try
        Else
            MsgBox("Đã hủy thao tác xóa!", vbExclamation, "Thông báo")
        End If
    End Sub

End Class