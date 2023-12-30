Imports System.Data
Imports System.Data.SqlClient
Class Nguoi_dung
    Private flag As Boolean
    Private bang_Nguoi_Dung As Data.DataTable
    Private vi_tri_hien_hanh As Integer

    Public Sub UpdateNguoiDung()
        If Form_Login.LoginLoaiND = "Quan_Ly" OrElse Form_Login.LoginLoaiND = "Admin" Then
            Doc_bang_Nguoi_Dung()
            vi_tri_hien_hanh = 0
            Xuat_thong_tin_Nguoi_Dung()
            Tao_lien_ket()
            Form_Main.luoi_NguoiDung.ReadOnly = True
            Lock_Control(False)
            LockButton(False)
        Else
            Doc_bang_Nguoi_Dung()
            vi_tri_hien_hanh = 0
            Xuat_thong_tin_Nguoi_Dung()
            Tao_lien_ket()
            Form_Main.luoi_NguoiDung.ReadOnly = True
            Form_Main.Button_Them.Enabled = False
            Form_Main.Button_Sua.Enabled = False
            Form_Main.Button_Xoa.Enabled = False
            Form_Main.Button_CapPass.Enabled = False
            Form_Main.Button_PhanQuyen.Text = "Xem Quyền"
        End If
    End Sub

#Region "Xu ly doc bang nguoi dung va phan loai nguoi dung de hien thi da hoan tat"
    Private Sub Doc_bang_Nguoi_Dung()
        'Lam sach luoi sau moi lan cap nhat
        Form_Main.luoi_NguoiDung.ClearSelection()
        Dim lenh As String
        If Form_Login.LoginLoaiND = "Quan_Ly" Then
            lenh = "Select * from NguoiDung where IdLoaiND = 'Nhan_Vien' or IdNguoiDung = '" & Form_Login.LoginTenND & "'"
        ElseIf Form_Login.LoginLoaiND = "Nhan_Vien" Then
            lenh = "Select * from NguoiDung where IdNguoiDung = '" & Form_Login.txtUserName.Text & "'"
        Else
            lenh = "Select * from NguoiDung"
        End If
        bang_Nguoi_Dung = Doc_bang(lenh)
        Form_Main.luoi_NguoiDung.DataSource = bang_Nguoi_Dung
    End Sub
#End Region

#Region "Xu ly cac nut di chuyen va xuat thong tin nguoi dung da hoan tat"
    Private Sub Xuat_thong_tin_Nguoi_Dung()
        Dim dong As DataRow = bang_Nguoi_Dung.Rows(vi_tri_hien_hanh)
        With Form_Main
            .cbo_Username.Text = dong("IdNguoiDung").ToString
            .txt_Password.Text = dong("PassND").ToString
            .txt_HoTen.Text = CStr(dong("HoTen"))
            .date_NgaySinh.Text = CStr(dong("NgaySinh"))
            If dong("GioiTinh").ToString = "Nam" Then
                .radNam.Checked = True
            Else
                .radNu.Checked = True
            End If
            .txt_DiaChi.Text = dong("DiaChi").ToString
            .txt_SoDienThoai.Text = dong("SoDT").ToString
            .cbo_IdLoaiND.Text = dong("IdLoaiND").ToString
        End With
    End Sub

    Public Sub Di_chuyen_ve_sau()
        If vi_tri_hien_hanh < bang_Nguoi_Dung.Rows.Count - 1 Then
            vi_tri_hien_hanh += 1
            Xuat_thong_tin_Nguoi_Dung()
        End If
    End Sub

    Public Sub Di_chuyen_ve_truoc()
        If vi_tri_hien_hanh > 0 Then
            vi_tri_hien_hanh -= 1
            Xuat_thong_tin_Nguoi_Dung()
        End If
    End Sub

    Public Sub Di_chuyen_ve_dau()
        vi_tri_hien_hanh = 0
        Xuat_thong_tin_Nguoi_Dung()
    End Sub

    Public Sub Di_chuyen_ve_cuoi()
        vi_tri_hien_hanh = bang_Nguoi_Dung.Rows.Count - 1
        Xuat_thong_tin_Nguoi_Dung()
    End Sub
#End Region

#Region "Tao lien ket giua cac dieu khien voi datagridview da hoan tat"
    Private Sub Tao_lien_ket()
        Dim query As New SqlCommand("select IdLoaiND from LoaiNguoiDung", connect)
        Dim dr As SqlDataReader
        connect.Open()
        dr = query.ExecuteReader
        Form_Main.cbo_IdLoaiND.Items.Clear()
        While dr.Read() = True
            If Form_Login.LoginLoaiND = "Admin" Then
                Form_Main.cbo_IdLoaiND.Items.Add(dr.GetValue(0).ToString)
            ElseIf Form_Login.LoginLoaiND = "Quan_Ly" Then
                If dr.GetValue(0).ToString <> "Admin" Then
                    Form_Main.cbo_IdLoaiND.Items.Add(dr.GetValue(0).ToString)
                End If
            Else
                If dr.GetValue(0).ToString <> "Admin" AndAlso dr.GetValue(0).ToString <> "Quan_Ly" Then
                    Form_Main.cbo_IdLoaiND.Items.Add(dr.GetValue(0).ToString)
                End If
            End If
        End While
        connect.Close()
        With Form_Main.cbo_Username
            .DataSource = Form_Main.luoi_NguoiDung.DataSource
            .DisplayMember = "IdNguoiDung"
            .ValueMember = "IdNguoiDung"
            .SelectedValue = "IdNguoiDung"
        End With
        Xoa_lien_ket()
        'Tao gia tri mac dinh la IdNguoiDung dong thu 0 cot 0 luc khoi dong vi IdNguoiDung la member ko lien ket duoc
        Form_Main.cbo_Username.Text = Form_Main.luoi_NguoiDung.Rows(0).Cells.Item(0).Value.ToString
        Form_Main.txt_Password.DataBindings.Add("text", Form_Main.luoi_NguoiDung.DataSource, "PassND")
        Form_Main.txt_DiaChi.DataBindings.Add("text", Form_Main.luoi_NguoiDung.DataSource, "DiaChi")
        Form_Main.txt_HoTen.DataBindings.Add("text", Form_Main.luoi_NguoiDung.DataSource, "HoTen")
        Form_Main.txt_SoDienThoai.DataBindings.Add("text", Form_Main.luoi_NguoiDung.DataSource, "SoDT")
        Form_Main.date_NgaySinh.DataBindings.Add("text", Form_Main.luoi_NguoiDung.DataSource, "NgaySinh")
        Form_Main.cbo_IdLoaiND.DataBindings.Add("text", Form_Main.luoi_NguoiDung.DataSource, "IdLoaiND")
    End Sub
#End Region

#Region "Xoa lien ket giua cac dieu khien voi datagridview da hoan tat"
    Private Sub Xoa_lien_ket()
        Form_Main.txt_Password.DataBindings.Clear()
        Form_Main.txt_DiaChi.DataBindings.Clear()
        Form_Main.txt_HoTen.DataBindings.Clear()
        Form_Main.txt_SoDienThoai.DataBindings.Clear()
        Form_Main.cbo_IdLoaiND.DataBindings.Clear()
        Form_Main.date_NgaySinh.DataBindings.Clear()
    End Sub
#End Region

#Region "Them va sua thong tin nguoi dung da ly ly xong"
    Public Sub Them_nguoi_dung()
        flag = True
        Lock_Control(True)
        LockButton(True)
        Clear_Control()
        Form_Main.luoi_NguoiDung.ReadOnly = False
    End Sub

    Public Sub Sua_thong_tin_ca_nhan()
        flag = False
        Lock_Control(True)
        LockButton(True)
        Form_Main.cbo_Username.Focus()
        Form_Main.cbo_Username.Text = Form_Login.LoginTenND
        Form_Main.cbo_Username.Enabled = False
        Form_Main.luoi_NguoiDung.ReadOnly = False
        Form_Main.cbo_IdLoaiND.Enabled = False
    End Sub

    Public Sub Luu_thay_doi()
        Tao_ket_noi()
        If connect.State = ConnectionState.Open Then
            connect.Close()
        End If
        With Form_Main
            If flag = True Then 'Them nguoi dung moi
                If TestInfo() Then
                    Dim dg As DialogResult = MessageBox.Show("Ban có chắn chắc muốn thêm người dùng này không, " & vbNewLine & _
                                "Click OK đê đồng ý, Cancel để hủy.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If dg = Windows.Forms.DialogResult.OK Then
                        Dim flag As Integer = 0
                        Dim sqlCM As New SqlCommand("select IdNguoiDung from NguoiDung ", connect)
                        Dim sqlDR As SqlDataReader
                        connect.Open()
                        sqlDR = sqlCM.ExecuteReader
                        While sqlDR.Read() = True
                            If sqlDR.GetValue(0).ToString = .cbo_Username.Text Then
                                flag = 1
                                MsgBox("Tài khoản " + .cbo_Username.Text + " đã được sử dụng !", MsgBoxStyle.OkOnly, "Thông Báo")
                            End If
                        End While
                        connect.Close()

                        If flag = 0 Then
                            Dim sqlqr As New SqlCommand
                            sqlqr.Connection = connect
                            If .radNam.Checked = True Then
                                sqlqr.CommandText = "insert into NguoiDung values('" + .cbo_Username.Text + "','" + .txt_Password.Text + "',N'" + .txt_HoTen.Text + "','" + Format(.date_NgaySinh.Value, "yyyy/MM/dd") + "',N'Nam',N'" + .txt_DiaChi.Text + "'," + .txt_SoDienThoai.Text + ",'" + .cbo_IdLoaiND.Text + "')"
                            Else
                                sqlqr.CommandText = "insert into NguoiDung values('" + .cbo_Username.Text + "','" + .txt_Password.Text + "',N'" + .txt_HoTen.Text + "','" + Format(.date_NgaySinh.Value, "yyyy/MM/dd") + "',N'Nữ',N'" + .txt_DiaChi.Text + "'," + .txt_SoDienThoai.Text + ",'" + .cbo_IdLoaiND.Text + "')"
                            End If

                            connect.Open()
                            Try
                                sqlqr.ExecuteNonQuery()
                                connect.Close()
                                Doc_bang_Nguoi_Dung()
                                vi_tri_hien_hanh = 0
                                Xuat_thong_tin_Nguoi_Dung()
                                Tao_lien_ket()
                                MsgBox("Đã cập nhật dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
                            Catch ex As Exception
                                MsgBox("Một số kí tự trong ô 'Họ Tên' và 'Địa Chỉ' không phù hợp" & vbNewLine & "Các kí có thể nhập là 0 - 9, 26 chữ cái, '_', các dấu trong tiếng việt và một số kí tự khác", MsgBoxStyle.Exclamation, "Thông báo lỗi")
                                connect.Close()
                            End Try
                        End If
                    Else
                        Huy_thao_tac()
                    End If
                
                End If
            Else 'Sua thong tin nguoi dung
                If TestInfo() Then
                    If Form_Main.cbo_Username.Text <> Form_Login.LoginTenND Then
                        Dim dg As DialogResult = MessageBox.Show("Ban chỉ có quyền sưa thông tin cá nhân của mình, " & vbNewLine & _
                                "Click OK đê tiếp tục sửa thông tin, Cancel để hủy thao tác", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        If dg = Windows.Forms.DialogResult.OK Then
                            Sua_thong_tin_ca_nhan()
                            Exit Sub
                        Else
                            Huy_thao_tac()
                            Exit Sub
                        End If
                    End If

                    Dim dialog As DialogResult = MessageBox.Show("Ban có chắn chắc muốn sửa thông tin cá nhân., " & vbNewLine & _
                                "Click OK đê đồng ý, Cancel để hủy.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If dialog = DialogResult.OK Then
                        Dim sqlqr As New SqlCommand
                        sqlqr.Connection = connect
                        If .radNam.Checked Then
                            sqlqr.CommandText = "update NguoiDung set PassND='" + .txt_Password.Text + "',HoTen=N'" + .txt_HoTen.Text + "',NgaySinh='" + Format(.date_NgaySinh.Value, "yyyy/MM/dd") + "',GioiTinh=N'Nam',DiaChi=N'" + .txt_DiaChi.Text + "',SoDT=" + .txt_SoDienThoai.Text + ",IdLoaiND='" + .cbo_IdLoaiND.Text + "' where IdNguoiDung='" + .cbo_Username.Text + "'"
                        Else
                            sqlqr.CommandText = "update NguoiDung set PassND='" + .txt_Password.Text + "',HoTen=N'" + .txt_HoTen.Text + "',NgaySinh='" + Format(.date_NgaySinh.Value, "yyyy/MM/dd") + "',GioiTinh=N'Nữ',DiaChi=N'" + .txt_DiaChi.Text + "',SoDT=" + .txt_SoDienThoai.Text + ",IdLoaiND='" + .cbo_IdLoaiND.Text + "' where IdNguoiDung='" + .cbo_Username.Text + "'"
                        End If

                        Try
                            connect.Open()
                            sqlqr.ExecuteNonQuery()
                            connect.Close()
                            Lock_Control(False)
                            LockButton(False)
                            Form_Main.luoi_NguoiDung.Enabled = True
                            UpdateNguoiDung()
                            MsgBox("Đã cập nhật dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
                        Catch ex As Exception
                            MsgBox("Một số kí tự bạn nhập không phù hợp" & vbNewLine & "Các kí có thể nhập là 0 - 9, 26 chữ cái, _ @ * % $ & - ~ và một số kí tự khác", MsgBoxStyle.Exclamation, "Thông báo lỗi")
                            connect.Close()
                        End Try
                    Else
                        Huy_thao_tac()
                    End If
                End If
            End If
        End With
    End Sub
#End Region

#Region "Xu ly huy thao tac cap nhat da hoan tat"
    Public Sub Huy_thao_tac()
        Xoa_lien_ket()
        Lock_Control(False)
        LockButton(False)
        UpdateNguoiDung()
    End Sub
#End Region

#Region "Xu ly xoa nguoi dung da hoan tat"
    Public Sub Xoa_nguoi_dung()
        If Trim(Form_Main.cbo_Username.Text) = Form_Login.LoginTenND Then
            Dim dg As DialogResult = MessageBox.Show("Ban không được quyền xóa thông tin của chính bạn được. " _
            , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim qs = MessageBox.Show("Bạn chắc chắn muốn xóa tất cả thông tin về:" & vbNewLine & _
                        " - User name người dùng: " & Form_Main.cbo_Username.Text & vbNewLine & _
                        " - Tên: " & Form_Main.txt_HoTen.Text & vbNewLine & _
                        " - Số điện thoại: " & Form_Main.txt_SoDienThoai.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If qs = DialogResult.Yes Then
                Dim lenh As String = "Delete from NguoiDung where IdNguoiDung = '" & Form_Main.cbo_Username.SelectedValue.ToString & "'"
                Dim query1 As New SqlCommand(lenh, connect)
                Try
                    connect.Open()
                    query1.ExecuteNonQuery()
                    connect.Close()
                    UpdateNguoiDung()
                    MsgBox("Dữ liệu đã xóa thành công", vbInformation, "Thông báo")
                Catch ex As Exception
                    MsgBox("Xóa không thành công", vbExclamation, "Thông báo")
                End Try
            Else
                MsgBox("Đã hủy thao tác xóa!", vbExclamation, "Thông báo")
            End If
        End If
    End Sub
#End Region

#Region "Cac xu ly phu voi cac dieu khien da hoan tat"
    Private Sub Lock_Control(ByVal f As Boolean)
        With Form_Main
            .cbo_Username.Enabled = True
            .txt_Password.Enabled = f
            .txt_HoTen.Enabled = f
            .date_NgaySinh.Enabled = f
            .radNam.Enabled = f
            .radNu.Enabled = f
            .cbo_IdLoaiND.Enabled = f
            .txt_SoDienThoai.Enabled = f
            .txt_DiaChi.Enabled = f
        End With
    End Sub

    Private Sub Clear_Control()
        With Form_Main
            .txt_Password.Text = ""
            .txt_DiaChi.Text = ""
            .txt_HoTen.Text = ""
            .txt_SoDienThoai.Text = ""
            .radNu.Checked = True
            .cbo_Username.Text = ""
            .date_NgaySinh.Text = ""
            .cbo_IdLoaiND.Text = "Nhan_Vien"
            .cbo_Username.Focus()
        End With
    End Sub

    Private Sub LockButton(ByVal dt As Boolean)
        With Form_Main
            .Button_Them.Enabled = Not dt
            .Button_Sua.Enabled = Not dt
            .Button_Xoa.Enabled = Not dt
            .Button_Luu.Enabled = dt
            .Button_Huy.Enabled = dt
            .Button_PhanQuyen.Enabled = Not dt
            .Button_CapPass.Enabled = Not dt
        End With
    End Sub

    Private Function TestInfo() As Boolean
        TestInfo = True
        With Form_Main
            If Trim(.cbo_Username.Text) = "" OrElse Trim(.txt_Password.Text) = "" OrElse Trim(.txt_HoTen.Text) = "" _
            OrElse Trim(.date_NgaySinh.Text) = "" OrElse Trim(.cbo_IdLoaiND.Text) = "" _
            OrElse Trim(.txt_SoDienThoai.Text) = "" OrElse Trim(.txt_DiaChi.Text) = "" Then
                TestInfo = False
                MsgBox("Bạn phải nhập đầy đủ thông tin!", MsgBoxStyle.Exclamation, "Thông báo lỗi")
            End If

            If Trim(.cbo_Username.Text) = "" Then
                .cbo_Username.Focus()
                Exit Function
            ElseIf Trim(.txt_Password.Text) = "" Then
                .txt_Password.Focus()
                Exit Function
            ElseIf Trim(.txt_HoTen.Text) = "" Then
                .txt_HoTen.Focus()
                Exit Function
            ElseIf Trim(.date_NgaySinh.Text) = "" Then
                .date_NgaySinh.Focus()
                Exit Function
            ElseIf Trim(.txt_SoDienThoai.Text) = "" Then
                .txt_SoDienThoai.Focus()
                Exit Function
            ElseIf Trim(.txt_DiaChi.Text) = "" Then
                .txt_DiaChi.Focus()
                Exit Function
            End If

            If Trim(.txt_Password.Text).Length < 5 Then
                TestInfo = False
                MsgBox("Password không được ít hơn 5 kí tự!", MsgBoxStyle.Exclamation, "Thông báo lỗi")
                .txt_Password.Focus()
                Exit Function
            End If

            If Trim(.cbo_IdLoaiND.Text) <> "Quan_Ly" AndAlso Trim(.cbo_IdLoaiND.Text) <> "Nhan_Vien" AndAlso Trim(.cbo_IdLoaiND.Text) <> "Admin" Then
                TestInfo = False
                MsgBox("Loại người dùng chỉ có thể là QL(Quản Lý) hoặc NV(Nhân Viên)", MsgBoxStyle.Exclamation, "Thông báo lỗi")
                .cbo_IdLoaiND.Focus()
                Exit Function
            End If

            If Trim(.txt_SoDienThoai.Text).Length > 11 Then
                TestInfo = False
                MsgBox("Số điện thoại không được quá 11 số", MsgBoxStyle.Exclamation, "Thông báo lỗi")
                .txt_SoDienThoai.Focus()
                Exit Function
            End If
        End With
    End Function
#End Region

End Class
