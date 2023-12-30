Public Class MainForm

    Private Sub SinhViênToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SinhViênToolStripMenuItem.Click
        Form4.Show()

    End Sub

    Private Sub MônHọcToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MônHọcToolStripMenuItem.Click
        Form3.Show()

    End Sub

    Private Sub KhoaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KhoaToolStripMenuItem.Click
        Form2.Show()

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

    Private Sub themmh()
        loadmh()
        Dim i As Integer
        cbomm.Items.Clear()
        For i = 0 To ds.Tables("monhoc").Rows.Count - 1
            cbomm.Items.Add(ds.Tables("monhoc").Rows(i).Item(0))

        Next
    End Sub

    Public Sub reloadall()
        loadsv()
        dgv1.DataSource = ds.Tables("sinhvien")
        themmh()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadsv()
        dgv1.DataSource = ds.Tables("sinhvien")
        themmh()
        dgv1.ReadOnly = True
        dgv1.Columns(1).Visible = False
        dgv1.Columns(2).Visible = False
        dgv1.Columns(3).Visible = False
        dgv1.Columns(4).Visible = False
        dgv1.Columns(5).Visible = False
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

        dgv2.ReadOnly = True
        dgv2.AllowUserToAddRows = False
        dgv2.AllowUserToDeleteRows = False
        dgv2.RowHeadersVisible = False
        dgv2.AllowUserToResizeColumns = False
        dgv2.AllowUserToResizeRows = False
        dgv2.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        dgv2.DefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        dgv2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        

    End Sub

    Private Sub cbomm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomm.SelectedIndexChanged
        txttenm.Text = tenmh(cbomm.Text)

    End Sub

    Private Sub dgv1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellClick
        dgv2.Refresh()

        loadkq(dgv1.CurrentCell.Value)
        dgv2.DataSource = ds.Tables("ketqua")
        dgv2.Columns(0).Visible = False
        dgv2.Columns(1).HeaderText = "Mã môn"
        dgv2.Columns(2).HeaderText = "Lần thi"
        dgv2.Columns(3).HeaderText = "Điểm"
        dgv2.Columns(1).Width = 150
        dgv2.Columns(2).Width = 150
        dgv2.Columns(3).Width = 100

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim res As Long
        If txtlt.Text = "" Or txtd.Text = "" Or cbomm.Text = "" Then
            MsgBox("Bạn cần nhập đủ thông tin", MsgBoxStyle.Information, "Thông Báo")
        Else
            If checkkq(dgv1.CurrentCell.Value, cbomm.Text, Convert.ToInt32(txtlt.Text)) = 0 Then
                addkq(dgv1.CurrentCell.Value, cbomm.Text, Convert.ToInt32(txtlt.Text), Convert.ToDecimal(txtd.Text))
                MsgBox("Đã thêm kết quả mới", MsgBoxStyle.Information, "Thông Báo")
                Exit Sub
            Else
                res = MsgBox("Đã tồn tại, bạn muốn sửa không", MsgBoxStyle.OkCancel, "Thông báo")
                If res = vbOK Then
                    updkq(dgv1.CurrentCell.Value, cbomm.Text, Convert.ToInt32(txtlt.Text), Convert.ToDecimal(txtd.Text))
                   
                Else : res = vbCancel
                    
                End If
            End If
        End If
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThoátToolStripMenuItem.Click
        con.Close()
        Close()

    End Sub

    Private Sub GiớiThiệuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GiớiThiệuToolStripMenuItem.Click
        Form5.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If checkkq(dgv1.CurrentCell.Value, cbomm.Text, Convert.ToInt32(txtlt.Text)) = 0 Then
            MsgBox("Dữ liệu không trùng khớp, không thể xóa", MsgBoxStyle.Information, "Thông báo")
        Else
            delkq(dgv1.CurrentCell.Value, cbomm.Text, Convert.ToInt32(txtlt.Text))
            MsgBox("Đã xóa", MsgBoxStyle.Information, "Thông báo")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            loadkq(dgv1.CurrentCell.Value)
        Catch ex As Exception
            Exit Sub

        End Try
        Form9.Show()

    End Sub
End Class