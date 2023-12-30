VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TABCTL32.OCX"
Begin VB.Form frmCongTac 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Noi cong Tac cua nhan vien"
   ClientHeight    =   7050
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6120
   Icon            =   "CongTac.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7050
   ScaleWidth      =   6120
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin TabDlg.SSTab SSTab1 
      Height          =   5895
      Left            =   120
      TabIndex        =   0
      Top             =   1080
      Width           =   5895
      _ExtentX        =   10398
      _ExtentY        =   10398
      _Version        =   393216
      Tab             =   2
      TabHeight       =   520
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      TabCaption(0)   =   "Ñôn vò"
      TabPicture(0)   =   "CongTac.frx":0442
      Tab(0).ControlEnabled=   0   'False
      Tab(0).Control(0)=   "Frame1(0)"
      Tab(0).Control(1)=   "lstDV"
      Tab(0).Control(2)=   "Frame2"
      Tab(0).ControlCount=   3
      TabCaption(1)   =   "Chuyeân Moân"
      TabPicture(1)   =   "CongTac.frx":045E
      Tab(1).ControlEnabled=   0   'False
      Tab(1).Control(0)=   "Frame3"
      Tab(1).Control(1)=   "lstCM"
      Tab(1).Control(2)=   "Frame1(1)"
      Tab(1).ControlCount=   3
      TabCaption(2)   =   "Chöùc vuï"
      TabPicture(2)   =   "CongTac.frx":047A
      Tab(2).ControlEnabled=   -1  'True
      Tab(2).Control(0)=   "Frame1(2)"
      Tab(2).Control(0).Enabled=   0   'False
      Tab(2).Control(1)=   "Frame4"
      Tab(2).Control(1).Enabled=   0   'False
      Tab(2).Control(2)=   "lstCV"
      Tab(2).Control(2).Enabled=   0   'False
      Tab(2).ControlCount=   3
      Begin MSComctlLib.ListView lstCV 
         Height          =   2655
         Left            =   120
         TabIndex        =   37
         Top             =   2040
         Width           =   5655
         _ExtentX        =   9975
         _ExtentY        =   4683
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
         NumItems        =   2
         BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Text            =   "Maõ chöùc vuï"
            Object.Width           =   3704
         EndProperty
         BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   1
            Text            =   "Teân chöùc vuï"
            Object.Width           =   6174
         EndProperty
      End
      Begin VB.Frame Frame4 
         Height          =   1335
         Left            =   120
         TabIndex        =   32
         Top             =   480
         Width           =   5655
         Begin VB.TextBox txtTenCV 
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
            Left            =   1680
            TabIndex        =   36
            Top             =   720
            Width           =   3735
         End
         Begin VB.TextBox txtMaCV 
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
            Left            =   1680
            MaxLength       =   3
            TabIndex        =   35
            Top             =   240
            Width           =   1215
         End
         Begin VB.Label Label7 
            Alignment       =   1  'Right Justify
            Caption         =   "Teân chöùc vuï :"
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
            TabIndex        =   34
            Top             =   720
            Width           =   1455
         End
         Begin VB.Label Label6 
            Alignment       =   1  'Right Justify
            Caption         =   "Maõ chöùc vuï :"
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
            TabIndex        =   33
            Top             =   240
            Width           =   1455
         End
      End
      Begin VB.Frame Frame1 
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
         Index           =   2
         Left            =   120
         TabIndex        =   26
         Top             =   4680
         Width           =   5655
         Begin VB.CommandButton cmdMoiCV 
            Caption         =   "Môùi"
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
            TabIndex        =   31
            Top             =   360
            Width           =   1095
         End
         Begin VB.CommandButton cmdSuaCV 
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
            Left            =   1320
            TabIndex        =   30
            Top             =   360
            Width           =   975
         End
         Begin VB.CommandButton cmdXoaCV 
            Caption         =   "Xoaù"
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
            Left            =   2400
            TabIndex        =   29
            Top             =   360
            Width           =   975
         End
         Begin VB.CommandButton cmdLuuCV 
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
            Left            =   3480
            TabIndex        =   28
            Top             =   360
            Width           =   975
         End
         Begin VB.CommandButton cmdThoatCV 
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
            Left            =   4560
            TabIndex        =   27
            Top             =   360
            Width           =   975
         End
      End
      Begin VB.Frame Frame1 
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
         Index           =   1
         Left            =   -74880
         TabIndex        =   20
         Top             =   4680
         Width           =   5655
         Begin VB.CommandButton cmdMoiCM 
            Caption         =   "Môùi"
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
            TabIndex        =   25
            Top             =   360
            Width           =   975
         End
         Begin VB.CommandButton cmdSuaCM 
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
            Left            =   1200
            TabIndex        =   24
            Top             =   360
            Width           =   975
         End
         Begin VB.CommandButton cmdXoaCM 
            Caption         =   "Xoaù"
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
            Left            =   2280
            TabIndex        =   23
            Top             =   360
            Width           =   1095
         End
         Begin VB.CommandButton cmdLuuCM 
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
            Left            =   3480
            TabIndex        =   22
            Top             =   360
            Width           =   975
         End
         Begin VB.CommandButton cmdThoatCM 
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
            Left            =   4560
            TabIndex        =   21
            Top             =   360
            Width           =   975
         End
      End
      Begin MSComctlLib.ListView lstCM 
         Height          =   2775
         Left            =   -74880
         TabIndex        =   19
         Top             =   1800
         Width           =   5655
         _ExtentX        =   9975
         _ExtentY        =   4895
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
         NumItems        =   2
         BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Text            =   "Maõ chuyeân moân"
            Object.Width           =   3704
         EndProperty
         BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   1
            Text            =   "Teân chuyeân moân"
            Object.Width           =   6174
         EndProperty
      End
      Begin VB.Frame Frame3 
         Height          =   1215
         Left            =   -74880
         TabIndex        =   14
         Top             =   480
         Width           =   5655
         Begin VB.TextBox txtTenCM 
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
            Left            =   2040
            TabIndex        =   18
            Top             =   720
            Width           =   3495
         End
         Begin VB.TextBox txtMaCM 
            BeginProperty Font 
               Name            =   "VNI-Times"
               Size            =   11.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   435
            Left            =   2040
            MaxLength       =   3
            TabIndex        =   17
            Top             =   240
            Width           =   1335
         End
         Begin VB.Label Label5 
            Alignment       =   1  'Right Justify
            Caption         =   "Teân chuyeân moân :"
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
            Top             =   720
            Width           =   1815
         End
         Begin VB.Label Label4 
            Alignment       =   1  'Right Justify
            Caption         =   "Maõ chuyeân moân :"
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
            Top             =   240
            Width           =   1815
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
         Height          =   1095
         Left            =   -74880
         TabIndex        =   8
         Top             =   4560
         Width           =   5655
         Begin VB.CommandButton cmdMoiDV 
            Caption         =   "Môùi"
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
            Top             =   480
            Width           =   975
         End
         Begin VB.CommandButton cmdSuaDV 
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
            Left            =   1200
            TabIndex        =   12
            Top             =   480
            Width           =   975
         End
         Begin VB.CommandButton cmdXoaDV 
            Caption         =   "Xoaù"
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
            Left            =   2280
            TabIndex        =   11
            Top             =   480
            Width           =   975
         End
         Begin VB.CommandButton cmdLuuDV 
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
            Left            =   3360
            TabIndex        =   10
            Top             =   480
            Width           =   855
         End
         Begin VB.CommandButton cmdThoatDV 
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
            Left            =   4440
            TabIndex        =   9
            Top             =   480
            Width           =   975
         End
      End
      Begin MSComctlLib.ListView lstDV 
         Height          =   2535
         Left            =   -74880
         TabIndex        =   7
         Top             =   1920
         Width           =   5535
         _ExtentX        =   9763
         _ExtentY        =   4471
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
         NumItems        =   2
         BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Text            =   "Maõ ñôn vò"
            Object.Width           =   3528
         EndProperty
         BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   1
            Text            =   "Teân ñôn vò"
            Object.Width           =   6086
         EndProperty
      End
      Begin VB.Frame Frame1 
         Height          =   1215
         Index           =   0
         Left            =   -74880
         TabIndex        =   2
         Top             =   480
         Width           =   5535
         Begin VB.TextBox txtTenDV 
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
            TabIndex        =   6
            Top             =   720
            Width           =   3975
         End
         Begin VB.TextBox txtMaDV 
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
            MaxLength       =   3
            TabIndex        =   5
            Top             =   240
            Width           =   975
         End
         Begin VB.Label Label3 
            Alignment       =   1  'Right Justify
            Caption         =   "Teân Ñôn Vò:"
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
            Width           =   1215
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            Caption         =   "Maõ Ñôn Vò :"
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
            Top             =   240
            Width           =   1215
         End
      End
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFC0&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "COÂNG TAÙC NHAÂN VIEÂN"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   26.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   5895
   End
End
Attribute VB_Name = "frmCongTac"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdLuuCM_Click()
    Dim SQL As String
    Dim MaChuyenMon As String
    Dim TenChuyenMon As String
    Dim Msg As Integer
    MaChuyenMon = Trim(txtMaCM.Text)
    TenChuyenMon = Trim(txtTenCM.Text)
    SQL = "Select MaChuyenMon From tblChuyenMon Where MaChuyenMon=" & MaChuyenMon
    If txtMaCM.Enabled = True Then
        If MaChuyenMon <> "" Then
            If Len(MaChuyenMon) = 3 Then
                If Kt_Text(SQL) = True Then
                    If TenChuyenMon <> "" Then
                        DE.sp_NhapChuyenMon MaChuyenMon, TenChuyenMon
                        disPlayListViewCM
                        txtMaCM.Text = ""
                        txtTenCM.Text = ""
                     Else
                        MsgBox "Ban chua nhap ten chuyen mon", vbInformation
                    End If
                Else
                    MsgBox "Ma chuyen mon nay da co trong co so du lieu", vbCritical
                End If
            Else
                MsgBox "Ma chuyen mon khong hop le", vbCritical
            End If
        Else
            MsgBox "Ban chua nhap ma chuyen mon", vbInformation
        End If
    Else
        If txtTenCM.Enabled = True Then
            If TenChuyenMon <> "" Then
                Msg = MsgBox("Ban co dong y sua chuyen mon khong ?", vbQuestion + vbYesNo)
                If Msg = vbYes Then
                    DE.sp_SuaChuyenMon MaChuyenMon, TenChuyenMon
                    disPlayListViewCM
                End If
            Else
                MsgBox "Ban phai nhap ten chuyen mon", vbInformation
            End If
        End If
    End If
End Sub

Private Sub cmdLuuCV_Click()
    Dim SQL As String
    Dim MaChucVu As String
    Dim TenChucVu As String
    Dim Msg As Integer
    MaChucVu = Trim(txtMaCV.Text)
    TenChucVu = Trim(txtTenCV.Text)
    SQL = "Select MaChucVu From tblChucVu Where MaChucVu=" & MaChucVu
    If txtMaCV.Enabled = True Then
        If MaChucVu <> "" Then
            If Len(MaChucVu) = 3 Then
                If Kt_Text(SQL) = True Then
                    If TenChucVu <> "" Then
                        DE.sp_NhapChucVu MaChucVu, TenChucVu
                        disPlaylistViewCV
                        txtMaCV.Text = ""
                        txtTenCV.Text = ""
                     Else
                        MsgBox "Ban chua nhap ten chuc vu", vbInformation
                    End If
                Else
                    MsgBox "Ma chuc vu nay da co trong co so du lieu", vbCritical
                End If
            Else
                MsgBox "Ma chuc vu khong hop le", vbCritical
            End If
        Else
            MsgBox "Ban chua nhap ma chuc vu", vbInformation
        End If
    Else
        If txtTenCV.Enabled = True Then
            If TenChucVu <> "" Then
                Msg = MsgBox("Ban co dong y sua chuc vu khong ?", vbQuestion + vbYesNo)
                If Msg = vbYes Then
                    DE.sp_SuaChucVu MaChucVu, TenChucVu
                    disPlaylistViewCV
                End If
            Else
                MsgBox "Ban phai nhap ten chuc vu", vbInformation
            End If
        End If
    End If
End Sub

Private Sub cmdLuuDV_Click()
    Dim SQL As String
    Dim MaDonVi As String
    Dim TenDonVi As String
    Dim Msg As Integer
    MaDonVi = Trim(txtMaDV.Text)
    TenDonVi = Trim(txtTenDV.Text)
    SQL = "Select MaDonVi From tblDonVi Where MaDonVi=" & MaDonVi
    If txtMaDV.Enabled = True Then
        If MaDonVi <> "" Then
            If Len(MaDonVi) = 3 Then
                If Kt_Text(SQL) = True Then
                    If TenDonVi <> "" Then
                        DE.sp_NhapDonVi MaDonVi, TenDonVi
                        disPlaylistViewDV
                        txtMaDV.Text = ""
                        txtTenDV.Text = ""
                     Else
                        MsgBox "Ban chua nhap ten don vi", vbInformation
                    End If
                Else
                    MsgBox "Ma don vi nay da co trong co so du lieu", vbCritical
                End If
            Else
                MsgBox "Ma don vi khong hop le", vbCritical
            End If
        Else
            MsgBox "Ban chua nhap ma don vi", vbInformation
        End If
    Else
        If txtTenDV.Enabled = True Then
            If TenDonVi <> "" Then
                Msg = MsgBox("Ban co dong y sua don vi khong ?", vbQuestion + vbYesNo)
                If Msg = vbYes Then
                    DE.sp_SuaDonVi MaDonVi, TenDonVi
                    disPlaylistViewDV
                End If
            Else
                MsgBox "Ban phai nhap ten don vi", vbInformation
            End If
        End If
    End If
End Sub

Private Sub cmdMoiCM_Click()
    txtMaCM.Enabled = True
    txtTenCM.Enabled = True
    txtMaCM.Text = ""
    txtTenCM.Text = ""
    cmdLuuCM.Enabled = True
End Sub

Private Sub cmdMoiCV_Click()
    txtMaCV.Enabled = True
    txtTenCV.Enabled = True
    txtMaCV.Text = ""
    txtTenCV.Text = ""
    cmdLuuCV.Enabled = True
End Sub

Private Sub cmdMoiDV_Click()
    txtMaDV.Enabled = True
    txtTenDV.Enabled = True
    txtMaDV.Text = ""
    txtTenDV.Text = ""
    cmdLuuDV.Enabled = True
End Sub

Private Sub cmdSuaCM_Click()
    cmdLuuCM.Enabled = True
    txtTenCM.Enabled = True
    txtMaCM.Enabled = False
End Sub

Private Sub cmdSuaCV_Click()
    txtTenCV.Enabled = True
    cmdLuuCV.Enabled = True
End Sub

Private Sub cmdSuaDV_Click()
    txtTenDV.Enabled = True
    cmdLuuDV.Enabled = True
End Sub

Private Sub cmdThoatCM_Click()
    Unload Me
End Sub

Private Sub cmdThoatCV_Click()
    Unload Me
End Sub

Private Sub cmdThoatDV_Click()
    Unload Me
End Sub

Private Sub cmdXoaCM_Click()
    Dim Msg As Integer
    Dim MaChuyenMon As String
    Dim TenChuyenMon As String
    MaChuyenMon = Trim(txtMaCM.Text)
    TenChuyenMon = Trim(txtTenCM.Text)
    Msg = MsgBox("Ban co chac chan xoa chuyen mon nay khong", vbQuestion + vbYesNo)
    If Msg = vbYes Then
        DE.sp_XoaChuyenMon MaChuyenMon, TenChuyenMon
        disPlayListViewCM
    End If
    txtMaCM.Enabled = False
    txtTenCM.Enabled = False
    txtMaCM.Text = ""
    txtTenCM.Text = ""
End Sub

Private Sub cmdXoaCV_Click()
    Dim Msg As Integer
    Dim MaChucVu As String
    Dim TenChucVu As String
    MaChucVu = Trim(txtMaCV.Text)
    TenChucVu = Trim(txtTenCV.Text)
    Msg = MsgBox("Ban co chac chan xoa chuc vu nay khong", vbQuestion + vbYesNo)
    If Msg = vbYes Then
        DE.sp_XaoChucVu MaChucVu, TenChucVu
        disPlaylistViewCV
    End If
    txtMaCV.Enabled = False
    txtTenCV.Enabled = False
    txtMaCV.Text = ""
    txtTenCV.Text = ""
End Sub

Private Sub cmdXoaDV_Click()
    Dim Msg As Integer
    Dim MaDonVi As String
    Dim TenDonVi As String
    MaDonVi = Trim(txtMaDV.Text)
    TenDonVi = Trim(txtTenDV.Text)
    Msg = MsgBox("Ban co chac chan xoa nay khong", vbQuestion + vbYesNo)
    If Msg = vbYes Then
        DE.sp_XoaDonVi MaDonVi, TenDonVi
        disPlaylistViewDV
    End If
    txtMaDV.Enabled = False
    txtTenDV.Enabled = False
    txtMaDV.Text = ""
    txtTenDV.Text = ""
End Sub

Private Sub Form_Load()
    cmdMoiCV.Enabled = Flag
    cmdSuaCV.Enabled = Flag
    cmdXoaCV.Enabled = Flag
    cmdMoiDV.Enabled = Flag
    cmdSuaDV.Enabled = Flag
    cmdXoaDV.Enabled = Flag
    cmdMoiCM.Enabled = Flag
    cmdSuaCM.Enabled = Flag
    cmdXoaCM.Enabled = Flag
    '------------------------------------
    cmdLuuCM.Enabled = False
    cmdLuuCV.Enabled = False
    cmdLuuDV.Enabled = False
    txtMaDV.Enabled = False
    txtTenDV.Enabled = False
    txtMaCM.Enabled = False
    txtTenCM.Enabled = False
    txtMaCV.Enabled = False
    txtTenCV.Enabled = False
    '------------------------------------
    disPlaylistViewCV
    disPlayListViewCM
    disPlaylistViewDV
End Sub

Private Sub disPlaylistViewCV()
    Dim rs As ADODB.Recordset
    Dim SQL As String
    Dim mItem As listItem
    lstCV.ListItems.Clear
    SQL = "Select * From tblChucVu "
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstCV.ListItems.Add(, , rs!MaChucVu)
                   mItem.SubItems(1) = rs!TenChucVu
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub disPlayListViewCM()
    Dim rs As ADODB.Recordset
    Dim SQL As String
    Dim mItem As listItem
    lstCM.ListItems.Clear
    SQL = "Select * From tblChuyenMon "
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstCM.ListItems.Add(, , rs!MaChuyenMon)
                   mItem.SubItems(1) = rs!TenChuyenMon
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub disPlaylistViewDV()
    Dim rs As ADODB.Recordset
    Dim SQL As String
    Dim mItem As listItem
    lstDV.ListItems.Clear
    SQL = "Select * From tblDonVi"
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstDV.ListItems.Add(, , rs!MaDonVi)
                   mItem.SubItems(1) = rs!TenDonVi
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub lstCM_ItemClick(ByVal Item As MSComctlLib.listItem)
    txtMaCM.Text = Item.Text
    txtTenCM.Text = Item.SubItems(1)
    txtMaCM.Enabled = False
End Sub

Private Sub lstCV_ItemClick(ByVal Item As MSComctlLib.listItem)
    txtMaCV.Text = Item.Text
    txtTenCV.Text = Item.SubItems(1)
    txtMaCV.Enabled = False
End Sub

Private Sub lstDV_ItemClick(ByVal Item As MSComctlLib.listItem)
    txtMaDV.Text = Item.Text
    txtTenDV.Text = Item.SubItems(1)
    txtMaDV.Enabled = False
End Sub

Private Sub txtMaCM_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub

Private Sub txtMaCV_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub

Private Sub txtMaDV_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub
