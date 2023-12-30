Attribute VB_Name = "mdlOpen"
Option Explicit
Public Flag As Boolean
Public cn As ADODB.Connection
'-----------------------------------------
Type ChonThuoc
    MaThuoc As String
    TenThuoc As String
    SoLuong As Long
    DonGia As Currency
    LieuDung As String
    MaDonThuoc As String
End Type

Public Sub OpenConnection()
    ' Tao ket noi den nguon co so du lieu
    Set cn = New ADODB.Connection
    cn.Provider = "SQLOLEDB.1;"
    cn.ConnectionString = " Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BENHNHAN"
    cn.Open
End Sub
Public Function Kt_Text(SQL As String) As Boolean
    ' Kiem tra xem mot ban tin da ton tai hay chua
    Dim rs As ADODB.Recordset
    Set rs = cn.Execute(SQL)
    Kt_Text = rs.EOF
End Function

Public Function SuLiChuoi(Str As String) As String
    'Tra ve mot chuoi da xu li (Chu cai dau cua moi tu viet hoa)
    Dim i%, Tam$
    Str = " " + Str
    i = 2
    Tam = ""
    Do While Len(Str) >= i
        If Mid$(Str, i, 1) = " " And Mid$(Str, i + 1, 1) = " " Then
        Else
            If Mid$(Str, i - 1, 1) = " " Then
                Select Case Mid$(Str, i, 1)
                    Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
                        Tam = Tam + Mid$(Str, i, 1)
                    Case Else
                        Tam = Tam + UCase(Mid$(Str, i, 1))
                End Select
             Else
                Tam = Tam + Mid$(Str, i, 1)
            End If
        End If
        i = i + 1
    Loop
    Tam = Trim(Tam)
    SuLiChuoi = Tam
End Function

Public Sub KiemTraText(Key As Integer, TieuChi As Boolean)
    'Cam mot so phim
    Select Case Key
        Case Asc("0") To Asc("9")
        Case Else
            If TieuChi = True Then
                If (Key <> 8) And (Key <> 46) Then
                    Beep
                    Key = 0
                End If
            Else
                If (Key <> 8) Then
                    Beep
                    Key = 0
               End If
           End If
    End Select
End Sub
Public Function SuLiNgay(strNgay As String) As String
    ' Kiem tra mot ngay duoc nhap vao co hop le khong
    Dim dNgay$, Ngay$, Thang$, Nam$, Tam$
    Dim NamNhap%, NgayHienTai$, NamHienTai%
    dNgay = Replace(strNgay, "_", "0")
    Ngay = Mid$(dNgay, 1, 2)
    Thang = Mid$(dNgay, 4, 2)
    Nam = Mid$(dNgay, 7, 4)
    Tam = dNgay
    If Str(Nam) < 1800 Then
        Tam = "NotOK"
    End If
    If (Str(Thang) > 12) Or (Str(Thang) < 1) Then
        Tam = "NotOK"
    Else
        Select Case Thang
            Case "01", "03", "05", "07", "08", "10", "12"
                 If (Str(Ngay) > 31) Or (Str(Ngay) < 1) Then
                    Tam = "NotOK"
                 End If
            Case "04", "06", "09", "11"
                If (Str(Ngay) > 30) Or (Str(Ngay) < 1) Then
                    Tam = "NotOK"
                End If
            Case "02"
                If (Str(Ngay) > 29) Or (Str(Ngay) < 1) Then
                    Tam = "NotOK"
                End If
        End Select
    End If
    SuLiNgay = Tam
End Function

Public Function SuLiNgaySinh(strNgay As String, Ai As String) As String
    ' Xu li xem ngay thang nam sinh cua benh nhan hoac nhan vien
    ' co thoa dieu kien thuc te khong
    Dim dNgay$, Ngay$, Thang$, Nam$, Tam$
    Dim NamNhap%, NgayHienTai$, NamHienTai%
    dNgay = Replace(strNgay, "_", "0")
    Ngay = Mid$(dNgay, 1, 2)
    Thang = Mid$(dNgay, 4, 2)
    Nam = Mid$(dNgay, 7, 4)
    Tam = dNgay
    If (Str(Thang) > 12) Or (Str(Thang) < 1) Then
        Tam = "NotOK"
    Else
        Select Case Thang
            Case "01", "03", "05", "07", "08", "10", "12"
                 If (Str(Ngay) > 31) Or (Str(Ngay) < 0) Then
                    Tam = "NotOK"
                 End If
            Case "04", "06", "09", "11"
                If (Str(Ngay) > 30) Or (Str(Ngay) < 1) Then
                    Tam = "NotOK"
                End If
            Case "02"
                If (Str(Ngay) > 29) Or (Str(Ngay) < 1) Then
                    Tam = "NotOK"
                End If
        End Select
        If Tam = "NotOK" Then
            SuLiNgaySinh = Tam
            Exit Function
        End If
        NamNhap = Str(Nam)
        NgayHienTai = Date
        NamHienTai = Str(Mid$(NgayHienTai, 7, 4))
        If Ai = "NhanVien" Then
            If (NamHienTai - NamNhap < 18) Or (NamHienTai - NamNhap > 65) Then
                Tam = "NotOK"
            End If
        Else
            If Ai = "BenhNhan" Then
                If (Date - DateValue(dNgay) < 0) Or (NamHienTai - NamNhap > 151) Then
                    Tam = "NotOK"
                End If
            End If
        End If
    End If
    SuLiNgaySinh = Tam
End Function

Public Function KiemTraMa(Ma As String) As Boolean
    'Kiem tra ma so duoc nhap vao xem co chua khoang trang khong
    Dim Tam As Integer
    Tam = InStr(1, Ma, " ")
    If Tam > 0 Then
        KiemTraMa = False
    Else
        KiemTraMa = True
    End If
End Function
Public Function tfGT(GioiTinh As Boolean) As String
    'Ham tra ve chuoi gioi tinh
    Dim Tam$
    Select Case GioiTinh
        Case True
            Tam = "Nam"
        Case False
            Tam = "Nu"
    End Select
    tfGT = Tam
End Function

Public Function strGT(GioiTinh As String) As Boolean
    'Ham tra ve gioi tinh la true =Nam
    Dim Tam As Boolean
    Select Case GioiTinh
        Case "Nam"
            Tam = True
        Case "Nu"
            Tam = False
    End Select
    strGT = Tam
End Function

Public Sub TachHoTen(HoTen As String, Ho As String, Ten As String)
    'Dung tach chuoi ho ten nhap vao tu ban phim thanh ho va ten
    Dim i As Long
    HoTen = Trim(HoTen)
    i = InStrRev(HoTen, " ")
    Ten = Mid(HoTen, i + 1)
    
    If i <> 0 Then
        Ho = Mid(HoTen, 1, i - 1)
    Else
        Ho = ""
    End If
    Ten = SuLiChuoi(Ten)
    Ho = SuLiChuoi(Ho)
End Sub
Public Sub NhapTen(KeyAscii As Integer, laMaso As Boolean)
    If laMaso = True Then
        Select Case KeyAscii
            Case Asc("A") To Asc("Z"), Asc("a") To Asc("z"), 8
            Case Asc("0") To Asc("9")
                Beep
                KeyAscii = 0
        End Select
    Else
        Select Case KeyAscii
            Case Asc("A") To Asc("Z"), Asc("a") To Asc("z"), 8, 32
            Case Asc("0") To Asc("9")
                Beep
                KeyAscii = 0
        End Select
    End If
End Sub
