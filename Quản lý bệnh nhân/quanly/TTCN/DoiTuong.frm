VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frmDoiTuong 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Doi Tuong"
   ClientHeight    =   6585
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6105
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6585
   ScaleWidth      =   6105
   StartUpPosition =   2  'CenterScreen
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
      Height          =   1695
      Left            =   120
      TabIndex        =   6
      Top             =   1080
      Width           =   5895
      Begin VB.TextBox txtTenDoiTuong 
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
         Left            =   1680
         TabIndex        =   12
         Top             =   960
         Width           =   3375
      End
      Begin VB.TextBox txtMaDoiTuong 
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
         Left            =   1680
         MaxLength       =   3
         TabIndex        =   11
         Top             =   360
         Width           =   495
      End
      Begin VB.Label lblFieldLabel 
         AutoSize        =   -1  'True
         Caption         =   "Ma ñoái töôïng:"
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
         Left            =   240
         TabIndex        =   8
         Top             =   450
         Width           =   1365
      End
      Begin VB.Label lblFieldLabel 
         AutoSize        =   -1  'True
         Caption         =   "Teân ñoái töôïng:"
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
         Left            =   150
         TabIndex        =   7
         Top             =   1065
         Width           =   1440
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
      TabIndex        =   0
      Top             =   5520
      Width           =   5895
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
         Left            =   3720
         TabIndex        =   5
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
         Left            =   4800
         TabIndex        =   4
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
         Left            =   2520
         TabIndex        =   3
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
         Left            =   1320
         TabIndex        =   2
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
         TabIndex        =   1
         ToolTipText     =   "Them du lieu"
         Top             =   360
         Width           =   1095
      End
   End
   Begin MSComctlLib.ListView lstDoiTuong 
      Height          =   2535
      Left            =   120
      TabIndex        =   9
      Top             =   2880
      Width           =   5895
      _ExtentX        =   10398
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
         Text            =   "Maõ ñoái töôïng"
         Object.Width           =   3880
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Teân ñoái töôïng"
         Object.Width           =   6350
      EndProperty
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFC0&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "ÑOÁI TÖÔÏNG"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   27.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Left            =   120
      TabIndex        =   10
      Top             =   120
      Width           =   5895
   End
End
Attribute VB_Name = "frmDoiTuong"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdLuu_Click()
    Dim MaDoiTuong$, TenDoiTuong$
    Dim SQL$
    Dim Msg As Integer
    Dim Ts As Long, Kt As Boolean
    MaDoiTuong = Trim(txtMaDoiTuong)
    TenDoiTuong = Trim(txtTenDoiTuong)
    SQL = "Select * From tbldoituong Where MaDoiTuong= " & Trim(MaDoiTuong)
    If txtMaDoiTuong.Enabled = True And txtTenDoiTuong.Enabled = True Then
        If Len(MaDoiTuong) = 3 Then
            If TenDoiTuong <> "" Then
                Ts = DE.sp_KiemTraDoiTuong(TenDoiTuong, Kt)
                If Kt = False Then
                    If Kt_Text(SQL) = True Then
                        DE.sp_NhapDoiTuong MaDoiTuong, TenDoiTuong
                        txtMaDoiTuong.Text = ""
                        txtTenDoiTuong.Text = ""
                        disPlayListView
                    Else
                        MsgBox "Doi tuong nay da co trong co so du lieu", vbCritical
                    End If
                Else
                    MsgBox "Ten Doi Tuong nay da co moi ban nhap ten khac", vbCritical
                End If
            Else
                MsgBox "Ban chua nhap ten doi tuong", vbInformation
            End If
        Else
            MsgBox "Ma doi tuong khong hop le", vbInformation
        End If
    End If
    If (txtMaDoiTuong.Enabled = False) And (txtTenDoiTuong.Enabled = True) Then
        If TenDoiTuong <> "" Then
            Msg = MsgBox("Ban co chac chan sua ten doi tuong nay khong", vbQuestion + vbYesNo)
            If Msg = vbYes Then
                DE.sp_SuaDoiTuong MaDoiTuong, TenDoiTuong
                disPlayListView
            End If
        Else
            MsgBox "Ban chua nhap ten doi tuong ", vbInformation
        End If
    End If
End Sub

Private Sub cmdMoi_Click()
    txtMaDoiTuong.Enabled = True
    txtTenDoiTuong.Enabled = True
    cmdLuu.Enabled = True
    txtMaDoiTuong.Text = ""
    txtTenDoiTuong.Text = ""
End Sub

Private Sub cmdSua_Click()
    cmdLuu.Enabled = True
    txtMaDoiTuong.Enabled = False
    txtTenDoiTuong.Enabled = True
End Sub

Private Sub cmdThoat_Click()
    Unload Me
End Sub

Private Sub cmdXoa_Click()
    Dim MaDoiTuong As String
    Dim TenDoiTuong As String
    Dim Msg As Integer
    MaDoiTuong = Trim(txtMaDoiTuong)
    TenDoiTuong = Trim(txtTenDoiTuong)
    Msg = MsgBox("Ban co chac chan xo doi tuong nay khong", vbQuestion + vbYesNo)
    If Msg = vbYes Then
        DE.sp_XoaDoiTuong MaDoiTuong, TenDoiTuong
        disPlayListView
    End If
End Sub

Private Sub Form_Load()
    cmdLuu.Enabled = False
    txtMaDoiTuong.Enabled = False
    txtTenDoiTuong.Enabled = False
    '---------------------------------------
    cmdMoi.Enabled = Flag
    cmdSua.Enabled = Flag
    cmdXoa.Enabled = Flag
    disPlayListView
End Sub
Private Sub disPlayListView()
    Dim rs As ADODB.Recordset
    Dim SQL As String
    Dim mItem As listItem
    lstDoiTuong.ListItems.Clear
    SQL = "Select * From tblDoiTuong Order by MaDoiTuong"
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstDoiTuong.ListItems.Add(, , rs!MaDoiTuong)
                   mItem.SubItems(1) = rs!TenDoiTuong
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub lstDoiTuong_ItemClick(ByVal Item As MSComctlLib.listItem)
    txtMaDoiTuong.Enabled = False
    txtMaDoiTuong.Text = Item.Text
    txtTenDoiTuong.Text = Item.SubItems(1)
End Sub

Private Sub txtMaDoiTuong_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub

