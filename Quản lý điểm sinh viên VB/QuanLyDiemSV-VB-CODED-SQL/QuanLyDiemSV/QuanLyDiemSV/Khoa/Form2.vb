Public Class Form2

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MainForm.reloadall()
        Me.Hide()

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        loadkhoa()
        dgv1.DataSource = ds.Tables("khoa")


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
        dgv1.Columns(0).Width = 160
        dgv1.Columns(1).Width = 390

        dgv1.Columns(0).HeaderText = "Mã khoa"
        dgv1.Columns(1).HeaderText = "Tên khoa"
        

    End Sub

    Private Sub huy()
        txtmk.Clear()
        txtten.Clear()

    End Sub

    Private Sub binding()
        txtmk.DataBindings.Clear()
        txtten.DataBindings.Clear()

        txtmk.DataBindings.Add("Text", ds.Tables("khoa"), "MAKHOA")
        txtten.DataBindings.Add("Text", ds.Tables("khoa"), "TENKHOA")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim res As Long
        If txtmk.Text = "" Or txtten.Text = "" Then
            MsgBox("Bạn cần nhập đủ thông tin", MsgBoxStyle.Information, "Thông Báo")
        Else
            If checkkhoa(txtmk.Text) = 0 Then
                addkhoa(txtmk.Text, txtten.Text)
                MsgBox("Đã thêm khoa mới", MsgBoxStyle.Information, "Thông Báo")
                huy()
                loadkhoa()

                Exit Sub
            Else
                res = MsgBox("Đã tồn tại, bạn muốn sửa không", MsgBoxStyle.OkCancel, "Thông báo")
                If res = vbOK Then
                    updkhoa(txtmk.Text, txtten.Text)
                    huy()
                    loadkhoa()
                Else : res = vbCancel
                    huy()
                    loadkhoa()

                End If
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtmk.Text = "" Then
            MsgBox("Bạn phải điền mã khoa hoặc chọn ở bảng", MsgBoxStyle.Information, "Thông báo")
        Else
            If checkkhoa(txtmk.Text) = 0 Then
                MsgBox("Không có môn này", MsgBoxStyle.Information, "Lỗi")
            Else
                delkhoa(txtmk.Text)
                MsgBox("Đã xóa", MsgBoxStyle.Information, "Xong")
                huy()

                loadkhoa()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        loadkhoa()
        Form6.Show()

    End Sub
End Class