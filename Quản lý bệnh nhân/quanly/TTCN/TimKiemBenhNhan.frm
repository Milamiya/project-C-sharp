VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Object = "{C932BA88-4374-101B-A56C-00AA003668DC}#1.1#0"; "MSMASK32.OCX"
Begin VB.Form frmTimKiemBenhNhan 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Tim kiem benh nhan"
   ClientHeight    =   7500
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   10815
   Icon            =   "TimKiemBenhNhan.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7500
   ScaleWidth      =   10815
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtDiaChiBenhNhan 
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
      Left            =   3120
      TabIndex        =   9
      Top             =   4320
      Width           =   7575
   End
   Begin VB.Frame Frame2 
      Caption         =   "Xöû lí"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2535
      Left            =   6600
      TabIndex        =   7
      Top             =   4800
      Width           =   4095
      Begin VB.CommandButton cmdInDanhSach 
         Caption         =   "In Danh Saùch"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   2040
         TabIndex        =   21
         Top             =   1560
         Width           =   1815
      End
      Begin VB.CommandButton Command1 
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
         Left            =   120
         TabIndex        =   15
         Top             =   1560
         Width           =   1695
      End
      Begin VB.CommandButton cmdTim 
         Caption         =   "Tìm"
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
         Left            =   120
         TabIndex        =   14
         Top             =   720
         Width           =   1695
      End
      Begin VB.CommandButton cmdInMotBenhNhan 
         Caption         =   "In moät ngöôøi"
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
         Left            =   2040
         TabIndex        =   8
         Top             =   720
         Width           =   1815
      End
   End
   Begin MSComctlLib.ListView lstBenhNhan 
      Height          =   3975
      Left            =   120
      TabIndex        =   6
      Top             =   240
      Width           =   10575
      _ExtentX        =   18653
      _ExtentY        =   7011
      View            =   3
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      GridLines       =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
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
      NumItems        =   6
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Maõ beânh nhaân"
         Object.Width           =   3069
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Hoï Teân beänh nhaân"
         Object.Width           =   5521
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Ngaøy sinh"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "Giôùi tính"
         Object.Width           =   1941
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Text            =   "Ma Xa"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   5
         Text            =   "Ñòa chæ"
         Object.Width           =   5468
      EndProperty
   End
   Begin VB.Frame Frame1 
      Caption         =   "Tieâu chi tìm kieám"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2535
      Left            =   120
      TabIndex        =   0
      Top             =   4800
      Width           =   6375
      Begin VB.OptionButton opHoTenNgaySinh 
         Caption         =   "H.Teân+Ng.Sinh"
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
         Left            =   4080
         TabIndex        =   20
         Top             =   360
         Width           =   1935
      End
      Begin VB.OptionButton opDiaChiHoTen 
         Caption         =   "Ñ.Chi+H.Teân"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   2520
         TabIndex        =   18
         Top             =   840
         Width           =   1695
      End
      Begin VB.Frame Frame3 
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
         Height          =   1335
         Left            =   120
         TabIndex        =   11
         Top             =   1080
         Width           =   6135
         Begin VB.TextBox txtHoTen 
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
            Left            =   1560
            TabIndex        =   19
            Top             =   840
            Width           =   4455
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
            Height          =   375
            Left            =   1560
            TabIndex        =   13
            Top             =   360
            Width           =   4455
         End
         Begin MSMask.MaskEdBox marNgaySinh 
            Height          =   375
            Left            =   1560
            TabIndex        =   12
            Top             =   840
            Width           =   4455
            _ExtentX        =   7858
            _ExtentY        =   661
            _Version        =   393216
            MaxLength       =   10
            BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
               Name            =   "VNI-Times"
               Size            =   11.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Mask            =   "##/##/####"
            PromptChar      =   "_"
         End
         Begin VB.Label lblNgaySinh 
            Caption         =   "Ngaøy sinh"
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
            Left            =   120
            TabIndex        =   17
            Top             =   840
            Width           =   1335
         End
         Begin VB.Label lblNhap 
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
            Left            =   120
            TabIndex        =   16
            Top             =   360
            Width           =   1335
         End
      End
      Begin VB.OptionButton opHoTen 
         Caption         =   "Hoï teân"
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
         Left            =   1320
         TabIndex        =   5
         Top             =   360
         Width           =   1095
      End
      Begin VB.OptionButton opTen 
         Caption         =   "Teân"
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
         Left            =   120
         TabIndex        =   4
         Top             =   720
         Width           =   1095
      End
      Begin VB.OptionButton opHoDem 
         Caption         =   "Hoï ñeäm "
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
         Left            =   120
         TabIndex        =   3
         Top             =   360
         Width           =   1215
      End
      Begin VB.OptionButton opNgaySinh 
         Caption         =   "Ng.sinh"
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
         Left            =   1320
         TabIndex        =   2
         Top             =   720
         Width           =   1095
      End
      Begin VB.OptionButton opDiaChi 
         Caption         =   "Ñòa chæ"
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
         Left            =   2520
         TabIndex        =   1
         Top             =   360
         Width           =   1215
      End
   End
   Begin VB.Label Label1 
      Caption         =   "Ñòa chæ beänh nhaân ñaày ñuû"
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
      Left            =   120
      TabIndex        =   10
      Top             =   4320
      Width           =   2775
   End
End
Attribute VB_Name = "frmTimKiemBenhNhan"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim MaBenhNhan$

Private Sub cmdInDanhSach_Click()
    Dim SQL$, HoBenhNhan$, TenBenhNhan$, HoTenBenhNhan$
    Dim NgaySinh$
    Dim TenXa$, TenHuyen$, TenTinh$
    Dim clTachDiaChi As New clTachDiaChi
    '----------------------------------------------------
    If opTen = True Then
        If Trim(txtNhapLieu.Text) = "" Then
            MsgBox "Ban chua nhap ten benh nhan can tim", vbInformation
            Exit Sub
        End If
        TenBenhNhan = Trim(txtNhapLieu.Text)
        SQL = "Select * From vwTimBenhNhan where TenBenhNhan=" & _
                    "'" & TenBenhNhan & "'"
    ElseIf opHoDem = True Then
        HoBenhNhan = SuLiChuoi(txtNhapLieu.Text)
        SQL = "Select * From vwTimBenhNhan where HoBenhNhan=" & _
                    "'" & HoBenhNhan & "'"
    ElseIf opDiaChi = True Then ' In danh sach theo dia chi
        clTachDiaChi.DiaChiVao txtNhapLieu.Text
        clTachDiaChi.TachDiaChi TenXa, TenHuyen, TenTinh
        If TenXa <> "" Then
           SQL = " Select * From vwTimBenhNhan " & _
                            "Where Diachi='" & TenXa & "/" & TenHuyen & _
                            "/" & TenTinh & "'"
         ElseIf TenHuyen <> "" Then
            SQL = "Select * From vwTimBenhNhan Where " & _
                      "TenHuyen='" & TenHuyen & "' And " & _
                       "TenTinh='" & _
                       TenTinh & "'"
         Else
            SQL = "Select * From vwTimBenhNhan Where " & _
                    "TenTinh='" & TenTinh & "'"
        End If ' Ket thuc viec in theo dia chi
    ElseIf opHoTen = True Then
        HoTenBenhNhan = Trim(txtNhapLieu.Text)
        HoTenBenhNhan = SuLiChuoi(HoTenBenhNhan)
        SQL = "Select * From vwTimBenhNhan Where " & _
                "HoTenBenhNhan='" & HoTenBenhNhan & "'"
    ElseIf opNgaySinh = True Then
        NgaySinh = SuLiNgaySinh(marNgaySinh.Text, "BenhNhan")
        If NgaySinh = "NotOK" Then
            MsgBox "Ngay sinh benh nhan can tim khong hop le", vbCritical
            Exit Sub
        Else
            NgaySinh = Replace(NgaySinh, "/", "-")
        End If
        SQL = "Select * From vwTimBenhNhan Where " & _
                    "NgaySinhBenhNhan='" & NgaySinh & "'"
    ElseIf opDiaChiHoTen = True Then
        clTachDiaChi.DiaChiVao (txtNhapLieu.Text)
        clTachDiaChi.TachDiaChi TenXa, TenHuyen, TenTinh
        HoTenBenhNhan = SuLiChuoi(txtHoTen.Text)
        TachHoTen HoTenBenhNhan, HoBenhNhan, TenBenhNhan
        If HoBenhNhan <> "" Then
            If TenXa <> "" Then
                SQL = "Select * From vwTimBenhNhan Where " & _
                            "HoTenBenhNhan='" & HoTenBenhNhan & _
                            "' And DiaChi='" & TenXa & "/" & _
                            TenHuyen & "/" & TenTinh & "'"
            ElseIf TenHuyen <> "" Then
                SQL = "Select * From vwTimBenhNhan Where " & _
                            "HoTenBenhNhan='" & HoTenBenhNhan & _
                            "' And TenHuyen= '" & TenHuyen & _
                            "' And TenTinh='" & TenTinh & "'"
            Else
                SQL = "Select * From vwTimBenhNhan Where " & _
                            "HoTenBenhNhan='" & HoTenBenhNhan & _
                            "' And TenTinh='" & TenTinh & "'"
            End If ' Ho ten benh nhan day du
        Else ' Chi co ten
            If TenXa <> "" Then
                SQL = "Select * From vwTimBenhNhan Where " & _
                            "TenBenhNhan='" & TenBenhNhan & _
                            "' And DiaChi='" & TenXa & "/" & _
                            TenHuyen & "/" & TenTinh & "'"
            ElseIf TenHuyen <> "" Then
                SQL = "Select * From vwTimBenhNhan Where " & _
                            "TenBenhNhan='" & TenBenhNhan & _
                            "' And TenHuyen= '" & TenHuyen & _
                            "' And TenTinh='" & TenTinh & "'"
            Else
                SQL = "Select * From vwTimBenhNhan Where " & _
                            "TenBenhNhan='" & TenBenhNhan & _
                            "' And TenTinh='" & TenTinh & "'"
            End If ' Ho ten benh nhan day du
                End If
    ElseIf opHoTenNgaySinh = True Then
        HoTenBenhNhan = SuLiChuoi(txtNhapLieu.Text)
        NgaySinh = SuLiNgaySinh(marNgaySinh.Text, "BenhNhan")
        If NgaySinh = "NotOK" Then
            MsgBox "Ngay sinh nhap vao khong hop le", vbCritical
            Exit Sub
        Else
            NgaySinh = Replace(NgaySinh, "/", "-")
        End If
        TachHoTen HoTenBenhNhan, HoBenhNhan, TenBenhNhan
        If HoBenhNhan <> "" Then
            SQL = "Select * From vwTimBenhNhan Where " & _
                        "HoTenBenhNhan='" & HoTenBenhNhan & _
                        "' And NgaySinh='" & NgaySinh & "'"
        Else
            SQL = "Select * From vwTimBenhNhan Where " & _
                            "TenBenhNhan='" & TenBenhNhan & _
                            "' And NgaySinh='" & NgaySinh & "'"
        End If
    End If
    DE.Commands(92).CommandText = SQL
    If DE.rsDanhSachBenhNhan.State = 0 Then
        DE.rsDanhSachBenhNhan.Open
    End If
    DE.rsDanhSachBenhNhan.Requery
    repDanhSachBenhNHan.Show 1
End Sub

Private Sub cmdinmotbenhnhan_Click()
    Dim SQL$
    SQL = "Select * From vwTimBenhNhan Where MaBenhNhan=" & _
                        Trim(MaBenhNhan)
    DE.Commands(92).CommandText = SQL
    If DE.rsDanhSachBenhNhan.State = 0 Then
        DE.rsDanhSachBenhNhan.Open
    End If
    DE.rsDanhSachBenhNhan.Requery
    'Dim SQL$
    'Dim rs As ADODB.Recordset
    'SQL = "Select * From vwTimTamUng Where MaBenhNhan =" & Trim(MaBenhNhan)
    'DE.TamUng.commandstex = SQl
    'de.Commands.Item.
    'Set rs = cn.Execute(SQL)
    'If rs.EOF = False Then
    '    Set repThongTinBenhNhan.DataSource = rs.DataSource
    '    repThongTinBenhNhan.DataMember = rs.DataMember
    'End If
    'If DE.rsTamUng.State = 0 Then
        'DE.rsTamUng.Open
    'End If
    'DE.rsTamUng.Requery
    repMotBenhNhan.Show 1
End Sub

Private Sub cmdTim_Click()
    Dim strNhapLieu$
    If opNgaySinh = False Then
        strNhapLieu = Trim(txtNhapLieu.Text)
        If strNhapLieu = "" Then
            MsgBox "Ban chua nhap ho dem benh nhan can tim", vbInformation
            Exit Sub
         End If
    Else
        TimBenhNhanTheoNgaySinh
    End If
        '-----------------------------------------------------
    If opDiaChi = True Then 'Tim benh nhan theo dia chi
        TimBenhNhanTheoDiaChi
    ElseIf opHoDem = True Then 'Tim benh nhan theo ho dem
        TimBenhNhanTheoHo strNhapLieu
    ElseIf opTen = True Then
        TimBenhNhanTheoTen strNhapLieu
    ElseIf opHoTen = True Then
        TimBenhNhanTheoHoTen strNhapLieu
    ElseIf opDiaChiHoTen = True Then
        TimBenhNhanTheoDiaChiVaHoTen
    ElseIf opHoTenNgaySinh = True Then
        TimBenhNhanTheoHoTenVaNgaySinh
    End If
End Sub

Private Sub Command1_Click()
    Unload Me
End Sub

Private Sub Form_Load()
    opHoDem = False
    opTen = False
    opHoTen = True
    opDiaChi = False
    opNgaySinh = False
    txtDiaChiBenhNhan.Enabled = False
    marNgaySinh.Enabled = False
    lblNhap.Caption = "Hoï ñeäm"
    txtHoTen.Visible = False
    '---------------------------
    opDiaChi.ToolTipText = " Xa/Huyen/Tinh"
    cmdInMotBenhNhan.Enabled = False
End Sub

Private Sub TimBenhNhanTheoDiaChiVaHoTen()
    Dim HoBenhNhan$, TenBenhNhan$, HoTenBenhNhan$
    Dim TenTinh$, TenHuyen$, TenXa$, DiaChi$
    Dim clDiaChi As New clTachDiaChi
    DiaChi = txtNhapLieu.Text
    If DiaChi = "" Then
        MsgBox "ban chua nhap dia chi benh nhan", vbInformation
        Exit Sub
    End If
    HoTenBenhNhan = SuLiChuoi(txtHoTen.Text)
    If HoTenBenhNhan = "" Then
        MsgBox "Ban chua nhap ho ten benh nhan", vbInformation
        Exit Sub
    End If
    TachHoTen HoTenBenhNhan, HoBenhNhan, TenBenhNhan
    clDiaChi.DiaChiVao DiaChi
    clDiaChi.TachDiaChi TenXa, TenHuyen, TenTinh
    If HoBenhNhan = "" Then
        If TenXa = "" Then
            If TenHuyen = "" Then
                TimBenhNhanTheoTinhVaTen TenTinh, TenBenhNhan
            Else
                TimTheoHuyenVaTen TenHuyen, TenTinh, TenBenhNhan
            End If ' Ten huyen=""
        Else
            TimBenhNhanXaVaTen TenXa, TenHuyen, TenTinh, TenBenhNhan
        End If ' ten xa=""
    Else
        If TenXa = "" Then
            If TenHuyen = "" Then
                TimBenhNhanTinhVaHoTen TenTinh, HoBenhNhan, TenBenhNhan
            Else
                TimTheoHuyenVaTen TenHuyen, TenTinh, TenBenhNhan
            End If ' Ten huyen=""
        Else
            TimBenhNhanXaVaTen TenXa, TenHuyen, TenTinh, TenBenhNhan
        End If ' ten xa=""
    End If 'Ho=""
End Sub

Private Sub TimBenhNhanTheoTinh(TenTinh As String)
    'Hien thi thong tin benh nhan
    Dim SQL$
    Dim rs As ADODB.Recordset
    Dim mItem As listItem
    TenTinh = SuLiChuoi(TenTinh)
    Set rs = New ADODB.Recordset
    SQL = "Select *  From udf_TimBenhNhanTheoTinh" & "('" & TenTinh & "')"
    Set rs = cn.Execute(SQL)
    lstBenhNhan.ListItems.Clear
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!MaBenhNhan))
                mItem.SubItems(1) = Trim(rs!HoBenhNhan) & _
                                                     "  " & Trim(rs!TenBenhNhan)
                mItem.SubItems(2) = rs!NgaySinhBenhNhan
                mItem.SubItems(3) = tfGT(rs!GioiTinhBenhNhan)
                mItem.SubItems(4) = rs!MaXa
                mItem.SubItems(5) = TimDiaChi(rs!MaXa)
            rs.MoveNext
        Loop
      
    Else
        MsgBox "Khong co benh nhan nao trong tinh vua nhap"
    End If
End Sub

Private Sub TimBenhNhanTheoHuyen(TenHuyen As String, _
                                                                    TenTinh As String)
    Dim SQL$, mItem As listItem
    Dim rs As ADODB.Recordset
    SQL = "Select * From udf_TimBenhNhanTheoHuyen(" & "'" & _
              TenTinh & "','" & TenHuyen & "')"
    lstBenhNhan.ListItems.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!MaBenhNhan))
                mItem.SubItems(1) = Trim(rs!HoBenhNhan) & _
                                                     "  " & Trim(rs!TenBenhNhan)
                mItem.SubItems(2) = rs!NgaySinhBenhNhan
                mItem.SubItems(3) = tfGT(rs!GioiTinhBenhNhan)
                mItem.SubItems(4) = rs!MaXa
                mItem.SubItems(5) = TimDiaChi(rs!MaXa)
            rs.MoveNext
        Loop
        
    Else
        MsgBox "Khong co benh nhan nao trong huyen/tinh vua nhap"
    End If
End Sub

Private Sub TimBenhNhanTheoXa(TenXa As String, TenHuyen As String, _
                                                            TenTinh As String)
    Dim SQL$, mItem As listItem
    Dim rs As ADODB.Recordset
    SQL = "Select * From udf_TimBenhNhanTheoXa(" & "'" & _
              TenTinh & "','" & TenHuyen & "','" & TenXa & "')"
    lstBenhNhan.ListItems.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!MaBenhNhan))
                mItem.SubItems(1) = Trim(rs!HoBenhNhan) & _
                                                     "  " & Trim(rs!TenBenhNhan)
                mItem.SubItems(2) = rs!NgaySinhBenhNhan
                mItem.SubItems(3) = tfGT(rs!GioiTinhBenhNhan)
                mItem.SubItems(4) = rs!MaXa
                mItem.SubItems(5) = TimDiaChi(rs!MaXa)
            rs.MoveNext
        Loop

    Else
        MsgBox "Khong co benh nhan nao trong xa/huyen/tinh vua nhap"
    End If
End Sub
                                                            
Private Sub TimBenhNhanTheoDiaChi()
    Dim TenTinh$, TenHuyen$, TenXa$
    Dim strDiaChi$
    Dim clDiaChi As New clTachDiaChi
    '----------------------------------------------
    strDiaChi = Trim(txtNhapLieu.Text)
    If (strDiaChi <> "") And strDiaChi <> "/" Then
        clDiaChi.DiaChiVao strDiaChi
        clDiaChi.TachDiaChi TenXa, TenHuyen, TenTinh
        If TenXa <> "" Then 'Tim Dia chi day du
            TimBenhNhanTheoXa TenXa, TenHuyen, TenTinh
        Else
            If TenHuyen <> "" Then 'Tim theo dia chi co huyen tinh
                TimBenhNhanTheoHuyen TenHuyen, TenTinh
            Else
                TimBenhNhanTheoTinh TenTinh
            End If
        End If
    Else ' Chua co dia chi
        MsgBox "Ban chua nhap dia chi", vbInformation
    End If
End Sub

Private Sub TimBenhNhanTheoTen(TenBenhNhan As String)
    Dim SQL$, mItem As listItem
    Dim rs As ADODB.Recordset
    '----------------------------------------
    SQL = "Select * From udf_TimBenhNhanTheoTen('" & _
                TenBenhNhan & "')"
    lstBenhNhan.ListItems.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!MaBenhNhan))
                mItem.SubItems(1) = Trim(rs!HoBenhNhan) & _
                                                     "  " & Trim(rs!TenBenhNhan)
                mItem.SubItems(2) = rs!NgaySinhBenhNhan
                mItem.SubItems(3) = tfGT(rs!GioiTinhBenhNhan)
                mItem.SubItems(4) = rs!MaXa
                mItem.SubItems(5) = TimDiaChi(rs!MaXa)
            rs.MoveNext
        Loop
        
    Else
        MsgBox "Khong tim thay benh nhan co ten chi ra"
    End If
End Sub

Private Sub TimBenhNhanTheoHoTen(HoTenBenhNhan As String)
    Dim SQL$, mItem As listItem
    Dim rs As ADODB.Recordset
    Dim HoBenhNhan$, TenBenhNhan$
    '----------------------------------------
    TachHoTen HoTenBenhNhan, HoBenhNhan, TenBenhNhan
    SQL = "Select * From udf_TimBenhNhanTheoHoTen('" & _
                HoBenhNhan & "','" & TenBenhNhan & "')"
    lstBenhNhan.ListItems.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!MaBenhNhan))
                mItem.SubItems(1) = Trim(rs!HoBenhNhan) & _
                                                     "  " & Trim(rs!TenBenhNhan)
                mItem.SubItems(2) = rs!NgaySinhBenhNhan
                mItem.SubItems(3) = tfGT(rs!GioiTinhBenhNhan)
                mItem.SubItems(4) = rs!MaXa
                mItem.SubItems(5) = TimDiaChi(rs!MaXa)
            rs.MoveNext
        Loop
 
    Else
        MsgBox "Khong tim thay benh nhan co ho ten chi ra"
    End If
End Sub

Private Sub TimBenhNhanTheoHo(HoBenhNhan As String)
    Dim SQL$, mItem As listItem
    Dim rs As ADODB.Recordset
    '----------------------------------------
    HoBenhNhan = SuLiChuoi(HoBenhNhan)
    SQL = "Select * From udf_TimBenhNhanTheoHo('" & _
                HoBenhNhan & "')"
    lstBenhNhan.ListItems.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!MaBenhNhan))
                mItem.SubItems(1) = Trim(rs!HoBenhNhan) & _
                                                     "  " & Trim(rs!TenBenhNhan)
                mItem.SubItems(2) = rs!NgaySinhBenhNhan
                mItem.SubItems(3) = tfGT(rs!GioiTinhBenhNhan)
                mItem.SubItems(4) = rs!MaXa
                mItem.SubItems(5) = TimDiaChi(rs!MaXa)
            rs.MoveNext
        Loop

    Else
        MsgBox "Khong tim thay benh nhan co ho chi ra"
    End If
End Sub

Private Sub TimBenhNhanTheoNgaySinh()
    Dim SQL$, mItem As listItem
    Dim NgaySinh$, NgayTam$
    Dim rs As ADODB.Recordset
    '----------------------------------------
    NgaySinh = SuLiNgaySinh(marNgaySinh.Text, "Benh Nhan")
    If NgaySinh = "NotOK" Then
        MsgBox "Ngay sinh " & marNgaySinh.Text & " khong hop le", vbCritical
        Exit Sub
    End If
    NgayTam = NgaySinh
    NgaySinh = Replace(NgaySinh, "/", "-")
    SQL = "Select * From udf_TimBenhNhanTheoNgaySinh ('" & _
                NgaySinh & "')"
    lstBenhNhan.ListItems.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!MaBenhNhan))
                mItem.SubItems(1) = Trim(rs!HoBenhNhan) & _
                                                     "  " & Trim(rs!TenBenhNhan)
                mItem.SubItems(2) = rs!NgaySinhBenhNhan
                mItem.SubItems(3) = tfGT(rs!GioiTinhBenhNhan)
                mItem.SubItems(4) = rs!MaXa
                mItem.SubItems(5) = TimDiaChi(rs!MaXa)
            rs.MoveNext
        Loop
  
    Else
        MsgBox "Khong tim thay benh nhan co ngay sinh: " & NgayTam, vbCritical
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

Private Sub TimBenhNhanXaVaTen(TenXa As String, _
                                    TenHuyen As String, TenTinh As String, _
                                    TenBenhNhan As String)
    Dim SQL$, mItem As listItem
    Dim rs As ADODB.Recordset
    SQL = "Select * From udf_TimBenhNhanXaVaTen('" & _
            TenXa & "','" & TenHuyen & "','" & TenTinh & "','" & TenBenhNhan & "')"
    lstBenhNhan.ListItems.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!MaBenhNhan))
                mItem.SubItems(1) = Trim(rs!HoBenhNhan) & _
                                                     "  " & Trim(rs!TenBenhNhan)
                mItem.SubItems(2) = rs!NgaySinhBenhNhan
                mItem.SubItems(3) = tfGT(rs!GioiTinhBenhNhan)
                mItem.SubItems(4) = rs!MaXa
                mItem.SubItems(5) = TimDiaChi(rs!MaXa)
            rs.MoveNext
        Loop
     
    Else
        MsgBox "Khong tim thay benh nhan co tren", vbCritical
    End If
End Sub

Private Sub TimTheoHuyenVaTen(TenHuyen As String, _
                                TenTinh As String, TenBenhNhan As String)
    Dim SQL$, mItem As listItem
    Dim rs As ADODB.Recordset
    SQL = "Select * From udf_TimBenhNhanHuyenVaTen('" & _
                TenHuyen & "','" & TenTinh & "','" & TenBenhNhan & "')"
    lstBenhNhan.ListItems.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!MaBenhNhan))
                mItem.SubItems(1) = Trim(rs!HoBenhNhan) & _
                                                     "  " & Trim(rs!TenBenhNhan)
                mItem.SubItems(2) = rs!NgaySinhBenhNhan
                mItem.SubItems(3) = tfGT(rs!GioiTinhBenhNhan)
                mItem.SubItems(4) = rs!MaXa
                mItem.SubItems(5) = TimDiaChi(rs!MaXa)
            rs.MoveNext
        Loop
 
    Else
        MsgBox "Khong tim thay benh nhan tren", vbCritical
    End If
End Sub

Private Sub TimBenhNhanTheoTinhVaTen(TenTinh As String, _
                                        TenBenhNhan As String)
    Dim SQL$, mItem As listItem
    Dim rs As ADODB.Recordset
    SQL = "Select * From udf_TimBenhNhanTinhVaTen('" & _
                TenTinh & "','" & TenBenhNhan & "')"
    lstBenhNhan.ListItems.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!MaBenhNhan))
                mItem.SubItems(1) = Trim(rs!HoBenhNhan) & _
                                                     "  " & Trim(rs!TenBenhNhan)
                mItem.SubItems(2) = rs!NgaySinhBenhNhan
                mItem.SubItems(3) = tfGT(rs!GioiTinhBenhNhan)
                mItem.SubItems(4) = rs!MaXa
                mItem.SubItems(5) = TimDiaChi(rs!MaXa)
            rs.MoveNext
        Loop
       
    Else
        MsgBox "Khong tim thay benh nhan tren", vbCritical
    End If
End Sub

Private Sub TimBenhNhanXaVaHoTen(TenXa As String, _
                                    TenHuyen As String, TenTinh As String, _
                                    HoBenhNhan As String, TenBenhNhan As String)
    Dim SQL$, mItem As listItem
    Dim rs As ADODB.Recordset
    SQL = "Select * From udf_TimBenhNhanXaVaHoTen('" & _
            TenXa & "','" & TenHuyen & "','" & TenTinh & "','" & _
            HoBenhNhan & "','" & TenBenhNhan & "')"
    lstBenhNhan.ListItems.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!MaBenhNhan))
                mItem.SubItems(1) = Trim(rs!HoBenhNhan) & _
                                                     "  " & Trim(rs!TenBenhNhan)
                mItem.SubItems(2) = rs!NgaySinhBenhNhan
                mItem.SubItems(3) = tfGT(rs!GioiTinhBenhNhan)
                mItem.SubItems(4) = rs!MaXa
                mItem.SubItems(5) = TimDiaChi(rs!MaXa)
            rs.MoveNext
        Loop

    Else
        MsgBox "Khong tim thay benh nhan co tren", vbCritical
    End If
End Sub

Private Sub TimBenhNhanHuyenVaHoTen(TenHuyen As String, _
                                    TenTinh As String, HoBenhNhan As String, _
                                    TenBenhNhan As String)
    Dim SQL$, mItem As listItem
    Dim rs As ADODB.Recordset
    SQL = "Select * From udf_TimBenhNhanHuyenVaHoTen('" & _
            TenHuyen & "','" & TenTinh & "','" & _
            HoBenhNhan & "','" & TenBenhNhan & "')"
    lstBenhNhan.ListItems.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!MaBenhNhan))
                mItem.SubItems(1) = Trim(rs!HoBenhNhan) & _
                                                     "  " & Trim(rs!TenBenhNhan)
                mItem.SubItems(2) = rs!NgaySinhBenhNhan
                mItem.SubItems(3) = tfGT(rs!GioiTinhBenhNhan)
                mItem.SubItems(4) = rs!MaXa
                mItem.SubItems(5) = TimDiaChi(rs!MaXa)
            rs.MoveNext
        Loop
        
    Else
        MsgBox "Khong tim thay benh nhan co tren", vbCritical
    End If
End Sub

Private Sub TimBenhNhanTinhVaHoTen(TenTinh As String, _
                                            HoBenhNhan As String, _
                                            TenBenhNhan As String)
    Dim SQL$, mItem As listItem
    Dim rs As ADODB.Recordset
    SQL = "Select * From udf_TimBenhNhanTinhVaHoTen('" & _
            TenTinh & "','" & HoBenhNhan & "','" & TenBenhNhan & "')"
    lstBenhNhan.ListItems.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!MaBenhNhan))
                mItem.SubItems(1) = Trim(rs!HoBenhNhan) & _
                                                     "  " & Trim(rs!TenBenhNhan)
                mItem.SubItems(2) = rs!NgaySinhBenhNhan
                mItem.SubItems(3) = tfGT(rs!GioiTinhBenhNhan)
                mItem.SubItems(4) = rs!MaXa
                mItem.SubItems(5) = TimDiaChi(rs!MaXa)
            rs.MoveNext
        Loop
        
    Else
        MsgBox "Khong tim thay benh nhan co tren", vbCritical
    End If
End Sub

Private Sub TimBenhNhanTenVaNgaySinh(TenBenhNhan As String, _
                                                                    NgaySinh As String)
    Dim SQL$, mItem As listItem
    Dim rs As ADODB.Recordset
    NgaySinh = Replace(NgaySinh, "/", "-")
    SQL = "Select * From udf_TimBenhNhanTheoTenVaNgaySinh('" & _
            TenBenhNhan & "','" & NgaySinh & "')"
    lstBenhNhan.ListItems.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!MaBenhNhan))
                mItem.SubItems(1) = Trim(rs!HoBenhNhan) & _
                                                     "  " & Trim(rs!TenBenhNhan)
                mItem.SubItems(2) = rs!NgaySinhBenhNhan
                mItem.SubItems(3) = tfGT(rs!GioiTinhBenhNhan)
                mItem.SubItems(4) = rs!MaXa
                mItem.SubItems(5) = TimDiaChi(rs!MaXa)
            rs.MoveNext
        Loop
        
    Else
        MsgBox "Khong tim thay benh nhan co tren", vbCritical
    End If
End Sub

Private Sub TimBenhNhanHoTenVaNgaySinh(HoBenhNhan As String, _
                        TenBenhNhan As String, NgaySinh As String)
    Dim SQL$, mItem As listItem
    Dim rs As ADODB.Recordset
    NgaySinh = Replace(NgaySinh, "/", "-")
    SQL = "Select * From udf_TimBenhNhanTheoHoTenVaNgaySinh('" & _
            HoBenhNhan & "','" & TenBenhNhan & "','" & NgaySinh & "')"
    lstBenhNhan.ListItems.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!MaBenhNhan))
                mItem.SubItems(1) = Trim(rs!HoBenhNhan) & _
                                                     "  " & Trim(rs!TenBenhNhan)
                mItem.SubItems(2) = rs!NgaySinhBenhNhan
                mItem.SubItems(3) = tfGT(rs!GioiTinhBenhNhan)
                mItem.SubItems(4) = rs!MaXa
                mItem.SubItems(5) = TimDiaChi(rs!MaXa)
            rs.MoveNext
        Loop
        
    Else
        MsgBox "Khong tim thay benh nhan co tren", vbCritical
    End If
End Sub

Private Sub TimBenhNhanTheoHoTenVaNgaySinh()
    Dim HoBenhNhan$, TenBenhNhan$, HoTenBenhNhan$
    Dim NgaySinh$
    NgaySinh = marNgaySinh.Text
    HoTenBenhNhan = Trim(txtNhapLieu.Text)
    If HoTenBenhNhan = "" Then
        MsgBox "Ban chua nhap ten benh nhan can tim", vbInformation
        Exit Sub
    End If
    NgaySinh = SuLiNgaySinh(NgaySinh, "BenhNhan")
    If NgaySinh = "NotOK" Then
        MsgBox "Ngay sinh benh nhan can tim khong hop le", vbCritical
    Else
        TachHoTen HoTenBenhNhan, HoBenhNhan, TenBenhNhan
        If HoBenhNhan = "" Then
            TimBenhNhanTenVaNgaySinh TenBenhNhan, NgaySinh
        Else
            TimBenhNhanHoTenVaNgaySinh HoBenhNhan, TenBenhNhan, NgaySinh
        End If
    End If
End Sub

Private Sub lstBenhNhan_ItemClick(ByVal Item As MSComctlLib.listItem)
    MaBenhNhan = Item.Text
    txtDiaChiBenhNhan.Text = Item.SubItems(5)
    cmdInMotBenhNhan.Enabled = True
End Sub

Private Sub opDiaChi_Click()
    lblNgaySinh.Caption = "Ngaøy Sinh"
    lblNhap.Caption = "Ñòa chæ"
    marNgaySinh.Enabled = False
    txtNhapLieu.Enabled = True
    txtHoTen.Visible = False
End Sub

Private Sub opDiaChiHoTen_Click()
    lblNhap.Caption = "Ñòa chæ"
    lblNgaySinh.Caption = "Hoï teân"
    txtNhapLieu.Enabled = True
    marNgaySinh.Visible = True
    txtHoTen.Visible = True
    txtHoTen.Enabled = True
End Sub

Private Sub opHoDem_Click()
    lblNgaySinh.Caption = "Ngaøy Sinh"
    lblNhap.Caption = "Hoï ñeäm"
    marNgaySinh.Enabled = False
    txtNhapLieu.Enabled = True
    txtHoTen.Visible = False
End Sub

Private Sub opHoTen_Click()
    lblNgaySinh.Caption = "Ngaøy Sinh"
    lblNhap.Caption = "Hoï teân"
    marNgaySinh.Enabled = False
    txtNhapLieu.Enabled = True
    txtHoTen.Visible = False
End Sub

Private Sub opNgaySinh_Click()
    marNgaySinh.Visible = True
    marNgaySinh.Enabled = True
    txtNhapLieu.Enabled = False
    lblNgaySinh.Caption = "Ngaøy Sinh"
    txtHoTen.Visible = False
End Sub

Private Sub opTen_Click()
    lblNgaySinh.Caption = "Ngaøy Sinh"
    lblNhap.Caption = "Teân"
    marNgaySinh.Enabled = False
    txtNhapLieu.Enabled = True
    txtHoTen.Visible = False
End Sub

Private Sub ophotenngaysinh_Click()
    lblNhap.Caption = "Hoï teân"
    lblNgaySinh.Caption = "Ngaøy Sinh"
    txtNhapLieu.Enabled = True
    txtNhapLieu.Visible = True
    txtHoTen.Visible = False
    marNgaySinh.Visible = True
    marNgaySinh.Enabled = True
End Sub
