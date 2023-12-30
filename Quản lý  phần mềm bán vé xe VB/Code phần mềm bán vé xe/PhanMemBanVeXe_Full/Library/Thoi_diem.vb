Imports System.Data.SqlClient
Public Class Thoi_diem
    Private bang_thoi_diem As DataTable
    Private bang_tuyen_xe As DataTable
    Private lenh As String
    Private flag As Boolean

    Public Sub Update_thoi_diem()
        Doc_thoi_diem()
        Tao_lien_ket()
        Doc_tuyen()
        Hide()
    End Sub

    Private Sub Hide()
        Form_Main.rad_KhongLap.Hide()
        Form_Main.rad_LapTuan.Hide()
        Form_Main.lbl_Lap.Hide()
        Form_Main.date_NgayKetThuc.Hide()
    End Sub

    Private Sub Show()
        Form_Main.rad_KhongLap.Show()
        Form_Main.rad_LapTuan.Show()
    End Sub

    Private Sub Doc_tuyen()
        lenh = "Select IdTuyen, TenTuyen from TuyenXe"
        bang_tuyen_xe = Doc_bang(lenh)
        With Form_Main.cbo_GanTuyen
            .DataSource = bang_tuyen_xe
            .DisplayMember = "IdTuyen"
            .ValueMember = "IdTuyen"
        End With
        With Form_Main
            .txt_TenTuyen.DataBindings.Clear()
            .txt_TenTuyen.DataBindings.Add("Text", bang_tuyen_xe, "TenTuyen")
        End With
    End Sub

#Region "Doc thoi diem voi tao lien ket da xong"
    Private Sub Doc_thoi_diem()
        lenh = "Select * from ThoiDiem"
        bang_thoi_diem = Doc_bang(lenh)
        Form_Main.luoi_ThoiDiem.DataSource = bang_thoi_diem
    End Sub

    Private Sub Tao_lien_ket()
        With Form_Main.cbo_MaThoiDiem
            .DataSource = bang_thoi_diem
            .DisplayMember = "IdThoiDiem"
            .ValueMember = "IdThoiDiem"
        End With
        With Form_Main
            .date_Chay.DataBindings.Clear()
            .txt_GioChay.DataBindings.Clear()

            .date_Chay.DataBindings.Add("Text", bang_thoi_diem, "Ngay")
            .txt_GioChay.DataBindings.Add("Text", bang_thoi_diem, "Gio")
        End With
    End Sub
#End Region

#Region "Xu ly ho tro button da xong"
    Private Sub Clear_Control()
        With Form_Main
            .date_Chay.Text = ""
            .date_NgayKetThuc.Text = ""
            .txt_GioChay.Text = ""
            .rad_KhongLap.Checked = True
            .date_Chay.Focus()
        End With
    End Sub

    Private Sub LockButton(ByVal dt As Boolean)
        With Form_Main
            .btn_ThemThoiDiem.Enabled = Not dt
            .btn_SuaThoiDiem.Enabled = Not dt
            .btn_XoaThoiDiem.Enabled = Not dt
            .btn_LuuThoiDiem.Enabled = dt
            .btn_HuyThoiDiem.Enabled = dt
        End With
    End Sub
#End Region

    Public Sub them()
        flag = True
        LockButton(True)
        Form_Main.lbl_Lap.Hide()
        Form_Main.date_NgayKetThuc.Hide()
        Show()
        Clear_Control()
        Form_Main.cbo_MaThoiDiem.Enabled = False
    End Sub

    Public Sub Sua()
        Form_Main.rad_LapTuan.Checked = False
        Form_Main.rad_KhongLap.Checked = True
        Show()
        flag = False
        LockButton(True)
        Form_Main.cbo_MaThoiDiem.Enabled = False
    End Sub

    Public Sub Luu()
        Tao_ket_noi()
        If connect.State = ConnectionState.Open Then
            connect.Close()
        End If
        With Form_Main
            'Neu nhu trang thai dang la them
            If flag Then
                If TestInfo() Then

                    'Kiem tra ngay gio them vao phai la chua co trong CSDL
                    Dim sqlCM As New SqlCommand("select Ngay, Gio from ThoiDiem", connect)
                    Dim sqlDR As SqlDataReader
                    connect.Open()
                    sqlDR = sqlCM.ExecuteReader
                    While sqlDR.Read() = True
                        If FormatDateTime(CDate(sqlDR.GetValue(0)), DateFormat.ShortDate) = .date_Chay.Text AndAlso sqlDR.GetValue(1).ToString = .txt_GioChay.Text Then
                            MessageBox.Show("Ngày giờ này đã tồn tại, vui lòng kiểm tra lại thông tin nhập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    End While
                    connect.Close()

                    If .rad_KhongLap.Checked = True Then
                        lenh = "Insert into ThoiDiem(Ngay, Gio) "
                        lenh &= "Values ('" + FormatDateTime(CDate(.date_Chay.Text), DateFormat.ShortDate) + "', '" + .txt_GioChay.Text + "')"
                        Dim bo_lenh As New SqlCommand(lenh, connect)
                        Try
                            connect.Open()
                            bo_lenh.ExecuteNonQuery()
                            connect.Close()
                            Update_thoi_diem()
                            LockButton(False)
                            MsgBox("Đã cập nhật dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
                        Catch ex As Exception
                            MessageBox.Show("Không cập nhật được dữ liệu.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            connect.Close()
                        End Try
                    ElseIf .rad_LapTuan.Checked = True Then
                        Dim i As Long = layKhoangCach()
                        If i < 0 Then
                            MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                        If i = 0 Then 'Ngay them trung ngay hien tai
                            lenh = "Insert into ThoiDiem(Ngay, Gio) "
                            lenh &= "Values ('" + FormatDateTime(CDate(.date_Chay.Text), DateFormat.ShortDate) + "', '" + .txt_GioChay.Text + "')"
                            Dim bo_lenh As New SqlCommand(lenh, connect)
                            Try
                                connect.Open()
                                bo_lenh.ExecuteNonQuery()
                                connect.Close()
                                Update_thoi_diem()
                                LockButton(False)
                                MsgBox("Đã cập nhật dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
                            Catch ex As Exception
                                MessageBox.Show("Không cập nhật được dữ liệu.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                connect.Close()
                            End Try
                        ElseIf i > 0 Then
                            Dim ngay = 0
                            Dim d = CDate(.date_Chay.Text)
                            While (ngay <= i)
                                lenh = "Insert into ThoiDiem(Ngay, Gio) "
                                lenh &= "Values ('" + FormatDateTime(d, DateFormat.ShortDate) + "', '" + .txt_GioChay.Text + "')"
                                Dim bo_lenh As New SqlCommand(lenh, connect)
                                Try
                                    connect.Open()
                                    bo_lenh.ExecuteNonQuery()
                                    connect.Close()
                                Catch ex As Exception
                                    MessageBox.Show("Không cập nhật được dữ liệu.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    connect.Close()
                                    Exit Sub
                                End Try
                                ngay += 7
                                d = DateAdd(DateInterval.Day, ngay, d)
                            End While
                            Update_thoi_diem()
                            LockButton(False)
                            MsgBox("Đã cập nhật dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
                        End If
                    End If
                End If
            Else 'trang thai sua
                If TestInfo() Then
                    lenh = "Update ThoiDiem set Ngay = '" + FormatDateTime(CDate(.date_Chay.Text), DateFormat.ShortDate) + "', Gio = '" + .txt_GioChay.Text + "' where IdThoiDiem = '" + .cbo_MaThoiDiem.Text + "'"
                    Dim sqlqr As New SqlCommand(lenh, connect)
                    Try
                        connect.Open()
                        sqlqr.ExecuteNonQuery()
                        connect.Close()
                        Update_thoi_diem()
                        LockButton(False)
                        MsgBox("Đã cập nhật dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
                    Catch ex As Exception
                        MessageBox.Show("Không cập nhật được dữ liệu.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        connect.Close()
                    End Try
                End If
            End If
        End With
    End Sub

    Public Sub Huy()
        LockButton(False)
        Update_thoi_diem()
        Form_Main.cbo_MaThoiDiem.Enabled = True
        Hide()
    End Sub

    Public Sub Xoa()
        Dim qs = MessageBox.Show("Bạn chắc chắn muốn xóa tất cả thông tin về:" & vbNewLine & _
                        " - Ma thoi diem: " & Form_Main.cbo_MaThoiDiem.Text & vbNewLine & _
                        " - Ngay: " & Form_Main.date_Chay.Text & vbNewLine & _
                        " - Giờ: " & Form_Main.txt_GioChay.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If qs = DialogResult.Yes Then
            Dim lenh As String = "Delete from ThoiDiem where IdThoiDiem = '" & Form_Main.cbo_MaThoiDiem.Text & "'"
            Dim query1 As New SqlCommand(lenh, connect)
            Try
                connect.Open()
                query1.ExecuteNonQuery()
                connect.Close()
                Update_thoi_diem()
                MsgBox("Dữ liệu đã xóa thành công", vbInformation, "Thông báo")
            Catch ex As Exception
                MsgBox("Thời điểm này đã được gán cho tuyến xe, bạn phải xóa thông tin tuyến xe đó trước!", vbExclamation, "Thông báo")
            End Try
        Else
            MsgBox("Đã hủy thao tác xóa!", vbExclamation, "Thông báo")
        End If
    End Sub

    Private Function layKhoangCach() As Long
        Dim i As Long
        i = DateAndTime.DateDiff(DateInterval.Day, CDate(Form_Main.date_Chay.Text), CDate(Form_Main.date_NgayKetThuc.Text), FirstDayOfWeek.System, FirstWeekOfYear.System)
        Return i
    End Function

    Private Function TestInfo() As Boolean
        TestInfo = True
        With Form_Main
            If .rad_KhongLap.Checked = True Then
                If Trim(.date_Chay.Text) = "" OrElse Trim(.txt_GioChay.Text) = "" Then
                    TestInfo = False
                    MsgBox("Bạn phải nhập đầy đủ thông tin!", MsgBoxStyle.Exclamation, "Thông báo lỗi")
                    Exit Function
                End If
            ElseIf .rad_LapTuan.Checked = True Then
                If Trim(.date_Chay.Text) = "" OrElse Trim(.txt_GioChay.Text) = "" OrElse .date_NgayKetThuc.Text = "" Then
                    TestInfo = False
                    MsgBox("Bạn phải nhập đầy đủ thông tin!", MsgBoxStyle.Exclamation, "Thông báo lỗi")
                    Exit Function
                End If

                If .date_Chay.Text <> "" AndAlso .date_NgayKetThuc.Text <> "" Then
                    If layKhoangCach() > 365 Then
                        TestInfo = False
                        MessageBox.Show("Bạn chỉ được lặp tuần trong phạm vi là 1 năm hay 48 tuần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Exit Function
                    End If
                End If
            End If

            If CDate(Form_Main.date_Chay.Text) < Today.Date Then
                TestInfo = False
                MessageBox.Show("Ngay ban them khong duoc nho hon ngay hien tai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Function
            End If
        End With
    End Function

    Public Sub Gan_tuyen()
        With Form_Main
            If .cbo_MaThoiDiem.Text = "" Then
                MessageBox.Show("Bạn chưa chọn thời điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            'Neu ngay gio do da gan cho tuyen do roi thi thong bao loi
            Dim sqlCM As New SqlCommand("select * from ChiTietTuyen", connect)
            Dim sqlDR As SqlDataReader
            connect.Open()
            sqlDR = sqlCM.ExecuteReader
            While sqlDR.Read() = True
                If sqlDR.GetValue(0).ToString = .cbo_GanTuyen.Text AndAlso sqlDR.GetValue(1).ToString = .cbo_MaThoiDiem.Text Then
                    MessageBox.Show("Thời điểm này đã được gán cho tuyến " & .cbo_GanTuyen.Text & " rồi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    connect.Close()
                    Exit Sub
                End If
            End While
            connect.Close()

            'Sau khi kiem tra logic thi bat dau gan tuyen
            lenh = "Insert into ChiTietTuyen values('" & .cbo_GanTuyen.Text & "', '" & .cbo_MaThoiDiem.Text & "')"
            Dim bo_lenh As New SqlCommand(lenh, connect)
            Try
                connect.Open()
                bo_lenh.ExecuteNonQuery()
                connect.Close()
                MsgBox("Ngày " & .date_Chay.Text & " Giờ: " & .txt_GioChay.Text & " đã được gán cho tuyến " & .cbo_GanTuyen.Text, vbInformation, "Thông báo")
                Update_thoi_diem()
            Catch ex As Exception
                MsgBox("Gán tuyến không thành công", vbExclamation, "Thông báo")
            End Try
        End With
    End Sub
End Class
