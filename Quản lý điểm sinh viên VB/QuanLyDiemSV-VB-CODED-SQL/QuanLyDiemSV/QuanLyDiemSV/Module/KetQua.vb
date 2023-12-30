Imports System.Data
Imports System.Data.SqlClient

Module KetQua

    Public Sub loadkq(ByVal masv As String)

        ds.Tables("ketqua").Clear()

        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from ketqua where MASV=@masv"
        cmd.Parameters.Add("@masv", SqlDbType.NVarChar).Value = masv

        da.SelectCommand = cmd
        da.Fill(ds.Tables("ketqua"))
    End Sub

    Public Sub addkq(ByVal masv As String, ByVal mamh As String, ByVal lanthi As Integer, ByVal diem As Decimal)

        Dim row As DataRow = ds.Tables("ketqua").NewRow()

        row("MASV") = masv
        row("MAMH") = mamh
        row("LANTHI") = lanthi
        row("DIEM") = diem

        ds.Tables("ketqua").Rows.Add(row)

        Dim cmdi As New SqlCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = "insert into ketqua values(@masv,@mamh,@lanthi,@diem)"
        cmdi.Parameters.Add("@masv", SqlDbType.NVarChar).Value = masv
        cmdi.Parameters.Add("@mamh", SqlDbType.NVarChar).Value = mamh
        cmdi.Parameters.Add("@lanthi", SqlDbType.Int).Value = lanthi
        cmdi.Parameters.Add("@diem", SqlDbType.Decimal).Value = diem

        da.InsertCommand = cmdi

        da.Update(ds.Tables("ketqua"))

    End Sub

    Public Sub updkq(ByVal masv As String, ByVal mamh As String, ByVal lanthi As Integer, ByVal diem As Decimal)

        Dim row As DataRow = ds.Tables("ketqua").Select("MASV='" & masv & "' and MAMH='" & mamh & "' and LANTHI='" & Convert.ToInt32(lanthi) & "'")(0)

        row.BeginEdit()

        row("DIEM") = diem

        row.EndEdit()

        Dim cmdi As New SqlCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = " update ketqua set DIEM=@diem where MASV=@masv and MAMH=@mamh and LANTHI=@lanthi"

        cmdi.Parameters.Add("@diem", SqlDbType.Decimal).Value = diem
        cmdi.Parameters.Add("@masv", SqlDbType.NVarChar).Value = masv
        cmdi.Parameters.Add("@mamh", SqlDbType.NVarChar).Value = mamh
        cmdi.Parameters.Add("@lanthi", SqlDbType.Int).Value = lanthi

        da.UpdateCommand = cmdi
        da.Update(ds.Tables("ketqua"))

    End Sub

    Public Sub delkq(ByVal masv As String, ByVal mamh As String, ByVal lanthi As Integer)

        Dim row As DataRow = ds.Tables("ketqua").Select("MASV='" & masv & "' and MAMH='" & mamh & "' and LANTHI='" & lanthi & "'")(0)

        row.BeginEdit()
        row.Delete()
        row.EndEdit()

        Dim cmdi As New SqlCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = " delete from ketqua where MASV=@masv and MAMH=@mamh and LANTHI=@lanthi"
        cmdi.Parameters.Add("@masv", SqlDbType.NVarChar).Value = masv
        cmdi.Parameters.Add("@mamh", SqlDbType.NVarChar).Value = mamh
        cmdi.Parameters.Add("@lanthi", SqlDbType.Int).Value = lanthi

        da.DeleteCommand = cmdi
        da.Update(ds.Tables("ketqua"))

    End Sub

    Public Sub delkqsv(ByVal masv As String)

        Dim row As DataRow = ds.Tables("ketqua").Select("MASV='" & masv & "'")(0)

        row.BeginEdit()
        row.Delete()
        row.EndEdit()

        Dim cmdi As New SqlCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = " delete from ketqua where MASV=@masv"
        cmdi.Parameters.Add("@masv", SqlDbType.NVarChar).Value = masv

        da.DeleteCommand = cmdi
        da.Update(ds.Tables("ketqua"))

    End Sub

    Public Function checkkq(ByVal masv As String, ByVal mamh As String, ByVal lanthi As Integer) As Integer

        Dim oledb As New SqlCommand("Select count(*) from ketqua where MASV='" & masv & "' and MAMH='" & mamh & "' and LANTHI='" & lanthi & "'", con)
        Return oledb.ExecuteScalar()

    End Function

End Module
