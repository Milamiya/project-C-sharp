VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Object = "{C932BA88-4374-101B-A56C-00AA003668DC}#1.1#0"; "MSMASK32.OCX"
Begin VB.Form frmBenhAn 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Benh An"
   ClientHeight    =   8010
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6975
   Icon            =   "BenhAn.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   8010
   ScaleWidth      =   6975
   StartUpPosition =   1  'CenterOwner
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
      Height          =   975
      Left            =   120
      TabIndex        =   12
      Top             =   6960
      Width           =   6735
      Begin VB.CommandButton cmdLuu 
         Caption         =   "Löu"
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
         Left            =   4320
         TabIndex        =   17
         Top             =   360
         Width           =   975
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
         Height          =   375
         Left            =   5640
         TabIndex        =   16
         Top             =   360
         Width           =   975
      End
      Begin VB.CommandButton cmdXoa 
         Caption         =   "Xoùa"
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
         Left            =   2880
         TabIndex        =   15
         Top             =   360
         Width           =   1095
      End
      Begin VB.CommandButton cmdSua 
         Caption         =   "Söûa"
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
         Left            =   1440
         TabIndex        =   14
         Top             =   360
         Width           =   1095
      End
      Begin VB.CommandButton cmdMoi 
         Caption         =   "Môùi"
         CausesValidation=   0   'False
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
         TabIndex        =   13
         ToolTipText     =   "Them du lieu"
         Top             =   360
         Width           =   1095
      End
   End
   Begin MSComctlLib.ListView lstBenhAn 
      Height          =   3255
      Left            =   120
      TabIndex        =   11
      Top             =   3720
      Width           =   6735
      _ExtentX        =   11880
      _ExtentY        =   5741
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
      NumItems        =   11
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Maõ Beänh aùn"
         Object.Width           =   2539
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Ngaøy vaøo"
         Object.Width           =   2274
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Ngaøy ra"
         Object.Width           =   2274
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "Teân beänh nhaân"
         Object.Width           =   4691
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Text            =   "Teân nhaân vieân"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   5
         Text            =   "MaNhanVien"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(7) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   6
         Text            =   "MaBenhNhan"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(8) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   7
         Text            =   "Tenbenh"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(9) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   8
         Text            =   "MaBenh"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(10) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   9
         Text            =   "TenNoiDieuTri"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(11) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   10
         Text            =   "MaNoiDieuTri"
         Object.Width           =   0
      EndProperty
   End
   Begin VB.Frame Frame1 
      Height          =   3615
      Left            =   120
      TabIndex        =   0
      Top             =   0
      Width           =   6735
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
         Left            =   2520
         TabIndex        =   20
         Top             =   1200
         Width           =   3735
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
         Left            =   2520
         TabIndex        =   18
         Top             =   1680
         Width           =   3735
      End
      Begin MSMask.MaskEdBox marNgayRa 
         Height          =   375
         Left            =   2520
         TabIndex        =   10
         Top             =   3120
         Width           =   3735
         _ExtentX        =   6588
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
         Left            =   2520
         TabIndex        =   9
         Top             =   2640
         Width           =   3735
         _ExtentX        =   6588
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
      Begin VB.TextBox txtMaBenhAn 
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
         MaxLength       =   10
         TabIndex        =   8
         Top             =   2160
         Width           =   3735
      End
      Begin VB.TextBox txtTenNhanVien 
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
         TabIndex        =   7
         Top             =   720
         Width           =   3735
      End
      Begin VB.TextBox txtTenBenhNhan 
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
         TabIndex        =   6
         Top             =   240
         Width           =   3735
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
         Left            =   120
         TabIndex        =   21
         Top             =   1200
         Width           =   1815
      End
      Begin VB.Label Label6 
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
         Left            =   120
         TabIndex        =   19
         Top             =   1680
         Width           =   2295
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
         Left            =   120
         TabIndex        =   5
         Top             =   3120
         Width           =   2175
      End
      Begin VB.Label Label4 
         Caption         =   "Ngaøy vaøo"
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
         Top             =   2640
         Width           =   1695
      End
      Begin VB.Label Label3 
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
         Height          =   255
         Left            =   120
         TabIndex        =   3
         Top             =   2160
         Width           =   1935
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
         Left            =   120
         TabIndex        =   2
         Top             =   720
         Width           =   2295
      End
      Begin VB.Label Label1 
         Caption         =   "Beänh nhaân"
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
         Left            =   120
         TabIndex        =   1
         Top             =   240
         Width           =   1815
      End
   End
End
Attribute VB_Name = "frmBenhAn"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim MaBenhNhanLst$, MaNhanVienlst$, CoLuu$, MaNoiDieuTrilst$
Dim MaNhanVien$, MaBenhNhan$, MaBenh$, MaBenhlst$
Dim MaNoiDieuTri$

Private Sub cmdLuu_Click()
    Dim MaBenhAn$, SQL$, SQLBenhNhan$
    Dim NgayVao$, NgayRa$
    '------------------------
    MaBenhAn = Trim(txtmaBenhAn.Text)
    NgayVao = SuLiNgay(marNgayVao.Text)
    NgayRa = marNgayRa.Text
'-----------------------------------------
    If CoLuu = "Moi" Then
        If MaBenhAn = "" Then 'KiemTra ma benh an
            MsgBox "Ban chua nhap ma benh an", vbInformation
            Exit Sub
        Else
            SQL = "Select MaBenhAn from tblBenhAn Where MaBenhAn='" & MaBenhAn & "'"
            If Kt_Text(SQL) = False Then ' kiem tra ma co trong CSDL chua
                MsgBox "Ban vui long nhap lai ma benh an, ma nay da co trong CSDL", vbCritical
                Exit Sub
            End If ' kiem tra xem ma da co trong CSDL chua
        End If ' End if mabenh an=""
    '------------------------------------------
        If MaBenhNhan = "" Then 'Kiem tra co benh nhan chua
            MsgBox "Ban chua chon benh nhan can lap benh an"
            Exit Sub
        Else 'Ma benh nhan <>""
            SQLBenhNhan = "Select MaBenhan From tblBenhAn Where MaBenhNhan=" & _
                            MaBenhNhan
            If Kt_Text(SQLBenhNhan) = False Then 'Kiem tra xem benh nhan co benh an chua
                MsgBox "Benh nhan nay da co benh an roi", vbCritical
                Exit Sub
            End If
        End If
    '----------------------
        If MaNhanVien = "" Then 'kiem tra nhan vien
            MsgBox "Ban chua nhap nhan vien viet benh an", vbInformation
            Exit Sub
        End If
    '----------------------------
        If MaBenh = "" Then
            MsgBox "Ban chua nhap benh cua benh nhan", vbInformation
            Exit Sub
        End If
    '-----------------------------
    If MaNoiDieuTri = "" Then
        MsgBox "Ban chua nhap noi dieu tri", vbInformation
        Exit Sub
    End If
    '--- kiem tra ngay thang
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
        DE.sp_NhapBenhAn MaBenhAn, MaBenhNhan, MaNhanVien, MaBenh, _
                                MaNoiDieuTri, NgayVao, Trim(NgayRa)
        disPlayListBenhAn
        SetNull
    Else
        If CoLuu = "Sua" Then 'Sua ban tin
            If Trim(MaBenhAn) = "" Then
                MsgBox "Ban chua chon benh an can sua", vbInformation
                Exit Sub
            End If
            '------------------------------------------
            If Trim(MaBenhNhan) = "" Then MaBenhNhan = MaBenhNhanLst
            If Trim(MaNhanVien) = "" Then MaNhanVien = MaNhanVienlst
            If Trim(MaBenh) = "" Then MaBenh = MaBenhlst
            If Trim(MaNoiDieuTri) = "" Then MaNoiDieuTri = MaNoiDieuTrilst
            '-----------------------------------------------
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
            DE.sp_SuaBenhAn MaBenhAn, MaBenhNhan, MaNhanVien, MaBenh, _
                            MaNoiDieuTri, Format(NgayVao, "dd/mm/yyyy"), NgayRa
            disPlayListBenhAn
        End If ' Sua ban tin
    End If 'Coluu= Moi
End Sub

Private Sub cmdMoi_Click()
    txtmaBenhAn.Enabled = True
    txtTenBenhNhan.Enabled = True
    txtTenNhanVien.Enabled = True
    marNgayVao.Enabled = True
    marNgayRa.Enabled = True
    cmdLuu.Enabled = True
    txtTenBenh.Enabled = True
    txtNoiDieuTri.Enabled = True
    CoLuu = "Moi"
    SetNull
End Sub

Private Sub cmdSua_Click()
    txtmaBenhAn.Enabled = False
    txtTenBenhNhan.Enabled = True
    txtTenNhanVien.Enabled = True
    txtTenBenh.Enabled = True
    txtNoiDieuTri.Enabled = True
    marNgayVao.Enabled = True
    marNgayRa.Enabled = True
    cmdLuu.Enabled = True
    CoLuu = "Sua"
End Sub

Private Sub cmdThoat_Click()
    Unload Me
End Sub

Private Sub disPlayListBenhAn()
    Dim SQL$, mItem As listItem
    Dim rs As ADODB.Recordset
    lstBenhAn.ListItems.Clear
    SQL = "Select * From vwBenhAn Order By MaBenhAn"
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenhAn.ListItems.Add(, , Trim(rs!MaBenhAn))
                mItem.SubItems(1) = rs!NgayVao
                mItem.SubItems(2) = rs!NgayRa
                mItem.SubItems(4) = rs!HoTenNhanVien
                mItem.SubItems(3) = Trim(rs!HoBenhNhan) & " " & Trim(rs!TenBenhNhan)
                mItem.SubItems(5) = Trim(rs!MaNhanVien)
                mItem.SubItems(6) = Trim(rs!MaBenhNhan)
                mItem.SubItems(7) = Trim(rs!TenBenh)
                mItem.SubItems(8) = Trim(rs!MaBenh)
                mItem.SubItems(9) = Trim(rs!TenNoiDieuTri)
                mItem.SubItems(10) = Trim(rs!MaNoiDieuTri)
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub cmdXoa_Click()
    Dim Msg As Long
    Dim MaBenhAn$
    MaBenhAn = Trim(txtmaBenhAn.Text)
    Msg = MsgBox("Ban co chac chan xoa benh an nay khong ?", vbQuestion + vbYesNo)
    If Msg = vbYes Then
        DE.sp_XoaBenhAn MaBenhAn
        disPlayListBenhAn
        SetNull
    End If
End Sub

Private Sub Form_Load()
    txtmaBenhAn.Enabled = False
    txtTenNhanVien.Enabled = False
    txtTenBenhNhan.Enabled = False
    marNgayVao.Enabled = False
    marNgayRa.Enabled = False
    cmdLuu.Enabled = False
    txtTenBenh.Enabled = False
    txtNoiDieuTri.Enabled = False
    '----------------------------------------
    cmdMoi.Enabled = Flag
    cmdSua.Enabled = Flag
    cmdXoa.Enabled = Flag
    disPlayListBenhAn
End Sub

Private Sub lstBenhAn_ItemClick(ByVal Item As MSComctlLib.listItem)
    txtmaBenhAn.Enabled = False
    txtmaBenhAn.Text = Item.Text
    marNgayVao.Text = Item.SubItems(1)
    If Trim(Item.SubItems(2)) <> "" Then
        marNgayRa.Text = Item.SubItems(2)
    Else
        marNgayRa.Text = "__/__/____"
    End If
    txtTenBenhNhan.Text = Item.SubItems(3)
    txtTenNhanVien.Text = Item.SubItems(4)
    MaNhanVienlst = Item.SubItems(5)
    MaBenhNhanLst = Item.SubItems(6)
    MaBenhlst = Item.SubItems(8)
    txtTenBenh.Text = Item.SubItems(7)
    txtNoiDieuTri.Text = Item.SubItems(9)
    MaNoiDieuTrilst = Item.SubItems(10)
End Sub

Private Sub txtmaBenhAn_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub

Private Sub txtNoiDieuTri_Click()
    Dim TenNoiDieuTri$
    frmDanhSachNoiDieuTri.Show 1
    frmDanhSachNoiDieuTri.clNoiDieuTri.TraTTNoiDT MaNoiDieuTri, TenNoiDieuTri
    txtNoiDieuTri.Text = Trim(TenNoiDieuTri)
End Sub

Private Sub txtTenBenh_Click()
    Dim TenBenh$
    frmDanhSachBenh.Show 1
    frmDanhSachBenh.clBenh.ThongTTRa MaBenh, TenBenh
    txtTenBenh.Text = TenBenh
End Sub

Private Sub txtTenBenhNhan_Click()
    Dim HoTenBenhNhan$, NgaySinh$, GioiTinh As Boolean
    frmDanhSachBenhNhan.Show 1
    frmDanhSachBenhNhan.clThongTinBenhNhan.TraThongTinVeTuDanhSachBenhNhan _
                                MaBenhNhan, HoTenBenhNhan, NgaySinh, GioiTinh
    If CoLuu = "Sua" Then
        If Trim(MaBenhNhan) <> "" Then
            MaBenhNhanLst = MaBenhNhan
        End If
    End If
    If Trim(HoTenBenhNhan) <> "" Then
        txtTenBenhNhan = HoTenBenhNhan
    End If
End Sub

Private Sub txtTenNhanVien_Click()
    Dim HoTenNhanVien$
    frmDanhSachNhanVien.Show 1
    frmDanhSachNhanVien.clNhanVien.TraTTNhanVien MaNhanVien, _
                                                                HoTenNhanVien
    If CoLuu = "Sua" Then
        If Trim(MaNhanVien) <> "" Then
            MaNhanVienlst = MaNhanVien
        End If
    End If
    If Trim(MaNhanVien) <> "" Then
        txtTenNhanVien.Text = HoTenNhanVien
    End If
End Sub

Private Sub SetNull()
    txtNoiDieuTri.Text = ""
    txtmaBenhAn.Text = ""
    txtTenBenhNhan.Text = ""
    txtTenNhanVien.Text = ""
    txtTenBenh.Text = ""
    marNgayVao.Text = "__/__/____"
    marNgayRa.Text = "__/__/____"
End Sub

