Imports System.Data
Imports System.Data.OleDb

Module kytuc

    Public Sub loadkt()

        ds.Tables("kytuc").Clear()

        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from kytucxa"
        da.SelectCommand = cmd
        da.Fill(ds.Tables("kytuc"))

    End Sub

    Public Sub addkt(ByVal makt As String, ByVal ten As String)

        Dim row As DataRow = ds.Tables("kytuc").NewRow()

        row("maktx") = makt
        row("tenktx") = ten
        

        ds.Tables("kytuc").Rows.Add(row)

        Dim cmdi As New OleDbCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = "insert into kytucxa values(@maktx,@tenktx)"
        cmdi.Parameters.Add("@maktx", OleDbType.VarChar).Value = makt
        cmdi.Parameters.Add("@tenktx", OleDbType.VarChar).Value = ten

        da.InsertCommand = cmdi

        da.Update(ds.Tables("kytuc"))
    End Sub

    Public Sub updkt(ByVal makt As String, ByVal ten As String)

        Dim row As DataRow = ds.Tables("kytuc").Select("maktx='" & makt & "'")(0)

        row.BeginEdit()
        row("tenktx") = ten
        row.EndEdit()

        Dim cmdi As New OleDbCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = " update kytucxa set tenktx=@tenktx where maktx=@maktx"

        cmdi.Parameters.Add("@tenktx", OleDbType.VarChar).Value = ten
        cmdi.Parameters.Add("@maktx", OleDbType.VarChar).Value = makt

        da.UpdateCommand = cmdi
        da.Update(ds.Tables("kytuc"))

    End Sub

    Public Sub delkt(ByVal a As String)

        Dim row As DataRow = ds.Tables("kytuc").Select("maktx='" & a & "'")(0)

        row.BeginEdit()
        row.Delete()
        row.EndEdit()

        Dim cmdi As New OleDbCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = " delete from kytucxa where maktx=@maktx"
        cmdi.Parameters.Add("@maktx", OleDbType.VarChar).Value = a

        da.DeleteCommand = cmdi
        da.Update(ds.Tables("kytuc"))

    End Sub

    Public Function checkmkt(ByVal a As String) As Integer

        Dim oledbcom As New OleDbCommand("select count(*) from kytucxa where maktx='" & a & "'", con)

        Return oledbcom.ExecuteScalar()

    End Function
End Module
