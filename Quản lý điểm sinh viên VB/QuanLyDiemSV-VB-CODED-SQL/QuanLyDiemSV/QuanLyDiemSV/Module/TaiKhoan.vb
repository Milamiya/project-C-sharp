' Mỗi một bảng sẽ tạo 1 module, tất cả các thao tác dữ liệu liên quan đến bảng đó được đưa vào module cùng tên
' Mục đích tiện quản lý và chỉnh sửa code.
Imports System.Data
Imports System.Data.SqlClient

Module Taikhoan

    Public Sub loadtk()

        ds.Tables("taikhoan").Clear()

        Dim cmd As New sqlcommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from taikhoan"
        da.SelectCommand = cmd
        da.Fill(ds.Tables("taikhoan"))

    End Sub

    Public Function tktt(ByVal uid As String) As Integer
        Dim oledbcom As New sqlcommand("select count(*) from taikhoan where uid='" & uid & "'", con)

        Return oledbcom.ExecuteScalar()
    End Function

    Public Function checktk(ByVal a As String) As String

        Dim oledbcom As New sqlcommand("select pss from taikhoan where uid='" & a & "'", con)

        Return oledbcom.ExecuteScalar()

    End Function

    Public Function checkuqes(ByVal a As String) As String

        Dim oledbcom As New sqlcommand("select uqes from taikhoan where uid='" & a & "'", con)

        Return oledbcom.ExecuteScalar()

    End Function

    Public Function checkpss2(ByVal a As String) As String

        Dim oledbcom As New SqlCommand("select pss2 from taikhoan where uid='" & a & "'", con)

        Return oledbcom.ExecuteScalar()

    End Function

    Public Function checkuans(ByVal a As String) As String

        Dim oledbcom As New SqlCommand("select uans from taikhoan where uid='" & a & "'", con)

        Return oledbcom.ExecuteScalar()

    End Function


    Public Sub resetpss(ByVal id As String, ByVal pss As String)
        Dim row As DataRow = ds.Tables("taikhoan").Select("uid = '" & id & "'")(0)

        row.BeginEdit()
        row("pss") = pss
        row.EndEdit()

        Dim commandUpdate As New SqlCommand()
        commandUpdate.Connection = con
        commandUpdate.CommandType = CommandType.Text

        commandUpdate.CommandText = "Update taikhoan Set pss=@pss Where uid=@uid"

        commandUpdate.Parameters.Add("@pss", SqlDbType.NVarChar).Value = pss
        commandUpdate.Parameters.Add("@uid", SqlDbType.VarChar).Value = id

        da.UpdateCommand = commandUpdate

        da.Update(ds.Tables("taikhoan"))
    End Sub

    Public Sub addtk(ByVal id As String, ByVal pss As String, ByVal pss2 As String, ByVal uqes As String, ByVal uans As String, ByVal utype As Boolean)

        Dim row As DataRow = ds.Tables("taikhoan").NewRow()
        row("uid") = id
        row("pss") = pss
        row("pss2") = pss2
        row("utype") = utype
        row("uqes") = uqes
        row("uans") = uans
        ds.Tables("taikhoan").Rows.Add(row)

        Dim cmdin As New SqlCommand
        cmdin.Connection = con
        cmdin.CommandType = CommandType.Text
        cmdin.CommandText = "Insert into taikhoan values (@uid,@pss,@pss2,@uqes,@uans,@utype)"
        cmdin.Parameters.Add("@uid", SqlDbType.VarChar).Value = id
        cmdin.Parameters.Add("@pss", SqlDbType.NVarChar).Value = pss
        cmdin.Parameters.Add("@pss2", SqlDbType.NVarChar).Value = pss2

        cmdin.Parameters.Add("@uqes", SqlDbType.NVarChar).Value = uqes
        cmdin.Parameters.Add("@uans", SqlDbType.NVarChar).Value = uans
        cmdin.Parameters.Add("@utype", SqlDbType.TinyInt).Value = utype
        da.InsertCommand = cmdin
        da.Update(ds.Tables("taikhoan"))

    End Sub

End Module
