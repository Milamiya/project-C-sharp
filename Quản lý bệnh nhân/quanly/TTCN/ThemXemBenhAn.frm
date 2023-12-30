VERSION 5.00
Object = "{C932BA88-4374-101B-A56C-00AA003668DC}#1.1#0"; "MSMASK32.OCX"
Begin VB.Form frmThemXemBenhAn 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Thong tin benh an"
   ClientHeight    =   5685
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   7695
   Icon            =   "ThemXemBenhAn.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5685
   ScaleWidth      =   7695
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame2 
      Caption         =   "Chöùc naêng"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Left            =   120
      TabIndex        =   13
      Top             =   4320
      Width           =   7455
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
         Left            =   3960
         TabIndex        =   15
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
         Left            =   960
         TabIndex        =   14
         Top             =   360
         Width           =   2175
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Thoâng tin beänh aùn cuûa beänh nhaân "
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   4095
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   7455
      Begin VB.TextBox txtNoiDieuTri 
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
         Left            =   2640
         TabIndex        =   16
         Top             =   3480
         Width           =   4095
      End
      Begin VB.TextBox txtTenBenh 
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
         Left            =   2640
         TabIndex        =   12
         Top             =   2880
         Width           =   4095
      End
      Begin VB.TextBox txtBenhNhan 
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
         Left            =   2640
         TabIndex        =   11
         Top             =   2400
         Width           =   4095
      End
      Begin VB.TextBox txtNhanVien 
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
         Left            =   2640
         TabIndex        =   10
         Top             =   1920
         Width           =   4095
      End
      Begin MSMask.MaskEdBox marNgayRa 
         Height          =   375
         Left            =   2640
         TabIndex        =   9
         Top             =   1440
         Width           =   4095
         _ExtentX        =   7223
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
      Begin MSMask.MaskEdBox marNgayVao 
         Height          =   375
         Left            =   2640
         TabIndex        =   8
         Top             =   960
         Width           =   4095
         _ExtentX        =   7223
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
      Begin VB.TextBox txtmaBenhAn 
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
         Left            =   2640
         MaxLength       =   10
         TabIndex        =   7
         Top             =   480
         Width           =   4095
      End
      Begin VB.Label Label1 
         Caption         =   "Nôi ñieàu trò"
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
         Index           =   1
         Left            =   240
         TabIndex        =   17
         Top             =   3480
         Width           =   1815
      End
      Begin VB.Label Label6 
         Caption         =   "Maõ beänh aùn"
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
         TabIndex        =   6
         Top             =   480
         Width           =   2175
      End
      Begin VB.Label Label5 
         Caption         =   "Ngaøy ra"
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
         TabIndex        =   5
         Top             =   1440
         Width           =   1935
      End
      Begin VB.Label Label4 
         Caption         =   "Ngaøy vaøo "
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
         Top             =   960
         Width           =   2175
      End
      Begin VB.Label Label3 
         Caption         =   "Beänh"
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
         Top             =   2880
         Width           =   2295
      End
      Begin VB.Label Label2 
         Caption         =   "Nhaân vieân laäp beänh aùn"
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
         Top             =   1920
         Width           =   2295
      End
      Begin VB.Label Label1 
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
         Index           =   0
         Left            =   240
         TabIndex        =   1
         Top             =   2400
         Width           =   2415
      End
   End
End
Attribute VB_Name = "frmThemXemBenhAn"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Public Co$
Dim MaBenhAn$, MaNhanVien$, NgayVao$, NgayRa$
Dim MaNoiDieuTri$, MaBenh$
Public clBenhAn As New clBenhAnBenhNhan

Private Sub cmdChapNhan_Click()
    Dim SQL$, TenBenh$, TenNhanVien$
    '--------------------------------------------
    MaBenhAn = Trim(txtmaBenhAn.Text)
    NgayVao = SuLiNgay(marNgayVao.Text)
    NgayRa = Trim(marNgayRa.Text)
    If MaBenhAn = "" Then
        MsgBox "Ban chua nhap ma benh an", vbInformation
        Exit Sub
    Else
        SQL = "Select MaBenhAn From tblBenhAn Where tblBenhAn.MaBenhAn ='" & _
                MaBenhAn & "'"
        If Kt_Text(SQL) = False Then
            MsgBox "Ma benh an nay da co trong co so du lieu", vbCritical
            Exit Sub
        End If
    End If
    If NgayVao = "NotOK" Then
        MsgBox "Ngay vao vien cua benh nhan khong hop le", vbCritical
        Exit Sub
    Else 'Ngay vao vien da dung
    '------------------------------------
        If Date - DateValue(NgayVao) < 0 Then
            MsgBox "Ngay vao sau ngay hien tai", vbCritical
            Exit Sub
        Else ' Ngay vao da truoc ngay hien tai
        '-----------------------------------------
            If Date - DateValue(NgayVao) > 1800 Then
                MsgBox "Ngayvao vien cua benh nhan cach ngay hien tai xa qua", vbCritical
                Exit Sub
            End If
            If NgayRa <> "__/__/____" Then ' Xem ngay ra co dung khong
                NgayRa = SuLiNgay(NgayRa)
                If NgayRa = "NotOK" Then 'Ngay ra co hop le
                    MsgBox "Ngay ra nay khong hop le", vbCritical
                    Exit Sub
                Else
                    If Date - DateValue(NgayRa) < 0 Then
                        MsgBox "Ngay ra sau ngay hien tai", vbCritical
                        Exit Sub
                    End If
                '--  kiem tra ngay vao co truoc ngay ra khong  -------------------------
                    If DateValue(NgayRa) - DateValue(NgayVao) < 0 Then
                        MsgBox "ban vui long kiem tra lai ngay thang, ngay vao sau ngay ra", vbCritical
                        Exit Sub
                    End If 'End if kiem tra ngay vao co truoc ngay ra
                '------------------------------------
                End If ' Ngay ra co hop le
            Else
                NgayRa = ""
            End If 'Ngay ra=""
        End If ' End if kiem tra ngay vao co sau ngay hien tai khong
    '-----------------
    End If 'Kiem tra ngay thang
    '--- Xac dinh benh cua benh nhan
    'frmDanhSachBenh.clBenh.ThongTTRa MaBenh, TenBenh
    'frmDanhSachBenh.clBenh.SetNull
    MaBenh = Trim(MaBenh)
    If MaBenh = "" Then
        MsgBox "Ban chua nhap benh cua benh nhan", vbInformation
        Exit Sub
    Else
        'txtTenBenh.Text = Trim(TenBenh)
    End If
    '--- Xac dinh nhan vien lap benh an
    'frmDanhSachNhanVien.clNhanVien.TraTTNhanVien MaNhanVien, _
                                                                    TenNhanVien
    'frmDanhSachNhanVien.clNhanVien.SetNull
    MaNhanVien = Trim(MaNhanVien)
    If MaNhanVien = "" Then
        MsgBox "Ban chua nhap ten nhan vien lap benh an", vbInformation
        Exit Sub
    Else
        txtNhanVien.Text = Trim(TenNhanVien)
    End If
    '--------------------------------------------------------------
    Unload Me
End Sub

Private Sub cmdThoat_Click()
    MaBenhAn = ""
    Unload Me
End Sub

Private Sub Form_Load()
    Dim MaBenhNhan$, HoTen$, NgaySinh$, GioiTinh As Boolean
    Dim SQL$
    Dim rs As ADODB.Recordset
    '---------------------------------------
    frmBenhNhan.clBenhNhan.TraThongTinVeTuDanhSachBenhNhan _
                        MaBenhNhan, HoTen, NgaySinh, GioiTinh
    frmBenhNhan.clBenhNhan.SetNullBenhNhan
    '---------------------------------------------------
    If Co = "Xem" Then
        marNgayVao.Enabled = False
        cmdChapNhan.Enabled = False
        marNgayRa.Enabled = False
        txtBenhNhan.Enabled = False
        txtTenBenh.Enabled = False
        txtNhanVien.Enabled = False
        txtmaBenhAn.Enabled = False
        txtNoiDieuTri.Enabled = False
        '------------------------------------
        SQL = "Select * From vwBenhAn Where MaBenhNhan=" & MaBenhNhan
        txtBenhNhan.Text = HoTen
        Set rs = cn.Execute(SQL)
        If rs.EOF = False Then
            marNgayVao.Text = rs.Fields("NgayVao")
            If Trim(rs.Fields("NgayRa")) <> "" Then
                marNgayRa.Text = rs.Fields("NgayRa")
            Else
                marNgayRa.Text = "__/__/____"
            End If
            txtmaBenhAn.Text = rs.Fields("MaBenhAn")
            txtNhanVien.Text = rs.Fields("HoTenNhanVien")
            txtTenBenh.Text = rs.Fields("TenBenh")
            txtNoiDieuTri.Text = rs.Fields("TenNoiDieuTri")
        End If
    Else ' Truong hop lap mot benh an moi
        If Co = "Moi" Then
            txtBenhNhan.Enabled = False
            txtBenhNhan.Text = HoTen
        End If
    End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
    If MaBenhAn = "" Then
        clBenhAn.SetNull
    Else
        clBenhAn.TTBenhAnVao MaBenhAn, MaNhanVien, MaBenh, _
                                                    MaNoiDieuTri, NgayVao, NgayRa
    End If
End Sub

Private Sub txtmaBenhAn_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub

Private Sub txtNhanVien_Click()
    Dim HoTenNhanVien$
    frmDanhSachNhanVien.Show 1
    frmDanhSachNhanVien.clNhanVien.TraTTNhanVien MaNhanVien, _
                    HoTenNhanVien
    txtNhanVien.Text = HoTenNhanVien
    frmDanhSachNhanVien.clNhanVien.SetNull
End Sub

Private Sub txtNoiDieuTri_Click()
    Dim TenNoiDieuTri$
    frmDanhSachNoiDieuTri.Show 1
    frmDanhSachNoiDieuTri.clNoiDieuTri.TraTTNoiDT _
                                                        MaNoiDieuTri, TenNoiDieuTri
    frmDanhSachNoiDieuTri.clNoiDieuTri.SetNull
    If Trim(MaNoiDieuTri) <> "" Then
        txtNoiDieuTri.Text = Trim(TenNoiDieuTri)
    End If
End Sub

Private Sub txtTenBenh_Click()
    Dim TenBenh$
    frmDanhSachBenh.Show 1
    frmDanhSachBenh.clBenh.ThongTTRa MaBenh, TenBenh
    frmDanhSachBenh.clBenh.SetNull
    txtTenBenh.Text = Trim(TenBenh)
    frmDanhSachBenh.clBenh.SetNull
End Sub
