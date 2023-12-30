VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Object = "{C932BA88-4374-101B-A56C-00AA003668DC}#1.1#0"; "MSMASK32.OCX"
Begin VB.Form frmBaoHiemYTe 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Bao Hiem Y Te"
   ClientHeight    =   7935
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   11415
   Icon            =   "BaoHiemYTe.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7935
   ScaleWidth      =   11415
   StartUpPosition =   1  'CenterOwner
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
      Height          =   2895
      Left            =   6240
      TabIndex        =   18
      Top             =   0
      Width           =   5055
      Begin VB.CheckBox chkCoQuan 
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
         Height          =   375
         Left            =   120
         TabIndex        =   27
         Top             =   360
         Width           =   2655
      End
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
         Left            =   1440
         TabIndex        =   26
         Top             =   840
         Width           =   3495
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
         Left            =   1440
         TabIndex        =   25
         Top             =   1320
         Width           =   3495
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
         Height          =   405
         Left            =   1440
         TabIndex        =   24
         Top             =   1800
         Width           =   3495
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
         Height          =   405
         Left            =   1440
         TabIndex        =   23
         Top             =   2280
         Width           =   3495
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
         Top             =   840
         Width           =   1455
      End
      Begin VB.Label Label8 
         Caption         =   "Fax "
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
         TabIndex        =   21
         Top             =   2280
         Width           =   1575
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
         TabIndex        =   20
         Top             =   1800
         Width           =   1575
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
         TabIndex        =   19
         Top             =   1320
         Width           =   1455
      End
   End
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
      Top             =   6840
      Width           =   11175
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
         Left            =   7440
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
         Left            =   9840
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
         Left            =   5040
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
         Left            =   2760
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
         Left            =   360
         TabIndex        =   13
         ToolTipText     =   "Them du lieu"
         Top             =   360
         Width           =   1095
      End
   End
   Begin MSComctlLib.ListView lstBaoHiem 
      Height          =   3735
      Left            =   120
      TabIndex        =   11
      Top             =   3000
      Width           =   11175
      _ExtentX        =   19711
      _ExtentY        =   6588
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
         Text            =   "Soá theû "
         Object.Width           =   2611
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Ngaøy baét ñaàu"
         Object.Width           =   2999
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Ngaøy Keát thuùc"
         Object.Width           =   3174
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "Phaàn Traêm"
         Object.Width           =   2470
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Text            =   "Hoï teân beänh nhaân"
         Object.Width           =   8272
      EndProperty
      BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   5
         Text            =   "MaBenhNhan"
         Object.Width           =   0
      EndProperty
   End
   Begin VB.Frame Frame1 
      Height          =   2775
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   6015
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
         TabIndex        =   10
         Top             =   2160
         Width           =   3615
      End
      Begin MSMask.MaskEdBox marNgayKetThuc 
         Height          =   375
         Left            =   2160
         TabIndex        =   9
         Top             =   1680
         Width           =   3615
         _ExtentX        =   6376
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
      Begin MSMask.MaskEdBox marNgayBatDau 
         Height          =   375
         Left            =   2160
         TabIndex        =   8
         Top             =   1200
         Width           =   3615
         _ExtentX        =   6376
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
         TabIndex        =   7
         Top             =   720
         Width           =   3615
      End
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
         TabIndex        =   6
         Top             =   240
         Width           =   3615
      End
      Begin VB.Label Label5 
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
         Left            =   120
         TabIndex        =   5
         Top             =   2160
         Width           =   1695
      End
      Begin VB.Label Label4 
         Caption         =   "Ngaøy keát thuùc "
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
         Top             =   1680
         Width           =   1575
      End
      Begin VB.Label Label3 
         Caption         =   "Ngaøy baét ñaàu "
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
         Top             =   1200
         Width           =   1815
      End
      Begin VB.Label Label2 
         Caption         =   "Soá theû baûo hieåm y teá"
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
         Width           =   1935
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
         Left            =   120
         TabIndex        =   1
         Top             =   240
         Width           =   1935
      End
   End
End
Attribute VB_Name = "frmBaoHiemYTe"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim MaBenhNhan$, MaBenhNhanLst$, MaCoQuanlst$
Dim CoLuu$

Private Sub chkCoQuan_Click()
    Dim MaCoQuan$, TenCoQuan$, DienThoai$, Fax$
    If chkCoQuan.Value = 1 Then ' Nut duoc chon
        frmDanhsachCQ.Show 1
        frmDanhsachCQ.clCoQuan.TTcoQuanRa MaCoQuan, TenCoQuan, _
                    DienThoai, Fax
        If MaCoQuan <> "" Then
            txtMaCoQuan.Text = Trim(MaCoQuan)
            txtTenCoQuan.Text = TenCoQuan
            txtDienThoaiCoQuan.Text = DienThoai
            txtFaxCoQuan.Text = MaCoQuan
        Else
            chkCoQuan.Value = 0
        End If
    Else
        frmDanhsachCQ.clCoQuan.SetNull
    End If
End Sub

Private Sub cmdLuu_Click()
    Dim NgayBatDau$, NgayKetThuc$
    Dim SQL$, SoTheBaoHiem$, SQLBenhNhan$
    Dim PhanTram As Currency
    Dim MaCoQuan$, TenCoQuan$, DienThoai$, Fax$
    Dim CoLuuCoQuan As Boolean
    '-------------------------------------------
    NgayBatDau = SuLiNgay(marNgayBatDau.Text)
    NgayKetThuc = SuLiNgay(marNgayKetThuc.Text)
    '------------------------------------------------------------
    frmDanhsachCQ.clCoQuan.TTcoQuanRa MaCoQuan, TenCoQuan, _
                    DienThoai, Fax
    frmDanhsachCQ.clCoQuan.SetNull ' Lay thong tin xong set null bien
    '---------------------------
    CoLuuCoQuan = False
    If Trim(MaCoQuan) <> "" Then
        CoLuuCoQuan = True
    End If
    '------------------------------------------------------------
    If Trim(txtPhanTram.Text <> "") Then
        PhanTram = Trim(txtPhanTram.Text)
    Else
        PhanTram = 0
    End If
    '------------------------------------------------------
    If CoLuu = "Moi" Then 'Che do Tao Moi
        SoTheBaoHiem = Trim(txtSoTheBaoHiem.Text)
        If SoTheBaoHiem = "" Then 'Kiem tra so the
            MsgBox "Ban chua nhap so the bao hiem", vbInformation
            Exit Sub
        Else
            SQL = "Select SoTheBHYT From tblBaoHiemYTe Where SoTheBHYT=" & _
                            SoTheBaoHiem
            If Kt_Text(SQL) = False Then ' So the da co
                MsgBox "Ban vui long sua lai so the bao hiem, so nay da co trong CSDL", vbCritical
                Exit Sub
            Else ' So the Da duoc chap nhan
                SQLBenhNhan = "Select SoTheBHYT From tblBaoHiemYTe Where MaBenhNhan=" & _
                            MaBenhNhan
                If Kt_Text(SQLBenhNhan) = False Then 'Xem benh nhan da luu the chua
                    MsgBox "Benh nhan nay da luu the bao hiem roi", vbCritical
                    Exit Sub
                Else ' Benh nhan chua luu bao hiem y te
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
                '---------- Ket thuc kiem tra ngay thang  -----------
                End If ' benh nhan da luu the chua
                '-------- kiem tra phan tram --------------
                If PhanTram < 1 Then
                    MsgBox "Phan tram bao hiem < 0", vbCritical
                    Exit Sub
                Else
                    If PhanTram > 99 Then
                        MsgBox "Phan tram khong duoc lon hon 100"
                        Exit Sub
                    End If
                End If 'Kiem tra phan tram
            End If ' End If so the da co
            DE.sp_NhapBaoHiem MaBenhNhan, SoTheBaoHiem, _
                                    Format(NgayBatDau, "dd/mm/yyyy"), _
                                    Format(NgayKetThuc, "dd/mm/yyyy"), PhanTram
            '----- 'Benh nhan co the bao hiem y te thuoc co quan
            If CoLuuCoQuan = True Then
                DE.sp_NhapCanBo MaBenhNhan, MaCoQuan
            End If
            DisPlayListBaoHiem
            SetNull
        End If
    Else ' Colu= Sua
        '----- Sua ban tin ----------
        If CoLuu = "Sua" Then 'Sua ban tin
                        '---------- Kiem tra ngay thang ------------------------------
            SoTheBaoHiem = Trim(txtSoTheBaoHiem.Text)
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
        '---------- Ket thuc kiem tra ngay thang  -----------
            If Trim(MaBenhNhan = "") Then MaBenhNhan = MaBenhNhanLst
            'If Trim(MaCoQuan = "") Then MaCoQuan = MaCoQuanlst
            If PhanTram < 1 Then
                MsgBox "Phan tram bao hiem < 0", vbCritical
                Exit Sub
            Else
                If PhanTram > 99 Then
                    MsgBox "Phan tram khong duoc lon hon 100"
                    Exit Sub
                End If
            End If 'Kiem tra phan tram
            DE.sp_SuaBaoHiem MaBenhNhan, SoTheBaoHiem, _
                                    Format(NgayBatDau, "dd/mm/yyyy"), _
                                    Format(NgayKetThuc, "dd/mm/yyyy"), PhanTram
            '----- Sua Ma co quan sau do sua MaBenhNhan trong tblCanBo
            ' Truong hop truoc do benh nhan chua thuoc co quan nao ca
            If (Trim(MaCoQuan) <> "") And (Trim(MaCoQuanlst) = "") Then
                DE.sp_NhapCanBo MaBenhNhan, MaCoQuan
            Else
                ' Truong hop truoc do benh nhan da tuoc mot co quan
                If (Trim(MaCoQuan) <> "") And (MaCoQuanlst <> "") Then
                    ' De phong truong hop nguoi dung khong sua co quan
                    If Trim(MaCoQuan) <> Trim(MaCoQuanlst) Then
                        DE.sp_SuaCanBo MaCoQuan, MaBenhNhan
                    End If
                End If
            End If
            'DE.sp_SuaCanBo MaCoQuan, MaBenhNhan
            DisPlayListBaoHiem
        End If
    End If ' Tao moi
End Sub

Private Sub cmdMoi_Click()
    txtHoTenBenhNhan.Enabled = True
    txtPhanTram.Enabled = True
    txtSoTheBaoHiem.Enabled = True
    marNgayBatDau.Enabled = True
    marNgayKetThuc.Enabled = True
    cmdLuu.Enabled = True
    CoLuu = "Moi"
    SetNullCoQuan
    SetNull
    chkCoQuan.Value = 0
    chkCoQuan.Enabled = True
End Sub

Private Sub cmdSua_Click()
    txtHoTenBenhNhan.Enabled = True
    txtPhanTram.Enabled = True
    marNgayBatDau.Enabled = True
    marNgayKetThuc.Enabled = True
    cmdLuu.Enabled = True
    chkCoQuan.Enabled = True
    CoLuu = "Sua"
End Sub

Private Sub cmdThoat_Click()
    Unload Me
End Sub

Private Sub DisPlayListBaoHiem()
    Dim SQL$
    Dim mItem As listItem
    Dim rs As ADODB.Recordset
    '----------------------------------
    SQL = "Select * From vwBaoHiemYte Order by SoTheBHYT"
    Set rs = cn.Execute(SQL)
    lstBaoHiem.ListItems.Clear
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBaoHiem.ListItems.Add(, , Trim(rs!SoTheBHYT))
                mItem.SubItems(1) = rs!NgayBatDau
                mItem.SubItems(2) = rs!NgayKetThuc
                mItem.SubItems(3) = rs!PhanTram
                mItem.SubItems(4) = Trim(rs!HoBenhNhan) & " " & Trim(rs!TenBenhNhan)
                mItem.SubItems(5) = Trim(rs!MaBenhNhan)
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub cmdXoa_Click()
    Dim Msg As Long, SoTheBaoHiem$
    SoTheBaoHiem = Trim(txtSoTheBaoHiem.Text)
    Msg = MsgBox("Ban co chac chan xo so bao hiem nay khong", vbQuestion + vbYesNo)
    If Msg = vbYes Then
        DE.sp_XoaBaoHiem SoTheBaoHiem
        DisPlayListBaoHiem
        SetNull
    End If
End Sub

Private Sub Form_Load()
    txtHoTenBenhNhan.Enabled = False
    txtSoTheBaoHiem.Enabled = False
    marNgayBatDau.Enabled = False
    marNgayKetThuc.Enabled = False
    txtPhanTram.Enabled = False
    cmdLuu.Enabled = False
    txtMaCoQuan.Enabled = False
    txtTenCoQuan.Enabled = False
    txtDienThoaiCoQuan.Enabled = False
    txtFaxCoQuan.Enabled = False
    chkCoQuan.Enabled = False
    '-------------------------------------------
    cmdMoi.Enabled = Flag
    cmdSua.Enabled = Flag
    cmdXoa.Enabled = Flag
    '------------------------------------
    DisPlayListBaoHiem
End Sub

Private Sub lstBaoHiem_ItemClick(ByVal Item As MSComctlLib.listItem)
    Dim SQL$
    Dim rs As ADODB.Recordset
    '------------------------------------------
    txtSoTheBaoHiem.Enabled = False
    txtSoTheBaoHiem.Text = Item.Text
    marNgayBatDau.Text = Item.SubItems(1)
    marNgayKetThuc.Text = Item.SubItems(2)
    txtPhanTram.Text = Item.SubItems(3)
    txtHoTenBenhNhan.Text = Item.SubItems(4)
    MaBenhNhanLst = Item.SubItems(5)
    chkCoQuan.Value = 0
    '-----------------------------------------------
    If CoLuu = "Moi" Then
        chkCoQuan.Enabled = False
        txtHoTenBenhNhan.Enabled = False
        marNgayBatDau.Enabled = False
        marNgayKetThuc.Enabled = False
        txtPhanTram.Enabled = False
        CoLuu = ""   'Set lai coluu
    End If
    '---------------------------------------------
    SQL = "Select * From tblCoQuan Where MaCoQuan=(" & _
            "Select MaCoQuan From tblCanBo Where MaBenhNhan=" & _
            MaBenhNhanLst & ")"
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        txtMaCoQuan.Text = Trim(rs.Fields("MaCoQuan"))
        txtTenCoQuan.Text = Trim(rs.Fields("TenCoQuan"))
        txtDienThoaiCoQuan.Text = Trim(rs.Fields("DienThoaiCoQuan"))
        txtFaxCoQuan.Text = Trim(rs.Fields("faxCoQuan"))
        '----------------------------------------------------------------
        MaCoQuanlst = Trim(txtMaCoQuan.Text)
    Else
        SetNullCoQuan
        MaCoQuanlst = ""
    End If
End Sub

Private Sub txtHoTenBenhNhan_Click()
    Dim HoTenBenhNhan$, NgaySinh$, GioiTinh As Boolean
    frmDanhSachBenhNhan.Show 1
    frmDanhSachBenhNhan.clThongTinBenhNhan.TraThongTinVeTuDanhSachBenhNhan _
                                    MaBenhNhan, HoTenBenhNhan, NgaySinh, GioiTinh
    txtHoTenBenhNhan.Text = HoTenBenhNhan
End Sub

Private Sub SetNull()
    txtHoTenBenhNhan.Text = ""
    txtSoTheBaoHiem.Text = ""
    txtPhanTram.Text = ""
    marNgayBatDau.Text = "__/__/____"
    marNgayKetThuc.Text = "__/__/____"
End Sub

Private Sub SetNullCoQuan()
    txtMaCoQuan.Text = ""
    txtTenCoQuan.Text = ""
    txtDienThoaiCoQuan.Text = ""
    txtFaxCoQuan.Text = ""
End Sub

