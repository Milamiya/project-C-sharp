Imports System.Data.SqlClient
Public Class Tuyen_xe
    Private bang_tuyen_xe As DataTable
    Private vi_tri_hien_hanh As Integer
    Private lenh As String
    Private flag As Boolean

    Public Sub UpdateTuyenXe()
        Doc_bang_tuyen_xe()
        Tao_lien_ket()
        vi_tri_hien_hanh = 0
        Xuat_thong_tin_Tuyen_xe()
        Form_Main.luoi_Tuyen_xe.ReadOnly = True
        Lock_Control(False)
        LockButton(False)
    End Sub

#Region "Doc bang tuyen xe da xong"
    Private Sub Doc_bang_tuyen_xe()
        'Lam sach luoi sau moi lan cap nhat
        Form_Main.luoi_Tuyen_xe.ClearSelection()
        lenh = "Select * from TuyenXe"
        bang_tuyen_xe = Doc_bang(lenh)
        Form_Main.luoi_Tuyen_xe.DataSource = bang_tuyen_xe
    End Sub
#End Region

#Region "Tao lien ket giua cac dieu khien voi datagridview da hoan tat"
    Private Sub Tao_lien_ket()
        With Form_Main.cbo_IdTuyen
            .DataSource = Form_Main.luoi_Tuyen_xe.DataSource
            .DisplayMember = "IdTuyen"
            .ValueMember = "IdTuyen"
            .SelectedValue = "IdTuyen"
        End With
        Xoa_lien_ket()
        
        Form_Main.cbo_IdTuyen.Text = Form_Main.luoi_Tuyen_xe.Rows(0).Cells.Item(0).Value.ToString
        Form_Main.cbo_TenTuyen.DataBindings.Add("text", Form_Main.luoi_Tuyen_xe.DataSource, "TenTuyen")
        Form_Main.cbo_DiaDiemDi.DataBindings.Add("text", Form_Main.luoi_Tuyen_xe.DataSource, "DiaDiemDi")
        Form_Main.cbo_DiaDiemDen.DataBindings.Add("text", Form_Main.luoi_Tuyen_xe.DataSource, "DiaDiemDen")
    End Sub
#End Region

#Region "Xoa lien ket giua cac dieu khien voi datagridview da hoan tat"
    Private Sub Xoa_lien_ket()
        Form_Main.cbo_TenTuyen.DataBindings.Clear()
        Form_Main.cbo_DiaDiemDi.DataBindings.Clear()
        Form_Main.cbo_DiaDiemDen.DataBindings.Clear()
    End Sub
#End Region

#Region "Xu ly cac nut di chuyen va xuat thong tin tuyen xe da hoan tat"
    Private Sub Xuat_thong_tin_Tuyen_xe()
        Dim dong As DataRow = bang_tuyen_xe.Rows(vi_tri_hien_hanh)
        With Form_Main
            .cbo_IdTuyen.Text = dong("IdTuyen").ToString
            .cbo_TenTuyen.Text = dong("TenTuyen").ToString
            .cbo_DiaDiemDi.Text = CStr(dong("DiaDiemDi"))
            .cbo_DiaDiemDen.Text = dong("DiaDiemDen").ToString
        End With
    End Sub

    Public Sub Di_chuyen_ve_sau()
        If vi_tri_hien_hanh < bang_tuyen_xe.Rows.Count - 1 Then
            vi_tri_hien_hanh += 1
            Xuat_thong_tin_Tuyen_xe()
        End If
    End Sub

    Public Sub Di_chuyen_ve_truoc()
        If vi_tri_hien_hanh > 0 Then
            vi_tri_hien_hanh -= 1
            Xuat_thong_tin_Tuyen_xe()
        End If
    End Sub

    Public Sub Di_chuyen_ve_dau()
        vi_tri_hien_hanh = 0
        Xuat_thong_tin_Tuyen_xe()
    End Sub

    Public Sub Di_chuyen_ve_cuoi()
        vi_tri_hien_hanh = bang_tuyen_xe.Rows.Count - 1
        Xuat_thong_tin_Tuyen_xe()
    End Sub
#End Region

#Region "Them, sua tuyen da hoan tat"
    Public Sub Them()
        flag = True
        Lock_Control(True)
        LockButton(True)
        Clear_Control()
        Form_Main.luoi_Tuyen_xe.Enabled = False
        For i As Integer = 0 To bang_tuyen_xe.Rows.Count - 1
            Form_Main.cbo_TenTuyen.Items.Add(bang_tuyen_xe.Rows(i)("TenTuyen").ToString)
        Next
    End Sub

    Public Sub Sua()
        flag = False
        Lock_Control(True)
        LockButton(True)
        'Form_Main.cbo_SoXe.Enabled = False
        Form_Main.Luoi_Xe.ReadOnly = False
        Form_Main.cbo_IdTuyen.Enabled = False
    End Sub

    Public Sub Luu()
        Tao_ket_noi()
        If connect.State = ConnectionState.Open Then
            connect.Close()
        End If
        With Form_Main
            If flag = True Then 'Them nguoi dung moi
                If TestInfo() Then
                    Dim dg As DialogResult = MessageBox.Show("Ban có chắn chắc muốn thêm tuyến xe này không." & vbNewLine & _
                                "Click OK đê đồng ý, Cancel để hủy.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If dg = Windows.Forms.DialogResult.OK Then
                        Dim flag As Integer = 0
                        Dim sqlCM As New SqlCommand("select IdTuyen from TuyenXe", connect)
                        Dim sqlDR As SqlDataReader
                        connect.Open()
                        sqlDR = sqlCM.ExecuteReader
                        While sqlDR.Read() = True
                            If sqlDR.GetValue(0).ToString = .cbo_IdTuyen.Text Then
                                flag = 1
                                MessageBox.Show("Mã số tuyến " + .cbo_IdTuyen.Text + " đã tồn tại, vui lòng kiểm tra lại ma so tuyen bạn nhập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If
                        End While
                        connect.Close()
                        If flag = 0 Then
                            lenh = "Insert into TuyenXe"
                            lenh &= " Values ('" + .cbo_IdTuyen.Text + "', '" + .cbo_TenTuyen.Text + "', N'" + .cbo_DiaDiemDi.Text + "', N'" + .cbo_DiaDiemDen.Text + "')"
                            Dim bo_lenh As New SqlCommand(lenh, connect)
                            connect.Open()
                            Try
                                bo_lenh.ExecuteNonQuery()
                                connect.Close()
                                UpdateTuyenXe()
                                Lock_Control(False)
                                LockButton(False)
                                Form_Main.luoi_Tuyen_xe.Enabled = True
                                MsgBox("Đã cập nhật dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
                            Catch ex As Exception
                                MessageBox.Show("Không cập nhật được dữ liệu, thêm xe thông thành công.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                connect.Close()
                            End Try
                        End If
                    Else
                        Huy_thao_tac()
                    End If
                End If
            Else
                'Sua thong tin nguoi dung
                If TestInfo() Then
                    Dim dialog As DialogResult = MessageBox.Show("Ban có chắn chắc muốn sửa thông tin tuyến xe này." & vbNewLine & _
                                "Click OK đê đồng ý, Cancel để hủy.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If dialog = DialogResult.OK Then
                        lenh = "Update TuyenXe Set TenTuyen = '" + .cbo_TenTuyen.Text + "', DiaDiemDi = N'" + .cbo_DiaDiemDi.Text + "', DiaDiemDen = N'" + .cbo_DiaDiemDen.Text + "' where IdTuyen = '" + .cbo_IdTuyen.Text + "'"
                        Dim sqlqr As New SqlCommand(lenh, connect)
                        Try
                            connect.Open()
                            sqlqr.ExecuteNonQuery()
                            connect.Close()
                            UpdateTuyenXe()
                            Lock_Control(False)
                            LockButton(False)
                            Form_Main.luoi_Tuyen_xe.Enabled = True
                            MsgBox("Đã cập nhật dữ liệu thành công", MsgBoxStyle.Information, "Thông báo")
                        Catch ex As Exception
                            MessageBox.Show("Không cập nhật được dữ liệu, sửa thông tin xe thông thành công.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Form_Main.luoi_Tuyen_xe.Enabled = True
        Xoa_lien_ket()
        Lock_Control(False)
        LockButton(False)
        UpdateTuyenXe()
    End Sub
#End Region

#Region "Xoa tuyen hoan tat"
    Public Sub Xoa()
        Dim qs = MessageBox.Show("Bạn chắc chắn muốn xóa tất cả thông tin về:" & vbNewLine & _
                        " - Ma so tuyen: " & Form_Main.cbo_IdTuyen.Text & vbNewLine & _
                        " - Ten tuyen: " & Form_Main.cbo_TenTuyen.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If qs = DialogResult.Yes Then
            Dim lenh As String = "Delete from TuyenXe where IdTuyen = '" & Form_Main.cbo_IdTuyen.SelectedValue.ToString & "'"
            Dim query1 As New SqlCommand(lenh, connect)
            Try
                connect.Open()
                query1.ExecuteNonQuery()
                connect.Close()
                UpdateTuyenXe()
                MsgBox("Dữ liệu đã xóa thành công", vbInformation, "Thông báo")
            Catch ex As Exception
                MsgBox("Không cập nhật được dữ liệu, xóa tuyến không thành công", vbExclamation, "Thông báo")
            End Try
        Else
            MsgBox("Đã hủy thao tác xóa!", vbExclamation, "Thông báo")
        End If
    End Sub
#End Region

#Region "Cac xu ly phu voi cac dieu khien da hoan tat"
    Private Sub Lock_Control(ByVal f As Boolean)
        With Form_Main
            .cbo_IdTuyen.Enabled = True
            .cbo_TenTuyen.Enabled = f
            .cbo_DiaDiemDi.Enabled = f
            .cbo_DiaDiemDen.Enabled = f
        End With
    End Sub

    Private Sub Clear_Control()
        With Form_Main
            .cbo_IdTuyen.Text = ""
            .cbo_TenTuyen.Text = ""
            .cbo_DiaDiemDi.Text = ""
            .cbo_DiaDiemDen.Text = ""
            .cbo_IdTuyen.Focus()
        End With
    End Sub

    Private Sub LockButton(ByVal dt As Boolean)
        With Form_Main
            .btn_ThemTuyen.Enabled = Not dt
            .btn_SuaTuyen.Enabled = Not dt
            .btn_XoaTuyen.Enabled = Not dt
            .btn_LuuTuyen.Enabled = dt
            .btn_HuyTuyen.Enabled = dt
        End With
    End Sub

    Private Function TestInfo() As Boolean
        TestInfo = True
        With Form_Main
            If Trim(.cbo_IdTuyen.Text) = "" OrElse Trim(.cbo_TenTuyen.Text) = "" _
            OrElse Trim(.cbo_DiaDiemDi.Text) = "" OrElse Trim(.cbo_DiaDiemDen.Text) = "" Then
                TestInfo = False
                MsgBox("Bạn phải nhập đầy đủ thông tin!", MsgBoxStyle.Exclamation, "Thông báo lỗi")
            End If

            If Trim(.cbo_IdTuyen.Text) = "" Then
                .cbo_IdTuyen.Focus()
                Exit Function
            ElseIf Trim(.cbo_TenTuyen.Text) = "" Then
                .cbo_TenTuyen.Focus()
                Exit Function
            ElseIf Trim(.cbo_DiaDiemDi.Text) = "" Then
                .cbo_DiaDiemDi.Focus()
                Exit Function
            ElseIf Trim(.cbo_DiaDiemDen.Text) = "" Then
                .cbo_DiaDiemDen.Focus()
                Exit Function
            End If
        End With
    End Function
#End Region
End Class
