Imports System.Data
Imports System.Data.OleDb

Module Login

    Public Sub loadtk()

        ds.Tables("taikhoan").Clear()

        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from taikhoan"
        da.SelectCommand = cmd

        da.Fill(ds.Tables("taikhoan"))

    End Sub

    Public Function checktk(ByVal a As String) As String

        Dim oledbcom As New OleDbCommand("select pss from taikhoan where uid='" & a & "'", con)

        Return oledbcom.ExecuteScalar()

    End Function

    Public Function checkuqes(ByVal a As String) As String

        Dim oledbcom As New OleDbCommand("select uqes from taikhoan where uid='" & a & "'", con)

        Return oledbcom.ExecuteScalar()

    End Function

    Public Function checkpss2(ByVal a As String) As String

        Dim oledbcom As New OleDbCommand("select pss2 from taikhoan where uid='" & a & "'", con)

        Return oledbcom.ExecuteScalar()

    End Function

    Public Function checkuans(ByVal a As String) As String

        Dim oledbcom As New OleDbCommand("select uans from taikhoan where uid='" & a & "'", con)

        Return oledbcom.ExecuteScalar()

    End Function

    Public Sub resetpss(ByVal id As String, ByVal pss As String)

        Dim row As DataRow = ds.Tables("taikhoan").Select("uid = '" & id & "'")(0)

        row.BeginEdit()
        row("pss") = pss
        row.EndEdit()

        Dim commandUpdate As New OleDbCommand()

        commandUpdate.Connection = con
        commandUpdate.CommandType = CommandType.Text
        commandUpdate.CommandText = "Update taikhoan Set pss=@pss Where uid=@uid"
        commandUpdate.Parameters.Add("@pss", OleDbType.VarChar).Value = pss
        commandUpdate.Parameters.Add("@uid", OleDbType.VarChar).Value = id

        da.UpdateCommand = commandUpdate
        da.Update(ds.Tables("taikhoan"))
    End Sub

    Public Sub addtk(ByVal id As String, ByVal pss As String, ByVal pss2 As String, ByVal uqes As String, ByVal uans As String)

        Dim row As DataRow = ds.Tables("taikhoan").NewRow()
        row("uid") = id
        row("pss") = pss
        row("pss2") = pss2
        row("uqes") = uqes
        row("uans") = uans
        row("utype") = 0
        ds.Tables("taikhoan").Rows.Add(row)

        Dim cmdin As New OleDbCommand
        cmdin.Connection = con
        cmdin.CommandType = CommandType.Text
        cmdin.CommandText = "Insert into taikhoan values (@uid,@pss,@pss2,@uqes,@uans,@utype)"
        cmdin.Parameters.Add("@uid", OleDbType.VarChar).Value = id
        cmdin.Parameters.Add("@pss", OleDbType.VarChar).Value = pss
        cmdin.Parameters.Add("@pss2", OleDbType.VarChar).Value = pss2
        cmdin.Parameters.Add("@uqes", OleDbType.VarChar).Value = uqes
        cmdin.Parameters.Add("@uans", OleDbType.VarChar).Value = uans
        cmdin.Parameters.Add("@utype", OleDbType.Boolean).Value = 0
        da.InsertCommand = cmdin
        da.Update(ds.Tables("taikhoan"))

    End Sub

End Module