Imports System.Data
Imports System.Data.OleDb

Module hoso
    Public Sub loadhs()

        ds.Tables("hoso").Clear()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from hoso"
        da.SelectCommand = cmd
        da.Fill(ds.Tables("hoso"))

    End Sub

    Public Sub addhs(ByVal mahs As String, ByVal ten As String, ByVal ngaysinh As Date, ByVal gioitinh As Boolean, ByVal dantoc As String, ByVal tongiao As String, ByVal thuongtru As String, ByVal lop As String, ByVal makhoa As String, ByVal maphong As String)

        Dim row As DataRow = ds.Tables("hoso").NewRow()

        row("mahs") = mahs
        row("ten") = ten
        row("ngaysinh") = ngaysinh
        row("gioitinh") = gioitinh
        row("dantoc") = dantoc

        row("tongiao") = tongiao
        row("thuongtru") = thuongtru
        row("lop") = lop
        row("makhoa") = makhoa
        row("maphong") = maphong


        ds.Tables("hoso").Rows.Add(row)

        Dim cmdi As New OleDbCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = "insert into hoso values(@mahs,@ten,@ngaysinh,@gioitinh,@dantoc,@tongiao,@thuongtru,@lop,@makhoa,@maphong)"
        cmdi.Parameters.Add("@mahs", OleDbType.VarChar).Value = mahs
        cmdi.Parameters.Add("@ten", OleDbType.VarChar).Value = ten
        cmdi.Parameters.Add("@ngaysinh", OleDbType.Date).Value = ngaysinh
        cmdi.Parameters.Add("@gioitinh", OleDbType.Boolean).Value = gioitinh
        cmdi.Parameters.Add("@dantoc", OleDbType.VarChar).Value = dantoc
        cmdi.Parameters.Add("@tongiao", OleDbType.VarChar).Value = tongiao
        cmdi.Parameters.Add("@thuongtru", OleDbType.VarChar).Value = thuongtru
        cmdi.Parameters.Add("@lop", OleDbType.VarChar).Value = lop
        cmdi.Parameters.Add("@makhoa", OleDbType.VarChar).Value = makhoa
        cmdi.Parameters.Add("@maphong", OleDbType.VarChar).Value = maphong

        da.InsertCommand = cmdi

        da.Update(ds.Tables("hoso"))
    End Sub

    Public Sub updhs(ByVal mahs As String, ByVal ten As String, ByVal ngaysinh As Date, ByVal gioitinh As Boolean, ByVal dantoc As String, ByVal tongiao As String, ByVal thuongtru As String, ByVal lop As String, ByVal makhoa As String, ByVal maphong As String)

        Dim row As DataRow = ds.Tables("hoso").Select("mahs='" & mahs & "'")(0)

        row.BeginEdit()
        row("ten") = ten
        row("ngaysinh") = ngaysinh
        row("gioitinh") = gioitinh
        row("dantoc") = dantoc

        row("tongiao") = tongiao
        row("thuongtru") = thuongtru
        row("lop") = lop
        row("makhoa") = makhoa
        row("maphong") = maphong
        row.EndEdit()

        Dim cmdi As New OleDbCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = " update hoso set ten=@ten,ngaysinh=@ngaysinh,gioitinh=@gioitinh,dantoc=@dantoc,tongiao=@tongiao,thuongtru=@thuongtru,lop=@lop,makhoa=@makhoa,maphong=@maphong where mahs=@mahs"

        cmdi.Parameters.Add("@ten", OleDbType.VarChar).Value = ten
        cmdi.Parameters.Add("@ngaysinh", OleDbType.Date).Value = ngaysinh
        cmdi.Parameters.Add("@gioitinh", OleDbType.Boolean).Value = gioitinh
        cmdi.Parameters.Add("@dantoc", OleDbType.VarChar).Value = dantoc
        cmdi.Parameters.Add("@tongiao", OleDbType.VarChar).Value = tongiao
        cmdi.Parameters.Add("@thuongtru", OleDbType.VarChar).Value = thuongtru
        cmdi.Parameters.Add("@lop", OleDbType.VarChar).Value = lop
        cmdi.Parameters.Add("@makhoa", OleDbType.VarChar).Value = makhoa
        cmdi.Parameters.Add("@maphong", OleDbType.VarChar).Value = maphong
        cmdi.Parameters.Add("@mahs", OleDbType.VarChar).Value = mahs

        da.UpdateCommand = cmdi
        da.Update(ds.Tables("hoso"))

    End Sub

    Public Sub delhs(ByVal mahs As String)

        Dim row As DataRow = ds.Tables("hoso").Select("mahs='" & mahs & "'")(0)

        row.BeginEdit()
        row.Delete()
        row.EndEdit()

        Dim cmdi As New OleDbCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = " delete from hoso where mahs=@mahs"
        cmdi.Parameters.Add("@mahs", OleDbType.VarChar).Value = mahs

        da.DeleteCommand = cmdi
        da.Update(ds.Tables("hoso"))

    End Sub

    Public Function checkmhs(ByVal mhs As String) As Integer

        Dim oledbcom As New OleDbCommand("select count(*) from hoso where mahs='" & mhs & "'", con)

        Return oledbcom.ExecuteScalar()

    End Function
End Module
