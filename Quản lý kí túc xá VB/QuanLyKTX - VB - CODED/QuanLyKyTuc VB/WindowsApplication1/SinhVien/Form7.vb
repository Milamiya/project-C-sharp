Imports System.Data
Imports System.Data.OleDb

Public Class Form7

    Dim dtpkt As New DataTable
    Dim vt As Integer

    Private Sub ThoátToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub GiớiThiệuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GiớiThiệuToolStripMenuItem.Click
        Form8.Show()

    End Sub

    Private Sub PhòngToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhòngToolStripMenuItem.Click
        Form6.Show()

    End Sub

    Private Sub KhoaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KhoaToolStripMenuItem.Click
        Form5.Show()

    End Sub

    Private Sub KýTúcToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KýTúcToolStripMenuItem.Click
        Form4.Show()

    End Sub

    Private Sub TìmKiếmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TìmKiếmToolStripMenuItem.Click
        Form9.Show()

    End Sub

    Private Sub themmkt()
        loadkt()
        Dim i As Integer
        cbomkt.Items.Clear()

        For i = 0 To ds.Tables("kytuc").Rows.Count - 1
            cbomkt.Items.Add(ds.Tables("kytuc").Rows(i).Item(0))

        Next
    End Sub

    Private Sub themgrv1(ByVal makt As String)
        dtpkt.Clear()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = " Select maphong,loaiphong from phong where maktx='" & makt & "'"
        da.SelectCommand = cmd
        da.Fill(dtpkt)

        DataGridView1.DataSource = dtpkt
    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadhs()
        DataGridView2.DataSource = ds.Tables("hoso")

        themmkt()
        DataGridView1.RowHeadersVisible = False
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ReadOnly = True

        Me.mtb1.Mask = "00/00/0000"
        Me.mtb1.ValidatingType = GetType(System.DateTime)

        Me.ToolTip1.IsBalloon = True

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

    Private Sub cbomkt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomkt.SelectedIndexChanged
        themgrv1(cbomkt.Text)
    End Sub

    Private Sub CậpNhậtDữLiệuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CậpNhậtDữLiệuToolStripMenuItem.Click
        themmkt()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim res As Long
        If vt < 0 Or cbomkt.Text = "" Or txtsp.Text = "" Or txtten.Text = "" Or cbodt.Text = "" Or cbogt.Text = "" Or cbotg.Text = "" Or txtdchi.Text = "" Or txtlop.Text = "" Or cbokh.Text = "" Then
            MsgBox("Bạn phải điền đủ thông tin")
            Exit Sub
        Else
            If checkmhs(txtsp.Text) = 0 Then
                If Date.TryParse(mtb1.Text, Nothing) Then

                    If cbogt.Text = "Nam" Then
                        addhs(txtsp.Text, txtten.Text, mtb1.Text, True, cbodt.Text, cbotg.Text, txtdchi.Text, txtlop.Text, cbokh.Text, DataGridView1.Rows(vt).Cells(0).Value)
                        MsgBox("Đã thêm hồ sơ mới", MsgBoxStyle.Information, "Chúc mừng")
                    Else
                        addhs(txtsp.Text, txtten.Text, mtb1.Text, False, cbodt.Text, cbotg.Text, txtdchi.Text, txtlop.Text, cbokh.Text, DataGridView1.Rows(vt).Cells(0).Value)
                        MsgBox("Đã thêm hồ sơ mới", MsgBoxStyle.Information, "Chúc mừng")
                    End If


                Else

                    MsgBox("Bạn phải nhập đủ thông tin")
                    Exit Sub
                End If
            Else
                If Date.TryParse(mtb1.Text, Nothing) Then
                    If cbogt.Text = "Nam" Then
                        res = MsgBox("Hồ sơ đã tồn tại, bạn xác nhận muốn sửa?", MsgBoxStyle.OkCancel, "Thông báo")
                        If res = vbOK Then
                            updhs(txtsp.Text, txtten.Text, mtb1.Text, True, cbodt.Text, cbotg.Text, txtdchi.Text, txtlop.Text, cbokh.Text, DataGridView1.Rows(vt).Cells(0).Value)
                            MsgBox("Đã sửa hồ sơ", MsgBoxStyle.Information, "Chúc mừng")
                            huy()

                        Else : res = vbCancel

                            huy()

                        End If
                        
                    Else
                        res = MsgBox("Hồ sơ đã tồn tại, bạn xác nhận muốn sửa?", MsgBoxStyle.OkCancel, "Thông báo")
                        If res = vbOK Then
                            updhs(txtsp.Text, txtten.Text, mtb1.Text, False, cbodt.Text, cbotg.Text, txtdchi.Text, txtlop.Text, cbokh.Text, DataGridView1.Rows(vt).Cells(0).Value)
                            MsgBox("Đã sửa hồ sơ", MsgBoxStyle.Information, "Chúc mừng")
                            huy()

                        Else : res = vbCancel

                            huy()

                        End If
                    End If
                Else

                    MsgBox("Bạn phải nhập đủ thông tin")
                    Exit Sub
                End If
            End If
            huy()

        End If

    End Sub

    Private Sub huy()

        cbomkt.ResetText()
        txtsp.Clear()
        txtten.Clear()
        mtb1.Clear()
        cbotg.ResetText()
        cbodt.ResetText()
        cbodt.ResetText()
        txtlop.Clear()
        cbokh.ResetText()

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        vt = DataGridView1.CurrentCell.RowIndex
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If checkmhs(txtsp.Text) = 0 Then
            MsgBox("Hồ sơ không tồn tại", MsgBoxStyle.Information, "Lỗi")
        Else
            delhs(txtsp.Text)
            MsgBox("Đã xóa", MsgBoxStyle.Information, "Lỗi")
            huy()
        End If
    End Sub
End Class