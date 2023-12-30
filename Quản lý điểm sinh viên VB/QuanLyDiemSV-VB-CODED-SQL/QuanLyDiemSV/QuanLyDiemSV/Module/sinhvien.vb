Imports System.Data
Imports System.Data.SqlClient

Module sinhvien

    Public Sub loadsv()

        ds.Tables("sinhvien").Clear()

        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from sinhvien"
        da.SelectCommand = cmd
        da.Fill(ds.Tables("sinhvien"))
    End Sub

    Public Sub loadsvnam()

        ds.Tables("sinhviennam").Clear()

        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from sinhvien where PHAI='NAM'"
        da.SelectCommand = cmd
        da.Fill(ds.Tables("sinhviennam"))
    End Sub

    Public Sub loadsvnu(ByVal str As String)

        ds.Tables("sinhviennu").Clear()

        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from sinhvien where PHAI=@phai"
        cmd.Parameters.Add("@phai", SqlDbType.NVarChar).Value = str
        da.SelectCommand = cmd
        da.Fill(ds.Tables("sinhviennu"))
    End Sub

    Public Sub addsv(ByVal masv As String, ByVal hosv As String, ByVal tensv As String, ByVal ngaysinh As Date, ByVal phai As String, ByVal makhoa As String)

        Dim row As DataRow = ds.Tables("sinhvien").NewRow()

        row("MASV") = masv
        row("HOSV") = hosv
        row("TENSV") = tensv
        row("NGAYSINH") = ngaysinh
        row("PHAI") = phai
        row("MAKHOA") = makhoa

        ds.Tables("sinhvien").Rows.Add(row)

        Dim cmdi As New SqlCommand

        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = "insert into sinhvien values(@masv,@hosv,@tensv,@ngaysinh,@phai,@makhoa)"
        cmdi.Parameters.Add("@masv", SqlDbType.NVarChar).Value = masv
        cmdi.Parameters.Add("@hosv", SqlDbType.NVarChar).Value = hosv
        cmdi.Parameters.Add("@tensv", SqlDbType.NVarChar).Value = tensv
        cmdi.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh
        cmdi.Parameters.Add("@phai", SqlDbType.NVarChar).Value = phai
        cmdi.Parameters.Add("@makhoa", SqlDbType.NVarChar).Value = makhoa

        da.InsertCommand = cmdi

        da.Update(ds.Tables("sinhvien"))

    End Sub

    Public Sub updsv(ByVal masv As String, ByVal hosv As String, ByVal tensv As String, ByVal ngaysinh As Date, ByVal phai As String, ByVal makhoa As String)

        Dim row As DataRow = ds.Tables("sinhvien").Select("MASV='" & masv & "'")(0)

        row.BeginEdit()

        row("HOSV") = hosv
        row("TENSV") = tensv
        row("NGAYSINH") = ngaysinh
        row("PHAI") = phai
        row("MAKHOA") = makhoa

        row.EndEdit()

        Dim cmdi As New SqlCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = " update sinhvien set HOSV=@hosv,TENSV=@tensv,NGAYSINH=@ngaysinh,PHAI=@phai,MAKHOA=@makhoa where MASV=@masv"

        cmdi.Parameters.Add("@hosv", SqlDbType.NVarChar).Value = hosv
        cmdi.Parameters.Add("@tensv", SqlDbType.NVarChar).Value = tensv
        cmdi.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh
        cmdi.Parameters.Add("@phai", SqlDbType.NVarChar).Value = phai
        cmdi.Parameters.Add("@makhoa", SqlDbType.NVarChar).Value = makhoa
        cmdi.Parameters.Add("@masv", SqlDbType.NVarChar).Value = masv

        da.UpdateCommand = cmdi
        da.Update(ds.Tables("sinhvien"))

    End Sub

    Public Sub delsv(ByVal masv As String)

        Dim row As DataRow = ds.Tables("sinhvien").Select("MASV='" & masv & "'")(0)

        row.BeginEdit()
        row.Delete()
        row.EndEdit()

        Dim cmdi As New SqlCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = " delete from sinhvien where MASV=@masv"
        cmdi.Parameters.Add("@masv", SqlDbType.NVarChar).Value = masv
        da.DeleteCommand = cmdi
        da.Update(ds.Tables("sinhvien"))

    End Sub

    Public Function checksv(ByVal masv As String) As Integer

        Dim oledb As New SqlCommand("Select count(*) from sinhvien where MASV='" & masv & "'", con)
        Return oledb.ExecuteScalar()

    End Function

    Public Function ngaysinhsv(ByVal masv As String) As Date

        Dim oledb As New SqlCommand("Select NGAYSINH from sinhvien where MASV='" & masv & "'", con)
        Return oledb.ExecuteScalar()

    End Function

    Public Function hotensv(ByVal masv As String) As String

        Dim oledb As New SqlCommand("Select HOSV,TENSV from sinhvien where MASV='" & masv & "'", con)
        Return oledb.ExecuteScalar()

    End Function

    Public Function khoasv(ByVal masv As String) As String

        Dim oledb As New SqlCommand("Select MAKHOA from sinhvien where MASV='" & masv & "'", con)
        Return oledb.ExecuteScalar()

    End Function

End Module
