Imports System.Data.SqlClient
Public Class Form_Cap_pass
    Private flag As Boolean = True
    Private Nguoi_dung As New Nguoi_dung()
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Timer_Doi_Anh.Stop()
        Me.Close()
    End Sub

    Private Sub Form_Cap_pass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_IdNguoiDung.Text = Form_Main.cbo_Username.Text
        txt_IdNguoiDung.Enabled = False
        txt_NewPassword.Focus()
    End Sub

    Private Sub btn_DongY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DongY.Click
        If Trim(txt_NewPassword.Text).Length < 5 Then
            MsgBox("Password không được ít hơn 5 kí tự!", MsgBoxStyle.Exclamation, "Thông báo lỗi")
            txt_NewPassword.Focus()
        Else
            Dim lenh As String = "Update NguoiDung Set PassND = '" + txt_NewPassword.Text + "' where IdNguoiDung = '" + txt_IdNguoiDung.Text + "'"
            Dim bo_lenh As New SqlCommand(lenh, connect)
            Try
                connect.Open()
                bo_lenh.ExecuteNonQuery()
                connect.Close()
                MessageBox.Show("Pass mới đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Nguoi_dung.UpdateNguoiDung()
            Catch ex As Exception
                MessageBox.Show("Cấp pass không thành công, yêu cầu kiểm tra lại kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Timer_Doi_Anh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Doi_Anh.Tick
        If flag Then
            PictureBox1.Image = My.Resources.Fermer_session
            flag = Not flag
        Else
            PictureBox1.Image = My.Resources.ferme
            flag = Not flag
        End If

    End Sub
End Class