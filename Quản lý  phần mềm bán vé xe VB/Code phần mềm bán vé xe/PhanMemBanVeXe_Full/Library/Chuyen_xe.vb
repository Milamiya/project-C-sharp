Imports System.Data.SqlClient
Public Class Chuyen_xe
    Private Ban_ve As New Ban_ve
    Private bang_chuyen_xe As DataTable
    Private bang_tuyen_xe As DataTable
    Private bang_Chi_tiet_tuyen As DataTable
    Private bang_Thoi_diem As DataTable
    Private bang_xe As DataTable

    Private lenh As String
    Private flag As Boolean
    Private vi_tri_hien_hanh As Integer = 0


    Public Sub Update_Chuyen_xe()
        Doc_chuyen_xe()
        Tao_lien_ket()
        Lock_Control(False)
        vi_tri_hien_hanh = 0
        Xuat_thong_tin_Chuyen_xe()
    End Sub

    Private Sub Doc_chuyen_xe()
        Form_Main.Luoi_Chuyen_xe.ClearSelection()
        lenh = "Select * from ChuyenXe"
        bang_chuyen_xe = Doc_bang(lenh)
        Form_Main.Luoi_Chuyen_xe.DataSource = bang_chuyen_xe
    End Sub

    Private Sub Tao_lien_ket()
        If bang_chuyen_xe.Rows.Count <> 0 Then
            With Form_Main.cbo_IdChuyen
                .DataSource = bang_chuyen_xe
                .DisplayMember = "IdChuyen"
                .ValueMember = "IdChuyen"
            End With
            Xoa_lien_ket()
            Form_Main.cbo_IdChuyen.Text = Form_Main.Luoi_Chuyen_xe.Rows(0).Cells.Item(0).Value.ToString

            With Form_Main
                .cbo_IdTuyenChuyen.DataBindings.Add("Text", .Luoi_Chuyen_xe.DataSource, "IdTuyen")
                .cbo_SoXeChuyen.DataBindings.Add("Text", .Luoi_Chuyen_xe.DataSource, "So_Xe")
                .cbo_NgayDiChuyen.DataBindings.Add("Text", .Luoi_Chuyen_xe.DataSource, "NgayDi")
                .cbo_GioDiChuyen.DataBindings.Add("Text", .Luoi_Chuyen_xe.DataSource, "Gio")
            End With
        End If
    End Sub

    Private Sub Xoa_lien_ket()
        With Form_Main
            .cbo_IdTuyenChuyen.DataBindings.Clear()
            .cbo_SoXeChuyen.DataBindings.Clear()
            .cbo_NgayDiChuyen.DataBindings.Clear()
            .cbo_GioDiChuyen.DataBindings.Clear()
        End With
    End Sub

    Private Sub Lock_Control(ByVal f As Boolean)
        With Form_Main
            .cbo_IdChuyen.Enabled = Not f
            .cbo_IdTuyenChuyen.Enabled = f
            .cbo_SoXeChuyen.Enabled = f
            .cbo_NgayDiChuyen.Enabled = f
            .cbo_GioDiChuyen.Enabled = f
            .Luoi_Chuyen_xe.Enabled = Not f
        End With
    End Sub

    Private Sub Clear_Control()
        With Form_Main
            .cbo_IdChuyen.Text = ""
            .cbo_IdTuyenChuyen.Text = ""
            .cbo_NgayDiChuyen.Text = ""
            .cbo_GioDiChuyen.Text = ""
            .txt_SoDienThoai.Text = ""
            .cbo_SoXeChuyen.Text = ""
            .cbo_IdTuyenChuyen.Focus()
        End With
    End Sub

    Private Sub LockButton(ByVal dt As Boolean)
        With Form_Main
            .btn_ThemChuyen.Enabled = Not dt
            .btn_SuaChuyen.Enabled = Not dt
            .btn_XoaChuyen.Enabled = Not dt
            .btn_LuuChuyen.Enabled = dt
            .btn_HuyChuyen.Enabled = dt
        End With
    End Sub

    Public Sub Them()
        Xoa_lien_ket()
        flag = True
        Lock_Control(True)
        LockButton(True)
        Doc_tuyen_xe()
        Doc_xe()
        Clear_Control()
    End Sub

    Public Sub Sua()
        flag = False
        Lock_Control(True)
        LockButton(True)
        Doc_tuyen_xe()
        Doc_xe()
    End Sub

    Public Sub Huy()
        Xoa_lien_ket()
        Lock_Control(False)
        LockButton(False)
        Update_Chuyen_xe()

    End Sub

    Private Sub Doc_tuyen_xe()
        lenh = "Select IdTuyen from TuyenXe"
        bang_tuyen_xe = Doc_bang(lenh)
        With Form_Main.cbo_IdTuyenChuyen
            .DataSource = bang_tuyen_xe
            .DisplayMember = "IdTuyen"
            .ValueMember = "IdTuyen"
        End With
    End Sub

    Public Sub Chon_tuyen()
        If Form_Main.cbo_IdTuyenChuyen.SelectedIndex < 0 Then Exit Sub 'Nghia la ko chọn mục nào
        Loc_Thoi_diem_theo_Tuyen(Form_Main.cbo_IdTuyenChuyen.SelectedValue.ToString)
    End Sub

    Private Sub Loc_Thoi_diem_theo_Tuyen(ByVal IdTuyen As String)
        lenh = "Select Distinct Ngay from ThoiDiem, ChiTietTuyen where IdTuyen = '" + IdTuyen + "' and ThoiDiem.IdThoiDiem = ChiTietTuyen.IdThoiDiem"
        bang_Chi_tiet_tuyen = Doc_bang(lenh)
        With Form_Main.cbo_NgayDiChuyen
            .DataSource = bang_Chi_tiet_tuyen
            .ValueMember = "Ngay"
            .DisplayMember = "Ngay"
        End With
    End Sub

    Public Sub Chon_ngay()
        If Form_Main.cbo_NgayDiChuyen.SelectedIndex < 0 Then Exit Sub 'Nghia la ko chọn mục nào
        Loc_gio_theo_ngay(Form_Main.cbo_NgayDiChuyen.SelectedValue.ToString)
    End Sub

    Private Sub Loc_gio_theo_ngay(ByVal ngay As String)
        lenh = "Select Gio from ThoiDiem where Ngay = '" + ngay + "'"
        bang_Thoi_diem = Doc_bang(lenh)
        With Form_Main.cbo_GioDiChuyen
            .DataSource = bang_Thoi_diem
            .ValueMember = "Gio"
            .DisplayMember = "Gio"
        End With
    End Sub

    Private Sub Doc_xe()
        lenh = "Select So_Xe from Xe"
        bang_xe = Doc_bang(lenh)
        With Form_Main.cbo_SoXeChuyen
            .DataSource = bang_xe
            .ValueMember = "So_Xe"
            .DisplayMember = "So_Xe"
        End With
    End Sub

    Public Sub Luu()
        If connect.State = ConnectionState.Open Then
            connect.Close()
        End If
        With Form_Main
            If flag = True Then 'Truong hop them chuyen moi
                If TestInfo() Then
                    Dim dg As DialogResult = MessageBox.Show("Ban có chắn chắc muốn thêm chuyến xe này không, " & vbNewLine _
                               , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If dg = Windows.Forms.DialogResult.Yes Then 'Neu nhan vien dong y
                        'Kiem tra xem chuyen xe do co bi trung khong
                        Dim sqlCM As New SqlCommand("select IdTuyen, NgayDi, Gio, So_Xe from ChuyenXe", connect)
                        Dim sqlDR As SqlDataReader
                        connect.Open()
                        sqlDR = sqlCM.ExecuteReader
                        While sqlDR.Read() = True
                            If sqlDR.GetValue(0).ToString = .cbo_IdTuyenChuyen.Text AndAlso FormatDateTime(CDate(sqlDR.GetValue(1)), DateFormat.ShortDate) = .cbo_NgayDiChuyen.Text AndAlso sqlDR.GetValue(2).ToString = .cbo_GioDiChuyen.Text AndAlso sqlDR.GetValue(3).ToString = .cbo_SoXeChuyen.Text Then
                                MessageBox.Show("Xe " + .cbo_SoXeChuyen.Text + " đã được gán cho tuyến " + .cbo_IdTuyenChuyen.Text + " vào thời điểm này rồi, vui lòng chọn xe khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                connect.Close()
                                Exit Sub
                            End If
                            'Kiem tra hai gio chay cua xe do trong ngay khong duoc chenh lech it nhat la quá 3 tiếng
                            If FormatDateTime(CDate(sqlDR.GetValue(1)), DateFormat.ShortDate) = .cbo_NgayDiChuyen.Text AndAlso sqlDR.GetValue(3).ToString = .cbo_SoXeChuyen.Text Then
                                'Cat chuoi gio cua chuyen da co va gio cua chuyen muon them moi
                                Dim gioDaCo As String = sqlDR.GetValue(2).ToString
                                Dim gioMuonThem As String = .cbo_GioDiChuyen.Text
                                Dim i, j As Integer
                                If gioDaCo.Length = 4 And gioMuonThem.Length = 4 AndAlso Strings.Mid(gioDaCo, 2, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 2, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 1))
                                    j = CInt(Strings.Left(gioMuonThem, 1))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 2 And gioMuonThem.Length = 2 AndAlso Strings.Mid(gioDaCo, 2, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 2, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 1))
                                    j = CInt(Strings.Left(gioMuonThem, 1))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 3 And gioMuonThem.Length = 2 AndAlso Strings.Mid(gioDaCo, 3, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 2, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 2))
                                    j = CInt(Strings.Left(gioMuonThem, 1))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 2 And gioMuonThem.Length = 3 AndAlso Strings.Mid(gioDaCo, 2, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 3, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 1))
                                    j = CInt(Strings.Left(gioMuonThem, 2))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 5 And gioMuonThem.Length = 5 AndAlso Strings.Mid(gioDaCo, 3, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 3, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 2))
                                    j = CInt(Strings.Left(gioMuonThem, 2))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 2 And gioMuonThem.Length = 5 AndAlso Strings.Mid(gioDaCo, 2, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 3, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 1))
                                    j = CInt(Strings.Left(gioMuonThem, 2))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 5 And gioMuonThem.Length = 2 AndAlso Strings.Mid(gioDaCo, 3, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 2, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 2))
                                    j = CInt(Strings.Left(gioMuonThem, 1))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 3 And gioMuonThem.Length = 5 AndAlso Strings.Mid(gioDaCo, 3, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 3, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 2))
                                    j = CInt(Strings.Left(gioMuonThem, 2))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 5 And gioMuonThem.Length = 3 AndAlso Strings.Mid(gioDaCo, 3, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 3, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 2))
                                    j = CInt(Strings.Left(gioMuonThem, 2))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 5 And gioMuonThem.Length = 4 AndAlso Strings.Mid(gioDaCo, 3, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 3, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 2))
                                    j = CInt(Strings.Left(gioMuonThem, 2))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 4 And gioMuonThem.Length = 5 AndAlso Strings.Mid(gioDaCo, 3, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 3, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 2))
                                    j = CInt(Strings.Left(gioMuonThem, 2))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If
                            End If
                            'Neu muon kiem tra gi nua thi them o day
                        End While
                        connect.Close()

                        'Bat dau insert dulieu
                        lenh = "Insert into ChuyenXe(IdTuyen, NgayDi, Gio, So_Xe)"
                        lenh &= " Values ('" + .cbo_IdTuyenChuyen.Text + "', '" + .cbo_NgayDiChuyen.Text + "', '" + .cbo_GioDiChuyen.Text + "', '" + .cbo_SoXeChuyen.Text + "')"
                        Dim bo_lenh As New SqlCommand(lenh, connect)
                        connect.Open()
                        Try
                            bo_lenh.ExecuteNonQuery()
                            connect.Close()
                            Update_Chuyen_xe()
                            Lock_Control(False)
                            LockButton(False)
                            Form_Main.Luoi_Chuyen_xe.Enabled = True
                            MsgBox("Đã cập nhật dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
                        Catch ex As Exception
                            MessageBox.Show("Không cập nhật được dữ liệu, thêm chuyen thông thành công.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            connect.Close()
                        End Try
                    Else
                        Huy()
                    End If
                End If
            Else 'Truong hop sua thong tin chuyen
                If TestInfo() Then
                    Dim dg As DialogResult = MessageBox.Show("Ban có chắn chắc muốn sửa thông tin chuyến xe này không, " & vbNewLine _
                               , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If dg = Windows.Forms.DialogResult.Yes Then 'Neu nhan vien dong y
                        Dim sqlCM As New SqlCommand("select IdTuyen, NgayDi, Gio, So_Xe from ChuyenXe", connect)
                        Dim sqlDR As SqlDataReader
                        connect.Open()
                        sqlDR = sqlCM.ExecuteReader
                        While sqlDR.Read() = True
                            If sqlDR.GetValue(0).ToString = .cbo_IdTuyenChuyen.Text AndAlso FormatDateTime(CDate(sqlDR.GetValue(1)), DateFormat.ShortDate) = .cbo_NgayDiChuyen.Text AndAlso sqlDR.GetValue(2).ToString = .cbo_GioDiChuyen.Text AndAlso sqlDR.GetValue(3).ToString = .cbo_SoXeChuyen.Text Then
                                MessageBox.Show("Xe " + .cbo_SoXeChuyen.Text + " đã được gán cho tuyến " + .cbo_IdTuyenChuyen.Text + " vào thời điểm này rồi, vui lòng chọn xe khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                connect.Close()
                                Exit Sub
                            End If
                            'Kiem tra hai gio chay cua xe do trong ngay khong duoc chenh lech it nhat la quá 3 tiếng
                            If FormatDateTime(CDate(sqlDR.GetValue(1)), DateFormat.ShortDate) = .cbo_NgayDiChuyen.Text AndAlso sqlDR.GetValue(3).ToString = .cbo_SoXeChuyen.Text Then
                                'Cat chuoi gio cua chuyen da co va gio cua chuyen muon them moi
                                Dim gioDaCo As String = sqlDR.GetValue(2).ToString
                                Dim gioMuonThem As String = .cbo_GioDiChuyen.Text
                                Dim i, j As Integer
                                If gioDaCo.Length = 4 And gioMuonThem.Length = 4 AndAlso Strings.Mid(gioDaCo, 2, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 2, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 1))
                                    j = CInt(Strings.Left(gioMuonThem, 1))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 2 And gioMuonThem.Length = 2 AndAlso Strings.Mid(gioDaCo, 2, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 2, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 1))
                                    j = CInt(Strings.Left(gioMuonThem, 1))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 3 And gioMuonThem.Length = 2 AndAlso Strings.Mid(gioDaCo, 3, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 2, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 2))
                                    j = CInt(Strings.Left(gioMuonThem, 1))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 2 And gioMuonThem.Length = 3 AndAlso Strings.Mid(gioDaCo, 2, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 3, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 1))
                                    j = CInt(Strings.Left(gioMuonThem, 2))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 5 And gioMuonThem.Length = 5 AndAlso Strings.Mid(gioDaCo, 3, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 3, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 2))
                                    j = CInt(Strings.Left(gioMuonThem, 2))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 2 And gioMuonThem.Length = 5 AndAlso Strings.Mid(gioDaCo, 2, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 3, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 1))
                                    j = CInt(Strings.Left(gioMuonThem, 2))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 5 And gioMuonThem.Length = 2 AndAlso Strings.Mid(gioDaCo, 3, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 2, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 2))
                                    j = CInt(Strings.Left(gioMuonThem, 1))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 3 And gioMuonThem.Length = 5 AndAlso Strings.Mid(gioDaCo, 3, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 3, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 2))
                                    j = CInt(Strings.Left(gioMuonThem, 2))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 5 And gioMuonThem.Length = 3 AndAlso Strings.Mid(gioDaCo, 3, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 3, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 2))
                                    j = CInt(Strings.Left(gioMuonThem, 2))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 5 And gioMuonThem.Length = 4 AndAlso Strings.Mid(gioDaCo, 3, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 3, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 2))
                                    j = CInt(Strings.Left(gioMuonThem, 2))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If

                                If gioDaCo.Length = 4 And gioMuonThem.Length = 5 AndAlso Strings.Mid(gioDaCo, 3, 1) = "h" AndAlso Strings.Mid(gioMuonThem, 3, 1) = "h" Then
                                    i = CInt(Strings.Left(gioDaCo, 2))
                                    j = CInt(Strings.Left(gioMuonThem, 2))
                                    If i - j < 3 OrElse j - i < 3 Then
                                        MessageBox.Show("Một xe chạy trong cùng 1 ngày không được có thời gian cách nhau nhỏ hơn 3 tiếng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        connect.Close()
                                        Exit Sub
                                    End If
                                End If
                            End If
                            'Neu muon kiem tra gi nua thi them o day
                        End While
                        connect.Close()
                        Dim dr As SqlDataReader
                        Dim lenh3 As String = "Select IdChuyen from ChoNgoi"
                        Dim bo_lenh As New SqlCommand(lenh3, connect)
                        connect.Open()
                        dr = bo_lenh.ExecuteReader
                        While dr.Read = True
                            If dr.GetValue(0).ToString = .cbo_IdChuyen.Text Then
                                MessageBox.Show("Chuyến xe đã có nguoi đặt chỗ rồi, bạn không được sưa vì sẽ làm mất uy tính khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                connect.Close()
                                Exit Sub
                            End If
                        End While
                        connect.Close()
                        lenh = "Update ChuyenXe Set IdTuyen = '" + .cbo_IdTuyenChuyen.Text + "', NgayDi = '" + .cbo_NgayDiChuyen.Text + "', Gio = '" + .cbo_GioDiChuyen.Text + "', So_Xe = '" + .cbo_SoXeChuyen.Text + "' where IdChuyen = '" + .cbo_IdTuyenChuyen.Text + "'"
                        Dim sqlqr As New SqlCommand(lenh, connect)
                        Try
                            connect.Open()
                            sqlqr.ExecuteNonQuery()
                            connect.Close()
                            Update_Chuyen_xe()
                            Lock_Control(False)
                            LockButton(False)
                            Form_Main.Luoi_Chuyen_xe.Enabled = True
                            MsgBox("Đã cập nhật dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
                        Catch ex As Exception
                            MessageBox.Show("Không cập nhật được dữ liệu, sửa thông tin chuyen xe thông thành công.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            connect.Close()
                        End Try
                    Else
                        Huy()
                    End If
                End If
            End If
        End With
        Ban_ve.Update_Ve_xe()
    End Sub

    Private Function TestInfo() As Boolean
        TestInfo = True
        With Form_Main
            If Trim(.cbo_IdTuyenChuyen.Text) = "" OrElse Trim(.cbo_NgayDiChuyen.Text) = "" OrElse Trim(.cbo_GioDiChuyen.Text) = "" _
            OrElse Trim(.cbo_SoXeChuyen.Text) = "" Then
                TestInfo = False
                MsgBox("Bạn phải nhập đầy đủ thông tin!", MsgBoxStyle.Exclamation, "Thông báo lỗi")
            End If

            If Trim(.cbo_IdTuyenChuyen.Text) = "" Then
                .cbo_IdTuyenChuyen.Focus()
                Exit Function
            ElseIf Trim(.cbo_NgayDiChuyen.Text) = "" Then
                .cbo_NgayDiChuyen.Focus()
                Exit Function
            ElseIf Trim(.cbo_GioDiChuyen.Text) = "" Then
                .cbo_GioDiChuyen.Focus()
                Exit Function
            ElseIf Trim(.cbo_SoXeChuyen.Text) = "" Then
                .cbo_SoXeChuyen.Focus()
                Exit Function
            End If
        End With
    End Function

    Public Sub Xoa()
        Dim qs = MessageBox.Show("Bạn chắc chắn muốn xóa tất cả thông tin về:" & vbNewLine & _
                        " - Chuyến xe: " & Form_Main.cbo_IdChuyen.Text & vbNewLine & _
                        " - Tuyến xe: " & Form_Main.cbo_IdTuyenChuyen.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If qs = DialogResult.Yes Then
            Dim lenh As String = "Delete from ChuyenXe where IdChuyen = '" & Form_Main.cbo_IdChuyen.SelectedValue.ToString & "'"
            Dim query1 As New SqlCommand(lenh, connect)
            Try
                connect.Open()
                query1.ExecuteNonQuery()
                connect.Close()
                Update_Chuyen_xe()
                MsgBox("Dữ liệu đã xóa thành công", vbInformation, "Thông báo")
            Catch ex As Exception
                MsgBox("Không cập nhật được dữ liệu, xóa chuyến không thành công", vbExclamation, "Thông báo")
            End Try
        Else
            MsgBox("Đã hủy thao tác xóa!", vbExclamation, "Thông báo")
        End If
    End Sub

#Region "Xu ly cac nut di chuyen va xuat thong tin xe da hoan tat"
    Private Sub Xuat_thong_tin_Chuyen_xe()
        If bang_chuyen_xe.Rows.Count <> 0 Then
            Dim dong As DataRow = bang_chuyen_xe.Rows(vi_tri_hien_hanh)
            With Form_Main
                .cbo_IdChuyen.Text = dong("IdChuyen").ToString
                .cbo_IdTuyenChuyen.Text = dong("IdTuyen").ToString
                .cbo_NgayDiChuyen.Text = CStr(dong("NgayDi"))
                .cbo_GioDiChuyen.Text = dong("Gio").ToString
            End With
        End If
       
    End Sub

    Public Sub Di_chuyen_ve_sau()
        If vi_tri_hien_hanh < bang_chuyen_xe.Rows.Count - 1 Then
            vi_tri_hien_hanh += 1
            Xuat_thong_tin_Chuyen_xe()
        End If
    End Sub

    Public Sub Di_chuyen_ve_truoc()
        If vi_tri_hien_hanh > 0 Then
            vi_tri_hien_hanh -= 1
            Xuat_thong_tin_Chuyen_xe()
        End If
    End Sub

    Public Sub Di_chuyen_ve_dau()
        vi_tri_hien_hanh = 0
        Xuat_thong_tin_Chuyen_xe()
    End Sub

    Public Sub Di_chuyen_ve_cuoi()
        vi_tri_hien_hanh = bang_chuyen_xe.Rows.Count - 1
        Xuat_thong_tin_Chuyen_xe()
    End Sub
#End Region

End Class
