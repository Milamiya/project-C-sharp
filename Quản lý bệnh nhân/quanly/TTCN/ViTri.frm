VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frmViTri 
   Caption         =   "Vi tri khma benh"
   ClientHeight    =   6720
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6180
   Icon            =   "ViTri.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   6720
   ScaleWidth      =   6180
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
      TabIndex        =   3
      Top             =   5520
      Width           =   5895
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
         TabIndex        =   8
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
         Left            =   1320
         TabIndex        =   7
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
         Left            =   2520
         TabIndex        =   6
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
         Left            =   4800
         TabIndex        =   5
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
         Left            =   3720
         TabIndex        =   4
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
      Height          =   1695
      Left            =   120
      TabIndex        =   0
      Top             =   1080
      Width           =   5895
      Begin VB.TextBox txtTenViTri 
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
      Begin VB.TextBox txtMaViTri 
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
         Top             =   480
         Width           =   495
      End
      Begin VB.Label lblFieldLabel 
         AutoSize        =   -1  'True
         Caption         =   "Teân vò trí"
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
         TabIndex        =   2
         Top             =   1185
         Width           =   885
      End
      Begin VB.Label lblFieldLabel 
         AutoSize        =   -1  'True
         Caption         =   "Maõ vò trí"
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
         Left            =   360
         TabIndex        =   1
         Top             =   600
         Width           =   1065
      End
   End
   Begin MSComctlLib.ListView lstViTri 
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
         Text            =   "Maõ vò trí"
         Object.Width           =   3880
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Teân vò trí"
         Object.Width           =   6350
      EndProperty
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFC0&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "VÒ TRÍ"
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
Attribute VB_Name = "frmViTri"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdLuu_Click()
    Dim MaViTri As String
    Dim TenViTri As String
    Dim SQL As String
    Dim Msg As Integer
    MaViTri = Trim(txtMaViTri)
    TenViTri = Trim(txtTenViTri)
    SQL = "Select MaViTriKB From tblVitriKB Where MaViTriKB= " & MaViTri
    If txtMaViTri.Enabled = True And txtTenViTri.Enabled = True Then
        If Len(MaViTri) = 3 Then
            If TenViTri <> "" Then
                If Kt_Text(SQL) = True Then
                    DE.sp_NhapViTri MaViTri, TenViTri
                    txtMaViTri.Text = ""
                    txtTenViTri.Text = ""
                    disPlayListView
                Else
                    MsgBox "Vi tri nay da co trong co so du lieu", vbCritical
                End If
            Else
                MsgBox "Ban cha nhap ten vi tri", vbInformation
            End If
        Else
            MsgBox "Ma vi tri khong hop le", vbInformation
        End If
    End If
    If (txtMaViTri.Enabled = False) And (txtTenViTri.Enabled = True) Then
        If TenViTri <> "" Then
            Msg = MsgBox("Ban co chac chan sua ten vi tri nay khong", vbQuestion + vbYesNo)
            If Msg = vbYes Then
                DE.sp_Suavitri MaViTri, TenViTri
                disPlayListView
            End If
        Else
            MsgBox "Ban chua nhap ten vi tri", vbInformation
        End If
    End If
End Sub

Private Sub cmdMoi_Click()
    txtMaViTri.Enabled = True
    txtTenViTri.Enabled = True
    cmdLuu.Enabled = True
    txtMaViTri.Text = ""
    txtTenViTri.Text = ""
End Sub

Private Sub cmdSua_Click()
    cmdLuu.Enabled = True
    txtMaViTri.Enabled = False
    txtTenViTri.Enabled = True
End Sub

Private Sub cmdThoat_Click()
    Unload Me
End Sub

Private Sub cmdXoa_Click()
    Dim MaViTri As String
    Dim TenViTri As String
    Dim Msg As Integer
    MaViTri = Trim(txtMaViTri)
    TenViTri = Trim(txtTenViTri)
    Msg = MsgBox("Ban co chac chan xo vi tri nay khong", vbQuestion + vbYesNo)
    If Msg = vbYes Then
        DE.sp_Xoavitri MaViTri, TenViTri
        disPlayListView
    End If
End Sub

Private Sub Form_Load()
    cmdLuu.Enabled = False
    txtMaViTri.Enabled = False
    txtTenViTri.Enabled = False
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
    lstViTri.ListItems.Clear
    SQL = "Select * From tblViTriKB Order by MaViTriKB"
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstViTri.ListItems.Add(, , rs!MaViTriKB)
                   mItem.SubItems(1) = rs!TenViTriKB
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub lstViTri_ItemClick(ByVal Item As MSComctlLib.listItem)
    txtMaViTri.Enabled = False
    txtMaViTri.Text = Item.Text
    txtTenViTri.Text = Item.SubItems(1)
End Sub

Private Sub txtMaViTri_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub
