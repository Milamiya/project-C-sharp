Imports System.Data
Imports System.Data.SqlClient
Public Class Form_Main
    Private flag As Boolean = True
    Private Nguoi_dung As New Nguoi_dung()
    Private Xe As New Xe()
    Private Tuyen_xe As New Tuyen_xe()
    Private Thoi_diem As New Thoi_diem()
    Private Chuyen_Xe As New Chuyen_xe()
    Private Ban_ve As New Ban_ve()
    Private Quyen As New Form_Phan_Quyen
    Private update_he_thong As New Update_he_thong
   

    Private Sub Form_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        update_he_thong.update_()
        Nguoi_dung.UpdateNguoiDung()
        Xe.UpdateXe()
        Tuyen_xe.UpdateTuyenXe()
        Thoi_diem.Update_thoi_diem()
        Chuyen_Xe.Update_Chuyen_xe()
        Ban_ve.Update_Ve_xe()
        Quyen.UpdateQuyen()
        Timer1.Interval = 1000

        Splitter1.Height = 500
        Timer2.Interval = 100
        Timer2.Start()
    End Sub

#Region "Xu ly Timer da xong"
    Private Sub Timer_ChayChu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_ChayChu.Tick
        If lblChayChu.Left < 0 Then
            lblChayChu.Left = 1400
            flag = Not flag
        Else
            lblChayChu.Left -= 10
            If flag Then
                lblChayChu.ForeColor = Color.Black
                flag = Not flag
            Else
                lblChayChu.ForeColor = Color.Teal
                flag = Not flag
            End If
        End If
    End Sub

    Private Sub RibbonPanel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RibbonPanel1.Click
        If flag Then
            Timer_ChayChu.Stop()
            flag = Not flag
        Else
            Timer_ChayChu.Start()
            flag = Not flag
        End If
    End Sub
#End Region

#Region "Cac su kien Close, Logout cua FormMain da xu ly xong"
    Private Sub ButtonX_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX_Close.Click
        On Error Resume Next
        Me.WindowState = 0
        Do
            Me.Top = Me.Top + 10
            Me.Left = Me.Left + 10
            Me.Width = Me.Width - 30
            Me.Height = Me.Height - 30
        Loop Until Me.Top >= Me.Height
        End
        Form_Login.Close()
    End Sub

    Private Sub ButtonX_Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX_Logout.Click
        Form_Login.Visible = True
        Form_Login.Opacity = 100
        Form_Login.txtPassword.Clear()
        Form_Login.Timer1.Start()
        Form_Login.Timer2.Start()
        Me.Close()
    End Sub

    Private Sub FormMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form_Login.Visible = True
        Form_Login.Opacity = 100
        Form_Login.Timer1.Start()
        Form_Login.Timer2.Start()
        Form_Login.txtPassword.Clear()
    End Sub
#End Region

#Region "Xu ly cac su kien click cac button ben trai de di chuyen cac tab dieu khien hoan tat"
    Private Sub btn_QuanLyND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_QuanLyND.Click
        Me.TabControl_Main.SelectedTabIndex = 0
    End Sub

    Private Sub btn_QuanLyXe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_QuanLyXe.Click
        Me.TabControl_Main.SelectedTabIndex = 1
    End Sub

    Private Sub btn_QuanLyTuyenXe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_QuanLyTuyenXe.Click
        TabControl_Main.SelectedTabIndex = 2
    End Sub

    Private Sub btn_ChuyenXe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ChuyenXe.Click
        TabControl_Main.SelectedTabIndex = 4
    End Sub

    Private Sub btn_BanVe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BanVe.Click
        TabControl_Main.SelectedTabIndex = 5
    End Sub
#End Region

    '-----------------------------------------------Xu Ly Nguoi Dung----------------------------------------'
#Region "Xu ly cac nut di chuyen ben phai da hoan tat"
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Nguoi_dung.Di_chuyen_ve_truoc()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Nguoi_dung.Di_chuyen_ve_sau()
    End Sub

    Private Sub btnHead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHead.Click
        Nguoi_dung.Di_chuyen_ve_dau()
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Nguoi_dung.Di_chuyen_ve_cuoi()
    End Sub
#End Region

#Region "Xu ly su kien them, sua, xoa nguoi dung da hoan tat"
    Private Sub Button_Them_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Them.Click
        Nguoi_dung.Them_nguoi_dung()
    End Sub

    Private Sub Button_Luu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Luu.Click
        Nguoi_dung.Luu_thay_doi()
    End Sub

    Private Sub Button_Huy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Huy.Click
        Nguoi_dung.Huy_thao_tac()
    End Sub

    Private Sub Button_Sua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Sua.Click
        Nguoi_dung.Sua_thong_tin_ca_nhan()
    End Sub

    Private Sub Button_Xoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Xoa.Click
        Nguoi_dung.Xoa_nguoi_dung()
    End Sub
#End Region

#Region "Xu ly di chuyen radio theo click chuot tren datagrid da xong"

    Private Sub luoi_NguoiDung_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles luoi_NguoiDung.MouseClick
        If luoi_NguoiDung.CurrentRow.Cells.Item(4).Value.ToString = "Nam" Then
            radNam.Checked = True
        Else
            radNu.Checked = True
        End If
    End Sub

    Private Sub luoi_NguoiDung_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles luoi_NguoiDung.RowEnter
        cbo_Username.Text = luoi_NguoiDung.Item("IdNguoiDung", e.RowIndex).EditedFormattedValue.ToString
        txt_Password.Text = luoi_NguoiDung.Item("PassND", e.RowIndex).EditedFormattedValue.ToString
        txt_HoTen.Text = luoi_NguoiDung.Item("HoTen", e.RowIndex).EditedFormattedValue.ToString
        date_NgaySinh.Text = luoi_NguoiDung.Item("NgaySinh", e.RowIndex).EditedFormattedValue.ToString
        If luoi_NguoiDung.Item("GioiTinh", e.RowIndex).EditedFormattedValue.ToString = "Nam" Then
            radNam.Checked = True
        Else
            radNu.Checked = True
        End If
        txt_SoDienThoai.Text = luoi_NguoiDung.Item("SoDT", e.RowIndex).EditedFormattedValue.ToString
        txt_DiaChi.Text = luoi_NguoiDung.Item("DiaChi", e.RowIndex).EditedFormattedValue.ToString
    End Sub

    Private Sub luoi_NguoiDung_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles luoi_NguoiDung.RowHeaderMouseClick
        If luoi_NguoiDung.CurrentRow.Cells.Item(4).Value.ToString = "Nam" Then
            radNam.Checked = True
        Else
            radNu.Checked = True
        End If
    End Sub
#End Region

#Region "Xu ly button cap pass hoan tat "
    Private Sub Button_CapPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_CapPass.Click
        If cbo_IdLoaiND.Text = "Nhan_Vien" Then
            Dim frm As New Form_Cap_pass()
            frm.ShowDialog()
        ElseIf cbo_IdLoaiND.Text = "Admin" Then
            MessageBox.Show("Bạn không được cấp pass cho người Admin, vui lòng chọn 1 nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("Bạn không được cấp pass cho người quản lý, vui lòng chọn 1 nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub
#End Region

    '--------------------------------------------Xu Ly Xe--------------------------------------------'
#Region "Xu ly cac nut di chuyen xe da hoan tat "
    Private Sub btn_Top_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Top.Click
        Xe.Di_chuyen_ve_dau()
    End Sub

    Private Sub btn_Xe_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Xe_Back.Click
        Xe.Di_chuyen_ve_truoc()
    End Sub

    Private Sub btn_Xe_Next_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Xe_Next.Click
        Xe.Di_chuyen_ve_sau()
    End Sub

    Private Sub btn_Xe_End_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Xe_End.Click
        Xe.Di_chuyen_ve_cuoi()
    End Sub


#End Region

#Region "Xu ly them, sua , xoa Xe da hoan tat"
    Private Sub btn_ThemXe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ThemXe.Click
        Xe.Them_Xe()
    End Sub

    Private Sub btn_SuaXe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SuaXe.Click
        Xe.Sua_Xe()
    End Sub

    Private Sub btn_HuyXe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HuyXe.Click
        Xe.Huy_thao_tac()
    End Sub

    Private Sub btn_LuuXe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LuuXe.Click
        Xe.Luu_thay_doi()
    End Sub

    Private Sub btn_XoaXe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_XoaXe.Click
        Xe.Xoa_Xe()
    End Sub
#End Region

#Region "Su kien nhan enter tren Luoi_xe"
    Private Sub Luoi_Xe_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Luoi_Xe.RowEnter
        cbo_SoXe.Text = Luoi_Xe.Item("So_Xe", e.RowIndex).EditedFormattedValue.ToString
        cbo_HieuXe.Text = Luoi_Xe.Item("Hieu_Xe", e.RowIndex).EditedFormattedValue.ToString
        txt_DoiXe.Text = Luoi_Xe.Item("Doi_Xe", e.RowIndex).EditedFormattedValue.ToString
        cbo_SoChoNgoi.Text = Luoi_Xe.Item("So_Cho_Ngoi", e.RowIndex).EditedFormattedValue.ToString
    End Sub
#End Region

    ''--------------------------------------------------Tuyen Xe----------------------------------------------------
#Region "Xu ly cac button di chuyen da xong"
    Private Sub btn_First_Tuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_First_Tuyen.Click
        Tuyen_xe.Di_chuyen_ve_dau()
    End Sub

    Private Sub btn_Previous_Tuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Previous_Tuyen.Click
        Tuyen_xe.Di_chuyen_ve_truoc()
    End Sub

    Private Sub btn_Next_Tuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Next_Tuyen.Click
        Tuyen_xe.Di_chuyen_ve_sau()
    End Sub

    Private Sub btn_Last_Tuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Last_Tuyen.Click
        Tuyen_xe.Di_chuyen_ve_cuoi()
    End Sub
#End Region

#Region "Xu ly su kien them, xoa , sua hoan tat"
    Private Sub btn_ThemTuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ThemTuyen.Click
        Tuyen_xe.Them()
    End Sub

    Private Sub btn_SuaTuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SuaTuyen.Click
        Tuyen_xe.Sua()
    End Sub

    Private Sub btn_XoaTuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_XoaTuyen.Click
        Tuyen_xe.Xoa()
    End Sub

    Private Sub btn_LuuTuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LuuTuyen.Click
        Tuyen_xe.Luu()
    End Sub

    Private Sub btn_HuyTuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HuyTuyen.Click
        Tuyen_xe.Huy_thao_tac()
    End Sub
#End Region

    Private Sub btn_XemChiTietTuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_XemChiTietTuyen.Click
        Dim frm_ChiTietTuyen As New Form_ChiTietTuyen
        frm_ChiTietTuyen.ShowDialog()
    End Sub
    '----------------------------------------------------Thoi diem-----------------------------------------------
#Region "Đã xong"
    Private Sub btn_ThemThoiDiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ThemThoiDiem.Click
        Thoi_diem.them()
    End Sub

    Private Sub btn_SuaThoiDiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SuaThoiDiem.Click
        Thoi_diem.Sua()
    End Sub

    Private Sub btn_HuyThoiDiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HuyThoiDiem.Click
        Thoi_diem.Huy()
    End Sub

    Private Sub btn_LuuThoiDiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LuuThoiDiem.Click
        Thoi_diem.Luu()
    End Sub

    Private Sub rad_LapTuan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_LapTuan.CheckedChanged
        lbl_Lap.Show()
        date_NgayKetThuc.Show()
    End Sub

    Private Sub btn_XoaThoiDiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_XoaThoiDiem.Click
        Thoi_diem.Xoa()
    End Sub

    Private Sub btn_GanTuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GanTuyen.Click
        Thoi_diem.Gan_tuyen()
    End Sub
#End Region

    '----------------------------------------------------Chuyen Xe------------------------------------------
#Region "Da xong"
    Private Sub btn_ThemChuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ThemChuyen.Click
        Chuyen_Xe.Them()
    End Sub

    Private Sub btn_SuaChuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SuaChuyen.Click
        Chuyen_Xe.Sua()
    End Sub

    Private Sub btn_LuuChuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LuuChuyen.Click
        Chuyen_Xe.Luu()
    End Sub

    Private Sub btn_HuyChuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HuyChuyen.Click
        Chuyen_Xe.Huy()
    End Sub

    Private Sub cbo_IdTuyenChuyen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_IdTuyenChuyen.SelectedIndexChanged
        Chuyen_Xe.Chon_tuyen()
    End Sub

    Private Sub cbo_NgayDiChuyen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_NgayDiChuyen.SelectedIndexChanged
        Chuyen_Xe.Chon_ngay()
    End Sub

    Private Sub btn_XoaChuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_XoaChuyen.Click
        Chuyen_Xe.Xoa()
    End Sub

    Private Sub btn_FirstChuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_FirstChuyen.Click
        Chuyen_Xe.Di_chuyen_ve_dau()
    End Sub

    Private Sub btn_PreviousChuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PreviousChuyen.Click
        Chuyen_Xe.Di_chuyen_ve_truoc()
    End Sub

    Private Sub btn_NextChuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NextChuyen.Click
        Chuyen_Xe.Di_chuyen_ve_sau()
    End Sub

    Private Sub btn_LastChuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LastChuyen.Click
        Chuyen_Xe.Di_chuyen_ve_cuoi()
    End Sub
#End Region

    '-------------------------------------------------Ban Ve-----------------------------------------------
#Region "Da xong"
    Private Sub cbo_TenTuyenVe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_TenTuyenVe.SelectedIndexChanged
        Ban_ve.Chon_tuyen()
    End Sub

    Private Sub cbo_NgayVe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_NgayVe.SelectedIndexChanged
        Ban_ve.Chon_ngay()
    End Sub


    Private Sub cbo_GioVe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_GioVe.SelectedIndexChanged
        Ban_ve.Chon_xe()
    End Sub

    Private Sub cbo_XeVe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_XeVe.SelectedIndexChanged
        Ban_ve.Chon_thong_tin_xe()
    End Sub

    Private Sub btn_ChonChoNgoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ChonChoNgoi.Click
        Ban_ve.Chon_cho_ngoi()
    End Sub

    Private Sub Button_PhanQuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_PhanQuyen.Click
        If cbo_IdLoaiND.Text = "Nhan_Vien" Then
            Dim frm_PhanQuyen As New Form_Phan_Quyen
            frm_PhanQuyen.Show()
        Else
            MessageBox.Show("Bạn chỉ được cấp quyền cho nhân viên thôi, vui lòng chọn 1 nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If

    End Sub
#End Region

    Private Sub ButtonItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem14.Click
        Dim frm_Info As New Infomation()
        frm_Info.Show()
    End Sub

    Private Sub LabelItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Time.Text = DateTime.Now.ToString
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Splitter1.Height = 3 Then
            Timer2.Stop()
        Else
            Splitter1.Height = Splitter1.Height - 20
        End If
    End Sub
End Class