VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frmBenh 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Benh"
   ClientHeight    =   6645
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6135
   Icon            =   "Benh.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6645
   ScaleWidth      =   6135
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
         Height          =   405
         Left            =   1680
         TabIndex        =   12
         Top             =   1080
         Width           =   3375
      End
      Begin VB.TextBox txtMaBenh 
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
         MaxLength       =   5
         TabIndex        =   11
         Top             =   480
         Width           =   855
      End
      Begin VB.Label lblFieldLabel 
         AutoSize        =   -1  'True
         Caption         =   "Maõ beänh"
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
         Left            =   480
         TabIndex        =   8
         Top             =   600
         Width           =   885
      End
      Begin VB.Label lblFieldLabel 
         AutoSize        =   -1  'True
         Caption         =   "Teân beänh"
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
         Left            =   360
         TabIndex        =   7
         Top             =   1185
         Width           =   945
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
   Begin MSComctlLib.ListView lstBenh 
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
         Text            =   "Maõ Beänh"
         Object.Width           =   3880
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Teân beänh"
         Object.Width           =   6350
      EndProperty
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFC0&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "BEÄNH"
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
Attribute VB_Name = "frmBenh"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdLuu_Click()
    Dim MaBenh As String
    Dim TenBenh As String
    Dim SQL As String
    Dim Msg As Integer
    MaBenh = Trim(txtMaBenh)
    TenBenh = Trim(txtTenBenh)
    SQL = "Select * From tblBenh Where MaBenh= " & MaBenh
    If txtMaBenh.Enabled = True And txtTenBenh.Enabled = True Then
        If Len(MaBenh) = 5 Then
            If TenBenh <> "" Then
                If Kt_Text(SQL) = True Then
                    DE.sp_Nhapbenh MaBenh, TenBenh
                    txtMaBenh.Text = ""
                    txtTenBenh.Text = ""
                    disPlayListView
                Else
                    MsgBox "Benh nay da co trong co so du lieu", vbCritical
                End If
            Else
                MsgBox "Ban chua nhap ten benh", vbInformation
            End If
        Else
            MsgBox "Ma benh tuong khong hop le", vbInformation
        End If
    End If
    If (txtMaBenh.Enabled = False) And (txtTenBenh.Enabled = True) Then
        If TenBenh <> "" Then
            Msg = MsgBox("Ban co chac chan sua ten benh nay khong", vbQuestion + vbYesNo)
            If Msg = vbYes Then
                DE.sp_Suabenh MaBenh, TenBenh
                disPlayListView
            End If
        Else
            MsgBox "Ban chua nhap ten benh", vbInformation
        End If
    End If
End Sub

Private Sub cmdMoi_Click()
    txtMaBenh.Enabled = True
    txtTenBenh.Enabled = True
    cmdLuu.Enabled = True
    txtMaBenh.Text = ""
    txtTenBenh.Text = ""
End Sub

Private Sub cmdSua_Click()
    cmdLuu.Enabled = True
    txtMaBenh.Enabled = False
    txtTenBenh.Enabled = True
End Sub

Private Sub cmdThoat_Click()
    Unload Me
End Sub

Private Sub cmdXoa_Click()
    Dim MaBenh As String
    Dim TenBenh As String
    Dim Msg As Integer
    MaBenh = Trim(txtMaBenh)
    TenBenh = Trim(txtTenBenh)
    Msg = MsgBox("Ban co chac chan xo benh nay khong", vbQuestion + vbYesNo)
    If Msg = vbYes Then
        DE.sp_Xoabenh MaBenh, TenBenh
        disPlayListView
    End If
End Sub

Private Sub Form_Load()
    cmdLuu.Enabled = False
    txtMaBenh.Enabled = False
    txtTenBenh.Enabled = False
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
    lstBenh.ListItems.Clear
    SQL = "Select * From tblBenh Order by MaBenh"
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenh.ListItems.Add(, , Trim(rs!MaBenh))
                   mItem.SubItems(1) = rs!TenBenh
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub lstBenh_ItemClick(ByVal Item As MSComctlLib.listItem)
    txtMaBenh.Enabled = False
    txtMaBenh.Text = Item.Text
    txtTenBenh.Text = Item.SubItems(1)
End Sub

Private Sub txtMaBenh_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub
