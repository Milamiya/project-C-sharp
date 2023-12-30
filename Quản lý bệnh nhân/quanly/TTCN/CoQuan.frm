VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frmCoQuan 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Co Quan"
   ClientHeight    =   7035
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6990
   Icon            =   "CoQuan.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7035
   ScaleWidth      =   6990
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
      Height          =   975
      Left            =   120
      TabIndex        =   5
      Top             =   5880
      Width           =   6735
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
         TabIndex        =   10
         ToolTipText     =   "Them du lieu"
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
         TabIndex        =   9
         Top             =   360
         Width           =   1095
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
         Left            =   2760
         TabIndex        =   8
         Top             =   360
         Width           =   1095
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
         Left            =   5520
         TabIndex        =   7
         Top             =   360
         Width           =   975
      End
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
         Left            =   4200
         TabIndex        =   6
         Top             =   360
         Width           =   975
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Nhaäp thoâng tin"
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
      Top             =   1080
      Width           =   6735
      Begin VB.TextBox txtFax 
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   420
         Left            =   2040
         MaxLength       =   12
         TabIndex        =   16
         Top             =   1800
         Width           =   3375
      End
      Begin VB.TextBox txtDienThoai 
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   420
         Left            =   2040
         MaxLength       =   10
         TabIndex        =   15
         Top             =   1320
         Width           =   3375
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
         Height          =   405
         Left            =   2040
         TabIndex        =   14
         Top             =   840
         Width           =   3375
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
         Height          =   420
         Left            =   2040
         MaxLength       =   5
         TabIndex        =   13
         Top             =   360
         Width           =   855
      End
      Begin VB.Label Label3 
         Alignment       =   1  'Right Justify
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
         Left            =   480
         TabIndex        =   12
         Top             =   1800
         Width           =   1095
      End
      Begin VB.Label Label2 
         Alignment       =   1  'Right Justify
         Caption         =   "Ñieän thoaïi "
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
         Left            =   600
         TabIndex        =   4
         Top             =   1320
         Width           =   1095
      End
      Begin VB.Label lblFieldLabel 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
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
         Height          =   300
         Index           =   1
         Left            =   480
         TabIndex        =   3
         Top             =   840
         Width           =   1200
      End
      Begin VB.Label lblFieldLabel 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
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
         Height          =   300
         Index           =   0
         Left            =   555
         TabIndex        =   2
         Top             =   360
         Width           =   1140
      End
   End
   Begin MSComctlLib.ListView lstCoQuan 
      Height          =   2175
      Left            =   120
      TabIndex        =   11
      Top             =   3720
      Width           =   6735
      _ExtentX        =   11880
      _ExtentY        =   3836
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
      NumItems        =   4
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Maõ cô quan"
         Object.Width           =   2400
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Teân cô quan"
         Object.Width           =   4939
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Ñien thoai"
         Object.Width           =   2539
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "Fax"
         Object.Width           =   2540
      EndProperty
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFC0&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "CÔ QUAN"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   27.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   6735
   End
End
Attribute VB_Name = "frmCoQuan"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim Co$
Private Sub cmdLuu_Click()
    Dim TenCoQuan$, MaCoQuan$, DienThoai$, Fax$
    Dim SQL$, Msg%
    TenCoQuan = Trim(txtTenCoQuan)
    MaCoQuan = Trim(txtMaCoQuan)
    DienThoai = Trim(txtDienThoai)
    Fax = Trim(txtFax)
    If DienThoai = "" Then DienThoai = "Chua Co"
    If Fax = "" Then Fax = "Chua co"
    '===============
    If Co = "Insert" Then
        If MaCoQuan <> "" Then
            If TenCoQuan <> "" Then
                DE.sp_NHapCoQuan MaCoQuan, TenCoQuan, DienThoai, Fax
                disPlayListView
                SetNull
            Else
                MsgBox "Ban chua nhap ten co quan", vbInformation
            End If
        Else
            MsgBox "Ban chua nhap ma co quan", vbInformation
        End If
    Else 'Else Inser
        If Co = "Update" Then
            If TenCoQuan <> "" Then
                Msg = MsgBox("Ban co chac chan sua co quan nay khong", vbYesNo + vbQuestion)
                If Msg = vbYes Then
                    DE.sp_SuaCoQuan MaCoQuan, TenCoQuan, DienThoai, Fax
                    disPlayListView
                    SetNull
                End If
            Else
                MsgBox "Ban chua nhap ten co quan", vbInformation
            End If
        End If
    End If
End Sub

Private Sub cmdMoi_Click()
    cmdLuu.Enabled = True
    txtMaCoQuan.Enabled = True
    txtTenCoQuan.Enabled = True
    txtFax.Enabled = True
    txtDienThoai.Enabled = True
    Co = "Insert"
    SetNull
End Sub

Private Sub cmdSua_Click()
    cmdLuu.Enabled = True
    txtTenCoQuan.Enabled = True
    txtFax.Enabled = True
    txtDienThoai.Enabled = True
    Co = "Update"
End Sub

Private Sub cmdThoat_Click()
    Unload Me
End Sub
Private Sub disPlayListView()
    Dim rs As ADODB.Recordset
    Dim SQL As String
    Dim mItem As listItem
    lstCoQuan.ListItems.Clear
    SQL = "Select * From tblCoQuan Order by MaCoQuan"
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstCoQuan.ListItems.Add(, , rs!MaCoQuan)
                   mItem.SubItems(1) = rs!TenCoQuan
                   mItem.SubItems(2) = rs!DienThoaiCoQuan
                   mItem.SubItems(3) = rs!FaxCoQuan
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub cmdXoa_Click()
    Dim Msg%, MaCoQuan$
    MaCoQuan = Trim(txtMaCoQuan)
    Msg = MsgBox("Ban co chac chan xoa co quan nay khong", vbYesNo + vbQuestion)
    If Msg = vbYes Then
        DE.sp_XoaCoQuan MaCoQuan
        disPlayListView
        SetNull
    End If
End Sub

Private Sub Form_Load()
    disPlayListView
    cmdLuu.Enabled = False
    txtMaCoQuan.Enabled = False
    txtTenCoQuan.Enabled = False
    txtFax.Enabled = False
    txtDienThoai.Enabled = False
    '----------------------------------------
    cmdMoi.Enabled = Flag
    cmdSua.Enabled = Flag
    cmdXoa.Enabled = Flag
End Sub

Private Sub lstCoQuan_ItemClick(ByVal Item As MSComctlLib.listItem)
    txtMaCoQuan.Text = Item.Text
    txtMaCoQuan.Enabled = False
    txtTenCoQuan.Text = Item.SubItems(1)
    txtDienThoai.Text = Item.SubItems(2)
    txtFax.Text = Item.SubItems(3)
End Sub
Private Sub SetNull()
    txtMaCoQuan.Text = ""
    txtTenCoQuan.Text = ""
    txtDienThoai.Text = ""
    txtFax.Text = ""
End Sub

Private Sub txtDienThoai_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub

Private Sub txtFax_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub

Private Sub txtMaCoQuan_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub
