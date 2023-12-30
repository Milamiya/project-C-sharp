Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadmh()
        dgv1.DataSource = ds.Tables("monhoc")

        dgv1.ReadOnly = True
        dgv1.AllowUserToAddRows = False
        dgv1.AllowUserToDeleteRows = False
        dgv1.RowHeadersVisible = False
        dgv1.AllowUserToResizeColumns = False
        dgv1.AllowUserToResizeRows = False
        dgv1.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        dgv1.DefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        dgv1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv1.Columns(0).Width = 110
        dgv1.Columns(1).Width = 300
        dgv1.Columns(2).Width = 100

        dgv1.Columns(0).HeaderText = "Mã môn"
        dgv1.Columns(1).HeaderText = "Tên môn học"
        dgv1.Columns(2).HeaderText = "Số tiết"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MainForm.reloadall()
        Me.Hide()

    End Sub

    Private Sub huy()
        txtmm.Clear()
        txtten.Clear()
        txtst.Clear()
    End Sub

    Private Sub binding()
        txtmm.DataBindings.Clear()
        txtten.DataBindings.Clear()
        txtst.DataBindings.Clear()

        txtmm.DataBindings.Add("Text", ds.Tables("monhoc"), "MAMH")
        txtten.DataBindings.Add("Text", ds.Tables("monhoc"), "TENMH")
        txtst.DataBindings.Add("Text", ds.Tables("monhoc"), "SOTIET")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim res As Long
        If txtmm.Text = "" Or txtten.Text = "" Or txtst.Text = "" Then
            MsgBox("Bạn cần nhập đủ thông tin", MsgBoxStyle.Information, "Thông Báo")
        Else
            If checkmh(txtmm.Text) = 0 Then
                addmh(txtmm.Text, txtten.Text, Convert.ToInt32(txtst.Text))
                MsgBox("Đã thêm môn mới", MsgBoxStyle.Information, "Thông Báo")
                huy()

                loadmh()
                Exit Sub
            Else
                res = MsgBox("Đã tồn tại, bạn muốn sửa không", MsgBoxStyle.OkCancel, "Thông báo")
                If res = vbOK Then
                    updmh(txtmm.Text, txtten.Text, Convert.ToInt32(txtst.Text))
                    huy()

                    loadmh()
                Else : res = vbCancel
                    huy()
                    loadmh()

                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtmm.Text = "" Then
            MsgBox("Bạn phải điền mã môn học hoặc chọn ở bảng", MsgBoxStyle.Information, "Thông báo")
        Else
            If checkmh(txtmm.Text) = 0 Then
                MsgBox("Không có môn này", MsgBoxStyle.Information, "Lỗi")
            Else
                delmh(txtmm.Text)
                MsgBox("Đã xóa", MsgBoxStyle.Information, "Xong")
                huy()

                loadmh()
            End If
        End If

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellClick
        Try
            binding()

        Catch ex As Exception
            Exit Sub

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        loadmh()
        Form7.Show()

    End Sub
End Class