VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frmTinh1 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Tinh"
   ClientHeight    =   6660
   ClientLeft      =   3585
   ClientTop       =   330
   ClientWidth     =   6045
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   6660
   ScaleMode       =   0  'User
   ScaleWidth      =   6045
   ShowInTaskbar   =   0   'False
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
      TabIndex        =   7
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
         TabIndex        =   12
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
         TabIndex        =   11
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
         TabIndex        =   10
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
         TabIndex        =   9
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
         TabIndex        =   8
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
      TabIndex        =   2
      Top             =   1080
      Width           =   5775
      Begin VB.TextBox txtTenTinh 
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
         Left            =   1320
         TabIndex        =   6
         Top             =   945
         Width           =   3375
      End
      Begin VB.TextBox txtMaTinh 
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
         Left            =   1320
         MaxLength       =   3
         TabIndex        =   4
         Top             =   405
         Width           =   495
      End
      Begin VB.Label lblFieldLabel 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "TenTinh:"
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
         TabIndex        =   5
         Top             =   1065
         Width           =   870
      End
      Begin VB.Label lblFieldLabel 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "MaTinh:"
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
         TabIndex        =   3
         Top             =   450
         Width           =   810
      End
   End
   Begin MSComctlLib.ListView listItem 
      Height          =   2535
      Left            =   120
      TabIndex        =   1
      Top             =   2880
      Width           =   5775
      _ExtentX        =   10186
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
         Text            =   "Maõ Tænh"
         Object.Width           =   3528
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Teân Tænh"
         Object.Width           =   6086
      EndProperty
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFC0&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Tænh"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   27.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   240
      TabIndex        =   13
      Top             =   240
      Width           =   4215
   End
   Begin VB.Label lblLuu 
      Alignment       =   2  'Center
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   4680
      TabIndex        =   0
      Top             =   240
      Width           =   1215
   End
End
Attribute VB_Name = "frmTinh1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdLuu_Click()
    Dim MaTinh As String
    Dim TenTinh As String
    Dim SQL As String
    MaTinh = Trim(txtMaTinh)
    TenTinh = txtTenTinh
    SQL = "Select * From tblTinh Where Matinh= " & Trim(MaTinh)
    If txtTenTinh.Enabled = True And txtMaTinh.Enabled = True Then
        If Len(Trim(MaTinh)) = 3 Then
            If Kt_Text(MaTinh, SQL) = True Then
                DE.NhapTinh txtMaTinh, txtTenTinh
                txtMaTinh.Text = ""
                txtTenTinh.Text = ""
                lblLuu.Caption = luu
                Display_Listview
            Else
                MsgBox "Tinh nay da co trong co so du lieu"
            End If
        Else
            MsgBox "Ma tinh khong hop le"
        End If
    End If
    If (txtMaTinh.Enabled = False) And (txtTenTinh.Enabled = True) Then
        DE.sp_SuaTinh MaTinh, TenTinh
        lblLuu.Caption = luu
        Display_Listview
    End If
End Sub

Private Function Kiem_Tra_DL(strKT As String) As Boolean
    Dim rs As ADODB.Recordset
    Dim Str As String
    Str = "Select MaTinh from tblTinh Where MaTinh=" & strKT
    Set rs = cn.Execute(Str)
    Kiem_Tra_DL = rs.EOF
End Function


Private Sub cmdMoi_Click()
    txtMaTinh.Enabled = True
    txtTenTinh.Enabled = True
    lblLuu.Caption = ""
    txtMaTinh = ""
    txtTenTinh = ""
End Sub

Private Sub cmdSua_Click()
    txtMaTinh.Enabled = False
    lblLuu.Caption = ""
    txtTenTinh.Enabled = True
End Sub

Private Sub cmdThoat_Click()
    Unload Me
End Sub

Private Sub cmdXoa_Click()
    Dim MaTinh As String
    Dim TenTinh As String
    Dim Msg As Integer
    MaTinh = txtMaTinh
    TenTinh = txtTenTinh
    Beep
    lblLuu.Caption = ""
    If MaTinh <> "" Then
        Msg = MsgBox("Ban co chac chan xoa tinh nay khong ?", vbYesNo + vbQuestion)
        If Msg = vbYes Then
            DE.sp_XoaTinh MaTinh, TenTinh
        End If
    Else
        MsgBox "Ban phai chon mot tinh truoc khi xoa", vbCritical + vbOKOnly
    End If
    Display_Listview
End Sub

Private Sub DtTinh_KeyDown(KeyCode As Integer, Shift As Integer)
    KeyCode = 0
End Sub

Private Sub Form_Load()
    If Flag = False Then
        cmdXoa.Enabled = False
        cmdMoi.Enabled = False
        cmdSua.Enabled = False
    End If
    txtMaTinh.Enabled = False
    txtTenTinh.Enabled = False
    cmdLuu.Enabled = False
    Display_Listview
End Sub

Private Sub ListItem_ItemClick(ByVal Item As MSComctlLib.listItem)
    txtMaTinh.Text = Item.Text
    txtTenTinh.Text = Item.SubItems(1)
    txtMaTinh.Enabled = False
    txtTenTinh.Enabled = False
End Sub

Private Sub txtTenTinh_KeyPress(KeyAscii As Integer)
    cmdLuu.Enabled = True
End Sub

Private Sub Display_Listview()
    Dim rs As New ADODB.Recordset
    Dim Str
    Dim mItem As listItem
    listItem.ListItems.Clear
    Str = "select * from tblTinh order by Matinh asc"
    Set rs = cn.Execute(Str) 'Thuc Hien Mot Lenh SQL duoc chi ra boi str
    If rs.EOF = False Then
         While Not rs.EOF
               Set mItem = listItem.ListItems.Add(, , rs!MaTinh)
               mItem.SubItems(1) = rs!TenTinh
               rs.MoveNext
        Wend
    End If
End Sub
