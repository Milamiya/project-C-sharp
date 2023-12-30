VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frmThongKe 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Thong ke benh nhan"
   ClientHeight    =   7560
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   8070
   Icon            =   "frmThongKe.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7560
   ScaleWidth      =   8070
   StartUpPosition =   1  'CenterOwner
   Begin VB.Frame Frame1 
      Caption         =   "Tieâu chí thoáng keâ"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2415
      Left            =   120
      TabIndex        =   1
      Top             =   5040
      Width           =   7815
      Begin VB.TextBox txtTongSo 
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   405
         Left            =   1560
         TabIndex        =   9
         Top             =   1080
         Width           =   2895
      End
      Begin VB.CommandButton cmdThoat 
         Caption         =   "Thoaùt"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   5520
         TabIndex        =   8
         Top             =   1560
         Width           =   1455
      End
      Begin VB.CommandButton cmdIn 
         Caption         =   "In"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   6480
         TabIndex        =   7
         Top             =   600
         Width           =   1215
      End
      Begin VB.CommandButton cmdOK 
         Caption         =   "OK"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   4920
         TabIndex        =   6
         Top             =   600
         Width           =   1335
      End
      Begin VB.TextBox txtNhapLieu 
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   390
         Left            =   240
         TabIndex        =   5
         Top             =   1920
         Width           =   4215
      End
      Begin VB.OptionButton opThongKeTheoDiaChi 
         Caption         =   "Thoáng keâ theo ñòa chæ"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   240
         TabIndex        =   3
         Top             =   720
         Width           =   2535
      End
      Begin VB.OptionButton opThongKeTheoBenh 
         Caption         =   "Thoáng keâ theo beänh"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   240
         TabIndex        =   2
         Top             =   360
         Width           =   2295
      End
      Begin VB.Label Label2 
         Caption         =   "Toång soá"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   240
         TabIndex        =   10
         Top             =   1080
         Width           =   1695
      End
      Begin VB.Label Label1 
         Caption         =   "Nhaäp lieäu"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   240
         TabIndex        =   4
         Top             =   1560
         Width           =   1935
      End
   End
   Begin MSComctlLib.ListView lstBenhNhan 
      Height          =   4935
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   7815
      _ExtentX        =   13785
      _ExtentY        =   8705
      View            =   3
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      GridLines       =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483647
      BorderStyle     =   1
      Appearance      =   1
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      NumItems        =   4
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Hoï teân beänh nhaân"
         Object.Width           =   4586
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Ngaøy sinh "
         Object.Width           =   2363
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Giôùi tính"
         Object.Width           =   1818
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "Thoâng tin khaùc"
         Object.Width           =   4852
      EndProperty
   End
End
Attribute VB_Name = "frmThongKe"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim MaBenh$

Private Sub cmdIn_Click()
    Dim SQL$
    Dim TenXa$, TenTinh$, TenHuyen$, DiaChi$
    Dim clTachDiaChi As New clTachDiaChi
    '-------------------------------------------
    If opThongKeTheoBenh = True Then
        SQL = "Select *  From vwThongKeTheoBenh  Where " & _
                    "MaBenh='" & MaBenh & "'"
        DE.Commands(93).CommandText = SQL
        If DE.rsSQLThongKeTheoBenh.State = 0 Then
            DE.rsSQLThongKeTheoBenh.Open
        End If
        DE.rsSQLThongKeTheoBenh.Requery
        repDanhSachBenhNhanTheoBenh.Show 1
    ElseIf opThongKeTheoDiaChi = True Then
        DiaChi = Trim(txtNhapLieu.Text)
        If DiaChi = "" Then
            MsgBox "Ban chua nhap dia chi noi can thong ke"
            Exit Sub
        Else
            clTachDiaChi.DiaChiVao DiaChi
            clTachDiaChi.TachDiaChi TenXa, TenHuyen, TenTinh
        End If
        If TenXa <> "" Then
            SQL = "Select * From vwTimBenhNhan Where " & _
                    "DiachiBenhNhan='" & TenXa & "/" & _
                    TenHuyen & "/" & TenTinh & "'"
        ElseIf TenHuyen <> "" Then
            SQL = "Select * From vwTimBenhNhan Where " & _
                    "TenHuyen='" & TenHuyen & _
                    "TenTinh='" & TenTinh & "'"
        Else
            SQL = "Select * From vwTimBenhNhan Where " & _
                    "TenTinh='" & TenTinh & "'"
        End If
        DE.Commands(92).CommandText = SQL
        If DE.rsDanhSachBenhNhan.State = 0 Then
            DE.rsDanhSachBenhNhan.Open
        End If
        DE.rsDanhSachBenhNhan.Requery
        repDanhSachBenhNhanTheoDiaChi.Show 1
    End If
End Sub

Private Sub cmdOK_Click()
    If opThongKeTheoBenh = True Then
        If Trim(MaBenh) <> "" Then
            ThongKeBenhNhanTheoBenh (MaBenh)
        Else
            MsgBox "Ban chua chon ten benh can thong ke", vbInformation
            Exit Sub
        End If
    Else
        ThongKeBenhNhanTheoDiaChi
    End If
End Sub

Private Sub cmdThoat_Click()
    Unload Me
End Sub

Private Sub Form_Load()
    opThongKeTheoBenh = True
    opThongKeTheoDiaChi = False
    MaBenh = ""
End Sub

Private Sub ThongKeBenhNhanTheoDiaChi()
    Dim TenXa$, TenHuyen$, TenTinh$
    Dim strDiaChi$
    Dim clDiaChi As New clTachDiaChi
    '----------------------------------------------
    strDiaChi = Trim(txtNhapLieu.Text)
    If (strDiaChi <> "") And strDiaChi <> "/" Then
        clDiaChi.DiaChiVao strDiaChi
        clDiaChi.TachDiaChi TenXa, TenHuyen, TenTinh
        If TenXa <> "" Then 'Tim Dia chi day du
            ThongKeBenhNhanTheoXa TenXa, TenHuyen, TenTinh
        Else
            If TenHuyen <> "" Then 'Tim theo dia chi co huyen tinh
                ThongKeBenhNhanTheoHuyen TenHuyen, TenTinh
            Else
                ThongKeBenhNhanTheoTinh TenTinh
            End If
        End If
    Else ' Chua co dia chi
        MsgBox "Ban chua nhap dia chi", vbInformation
    End If
End Sub

Private Sub ThongKeBenhNhanTheoBenh(MaBenh As String)
    Dim SQL$, Tong%
    Dim rs As ADODB.Recordset
    Dim mItem As listItem
    Tong = 0
    SQL = "Select * From vwThongKeTheoBenh " & _
                                "Where MaBenh=" & MaBenh
    lstBenhNhan.ListItems.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!HoBenhNhan) & _
                                " " & Trim(rs!TenBenhNhan))
                mItem.SubItems(1) = rs!NgaySinhBenhNhan
                mItem.SubItems(2) = tfGT(rs!GioiTinhBenhNhan)
            Tong = Tong + 1
            rs.MoveNext
        Loop
    End If
    txtTongSo.Text = Tong
    If Tong > 0 Then
        MsgBox "So benh nhan can thong ke la: " & Tong
    Else
        MsgBox "Khong co benh nha mac benh nay"
    End If
End Sub

Private Sub ThongKeBenhNhanTheoTinh(TenTinh As String)
    Dim SQL$, SoBenhNhan%
    Dim rs As ADODB.Recordset
    Dim mItem As listItem
    TenTinh = SuLiChuoi(TenTinh)
    Set rs = New ADODB.Recordset
    SQL = "Select *  From udf_TimBenhNhanTheoTinh" & "('" & TenTinh & "')"
    Set rs = cn.Execute(SQL)
    lstBenhNhan.ListItems.Clear
    SoBenhNhan = 0
    If rs.EOF = False Then
        Do While rs.EOF = False
            SoBenhNhan = SoBenhNhan + 1
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!HoBenhNhan) & _
                                " " & Trim(rs!TenBenhNhan))
                mItem.SubItems(1) = rs!NgaySinhBenhNhan
                mItem.SubItems(2) = tfGT(rs!GioiTinhBenhNhan)
                mItem.SubItems(3) = TimDiaChi(rs!MaXa)
            rs.MoveNext
        Loop
        txtTongSo.Text = SoBenhNhan
        MsgBox "So benh nhan can thong ke la: " & SoBenhNhan
    Else
        MsgBox "Khong co benh nhan nao trong dia chi vua nhap"
    End If
End Sub

Private Sub ThongKeBenhNhanTheoHuyen(TenHuyen As String, _
                                                                        TenTinh As String)
    Dim SQL$, mItem As listItem
    Dim rs As ADODB.Recordset
    Dim SoBenhNhan%
    '----------------------------------
    SQL = "Select * From udf_TimBenhNhanTheoHuyen(" & "'" & _
              TenTinh & "','" & TenHuyen & "')"
    lstBenhNhan.ListItems.Clear
    SoBenhNhan = 0
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            SoBenhNhan = SoBenhNhan + 1
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!HoBenhNhan) & _
                                " " & Trim(rs!TenBenhNhan))
                mItem.SubItems(1) = rs!NgaySinhBenhNhan
                mItem.SubItems(2) = tfGT(rs!GioiTinhBenhNhan)
                mItem.SubItems(3) = TimDiaChi(rs!MaXa)
            rs.MoveNext
        Loop
        MsgBox "Tonh so benh nhan tai dia chi la: " & SoBenhNhan
    Else
        MsgBox "Khong co benh nhan nao trong dia chi vua nhap"
    End If
End Sub

Private Sub ThongKeBenhNhanTheoXa(TenXa As String, TenHuyen As String, _
                                                            TenTinh As String)
    Dim SQL$, mItem As listItem
    Dim rs As ADODB.Recordset
    Dim SoBenhNhan%
    SQL = "Select * From udf_TimBenhNhanTheoXa(" & "'" & _
              TenTinh & "','" & TenHuyen & "','" & TenXa & "')"
    lstBenhNhan.ListItems.Clear
    SoBenhNhan = 0
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            SoBenhNhan = SoBenhNhan + 1
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!HoBenhNhan) & _
                                " " & Trim(rs!TenBenhNhan))
                mItem.SubItems(1) = rs!NgaySinhBenhNhan
                mItem.SubItems(2) = tfGT(rs!GioiTinhBenhNhan)
                mItem.SubItems(3) = TimDiaChi(rs!MaXa)
            rs.MoveNext
        Loop
        txtTongSo.Text = SoBenhNhan
        MsgBox "So benh nhan can thong ke la: " & SoBenhNhan
    Else
        MsgBox "Khong co benh nhan nao trong xa/huyen/tinh vua nhap"
    End If
End Sub

Private Sub txtNhapLieu_Click()
    Dim TenBenh$
    If opThongKeTheoBenh = True Then
        frmDanhSachBenh.Show 1
        frmDanhSachBenh.clBenh.ThongTTRa MaBenh, TenBenh
        frmDanhSachBenh.clBenh.SetNull
        txtNhapLieu.Text = TenBenh
    End If
End Sub

Private Sub txtNhapLieu_KeyPress(KeyAscii As Integer)
    If opThongKeTheoBenh = True Then
        Beep
        KeyAscii = 0
    End If
End Sub

Private Function TimDiaChi(MaXa As String) As String
    Dim SQL$, DiaChi$
    Dim rs As ADODB.Recordset
    SQL = "Select * From vwDiaChi Where MaXa=" & Trim(MaXa)
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        DiaChi = Trim(rs.Fields("TenXa")) & "/" & _
                         Trim(rs.Fields("TenHuyen")) & "/" & _
                         Trim(rs.Fields("TenTinh"))
    End If
    TimDiaChi = DiaChi
End Function

