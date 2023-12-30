VERSION 5.00
Object = "{C932BA88-4374-101B-A56C-00AA003668DC}#1.1#0"; "MSMASK32.OCX"
Begin VB.Form frmThemXemBaoHiemYTe 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Thong tin bao hiem y te"
   ClientHeight    =   5355
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   11505
   Icon            =   "ThemXemBaoHiemYTe.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5355
   ScaleWidth      =   11505
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame3 
      Caption         =   "Cô quan"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3615
      Left            =   6480
      TabIndex        =   14
      Top             =   240
      Width           =   4815
      Begin VB.TextBox txtMaCoQuan 
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
         TabIndex        =   23
         Top             =   1080
         Width           =   3255
      End
      Begin VB.CheckBox chkThuocCoQuan 
         Caption         =   "Thuoäc cô quan"
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
         Left            =   240
         TabIndex        =   21
         Top             =   360
         Width           =   1815
      End
      Begin VB.TextBox txtFaxCoQuan 
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
         TabIndex        =   20
         Top             =   2880
         Width           =   3255
      End
      Begin VB.TextBox txtDienThoaiCoQuan 
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
         TabIndex        =   19
         Top             =   2280
         Width           =   3255
      End
      Begin VB.TextBox txtTenCoQuan 
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
         TabIndex        =   18
         Top             =   1680
         Width           =   3255
      End
      Begin VB.Label Label9 
         Caption         =   "Maõ cô quan"
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
         TabIndex        =   22
         Top             =   1080
         Width           =   1215
      End
      Begin VB.Label Label8 
         Caption         =   "Fax"
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
         Top             =   2880
         Width           =   1335
      End
      Begin VB.Label Label7 
         Caption         =   "Ñieän thoaïi"
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
         Top             =   2280
         Width           =   1335
      End
      Begin VB.Label Label6 
         Caption         =   "Teân cô quan"
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
         TabIndex        =   15
         Top             =   1680
         Width           =   1455
      End
   End
   Begin VB.Frame Frame2 
      Height          =   1215
      Left            =   120
      TabIndex        =   11
      Top             =   3960
      Width           =   11175
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
         Height          =   615
         Left            =   6600
         TabIndex        =   13
         Top             =   360
         Width           =   2415
      End
      Begin VB.CommandButton cmdChapNhan 
         Caption         =   "Chaáp nhaän"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   615
         Left            =   2160
         TabIndex        =   12
         Top             =   360
         Width           =   2055
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Thoâng tin baûo hieåm y teá beänh nhaân"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3735
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   6255
      Begin VB.TextBox txtHoTenBenhNhan 
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
         Left            =   2160
         TabIndex        =   10
         Top             =   600
         Width           =   3855
      End
      Begin VB.TextBox txtPhanTram 
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
         Left            =   2160
         MaxLength       =   2
         TabIndex        =   8
         Top             =   3000
         Width           =   3855
      End
      Begin VB.TextBox txtSoTheBaoHiem 
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
         Left            =   2160
         MaxLength       =   10
         TabIndex        =   5
         Top             =   1200
         Width           =   3855
      End
      Begin MSMask.MaskEdBox marNgayBatDau 
         Height          =   375
         Left            =   2160
         TabIndex        =   6
         Top             =   1800
         Width           =   3855
         _ExtentX        =   6800
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
      Begin MSMask.MaskEdBox marNgayKetThuc 
         Height          =   375
         Left            =   2160
         TabIndex        =   7
         Top             =   2400
         Width           =   3855
         _ExtentX        =   6800
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
      Begin VB.Label Label5 
         Caption         =   "Hoï teân beänh nhaân"
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
         TabIndex        =   9
         Top             =   600
         Width           =   1935
      End
      Begin VB.Label Label4 
         Caption         =   "Phaàn traêm"
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
         Top             =   3000
         Width           =   1935
      End
      Begin VB.Label Label3 
         Caption         =   "Ngaøy keát thuùc"
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
         Top             =   2400
         Width           =   1935
      End
      Begin VB.Label Label2 
         Caption         =   "Ngaøy baét ñaàu"
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
         Top             =   1800
         Width           =   2055
      End
      Begin VB.Label Label1 
         Caption         =   "Soá theû baûo hieåm "
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
         TabIndex        =   1
         Top             =   1200
         Width           =   2055
      End
   End
End
Attribute VB_Name = "frmThemXemBaoHiemYTe"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Public CoMoi As String
Public clBaoHiem As New clBaoHiemYTe
Dim SoTheBaoHiem$, NgayBatDau$, NgayKetThuc$, PhanTram As Currency
Dim MaCoQuan$

Private Sub chkThuocCoQuan_Click()
    Dim TenCoQuan$, DienThoai$, Fax$
    If chkThuocCoQuan.Value = 1 Then
        frmDanhsachCQ.Show 1
        frmDanhsachCQ.clCoQuan.TTcoQuanRa MaCoQuan, _
                                                TenCoQuan, DienThoai, Fax
        '---------------------------------------------
        If Trim(MaCoQuan) = "" Then chkThuocCoQuan.Value = 0
        txtMaCoQuan.Text = MaCoQuan
        txtTenCoQuan.Text = TenCoQuan
        txtDienThoaiCoQuan.Text = DienThoai
        txtFaxCoQuan.Text = Fax
    End If
End Sub

Private Sub cmdChapNhan_Click()
    Dim SQL$
    '-----------------------------------------------------------
    SoTheBaoHiem = Trim(txtSoTheBaoHiem.Text)
    NgayBatDau = SuLiNgay(marNgayBatDau.Text)
    NgayKetThuc = SuLiNgay(marNgayKetThuc.Text)
    If Trim(txtPhanTram.Text) <> "" Then
        PhanTram = Trim(txtPhanTram.Text)
    Else
        PhanTram = 0
    End If
    '-------------------------------------------
    If SoTheBaoHiem = "" Then 'Kiem tra so the bao hiem
        MsgBox "Ban chua nhap so the bao hiem", vbInformation
        Exit Sub
    Else
        SQL = "Select * From tblBaoHiemYTe Where SoTheBHYT=" & _
                    SoTheBaoHiem
        If Kt_Text(SQL) = False Then
            MsgBox "Ban vui long nhap lai so the bao hiem, so the nay da co trong CSDL", vbCritical
            Exit Sub
        End If
    End If ' Kiem tra so the bao hiem
    '---------- Kiem tra ngay thang ------------------------------
    If (NgayBatDau = "NotOK") Or (NgayKetThuc = "NotOK") Then
        MsgBox "Ban vui long kiem tra lai ngay thang vua nhap" & Chr(13) & Chr(10) & _
                        "Ngay bat dau hoac ngay ket thuc khong hop le", vbCritical
        Exit Sub
    Else
        If (Date - DateValue(NgayBatDau) < 0) Or (Date - DateValue(NgayBatDau) > 1600) Then
            MsgBox " Ngay bat dau khong hop le, ngay nay sau ngay hien tai" & Chr(13) & Chr(10) _
                                & "hoac truoc ngay hien tai lau qua roi", vbCritical
            Exit Sub
        End If
        If (DateValue(NgayKetThuc) - DateValue(NgayBatDau) < 0) Or (DateValue(NgayKetThuc) - Date > 400) Then
            MsgBox "Ngay bat dau sau ngay ket thuc hoac ngay ket thuc qua xa(sau ngay hien tai lau qua roi)", vbCritical
            Exit Sub
        End If ' Ngay ket thuc co truoc ngay bat dau?
    End If ' Kiem tra ngay bat dau, ket thuc
'---------- kiem tra phan tram -----------
    If PhanTram < 1 Then
            MsgBox "Phan tram bao hiem < 0", vbCritical
            Exit Sub
    Else
            If PhanTram > 99 Then
                MsgBox "Phan tram khong duoc lon hon 100"
                Exit Sub
            End If
    End If 'Kiem tra phan tram
    '-------------------------------------------
    Unload Me
End Sub

Private Sub cmdThoat_Click()
    SoTheBaoHiem = ""
    Unload Me
End Sub

Private Sub Form_Load()
    Dim rs As ADODB.Recordset, rsCanBo As ADODB.Recordset
    Dim SQL$, MaBenhNhan$, HoTenBenhNhan$
    Dim NgaySinh$, GioiTinh As Boolean
    Dim SQLCanBo$
    '-------------------------------------
    txtHoTenBenhNhan.Enabled = False
    txtTenCoQuan.Enabled = False
    txtDienThoaiCoQuan.Enabled = False
    txtFaxCoQuan.Enabled = False
    txtMaCoQuan.Enabled = False
    '----------------------------------------
    frmBenhNhan.clBenhNhan.TraThongTinVeTuDanhSachBenhNhan _
                MaBenhNhan, HoTenBenhNhan, NgaySinh, GioiTinh
    frmBenhNhan.clBenhNhan.SetNullBenhNhan
    '------------------------------------------------------------
    txtHoTenBenhNhan.Text = HoTenBenhNhan
    If CoMoi = "Xem" Then
        SQL = "Select * From tblBaoHiemYTe Where MaBenhNhan= " & _
                     MaBenhNhan
        '--- Cam truy cap chi cho phep xem -------------------
        txtSoTheBaoHiem.Enabled = False
        marNgayBatDau.Enabled = False
        marNgayKetThuc.Enabled = False
        txtPhanTram.Enabled = False
        cmdChapNhan.Enabled = False
        chkThuocCoQuan.Enabled = False
        '-------- Thuc hien truy van lay du lieu -----------------
        Set rs = cn.Execute(SQL)
        If rs.EOF = False Then
            txtSoTheBaoHiem.Text = Trim(rs.Fields("SoTheBHYT"))
            marNgayBatDau.Text = Trim(rs.Fields("NgayBatDau"))
            marNgayKetThuc.Text = Trim(rs.Fields("NgayKetThuc"))
            txtPhanTram.Text = Trim(rs.Fields("PhanTram"))
        End If
        SQLCanBo = "Select * From tblCoQuan Where MaCoQuan=(" & _
                            "Select MaCoQuan From tblCanBo Where MaBenhNhan=" & _
                            MaBenhNhan & ")"
        Set rsCanBo = cn.Execute(SQLCanBo)
        If rsCanBo.EOF = False Then
            txtMaCoQuan.Text = Trim(rsCanBo.Fields("MaCoQuan"))
            txtTenCoQuan.Text = Trim(rsCanBo.Fields("TenCoQuan"))
            txtFaxCoQuan.Text = Trim(rsCanBo.Fields("FaxCoQuan"))
            txtDienThoaiCoQuan.Text = Trim(rsCanBo.Fields("DienThoaiCoQuan"))
        End If
    Else
        If CoMoi = "Moi" Then
            cmdChapNhan.Enabled = True
            txtSoTheBaoHiem.Text = ""
            marNgayBatDau.Text = "__/__/____"
            marNgayKetThuc.Text = "__/__/____"
            txtPhanTram.Text = ""
        End If 'End if co moi
    End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
    If SoTheBaoHiem = "" Then
        clBaoHiem.SetNull
    Else
        clBaoHiem.TTBaoHiemVao SoTheBaoHiem, NgayBatDau, _
                    NgayKetThuc, PhanTram, MaCoQuan
    End If
End Sub

Private Sub txtPhanTram_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, True
End Sub

Private Sub txtSoTheBaoHiem_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub
