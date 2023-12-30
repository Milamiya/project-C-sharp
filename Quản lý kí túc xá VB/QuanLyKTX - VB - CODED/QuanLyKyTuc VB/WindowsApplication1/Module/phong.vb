Imports System.Data
Imports System.Data.OleDb

Module phong

    Public Sub loadphong()

        ds.Tables("phong").Clear()

        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from phong"
        da.SelectCommand = cmd
        da.Fill(ds.Tables("phong"))

    End Sub

    Public Sub loadphongtkt(ByVal makt As String)

        ds.Tables("phongtkt").Clear()

        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from phong where maktx='" & makt & "'"
        da.SelectCommand = cmd

        da.Fill(ds.Tables("phongtkt"))

    End Sub

    Public Sub addphong(ByVal map As String, ByVal maktx As String, ByVal ten As Boolean)

        Dim row As DataRow = ds.Tables("phong").NewRow()

        row("maktx") = maktx
        row("maphong") = map
        row("loaiphong") = ten

        ds.Tables("phong").Rows.Add(row)

        Dim cmdi As New OleDbCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = "insert into phong values(@maktx,@maphong,@loaiphong)"

        cmdi.Parameters.Add("@maktx", OleDbType.VarChar).Value = maktx
        cmdi.Parameters.Add("@maphong", OleDbType.VarChar).Value = map
        cmdi.Parameters.Add("@loaiphong", OleDbType.Boolean).Value = ten


        da.InsertCommand = cmdi

        da.Update(ds.Tables("phong"))
    End Sub

    Public Sub updphong(ByVal map As String, ByVal maktx As String, ByVal ten As Boolean)

        Dim row As DataRow = ds.Tables("phong").Select("maktx='" & maktx & "' and maphong='" & map & "'")(0)

        row.BeginEdit()
        row("loaiphong") = ten
        row.EndEdit()

        Dim cmdi As New OleDbCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = " update phong set loaiphong=@loaiphong where maktx=@maktx and maphong=@maphong"

        cmdi.Parameters.Add("@loaiphong", OleDbType.Boolean).Value = ten
        cmdi.Parameters.Add("@maktx", OleDbType.VarChar).Value = maktx
        cmdi.Parameters.Add("@maphong", OleDbType.VarChar).Value = map

        da.UpdateCommand = cmdi
        da.Update(ds.Tables("phong"))

    End Sub

    Public Sub xoaphong(ByVal map As String, ByVal maktx As String)

        Dim row As DataRow = ds.Tables("phong").Select("maktx='" & maktx & "' and maphong='" & map & "'")(0)

        row.BeginEdit()
        row.Delete()
        row.EndEdit()

        Dim cmdi As New OleDbCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = " delete from phong where maktx=@maktx and maphong=@maphong"

        cmdi.Parameters.Add("@maktx", OleDbType.VarChar).Value = maktx
        cmdi.Parameters.Add("@maphong", OleDbType.VarChar).Value = map

        da.DeleteCommand = cmdi
        da.Update(ds.Tables("phong"))

    End Sub
  

    Public Function checkphong(ByVal map As String, ByVal maktx As String) As Integer

        Dim oledbcom As New OleDbCommand("select count(*) from phong where maktx='" & maktx & "' and maphong='" & map & "'", con)
        oledbcom.Parameters.Add("@maktx", OleDbType.VarChar).Value = maktx
        oledbcom.Parameters.Add("@maphong", OleDbType.VarChar).Value = map


        Return oledbcom.ExecuteScalar()

    End Function

End Module
