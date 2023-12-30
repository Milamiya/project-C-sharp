Imports System.Data.SqlClient
Public Class Xe
    Private flag As Boolean
    Private lenh As String
    Private bang_xe As DataTable
    Private vi_tri_hien_hanh As Integer

    Public Sub UpdateXe()
        Doc_bang_Xe()
        Tao_lien_ket()
        vi_tri_hien_hanh = 0
        Xuat_thong_tin_Xe()
        Form_Main.Luoi_Xe.ReadOnly = True
        Lock_Control(False)
        LockButton(False)

        With Form_Main.cbo_HieuXe.Items
            .Add("Ford Transit")
            .Add("Huyndai Country")
            .Add("Toyota")
            .Add("Ford Everest")
            .Add("Huyndai")
        End With
        'Doc du lieu tu bang_xe vao cbo_HieuXe
        'Dim dem As Integer = 0
        'For i As Integer = 0 To bang_xe.Rows.Count - 1
        '    For j As Integer = 0 To Form_Main.cbo_HieuXe.Items.Count - 1
        '        If Form_Main.cbo_HieuXe.Items(j).ToString = bang_xe.Rows(i)("Hieu_Xe").ToString Then
        '            dem += 1
        '        End If
        '    Next
        '    If dem = 0 Then
        '        Form_Main.cbo_HieuXe.Items.Add(bang_xe.Rows(i)("Hieu_Xe").ToString)
        '    End If
        '    dem = 0
        'Next
    End Sub

#Region "Doc bang xe da xu ly xong"
    Private Sub Doc_bang_Xe()
        'Lam sach luoi sau moi lan cap nhat
        Form_Main.Luoi_Xe.ClearSelection()
        lenh = "Select * from Xe"
        bang_xe = Doc_bang(lenh)
        Form_Main.Luoi_Xe.DataSource = bang_xe
    End Sub
#End Region

#Region "Xu ly cac nut di chuyen va xuat thong tin xe da hoan tat"
    Private Sub Xuat_thong_tin_Xe()
        Dim dong As DataRow = bang_xe.Rows(vi_tri_hien_hanh)
        With Form_Main
            .cbo_SoXe.Text = dong("So_Xe").ToString
            .cbo_HieuXe.Text = dong("Hieu_Xe").ToString
            .txt_DoiXe.Text = CStr(dong("Doi_Xe"))
            .cbo_SoChoNgoi.Text = dong("So_Cho_Ngoi").ToString
        End With
    End Sub

    Public Sub Di_chuyen_ve_sau()
        If vi_tri_hien_hanh < bang_xe.Rows.Count - 1 Then
            vi_tri_hien_hanh += 1
            Xuat_thong_tin_Xe()
        End If
    End Sub

    Public Sub Di_chuyen_ve_truoc()
        If vi_tri_hien_hanh > 0 Then
            vi_tri_hien_hanh -= 1
            Xuat_thong_tin_Xe()
        End If
    End Sub

    Public Sub Di_chuyen_ve_dau()
        vi_tri_hien_hanh = 0
        Xuat_thong_tin_Xe()
    End Sub

    Public Sub Di_chuyen_ve_cuoi()
        vi_tri_hien_hanh = bang_xe.Rows.Count - 1
        Xuat_thong_tin_Xe()
    End Sub
#End Region

#Region "Tao lien ket giua cac dieu khien voi datagridview da hoan tat"
    Private Sub Tao_lien_ket()
        If Form_Main.cbo_SoChoNgoi.Text = "" Then
            With Form_Main.cbo_SoChoNgoi
                .Items.Add(7)
                .Items.Add(16)
                .Items.Add(25)
                .Items.Add(30)
                .Items.Add(45)
            End With
        End If
        With Form_Main.cbo_SoXe
            .DataSource = Form_Main.Luoi_Xe.DataSource
            .DisplayMember = "So_Xe"
            .ValueMember = "So_Xe"
            .SelectedValue = "So_Xe"
        End With
        Xoa_lien_ket()
        'Form_Main.cbo_IdXe.DataBindings.Add("text", Form_Main.Luoi_Xe.DataSource, "Id_Xe")
        'Do Id xe la value member nen ta se khoi tao no luc moi load form va
        '------------Cach1 nhung khong hay, ta nen huy vung nho cua bang sau moi lan xai xong
        'Form_Main.cbo_IdXe.Text = bang_xe.Rows(0)("Id_Xe").ToString 
        '-----------------Cach 2--------------------------
        Form_Main.cbo_SoXe.Text = Form_Main.Luoi_Xe.Rows(0).Cells.Item(0).Value.ToString
        Form_Main.cbo_HieuXe.DataBindings.Add("text", Form_Main.Luoi_Xe.DataSource, "Hieu_Xe")
        Form_Main.txt_DoiXe.DataBindings.Add("text", Form_Main.Luoi_Xe.DataSource, "Doi_Xe")
        Form_Main.cbo_SoChoNgoi.DataBindings.Add("text", Form_Main.Luoi_Xe.DataSource, "So_Cho_Ngoi")
    End Sub
#End Region

#Region "Xoa lien ket giua cac dieu khien voi datagridview da hoan tat"
    Private Sub Xoa_lien_ket()
        Form_Main.cbo_SoXe.DataBindings.Clear()
        Form_Main.cbo_HieuXe.DataBindings.Clear()
        Form_Main.txt_DoiXe.DataBindings.Clear()
        Form_Main.cbo_SoChoNgoi.DataBindings.Clear()
    End Sub
#End Region

#Region "Them, sua xe da hoan tat"
    Public Sub Them_Xe()
        flag = True
        Lock_Control(True)
        LockButton(True)
        Clear_Control()
    End Sub
   
    Public Sub Sua_Xe()
        flag = False
        Lock_Control(True)
        LockButton(True)
        'Form_Main.cbo_SoXe.Enabled = False
        Form_Main.Luoi_Xe.ReadOnly = False
        Form_Main.cbo_SoXe.Enabled = False
    End Sub

    Public Sub Luu_thay_doi()
        Tao_ket_noi()
        If connect.State = ConnectionState.Open Then
            connect.Close()
        End If
        With Form_Main
            If flag = True Then 'Them xe moi
                If TestInfo() Then
                    Dim dg As DialogResult = MessageBox.Show("Ban có chắn chắc muốn thêm xe này không." & vbNewLine & _
                                "Click OK đê đồng ý, Cancel để hủy.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If dg = Windows.Forms.DialogResult.OK Then
                        Dim flag As Integer = 0
                        Dim sqlCM As New SqlCommand("select So_Xe from Xe", connect)
                        Dim sqlDR As SqlDataReader
                        connect.Open()
                        sqlDR = sqlCM.ExecuteReader
                        While sqlDR.Read() = True
                            If sqlDR.GetValue(0).ToString = .cbo_SoXe.Text Then
                                flag = 1
                                MessageBox.Show("Số xe " + .cbo_SoXe.Text + " đã tồn tại, vui lòng kiểm tra lại số xe bạn nhập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If
                        End While
                        connect.Close()
                        If flag = 0 Then
                            lenh = "Insert into Xe(So_Xe, Hieu_Xe, Doi_Xe, So_Cho_Ngoi)"
                            lenh &= " Values ('" + .cbo_SoXe.Text + "', '" + .cbo_HieuXe.Text + "', '" + .txt_DoiXe.Text + "', '" + .cbo_SoChoNgoi.Text + "')"
                            Dim bo_lenh As New SqlCommand(lenh, connect)
                            connect.Open()
                            Try
                                bo_lenh.ExecuteNonQuery()
                                connect.Close()
                                Doc_bang_Xe()
                                Tao_lien_ket()
                                vi_tri_hien_hanh = 0
                                Xuat_thong_tin_Xe()
                                Form_Main.cbo_HieuXe.Items.Clear()
                                Form_Main.Luoi_Xe.Enabled = True
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

                    Dim dialog As DialogResult = MessageBox.Show("Ban có chắn chắc muốn sửa thông tin xe này." & vbNewLine & _
                                "Click OK đê đồng ý, Cancel để hủy.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If dialog = DialogResult.OK Then
                        lenh = "Update Xe Set Hieu_Xe = '" + .cbo_HieuXe.Text + "', Doi_Xe = '" + .txt_DoiXe.Text + "', So_Cho_Ngoi = '" + .cbo_SoChoNgoi.Text + "' where So_Xe = '" + .cbo_SoXe.Text + "'"
                        Dim sqlqr As New SqlCommand(lenh, connect)
                        Try
                            connect.Open()
                            sqlqr.ExecuteNonQuery()
                            connect.Close()
                            UpdateXe()
                            Lock_Control(False)
                            LockButton(False)
                            Form_Main.Luoi_Xe.Enabled = True
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
        Form_Main.Luoi_Xe.Enabled = True
        Xoa_lien_ket()
        Lock_Control(False)
        LockButton(False)
        UpdateXe()
    End Sub
#End Region

#Region "Xoa xe hoan tat"
    Public Sub Xoa_Xe()
        Dim qs = MessageBox.Show("Bạn chắc chắn muốn xóa tất cả thông tin về:" & vbNewLine & _
                        " - So xe: " & Form_Main.cbo_SoXe.Text & vbNewLine & _
                        " - Hieu xe: " & Form_Main.cbo_HieuXe.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If qs = DialogResult.Yes Then
            Dim lenh As String = "Delete from Xe where So_Xe = '" & Form_Main.cbo_SoXe.SelectedValue.ToString & "'"
            Dim query1 As New SqlCommand(lenh, connect)
            Try
                connect.Open()
                query1.ExecuteNonQuery()
                connect.Close()
                UpdateXe()
                MsgBox("Dữ liệu đã xóa thành công", vbInformation, "Thông báo")
            Catch ex As Exception
                MsgBox("Không cập nhật được dữ liệu, xóa xe không thành công", vbExclamation, "Thông báo")
            End Try
        Else
            MsgBox("Đã hủy thao tác xóa!", vbExclamation, "Thông báo")
        End If
    End Sub
#End Region

#Region "Cac xu ly phu voi cac dieu khien da hoan tat"
    Private Sub Lock_Control(ByVal f As Boolean)
        With Form_Main
            .cbo_SoXe.Enabled = True
            .cbo_HieuXe.Enabled = f
            .txt_DoiXe.Enabled = f
            .cbo_SoChoNgoi.Enabled = f
        End With
    End Sub

    Private Sub Clear_Control()
        With Form_Main
            .cbo_SoXe.Text = ""
            .cbo_HieuXe.Text = ""
            .txt_DoiXe.Text = ""
            .cbo_SoXe.Focus()
        End With
    End Sub

    Private Sub LockButton(ByVal dt As Boolean)
        With Form_Main
            .btn_ThemXe.Enabled = Not dt
            .btn_SuaXe.Enabled = Not dt
            .btn_XoaXe.Enabled = Not dt
            .btn_LuuXe.Enabled = dt
            .btn_HuyXe.Enabled = dt
        End With
    End Sub

    Private Function TestInfo() As Boolean
        TestInfo = True
        With Form_Main
            If Trim(.cbo_SoXe.Text) = "" OrElse Trim(.cbo_HieuXe.Text) = "" _
            OrElse Trim(.txt_DoiXe.Text) = "" OrElse Trim(.cbo_SoChoNgoi.Text) = "" Then
                TestInfo = False
                MsgBox("Bạn phải nhập đầy đủ thông tin!", MsgBoxStyle.Exclamation, "Thông báo lỗi")
            End If

            If Trim(.cbo_SoXe.Text) = "" Then
                .cbo_SoXe.Focus()
                Exit Function
            ElseIf Trim(.cbo_HieuXe.Text) = "" Then
                .cbo_HieuXe.Focus()
                Exit Function
            ElseIf Trim(.txt_DoiXe.Text) = "" Then
                .txt_DoiXe.Focus()
                Exit Function
            ElseIf Trim(.cbo_SoChoNgoi.Text) = "" Then
                .cbo_SoChoNgoi.Focus()
                Exit Function
            End If

            If Trim(.cbo_SoXe.Text).Length > 8 Then
                TestInfo = False
                MsgBox("Số xe không được lớn hơn 8 kí tự!", MsgBoxStyle.Exclamation, "Thông báo lỗi")
                .txt_Password.Focus()
                Exit Function
            End If

        End With
    End Function
#End Region

End Class
