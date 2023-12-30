Imports System.Data
Imports System.Data.OleDb
Public Class Form6

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        loadphong()
        DataGridView1.DataSource = ds.Tables("phong")
        themmkt()

    End Sub

    Private Sub themmkt()
        loadkt()
        Dim i As Integer
        cbomkt.Items.Clear()

        For i = 0 To ds.Tables("kytuc").Rows.Count - 1
            cbomkt.Items.Add(ds.Tables("kytuc").Rows(i).Item(0))

        Next
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim res As Long
        If cbomkt.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Bạn cần nhập đủ thông tin", MsgBoxStyle.Information, "Thông Báo")
        Else
            If ComboBox1.Text = "Nam" Then
                If checkphong(TextBox2.Text, cbomkt.Text) = 0 Then



                    addphong(TextBox2.Text, cbomkt.Text, True)

                    Exit Sub
                Else
                    res = MsgBox("Đã tồn tại, bạn muốn sủa không", MsgBoxStyle.OkCancel, "thông báo")
                    If res = vbOK Then
                        updphong(TextBox2.Text, cbomkt.Text, True)

                    Else : res = vbCancel

                    End If
                End If
            Else
                If ComboBox1.Text = "Nữ" Then
                    If checkphong(TextBox2.Text, cbomkt.Text) = 0 Then



                        addphong(TextBox2.Text, cbomkt.Text, False)

                        Exit Sub
                    Else
                        res = MsgBox("Đã tồn tại, bạn muốn sủa không", MsgBoxStyle.OkCancel, "thông báo")
                        If res = vbOK Then
                            updphong(TextBox2.Text, cbomkt.Text, False)

                        Else : res = vbCancel

                        End If
                    End If
                End If
            End If
            
        End If
        
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If checkphong(TextBox2.Text, cbomkt.Text) = 0 Then
            MsgBox("Không có mã  này , không xóa được", MsgBoxStyle.Information, "Thông báo")
        Else
            xoaphong(TextBox2.Text, cbomkt.Text)

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

End Class