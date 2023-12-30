Public Class Form4

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MainForm.reloadall()

        Me.Hide()

    End Sub

    Private Sub themmk()
        ComboBox1.Items.Clear()
        loadkhoa()
        Dim i As Integer
        For i = 0 To ds.Tables("khoa").Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables("khoa").Rows(i).Item(0))
        Next
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadsv()
        dgv1.DataSource = ds.Tables("sinhvien")
        Me.mtb1.Mask = "00/00/0000"
        Me.mtb1.ValidatingType = GetType(System.DateTime)
        Me.ToolTip1.IsBalloon = True
        rbt1.Checked = True

        themmk()

        dgv1.ReadOnly = True
        dgv1.AllowUserToAddRows = False
        dgv1.AllowUserToDeleteRows = False
        dgv1.RowHeadersVisible = False
        dgv1.AllowUserToResizeColumns = False
        dgv1.AllowUserToResizeRows = False
        dgv1.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point)
        dgv1.DefaultCellStyle.Font = New Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point)
        dgv1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv1.Columns(0).Width = 80
        dgv1.Columns(1).Width = 80
        dgv1.Columns(2).Width = 110
        dgv1.Columns(3).Width = 110
        dgv1.Columns(4).Width = 110
        dgv1.Columns(5).Width = 110

        dgv1.Columns(0).HeaderText = "Mã SV"
        dgv1.Columns(1).HeaderText = "Họ"
        dgv1.Columns(2).HeaderText = "Tên"
        dgv1.Columns(3).HeaderText = "Ngày sinh"
        dgv1.Columns(4).HeaderText = "Giới tính"
        dgv1.Columns(5).HeaderText = "Mã khoa"

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        loadsv()
        dgv1.DataSource = ds.Tables("sinhvien")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        loadsvnam()
        dgv1.DataSource = ds.Tables("sinhviennam")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        loadsvnu("Nữ")
        dgv1.DataSource = ds.Tables("sinhviennu")
    End Sub

    Private Sub mtb1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles mtb1.KeyDown
        Me.ToolTip1.Hide(Me.mtb1)
    End Sub

    Private Sub mtb1_TypeValidationCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.TypeValidationEventArgs) Handles mtb1.TypeValidationCompleted

        If (Not e.IsValidInput) Then
            Me.ToolTip1.ToolTipTitle = "Thời gian không phù hợp"
            Me.ToolTip1.Show("Bạn phải nhập ngày tháng định dạng dd/mm/yyyy", Me.mtb1, 100, -60, 5000)
            mtb1.Clear()
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        txttk.Text = tenkhoa(ComboBox1.Text)

    End Sub

    Private Sub huy()

        txtmsv.Clear()
        mtb1.Clear()
        txtho.Clear()
        txtten.Clear()
        ComboBox1.ResetText()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim res As Long
        If txtmsv.Text = "" Or txtho.Text = "" Or txtten.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Bạn phải nhập đủ thông tin")
        Else
            If Date.TryParse(mtb1.Text, Nothing) Then
                If checksv(txtmsv.Text) <> 0 Then
                    res = MsgBox("Sinh viên đã tồn tại, bạn xác nhận muốn sửa?", MsgBoxStyle.OkCancel, "Thông báo")
                    If res = vbOK Then
                        If rbt2.Checked = True Then
                            updsv(txtmsv.Text, txtho.Text, txtten.Text, mtb1.Text, "Nữ", ComboBox1.Text)
                            huy()
                        Else
                            updsv(txtmsv.Text, txtho.Text, txtten.Text, mtb1.Text, "Nam", ComboBox1.Text)
                            huy()
                        End If


                    Else : res = vbCancel

                        huy()

                    End If

                Else
                    If rbt2.Checked = True Then
                        addsv(txtmsv.Text, txtho.Text, txtten.Text, mtb1.Text, "Nữ", ComboBox1.Text)
                        MsgBox("Đã thêm SV mới", MsgBoxStyle.Information, "Chúc mừng")
                        huy()
                    Else
                        addsv(txtmsv.Text, txtho.Text, txtten.Text, mtb1.Text, "Nam", ComboBox1.Text)
                        MsgBox("Đã thêm SV mới", MsgBoxStyle.Information, "Chúc mừng")
                        huy()
                    End If
                    
              
                End If
            Else

                MsgBox("Bạn phải nhập đủ thông tin")

            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtmsv.Text = "" Then
            MsgBox("Bạn phải điền mã SV", MsgBoxStyle.Information, "Thông báo")
        Else
            If checksv(txtmsv.Text) = 0 Then
                MsgBox("Không có SV này", MsgBoxStyle.Information, "Lỗi")
            Else
                delsv(txtmsv.Text)
                delkqsv(txtmsv.Text)
                MsgBox("Đã xóa", MsgBoxStyle.Information, "Xong")
                huy()
            End If
        End If
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        loadsv()
        Form8.Show()

    End Sub
End Class